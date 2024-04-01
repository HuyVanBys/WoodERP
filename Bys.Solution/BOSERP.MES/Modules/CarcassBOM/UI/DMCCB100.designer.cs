using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;




namespace BOSERP.Modules.CarcassBOM.UI
{
	/// <summary>
	/// Summary description for DMCCB100
	/// </summary>
	partial class DMCCB100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCCB100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_cbbBOMStatus = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel44 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel40 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel39 = new BOSComponent.BOSLabel(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fld_lkeShowProductNotBOM = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeShowProductHasBOM = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_cbbBOMType = new BOSComponent.BOSComboBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductCarcass = new BOSERP.Modules.CarcassBOM.ICProductCarcasssGridControl();
            this.CarrcassBOMPage = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl4 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel7 = new BOSComponent.BOSPanel(this.components);
            this.bosButton7 = new BOSComponent.BOSButton(this.components);
            this.bosButton4 = new BOSComponent.BOSButton(this.components);
            this.fld_btnApprovedAll = new BOSComponent.BOSButton(this.components);
            this.fld_btnUnCanceled = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeMMProductionNormColorProccessStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMProductionNormCarcassProccessStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnEditMMProductionNormColorProccessStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnGetDefualtProcess = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormCarcassProccessStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormColorProccessStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditMMProductionNormCarcassProccessStatus = new BOSComponent.BOSButton(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteICProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel60 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormOverallSize = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionNormPromulgateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMProductionNormVersion = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionNormBlock = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormTotalPaint = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMProductionNormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_tcDetailInfo = new BOSComponent.BOSTabControl(this.components);
            this.tpSemiProducts = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel8 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnPrintMaterial = new BOSComponent.BOSButton(this.components);
            this.bosLabel51 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel50 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductIdentifyWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICProducts = new BOSERP.Modules.CarcassBOM.SemiProductsGridControl();
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            this.fld_txtDepreciationRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeChooseSemi = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCoppyCarcassSemiProduct = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeCarcassForCopy = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_radPropertiesOrProcess = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_btnUpdatePaint = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.tpProductStructure = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel4 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSaveBOMTree = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreateBOM = new BOSComponent.BOSButton(this.components);
            this.fld_trlICProductItems = new BOSERP.Modules.CarcassBOM.ProductItemsTreeListControl();
            this.fld_tabPackageNo = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pnlPackageDetail = new System.Windows.Forms.Panel();
            this.bosLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_splTicket = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine8 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductPackages = new BOSERP.Modules.CarcassBOM.ICProductPackagesGridControl();
            this.bosLine9 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMMProductionNormItemPackings = new BOSERP.Modules.CarcassBOM.MMProductionNormItemPackingsGridControl();
            this.fld_btnSavePackeNo = new BOSComponent.BOSButton(this.components);
            this.fld_lblHeigth = new BOSComponent.BOSLabel(this.components);
            this.bosLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblWidth = new BOSComponent.BOSLabel(this.components);
            this.bosLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLength = new BOSComponent.BOSLabel(this.components);
            this.bosLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblVolumn = new BOSComponent.BOSLabel(this.components);
            this.tpBOM = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel5 = new BOSComponent.BOSPanel(this.components);
            this.fld_tcBOM = new BOSComponent.BOSTabControl(this.components);
            this.fld_tpSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel9 = new BOSComponent.BOSPanel(this.components);
            this.bosButton6 = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrintSemiProduct = new BOSComponent.BOSButton(this.components);
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_btnEditMMProductionNormWoodStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormWoodStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormWoodStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_trlProductionNormItemTreeList = new BOSERP.Modules.CarcassBOM.ProductionNormItemsTreeListControl();
            this.fld_btnSaveBOM = new BOSComponent.BOSButton(this.components);
            this.fld_tpHardware = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel10 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtDepreciationRateHardware = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel52 = new BOSComponent.BOSLabel(this.components);
            this.bosLine12 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCopyHW = new BOSComponent.BOSButton(this.components);
            this.bosLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHWBomTemp = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnHardware = new BOSComponent.BOSButton(this.components);
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.bosMemoEdit2 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_btnEditMMProductionNormHardwareStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormHardwareStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormHardwareStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductHardwareID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSaveHardware = new BOSComponent.BOSButton(this.components);
            this.fld_btnChangeHardware = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMProductionNormItemsHardware = new BOSERP.Modules.CarcassBOM.ProductionNormItemsHardwareTreeListControl();
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_tpPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pnlPaint = new BOSComponent.BOSPanel(this.components);
            this.fld_txtDepreciationRateIngredientPaint = new BOSComponent.BOSTextBox(this.components);
            this.bosLine14 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCopyPaint = new BOSComponent.BOSButton(this.components);
            this.bosLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkePaintTemp = new BOSComponent.BOSLookupEdit(this.components);
            this.bosButton5 = new BOSComponent.BOSButton(this.components);
            this.bosLabel53 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrintPaint = new BOSComponent.BOSButton(this.components);
            this.bosLine10 = new BOSComponent.BOSLine(this.components);
            this.bosMemoEdit3 = new BOSComponent.BOSMemoEdit(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMProductionNormItemHavePaint = new BOSERP.Modules.CarcassBOM.MMProductionNormItemHavePaintGridControl();
            this.fld_btnViewDetailPain = new BOSComponent.BOSButton(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlMMProductionNormItemsPaint = new BOSERP.Modules.CarcassBOM.ProductionNormItemsPaintTreeListControl();
            this.fld_btnEditMMProductionNormPaintStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormPaintStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormPaintStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSavePaint = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductIngredientPaintID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMPaintProcessesID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_tpPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel13 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtDepreciationRateIngredientPackaging = new BOSComponent.BOSTextBox(this.components);
            this.fld_tlcProctionNormItemPackings = new BOSERP.Modules.CarcassBOM.ProductionNormItemsPackagingTreeListControl();
            this.bosLabel54 = new BOSComponent.BOSLabel(this.components);
            this.bosLine13 = new BOSComponent.BOSLine(this.components);
            this.fld_btnPackCopy = new BOSComponent.BOSButton(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkePackTemp = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnPrintPLDG = new BOSComponent.BOSButton(this.components);
            this.bosLine11 = new BOSComponent.BOSLine(this.components);
            this.bosMemoEdit4 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_radPackaging = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_lkeICProductPackaging = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnEditMMProductionNormPackingMaterialStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormPackingMaterialStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormPackingMaterialStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationPackaging = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSavePackaging = new BOSComponent.BOSButton(this.components);
            this.fld_tpOther = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel11 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtDepreciationRateGeneralMaterial = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel55 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrintVTK = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditMMProductionNormGeneralMaterialStatus = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus = new BOSComponent.BOSButton(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormGeneralMaterialStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeOperationGeneralMaterial = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductMaterialID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSaveOther = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionNormItems = new BOSERP.Modules.CarcassBOM.MMProductionNormItemsGridControl();
            this.fld_btnUpdateFromConfigMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_lblMaterialProduct = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel6 = new BOSComponent.BOSPanel(this.components);
            this.fld_lvImageList = new System.Windows.Forms.ListView();
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadProposalTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_xtpProfile = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProfile = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProfileManagementItems = new BOSERP.Modules.CarcassBOM.ProfileManagementItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbBOMStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShowProductNotBOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShowProductHasBOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbBOMType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCarcass)).BeginInit();
            this.CarrcassBOMPage.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl4)).BeginInit();
            this.bosTabControl4.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            this.bosPanel7.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormColorProccessStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormCarcassProccessStatus.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOverallSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormTotalPaint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcDetailInfo)).BeginInit();
            this.fld_tcDetailInfo.SuspendLayout();
            this.tpSemiProducts.SuspendLayout();
            this.bosPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRate.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeChooseSemi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCarcassForCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPropertiesOrProcess.Properties)).BeginInit();
            this.tpProductStructure.SuspendLayout();
            this.bosPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductItems)).BeginInit();
            this.fld_tabPackageNo.SuspendLayout();
            this.fld_pnlPackageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket.Panel1)).BeginInit();
            this.fld_splTicket.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket.Panel2)).BeginInit();
            this.fld_splTicket.Panel2.SuspendLayout();
            this.fld_splTicket.SuspendLayout();
            this.bosLine8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackages)).BeginInit();
            this.bosLine9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemPackings)).BeginInit();
            this.tpBOM.SuspendLayout();
            this.bosPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcBOM)).BeginInit();
            this.fld_tcBOM.SuspendLayout();
            this.fld_tpSemiProduct.SuspendLayout();
            this.bosPanel9.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormWoodStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductionNormItemTreeList)).BeginInit();
            this.fld_tpHardware.SuspendLayout();
            this.bosPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateHardware.Properties)).BeginInit();
            this.bosLine12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHWBomTemp.Properties)).BeginInit();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormHardwareStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).BeginInit();
            this.fld_tpPaint.SuspendLayout();
            this.fld_pnlPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateIngredientPaint.Properties)).BeginInit();
            this.bosLine14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePaintTemp.Properties)).BeginInit();
            this.bosLine10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemHavePaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPaintStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesID.Properties)).BeginInit();
            this.fld_tpPackaging.SuspendLayout();
            this.bosPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateIngredientPackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tlcProctionNormItemPackings)).BeginInit();
            this.bosLine13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackTemp.Properties)).BeginInit();
            this.bosLine11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPackingMaterialStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationPackaging.Properties)).BeginInit();
            this.fld_tpOther.SuspendLayout();
            this.bosPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateGeneralMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeOperationGeneralMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).BeginInit();
            this.xtraTabPage9.SuspendLayout();
            this.bosPanel6.SuspendLayout();
            this.fld_xtpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProfileManagementItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(2330, 925);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(2330, 925);
            this.bosTabControl1.TabIndex = 0;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.CarrcassBOMPage});
            this.bosTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.bosTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPanel2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(2328, 900);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoScroll = true;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_cbbBOMStatus);
            this.bosPanel2.Controls.Add(this.bosLabel44);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel2.Controls.Add(this.fld_lkeProductID);
            this.bosPanel2.Controls.Add(this.fld_lkeBRBranchID);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLine5);
            this.bosPanel2.Controls.Add(this.fld_lkeShowProductNotBOM);
            this.bosPanel2.Controls.Add(this.fld_lkeShowProductHasBOM);
            this.bosPanel2.Controls.Add(this.bosLabel35);
            this.bosPanel2.Controls.Add(this.fld_lkeICProductGroup);
            this.bosPanel2.Controls.Add(this.fld_cbbBOMType);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.bosLabel31);
            this.bosPanel2.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosPanel2.Controls.Add(this.bosLabel33);
            this.bosPanel2.Controls.Add(this.bosButton1);
            this.bosPanel2.Controls.Add(this.bosGroupControl1);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(2328, 900);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_cbbBOMStatus
            // 
            this.fld_cbbBOMStatus.Location = new System.Drawing.Point(586, 14);
            this.fld_cbbBOMStatus.Name = "fld_cbbBOMStatus";
            this.fld_cbbBOMStatus.Properties.AllowMultiSelect = true;
            this.fld_cbbBOMStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbbBOMStatus.Properties.DropDownRows = 20;
            this.fld_cbbBOMStatus.Size = new System.Drawing.Size(274, 20);
            this.fld_cbbBOMStatus.TabIndex = 492;
            // 
            // bosLabel44
            // 
            this.bosLabel44.BOSComment = null;
            this.bosLabel44.BOSDataMember = null;
            this.bosLabel44.BOSDataSource = null;
            this.bosLabel44.BOSDescription = null;
            this.bosLabel44.BOSError = null;
            this.bosLabel44.BOSFieldGroup = null;
            this.bosLabel44.BOSFieldRelation = null;
            this.bosLabel44.BOSPrivilege = null;
            this.bosLabel44.BOSPropertyName = null;
            this.bosLabel44.Location = new System.Drawing.Point(506, 17);
            this.bosLabel44.Name = "bosLabel44";
            this.bosLabel44.Screen = null;
            this.bosLabel44.Size = new System.Drawing.Size(74, 13);
            this.bosLabel44.TabIndex = 491;
            this.bosLabel44.Text = "Trạng thái BOM";
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
            this.bosLabel1.Location = new System.Drawing.Point(258, 69);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 489;
            this.bosLabel1.Text = "Khách hàng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICProducts";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(340, 66);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 479;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_lkeProductID
            // 
            this.fld_lkeProductID.BOSAllowAddNew = false;
            this.fld_lkeProductID.BOSAllowDummy = true;
            this.fld_lkeProductID.BOSComment = null;
            this.fld_lkeProductID.BOSDataMember = "ICProductID";
            this.fld_lkeProductID.BOSDataSource = "ICProducts";
            this.fld_lkeProductID.BOSDescription = null;
            this.fld_lkeProductID.BOSError = null;
            this.fld_lkeProductID.BOSFieldGroup = null;
            this.fld_lkeProductID.BOSFieldParent = null;
            this.fld_lkeProductID.BOSFieldRelation = null;
            this.fld_lkeProductID.BOSPrivilege = null;
            this.fld_lkeProductID.BOSPropertyName = "EditValue";
            this.fld_lkeProductID.BOSSelectType = "ICProductType";
            this.fld_lkeProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeProductID.CurrentDisplayText = null;
            this.fld_lkeProductID.Location = new System.Drawing.Point(340, 40);
            this.fld_lkeProductID.MenuManager = this.screenToolbar;
            this.fld_lkeProductID.Name = "fld_lkeProductID";
            this.fld_lkeProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductID.Properties.ColumnName = null;
            this.fld_lkeProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeProductID.Screen = null;
            this.fld_lkeProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeProductID.TabIndex = 477;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = "";
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = "";
            this.fld_lkeBRBranchID.BOSFieldParent = "";
            this.fld_lkeBRBranchID.BOSFieldRelation = "";
            this.fld_lkeBRBranchID.BOSPrivilege = "";
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = "";
            this.fld_lkeBRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeBRBranchID.CurrentDisplayText = "";
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(93, 14);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = "";
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 473;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(14, 17);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 487;
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLabel6);
            this.bosLine5.Controls.Add(this.button1);
            this.bosLine5.Controls.Add(this.bosLabel41);
            this.bosLine5.Controls.Add(this.bosLabel40);
            this.bosLine5.Controls.Add(this.bosLabel39);
            this.bosLine5.Controls.Add(this.button4);
            this.bosLine5.Controls.Add(this.button2);
            this.bosLine5.Controls.Add(this.button5);
            this.bosLine5.Location = new System.Drawing.Point(877, 3);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(190, 85);
            this.bosLine5.TabIndex = 486;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Chú thích";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(59, 66);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(115, 12);
            this.bosLabel6.TabIndex = 33;
            this.bosLabel6.Text = "BOM đã ngừng sử dụng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 15);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel41.Appearance.Options.UseFont = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(59, 32);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(82, 12);
            this.bosLabel41.TabIndex = 31;
            this.bosLabel41.Text = "BOM chưa duyệt";
            // 
            // bosLabel40
            // 
            this.bosLabel40.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel40.Appearance.Options.UseFont = true;
            this.bosLabel40.BOSComment = null;
            this.bosLabel40.BOSDataMember = null;
            this.bosLabel40.BOSDataSource = null;
            this.bosLabel40.BOSDescription = null;
            this.bosLabel40.BOSError = null;
            this.bosLabel40.BOSFieldGroup = null;
            this.bosLabel40.BOSFieldRelation = null;
            this.bosLabel40.BOSPrivilege = null;
            this.bosLabel40.BOSPropertyName = null;
            this.bosLabel40.Location = new System.Drawing.Point(59, 49);
            this.bosLabel40.Name = "bosLabel40";
            this.bosLabel40.Screen = null;
            this.bosLabel40.Size = new System.Drawing.Size(70, 12);
            this.bosLabel40.TabIndex = 30;
            this.bosLabel40.Text = "BOM đã duyệt";
            // 
            // bosLabel39
            // 
            this.bosLabel39.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel39.Appearance.Options.UseFont = true;
            this.bosLabel39.BOSComment = null;
            this.bosLabel39.BOSDataMember = null;
            this.bosLabel39.BOSDataSource = null;
            this.bosLabel39.BOSDescription = null;
            this.bosLabel39.BOSError = null;
            this.bosLabel39.BOSFieldGroup = null;
            this.bosLabel39.BOSFieldRelation = null;
            this.bosLabel39.BOSPrivilege = null;
            this.bosLabel39.BOSPropertyName = null;
            this.bosLabel39.Location = new System.Drawing.Point(59, 15);
            this.bosLabel39.Name = "bosLabel39";
            this.bosLabel39.Screen = null;
            this.bosLabel39.Size = new System.Drawing.Size(121, 12);
            this.bosLabel39.TabIndex = 29;
            this.bosLabel39.Text = "Sản phẩm chưa tạo BOM";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button4.Location = new System.Drawing.Point(12, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 15);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button2.Location = new System.Drawing.Point(12, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 15);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button5.Location = new System.Drawing.Point(12, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 15);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // fld_lkeShowProductNotBOM
            // 
            this.fld_lkeShowProductNotBOM.BOSComment = null;
            this.fld_lkeShowProductNotBOM.BOSDataMember = null;
            this.fld_lkeShowProductNotBOM.BOSDataSource = null;
            this.fld_lkeShowProductNotBOM.BOSDescription = null;
            this.fld_lkeShowProductNotBOM.BOSError = null;
            this.fld_lkeShowProductNotBOM.BOSFieldGroup = null;
            this.fld_lkeShowProductNotBOM.BOSFieldRelation = null;
            this.fld_lkeShowProductNotBOM.BOSPrivilege = null;
            this.fld_lkeShowProductNotBOM.BOSPropertyName = null;
            this.fld_lkeShowProductNotBOM.Location = new System.Drawing.Point(536, 66);
            this.fld_lkeShowProductNotBOM.MenuManager = this.screenToolbar;
            this.fld_lkeShowProductNotBOM.Name = "fld_lkeShowProductNotBOM";
            this.fld_lkeShowProductNotBOM.Properties.Caption = "Chỉ hiển thị sản phẩm chưa có BOM";
            this.fld_lkeShowProductNotBOM.Screen = null;
            this.fld_lkeShowProductNotBOM.Size = new System.Drawing.Size(197, 20);
            this.fld_lkeShowProductNotBOM.TabIndex = 482;
            this.fld_lkeShowProductNotBOM.CheckedChanged += new System.EventHandler(this.fld_lkeShowProductNotBOM_CheckedChanged);
            // 
            // fld_lkeShowProductHasBOM
            // 
            this.fld_lkeShowProductHasBOM.BOSComment = null;
            this.fld_lkeShowProductHasBOM.BOSDataMember = null;
            this.fld_lkeShowProductHasBOM.BOSDataSource = null;
            this.fld_lkeShowProductHasBOM.BOSDescription = null;
            this.fld_lkeShowProductHasBOM.BOSError = null;
            this.fld_lkeShowProductHasBOM.BOSFieldGroup = null;
            this.fld_lkeShowProductHasBOM.BOSFieldRelation = null;
            this.fld_lkeShowProductHasBOM.BOSPrivilege = null;
            this.fld_lkeShowProductHasBOM.BOSPropertyName = null;
            this.fld_lkeShowProductHasBOM.EditValue = true;
            this.fld_lkeShowProductHasBOM.Location = new System.Drawing.Point(536, 40);
            this.fld_lkeShowProductHasBOM.MenuManager = this.screenToolbar;
            this.fld_lkeShowProductHasBOM.Name = "fld_lkeShowProductHasBOM";
            this.fld_lkeShowProductHasBOM.Properties.Caption = "Chỉ hiển thị sản phẩm có BOM";
            this.fld_lkeShowProductHasBOM.Screen = null;
            this.fld_lkeShowProductHasBOM.Size = new System.Drawing.Size(197, 20);
            this.fld_lkeShowProductHasBOM.TabIndex = 480;
            this.fld_lkeShowProductHasBOM.CheckedChanged += new System.EventHandler(this.fld_lkeShowProductHasBOM_CheckedChanged);
            // 
            // bosLabel35
            // 
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(258, 17);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(54, 13);
            this.bosLabel35.TabIndex = 485;
            this.bosLabel35.Text = "Nhóm hàng";
            // 
            // fld_lkeICProductGroup
            // 
            this.fld_lkeICProductGroup.BOSAllowAddNew = false;
            this.fld_lkeICProductGroup.BOSAllowDummy = true;
            this.fld_lkeICProductGroup.BOSComment = null;
            this.fld_lkeICProductGroup.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroup.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroup.BOSDescription = null;
            this.fld_lkeICProductGroup.BOSError = null;
            this.fld_lkeICProductGroup.BOSFieldGroup = null;
            this.fld_lkeICProductGroup.BOSFieldParent = null;
            this.fld_lkeICProductGroup.BOSFieldRelation = null;
            this.fld_lkeICProductGroup.BOSPrivilege = null;
            this.fld_lkeICProductGroup.BOSPropertyName = null;
            this.fld_lkeICProductGroup.BOSSelectType = null;
            this.fld_lkeICProductGroup.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroup.CurrentDisplayText = null;
            this.fld_lkeICProductGroup.Location = new System.Drawing.Point(340, 14);
            this.fld_lkeICProductGroup.MenuManager = this.screenToolbar;
            this.fld_lkeICProductGroup.Name = "fld_lkeICProductGroup";
            this.fld_lkeICProductGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroup.Properties.ColumnName = null;
            this.fld_lkeICProductGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên")});
            this.fld_lkeICProductGroup.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroup.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroup.Screen = null;
            this.fld_lkeICProductGroup.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductGroup.TabIndex = 474;
            // 
            // fld_cbbBOMType
            // 
            this.fld_cbbBOMType.BOSComment = null;
            this.fld_cbbBOMType.BOSDataMember = null;
            this.fld_cbbBOMType.BOSDataSource = null;
            this.fld_cbbBOMType.BOSDescription = null;
            this.fld_cbbBOMType.BOSError = null;
            this.fld_cbbBOMType.BOSFieldGroup = null;
            this.fld_cbbBOMType.BOSFieldRelation = null;
            this.fld_cbbBOMType.BOSPrivilege = null;
            this.fld_cbbBOMType.BOSPropertyName = null;
            this.fld_cbbBOMType.Location = new System.Drawing.Point(93, 40);
            this.fld_cbbBOMType.MenuManager = this.screenToolbar;
            this.fld_cbbBOMType.Name = "fld_cbbBOMType";
            this.fld_cbbBOMType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbbBOMType.Properties.Items.AddRange(new object[] {
            "",
            "Hàng mẫu",
            "Hàng màu"});
            this.fld_cbbBOMType.Screen = null;
            this.fld_cbbBOMType.Size = new System.Drawing.Size(150, 20);
            this.fld_cbbBOMType.TabIndex = 476;
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
            this.bosLabel7.Location = new System.Drawing.Point(14, 43);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(19, 13);
            this.bosLabel7.TabIndex = 483;
            this.bosLabel7.Text = "Loại";
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
            this.bosLabel31.Location = new System.Drawing.Point(14, 69);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(68, 13);
            this.bosLabel31.TabIndex = 481;
            this.bosLabel31.Text = "Lệnh sản xuất";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = null;
            this.fld_lkeMMBatchProductID.BOSSelectType = null;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(93, 66);
            this.fld_lkeMMBatchProductID.MenuManager = this.screenToolbar;
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "LSX")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 478;
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
            this.bosLabel33.Location = new System.Drawing.Point(258, 43);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(67, 13);
            this.bosLabel33.TabIndex = 475;
            this.bosLabel33.Text = "Tên sản phẩm";
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
            this.bosButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bosButton1.ImageOptions.Image")));
            this.bosButton1.Location = new System.Drawing.Point(749, 45);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(111, 38);
            this.bosButton1.TabIndex = 484;
            this.bosButton1.Text = "Tìm kiếm     ";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcICProductCarcass);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 94);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(2321, 779);
            this.bosGroupControl1.TabIndex = 22;
            this.bosGroupControl1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcICProductCarcass
            // 
            this.fld_dgcICProductCarcass.BOSComment = null;
            this.fld_dgcICProductCarcass.BOSDataMember = null;
            this.fld_dgcICProductCarcass.BOSDataSource = "ICProducts";
            this.fld_dgcICProductCarcass.BOSDescription = null;
            this.fld_dgcICProductCarcass.BOSError = null;
            this.fld_dgcICProductCarcass.BOSFieldGroup = null;
            this.fld_dgcICProductCarcass.BOSFieldRelation = null;
            this.fld_dgcICProductCarcass.BOSGridType = null;
            this.fld_dgcICProductCarcass.BOSPrivilege = null;
            this.fld_dgcICProductCarcass.BOSPropertyName = null;
            this.fld_dgcICProductCarcass.CommodityType = "";
            this.fld_dgcICProductCarcass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductCarcass.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductCarcass.MenuManager = this.screenToolbar;
            this.fld_dgcICProductCarcass.Name = "fld_dgcICProductCarcass";
            this.fld_dgcICProductCarcass.PrintReport = false;
            this.fld_dgcICProductCarcass.Screen = null;
            this.fld_dgcICProductCarcass.Size = new System.Drawing.Size(2317, 754);
            this.fld_dgcICProductCarcass.TabIndex = 0;
            // 
            // CarrcassBOMPage
            // 
            this.CarrcassBOMPage.Controls.Add(this.bosPanel3);
            this.CarrcassBOMPage.Name = "CarrcassBOMPage";
            this.CarrcassBOMPage.Size = new System.Drawing.Size(2314, 893);
            this.CarrcassBOMPage.Text = "Định mức";
            // 
            // bosPanel3
            // 
            this.bosPanel3.AutoScroll = true;
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosTabControl4);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(2314, 893);
            this.bosPanel3.TabIndex = 0;
            // 
            // bosTabControl4
            // 
            this.bosTabControl4.BOSComment = null;
            this.bosTabControl4.BOSDataMember = null;
            this.bosTabControl4.BOSDataSource = null;
            this.bosTabControl4.BOSDescription = null;
            this.bosTabControl4.BOSError = null;
            this.bosTabControl4.BOSFieldGroup = null;
            this.bosTabControl4.BOSFieldRelation = null;
            this.bosTabControl4.BOSPrivilege = null;
            this.bosTabControl4.BOSPropertyName = null;
            this.bosTabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl4.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl4.Name = "bosTabControl4";
            this.bosTabControl4.Screen = null;
            this.bosTabControl4.SelectedTabPage = this.xtraTabPage8;
            this.bosTabControl4.Size = new System.Drawing.Size(2314, 893);
            this.bosTabControl4.TabIndex = 2;
            this.bosTabControl4.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage8,
            this.xtraTabPage9,
            this.fld_xtpProfile});
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.bosPanel7);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(2312, 868);
            this.xtraTabPage8.Text = "Thông tin";
            // 
            // bosPanel7
            // 
            this.bosPanel7.AutoScroll = true;
            this.bosPanel7.BOSComment = null;
            this.bosPanel7.BOSDataMember = null;
            this.bosPanel7.BOSDataSource = null;
            this.bosPanel7.BOSDescription = null;
            this.bosPanel7.BOSError = null;
            this.bosPanel7.BOSFieldGroup = null;
            this.bosPanel7.BOSFieldRelation = null;
            this.bosPanel7.BOSPrivilege = null;
            this.bosPanel7.BOSPropertyName = null;
            this.bosPanel7.Controls.Add(this.bosButton7);
            this.bosPanel7.Controls.Add(this.bosButton4);
            this.bosPanel7.Controls.Add(this.fld_btnApprovedAll);
            this.bosPanel7.Controls.Add(this.fld_btnUnCanceled);
            this.bosPanel7.Controls.Add(this.fld_btnCancel);
            this.bosPanel7.Controls.Add(this.bosLine4);
            this.bosPanel7.Controls.Add(this.bosLine3);
            this.bosPanel7.Controls.Add(this.bosLine1);
            this.bosPanel7.Controls.Add(this.fld_tcDetailInfo);
            this.bosPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel7.Location = new System.Drawing.Point(0, 0);
            this.bosPanel7.Name = "bosPanel7";
            this.bosPanel7.Screen = null;
            this.bosPanel7.Size = new System.Drawing.Size(2312, 868);
            this.bosPanel7.TabIndex = 25;
            // 
            // bosButton7
            // 
            this.bosButton7.BOSComment = null;
            this.bosButton7.BOSDataMember = null;
            this.bosButton7.BOSDataSource = null;
            this.bosButton7.BOSDescription = null;
            this.bosButton7.BOSError = null;
            this.bosButton7.BOSFieldGroup = null;
            this.bosButton7.BOSFieldRelation = null;
            this.bosButton7.BOSPrivilege = null;
            this.bosButton7.BOSPropertyName = null;
            this.bosButton7.Location = new System.Drawing.Point(1248, 116);
            this.bosButton7.Name = "bosButton7";
            this.bosButton7.Screen = null;
            this.bosButton7.Size = new System.Drawing.Size(94, 27);
            this.bosButton7.TabIndex = 156;
            this.bosButton7.Text = "In M2";
            this.bosButton7.Click += new System.EventHandler(this.bosButton7_Click);
            // 
            // bosButton4
            // 
            this.bosButton4.BOSComment = null;
            this.bosButton4.BOSDataMember = null;
            this.bosButton4.BOSDataSource = null;
            this.bosButton4.BOSDescription = null;
            this.bosButton4.BOSError = null;
            this.bosButton4.BOSFieldGroup = null;
            this.bosButton4.BOSFieldRelation = null;
            this.bosButton4.BOSPrivilege = null;
            this.bosButton4.BOSPropertyName = null;
            this.bosButton4.Location = new System.Drawing.Point(1148, 116);
            this.bosButton4.Name = "bosButton4";
            this.bosButton4.Screen = null;
            this.bosButton4.Size = new System.Drawing.Size(94, 27);
            this.bosButton4.TabIndex = 155;
            this.bosButton4.Text = "In";
            this.bosButton4.Click += new System.EventHandler(this.bosButton4_Click_1);
            // 
            // fld_btnApprovedAll
            // 
            this.fld_btnApprovedAll.BOSComment = null;
            this.fld_btnApprovedAll.BOSDataMember = null;
            this.fld_btnApprovedAll.BOSDataSource = null;
            this.fld_btnApprovedAll.BOSDescription = null;
            this.fld_btnApprovedAll.BOSError = null;
            this.fld_btnApprovedAll.BOSFieldGroup = null;
            this.fld_btnApprovedAll.BOSFieldRelation = null;
            this.fld_btnApprovedAll.BOSPrivilege = null;
            this.fld_btnApprovedAll.BOSPropertyName = null;
            this.fld_btnApprovedAll.Location = new System.Drawing.Point(948, 116);
            this.fld_btnApprovedAll.Name = "fld_btnApprovedAll";
            this.fld_btnApprovedAll.Screen = null;
            this.fld_btnApprovedAll.Size = new System.Drawing.Size(94, 27);
            this.fld_btnApprovedAll.TabIndex = 154;
            this.fld_btnApprovedAll.Text = "Duyệt tất cả";
            this.fld_btnApprovedAll.Click += new System.EventHandler(this.fld_btnApprovedAll_Click);
            // 
            // fld_btnUnCanceled
            // 
            this.fld_btnUnCanceled.BOSComment = null;
            this.fld_btnUnCanceled.BOSDataMember = null;
            this.fld_btnUnCanceled.BOSDataSource = null;
            this.fld_btnUnCanceled.BOSDescription = null;
            this.fld_btnUnCanceled.BOSError = null;
            this.fld_btnUnCanceled.BOSFieldGroup = null;
            this.fld_btnUnCanceled.BOSFieldRelation = null;
            this.fld_btnUnCanceled.BOSPrivilege = null;
            this.fld_btnUnCanceled.BOSPropertyName = null;
            this.fld_btnUnCanceled.Location = new System.Drawing.Point(1348, 116);
            this.fld_btnUnCanceled.Name = "fld_btnUnCanceled";
            this.fld_btnUnCanceled.Screen = null;
            this.fld_btnUnCanceled.Size = new System.Drawing.Size(94, 27);
            this.fld_btnUnCanceled.TabIndex = 153;
            this.fld_btnUnCanceled.Text = "Sử dụng BOM";
            this.fld_btnUnCanceled.Click += new System.EventHandler(this.fld_btnUnCanceled_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(1048, 116);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(94, 27);
            this.fld_btnCancel.TabIndex = 153;
            this.fld_btnCancel.Text = "Ngừng sử dụng";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLine4
            // 
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_lkeMMProductionNormColorProccessStatus);
            this.bosLine4.Controls.Add(this.fld_lkeMMProductionNormCarcassProccessStatus);
            this.bosLine4.Controls.Add(this.fld_btnEditMMProductionNormColorProccessStatus);
            this.bosLine4.Controls.Add(this.bosLabel30);
            this.bosLine4.Controls.Add(this.fld_btnGetDefualtProcess);
            this.bosLine4.Controls.Add(this.fld_btnApproveMMProductionNormCarcassProccessStatus);
            this.bosLine4.Controls.Add(this.fld_btnApproveMMProductionNormColorProccessStatus);
            this.bosLine4.Controls.Add(this.fld_btnEditMMProductionNormCarcassProccessStatus);
            this.bosLine4.Location = new System.Drawing.Point(409, 103);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(525, 49);
            this.bosLine4.TabIndex = 151;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Thông tin QTSX";
            // 
            // fld_lkeMMProductionNormColorProccessStatus
            // 
            this.fld_lkeMMProductionNormColorProccessStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormColorProccessStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormColorProccessStatus.BOSComment = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSDataMember = "MMProductionNormColorProccessStatus";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormColorProccessStatus.BOSError = null;
            this.fld_lkeMMProductionNormColorProccessStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormColorProccessStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormColorProccessStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormColorProccessStatus.Location = new System.Drawing.Point(114, 20);
            this.fld_lkeMMProductionNormColorProccessStatus.Name = "fld_lkeMMProductionNormColorProccessStatus";
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormColorProccessStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormColorProccessStatus.Screen = null;
            this.fld_lkeMMProductionNormColorProccessStatus.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeMMProductionNormColorProccessStatus.TabIndex = 145;
            this.fld_lkeMMProductionNormColorProccessStatus.Tag = "DC";
            this.fld_lkeMMProductionNormColorProccessStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormColorProccessStatus_EditValueChanged);
            // 
            // fld_lkeMMProductionNormCarcassProccessStatus
            // 
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSComment = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSDataMember = "MMProductionNormCarcassProccessStatus";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSError = null;
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Location = new System.Drawing.Point(114, 20);
            this.fld_lkeMMProductionNormCarcassProccessStatus.Name = "fld_lkeMMProductionNormCarcassProccessStatus";
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Screen = null;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeMMProductionNormCarcassProccessStatus.TabIndex = 143;
            this.fld_lkeMMProductionNormCarcassProccessStatus.Tag = "DC";
            this.fld_lkeMMProductionNormCarcassProccessStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormCarcassProccessStatus_EditValueChanged);
            // 
            // fld_btnEditMMProductionNormColorProccessStatus
            // 
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSError = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormColorProccessStatus.Location = new System.Drawing.Point(439, 17);
            this.fld_btnEditMMProductionNormColorProccessStatus.Name = "fld_btnEditMMProductionNormColorProccessStatus";
            this.fld_btnEditMMProductionNormColorProccessStatus.Screen = this;
            this.fld_btnEditMMProductionNormColorProccessStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormColorProccessStatus.TabIndex = 150;
            this.fld_btnEditMMProductionNormColorProccessStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormColorProccessStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormColorProccessStatus_Click);
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
            this.bosLabel30.BOSDataMember = "";
            this.bosLabel30.BOSDataSource = "";
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = "";
            this.bosLabel30.BOSFieldRelation = "";
            this.bosLabel30.BOSPrivilege = "";
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(6, 23);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(48, 13);
            this.bosLabel30.TabIndex = 144;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Trạng thái";
            // 
            // fld_btnGetDefualtProcess
            // 
            this.fld_btnGetDefualtProcess.BOSComment = null;
            this.fld_btnGetDefualtProcess.BOSDataMember = null;
            this.fld_btnGetDefualtProcess.BOSDataSource = null;
            this.fld_btnGetDefualtProcess.BOSDescription = null;
            this.fld_btnGetDefualtProcess.BOSError = null;
            this.fld_btnGetDefualtProcess.BOSFieldGroup = null;
            this.fld_btnGetDefualtProcess.BOSFieldRelation = null;
            this.fld_btnGetDefualtProcess.BOSPrivilege = null;
            this.fld_btnGetDefualtProcess.BOSPropertyName = null;
            this.fld_btnGetDefualtProcess.Location = new System.Drawing.Point(247, 17);
            this.fld_btnGetDefualtProcess.Name = "fld_btnGetDefualtProcess";
            this.fld_btnGetDefualtProcess.Screen = null;
            this.fld_btnGetDefualtProcess.Size = new System.Drawing.Size(99, 20);
            this.fld_btnGetDefualtProcess.TabIndex = 147;
            this.fld_btnGetDefualtProcess.Text = "Lấy QTSX mẫu";
            this.fld_btnGetDefualtProcess.Click += new System.EventHandler(this.fld_btnGetDefualtProcess_Click);
            // 
            // fld_btnApproveMMProductionNormCarcassProccessStatus
            // 
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Location = new System.Drawing.Point(358, 17);
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Name = "fld_btnApproveMMProductionNormCarcassProccessStatus";
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Screen = this;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.TabIndex = 147;
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormCarcassProccessStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormCarcassProccessStatus_Click);
            // 
            // fld_btnApproveMMProductionNormColorProccessStatus
            // 
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormColorProccessStatus.Location = new System.Drawing.Point(358, 17);
            this.fld_btnApproveMMProductionNormColorProccessStatus.Name = "fld_btnApproveMMProductionNormColorProccessStatus";
            this.fld_btnApproveMMProductionNormColorProccessStatus.Screen = this;
            this.fld_btnApproveMMProductionNormColorProccessStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormColorProccessStatus.TabIndex = 149;
            this.fld_btnApproveMMProductionNormColorProccessStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormColorProccessStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormColorProccessStatus_Click);
            // 
            // fld_btnEditMMProductionNormCarcassProccessStatus
            // 
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSError = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Location = new System.Drawing.Point(439, 17);
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Name = "fld_btnEditMMProductionNormCarcassProccessStatus";
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Screen = this;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormCarcassProccessStatus.TabIndex = 148;
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormCarcassProccessStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormCarcassProccessStatus_Click);
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_txtICProductNo);
            this.bosLine3.Controls.Add(this.fld_medICProductDesc);
            this.bosLine3.Controls.Add(this.fld_pteICProductPicture);
            this.bosLine3.Controls.Add(this.fld_lblLabel21);
            this.bosLine3.Controls.Add(this.fld_lblLabel15);
            this.bosLine3.Controls.Add(this.fld_txtICProductName);
            this.bosLine3.Controls.Add(this.bosLabel3);
            this.bosLine3.Location = new System.Drawing.Point(5, 3);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(389, 122);
            this.bosLine3.TabIndex = 25;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Thông tin Sản phẩm";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = "";
            this.fld_txtICProductNo.BOSDataMember = "";
            this.fld_txtICProductNo.BOSDataSource = "";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = null;
            this.fld_txtICProductNo.BOSFieldGroup = "";
            this.fld_txtICProductNo.BOSFieldRelation = "";
            this.fld_txtICProductNo.BOSPrivilege = "";
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.EditValue = "";
            this.fld_txtICProductNo.Location = new System.Drawing.Point(88, 20);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.Properties.ReadOnly = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICProductNo.TabIndex = 16;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_medICProductDesc
            // 
            this.fld_medICProductDesc.BOSComment = "";
            this.fld_medICProductDesc.BOSDataMember = "";
            this.fld_medICProductDesc.BOSDataSource = "";
            this.fld_medICProductDesc.BOSDescription = null;
            this.fld_medICProductDesc.BOSError = null;
            this.fld_medICProductDesc.BOSFieldGroup = "";
            this.fld_medICProductDesc.BOSFieldRelation = "";
            this.fld_medICProductDesc.BOSPrivilege = "";
            this.fld_medICProductDesc.BOSPropertyName = "Text";
            this.fld_medICProductDesc.EditValue = "";
            this.fld_medICProductDesc.Location = new System.Drawing.Point(88, 72);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Properties.ReadOnly = true;
            this.fld_medICProductDesc.Screen = null;
            this.fld_medICProductDesc.Size = new System.Drawing.Size(168, 44);
            this.fld_medICProductDesc.TabIndex = 21;
            this.fld_medICProductDesc.Tag = "DC";
            // 
            // fld_pteICProductPicture
            // 
            this.fld_pteICProductPicture.BOSComment = "";
            this.fld_pteICProductPicture.BOSDataMember = "";
            this.fld_pteICProductPicture.BOSDataSource = "";
            this.fld_pteICProductPicture.BOSDescription = null;
            this.fld_pteICProductPicture.BOSError = null;
            this.fld_pteICProductPicture.BOSFieldGroup = "";
            this.fld_pteICProductPicture.BOSFieldRelation = "";
            this.fld_pteICProductPicture.BOSPrivilege = "";
            this.fld_pteICProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICProductPicture.EditValue = "";
            this.fld_pteICProductPicture.FileName = null;
            this.fld_pteICProductPicture.FilePath = null;
            this.fld_pteICProductPicture.Location = new System.Drawing.Point(267, 18);
            this.fld_pteICProductPicture.Name = "fld_pteICProductPicture";
            this.fld_pteICProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICProductPicture.Properties.ReadOnly = true;
            this.fld_pteICProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.fld_pteICProductPicture.Screen = null;
            this.fld_pteICProductPicture.Size = new System.Drawing.Size(109, 98);
            this.fld_pteICProductPicture.TabIndex = 23;
            this.fld_pteICProductPicture.Tag = "DC";
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
            this.fld_lblLabel21.Location = new System.Drawing.Point(9, 74);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 22;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Mô tả";
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(9, 23);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel15.TabIndex = 17;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã sản phẩm";
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment = "";
            this.fld_txtICProductName.BOSDataMember = "";
            this.fld_txtICProductName.BOSDataSource = "";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = null;
            this.fld_txtICProductName.BOSFieldGroup = "";
            this.fld_txtICProductName.BOSFieldRelation = "";
            this.fld_txtICProductName.BOSPrivilege = "";
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.EditValue = "";
            this.fld_txtICProductName.Location = new System.Drawing.Point(88, 46);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.Properties.ReadOnly = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICProductName.TabIndex = 18;
            this.fld_txtICProductName.Tag = "DC";
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
            this.bosLabel3.BOSDataMember = "ICProductNo";
            this.bosLabel3.BOSDataSource = "ICProducts";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(9, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(68, 13);
            this.bosLabel3.TabIndex = 19;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tên sản phẩm";
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
            this.bosLine1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosLine1.Controls.Add(this.bosLabel60);
            this.bosLine1.Controls.Add(this.fld_medMMProductionNormDesc);
            this.bosLine1.Controls.Add(this.bosLabel49);
            this.bosLine1.Controls.Add(this.fld_txtMMProductionNormOverallSize);
            this.bosLine1.Controls.Add(this.bosLabel14);
            this.bosLine1.Controls.Add(this.bosLabel11);
            this.bosLine1.Controls.Add(this.fld_lkeMMProductionNormStatus);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Controls.Add(this.fld_dteMMProductionNormPromulgateDate);
            this.bosLine1.Controls.Add(this.fld_txtMMProductionNormVersion);
            this.bosLine1.Controls.Add(this.fld_txtMMProductionNormBlock);
            this.bosLine1.Controls.Add(this.bosLabel12);
            this.bosLine1.Controls.Add(this.fld_txtMMProductionNormTotalPaint);
            this.bosLine1.Controls.Add(this.bosLabel15);
            this.bosLine1.Controls.Add(this.bosLabel8);
            this.bosLine1.Controls.Add(this.fld_lkeMMProductionNormType);
            this.bosLine1.Controls.Add(this.fld_txtMMProductionNormNo);
            this.bosLine1.Controls.Add(this.fld_lblLabel4);
            this.bosLine1.Location = new System.Drawing.Point(409, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(854, 97);
            this.bosLine1.TabIndex = 24;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin Bảng định mức";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "MMProductionNorms";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(524, 70);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 762;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // bosLabel60
            // 
            this.bosLabel60.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel60.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel60.Appearance.Options.UseBackColor = true;
            this.bosLabel60.Appearance.Options.UseForeColor = true;
            this.bosLabel60.BOSComment = "";
            this.bosLabel60.BOSDataMember = "";
            this.bosLabel60.BOSDataSource = "";
            this.bosLabel60.BOSDescription = null;
            this.bosLabel60.BOSError = null;
            this.bosLabel60.BOSFieldGroup = "";
            this.bosLabel60.BOSFieldRelation = "";
            this.bosLabel60.BOSPrivilege = "";
            this.bosLabel60.BOSPropertyName = "";
            this.bosLabel60.Location = new System.Drawing.Point(458, 73);
            this.bosLabel60.Name = "bosLabel60";
            this.bosLabel60.Screen = null;
            this.bosLabel60.Size = new System.Drawing.Size(56, 13);
            this.bosLabel60.TabIndex = 791;
            this.bosLabel60.Tag = "";
            this.bosLabel60.Text = "Khách hàng";
            // 
            // fld_medMMProductionNormDesc
            // 
            this.fld_medMMProductionNormDesc.BOSComment = "";
            this.fld_medMMProductionNormDesc.BOSDataMember = "MMProductionNormDesc";
            this.fld_medMMProductionNormDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormDesc.BOSDescription = null;
            this.fld_medMMProductionNormDesc.BOSError = null;
            this.fld_medMMProductionNormDesc.BOSFieldGroup = "";
            this.fld_medMMProductionNormDesc.BOSFieldRelation = "";
            this.fld_medMMProductionNormDesc.BOSPrivilege = "";
            this.fld_medMMProductionNormDesc.BOSPropertyName = "Text";
            this.fld_medMMProductionNormDesc.EditValue = "";
            this.fld_medMMProductionNormDesc.Location = new System.Drawing.Point(691, 21);
            this.fld_medMMProductionNormDesc.Name = "fld_medMMProductionNormDesc";
            this.fld_medMMProductionNormDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormDesc.Screen = null;
            this.fld_medMMProductionNormDesc.Size = new System.Drawing.Size(157, 59);
            this.fld_medMMProductionNormDesc.TabIndex = 142;
            this.fld_medMMProductionNormDesc.Tag = "DC";
            // 
            // bosLabel49
            // 
            this.bosLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel49.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel49.Appearance.Options.UseBackColor = true;
            this.bosLabel49.Appearance.Options.UseFont = true;
            this.bosLabel49.Appearance.Options.UseForeColor = true;
            this.bosLabel49.BOSComment = "";
            this.bosLabel49.BOSDataMember = "";
            this.bosLabel49.BOSDataSource = "";
            this.bosLabel49.BOSDescription = null;
            this.bosLabel49.BOSError = null;
            this.bosLabel49.BOSFieldGroup = "";
            this.bosLabel49.BOSFieldRelation = "";
            this.bosLabel49.BOSPrivilege = "";
            this.bosLabel49.BOSPropertyName = "";
            this.bosLabel49.Location = new System.Drawing.Point(649, 23);
            this.bosLabel49.Name = "bosLabel49";
            this.bosLabel49.Screen = null;
            this.bosLabel49.Size = new System.Drawing.Size(27, 13);
            this.bosLabel49.TabIndex = 141;
            this.bosLabel49.Tag = "";
            this.bosLabel49.Text = "Mô tả";
            // 
            // fld_txtMMProductionNormOverallSize
            // 
            this.fld_txtMMProductionNormOverallSize.BOSComment = "";
            this.fld_txtMMProductionNormOverallSize.BOSDataMember = "MMProductionNormOverallSize";
            this.fld_txtMMProductionNormOverallSize.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormOverallSize.BOSDescription = null;
            this.fld_txtMMProductionNormOverallSize.BOSError = "";
            this.fld_txtMMProductionNormOverallSize.BOSFieldGroup = "";
            this.fld_txtMMProductionNormOverallSize.BOSFieldRelation = "";
            this.fld_txtMMProductionNormOverallSize.BOSPrivilege = "";
            this.fld_txtMMProductionNormOverallSize.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormOverallSize.Location = new System.Drawing.Point(524, 46);
            this.fld_txtMMProductionNormOverallSize.Name = "fld_txtMMProductionNormOverallSize";
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormOverallSize.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormOverallSize.Properties.ReadOnly = true;
            this.fld_txtMMProductionNormOverallSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormOverallSize.Screen = null;
            this.fld_txtMMProductionNormOverallSize.Size = new System.Drawing.Size(109, 20);
            this.fld_txtMMProductionNormOverallSize.TabIndex = 138;
            this.fld_txtMMProductionNormOverallSize.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(458, 49);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(56, 13);
            this.bosLabel14.TabIndex = 139;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "KT tổng thể";
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
            this.bosLabel11.Location = new System.Drawing.Point(458, 23);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 137;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormStatus
            // 
            this.fld_lkeMMProductionNormStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormStatus.BOSComment = "";
            this.fld_lkeMMProductionNormStatus.BOSDataMember = "MMProductionNormStatus";
            this.fld_lkeMMProductionNormStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormStatus.BOSError = null;
            this.fld_lkeMMProductionNormStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormStatus.Location = new System.Drawing.Point(524, 20);
            this.fld_lkeMMProductionNormStatus.Name = "fld_lkeMMProductionNormStatus";
            this.fld_lkeMMProductionNormStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormStatus.Screen = null;
            this.fld_lkeMMProductionNormStatus.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeMMProductionNormStatus.TabIndex = 136;
            this.fld_lkeMMProductionNormStatus.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
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
            this.bosLabel9.Location = new System.Drawing.Point(6, 75);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(76, 13);
            this.bosLabel9.TabIndex = 135;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Ngày phát hành";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
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
            this.bosLabel10.Location = new System.Drawing.Point(255, 75);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(69, 13);
            this.bosLabel10.TabIndex = 134;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Lần phát hành";
            // 
            // fld_dteMMProductionNormPromulgateDate
            // 
            this.fld_dteMMProductionNormPromulgateDate.BOSComment = "";
            this.fld_dteMMProductionNormPromulgateDate.BOSDataMember = "MMProductionNormPromulgateDate";
            this.fld_dteMMProductionNormPromulgateDate.BOSDataSource = "MMProductionNorms";
            this.fld_dteMMProductionNormPromulgateDate.BOSDescription = null;
            this.fld_dteMMProductionNormPromulgateDate.BOSError = null;
            this.fld_dteMMProductionNormPromulgateDate.BOSFieldGroup = "";
            this.fld_dteMMProductionNormPromulgateDate.BOSFieldRelation = "";
            this.fld_dteMMProductionNormPromulgateDate.BOSPrivilege = "";
            this.fld_dteMMProductionNormPromulgateDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionNormPromulgateDate.EditValue = null;
            this.fld_dteMMProductionNormPromulgateDate.Location = new System.Drawing.Point(114, 72);
            this.fld_dteMMProductionNormPromulgateDate.Name = "fld_dteMMProductionNormPromulgateDate";
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionNormPromulgateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionNormPromulgateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionNormPromulgateDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionNormPromulgateDate, true);
            this.fld_dteMMProductionNormPromulgateDate.Size = new System.Drawing.Size(109, 20);
            this.fld_dteMMProductionNormPromulgateDate.TabIndex = 132;
            this.fld_dteMMProductionNormPromulgateDate.Tag = "DC";
            // 
            // fld_txtMMProductionNormVersion
            // 
            this.fld_txtMMProductionNormVersion.BOSComment = "";
            this.fld_txtMMProductionNormVersion.BOSDataMember = "MMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormVersion.BOSDescription = null;
            this.fld_txtMMProductionNormVersion.BOSError = "";
            this.fld_txtMMProductionNormVersion.BOSFieldGroup = "";
            this.fld_txtMMProductionNormVersion.BOSFieldRelation = "";
            this.fld_txtMMProductionNormVersion.BOSPrivilege = "";
            this.fld_txtMMProductionNormVersion.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormVersion.Location = new System.Drawing.Point(332, 72);
            this.fld_txtMMProductionNormVersion.Name = "fld_txtMMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormVersion.Screen = null;
            this.fld_txtMMProductionNormVersion.Size = new System.Drawing.Size(109, 20);
            this.fld_txtMMProductionNormVersion.TabIndex = 133;
            this.fld_txtMMProductionNormVersion.Tag = "DC";
            // 
            // fld_txtMMProductionNormBlock
            // 
            this.fld_txtMMProductionNormBlock.BOSComment = "";
            this.fld_txtMMProductionNormBlock.BOSDataMember = "MMProductionNormBlock";
            this.fld_txtMMProductionNormBlock.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormBlock.BOSDescription = null;
            this.fld_txtMMProductionNormBlock.BOSError = "";
            this.fld_txtMMProductionNormBlock.BOSFieldGroup = "";
            this.fld_txtMMProductionNormBlock.BOSFieldRelation = "";
            this.fld_txtMMProductionNormBlock.BOSPrivilege = "";
            this.fld_txtMMProductionNormBlock.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormBlock.Enabled = false;
            this.fld_txtMMProductionNormBlock.Location = new System.Drawing.Point(332, 46);
            this.fld_txtMMProductionNormBlock.Name = "fld_txtMMProductionNormBlock";
            this.fld_txtMMProductionNormBlock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormBlock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormBlock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormBlock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormBlock.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormBlock.Properties.ReadOnly = true;
            this.fld_txtMMProductionNormBlock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormBlock.Screen = null;
            this.fld_txtMMProductionNormBlock.Size = new System.Drawing.Size(109, 20);
            this.fld_txtMMProductionNormBlock.TabIndex = 129;
            this.fld_txtMMProductionNormBlock.Tag = "DC";
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
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(255, 49);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(62, 13);
            this.bosLabel12.TabIndex = 131;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Tổng m3 tinh";
            // 
            // fld_txtMMProductionNormTotalPaint
            // 
            this.fld_txtMMProductionNormTotalPaint.BOSComment = "";
            this.fld_txtMMProductionNormTotalPaint.BOSDataMember = "MMProductionNormTotalPaint";
            this.fld_txtMMProductionNormTotalPaint.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormTotalPaint.BOSDescription = null;
            this.fld_txtMMProductionNormTotalPaint.BOSError = "";
            this.fld_txtMMProductionNormTotalPaint.BOSFieldGroup = "";
            this.fld_txtMMProductionNormTotalPaint.BOSFieldRelation = "";
            this.fld_txtMMProductionNormTotalPaint.BOSPrivilege = "";
            this.fld_txtMMProductionNormTotalPaint.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormTotalPaint.Location = new System.Drawing.Point(114, 46);
            this.fld_txtMMProductionNormTotalPaint.Name = "fld_txtMMProductionNormTotalPaint";
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormTotalPaint.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormTotalPaint.Properties.ReadOnly = true;
            this.fld_txtMMProductionNormTotalPaint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormTotalPaint.Screen = null;
            this.fld_txtMMProductionNormTotalPaint.Size = new System.Drawing.Size(109, 20);
            this.fld_txtMMProductionNormTotalPaint.TabIndex = 128;
            this.fld_txtMMProductionNormTotalPaint.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseFont = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(6, 49);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(87, 13);
            this.bosLabel15.TabIndex = 130;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Tổng DT sơn (M2)";
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
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(255, 23);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(67, 13);
            this.bosLabel8.TabIndex = 127;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Loại định mức";
            // 
            // fld_lkeMMProductionNormType
            // 
            this.fld_lkeMMProductionNormType.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormType.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormType.BOSComment = "";
            this.fld_lkeMMProductionNormType.BOSDataMember = "MMProductionNormType";
            this.fld_lkeMMProductionNormType.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormType.BOSDescription = null;
            this.fld_lkeMMProductionNormType.BOSError = null;
            this.fld_lkeMMProductionNormType.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormType.BOSFieldParent = "";
            this.fld_lkeMMProductionNormType.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormType.BOSPrivilege = "";
            this.fld_lkeMMProductionNormType.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormType.BOSSelectType = "";
            this.fld_lkeMMProductionNormType.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormType.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormType.Location = new System.Drawing.Point(332, 20);
            this.fld_lkeMMProductionNormType.Name = "fld_lkeMMProductionNormType";
            this.fld_lkeMMProductionNormType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormType.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormType.Properties.NullText = "";
            this.fld_lkeMMProductionNormType.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormType.Screen = null;
            this.fld_lkeMMProductionNormType.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeMMProductionNormType.TabIndex = 126;
            this.fld_lkeMMProductionNormType.Tag = "DC";
            // 
            // fld_txtMMProductionNormNo
            // 
            this.fld_txtMMProductionNormNo.BOSComment = "";
            this.fld_txtMMProductionNormNo.BOSDataMember = "MMProductionNormNo";
            this.fld_txtMMProductionNormNo.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormNo.BOSDescription = null;
            this.fld_txtMMProductionNormNo.BOSError = "";
            this.fld_txtMMProductionNormNo.BOSFieldGroup = "";
            this.fld_txtMMProductionNormNo.BOSFieldRelation = "";
            this.fld_txtMMProductionNormNo.BOSPrivilege = "";
            this.fld_txtMMProductionNormNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormNo.Location = new System.Drawing.Point(114, 20);
            this.fld_txtMMProductionNormNo.Name = "fld_txtMMProductionNormNo";
            this.fld_txtMMProductionNormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormNo.Properties.ReadOnly = true;
            this.fld_txtMMProductionNormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionNormNo, true);
            this.fld_txtMMProductionNormNo.Size = new System.Drawing.Size(109, 20);
            this.fld_txtMMProductionNormNo.TabIndex = 124;
            this.fld_txtMMProductionNormNo.Tag = "DC";
            this.fld_txtMMProductionNormNo.EditValueChanged += new System.EventHandler(this.fld_txtMMProductionNormNo_EditValueChanged);
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(6, 23);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel4.TabIndex = 125;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã BĐM";
            // 
            // fld_tcDetailInfo
            // 
            this.fld_tcDetailInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tcDetailInfo.BOSComment = null;
            this.fld_tcDetailInfo.BOSDataMember = null;
            this.fld_tcDetailInfo.BOSDataSource = null;
            this.fld_tcDetailInfo.BOSDescription = null;
            this.fld_tcDetailInfo.BOSError = null;
            this.fld_tcDetailInfo.BOSFieldGroup = null;
            this.fld_tcDetailInfo.BOSFieldRelation = null;
            this.fld_tcDetailInfo.BOSPrivilege = null;
            this.fld_tcDetailInfo.BOSPropertyName = null;
            this.fld_tcDetailInfo.Location = new System.Drawing.Point(3, 158);
            this.fld_tcDetailInfo.Name = "fld_tcDetailInfo";
            this.fld_tcDetailInfo.Screen = null;
            this.fld_tcDetailInfo.SelectedTabPage = this.tpSemiProducts;
            this.fld_tcDetailInfo.Size = new System.Drawing.Size(2305, 707);
            this.fld_tcDetailInfo.TabIndex = 1;
            this.fld_tcDetailInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSemiProducts,
            this.tpProductStructure,
            this.fld_tabPackageNo,
            this.tpBOM});
            this.fld_tcDetailInfo.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.Fld_tcDetailInfo_SelectedPageChanged);
            // 
            // tpSemiProducts
            // 
            this.tpSemiProducts.Controls.Add(this.bosPanel8);
            this.tpSemiProducts.Name = "tpSemiProducts";
            this.tpSemiProducts.Size = new System.Drawing.Size(2303, 682);
            this.tpSemiProducts.Text = "Bán thành phẩm";
            // 
            // bosPanel8
            // 
            this.bosPanel8.AutoScroll = true;
            this.bosPanel8.BOSComment = null;
            this.bosPanel8.BOSDataMember = null;
            this.bosPanel8.BOSDataSource = null;
            this.bosPanel8.BOSDescription = null;
            this.bosPanel8.BOSError = null;
            this.bosPanel8.BOSFieldGroup = null;
            this.bosPanel8.BOSFieldRelation = null;
            this.bosPanel8.BOSPrivilege = null;
            this.bosPanel8.BOSPropertyName = null;
            this.bosPanel8.Controls.Add(this.fld_btnPrintMaterial);
            this.bosPanel8.Controls.Add(this.bosLabel51);
            this.bosPanel8.Controls.Add(this.bosLookupEdit1);
            this.bosPanel8.Controls.Add(this.bosLabel50);
            this.bosPanel8.Controls.Add(this.fld_lkeICProductIdentifyWoodType);
            this.bosPanel8.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.bosPanel8.Controls.Add(this.fld_lblLabel16);
            this.bosPanel8.Controls.Add(this.fld_dgcICProducts);
            this.bosPanel8.Controls.Add(this.bosButton3);
            this.bosPanel8.Controls.Add(this.fld_txtDepreciationRate);
            this.bosPanel8.Controls.Add(this.bosLabel38);
            this.bosPanel8.Controls.Add(this.bosLine2);
            this.bosPanel8.Controls.Add(this.fld_radPropertiesOrProcess);
            this.bosPanel8.Controls.Add(this.fld_btnUpdatePaint);
            this.bosPanel8.Controls.Add(this.fld_btnSave);
            this.bosPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel8.Location = new System.Drawing.Point(0, 0);
            this.bosPanel8.Name = "bosPanel8";
            this.bosPanel8.Screen = null;
            this.bosPanel8.Size = new System.Drawing.Size(2303, 682);
            this.bosPanel8.TabIndex = 115;
            // 
            // fld_btnPrintMaterial
            // 
            this.fld_btnPrintMaterial.BOSComment = null;
            this.fld_btnPrintMaterial.BOSDataMember = null;
            this.fld_btnPrintMaterial.BOSDataSource = null;
            this.fld_btnPrintMaterial.BOSDescription = null;
            this.fld_btnPrintMaterial.BOSError = null;
            this.fld_btnPrintMaterial.BOSFieldGroup = null;
            this.fld_btnPrintMaterial.BOSFieldRelation = null;
            this.fld_btnPrintMaterial.BOSPrivilege = null;
            this.fld_btnPrintMaterial.BOSPropertyName = null;
            this.fld_btnPrintMaterial.Location = new System.Drawing.Point(958, 17);
            this.fld_btnPrintMaterial.Name = "fld_btnPrintMaterial";
            this.fld_btnPrintMaterial.Screen = null;
            this.fld_btnPrintMaterial.Size = new System.Drawing.Size(134, 27);
            this.fld_btnPrintMaterial.TabIndex = 457;
            this.fld_btnPrintMaterial.Text = "In định mức nguyên liệu";
            this.fld_btnPrintMaterial.Click += new System.EventHandler(this.bosButton8_Click);
            // 
            // bosLabel51
            // 
            this.bosLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel51.Appearance.Options.UseBackColor = true;
            this.bosLabel51.Appearance.Options.UseFont = true;
            this.bosLabel51.Appearance.Options.UseForeColor = true;
            this.bosLabel51.BOSComment = "";
            this.bosLabel51.BOSDataMember = "";
            this.bosLabel51.BOSDataSource = "";
            this.bosLabel51.BOSDescription = null;
            this.bosLabel51.BOSError = null;
            this.bosLabel51.BOSFieldGroup = "";
            this.bosLabel51.BOSFieldRelation = "";
            this.bosLabel51.BOSPrivilege = "";
            this.bosLabel51.BOSPropertyName = "";
            this.bosLabel51.Location = new System.Drawing.Point(819, 63);
            this.bosLabel51.Name = "bosLabel51";
            this.bosLabel51.Screen = null;
            this.bosLabel51.Size = new System.Drawing.Size(102, 13);
            this.bosLabel51.TabIndex = 456;
            this.bosLabel51.Tag = "";
            this.bosLabel51.Text = "Độ phức tạp sản xuất";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "";
            this.bosLookupEdit1.BOSDataSource = "";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(927, 60);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Độ phức tạp")});
            this.bosLookupEdit1.Properties.DisplayMember = "ADConfigText";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ADConfigKeyValue";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(125, 20);
            this.bosLookupEdit1.TabIndex = 455;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit1_QueryPopUp_1);
            this.bosLookupEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit1_CloseUp);
            // 
            // bosLabel50
            // 
            this.bosLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel50.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel50.Appearance.Options.UseBackColor = true;
            this.bosLabel50.Appearance.Options.UseFont = true;
            this.bosLabel50.Appearance.Options.UseForeColor = true;
            this.bosLabel50.BOSComment = "";
            this.bosLabel50.BOSDataMember = "";
            this.bosLabel50.BOSDataSource = "";
            this.bosLabel50.BOSDescription = null;
            this.bosLabel50.BOSError = null;
            this.bosLabel50.BOSFieldGroup = "";
            this.bosLabel50.BOSFieldRelation = "";
            this.bosLabel50.BOSPrivilege = "";
            this.bosLabel50.BOSPropertyName = "";
            this.bosLabel50.Location = new System.Drawing.Point(575, 63);
            this.bosLabel50.Name = "bosLabel50";
            this.bosLabel50.Screen = null;
            this.bosLabel50.Size = new System.Drawing.Size(100, 13);
            this.bosLabel50.TabIndex = 454;
            this.bosLabel50.Tag = "";
            this.bosLabel50.Text = "Xác định nguyên liệu";
            // 
            // fld_lkeICProductIdentifyWoodType
            // 
            this.fld_lkeICProductIdentifyWoodType.BOSAllowAddNew = false;
            this.fld_lkeICProductIdentifyWoodType.BOSAllowDummy = false;
            this.fld_lkeICProductIdentifyWoodType.BOSComment = null;
            this.fld_lkeICProductIdentifyWoodType.BOSDataMember = "";
            this.fld_lkeICProductIdentifyWoodType.BOSDataSource = "ICProductAttributes";
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
            this.fld_lkeICProductIdentifyWoodType.Location = new System.Drawing.Point(681, 60);
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
            this.fld_lkeICProductIdentifyWoodType.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeICProductIdentifyWoodType.TabIndex = 451;
            this.fld_lkeICProductIdentifyWoodType.Tag = "DC";
            this.fld_lkeICProductIdentifyWoodType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductIdentifyWoodType_CloseUp);
            // 
            // fld_lkeFK_ICProductBasicUnitID
            // 
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSComment = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataMember = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataSource = "ICMeasureUnits";
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(426, 60);
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
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 452;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
            this.fld_lkeFK_ICProductBasicUnitID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductBasicUnitID_CloseUp);
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(400, 63);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel16.TabIndex = 453;
            this.fld_lblLabel16.Text = "ĐVT";
            // 
            // fld_dgcICProducts
            // 
            this.fld_dgcICProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProducts.BOSComment = null;
            this.fld_dgcICProducts.BOSDataMember = null;
            this.fld_dgcICProducts.BOSDataSource = "ICProducts";
            this.fld_dgcICProducts.BOSDescription = null;
            this.fld_dgcICProducts.BOSError = null;
            this.fld_dgcICProducts.BOSFieldGroup = null;
            this.fld_dgcICProducts.BOSFieldRelation = null;
            this.fld_dgcICProducts.BOSGridType = null;
            this.fld_dgcICProducts.BOSPrivilege = null;
            this.fld_dgcICProducts.BOSPropertyName = null;
            this.fld_dgcICProducts.CommodityType = "";
            this.fld_dgcICProducts.Location = new System.Drawing.Point(6, 89);
            this.fld_dgcICProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICProducts.Name = "fld_dgcICProducts";
            this.fld_dgcICProducts.PrintReport = false;
            this.fld_dgcICProducts.Screen = null;
            this.fld_dgcICProducts.Size = new System.Drawing.Size(2290, 587);
            this.fld_dgcICProducts.TabIndex = 117;
            this.fld_dgcICProducts.Tag = "DC";
            // 
            // bosButton3
            // 
            this.bosButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton3.BOSComment = null;
            this.bosButton3.BOSDataMember = null;
            this.bosButton3.BOSDataSource = null;
            this.bosButton3.BOSDescription = null;
            this.bosButton3.BOSError = null;
            this.bosButton3.BOSFieldGroup = null;
            this.bosButton3.BOSFieldRelation = null;
            this.bosButton3.BOSPrivilege = null;
            this.bosButton3.BOSPropertyName = null;
            this.bosButton3.Location = new System.Drawing.Point(2278, 3);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(22, 22);
            this.bosButton3.TabIndex = 117;
            this.bosButton3.Text = "❐";
            this.bosButton3.Click += new System.EventHandler(this.bosButton3_Click_1);
            // 
            // fld_txtDepreciationRate
            // 
            this.fld_txtDepreciationRate.BOSComment = "";
            this.fld_txtDepreciationRate.BOSDataMember = "";
            this.fld_txtDepreciationRate.BOSDataSource = "";
            this.fld_txtDepreciationRate.BOSDescription = null;
            this.fld_txtDepreciationRate.BOSError = null;
            this.fld_txtDepreciationRate.BOSFieldGroup = "";
            this.fld_txtDepreciationRate.BOSFieldRelation = "";
            this.fld_txtDepreciationRate.BOSPrivilege = "";
            this.fld_txtDepreciationRate.BOSPropertyName = "Text";
            this.fld_txtDepreciationRate.EditValue = "";
            this.fld_txtDepreciationRate.Location = new System.Drawing.Point(342, 60);
            this.fld_txtDepreciationRate.Name = "fld_txtDepreciationRate";
            this.fld_txtDepreciationRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtDepreciationRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDepreciationRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDepreciationRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDepreciationRate.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtDepreciationRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRate.Properties.EditFormat.FormatString = "n2";
            this.fld_txtDepreciationRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRate.Properties.Mask.EditMask = "n2";
            this.fld_txtDepreciationRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtDepreciationRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDepreciationRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDepreciationRate.Screen = null;
            this.fld_txtDepreciationRate.Size = new System.Drawing.Size(32, 20);
            this.fld_txtDepreciationRate.TabIndex = 115;
            this.fld_txtDepreciationRate.Tag = "DC";
            this.fld_txtDepreciationRate.ToolTip = "Nhấn Enter để cập nhật xuống chi tiết";
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.Options.UseBackColor = true;
            this.bosLabel38.Appearance.Options.UseFont = true;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = "";
            this.bosLabel38.BOSDataMember = "ICProductNo";
            this.bosLabel38.BOSDataSource = "ICProducts";
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = "";
            this.bosLabel38.BOSFieldRelation = "";
            this.bosLabel38.BOSPrivilege = "";
            this.bosLabel38.BOSPropertyName = "";
            this.bosLabel38.Location = new System.Drawing.Point(275, 63);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(55, 13);
            this.bosLabel38.TabIndex = 116;
            this.bosLabel38.Tag = "";
            this.bosLabel38.Text = "TS tiêu hao";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_lkeChooseSemi);
            this.bosLine2.Controls.Add(this.bosLabel5);
            this.bosLine2.Controls.Add(this.fld_btnCoppyCarcassSemiProduct);
            this.bosLine2.Controls.Add(this.bosLabel4);
            this.bosLine2.Controls.Add(this.fld_lkeCarcassForCopy);
            this.bosLine2.Location = new System.Drawing.Point(7, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(638, 47);
            this.bosLine2.TabIndex = 111;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Sao chép";
            // 
            // fld_lkeChooseSemi
            // 
            this.fld_lkeChooseSemi.BOSAllowAddNew = false;
            this.fld_lkeChooseSemi.BOSAllowDummy = false;
            this.fld_lkeChooseSemi.BOSComment = null;
            this.fld_lkeChooseSemi.BOSDataMember = null;
            this.fld_lkeChooseSemi.BOSDataSource = null;
            this.fld_lkeChooseSemi.BOSDescription = null;
            this.fld_lkeChooseSemi.BOSError = null;
            this.fld_lkeChooseSemi.BOSFieldGroup = null;
            this.fld_lkeChooseSemi.BOSFieldParent = null;
            this.fld_lkeChooseSemi.BOSFieldRelation = null;
            this.fld_lkeChooseSemi.BOSPrivilege = null;
            this.fld_lkeChooseSemi.BOSPropertyName = null;
            this.fld_lkeChooseSemi.BOSSelectType = null;
            this.fld_lkeChooseSemi.BOSSelectTypeValue = null;
            this.fld_lkeChooseSemi.CurrentDisplayText = null;
            this.fld_lkeChooseSemi.Location = new System.Drawing.Point(317, 17);
            this.fld_lkeChooseSemi.MenuManager = this.screenToolbar;
            this.fld_lkeChooseSemi.Name = "fld_lkeChooseSemi";
            this.fld_lkeChooseSemi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeChooseSemi.Properties.ColumnName = null;
            this.fld_lkeChooseSemi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductCode", "Mã code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã BTP")});
            this.fld_lkeChooseSemi.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeChooseSemi.Properties.ValueMember = "ICProductID";
            this.fld_lkeChooseSemi.Screen = null;
            this.fld_lkeChooseSemi.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeChooseSemi.TabIndex = 417;
            this.fld_lkeChooseSemi.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit1_QueryPopUp);
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
            this.bosLabel5.Location = new System.Drawing.Point(263, 21);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(41, 13);
            this.bosLabel5.TabIndex = 416;
            this.bosLabel5.Text = "BTP Mẫu";
            // 
            // fld_btnCoppyCarcassSemiProduct
            // 
            this.fld_btnCoppyCarcassSemiProduct.BOSComment = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSDataMember = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSDataSource = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSDescription = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSError = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSFieldGroup = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSFieldRelation = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSPrivilege = null;
            this.fld_btnCoppyCarcassSemiProduct.BOSPropertyName = null;
            this.fld_btnCoppyCarcassSemiProduct.Location = new System.Drawing.Point(503, 14);
            this.fld_btnCoppyCarcassSemiProduct.Name = "fld_btnCoppyCarcassSemiProduct";
            this.fld_btnCoppyCarcassSemiProduct.Screen = null;
            this.fld_btnCoppyCarcassSemiProduct.Size = new System.Drawing.Size(118, 27);
            this.fld_btnCoppyCarcassSemiProduct.TabIndex = 112;
            this.fld_btnCoppyCarcassSemiProduct.Text = "Sao chép";
            this.fld_btnCoppyCarcassSemiProduct.Click += new System.EventHandler(this.fld_btnCoppyCarcassSemiProduct_Click);
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
            this.bosLabel4.Location = new System.Drawing.Point(24, 21);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "BĐM Mẫu";
            // 
            // fld_lkeCarcassForCopy
            // 
            this.fld_lkeCarcassForCopy.BOSAllowAddNew = false;
            this.fld_lkeCarcassForCopy.BOSAllowDummy = true;
            this.fld_lkeCarcassForCopy.BOSComment = null;
            this.fld_lkeCarcassForCopy.BOSDataMember = null;
            this.fld_lkeCarcassForCopy.BOSDataSource = null;
            this.fld_lkeCarcassForCopy.BOSDescription = null;
            this.fld_lkeCarcassForCopy.BOSError = null;
            this.fld_lkeCarcassForCopy.BOSFieldGroup = null;
            this.fld_lkeCarcassForCopy.BOSFieldParent = null;
            this.fld_lkeCarcassForCopy.BOSFieldRelation = null;
            this.fld_lkeCarcassForCopy.BOSPrivilege = null;
            this.fld_lkeCarcassForCopy.BOSPropertyName = null;
            this.fld_lkeCarcassForCopy.BOSSelectType = null;
            this.fld_lkeCarcassForCopy.BOSSelectTypeValue = null;
            this.fld_lkeCarcassForCopy.CurrentDisplayText = null;
            this.fld_lkeCarcassForCopy.Location = new System.Drawing.Point(82, 17);
            this.fld_lkeCarcassForCopy.MenuManager = this.screenToolbar;
            this.fld_lkeCarcassForCopy.Name = "fld_lkeCarcassForCopy";
            this.fld_lkeCarcassForCopy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCarcassForCopy.Properties.ColumnName = null;
            this.fld_lkeCarcassForCopy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã hàng mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Bảng định mức")});
            this.fld_lkeCarcassForCopy.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeCarcassForCopy.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeCarcassForCopy.Screen = null;
            this.fld_lkeCarcassForCopy.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeCarcassForCopy.TabIndex = 110;
            this.fld_lkeCarcassForCopy.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeCarcassForCopy_CloseUp);
            // 
            // fld_radPropertiesOrProcess
            // 
            this.fld_radPropertiesOrProcess.BOSComment = null;
            this.fld_radPropertiesOrProcess.BOSDataMember = null;
            this.fld_radPropertiesOrProcess.BOSDataSource = null;
            this.fld_radPropertiesOrProcess.BOSDescription = null;
            this.fld_radPropertiesOrProcess.BOSError = null;
            this.fld_radPropertiesOrProcess.BOSFieldGroup = null;
            this.fld_radPropertiesOrProcess.BOSFieldRelation = null;
            this.fld_radPropertiesOrProcess.BOSPrivilege = null;
            this.fld_radPropertiesOrProcess.BOSPropertyName = null;
            this.fld_radPropertiesOrProcess.Location = new System.Drawing.Point(7, 56);
            this.fld_radPropertiesOrProcess.MenuManager = this.screenToolbar;
            this.fld_radPropertiesOrProcess.Name = "fld_radPropertiesOrProcess";
            this.fld_radPropertiesOrProcess.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_radPropertiesOrProcess.Properties.Appearance.Options.UseBackColor = true;
            this.fld_radPropertiesOrProcess.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cấu trúc"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Qui trình SX")});
            this.fld_radPropertiesOrProcess.Screen = null;
            this.fld_radPropertiesOrProcess.Size = new System.Drawing.Size(251, 27);
            this.fld_radPropertiesOrProcess.TabIndex = 109;
            // 
            // fld_btnUpdatePaint
            // 
            this.fld_btnUpdatePaint.BOSComment = null;
            this.fld_btnUpdatePaint.BOSDataMember = null;
            this.fld_btnUpdatePaint.BOSDataSource = null;
            this.fld_btnUpdatePaint.BOSDescription = null;
            this.fld_btnUpdatePaint.BOSError = null;
            this.fld_btnUpdatePaint.BOSFieldGroup = null;
            this.fld_btnUpdatePaint.BOSFieldRelation = null;
            this.fld_btnUpdatePaint.BOSPrivilege = null;
            this.fld_btnUpdatePaint.BOSPropertyName = null;
            this.fld_btnUpdatePaint.Location = new System.Drawing.Point(819, 17);
            this.fld_btnUpdatePaint.Name = "fld_btnUpdatePaint";
            this.fld_btnUpdatePaint.Screen = null;
            this.fld_btnUpdatePaint.Size = new System.Drawing.Size(125, 27);
            this.fld_btnUpdatePaint.TabIndex = 108;
            this.fld_btnUpdatePaint.Text = "Cập nhật Sơn";
            this.fld_btnUpdatePaint.Click += new System.EventHandler(this.fld_btnUpdatePaint_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(681, 17);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSave, true);
            this.fld_btnSave.Size = new System.Drawing.Size(125, 27);
            this.fld_btnSave.TabIndex = 108;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // tpProductStructure
            // 
            this.tpProductStructure.Controls.Add(this.bosPanel4);
            this.tpProductStructure.Name = "tpProductStructure";
            this.tpProductStructure.Size = new System.Drawing.Size(2303, 682);
            this.tpProductStructure.Text = "Cây định mức";
            // 
            // bosPanel4
            // 
            this.bosPanel4.AutoScroll = true;
            this.bosPanel4.BOSComment = null;
            this.bosPanel4.BOSDataMember = null;
            this.bosPanel4.BOSDataSource = null;
            this.bosPanel4.BOSDescription = null;
            this.bosPanel4.BOSError = null;
            this.bosPanel4.BOSFieldGroup = null;
            this.bosPanel4.BOSFieldRelation = null;
            this.bosPanel4.BOSPrivilege = null;
            this.bosPanel4.BOSPropertyName = null;
            this.bosPanel4.Controls.Add(this.fld_btnSaveBOMTree);
            this.bosPanel4.Controls.Add(this.fld_btnCreateBOM);
            this.bosPanel4.Controls.Add(this.fld_trlICProductItems);
            this.bosPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel4.Location = new System.Drawing.Point(0, 0);
            this.bosPanel4.Name = "bosPanel4";
            this.bosPanel4.Screen = null;
            this.bosPanel4.Size = new System.Drawing.Size(2303, 682);
            this.bosPanel4.TabIndex = 0;
            // 
            // fld_btnSaveBOMTree
            // 
            this.fld_btnSaveBOMTree.BOSComment = null;
            this.fld_btnSaveBOMTree.BOSDataMember = null;
            this.fld_btnSaveBOMTree.BOSDataSource = null;
            this.fld_btnSaveBOMTree.BOSDescription = null;
            this.fld_btnSaveBOMTree.BOSError = null;
            this.fld_btnSaveBOMTree.BOSFieldGroup = null;
            this.fld_btnSaveBOMTree.BOSFieldRelation = null;
            this.fld_btnSaveBOMTree.BOSPrivilege = null;
            this.fld_btnSaveBOMTree.BOSPropertyName = null;
            this.fld_btnSaveBOMTree.Location = new System.Drawing.Point(24, 8);
            this.fld_btnSaveBOMTree.Name = "fld_btnSaveBOMTree";
            this.fld_btnSaveBOMTree.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveBOMTree, true);
            this.fld_btnSaveBOMTree.Size = new System.Drawing.Size(118, 27);
            this.fld_btnSaveBOMTree.TabIndex = 110;
            this.fld_btnSaveBOMTree.Text = "Lưu";
            this.fld_btnSaveBOMTree.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // fld_btnCreateBOM
            // 
            this.fld_btnCreateBOM.BOSComment = null;
            this.fld_btnCreateBOM.BOSDataMember = null;
            this.fld_btnCreateBOM.BOSDataSource = null;
            this.fld_btnCreateBOM.BOSDescription = null;
            this.fld_btnCreateBOM.BOSError = null;
            this.fld_btnCreateBOM.BOSFieldGroup = null;
            this.fld_btnCreateBOM.BOSFieldRelation = null;
            this.fld_btnCreateBOM.BOSPrivilege = null;
            this.fld_btnCreateBOM.BOSPropertyName = null;
            this.fld_btnCreateBOM.Location = new System.Drawing.Point(148, 8);
            this.fld_btnCreateBOM.Name = "fld_btnCreateBOM";
            this.fld_btnCreateBOM.Screen = null;
            this.fld_btnCreateBOM.Size = new System.Drawing.Size(118, 27);
            this.fld_btnCreateBOM.TabIndex = 109;
            this.fld_btnCreateBOM.Text = "Cập nhật BOM";
            this.fld_btnCreateBOM.Click += new System.EventHandler(this.fld_btnCreateBOM_Click);
            // 
            // fld_trlICProductItems
            // 
            this.fld_trlICProductItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.behaviorManager1.SetBehaviors(this.fld_trlICProductItems, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraTreeList.TreeListDragDropSource), true, true, true, true, this.dragDropEvents1)))});
            this.fld_trlICProductItems.BOSComment = "";
            this.fld_trlICProductItems.BOSDataMember = null;
            this.fld_trlICProductItems.BOSDataSource = "ICProductItems";
            this.fld_trlICProductItems.BOSDescription = null;
            this.fld_trlICProductItems.BOSDisplayOption = true;
            this.fld_trlICProductItems.BOSDisplayRoot = false;
            this.fld_trlICProductItems.BOSError = "";
            this.fld_trlICProductItems.BOSFieldGroup = "";
            this.fld_trlICProductItems.BOSFieldRelation = null;
            this.fld_trlICProductItems.BOSPrivilege = "";
            this.fld_trlICProductItems.BOSPropertyName = null;
            this.fld_trlICProductItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlICProductItems.KeyFieldName = "ICProductItemID";
            this.fld_trlICProductItems.Location = new System.Drawing.Point(0, 42);
            this.fld_trlICProductItems.Name = "fld_trlICProductItems";
            this.fld_trlICProductItems.ParentFieldName = "ICProductItemParentID";
            this.fld_trlICProductItems.Screen = null;
            this.fld_trlICProductItems.Size = new System.Drawing.Size(2300, 634);
            this.fld_trlICProductItems.TabIndex = 94;
            this.fld_trlICProductItems.Tag = "DC";
            // 
            // fld_tabPackageNo
            // 
            this.fld_tabPackageNo.Controls.Add(this.fld_pnlPackageDetail);
            this.fld_tabPackageNo.Name = "fld_tabPackageNo";
            this.fld_tabPackageNo.Size = new System.Drawing.Size(2303, 682);
            this.fld_tabPackageNo.Text = "Danh sách kiện";
            // 
            // fld_pnlPackageDetail
            // 
            this.fld_pnlPackageDetail.Controls.Add(this.bosLabel45);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_splTicket);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_btnSavePackeNo);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_lblHeigth);
            this.fld_pnlPackageDetail.Controls.Add(this.bosLabel46);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_lblWidth);
            this.fld_pnlPackageDetail.Controls.Add(this.bosLabel47);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_lblLength);
            this.fld_pnlPackageDetail.Controls.Add(this.bosLabel48);
            this.fld_pnlPackageDetail.Controls.Add(this.fld_lblVolumn);
            this.fld_pnlPackageDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlPackageDetail.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlPackageDetail.Name = "fld_pnlPackageDetail";
            this.fld_pnlPackageDetail.Size = new System.Drawing.Size(2303, 682);
            this.fld_pnlPackageDetail.TabIndex = 414;
            // 
            // bosLabel45
            // 
            this.bosLabel45.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel45.Appearance.Options.UseFont = true;
            this.bosLabel45.BOSComment = null;
            this.bosLabel45.BOSDataMember = null;
            this.bosLabel45.BOSDataSource = null;
            this.bosLabel45.BOSDescription = null;
            this.bosLabel45.BOSError = null;
            this.bosLabel45.BOSFieldGroup = null;
            this.bosLabel45.BOSFieldRelation = null;
            this.bosLabel45.BOSPrivilege = null;
            this.bosLabel45.BOSPropertyName = null;
            this.bosLabel45.Location = new System.Drawing.Point(145, 6);
            this.bosLabel45.Name = "bosLabel45";
            this.bosLabel45.Screen = null;
            this.bosLabel45.Size = new System.Drawing.Size(67, 13);
            this.bosLabel45.TabIndex = 412;
            this.bosLabel45.Text = "Rộng (mm):";
            // 
            // fld_splTicket
            // 
            this.fld_splTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_splTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_splTicket.Location = new System.Drawing.Point(9, 26);
            this.fld_splTicket.Name = "fld_splTicket";
            // 
            // fld_splTicket.Panel1
            // 
            this.fld_splTicket.Panel1.Controls.Add(this.bosLine8);
            this.fld_splTicket.Panel1.Text = "Panel1";
            // 
            // fld_splTicket.Panel2
            // 
            this.fld_splTicket.Panel2.Controls.Add(this.bosLine9);
            this.fld_splTicket.Panel2.Text = "Panel2";
            this.fld_splTicket.Size = new System.Drawing.Size(2309, 645);
            this.fld_splTicket.SplitterPosition = 830;
            this.fld_splTicket.TabIndex = 411;
            this.fld_splTicket.Text = "splitContainerControl2";
            // 
            // bosLine8
            // 
            this.bosLine8.BOSComment = null;
            this.bosLine8.BOSDataMember = null;
            this.bosLine8.BOSDataSource = null;
            this.bosLine8.BOSDescription = null;
            this.bosLine8.BOSError = null;
            this.bosLine8.BOSFieldGroup = null;
            this.bosLine8.BOSFieldRelation = null;
            this.bosLine8.BOSPrivilege = null;
            this.bosLine8.BOSPropertyName = null;
            this.bosLine8.Controls.Add(this.fld_dgcICProductPackages);
            this.bosLine8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine8.Location = new System.Drawing.Point(0, 0);
            this.bosLine8.Name = "bosLine8";
            this.bosLine8.Screen = null;
            this.bosLine8.Size = new System.Drawing.Size(830, 641);
            this.bosLine8.TabIndex = 405;
            this.bosLine8.TabStop = false;
            this.bosLine8.Text = "Thông tin kiện";
            // 
            // fld_dgcICProductPackages
            // 
            this.fld_dgcICProductPackages.BOSComment = null;
            this.fld_dgcICProductPackages.BOSDataMember = null;
            this.fld_dgcICProductPackages.BOSDataSource = "ICProductPackages";
            this.fld_dgcICProductPackages.BOSDescription = null;
            this.fld_dgcICProductPackages.BOSError = null;
            this.fld_dgcICProductPackages.BOSFieldGroup = null;
            this.fld_dgcICProductPackages.BOSFieldRelation = null;
            this.fld_dgcICProductPackages.BOSGridType = null;
            this.fld_dgcICProductPackages.BOSPrivilege = null;
            this.fld_dgcICProductPackages.BOSPropertyName = null;
            this.fld_dgcICProductPackages.CommodityType = "";
            this.fld_dgcICProductPackages.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcICProductPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductPackages.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICProductPackages.MenuManager = this.screenToolbar;
            this.fld_dgcICProductPackages.Name = "fld_dgcICProductPackages";
            this.fld_dgcICProductPackages.PrintReport = false;
            this.fld_dgcICProductPackages.Screen = null;
            this.fld_dgcICProductPackages.Size = new System.Drawing.Size(824, 621);
            this.fld_dgcICProductPackages.TabIndex = 404;
            this.fld_dgcICProductPackages.Tag = "DC";
            // 
            // bosLine9
            // 
            this.bosLine9.BOSComment = null;
            this.bosLine9.BOSDataMember = null;
            this.bosLine9.BOSDataSource = null;
            this.bosLine9.BOSDescription = null;
            this.bosLine9.BOSError = null;
            this.bosLine9.BOSFieldGroup = null;
            this.bosLine9.BOSFieldRelation = null;
            this.bosLine9.BOSPrivilege = null;
            this.bosLine9.BOSPropertyName = null;
            this.bosLine9.Controls.Add(this.fld_dgcMMProductionNormItemPackings);
            this.bosLine9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine9.Location = new System.Drawing.Point(0, 0);
            this.bosLine9.Name = "bosLine9";
            this.bosLine9.Screen = null;
            this.bosLine9.Size = new System.Drawing.Size(1465, 641);
            this.bosLine9.TabIndex = 404;
            this.bosLine9.TabStop = false;
            this.bosLine9.Text = "Thông tin đóng gói";
            // 
            // fld_dgcMMProductionNormItemPackings
            // 
            this.fld_dgcMMProductionNormItemPackings.BOSComment = null;
            this.fld_dgcMMProductionNormItemPackings.BOSDataMember = null;
            this.fld_dgcMMProductionNormItemPackings.BOSDataSource = "MMProductionNormItemPackings";
            this.fld_dgcMMProductionNormItemPackings.BOSDescription = null;
            this.fld_dgcMMProductionNormItemPackings.BOSError = null;
            this.fld_dgcMMProductionNormItemPackings.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItemPackings.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItemPackings.BOSGridType = null;
            this.fld_dgcMMProductionNormItemPackings.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItemPackings.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItemPackings.CommodityType = "";
            this.fld_dgcMMProductionNormItemPackings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionNormItemPackings.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcMMProductionNormItemPackings.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItemPackings.Name = "fld_dgcMMProductionNormItemPackings";
            this.fld_dgcMMProductionNormItemPackings.PrintReport = false;
            this.fld_dgcMMProductionNormItemPackings.Screen = null;
            this.fld_dgcMMProductionNormItemPackings.Size = new System.Drawing.Size(1459, 621);
            this.fld_dgcMMProductionNormItemPackings.TabIndex = 402;
            this.fld_dgcMMProductionNormItemPackings.Tag = "DC";
            // 
            // fld_btnSavePackeNo
            // 
            this.fld_btnSavePackeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSavePackeNo.BOSComment = null;
            this.fld_btnSavePackeNo.BOSDataMember = null;
            this.fld_btnSavePackeNo.BOSDataSource = null;
            this.fld_btnSavePackeNo.BOSDescription = null;
            this.fld_btnSavePackeNo.BOSError = null;
            this.fld_btnSavePackeNo.BOSFieldGroup = null;
            this.fld_btnSavePackeNo.BOSFieldRelation = null;
            this.fld_btnSavePackeNo.BOSPrivilege = null;
            this.fld_btnSavePackeNo.BOSPropertyName = null;
            this.fld_btnSavePackeNo.Location = new System.Drawing.Point(2227, 677);
            this.fld_btnSavePackeNo.Name = "fld_btnSavePackeNo";
            this.fld_btnSavePackeNo.Screen = null;
            this.fld_btnSavePackeNo.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSavePackeNo.TabIndex = 3;
            this.fld_btnSavePackeNo.Text = "Lưu";
            this.fld_btnSavePackeNo.Click += new System.EventHandler(this.Fld_btnSavePackeNo_Click);
            // 
            // fld_lblHeigth
            // 
            this.fld_lblHeigth.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblHeigth.Appearance.Options.UseFont = true;
            this.fld_lblHeigth.BOSComment = null;
            this.fld_lblHeigth.BOSDataMember = null;
            this.fld_lblHeigth.BOSDataSource = null;
            this.fld_lblHeigth.BOSDescription = null;
            this.fld_lblHeigth.BOSError = null;
            this.fld_lblHeigth.BOSFieldGroup = null;
            this.fld_lblHeigth.BOSFieldRelation = null;
            this.fld_lblHeigth.BOSPrivilege = null;
            this.fld_lblHeigth.BOSPropertyName = null;
            this.fld_lblHeigth.Location = new System.Drawing.Point(349, 6);
            this.fld_lblHeigth.Name = "fld_lblHeigth";
            this.fld_lblHeigth.Screen = null;
            this.fld_lblHeigth.Size = new System.Drawing.Size(24, 13);
            this.fld_lblHeigth.TabIndex = 412;
            this.fld_lblHeigth.Text = "0.00";
            // 
            // bosLabel46
            // 
            this.bosLabel46.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel46.Appearance.Options.UseFont = true;
            this.bosLabel46.BOSComment = null;
            this.bosLabel46.BOSDataMember = null;
            this.bosLabel46.BOSDataSource = null;
            this.bosLabel46.BOSDescription = null;
            this.bosLabel46.BOSError = null;
            this.bosLabel46.BOSFieldGroup = null;
            this.bosLabel46.BOSFieldRelation = null;
            this.bosLabel46.BOSPrivilege = null;
            this.bosLabel46.BOSPropertyName = null;
            this.bosLabel46.Location = new System.Drawing.Point(423, 6);
            this.bosLabel46.Name = "bosLabel46";
            this.bosLabel46.Screen = null;
            this.bosLabel46.Size = new System.Drawing.Size(106, 13);
            this.bosLabel46.TabIndex = 412;
            this.bosLabel46.Text = "Thể tích kiện (m3):";
            // 
            // fld_lblWidth
            // 
            this.fld_lblWidth.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblWidth.Appearance.Options.UseFont = true;
            this.fld_lblWidth.BOSComment = null;
            this.fld_lblWidth.BOSDataMember = null;
            this.fld_lblWidth.BOSDataSource = null;
            this.fld_lblWidth.BOSDescription = null;
            this.fld_lblWidth.BOSError = null;
            this.fld_lblWidth.BOSFieldGroup = null;
            this.fld_lblWidth.BOSFieldRelation = null;
            this.fld_lblWidth.BOSPrivilege = null;
            this.fld_lblWidth.BOSPropertyName = null;
            this.fld_lblWidth.Location = new System.Drawing.Point(218, 6);
            this.fld_lblWidth.Name = "fld_lblWidth";
            this.fld_lblWidth.Screen = null;
            this.fld_lblWidth.Size = new System.Drawing.Size(24, 13);
            this.fld_lblWidth.TabIndex = 412;
            this.fld_lblWidth.Text = "0.00";
            // 
            // bosLabel47
            // 
            this.bosLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel47.Appearance.Options.UseFont = true;
            this.bosLabel47.BOSComment = null;
            this.bosLabel47.BOSDataMember = null;
            this.bosLabel47.BOSDataSource = null;
            this.bosLabel47.BOSDescription = null;
            this.bosLabel47.BOSError = null;
            this.bosLabel47.BOSFieldGroup = null;
            this.bosLabel47.BOSFieldRelation = null;
            this.bosLabel47.BOSPrivilege = null;
            this.bosLabel47.BOSPropertyName = null;
            this.bosLabel47.Location = new System.Drawing.Point(10, 6);
            this.bosLabel47.Name = "bosLabel47";
            this.bosLabel47.Screen = null;
            this.bosLabel47.Size = new System.Drawing.Size(56, 13);
            this.bosLabel47.TabIndex = 412;
            this.bosLabel47.Text = "Dài (mm):";
            // 
            // fld_lblLength
            // 
            this.fld_lblLength.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLength.Appearance.Options.UseFont = true;
            this.fld_lblLength.BOSComment = null;
            this.fld_lblLength.BOSDataMember = null;
            this.fld_lblLength.BOSDataSource = null;
            this.fld_lblLength.BOSDescription = null;
            this.fld_lblLength.BOSError = null;
            this.fld_lblLength.BOSFieldGroup = null;
            this.fld_lblLength.BOSFieldRelation = null;
            this.fld_lblLength.BOSPrivilege = null;
            this.fld_lblLength.BOSPropertyName = null;
            this.fld_lblLength.Location = new System.Drawing.Point(72, 6);
            this.fld_lblLength.Name = "fld_lblLength";
            this.fld_lblLength.Screen = null;
            this.fld_lblLength.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLength.TabIndex = 412;
            this.fld_lblLength.Text = "0.00";
            // 
            // bosLabel48
            // 
            this.bosLabel48.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel48.Appearance.Options.UseFont = true;
            this.bosLabel48.BOSComment = null;
            this.bosLabel48.BOSDataMember = null;
            this.bosLabel48.BOSDataSource = null;
            this.bosLabel48.BOSDescription = null;
            this.bosLabel48.BOSError = null;
            this.bosLabel48.BOSFieldGroup = null;
            this.bosLabel48.BOSFieldRelation = null;
            this.bosLabel48.BOSPrivilege = null;
            this.bosLabel48.BOSPropertyName = null;
            this.bosLabel48.Location = new System.Drawing.Point(284, 6);
            this.bosLabel48.Name = "bosLabel48";
            this.bosLabel48.Screen = null;
            this.bosLabel48.Size = new System.Drawing.Size(59, 13);
            this.bosLabel48.TabIndex = 412;
            this.bosLabel48.Text = "Cao (mm):";
            // 
            // fld_lblVolumn
            // 
            this.fld_lblVolumn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblVolumn.Appearance.Options.UseFont = true;
            this.fld_lblVolumn.BOSComment = null;
            this.fld_lblVolumn.BOSDataMember = null;
            this.fld_lblVolumn.BOSDataSource = null;
            this.fld_lblVolumn.BOSDescription = null;
            this.fld_lblVolumn.BOSError = null;
            this.fld_lblVolumn.BOSFieldGroup = null;
            this.fld_lblVolumn.BOSFieldRelation = null;
            this.fld_lblVolumn.BOSPrivilege = null;
            this.fld_lblVolumn.BOSPropertyName = null;
            this.fld_lblVolumn.Location = new System.Drawing.Point(535, 6);
            this.fld_lblVolumn.Name = "fld_lblVolumn";
            this.fld_lblVolumn.Screen = null;
            this.fld_lblVolumn.Size = new System.Drawing.Size(24, 13);
            this.fld_lblVolumn.TabIndex = 412;
            this.fld_lblVolumn.Text = "0.00";
            // 
            // tpBOM
            // 
            this.tpBOM.Controls.Add(this.bosPanel5);
            this.tpBOM.Name = "tpBOM";
            this.tpBOM.Size = new System.Drawing.Size(2303, 682);
            this.tpBOM.Text = "Chi tiết định mức";
            // 
            // bosPanel5
            // 
            this.bosPanel5.AutoScroll = true;
            this.bosPanel5.BOSComment = null;
            this.bosPanel5.BOSDataMember = null;
            this.bosPanel5.BOSDataSource = null;
            this.bosPanel5.BOSDescription = null;
            this.bosPanel5.BOSError = null;
            this.bosPanel5.BOSFieldGroup = null;
            this.bosPanel5.BOSFieldRelation = null;
            this.bosPanel5.BOSPrivilege = null;
            this.bosPanel5.BOSPropertyName = null;
            this.bosPanel5.Controls.Add(this.fld_tcBOM);
            this.bosPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel5.Location = new System.Drawing.Point(0, 0);
            this.bosPanel5.Name = "bosPanel5";
            this.bosPanel5.Screen = null;
            this.bosPanel5.Size = new System.Drawing.Size(2303, 682);
            this.bosPanel5.TabIndex = 0;
            // 
            // fld_tcBOM
            // 
            this.fld_tcBOM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.fld_tcBOM.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_tcBOM.BOSComment = null;
            this.fld_tcBOM.BOSDataMember = null;
            this.fld_tcBOM.BOSDataSource = null;
            this.fld_tcBOM.BOSDescription = null;
            this.fld_tcBOM.BOSError = null;
            this.fld_tcBOM.BOSFieldGroup = null;
            this.fld_tcBOM.BOSFieldRelation = null;
            this.fld_tcBOM.BOSPrivilege = null;
            this.fld_tcBOM.BOSPropertyName = null;
            this.fld_tcBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tcBOM.Location = new System.Drawing.Point(0, 0);
            this.fld_tcBOM.Name = "fld_tcBOM";
            this.fld_tcBOM.Screen = null;
            this.fld_tcBOM.SelectedTabPage = this.fld_tpSemiProduct;
            this.fld_tcBOM.Size = new System.Drawing.Size(2303, 682);
            this.fld_tcBOM.TabIndex = 97;
            this.fld_tcBOM.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tpSemiProduct,
            this.fld_tpHardware,
            this.fld_tpPaint,
            this.fld_tpPackaging,
            this.fld_tpOther});
            this.fld_tcBOM.UseDisabledStatePainter = false;
            this.fld_tcBOM.SizeChanged += new System.EventHandler(this.bosTabControl3_SizeChanged);
            // 
            // fld_tpSemiProduct
            // 
            this.fld_tpSemiProduct.Controls.Add(this.bosPanel9);
            this.fld_tpSemiProduct.Name = "fld_tpSemiProduct";
            this.fld_tpSemiProduct.Size = new System.Drawing.Size(2297, 653);
            this.fld_tpSemiProduct.Text = "Bán thành phẩm";
            // 
            // bosPanel9
            // 
            this.bosPanel9.AutoScroll = true;
            this.bosPanel9.BOSComment = null;
            this.bosPanel9.BOSDataMember = null;
            this.bosPanel9.BOSDataSource = null;
            this.bosPanel9.BOSDescription = null;
            this.bosPanel9.BOSError = null;
            this.bosPanel9.BOSFieldGroup = null;
            this.bosPanel9.BOSFieldRelation = null;
            this.bosPanel9.BOSPrivilege = null;
            this.bosPanel9.BOSPropertyName = null;
            this.bosPanel9.Controls.Add(this.bosButton6);
            this.bosPanel9.Controls.Add(this.fld_btnPrintSemiProduct);
            this.bosPanel9.Controls.Add(this.bosLine6);
            this.bosPanel9.Controls.Add(this.fld_btnEditMMProductionNormWoodStatus);
            this.bosPanel9.Controls.Add(this.fld_btnApproveMMProductionNormWoodStatus);
            this.bosPanel9.Controls.Add(this.bosLabel24);
            this.bosPanel9.Controls.Add(this.fld_lkeMMProductionNormWoodStatus);
            this.bosPanel9.Controls.Add(this.fld_trlProductionNormItemTreeList);
            this.bosPanel9.Controls.Add(this.fld_btnSaveBOM);
            this.bosPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel9.Location = new System.Drawing.Point(0, 0);
            this.bosPanel9.Name = "bosPanel9";
            this.bosPanel9.Screen = null;
            this.bosPanel9.Size = new System.Drawing.Size(2297, 653);
            this.bosPanel9.TabIndex = 96;
            // 
            // bosButton6
            // 
            this.bosButton6.BOSComment = null;
            this.bosButton6.BOSDataMember = null;
            this.bosButton6.BOSDataSource = null;
            this.bosButton6.BOSDescription = null;
            this.bosButton6.BOSError = null;
            this.bosButton6.BOSFieldGroup = null;
            this.bosButton6.BOSFieldRelation = null;
            this.bosButton6.BOSPrivilege = null;
            this.bosButton6.BOSPropertyName = null;
            this.bosButton6.Location = new System.Drawing.Point(702, 42);
            this.bosButton6.Name = "bosButton6";
            this.bosButton6.Screen = null;
            this.bosButton6.Size = new System.Drawing.Size(75, 20);
            this.bosButton6.TabIndex = 156;
            this.bosButton6.Text = "In (m2)";
            this.bosButton6.Click += new System.EventHandler(this.bosButton6_Click_1);
            // 
            // fld_btnPrintSemiProduct
            // 
            this.fld_btnPrintSemiProduct.BOSComment = null;
            this.fld_btnPrintSemiProduct.BOSDataMember = null;
            this.fld_btnPrintSemiProduct.BOSDataSource = null;
            this.fld_btnPrintSemiProduct.BOSDescription = null;
            this.fld_btnPrintSemiProduct.BOSError = null;
            this.fld_btnPrintSemiProduct.BOSFieldGroup = null;
            this.fld_btnPrintSemiProduct.BOSFieldRelation = null;
            this.fld_btnPrintSemiProduct.BOSPrivilege = null;
            this.fld_btnPrintSemiProduct.BOSPropertyName = null;
            this.fld_btnPrintSemiProduct.Location = new System.Drawing.Point(621, 42);
            this.fld_btnPrintSemiProduct.Name = "fld_btnPrintSemiProduct";
            this.fld_btnPrintSemiProduct.Screen = null;
            this.fld_btnPrintSemiProduct.Size = new System.Drawing.Size(75, 20);
            this.fld_btnPrintSemiProduct.TabIndex = 155;
            this.fld_btnPrintSemiProduct.Text = "In";
            this.fld_btnPrintSemiProduct.Click += new System.EventHandler(this.Fld_btnPrintSemiProduct_Click_1);
            // 
            // bosLine6
            // 
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.bosMemoEdit1);
            this.bosLine6.Location = new System.Drawing.Point(13, 3);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(343, 62);
            this.bosLine6.TabIndex = 148;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Diễn giải";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "MMProductionNormSemiProductDesc";
            this.bosMemoEdit1.BOSDataSource = "MMProductionNorms";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(3, 17);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(337, 42);
            this.bosMemoEdit1.TabIndex = 147;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_btnEditMMProductionNormWoodStatus
            // 
            this.fld_btnEditMMProductionNormWoodStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSError = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormWoodStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormWoodStatus.Location = new System.Drawing.Point(540, 42);
            this.fld_btnEditMMProductionNormWoodStatus.Name = "fld_btnEditMMProductionNormWoodStatus";
            this.fld_btnEditMMProductionNormWoodStatus.Screen = this;
            this.fld_btnEditMMProductionNormWoodStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormWoodStatus.TabIndex = 145;
            this.fld_btnEditMMProductionNormWoodStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormWoodStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormWoodStatus_Click);
            // 
            // fld_btnApproveMMProductionNormWoodStatus
            // 
            this.fld_btnApproveMMProductionNormWoodStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormWoodStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormWoodStatus.Location = new System.Drawing.Point(459, 42);
            this.fld_btnApproveMMProductionNormWoodStatus.Name = "fld_btnApproveMMProductionNormWoodStatus";
            this.fld_btnApproveMMProductionNormWoodStatus.Screen = this;
            this.fld_btnApproveMMProductionNormWoodStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormWoodStatus.TabIndex = 144;
            this.fld_btnApproveMMProductionNormWoodStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormWoodStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormWoodStatus_Click);
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
            this.bosLabel24.Location = new System.Drawing.Point(381, 19);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(48, 13);
            this.bosLabel24.TabIndex = 139;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormWoodStatus
            // 
            this.fld_lkeMMProductionNormWoodStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormWoodStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormWoodStatus.BOSComment = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSDataMember = "MMProductionNormWoodStatus";
            this.fld_lkeMMProductionNormWoodStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormWoodStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormWoodStatus.BOSError = null;
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormWoodStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormWoodStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormWoodStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormWoodStatus.Location = new System.Drawing.Point(447, 16);
            this.fld_lkeMMProductionNormWoodStatus.Name = "fld_lkeMMProductionNormWoodStatus";
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormWoodStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormWoodStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormWoodStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormWoodStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormWoodStatus.Screen = null;
            this.fld_lkeMMProductionNormWoodStatus.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeMMProductionNormWoodStatus.TabIndex = 138;
            this.fld_lkeMMProductionNormWoodStatus.Tag = "DC";
            this.fld_lkeMMProductionNormWoodStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormWoodStatus_EditValueChanged);
            // 
            // fld_trlProductionNormItemTreeList
            // 
            this.fld_trlProductionNormItemTreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlProductionNormItemTreeList.BOSComment = "";
            this.fld_trlProductionNormItemTreeList.BOSDataMember = null;
            this.fld_trlProductionNormItemTreeList.BOSDataSource = "MMProductionNormItems";
            this.fld_trlProductionNormItemTreeList.BOSDescription = null;
            this.fld_trlProductionNormItemTreeList.BOSDisplayOption = false;
            this.fld_trlProductionNormItemTreeList.BOSDisplayRoot = false;
            this.fld_trlProductionNormItemTreeList.BOSError = "";
            this.fld_trlProductionNormItemTreeList.BOSFieldGroup = "";
            this.fld_trlProductionNormItemTreeList.BOSFieldRelation = null;
            this.fld_trlProductionNormItemTreeList.BOSPrivilege = "";
            this.fld_trlProductionNormItemTreeList.BOSPropertyName = null;
            this.fld_trlProductionNormItemTreeList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlProductionNormItemTreeList.Location = new System.Drawing.Point(3, 71);
            this.fld_trlProductionNormItemTreeList.Name = "fld_trlProductionNormItemTreeList";
            this.fld_trlProductionNormItemTreeList.Screen = null;
            this.fld_trlProductionNormItemTreeList.Size = new System.Drawing.Size(2291, 579);
            this.fld_trlProductionNormItemTreeList.TabIndex = 94;
            this.fld_trlProductionNormItemTreeList.Tag = "DC";
            this.fld_trlProductionNormItemTreeList.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlProductionNormItemTreeList_NodeCellStyle);
            this.fld_trlProductionNormItemTreeList.DoubleClick += new System.EventHandler(this.fld_trlProductionNormItemTreeList_DoubleClick);
            // 
            // fld_btnSaveBOM
            // 
            this.fld_btnSaveBOM.BOSComment = null;
            this.fld_btnSaveBOM.BOSDataMember = null;
            this.fld_btnSaveBOM.BOSDataSource = null;
            this.fld_btnSaveBOM.BOSDescription = null;
            this.fld_btnSaveBOM.BOSError = null;
            this.fld_btnSaveBOM.BOSFieldGroup = null;
            this.fld_btnSaveBOM.BOSFieldRelation = null;
            this.fld_btnSaveBOM.BOSPrivilege = null;
            this.fld_btnSaveBOM.BOSPropertyName = null;
            this.fld_btnSaveBOM.Location = new System.Drawing.Point(378, 42);
            this.fld_btnSaveBOM.Name = "fld_btnSaveBOM";
            this.fld_btnSaveBOM.Screen = null;
            this.fld_btnSaveBOM.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSaveBOM.TabIndex = 95;
            this.fld_btnSaveBOM.Text = "Lưu";
            this.fld_btnSaveBOM.Click += new System.EventHandler(this.fld_btnSaveBOM_Click);
            // 
            // fld_tpHardware
            // 
            this.fld_tpHardware.Controls.Add(this.bosPanel10);
            this.fld_tpHardware.Name = "fld_tpHardware";
            this.fld_tpHardware.Size = new System.Drawing.Size(2297, 653);
            this.fld_tpHardware.Text = "Hardware";
            // 
            // bosPanel10
            // 
            this.bosPanel10.AutoScroll = true;
            this.bosPanel10.BOSComment = null;
            this.bosPanel10.BOSDataMember = null;
            this.bosPanel10.BOSDataSource = null;
            this.bosPanel10.BOSDescription = null;
            this.bosPanel10.BOSError = null;
            this.bosPanel10.BOSFieldGroup = null;
            this.bosPanel10.BOSFieldRelation = null;
            this.bosPanel10.BOSPrivilege = null;
            this.bosPanel10.BOSPropertyName = null;
            this.bosPanel10.Controls.Add(this.fld_txtDepreciationRateHardware);
            this.bosPanel10.Controls.Add(this.bosLabel52);
            this.bosPanel10.Controls.Add(this.bosLine12);
            this.bosPanel10.Controls.Add(this.fld_btnHardware);
            this.bosPanel10.Controls.Add(this.bosLine7);
            this.bosPanel10.Controls.Add(this.fld_btnEditMMProductionNormHardwareStatus);
            this.bosPanel10.Controls.Add(this.fld_btnApproveMMProductionNormHardwareStatus);
            this.bosPanel10.Controls.Add(this.bosLabel26);
            this.bosPanel10.Controls.Add(this.fld_lkeMMProductionNormHardwareStatus);
            this.bosPanel10.Controls.Add(this.fld_lkeICProductHardwareID);
            this.bosPanel10.Controls.Add(this.fld_btnSaveHardware);
            this.bosPanel10.Controls.Add(this.fld_btnChangeHardware);
            this.bosPanel10.Controls.Add(this.fld_trlMMProductionNormItemsHardware);
            this.bosPanel10.Controls.Add(this.bosLabel25);
            this.bosPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel10.Location = new System.Drawing.Point(0, 0);
            this.bosPanel10.Name = "bosPanel10";
            this.bosPanel10.Screen = null;
            this.bosPanel10.Size = new System.Drawing.Size(2297, 653);
            this.bosPanel10.TabIndex = 132;
            // 
            // fld_txtDepreciationRateHardware
            // 
            this.fld_txtDepreciationRateHardware.BOSComment = "";
            this.fld_txtDepreciationRateHardware.BOSDataMember = "";
            this.fld_txtDepreciationRateHardware.BOSDataSource = "";
            this.fld_txtDepreciationRateHardware.BOSDescription = null;
            this.fld_txtDepreciationRateHardware.BOSError = null;
            this.fld_txtDepreciationRateHardware.BOSFieldGroup = "";
            this.fld_txtDepreciationRateHardware.BOSFieldRelation = "";
            this.fld_txtDepreciationRateHardware.BOSPrivilege = "";
            this.fld_txtDepreciationRateHardware.BOSPropertyName = "Text";
            this.fld_txtDepreciationRateHardware.EditValue = "";
            this.fld_txtDepreciationRateHardware.Location = new System.Drawing.Point(603, 45);
            this.fld_txtDepreciationRateHardware.Name = "fld_txtDepreciationRateHardware";
            this.fld_txtDepreciationRateHardware.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtDepreciationRateHardware.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDepreciationRateHardware.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDepreciationRateHardware.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDepreciationRateHardware.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtDepreciationRateHardware.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateHardware.Properties.EditFormat.FormatString = "n2";
            this.fld_txtDepreciationRateHardware.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateHardware.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDepreciationRateHardware.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtDepreciationRateHardware.Properties.MaskSettings.Set("mask", "n2");
            this.fld_txtDepreciationRateHardware.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDepreciationRateHardware.Screen = null;
            this.fld_txtDepreciationRateHardware.Size = new System.Drawing.Size(32, 20);
            this.fld_txtDepreciationRateHardware.TabIndex = 160;
            this.fld_txtDepreciationRateHardware.Tag = "DC";
            this.fld_txtDepreciationRateHardware.ToolTip = "Nhấn Enter để cập nhật xuống chi tiết";
            // 
            // bosLabel52
            // 
            this.bosLabel52.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel52.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel52.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel52.Appearance.Options.UseBackColor = true;
            this.bosLabel52.Appearance.Options.UseFont = true;
            this.bosLabel52.Appearance.Options.UseForeColor = true;
            this.bosLabel52.BOSComment = "";
            this.bosLabel52.BOSDataMember = "";
            this.bosLabel52.BOSDataSource = "";
            this.bosLabel52.BOSDescription = null;
            this.bosLabel52.BOSError = null;
            this.bosLabel52.BOSFieldGroup = "";
            this.bosLabel52.BOSFieldRelation = "";
            this.bosLabel52.BOSPrivilege = "";
            this.bosLabel52.BOSPropertyName = null;
            this.bosLabel52.Location = new System.Drawing.Point(525, 48);
            this.bosLabel52.Name = "bosLabel52";
            this.bosLabel52.Screen = null;
            this.bosLabel52.Size = new System.Drawing.Size(61, 13);
            this.bosLabel52.TabIndex = 159;
            this.bosLabel52.Tag = "";
            this.bosLabel52.Text = "Tỉ lệ tiêu hao";
            // 
            // bosLine12
            // 
            this.bosLine12.BOSComment = null;
            this.bosLine12.BOSDataMember = null;
            this.bosLine12.BOSDataSource = null;
            this.bosLine12.BOSDescription = null;
            this.bosLine12.BOSError = null;
            this.bosLine12.BOSFieldGroup = null;
            this.bosLine12.BOSFieldRelation = null;
            this.bosLine12.BOSPrivilege = null;
            this.bosLine12.BOSPropertyName = null;
            this.bosLine12.Controls.Add(this.fld_btnCopyHW);
            this.bosLine12.Controls.Add(this.bosLabel42);
            this.bosLine12.Controls.Add(this.fld_lkeHWBomTemp);
            this.bosLine12.Location = new System.Drawing.Point(774, 8);
            this.bosLine12.Name = "bosLine12";
            this.bosLine12.Screen = null;
            this.bosLine12.Size = new System.Drawing.Size(333, 59);
            this.bosLine12.TabIndex = 157;
            this.bosLine12.TabStop = false;
            this.bosLine12.Text = "Sao chép";
            // 
            // fld_btnCopyHW
            // 
            this.fld_btnCopyHW.BOSComment = null;
            this.fld_btnCopyHW.BOSDataMember = null;
            this.fld_btnCopyHW.BOSDataSource = null;
            this.fld_btnCopyHW.BOSDescription = null;
            this.fld_btnCopyHW.BOSError = null;
            this.fld_btnCopyHW.BOSFieldGroup = null;
            this.fld_btnCopyHW.BOSFieldRelation = null;
            this.fld_btnCopyHW.BOSPrivilege = null;
            this.fld_btnCopyHW.BOSPropertyName = null;
            this.fld_btnCopyHW.Location = new System.Drawing.Point(267, 18);
            this.fld_btnCopyHW.Name = "fld_btnCopyHW";
            this.fld_btnCopyHW.Screen = null;
            this.fld_btnCopyHW.Size = new System.Drawing.Size(58, 27);
            this.fld_btnCopyHW.TabIndex = 112;
            this.fld_btnCopyHW.Text = "Sao chép";
            this.fld_btnCopyHW.Click += new System.EventHandler(this.fld_btnCopyHW_Click);
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
            this.bosLabel42.Location = new System.Drawing.Point(24, 28);
            this.bosLabel42.Name = "bosLabel42";
            this.bosLabel42.Screen = null;
            this.bosLabel42.Size = new System.Drawing.Size(45, 13);
            this.bosLabel42.TabIndex = 0;
            this.bosLabel42.Text = "BĐM Mẫu";
            // 
            // fld_lkeHWBomTemp
            // 
            this.fld_lkeHWBomTemp.BOSAllowAddNew = false;
            this.fld_lkeHWBomTemp.BOSAllowDummy = true;
            this.fld_lkeHWBomTemp.BOSComment = null;
            this.fld_lkeHWBomTemp.BOSDataMember = null;
            this.fld_lkeHWBomTemp.BOSDataSource = null;
            this.fld_lkeHWBomTemp.BOSDescription = null;
            this.fld_lkeHWBomTemp.BOSError = null;
            this.fld_lkeHWBomTemp.BOSFieldGroup = null;
            this.fld_lkeHWBomTemp.BOSFieldParent = null;
            this.fld_lkeHWBomTemp.BOSFieldRelation = null;
            this.fld_lkeHWBomTemp.BOSPrivilege = null;
            this.fld_lkeHWBomTemp.BOSPropertyName = null;
            this.fld_lkeHWBomTemp.BOSSelectType = null;
            this.fld_lkeHWBomTemp.BOSSelectTypeValue = null;
            this.fld_lkeHWBomTemp.CurrentDisplayText = null;
            this.fld_lkeHWBomTemp.Location = new System.Drawing.Point(82, 24);
            this.fld_lkeHWBomTemp.MenuManager = this.screenToolbar;
            this.fld_lkeHWBomTemp.Name = "fld_lkeHWBomTemp";
            this.fld_lkeHWBomTemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHWBomTemp.Properties.ColumnName = null;
            this.fld_lkeHWBomTemp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã hàng mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Bảng định mức")});
            this.fld_lkeHWBomTemp.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeHWBomTemp.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeHWBomTemp.Screen = null;
            this.fld_lkeHWBomTemp.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeHWBomTemp.TabIndex = 110;
            this.fld_lkeHWBomTemp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHWBomTemp_QueryPopUp);
            // 
            // fld_btnHardware
            // 
            this.fld_btnHardware.BOSComment = null;
            this.fld_btnHardware.BOSDataMember = null;
            this.fld_btnHardware.BOSDataSource = null;
            this.fld_btnHardware.BOSDescription = null;
            this.fld_btnHardware.BOSError = null;
            this.fld_btnHardware.BOSFieldGroup = null;
            this.fld_btnHardware.BOSFieldRelation = null;
            this.fld_btnHardware.BOSPrivilege = null;
            this.fld_btnHardware.BOSPropertyName = null;
            this.fld_btnHardware.Location = new System.Drawing.Point(684, 44);
            this.fld_btnHardware.Name = "fld_btnHardware";
            this.fld_btnHardware.Screen = null;
            this.fld_btnHardware.Size = new System.Drawing.Size(75, 20);
            this.fld_btnHardware.TabIndex = 156;
            this.fld_btnHardware.Text = "In";
            this.fld_btnHardware.Click += new System.EventHandler(this.Fld_btnHardware_Click);
            // 
            // bosLine7
            // 
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.bosMemoEdit2);
            this.bosLine7.Location = new System.Drawing.Point(13, 3);
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.bosLine7.Size = new System.Drawing.Size(250, 62);
            this.bosLine7.TabIndex = 149;
            this.bosLine7.TabStop = false;
            this.bosLine7.Text = "Diễn giải";
            // 
            // bosMemoEdit2
            // 
            this.bosMemoEdit2.BOSComment = "";
            this.bosMemoEdit2.BOSDataMember = "MMProductionNormHardwareDesc";
            this.bosMemoEdit2.BOSDataSource = "MMProductionNorms";
            this.bosMemoEdit2.BOSDescription = null;
            this.bosMemoEdit2.BOSError = null;
            this.bosMemoEdit2.BOSFieldGroup = "";
            this.bosMemoEdit2.BOSFieldRelation = "";
            this.bosMemoEdit2.BOSPrivilege = "";
            this.bosMemoEdit2.BOSPropertyName = "Text";
            this.bosMemoEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosMemoEdit2.EditValue = "";
            this.bosMemoEdit2.Location = new System.Drawing.Point(3, 17);
            this.bosMemoEdit2.Name = "bosMemoEdit2";
            this.bosMemoEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit2.Screen = null;
            this.bosMemoEdit2.Size = new System.Drawing.Size(244, 42);
            this.bosMemoEdit2.TabIndex = 147;
            this.bosMemoEdit2.Tag = "DC";
            // 
            // fld_btnEditMMProductionNormHardwareStatus
            // 
            this.fld_btnEditMMProductionNormHardwareStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSError = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormHardwareStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormHardwareStatus.Location = new System.Drawing.Point(684, 18);
            this.fld_btnEditMMProductionNormHardwareStatus.Name = "fld_btnEditMMProductionNormHardwareStatus";
            this.fld_btnEditMMProductionNormHardwareStatus.Screen = this;
            this.fld_btnEditMMProductionNormHardwareStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormHardwareStatus.TabIndex = 143;
            this.fld_btnEditMMProductionNormHardwareStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormHardwareStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormHardwareStatus_Click);
            // 
            // fld_btnApproveMMProductionNormHardwareStatus
            // 
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormHardwareStatus.Location = new System.Drawing.Point(603, 18);
            this.fld_btnApproveMMProductionNormHardwareStatus.Name = "fld_btnApproveMMProductionNormHardwareStatus";
            this.fld_btnApproveMMProductionNormHardwareStatus.Screen = this;
            this.fld_btnApproveMMProductionNormHardwareStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormHardwareStatus.TabIndex = 142;
            this.fld_btnApproveMMProductionNormHardwareStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormHardwareStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormHardwareStatus_Click);
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel26.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseFont = true;
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
            this.bosLabel26.Location = new System.Drawing.Point(269, 21);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(48, 13);
            this.bosLabel26.TabIndex = 141;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormHardwareStatus
            // 
            this.fld_lkeMMProductionNormHardwareStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormHardwareStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormHardwareStatus.BOSComment = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSDataMember = "MMProductionNormHardwareStatus";
            this.fld_lkeMMProductionNormHardwareStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormHardwareStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormHardwareStatus.BOSError = null;
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormHardwareStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormHardwareStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormHardwareStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormHardwareStatus.Location = new System.Drawing.Point(324, 18);
            this.fld_lkeMMProductionNormHardwareStatus.Name = "fld_lkeMMProductionNormHardwareStatus";
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormHardwareStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormHardwareStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormHardwareStatus.Screen = null;
            this.fld_lkeMMProductionNormHardwareStatus.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeMMProductionNormHardwareStatus.TabIndex = 140;
            this.fld_lkeMMProductionNormHardwareStatus.Tag = "DC";
            this.fld_lkeMMProductionNormHardwareStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormHardwareStatus_EditValueChanged);
            // 
            // fld_lkeICProductHardwareID
            // 
            this.fld_lkeICProductHardwareID.BOSAllowAddNew = false;
            this.fld_lkeICProductHardwareID.BOSAllowDummy = true;
            this.fld_lkeICProductHardwareID.BOSComment = null;
            this.fld_lkeICProductHardwareID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductHardwareID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductHardwareID.BOSDescription = null;
            this.fld_lkeICProductHardwareID.BOSError = null;
            this.fld_lkeICProductHardwareID.BOSFieldGroup = null;
            this.fld_lkeICProductHardwareID.BOSFieldParent = null;
            this.fld_lkeICProductHardwareID.BOSFieldRelation = null;
            this.fld_lkeICProductHardwareID.BOSPrivilege = null;
            this.fld_lkeICProductHardwareID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductHardwareID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductHardwareID.BOSSelectTypeValue = "Hardware;Equipment";
            this.fld_lkeICProductHardwareID.CurrentDisplayText = null;
            this.fld_lkeICProductHardwareID.Location = new System.Drawing.Point(324, 44);
            this.fld_lkeICProductHardwareID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductHardwareID.Name = "fld_lkeICProductHardwareID";
            this.fld_lkeICProductHardwareID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductHardwareID.Properties.ColumnName = null;
            this.fld_lkeICProductHardwareID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductHardwareID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductHardwareID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductHardwareID.Screen = null;
            this.fld_lkeICProductHardwareID.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeICProductHardwareID.TabIndex = 126;
            this.fld_lkeICProductHardwareID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductHardwareID_KeyUp);
            // 
            // fld_btnSaveHardware
            // 
            this.fld_btnSaveHardware.BOSComment = null;
            this.fld_btnSaveHardware.BOSDataMember = null;
            this.fld_btnSaveHardware.BOSDataSource = null;
            this.fld_btnSaveHardware.BOSDescription = null;
            this.fld_btnSaveHardware.BOSError = null;
            this.fld_btnSaveHardware.BOSFieldGroup = null;
            this.fld_btnSaveHardware.BOSFieldRelation = null;
            this.fld_btnSaveHardware.BOSPrivilege = null;
            this.fld_btnSaveHardware.BOSPropertyName = null;
            this.fld_btnSaveHardware.Location = new System.Drawing.Point(522, 18);
            this.fld_btnSaveHardware.Name = "fld_btnSaveHardware";
            this.fld_btnSaveHardware.Screen = null;
            this.fld_btnSaveHardware.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSaveHardware.TabIndex = 104;
            this.fld_btnSaveHardware.Text = "Lưu";
            this.fld_btnSaveHardware.Click += new System.EventHandler(this.bosButton3_Click);
            // 
            // fld_btnChangeHardware
            // 
            this.fld_btnChangeHardware.BOSComment = null;
            this.fld_btnChangeHardware.BOSDataMember = null;
            this.fld_btnChangeHardware.BOSDataSource = null;
            this.fld_btnChangeHardware.BOSDescription = null;
            this.fld_btnChangeHardware.BOSError = null;
            this.fld_btnChangeHardware.BOSFieldGroup = null;
            this.fld_btnChangeHardware.BOSFieldRelation = null;
            this.fld_btnChangeHardware.BOSPrivilege = null;
            this.fld_btnChangeHardware.BOSPropertyName = null;
            this.fld_btnChangeHardware.Location = new System.Drawing.Point(1113, 45);
            this.fld_btnChangeHardware.Name = "fld_btnChangeHardware";
            this.fld_btnChangeHardware.Screen = null;
            this.fld_btnChangeHardware.Size = new System.Drawing.Size(156, 20);
            this.fld_btnChangeHardware.TabIndex = 131;
            this.fld_btnChangeHardware.Text = "Thay đổi hardware";
            this.fld_btnChangeHardware.Click += new System.EventHandler(this.fld_btnChangeHardware_Click);
            // 
            // fld_trlMMProductionNormItemsHardware
            // 
            this.fld_trlMMProductionNormItemsHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsHardware.BOSComment = "";
            this.fld_trlMMProductionNormItemsHardware.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsHardware.BOSDescription = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayOption = false;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsHardware.BOSError = "";
            this.fld_trlMMProductionNormItemsHardware.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsHardware.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsHardware.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsHardware.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsHardware.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsHardware.Location = new System.Drawing.Point(3, 73);
            this.fld_trlMMProductionNormItemsHardware.Name = "fld_trlMMProductionNormItemsHardware";
            this.fld_trlMMProductionNormItemsHardware.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsHardware.Screen = null;
            this.fld_trlMMProductionNormItemsHardware.Size = new System.Drawing.Size(2291, 577);
            this.fld_trlMMProductionNormItemsHardware.TabIndex = 103;
            this.fld_trlMMProductionNormItemsHardware.Tag = "DC";
            this.fld_trlMMProductionNormItemsHardware.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItemsHardware_KeyUp);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseFont = true;
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
            this.bosLabel25.Location = new System.Drawing.Point(269, 47);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(46, 13);
            this.bosLabel25.TabIndex = 125;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Hardware";
            // 
            // fld_tpPaint
            // 
            this.fld_tpPaint.Controls.Add(this.fld_pnlPaint);
            this.fld_tpPaint.Name = "fld_tpPaint";
            this.fld_tpPaint.Size = new System.Drawing.Size(2297, 653);
            this.fld_tpPaint.Text = "Sơn";
            // 
            // fld_pnlPaint
            // 
            this.fld_pnlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlPaint.AutoScroll = true;
            this.fld_pnlPaint.BOSComment = null;
            this.fld_pnlPaint.BOSDataMember = null;
            this.fld_pnlPaint.BOSDataSource = null;
            this.fld_pnlPaint.BOSDescription = null;
            this.fld_pnlPaint.BOSError = null;
            this.fld_pnlPaint.BOSFieldGroup = null;
            this.fld_pnlPaint.BOSFieldRelation = null;
            this.fld_pnlPaint.BOSPrivilege = null;
            this.fld_pnlPaint.BOSPropertyName = null;
            this.fld_pnlPaint.Controls.Add(this.fld_txtDepreciationRateIngredientPaint);
            this.fld_pnlPaint.Controls.Add(this.bosLine14);
            this.fld_pnlPaint.Controls.Add(this.bosButton5);
            this.fld_pnlPaint.Controls.Add(this.bosLabel53);
            this.fld_pnlPaint.Controls.Add(this.fld_btnPrintPaint);
            this.fld_pnlPaint.Controls.Add(this.bosLine10);
            this.fld_pnlPaint.Controls.Add(this.splitContainerControl1);
            this.fld_pnlPaint.Controls.Add(this.fld_btnEditMMProductionNormPaintStatus);
            this.fld_pnlPaint.Controls.Add(this.fld_btnApproveMMProductionNormPaintStatus);
            this.fld_pnlPaint.Controls.Add(this.bosLabel27);
            this.fld_pnlPaint.Controls.Add(this.fld_lkeMMProductionNormPaintStatus);
            this.fld_pnlPaint.Controls.Add(this.bosLabel21);
            this.fld_pnlPaint.Controls.Add(this.fld_lkeMMOperationID);
            this.fld_pnlPaint.Controls.Add(this.fld_btnSavePaint);
            this.fld_pnlPaint.Controls.Add(this.fld_lkeICProductIngredientPaintID);
            this.fld_pnlPaint.Controls.Add(this.bosLabel17);
            this.fld_pnlPaint.Controls.Add(this.fld_lkeMMPaintProcessesID);
            this.fld_pnlPaint.Controls.Add(this.bosLabel13);
            this.fld_pnlPaint.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlPaint.Name = "fld_pnlPaint";
            this.fld_pnlPaint.Screen = null;
            this.fld_pnlPaint.Size = new System.Drawing.Size(2285, 639);
            this.fld_pnlPaint.TabIndex = 0;
            // 
            // fld_txtDepreciationRateIngredientPaint
            // 
            this.fld_txtDepreciationRateIngredientPaint.BOSComment = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSDataMember = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSDataSource = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSDescription = null;
            this.fld_txtDepreciationRateIngredientPaint.BOSError = null;
            this.fld_txtDepreciationRateIngredientPaint.BOSFieldGroup = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSFieldRelation = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSPrivilege = "";
            this.fld_txtDepreciationRateIngredientPaint.BOSPropertyName = "Text";
            this.fld_txtDepreciationRateIngredientPaint.EditValue = "";
            this.fld_txtDepreciationRateIngredientPaint.Location = new System.Drawing.Point(1288, 41);
            this.fld_txtDepreciationRateIngredientPaint.Name = "fld_txtDepreciationRateIngredientPaint";
            this.fld_txtDepreciationRateIngredientPaint.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtDepreciationRateIngredientPaint.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDepreciationRateIngredientPaint.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDepreciationRateIngredientPaint.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDepreciationRateIngredientPaint.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtDepreciationRateIngredientPaint.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateIngredientPaint.Properties.EditFormat.FormatString = "n2";
            this.fld_txtDepreciationRateIngredientPaint.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateIngredientPaint.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDepreciationRateIngredientPaint.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtDepreciationRateIngredientPaint.Properties.MaskSettings.Set("mask", "n2");
            this.fld_txtDepreciationRateIngredientPaint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDepreciationRateIngredientPaint.Screen = null;
            this.fld_txtDepreciationRateIngredientPaint.Size = new System.Drawing.Size(32, 20);
            this.fld_txtDepreciationRateIngredientPaint.TabIndex = 438;
            this.fld_txtDepreciationRateIngredientPaint.Tag = "DC";
            this.fld_txtDepreciationRateIngredientPaint.ToolTip = "Nhấn Enter để cập nhật xuống chi tiết";
            this.fld_txtDepreciationRateIngredientPaint.Visible = false;
            // 
            // bosLine14
            // 
            this.bosLine14.BOSComment = null;
            this.bosLine14.BOSDataMember = null;
            this.bosLine14.BOSDataSource = null;
            this.bosLine14.BOSDescription = null;
            this.bosLine14.BOSError = null;
            this.bosLine14.BOSFieldGroup = null;
            this.bosLine14.BOSFieldRelation = null;
            this.bosLine14.BOSPrivilege = null;
            this.bosLine14.BOSPropertyName = null;
            this.bosLine14.Controls.Add(this.fld_btnCopyPaint);
            this.bosLine14.Controls.Add(this.bosLabel43);
            this.bosLine14.Controls.Add(this.fld_lkePaintTemp);
            this.bosLine14.Location = new System.Drawing.Point(874, 6);
            this.bosLine14.Name = "bosLine14";
            this.bosLine14.Screen = null;
            this.bosLine14.Size = new System.Drawing.Size(333, 59);
            this.bosLine14.TabIndex = 436;
            this.bosLine14.TabStop = false;
            this.bosLine14.Text = "Sao chép";
            // 
            // fld_btnCopyPaint
            // 
            this.fld_btnCopyPaint.BOSComment = null;
            this.fld_btnCopyPaint.BOSDataMember = null;
            this.fld_btnCopyPaint.BOSDataSource = null;
            this.fld_btnCopyPaint.BOSDescription = null;
            this.fld_btnCopyPaint.BOSError = null;
            this.fld_btnCopyPaint.BOSFieldGroup = null;
            this.fld_btnCopyPaint.BOSFieldRelation = null;
            this.fld_btnCopyPaint.BOSPrivilege = null;
            this.fld_btnCopyPaint.BOSPropertyName = null;
            this.fld_btnCopyPaint.Location = new System.Drawing.Point(267, 18);
            this.fld_btnCopyPaint.Name = "fld_btnCopyPaint";
            this.fld_btnCopyPaint.Screen = null;
            this.fld_btnCopyPaint.Size = new System.Drawing.Size(58, 27);
            this.fld_btnCopyPaint.TabIndex = 112;
            this.fld_btnCopyPaint.Text = "Sao chép";
            this.fld_btnCopyPaint.Click += new System.EventHandler(this.fld_btnCopyPaint_Click);
            // 
            // bosLabel43
            // 
            this.bosLabel43.BOSComment = null;
            this.bosLabel43.BOSDataMember = null;
            this.bosLabel43.BOSDataSource = null;
            this.bosLabel43.BOSDescription = null;
            this.bosLabel43.BOSError = null;
            this.bosLabel43.BOSFieldGroup = null;
            this.bosLabel43.BOSFieldRelation = null;
            this.bosLabel43.BOSPrivilege = null;
            this.bosLabel43.BOSPropertyName = null;
            this.bosLabel43.Location = new System.Drawing.Point(24, 28);
            this.bosLabel43.Name = "bosLabel43";
            this.bosLabel43.Screen = null;
            this.bosLabel43.Size = new System.Drawing.Size(45, 13);
            this.bosLabel43.TabIndex = 0;
            this.bosLabel43.Text = "BĐM Mẫu";
            // 
            // fld_lkePaintTemp
            // 
            this.fld_lkePaintTemp.BOSAllowAddNew = false;
            this.fld_lkePaintTemp.BOSAllowDummy = true;
            this.fld_lkePaintTemp.BOSComment = null;
            this.fld_lkePaintTemp.BOSDataMember = null;
            this.fld_lkePaintTemp.BOSDataSource = null;
            this.fld_lkePaintTemp.BOSDescription = null;
            this.fld_lkePaintTemp.BOSError = null;
            this.fld_lkePaintTemp.BOSFieldGroup = null;
            this.fld_lkePaintTemp.BOSFieldParent = null;
            this.fld_lkePaintTemp.BOSFieldRelation = null;
            this.fld_lkePaintTemp.BOSPrivilege = null;
            this.fld_lkePaintTemp.BOSPropertyName = null;
            this.fld_lkePaintTemp.BOSSelectType = null;
            this.fld_lkePaintTemp.BOSSelectTypeValue = null;
            this.fld_lkePaintTemp.CurrentDisplayText = null;
            this.fld_lkePaintTemp.Location = new System.Drawing.Point(82, 24);
            this.fld_lkePaintTemp.MenuManager = this.screenToolbar;
            this.fld_lkePaintTemp.Name = "fld_lkePaintTemp";
            this.fld_lkePaintTemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePaintTemp.Properties.ColumnName = null;
            this.fld_lkePaintTemp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã hàng mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Bảng định mức")});
            this.fld_lkePaintTemp.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkePaintTemp.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkePaintTemp.Screen = null;
            this.fld_lkePaintTemp.Size = new System.Drawing.Size(168, 20);
            this.fld_lkePaintTemp.TabIndex = 110;
            this.fld_lkePaintTemp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkePaintTemp_QueryPopUp);
            // 
            // bosButton5
            // 
            this.bosButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton5.BOSComment = null;
            this.bosButton5.BOSDataMember = null;
            this.bosButton5.BOSDataSource = null;
            this.bosButton5.BOSDescription = null;
            this.bosButton5.BOSError = null;
            this.bosButton5.BOSFieldGroup = null;
            this.bosButton5.BOSFieldRelation = null;
            this.bosButton5.BOSPrivilege = null;
            this.bosButton5.BOSPropertyName = null;
            this.bosButton5.Location = new System.Drawing.Point(2260, 3);
            this.bosButton5.Name = "bosButton5";
            this.bosButton5.Screen = null;
            this.bosButton5.Size = new System.Drawing.Size(22, 22);
            this.bosButton5.TabIndex = 430;
            this.bosButton5.Text = "❐";
            this.bosButton5.Click += new System.EventHandler(this.bosButton5_Click);
            // 
            // bosLabel53
            // 
            this.bosLabel53.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel53.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel53.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel53.Appearance.Options.UseBackColor = true;
            this.bosLabel53.Appearance.Options.UseFont = true;
            this.bosLabel53.Appearance.Options.UseForeColor = true;
            this.bosLabel53.BOSComment = "";
            this.bosLabel53.BOSDataMember = "";
            this.bosLabel53.BOSDataSource = "";
            this.bosLabel53.BOSDescription = null;
            this.bosLabel53.BOSError = null;
            this.bosLabel53.BOSFieldGroup = "";
            this.bosLabel53.BOSFieldRelation = "";
            this.bosLabel53.BOSPrivilege = "";
            this.bosLabel53.BOSPropertyName = null;
            this.bosLabel53.Location = new System.Drawing.Point(1213, 44);
            this.bosLabel53.Name = "bosLabel53";
            this.bosLabel53.Screen = null;
            this.bosLabel53.Size = new System.Drawing.Size(61, 13);
            this.bosLabel53.TabIndex = 437;
            this.bosLabel53.Tag = "";
            this.bosLabel53.Text = "Tỉ lệ tiêu hao";
            this.bosLabel53.Visible = false;
            // 
            // fld_btnPrintPaint
            // 
            this.fld_btnPrintPaint.BOSComment = null;
            this.fld_btnPrintPaint.BOSDataMember = null;
            this.fld_btnPrintPaint.BOSDataSource = null;
            this.fld_btnPrintPaint.BOSDescription = null;
            this.fld_btnPrintPaint.BOSError = null;
            this.fld_btnPrintPaint.BOSFieldGroup = null;
            this.fld_btnPrintPaint.BOSFieldRelation = null;
            this.fld_btnPrintPaint.BOSPrivilege = null;
            this.fld_btnPrintPaint.BOSPropertyName = null;
            this.fld_btnPrintPaint.Location = new System.Drawing.Point(780, 44);
            this.fld_btnPrintPaint.Name = "fld_btnPrintPaint";
            this.fld_btnPrintPaint.Screen = null;
            this.fld_btnPrintPaint.Size = new System.Drawing.Size(75, 20);
            this.fld_btnPrintPaint.TabIndex = 428;
            this.fld_btnPrintPaint.Text = "In";
            this.fld_btnPrintPaint.Click += new System.EventHandler(this.Fld_btnPrintPaint_Click);
            // 
            // bosLine10
            // 
            this.bosLine10.BOSComment = null;
            this.bosLine10.BOSDataMember = null;
            this.bosLine10.BOSDataSource = null;
            this.bosLine10.BOSDescription = null;
            this.bosLine10.BOSError = null;
            this.bosLine10.BOSFieldGroup = null;
            this.bosLine10.BOSFieldRelation = null;
            this.bosLine10.BOSPrivilege = null;
            this.bosLine10.BOSPropertyName = null;
            this.bosLine10.Controls.Add(this.bosMemoEdit3);
            this.bosLine10.Location = new System.Drawing.Point(13, 3);
            this.bosLine10.Name = "bosLine10";
            this.bosLine10.Screen = null;
            this.bosLine10.Size = new System.Drawing.Size(224, 62);
            this.bosLine10.TabIndex = 427;
            this.bosLine10.TabStop = false;
            this.bosLine10.Text = "Diễn giải";
            // 
            // bosMemoEdit3
            // 
            this.bosMemoEdit3.BOSComment = "";
            this.bosMemoEdit3.BOSDataMember = "MMProductionNormIngredientPaintDesc";
            this.bosMemoEdit3.BOSDataSource = "MMProductionNorms";
            this.bosMemoEdit3.BOSDescription = null;
            this.bosMemoEdit3.BOSError = null;
            this.bosMemoEdit3.BOSFieldGroup = "";
            this.bosMemoEdit3.BOSFieldRelation = "";
            this.bosMemoEdit3.BOSPrivilege = "";
            this.bosMemoEdit3.BOSPropertyName = "Text";
            this.bosMemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosMemoEdit3.EditValue = "";
            this.bosMemoEdit3.Location = new System.Drawing.Point(3, 17);
            this.bosMemoEdit3.Name = "bosMemoEdit3";
            this.bosMemoEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit3.Screen = null;
            this.bosMemoEdit3.Size = new System.Drawing.Size(218, 42);
            this.bosMemoEdit3.TabIndex = 147;
            this.bosMemoEdit3.Tag = "DC";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(5, 74);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.bosButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosLabel32);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcMMProductionNormItemHavePaint);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnViewDetailPain);
            this.splitContainerControl1.Panel2.Controls.Add(this.bosLabel36);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_trlMMProductionNormItemsPaint);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(2277, 562);
            this.splitContainerControl1.SplitterPosition = 695;
            this.splitContainerControl1.TabIndex = 426;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(157, 1);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = this;
            this.bosButton2.Size = new System.Drawing.Size(75, 20);
            this.bosButton2.TabIndex = 425;
            this.bosButton2.Text = "Làm mới";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click_1);
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseFont = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(4, 5);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(142, 13);
            this.bosLabel32.TabIndex = 424;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Danh sách cụm && chi tiết";
            // 
            // fld_dgcMMProductionNormItemHavePaint
            // 
            this.fld_dgcMMProductionNormItemHavePaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionNormItemHavePaint.BOSComment = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSDataMember = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSDataSource = "MMProductionNormItems";
            this.fld_dgcMMProductionNormItemHavePaint.BOSDescription = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSError = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSGridType = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItemHavePaint.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItemHavePaint.CommodityType = "";
            this.fld_dgcMMProductionNormItemHavePaint.Location = new System.Drawing.Point(3, 27);
            this.fld_dgcMMProductionNormItemHavePaint.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItemHavePaint.Name = "fld_dgcMMProductionNormItemHavePaint";
            this.fld_dgcMMProductionNormItemHavePaint.PrintReport = false;
            this.fld_dgcMMProductionNormItemHavePaint.Screen = null;
            this.fld_dgcMMProductionNormItemHavePaint.Size = new System.Drawing.Size(681, 535);
            this.fld_dgcMMProductionNormItemHavePaint.TabIndex = 138;
            // 
            // fld_btnViewDetailPain
            // 
            this.fld_btnViewDetailPain.BOSComment = null;
            this.fld_btnViewDetailPain.BOSDataMember = null;
            this.fld_btnViewDetailPain.BOSDataSource = null;
            this.fld_btnViewDetailPain.BOSDescription = null;
            this.fld_btnViewDetailPain.BOSError = null;
            this.fld_btnViewDetailPain.BOSFieldGroup = null;
            this.fld_btnViewDetailPain.BOSFieldRelation = null;
            this.fld_btnViewDetailPain.BOSPrivilege = null;
            this.fld_btnViewDetailPain.BOSPropertyName = null;
            this.fld_btnViewDetailPain.Location = new System.Drawing.Point(93, 1);
            this.fld_btnViewDetailPain.Name = "fld_btnViewDetailPain";
            this.fld_btnViewDetailPain.Screen = null;
            this.fld_btnViewDetailPain.Size = new System.Drawing.Size(75, 20);
            this.fld_btnViewDetailPain.TabIndex = 425;
            this.fld_btnViewDetailPain.Text = "Xem chi tiết";
            this.fld_btnViewDetailPain.Click += new System.EventHandler(this.Fld_btnViewDetailPain_Click);
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel36.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseFont = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = "";
            this.bosLabel36.BOSDataMember = "";
            this.bosLabel36.BOSDataSource = "";
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = "";
            this.bosLabel36.BOSFieldRelation = "";
            this.bosLabel36.BOSPrivilege = "";
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(2, 5);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(79, 13);
            this.bosLabel36.TabIndex = 427;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Định mức Sơn";
            // 
            // fld_trlMMProductionNormItemsPaint
            // 
            this.fld_trlMMProductionNormItemsPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsPaint.BOSComment = "";
            this.fld_trlMMProductionNormItemsPaint.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsPaint.BOSDescription = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsPaint.BOSError = "";
            this.fld_trlMMProductionNormItemsPaint.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsPaint.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsPaint.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsPaint.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsPaint.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsPaint.Location = new System.Drawing.Point(2, 27);
            this.fld_trlMMProductionNormItemsPaint.Name = "fld_trlMMProductionNormItemsPaint";
            this.fld_trlMMProductionNormItemsPaint.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsPaint.Screen = null;
            this.fld_trlMMProductionNormItemsPaint.Size = new System.Drawing.Size(1575, 535);
            this.fld_trlMMProductionNormItemsPaint.TabIndex = 131;
            this.fld_trlMMProductionNormItemsPaint.Tag = "DC";
            this.fld_trlMMProductionNormItemsPaint.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsPaint_CellValueChanged);
            this.fld_trlMMProductionNormItemsPaint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItemsPaint_KeyUp);
            // 
            // fld_btnEditMMProductionNormPaintStatus
            // 
            this.fld_btnEditMMProductionNormPaintStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSError = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormPaintStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormPaintStatus.Location = new System.Drawing.Point(780, 18);
            this.fld_btnEditMMProductionNormPaintStatus.Name = "fld_btnEditMMProductionNormPaintStatus";
            this.fld_btnEditMMProductionNormPaintStatus.Screen = this;
            this.fld_btnEditMMProductionNormPaintStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormPaintStatus.TabIndex = 425;
            this.fld_btnEditMMProductionNormPaintStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormPaintStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormPaintStatus_Click);
            // 
            // fld_btnApproveMMProductionNormPaintStatus
            // 
            this.fld_btnApproveMMProductionNormPaintStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormPaintStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormPaintStatus.Location = new System.Drawing.Point(699, 44);
            this.fld_btnApproveMMProductionNormPaintStatus.Name = "fld_btnApproveMMProductionNormPaintStatus";
            this.fld_btnApproveMMProductionNormPaintStatus.Screen = this;
            this.fld_btnApproveMMProductionNormPaintStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormPaintStatus.TabIndex = 424;
            this.fld_btnApproveMMProductionNormPaintStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormPaintStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormPaintStatus_Click);
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseFont = true;
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
            this.bosLabel27.Location = new System.Drawing.Point(261, 21);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(48, 13);
            this.bosLabel27.TabIndex = 423;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormPaintStatus
            // 
            this.fld_lkeMMProductionNormPaintStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormPaintStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormPaintStatus.BOSComment = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSDataMember = "MMProductionNormPaintStatus";
            this.fld_lkeMMProductionNormPaintStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormPaintStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormPaintStatus.BOSError = null;
            this.fld_lkeMMProductionNormPaintStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormPaintStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormPaintStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormPaintStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormPaintStatus.Location = new System.Drawing.Point(328, 18);
            this.fld_lkeMMProductionNormPaintStatus.Name = "fld_lkeMMProductionNormPaintStatus";
            this.fld_lkeMMProductionNormPaintStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormPaintStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormPaintStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormPaintStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormPaintStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormPaintStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormPaintStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormPaintStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormPaintStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormPaintStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormPaintStatus.Screen = null;
            this.fld_lkeMMProductionNormPaintStatus.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeMMProductionNormPaintStatus.TabIndex = 422;
            this.fld_lkeMMProductionNormPaintStatus.Tag = "DC";
            this.fld_lkeMMProductionNormPaintStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormPaintStatus_EditValueChanged);
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
            this.bosLabel21.Location = new System.Drawing.Point(482, 21);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(52, 13);
            this.bosLabel21.TabIndex = 420;
            this.bosLabel21.Text = "Công đoạn";
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = true;
            this.fld_lkeMMOperationID.BOSComment = "";
            this.fld_lkeMMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = "";
            this.fld_lkeMMOperationID.BOSFieldParent = "";
            this.fld_lkeMMOperationID.BOSFieldRelation = "";
            this.fld_lkeMMOperationID.BOSPrivilege = "";
            this.fld_lkeMMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationID.BOSSelectType = "";
            this.fld_lkeMMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationID.CurrentDisplayText = "";
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(540, 18);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.ColumnName = null;
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineGroup", "Nhóm máy")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationID.Properties.NullText = "";
            this.fld_lkeMMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationID, true);
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeMMOperationID.TabIndex = 421;
            this.fld_lkeMMOperationID.Tag = "DC";
            this.fld_lkeMMOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeMMOperationID_QueryPopUp);
            this.fld_lkeMMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMOperationID_CloseUp);
            // 
            // fld_btnSavePaint
            // 
            this.fld_btnSavePaint.BOSComment = null;
            this.fld_btnSavePaint.BOSDataMember = null;
            this.fld_btnSavePaint.BOSDataSource = null;
            this.fld_btnSavePaint.BOSDescription = null;
            this.fld_btnSavePaint.BOSError = null;
            this.fld_btnSavePaint.BOSFieldGroup = null;
            this.fld_btnSavePaint.BOSFieldRelation = null;
            this.fld_btnSavePaint.BOSPrivilege = null;
            this.fld_btnSavePaint.BOSPropertyName = null;
            this.fld_btnSavePaint.Location = new System.Drawing.Point(699, 18);
            this.fld_btnSavePaint.Name = "fld_btnSavePaint";
            this.fld_btnSavePaint.Screen = null;
            this.fld_btnSavePaint.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSavePaint.TabIndex = 132;
            this.fld_btnSavePaint.Text = "Lưu";
            this.fld_btnSavePaint.Click += new System.EventHandler(this.fld_btnSavePaint_Click);
            // 
            // fld_lkeICProductIngredientPaintID
            // 
            this.fld_lkeICProductIngredientPaintID.BOSAllowAddNew = false;
            this.fld_lkeICProductIngredientPaintID.BOSAllowDummy = true;
            this.fld_lkeICProductIngredientPaintID.BOSComment = null;
            this.fld_lkeICProductIngredientPaintID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductIngredientPaintID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductIngredientPaintID.BOSDescription = null;
            this.fld_lkeICProductIngredientPaintID.BOSError = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldGroup = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldParent = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldRelation = null;
            this.fld_lkeICProductIngredientPaintID.BOSPrivilege = null;
            this.fld_lkeICProductIngredientPaintID.BOSPropertyName = null;
            this.fld_lkeICProductIngredientPaintID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductIngredientPaintID.BOSSelectTypeValue = "IngredientPaint;Equipment";
            this.fld_lkeICProductIngredientPaintID.CurrentDisplayText = null;
            this.fld_lkeICProductIngredientPaintID.Location = new System.Drawing.Point(540, 44);
            this.fld_lkeICProductIngredientPaintID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductIngredientPaintID.Name = "fld_lkeICProductIngredientPaintID";
            this.fld_lkeICProductIngredientPaintID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIngredientPaintID.Properties.ColumnName = null;
            this.fld_lkeICProductIngredientPaintID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductIngredientPaintID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductIngredientPaintID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductIngredientPaintID.Screen = null;
            this.fld_lkeICProductIngredientPaintID.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeICProductIngredientPaintID.TabIndex = 130;
            this.fld_lkeICProductIngredientPaintID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductIngredientPaintID_KeyUp);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(482, 47);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(19, 13);
            this.bosLabel17.TabIndex = 129;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Sơn";
            // 
            // fld_lkeMMPaintProcessesID
            // 
            this.fld_lkeMMPaintProcessesID.BOSAllowAddNew = false;
            this.fld_lkeMMPaintProcessesID.BOSAllowDummy = true;
            this.fld_lkeMMPaintProcessesID.BOSComment = "";
            this.fld_lkeMMPaintProcessesID.BOSDataMember = "MMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeMMPaintProcessesID.BOSDescription = null;
            this.fld_lkeMMPaintProcessesID.BOSError = null;
            this.fld_lkeMMPaintProcessesID.BOSFieldGroup = "";
            this.fld_lkeMMPaintProcessesID.BOSFieldParent = "";
            this.fld_lkeMMPaintProcessesID.BOSFieldRelation = "";
            this.fld_lkeMMPaintProcessesID.BOSPrivilege = "";
            this.fld_lkeMMPaintProcessesID.BOSPropertyName = "";
            this.fld_lkeMMPaintProcessesID.BOSSelectType = "";
            this.fld_lkeMMPaintProcessesID.BOSSelectTypeValue = "";
            this.fld_lkeMMPaintProcessesID.CurrentDisplayText = null;
            this.fld_lkeMMPaintProcessesID.Location = new System.Drawing.Point(328, 44);
            this.fld_lkeMMPaintProcessesID.Name = "fld_lkeMMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMPaintProcessesID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPaintProcessesID.Properties.ColumnName = null;
            this.fld_lkeMMPaintProcessesID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesNo", "Mã qui trình"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesPaintNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesPaintName", "Màu sơn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesProductGroupName", "Hệ sơn")});
            this.fld_lkeMMPaintProcessesID.Properties.DisplayMember = "MMPaintProcessesDesc";
            this.fld_lkeMMPaintProcessesID.Properties.NullText = "";
            this.fld_lkeMMPaintProcessesID.Properties.PopupWidth = 40;
            this.fld_lkeMMPaintProcessesID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMPaintProcessesID.Properties.ValueMember = "MMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.Screen = null;
            this.fld_lkeMMPaintProcessesID.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeMMPaintProcessesID.TabIndex = 127;
            this.fld_lkeMMPaintProcessesID.Tag = "DC";
            this.fld_lkeMMPaintProcessesID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeMMPaintProcessesID_QueryPopUp);
            this.fld_lkeMMPaintProcessesID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMPaintProcessesID_KeyUp);
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
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(261, 47);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(59, 13);
            this.bosLabel13.TabIndex = 128;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Qui trình sơn";
            // 
            // fld_tpPackaging
            // 
            this.fld_tpPackaging.Controls.Add(this.bosPanel13);
            this.fld_tpPackaging.Name = "fld_tpPackaging";
            this.fld_tpPackaging.Size = new System.Drawing.Size(2297, 653);
            this.fld_tpPackaging.Text = "Phụ liệu đóng gói";
            // 
            // bosPanel13
            // 
            this.bosPanel13.BOSComment = null;
            this.bosPanel13.BOSDataMember = null;
            this.bosPanel13.BOSDataSource = null;
            this.bosPanel13.BOSDescription = null;
            this.bosPanel13.BOSError = null;
            this.bosPanel13.BOSFieldGroup = null;
            this.bosPanel13.BOSFieldRelation = null;
            this.bosPanel13.BOSPrivilege = null;
            this.bosPanel13.BOSPropertyName = null;
            this.bosPanel13.Controls.Add(this.fld_txtDepreciationRateIngredientPackaging);
            this.bosPanel13.Controls.Add(this.fld_tlcProctionNormItemPackings);
            this.bosPanel13.Controls.Add(this.bosLabel54);
            this.bosPanel13.Controls.Add(this.bosLine13);
            this.bosPanel13.Controls.Add(this.fld_btnPrintPLDG);
            this.bosPanel13.Controls.Add(this.bosLine11);
            this.bosPanel13.Controls.Add(this.fld_radPackaging);
            this.bosPanel13.Controls.Add(this.fld_lkeICProductPackaging);
            this.bosPanel13.Controls.Add(this.bosLabel37);
            this.bosPanel13.Controls.Add(this.fld_btnEditMMProductionNormPackingMaterialStatus);
            this.bosPanel13.Controls.Add(this.fld_btnApproveMMProductionNormPackingMaterialStatus);
            this.bosPanel13.Controls.Add(this.bosLabel28);
            this.bosPanel13.Controls.Add(this.fld_lkeMMProductionNormPackingMaterialStatus);
            this.bosPanel13.Controls.Add(this.bosLabel22);
            this.bosPanel13.Controls.Add(this.fld_lkeMMOperationPackaging);
            this.bosPanel13.Controls.Add(this.bosLabel20);
            this.bosPanel13.Controls.Add(this.bosLabel19);
            this.bosPanel13.Controls.Add(this.bosLabel18);
            this.bosPanel13.Controls.Add(this.bosLabel16);
            this.bosPanel13.Controls.Add(this.fld_btnSavePackaging);
            this.bosPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel13.Location = new System.Drawing.Point(0, 0);
            this.bosPanel13.Name = "bosPanel13";
            this.bosPanel13.Screen = null;
            this.bosPanel13.Size = new System.Drawing.Size(2297, 653);
            this.bosPanel13.TabIndex = 0;
            // 
            // fld_txtDepreciationRateIngredientPackaging
            // 
            this.fld_txtDepreciationRateIngredientPackaging.BOSComment = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSDataMember = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSDataSource = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSDescription = null;
            this.fld_txtDepreciationRateIngredientPackaging.BOSError = null;
            this.fld_txtDepreciationRateIngredientPackaging.BOSFieldGroup = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSFieldRelation = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSPrivilege = "";
            this.fld_txtDepreciationRateIngredientPackaging.BOSPropertyName = "Text";
            this.fld_txtDepreciationRateIngredientPackaging.EditValue = "";
            this.fld_txtDepreciationRateIngredientPackaging.Location = new System.Drawing.Point(725, 43);
            this.fld_txtDepreciationRateIngredientPackaging.Name = "fld_txtDepreciationRateIngredientPackaging";
            this.fld_txtDepreciationRateIngredientPackaging.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDepreciationRateIngredientPackaging.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtDepreciationRateIngredientPackaging.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.EditFormat.FormatString = "n2";
            this.fld_txtDepreciationRateIngredientPackaging.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDepreciationRateIngredientPackaging.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtDepreciationRateIngredientPackaging.Properties.MaskSettings.Set("mask", "n2");
            this.fld_txtDepreciationRateIngredientPackaging.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDepreciationRateIngredientPackaging.Screen = null;
            this.fld_txtDepreciationRateIngredientPackaging.Size = new System.Drawing.Size(32, 20);
            this.fld_txtDepreciationRateIngredientPackaging.TabIndex = 162;
            this.fld_txtDepreciationRateIngredientPackaging.Tag = "DC";
            this.fld_txtDepreciationRateIngredientPackaging.ToolTip = "Nhấn Enter để cập nhật xuống chi tiết";
            // 
            // fld_tlcProctionNormItemPackings
            // 
            this.fld_tlcProctionNormItemPackings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tlcProctionNormItemPackings.BOSComment = "";
            this.fld_tlcProctionNormItemPackings.BOSDataMember = null;
            this.fld_tlcProctionNormItemPackings.BOSDataSource = "MMProductionNormItems";
            this.fld_tlcProctionNormItemPackings.BOSDescription = null;
            this.fld_tlcProctionNormItemPackings.BOSDisplayOption = false;
            this.fld_tlcProctionNormItemPackings.BOSDisplayRoot = true;
            this.fld_tlcProctionNormItemPackings.BOSError = "";
            this.fld_tlcProctionNormItemPackings.BOSFieldGroup = "";
            this.fld_tlcProctionNormItemPackings.BOSFieldRelation = null;
            this.fld_tlcProctionNormItemPackings.BOSPrivilege = "";
            this.fld_tlcProctionNormItemPackings.BOSPropertyName = null;
            this.fld_tlcProctionNormItemPackings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_tlcProctionNormItemPackings.HasInitNewRow = false;
            this.fld_tlcProctionNormItemPackings.Location = new System.Drawing.Point(8, 71);
            this.fld_tlcProctionNormItemPackings.Name = "fld_tlcProctionNormItemPackings";
            this.fld_tlcProctionNormItemPackings.OptionsNavigation.AutoFocusNewNode = true;
            this.fld_tlcProctionNormItemPackings.OptionsView.NewItemRowPosition = DevExpress.XtraTreeList.TreeListNewItemRowPosition.Top;
            this.fld_tlcProctionNormItemPackings.PackagingList = null;
            this.fld_tlcProctionNormItemPackings.Screen = null;
            this.fld_tlcProctionNormItemPackings.Size = new System.Drawing.Size(2286, 542);
            this.fld_tlcProctionNormItemPackings.TabIndex = 436;
            this.fld_tlcProctionNormItemPackings.Tag = "DC";
            // 
            // bosLabel54
            // 
            this.bosLabel54.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel54.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel54.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel54.Appearance.Options.UseBackColor = true;
            this.bosLabel54.Appearance.Options.UseFont = true;
            this.bosLabel54.Appearance.Options.UseForeColor = true;
            this.bosLabel54.BOSComment = "";
            this.bosLabel54.BOSDataMember = "";
            this.bosLabel54.BOSDataSource = "";
            this.bosLabel54.BOSDescription = null;
            this.bosLabel54.BOSError = null;
            this.bosLabel54.BOSFieldGroup = "";
            this.bosLabel54.BOSFieldRelation = "";
            this.bosLabel54.BOSPrivilege = "";
            this.bosLabel54.BOSPropertyName = null;
            this.bosLabel54.Location = new System.Drawing.Point(642, 47);
            this.bosLabel54.Name = "bosLabel54";
            this.bosLabel54.Screen = null;
            this.bosLabel54.Size = new System.Drawing.Size(61, 13);
            this.bosLabel54.TabIndex = 161;
            this.bosLabel54.Tag = "";
            this.bosLabel54.Text = "Tỉ lệ tiêu hao";
            // 
            // bosLine13
            // 
            this.bosLine13.BOSComment = null;
            this.bosLine13.BOSDataMember = null;
            this.bosLine13.BOSDataSource = null;
            this.bosLine13.BOSDescription = null;
            this.bosLine13.BOSError = null;
            this.bosLine13.BOSFieldGroup = null;
            this.bosLine13.BOSFieldRelation = null;
            this.bosLine13.BOSPrivilege = null;
            this.bosLine13.BOSPropertyName = null;
            this.bosLine13.Controls.Add(this.fld_btnPackCopy);
            this.bosLine13.Controls.Add(this.bosLabel34);
            this.bosLine13.Controls.Add(this.fld_lkePackTemp);
            this.bosLine13.Location = new System.Drawing.Point(926, 6);
            this.bosLine13.Name = "bosLine13";
            this.bosLine13.Screen = null;
            this.bosLine13.Size = new System.Drawing.Size(333, 59);
            this.bosLine13.TabIndex = 435;
            this.bosLine13.TabStop = false;
            this.bosLine13.Text = "Sao chép";
            // 
            // fld_btnPackCopy
            // 
            this.fld_btnPackCopy.BOSComment = null;
            this.fld_btnPackCopy.BOSDataMember = null;
            this.fld_btnPackCopy.BOSDataSource = null;
            this.fld_btnPackCopy.BOSDescription = null;
            this.fld_btnPackCopy.BOSError = null;
            this.fld_btnPackCopy.BOSFieldGroup = null;
            this.fld_btnPackCopy.BOSFieldRelation = null;
            this.fld_btnPackCopy.BOSPrivilege = null;
            this.fld_btnPackCopy.BOSPropertyName = null;
            this.fld_btnPackCopy.Location = new System.Drawing.Point(267, 18);
            this.fld_btnPackCopy.Name = "fld_btnPackCopy";
            this.fld_btnPackCopy.Screen = null;
            this.fld_btnPackCopy.Size = new System.Drawing.Size(58, 27);
            this.fld_btnPackCopy.TabIndex = 112;
            this.fld_btnPackCopy.Text = "Sao chép";
            this.fld_btnPackCopy.Click += new System.EventHandler(this.fld_btnPackCopy_Click);
            // 
            // bosLabel34
            // 
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(24, 28);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(45, 13);
            this.bosLabel34.TabIndex = 0;
            this.bosLabel34.Text = "BĐM Mẫu";
            // 
            // fld_lkePackTemp
            // 
            this.fld_lkePackTemp.BOSAllowAddNew = false;
            this.fld_lkePackTemp.BOSAllowDummy = true;
            this.fld_lkePackTemp.BOSComment = null;
            this.fld_lkePackTemp.BOSDataMember = null;
            this.fld_lkePackTemp.BOSDataSource = null;
            this.fld_lkePackTemp.BOSDescription = null;
            this.fld_lkePackTemp.BOSError = null;
            this.fld_lkePackTemp.BOSFieldGroup = null;
            this.fld_lkePackTemp.BOSFieldParent = null;
            this.fld_lkePackTemp.BOSFieldRelation = null;
            this.fld_lkePackTemp.BOSPrivilege = null;
            this.fld_lkePackTemp.BOSPropertyName = null;
            this.fld_lkePackTemp.BOSSelectType = null;
            this.fld_lkePackTemp.BOSSelectTypeValue = null;
            this.fld_lkePackTemp.CurrentDisplayText = null;
            this.fld_lkePackTemp.Location = new System.Drawing.Point(82, 24);
            this.fld_lkePackTemp.MenuManager = this.screenToolbar;
            this.fld_lkePackTemp.Name = "fld_lkePackTemp";
            this.fld_lkePackTemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePackTemp.Properties.ColumnName = null;
            this.fld_lkePackTemp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã hàng mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Bảng định mức")});
            this.fld_lkePackTemp.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkePackTemp.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkePackTemp.Screen = null;
            this.fld_lkePackTemp.Size = new System.Drawing.Size(168, 20);
            this.fld_lkePackTemp.TabIndex = 110;
            this.fld_lkePackTemp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkePackTemp_QueryPopUp);
            // 
            // fld_btnPrintPLDG
            // 
            this.fld_btnPrintPLDG.BOSComment = null;
            this.fld_btnPrintPLDG.BOSDataMember = null;
            this.fld_btnPrintPLDG.BOSDataSource = null;
            this.fld_btnPrintPLDG.BOSDescription = null;
            this.fld_btnPrintPLDG.BOSError = null;
            this.fld_btnPrintPLDG.BOSFieldGroup = null;
            this.fld_btnPrintPLDG.BOSFieldRelation = null;
            this.fld_btnPrintPLDG.BOSPrivilege = null;
            this.fld_btnPrintPLDG.BOSPropertyName = null;
            this.fld_btnPrintPLDG.Location = new System.Drawing.Point(843, 43);
            this.fld_btnPrintPLDG.Name = "fld_btnPrintPLDG";
            this.fld_btnPrintPLDG.Screen = null;
            this.fld_btnPrintPLDG.Size = new System.Drawing.Size(75, 20);
            this.fld_btnPrintPLDG.TabIndex = 434;
            this.fld_btnPrintPLDG.Text = "In";
            this.fld_btnPrintPLDG.Click += new System.EventHandler(this.Fld_btnPrintPLDG_Click);
            // 
            // bosLine11
            // 
            this.bosLine11.BOSComment = null;
            this.bosLine11.BOSDataMember = null;
            this.bosLine11.BOSDataSource = null;
            this.bosLine11.BOSDescription = null;
            this.bosLine11.BOSError = null;
            this.bosLine11.BOSFieldGroup = null;
            this.bosLine11.BOSFieldRelation = null;
            this.bosLine11.BOSPrivilege = null;
            this.bosLine11.BOSPropertyName = null;
            this.bosLine11.Controls.Add(this.bosMemoEdit4);
            this.bosLine11.Location = new System.Drawing.Point(13, 3);
            this.bosLine11.Name = "bosLine11";
            this.bosLine11.Screen = null;
            this.bosLine11.Size = new System.Drawing.Size(219, 62);
            this.bosLine11.TabIndex = 433;
            this.bosLine11.TabStop = false;
            this.bosLine11.Text = "Diễn giải";
            // 
            // bosMemoEdit4
            // 
            this.bosMemoEdit4.BOSComment = "";
            this.bosMemoEdit4.BOSDataMember = "MMProductionNormIngredientPackagingDesc";
            this.bosMemoEdit4.BOSDataSource = "MMProductionNorms";
            this.bosMemoEdit4.BOSDescription = null;
            this.bosMemoEdit4.BOSError = null;
            this.bosMemoEdit4.BOSFieldGroup = "";
            this.bosMemoEdit4.BOSFieldRelation = "";
            this.bosMemoEdit4.BOSPrivilege = "";
            this.bosMemoEdit4.BOSPropertyName = "Text";
            this.bosMemoEdit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosMemoEdit4.EditValue = "";
            this.bosMemoEdit4.Location = new System.Drawing.Point(3, 17);
            this.bosMemoEdit4.Name = "bosMemoEdit4";
            this.bosMemoEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit4.Screen = null;
            this.bosMemoEdit4.Size = new System.Drawing.Size(213, 42);
            this.bosMemoEdit4.TabIndex = 147;
            this.bosMemoEdit4.Tag = "DC";
            // 
            // fld_radPackaging
            // 
            this.fld_radPackaging.BOSComment = null;
            this.fld_radPackaging.BOSDataMember = null;
            this.fld_radPackaging.BOSDataSource = null;
            this.fld_radPackaging.BOSDescription = null;
            this.fld_radPackaging.BOSError = null;
            this.fld_radPackaging.BOSFieldGroup = null;
            this.fld_radPackaging.BOSFieldRelation = null;
            this.fld_radPackaging.BOSPrivilege = null;
            this.fld_radPackaging.BOSPropertyName = null;
            this.fld_radPackaging.Location = new System.Drawing.Point(452, 41);
            this.fld_radPackaging.MenuManager = this.screenToolbar;
            this.fld_radPackaging.Name = "fld_radPackaging";
            this.fld_radPackaging.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_radPackaging.Properties.Appearance.Options.UseBackColor = true;
            this.fld_radPackaging.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Quy cách"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Thành phần")});
            this.fld_radPackaging.Screen = null;
            this.fld_radPackaging.Size = new System.Drawing.Size(184, 21);
            this.fld_radPackaging.TabIndex = 432;
            // 
            // fld_lkeICProductPackaging
            // 
            this.fld_lkeICProductPackaging.BOSAllowAddNew = false;
            this.fld_lkeICProductPackaging.BOSAllowDummy = true;
            this.fld_lkeICProductPackaging.BOSComment = null;
            this.fld_lkeICProductPackaging.BOSDataMember = "ICProductID";
            this.fld_lkeICProductPackaging.BOSDataSource = "ICProducts";
            this.fld_lkeICProductPackaging.BOSDescription = null;
            this.fld_lkeICProductPackaging.BOSError = null;
            this.fld_lkeICProductPackaging.BOSFieldGroup = null;
            this.fld_lkeICProductPackaging.BOSFieldParent = null;
            this.fld_lkeICProductPackaging.BOSFieldRelation = null;
            this.fld_lkeICProductPackaging.BOSPrivilege = null;
            this.fld_lkeICProductPackaging.BOSPropertyName = null;
            this.fld_lkeICProductPackaging.BOSSelectType = "ICProductType";
            this.fld_lkeICProductPackaging.BOSSelectTypeValue = "IngredientPackaging";
            this.fld_lkeICProductPackaging.CurrentDisplayText = null;
            this.fld_lkeICProductPackaging.Location = new System.Drawing.Point(496, 19);
            this.fld_lkeICProductPackaging.MenuManager = this.screenToolbar;
            this.fld_lkeICProductPackaging.Name = "fld_lkeICProductPackaging";
            this.fld_lkeICProductPackaging.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPackaging.Properties.ColumnName = null;
            this.fld_lkeICProductPackaging.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductPackaging.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductPackaging.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductPackaging.Screen = null;
            this.fld_lkeICProductPackaging.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeICProductPackaging.TabIndex = 431;
            this.fld_lkeICProductPackaging.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductPackaging_KeyUp);
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel37.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseFont = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = "";
            this.bosLabel37.BOSDataMember = "";
            this.bosLabel37.BOSDataSource = "";
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = "";
            this.bosLabel37.BOSFieldRelation = "";
            this.bosLabel37.BOSPrivilege = "";
            this.bosLabel37.BOSPropertyName = null;
            this.bosLabel37.Location = new System.Drawing.Point(452, 22);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(29, 13);
            this.bosLabel37.TabIndex = 430;
            this.bosLabel37.Tag = "";
            this.bosLabel37.Text = "PLĐG";
            // 
            // fld_btnEditMMProductionNormPackingMaterialStatus
            // 
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSError = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Location = new System.Drawing.Point(844, 17);
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Name = "fld_btnEditMMProductionNormPackingMaterialStatus";
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Screen = this;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormPackingMaterialStatus.TabIndex = 429;
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormPackingMaterialStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormPackingMaterialStatus_Click);
            // 
            // fld_btnApproveMMProductionNormPackingMaterialStatus
            // 
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Location = new System.Drawing.Point(763, 43);
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Name = "fld_btnApproveMMProductionNormPackingMaterialStatus";
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Screen = this;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.TabIndex = 428;
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormPackingMaterialStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormPackingMaterialStatus_Click);
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
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(252, 21);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(48, 13);
            this.bosLabel28.TabIndex = 427;
            this.bosLabel28.Tag = "";
            this.bosLabel28.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormPackingMaterialStatus
            // 
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSComment = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDataMember = "MMProductionNormPackingMaterialStatus";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSError = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Location = new System.Drawing.Point(319, 18);
            this.fld_lkeMMProductionNormPackingMaterialStatus.Name = "fld_lkeMMProductionNormPackingMaterialStatus";
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Screen = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeMMProductionNormPackingMaterialStatus.TabIndex = 426;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Tag = "DC";
            this.fld_lkeMMProductionNormPackingMaterialStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormPackingMaterialStatus_EditValueChanged);
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
            this.bosLabel22.Location = new System.Drawing.Point(252, 47);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(52, 13);
            this.bosLabel22.TabIndex = 422;
            this.bosLabel22.Text = "Công đoạn";
            // 
            // fld_lkeMMOperationPackaging
            // 
            this.fld_lkeMMOperationPackaging.BOSAllowAddNew = false;
            this.fld_lkeMMOperationPackaging.BOSAllowDummy = true;
            this.fld_lkeMMOperationPackaging.BOSComment = "";
            this.fld_lkeMMOperationPackaging.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationPackaging.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationPackaging.BOSDescription = null;
            this.fld_lkeMMOperationPackaging.BOSError = null;
            this.fld_lkeMMOperationPackaging.BOSFieldGroup = "";
            this.fld_lkeMMOperationPackaging.BOSFieldParent = "";
            this.fld_lkeMMOperationPackaging.BOSFieldRelation = "";
            this.fld_lkeMMOperationPackaging.BOSPrivilege = "";
            this.fld_lkeMMOperationPackaging.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationPackaging.BOSSelectType = "";
            this.fld_lkeMMOperationPackaging.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationPackaging.CurrentDisplayText = "";
            this.fld_lkeMMOperationPackaging.Location = new System.Drawing.Point(319, 44);
            this.fld_lkeMMOperationPackaging.Name = "fld_lkeMMOperationPackaging";
            this.fld_lkeMMOperationPackaging.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMOperationPackaging.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationPackaging.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationPackaging.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationPackaging.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationPackaging.Properties.ColumnName = null;
            this.fld_lkeMMOperationPackaging.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineGroup", "Nhóm máy")});
            this.fld_lkeMMOperationPackaging.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationPackaging.Properties.NullText = "";
            this.fld_lkeMMOperationPackaging.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationPackaging.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationPackaging.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationPackaging, true);
            this.fld_lkeMMOperationPackaging.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeMMOperationPackaging.TabIndex = 423;
            this.fld_lkeMMOperationPackaging.Tag = "DC";
            this.fld_lkeMMOperationPackaging.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeMMOperationPackaging_QueryPopUp);
            this.fld_lkeMMOperationPackaging.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMOperationPackaging_CloseUp);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.SandyBrown;
            this.bosLabel20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseFont = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "ICProductNo";
            this.bosLabel20.BOSDataSource = "ICProducts";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = "";
            this.bosLabel20.Location = new System.Drawing.Point(23, 619);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(21, 13);
            this.bosLabel20.TabIndex = 142;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "       ";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "ICProductNo";
            this.bosLabel19.BOSDataSource = "ICProducts";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(23, 637);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(21, 13);
            this.bosLabel19.TabIndex = 141;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "       ";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "ICProductNo";
            this.bosLabel18.BOSDataSource = "ICProducts";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(50, 635);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(387, 13);
            this.bosLabel18.TabIndex = 140;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "PLDG có kích thước khác với quy cách sản phẩm đã được chọn (đã +- dung sai)";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "ICProductNo";
            this.bosLabel16.BOSDataSource = "ICProducts";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(50, 619);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(182, 13);
            this.bosLabel16.TabIndex = 139;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "PLDG chưa mapping với mã sản phẩm";
            // 
            // fld_btnSavePackaging
            // 
            this.fld_btnSavePackaging.BOSComment = null;
            this.fld_btnSavePackaging.BOSDataMember = null;
            this.fld_btnSavePackaging.BOSDataSource = null;
            this.fld_btnSavePackaging.BOSDescription = null;
            this.fld_btnSavePackaging.BOSError = null;
            this.fld_btnSavePackaging.BOSFieldGroup = null;
            this.fld_btnSavePackaging.BOSFieldRelation = null;
            this.fld_btnSavePackaging.BOSPrivilege = null;
            this.fld_btnSavePackaging.BOSPropertyName = null;
            this.fld_btnSavePackaging.Location = new System.Drawing.Point(763, 17);
            this.fld_btnSavePackaging.Name = "fld_btnSavePackaging";
            this.fld_btnSavePackaging.Screen = null;
            this.fld_btnSavePackaging.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSavePackaging.TabIndex = 137;
            this.fld_btnSavePackaging.Text = "Lưu";
            this.fld_btnSavePackaging.Click += new System.EventHandler(this.bosButton6_Click);
            // 
            // fld_tpOther
            // 
            this.fld_tpOther.Controls.Add(this.bosPanel11);
            this.fld_tpOther.Name = "fld_tpOther";
            this.fld_tpOther.Size = new System.Drawing.Size(2297, 653);
            this.fld_tpOther.Text = "Vật tư khác";
            // 
            // bosPanel11
            // 
            this.bosPanel11.AutoScroll = true;
            this.bosPanel11.BOSComment = null;
            this.bosPanel11.BOSDataMember = null;
            this.bosPanel11.BOSDataSource = null;
            this.bosPanel11.BOSDescription = null;
            this.bosPanel11.BOSError = null;
            this.bosPanel11.BOSFieldGroup = null;
            this.bosPanel11.BOSFieldRelation = null;
            this.bosPanel11.BOSPrivilege = null;
            this.bosPanel11.BOSPropertyName = null;
            this.bosPanel11.Controls.Add(this.fld_txtDepreciationRateGeneralMaterial);
            this.bosPanel11.Controls.Add(this.bosLabel55);
            this.bosPanel11.Controls.Add(this.fld_btnPrintVTK);
            this.bosPanel11.Controls.Add(this.fld_btnEditMMProductionNormGeneralMaterialStatus);
            this.bosPanel11.Controls.Add(this.fld_btnApproveMMProductionNormGeneralMaterialStatus);
            this.bosPanel11.Controls.Add(this.bosLabel29);
            this.bosPanel11.Controls.Add(this.fld_lkeMMProductionNormGeneralMaterialStatus);
            this.bosPanel11.Controls.Add(this.bosLabel23);
            this.bosPanel11.Controls.Add(this.fld_lkeOperationGeneralMaterial);
            this.bosPanel11.Controls.Add(this.fld_lkeICProductMaterialID);
            this.bosPanel11.Controls.Add(this.fld_btnSaveOther);
            this.bosPanel11.Controls.Add(this.fld_dgcMMProductionNormItems);
            this.bosPanel11.Controls.Add(this.fld_btnUpdateFromConfigMaterial);
            this.bosPanel11.Controls.Add(this.fld_lblMaterialProduct);
            this.bosPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel11.Location = new System.Drawing.Point(0, 0);
            this.bosPanel11.Name = "bosPanel11";
            this.bosPanel11.Screen = null;
            this.bosPanel11.Size = new System.Drawing.Size(2297, 653);
            this.bosPanel11.TabIndex = 141;
            // 
            // fld_txtDepreciationRateGeneralMaterial
            // 
            this.fld_txtDepreciationRateGeneralMaterial.BOSComment = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSDataMember = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSDataSource = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSDescription = null;
            this.fld_txtDepreciationRateGeneralMaterial.BOSError = null;
            this.fld_txtDepreciationRateGeneralMaterial.BOSFieldGroup = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSFieldRelation = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSPrivilege = "";
            this.fld_txtDepreciationRateGeneralMaterial.BOSPropertyName = "Text";
            this.fld_txtDepreciationRateGeneralMaterial.EditValue = "";
            this.fld_txtDepreciationRateGeneralMaterial.Location = new System.Drawing.Point(368, 38);
            this.fld_txtDepreciationRateGeneralMaterial.Name = "fld_txtDepreciationRateGeneralMaterial";
            this.fld_txtDepreciationRateGeneralMaterial.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDepreciationRateGeneralMaterial.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtDepreciationRateGeneralMaterial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.EditFormat.FormatString = "n2";
            this.fld_txtDepreciationRateGeneralMaterial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDepreciationRateGeneralMaterial.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtDepreciationRateGeneralMaterial.Properties.MaskSettings.Set("mask", "n2");
            this.fld_txtDepreciationRateGeneralMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDepreciationRateGeneralMaterial.Screen = null;
            this.fld_txtDepreciationRateGeneralMaterial.Size = new System.Drawing.Size(32, 20);
            this.fld_txtDepreciationRateGeneralMaterial.TabIndex = 436;
            this.fld_txtDepreciationRateGeneralMaterial.Tag = "DC";
            this.fld_txtDepreciationRateGeneralMaterial.ToolTip = "Nhấn Enter để cập nhật xuống chi tiết";
            // 
            // bosLabel55
            // 
            this.bosLabel55.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel55.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel55.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel55.Appearance.Options.UseBackColor = true;
            this.bosLabel55.Appearance.Options.UseFont = true;
            this.bosLabel55.Appearance.Options.UseForeColor = true;
            this.bosLabel55.BOSComment = "";
            this.bosLabel55.BOSDataMember = "";
            this.bosLabel55.BOSDataSource = "";
            this.bosLabel55.BOSDescription = null;
            this.bosLabel55.BOSError = null;
            this.bosLabel55.BOSFieldGroup = "";
            this.bosLabel55.BOSFieldRelation = "";
            this.bosLabel55.BOSPrivilege = "";
            this.bosLabel55.BOSPropertyName = null;
            this.bosLabel55.Location = new System.Drawing.Point(290, 42);
            this.bosLabel55.Name = "bosLabel55";
            this.bosLabel55.Screen = null;
            this.bosLabel55.Size = new System.Drawing.Size(61, 13);
            this.bosLabel55.TabIndex = 435;
            this.bosLabel55.Tag = "";
            this.bosLabel55.Text = "Tỉ lệ tiêu hao";
            // 
            // fld_btnPrintVTK
            // 
            this.fld_btnPrintVTK.BOSComment = null;
            this.fld_btnPrintVTK.BOSDataMember = null;
            this.fld_btnPrintVTK.BOSDataSource = null;
            this.fld_btnPrintVTK.BOSDescription = null;
            this.fld_btnPrintVTK.BOSError = null;
            this.fld_btnPrintVTK.BOSFieldGroup = null;
            this.fld_btnPrintVTK.BOSFieldRelation = null;
            this.fld_btnPrintVTK.BOSPrivilege = null;
            this.fld_btnPrintVTK.BOSPropertyName = null;
            this.fld_btnPrintVTK.Location = new System.Drawing.Point(730, 13);
            this.fld_btnPrintVTK.Name = "fld_btnPrintVTK";
            this.fld_btnPrintVTK.Screen = null;
            this.fld_btnPrintVTK.Size = new System.Drawing.Size(75, 20);
            this.fld_btnPrintVTK.TabIndex = 434;
            this.fld_btnPrintVTK.Text = "In";
            this.fld_btnPrintVTK.Click += new System.EventHandler(this.Fld_btnPrintVTK_Click);
            // 
            // fld_btnEditMMProductionNormGeneralMaterialStatus
            // 
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSComment = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSDataMember = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSDataSource = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSDescription = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSError = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSFieldGroup = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSFieldRelation = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSPrivilege = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.BOSPropertyName = null;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Location = new System.Drawing.Point(649, 12);
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Name = "fld_btnEditMMProductionNormGeneralMaterialStatus";
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Screen = this;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.TabIndex = 433;
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Text = "Chỉnh sửa";
            this.fld_btnEditMMProductionNormGeneralMaterialStatus.Click += new System.EventHandler(this.fld_btnEditMMProductionNormGeneralMaterialStatus_Click);
            // 
            // fld_btnApproveMMProductionNormGeneralMaterialStatus
            // 
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSComment = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSDataMember = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSDataSource = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSDescription = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSError = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSFieldGroup = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSFieldRelation = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSPrivilege = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.BOSPropertyName = null;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Location = new System.Drawing.Point(568, 13);
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Name = "fld_btnApproveMMProductionNormGeneralMaterialStatus";
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Screen = this;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Size = new System.Drawing.Size(75, 20);
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.TabIndex = 432;
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Text = "Duyệt";
            this.fld_btnApproveMMProductionNormGeneralMaterialStatus.Click += new System.EventHandler(this.fld_btnApproveMMProductionNormGeneralMaterialStatus_Click);
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
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(14, 15);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(48, 13);
            this.bosLabel29.TabIndex = 431;
            this.bosLabel29.Tag = "";
            this.bosLabel29.Text = "Trạng thái";
            // 
            // fld_lkeMMProductionNormGeneralMaterialStatus
            // 
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSComment = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDataMember = "MMProductionNormGeneralMaterialStatus";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSError = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSSelectType = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Location = new System.Drawing.Point(81, 12);
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Name = "fld_lkeMMProductionNormGeneralMaterialStatus";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.NullText = "";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Screen = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeMMProductionNormGeneralMaterialStatus.TabIndex = 430;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Tag = "DC";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormGeneralMaterialStatus_EditValueChanged);
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
            this.bosLabel23.Location = new System.Drawing.Point(290, 16);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(52, 13);
            this.bosLabel23.TabIndex = 424;
            this.bosLabel23.Text = "Công đoạn";
            // 
            // fld_lkeOperationGeneralMaterial
            // 
            this.fld_lkeOperationGeneralMaterial.BOSAllowAddNew = false;
            this.fld_lkeOperationGeneralMaterial.BOSAllowDummy = true;
            this.fld_lkeOperationGeneralMaterial.BOSComment = "";
            this.fld_lkeOperationGeneralMaterial.BOSDataMember = "MMOperationID";
            this.fld_lkeOperationGeneralMaterial.BOSDataSource = "MMOperations";
            this.fld_lkeOperationGeneralMaterial.BOSDescription = null;
            this.fld_lkeOperationGeneralMaterial.BOSError = null;
            this.fld_lkeOperationGeneralMaterial.BOSFieldGroup = "";
            this.fld_lkeOperationGeneralMaterial.BOSFieldParent = "";
            this.fld_lkeOperationGeneralMaterial.BOSFieldRelation = "";
            this.fld_lkeOperationGeneralMaterial.BOSPrivilege = "";
            this.fld_lkeOperationGeneralMaterial.BOSPropertyName = "EditValue";
            this.fld_lkeOperationGeneralMaterial.BOSSelectType = "";
            this.fld_lkeOperationGeneralMaterial.BOSSelectTypeValue = "";
            this.fld_lkeOperationGeneralMaterial.CurrentDisplayText = "";
            this.fld_lkeOperationGeneralMaterial.Location = new System.Drawing.Point(364, 12);
            this.fld_lkeOperationGeneralMaterial.Name = "fld_lkeOperationGeneralMaterial";
            this.fld_lkeOperationGeneralMaterial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeOperationGeneralMaterial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeOperationGeneralMaterial.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeOperationGeneralMaterial.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeOperationGeneralMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeOperationGeneralMaterial.Properties.ColumnName = null;
            this.fld_lkeOperationGeneralMaterial.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineGroup", "Nhóm máy")});
            this.fld_lkeOperationGeneralMaterial.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeOperationGeneralMaterial.Properties.NullText = "";
            this.fld_lkeOperationGeneralMaterial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeOperationGeneralMaterial.Properties.ValueMember = "MMOperationID";
            this.fld_lkeOperationGeneralMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeOperationGeneralMaterial, true);
            this.fld_lkeOperationGeneralMaterial.Size = new System.Drawing.Size(101, 20);
            this.fld_lkeOperationGeneralMaterial.TabIndex = 425;
            this.fld_lkeOperationGeneralMaterial.Tag = "DC";
            this.fld_lkeOperationGeneralMaterial.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeOperationGeneralMaterial_QueryPopUp);
            this.fld_lkeOperationGeneralMaterial.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeOperationGeneralMaterial_CloseUp);
            // 
            // fld_lkeICProductMaterialID
            // 
            this.fld_lkeICProductMaterialID.BOSAllowAddNew = false;
            this.fld_lkeICProductMaterialID.BOSAllowDummy = true;
            this.fld_lkeICProductMaterialID.BOSComment = null;
            this.fld_lkeICProductMaterialID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductMaterialID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductMaterialID.BOSDescription = null;
            this.fld_lkeICProductMaterialID.BOSError = null;
            this.fld_lkeICProductMaterialID.BOSFieldGroup = null;
            this.fld_lkeICProductMaterialID.BOSFieldParent = null;
            this.fld_lkeICProductMaterialID.BOSFieldRelation = null;
            this.fld_lkeICProductMaterialID.BOSPrivilege = null;
            this.fld_lkeICProductMaterialID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductMaterialID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductMaterialID.BOSSelectTypeValue = "Hardware;IngredientPackaging;Verneer;ArtificialBoard;IngredientPaint;Equipment;Se" +
    "miProduct;Product;Ingredient;Material;Roundwood;Lumber;Glasses;Steel;BoardOf";
            this.fld_lkeICProductMaterialID.CurrentDisplayText = null;
            this.fld_lkeICProductMaterialID.Location = new System.Drawing.Point(81, 38);
            this.fld_lkeICProductMaterialID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductMaterialID.Name = "fld_lkeICProductMaterialID";
            this.fld_lkeICProductMaterialID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductMaterialID.Properties.ColumnName = null;
            this.fld_lkeICProductMaterialID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductMaterialID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductMaterialID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductMaterialID.Screen = null;
            this.fld_lkeICProductMaterialID.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeICProductMaterialID.TabIndex = 139;
            this.fld_lkeICProductMaterialID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductMaterialID_KeyUp);
            // 
            // fld_btnSaveOther
            // 
            this.fld_btnSaveOther.BOSComment = null;
            this.fld_btnSaveOther.BOSDataMember = null;
            this.fld_btnSaveOther.BOSDataSource = null;
            this.fld_btnSaveOther.BOSDescription = null;
            this.fld_btnSaveOther.BOSError = null;
            this.fld_btnSaveOther.BOSFieldGroup = null;
            this.fld_btnSaveOther.BOSFieldRelation = null;
            this.fld_btnSaveOther.BOSPrivilege = null;
            this.fld_btnSaveOther.BOSPropertyName = null;
            this.fld_btnSaveOther.Location = new System.Drawing.Point(486, 13);
            this.fld_btnSaveOther.Name = "fld_btnSaveOther";
            this.fld_btnSaveOther.Screen = null;
            this.fld_btnSaveOther.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSaveOther.TabIndex = 105;
            this.fld_btnSaveOther.Text = "Lưu";
            this.fld_btnSaveOther.Click += new System.EventHandler(this.bosButton4_Click);
            // 
            // fld_dgcMMProductionNormItems
            // 
            this.fld_dgcMMProductionNormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionNormItems.BOSComment = null;
            this.fld_dgcMMProductionNormItems.BOSDataMember = null;
            this.fld_dgcMMProductionNormItems.BOSDataSource = "MMProductionNormItems";
            this.fld_dgcMMProductionNormItems.BOSDescription = null;
            this.fld_dgcMMProductionNormItems.BOSError = null;
            this.fld_dgcMMProductionNormItems.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItems.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItems.BOSGridType = null;
            this.fld_dgcMMProductionNormItems.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItems.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItems.CommodityType = "";
            this.fld_dgcMMProductionNormItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcMMProductionNormItems.Location = new System.Drawing.Point(3, 64);
            this.fld_dgcMMProductionNormItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItems.Name = "fld_dgcMMProductionNormItems";
            this.fld_dgcMMProductionNormItems.PrintReport = false;
            this.fld_dgcMMProductionNormItems.Screen = null;
            this.fld_dgcMMProductionNormItems.Size = new System.Drawing.Size(2285, 553);
            this.fld_dgcMMProductionNormItems.TabIndex = 137;
            // 
            // fld_btnUpdateFromConfigMaterial
            // 
            this.fld_btnUpdateFromConfigMaterial.BOSComment = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDataMember = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDataSource = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDescription = null;
            this.fld_btnUpdateFromConfigMaterial.BOSError = null;
            this.fld_btnUpdateFromConfigMaterial.BOSFieldGroup = null;
            this.fld_btnUpdateFromConfigMaterial.BOSFieldRelation = null;
            this.fld_btnUpdateFromConfigMaterial.BOSPrivilege = null;
            this.fld_btnUpdateFromConfigMaterial.BOSPropertyName = null;
            this.fld_btnUpdateFromConfigMaterial.Location = new System.Drawing.Point(486, 38);
            this.fld_btnUpdateFromConfigMaterial.Name = "fld_btnUpdateFromConfigMaterial";
            this.fld_btnUpdateFromConfigMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateFromConfigMaterial, true);
            this.fld_btnUpdateFromConfigMaterial.Size = new System.Drawing.Size(238, 20);
            this.fld_btnUpdateFromConfigMaterial.TabIndex = 140;
            this.fld_btnUpdateFromConfigMaterial.Text = "Cập nhật cấu hình";
            this.fld_btnUpdateFromConfigMaterial.Visible = false;
            this.fld_btnUpdateFromConfigMaterial.Click += new System.EventHandler(this.fld_btnUpdateFromConfigMaterial_Click);
            // 
            // fld_lblMaterialProduct
            // 
            this.fld_lblMaterialProduct.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblMaterialProduct.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblMaterialProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblMaterialProduct.Appearance.Options.UseBackColor = true;
            this.fld_lblMaterialProduct.Appearance.Options.UseFont = true;
            this.fld_lblMaterialProduct.Appearance.Options.UseForeColor = true;
            this.fld_lblMaterialProduct.BOSComment = "";
            this.fld_lblMaterialProduct.BOSDataMember = "";
            this.fld_lblMaterialProduct.BOSDataSource = "";
            this.fld_lblMaterialProduct.BOSDescription = null;
            this.fld_lblMaterialProduct.BOSError = null;
            this.fld_lblMaterialProduct.BOSFieldGroup = "";
            this.fld_lblMaterialProduct.BOSFieldRelation = "";
            this.fld_lblMaterialProduct.BOSPrivilege = "";
            this.fld_lblMaterialProduct.BOSPropertyName = null;
            this.fld_lblMaterialProduct.Location = new System.Drawing.Point(14, 42);
            this.fld_lblMaterialProduct.Name = "fld_lblMaterialProduct";
            this.fld_lblMaterialProduct.Screen = null;
            this.fld_lblMaterialProduct.Size = new System.Drawing.Size(28, 13);
            this.fld_lblMaterialProduct.TabIndex = 138;
            this.fld_lblMaterialProduct.Tag = "";
            this.fld_lblMaterialProduct.Text = "Vật tư";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.bosPanel6);
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.xtraTabPage9.Size = new System.Drawing.Size(2312, 868);
            this.xtraTabPage9.Text = "Hình ảnh đính kèm";
            // 
            // bosPanel6
            // 
            this.bosPanel6.AutoScroll = true;
            this.bosPanel6.BOSComment = null;
            this.bosPanel6.BOSDataMember = null;
            this.bosPanel6.BOSDataSource = null;
            this.bosPanel6.BOSDescription = null;
            this.bosPanel6.BOSError = null;
            this.bosPanel6.BOSFieldGroup = null;
            this.bosPanel6.BOSFieldRelation = null;
            this.bosPanel6.BOSPrivilege = null;
            this.bosPanel6.BOSPropertyName = null;
            this.bosPanel6.Controls.Add(this.fld_lvImageList);
            this.bosPanel6.Controls.Add(this.fld_btnBrowseFile);
            this.bosPanel6.Controls.Add(this.fld_btnUploadProposalTemplate);
            this.bosPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel6.Location = new System.Drawing.Point(0, 0);
            this.bosPanel6.Name = "bosPanel6";
            this.bosPanel6.Screen = null;
            this.bosPanel6.Size = new System.Drawing.Size(2312, 868);
            this.bosPanel6.TabIndex = 0;
            // 
            // fld_lvImageList
            // 
            this.fld_lvImageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lvImageList.HideSelection = false;
            this.fld_lvImageList.Location = new System.Drawing.Point(3, 38);
            this.fld_lvImageList.Name = "fld_lvImageList";
            this.fld_lvImageList.Size = new System.Drawing.Size(2306, 827);
            this.fld_lvImageList.TabIndex = 20;
            this.fld_lvImageList.UseCompatibleStateImageBehavior = false;
            this.fld_lvImageList.DoubleClick += new System.EventHandler(this.fld_lvImageList_DoubleClick);
            this.fld_lvImageList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lvImageList_KeyUp);
            // 
            // fld_btnBrowseFile
            // 
            this.fld_btnBrowseFile.BOSComment = null;
            this.fld_btnBrowseFile.BOSDataMember = null;
            this.fld_btnBrowseFile.BOSDataSource = null;
            this.fld_btnBrowseFile.BOSDescription = null;
            this.fld_btnBrowseFile.BOSError = null;
            this.fld_btnBrowseFile.BOSFieldGroup = null;
            this.fld_btnBrowseFile.BOSFieldRelation = null;
            this.fld_btnBrowseFile.BOSPrivilege = null;
            this.fld_btnBrowseFile.BOSPropertyName = null;
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(8, 5);
            this.fld_btnBrowseFile.Name = "fld_btnBrowseFile";
            this.fld_btnBrowseFile.Screen = null;
            this.fld_btnBrowseFile.Size = new System.Drawing.Size(104, 27);
            this.fld_btnBrowseFile.TabIndex = 19;
            this.fld_btnBrowseFile.Text = "Chọn hình ảnh";
            this.fld_btnBrowseFile.Click += new System.EventHandler(this.fld_btnBrowseFile_Click);
            // 
            // fld_btnUploadProposalTemplate
            // 
            this.fld_btnUploadProposalTemplate.BOSComment = null;
            this.fld_btnUploadProposalTemplate.BOSDataMember = null;
            this.fld_btnUploadProposalTemplate.BOSDataSource = null;
            this.fld_btnUploadProposalTemplate.BOSDescription = null;
            this.fld_btnUploadProposalTemplate.BOSError = null;
            this.fld_btnUploadProposalTemplate.BOSFieldGroup = null;
            this.fld_btnUploadProposalTemplate.BOSFieldRelation = null;
            this.fld_btnUploadProposalTemplate.BOSPrivilege = null;
            this.fld_btnUploadProposalTemplate.BOSPropertyName = null;
            this.fld_btnUploadProposalTemplate.Location = new System.Drawing.Point(118, 5);
            this.fld_btnUploadProposalTemplate.Name = "fld_btnUploadProposalTemplate";
            this.fld_btnUploadProposalTemplate.Screen = null;
            this.fld_btnUploadProposalTemplate.Size = new System.Drawing.Size(99, 27);
            this.fld_btnUploadProposalTemplate.TabIndex = 16;
            this.fld_btnUploadProposalTemplate.Text = "Lưu hình ảnh";
            this.fld_btnUploadProposalTemplate.Click += new System.EventHandler(this.fld_btnUploadProposalTemplate_Click);
            // 
            // fld_xtpProfile
            // 
            this.fld_xtpProfile.Controls.Add(this.fld_btnSaveProfile);
            this.fld_xtpProfile.Controls.Add(this.fld_dgcMMProfileManagementItems);
            this.fld_xtpProfile.Name = "fld_xtpProfile";
            this.fld_xtpProfile.Size = new System.Drawing.Size(2312, 868);
            this.fld_xtpProfile.Text = "Trang kiểm soát hồ sơ";
            // 
            // fld_btnSaveProfile
            // 
            this.fld_btnSaveProfile.BOSComment = null;
            this.fld_btnSaveProfile.BOSDataMember = null;
            this.fld_btnSaveProfile.BOSDataSource = null;
            this.fld_btnSaveProfile.BOSDescription = null;
            this.fld_btnSaveProfile.BOSError = null;
            this.fld_btnSaveProfile.BOSFieldGroup = null;
            this.fld_btnSaveProfile.BOSFieldRelation = null;
            this.fld_btnSaveProfile.BOSPrivilege = null;
            this.fld_btnSaveProfile.BOSPropertyName = null;
            this.fld_btnSaveProfile.Location = new System.Drawing.Point(10, 10);
            this.fld_btnSaveProfile.Name = "fld_btnSaveProfile";
            this.fld_btnSaveProfile.Screen = null;
            this.fld_btnSaveProfile.Size = new System.Drawing.Size(118, 27);
            this.fld_btnSaveProfile.TabIndex = 113;
            this.fld_btnSaveProfile.Text = "Lưu";
            this.fld_btnSaveProfile.Click += new System.EventHandler(this.fld_btnSaveProfile_Click);
            // 
            // fld_dgcMMProfileManagementItems
            // 
            this.fld_dgcMMProfileManagementItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProfileManagementItems.BOSComment = null;
            this.fld_dgcMMProfileManagementItems.BOSDataMember = null;
            this.fld_dgcMMProfileManagementItems.BOSDataSource = "MMProfileManagementItems";
            this.fld_dgcMMProfileManagementItems.BOSDescription = null;
            this.fld_dgcMMProfileManagementItems.BOSError = null;
            this.fld_dgcMMProfileManagementItems.BOSFieldGroup = null;
            this.fld_dgcMMProfileManagementItems.BOSFieldRelation = null;
            this.fld_dgcMMProfileManagementItems.BOSGridType = null;
            this.fld_dgcMMProfileManagementItems.BOSPrivilege = null;
            this.fld_dgcMMProfileManagementItems.BOSPropertyName = null;
            this.fld_dgcMMProfileManagementItems.CommodityType = "";
            this.fld_dgcMMProfileManagementItems.Location = new System.Drawing.Point(2, 43);
            this.fld_dgcMMProfileManagementItems.MainView = this.gridView1;
            this.fld_dgcMMProfileManagementItems.Name = "fld_dgcMMProfileManagementItems";
            this.fld_dgcMMProfileManagementItems.PrintReport = false;
            this.fld_dgcMMProfileManagementItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProfileManagementItems, true);
            this.fld_dgcMMProfileManagementItems.Size = new System.Drawing.Size(2307, 822);
            this.fld_dgcMMProfileManagementItems.TabIndex = 74;
            this.fld_dgcMMProfileManagementItems.Tag = "DC";
            this.fld_dgcMMProfileManagementItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProfileManagementItems;
            this.gridView1.Name = "gridView1";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProfileManagementItems;
            this.gridView4.Name = "gridView4";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1)});
            this.popupMenu1.Manager = this.screenToolbar;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = " ";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // DMCCB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2330, 925);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCCB100.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(2, 640);
            this.Name = "DMCCB100";
            this.Text = "Định mức sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Validated += new System.EventHandler(this.DMCCB100_Validated);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbBOMStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShowProductNotBOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShowProductHasBOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbBOMType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCarcass)).EndInit();
            this.CarrcassBOMPage.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl4)).EndInit();
            this.bosTabControl4.ResumeLayout(false);
            this.xtraTabPage8.ResumeLayout(false);
            this.bosPanel7.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormColorProccessStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormCarcassProccessStatus.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOverallSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormTotalPaint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcDetailInfo)).EndInit();
            this.fld_tcDetailInfo.ResumeLayout(false);
            this.tpSemiProducts.ResumeLayout(false);
            this.bosPanel8.ResumeLayout(false);
            this.bosPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRate.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeChooseSemi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCarcassForCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPropertiesOrProcess.Properties)).EndInit();
            this.tpProductStructure.ResumeLayout(false);
            this.bosPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductItems)).EndInit();
            this.fld_tabPackageNo.ResumeLayout(false);
            this.fld_pnlPackageDetail.ResumeLayout(false);
            this.fld_pnlPackageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket.Panel1)).EndInit();
            this.fld_splTicket.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket.Panel2)).EndInit();
            this.fld_splTicket.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).EndInit();
            this.fld_splTicket.ResumeLayout(false);
            this.bosLine8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackages)).EndInit();
            this.bosLine9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemPackings)).EndInit();
            this.tpBOM.ResumeLayout(false);
            this.bosPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcBOM)).EndInit();
            this.fld_tcBOM.ResumeLayout(false);
            this.fld_tpSemiProduct.ResumeLayout(false);
            this.bosPanel9.ResumeLayout(false);
            this.bosPanel9.PerformLayout();
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormWoodStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductionNormItemTreeList)).EndInit();
            this.fld_tpHardware.ResumeLayout(false);
            this.bosPanel10.ResumeLayout(false);
            this.bosPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateHardware.Properties)).EndInit();
            this.bosLine12.ResumeLayout(false);
            this.bosLine12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHWBomTemp.Properties)).EndInit();
            this.bosLine7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormHardwareStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).EndInit();
            this.fld_tpPaint.ResumeLayout(false);
            this.fld_pnlPaint.ResumeLayout(false);
            this.fld_pnlPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateIngredientPaint.Properties)).EndInit();
            this.bosLine14.ResumeLayout(false);
            this.bosLine14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePaintTemp.Properties)).EndInit();
            this.bosLine10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemHavePaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPaintStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesID.Properties)).EndInit();
            this.fld_tpPackaging.ResumeLayout(false);
            this.bosPanel13.ResumeLayout(false);
            this.bosPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateIngredientPackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tlcProctionNormItemPackings)).EndInit();
            this.bosLine13.ResumeLayout(false);
            this.bosLine13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackTemp.Properties)).EndInit();
            this.bosLine11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPackingMaterialStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationPackaging.Properties)).EndInit();
            this.fld_tpOther.ResumeLayout(false);
            this.bosPanel11.ResumeLayout(false);
            this.bosPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDepreciationRateGeneralMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeOperationGeneralMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).EndInit();
            this.xtraTabPage9.ResumeLayout(false);
            this.bosPanel6.ResumeLayout(false);
            this.fld_xtpProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProfileManagementItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private ICProductCarcasssGridControl fld_dgcICProductCarcass;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage CarrcassBOMPage;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSTabControl fld_tcDetailInfo;
        private DevExpress.XtraTab.XtraTabPage tpSemiProducts;
        private DevExpress.XtraTab.XtraTabPage tpProductStructure;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSPanel bosPanel4;
        private ProductItemsTreeListControl fld_trlICProductItems;
        private BOSComponent.BOSButton fld_btnSaveBOMTree;
        private BOSComponent.BOSButton fld_btnCreateBOM;
        private DevExpress.XtraTab.XtraTabPage tpBOM;
        private BOSComponent.BOSPanel bosPanel5;
        private BOSComponent.BOSTabControl fld_tcBOM;
        private DevExpress.XtraTab.XtraTabPage fld_tpSemiProduct;
        private ProductionNormItemsTreeListControl fld_trlProductionNormItemTreeList;
        private BOSComponent.BOSButton fld_btnSaveBOM;
        private DevExpress.XtraTab.XtraTabPage fld_tpHardware;
        private BOSComponent.BOSButton fld_btnChangeHardware;
        private BOSComponent.BOSLookupEdit fld_lkeICProductHardwareID;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSButton fld_btnSaveHardware;
        private ProductionNormItemsHardwareTreeListControl fld_trlMMProductionNormItemsHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tpOther;
        private BOSComponent.BOSButton fld_btnUpdateFromConfigMaterial;
        private BOSComponent.BOSLookupEdit fld_lkeICProductMaterialID;
        private BOSComponent.BOSLabel fld_lblMaterialProduct;
        private MMProductionNormItemsGridControl fld_dgcMMProductionNormItems;
        private BOSComponent.BOSButton fld_btnSaveOther;
        private BOSComponent.BOSRadioGroup fld_radPropertiesOrProcess;
        private BOSComponent.BOSPictureEdit fld_pteICProductPicture;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLookupEdit fld_lkeCarcassForCopy;
        private BOSComponent.BOSButton fld_btnCoppyCarcassSemiProduct;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl bosTabControl4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private BOSComponent.BOSPanel bosPanel6;
        private BOSComponent.BOSButton fld_btnBrowseFile;
        private BOSComponent.BOSButton fld_btnUploadProposalTemplate;
        private BOSComponent.BOSPanel bosPanel7;
        private ListView fld_lvImageList;
        private ImageList imageList1;
        private ImageList imageList2;
        private BOSComponent.BOSLookupEdit fld_lkeChooseSemi;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormNo;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormType;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormBlock;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormTotalPaint;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteMMProductionNormPromulgateDate;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormVersion;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormStatus;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormOverallSize;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSPanel bosPanel8;
        private BOSComponent.BOSPanel bosPanel9;
        private BOSComponent.BOSPanel bosPanel10;
        private BOSComponent.BOSPanel bosPanel11;
        private DevExpress.XtraTab.XtraTabPage fld_tpPaint;
        private DevExpress.XtraTab.XtraTabPage fld_tpPackaging;
        private BOSComponent.BOSPanel fld_pnlPaint;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIngredientPaintID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeMMPaintProcessesID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSButton fld_btnSavePaint;
        private ProductionNormItemsPaintTreeListControl fld_trlMMProductionNormItemsPaint;
        private BOSComponent.BOSPanel bosPanel13;
        private BOSComponent.BOSButton fld_btnSavePackaging;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationPackaging;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeOperationGeneralMaterial;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormWoodStatus;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormHardwareStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormHardwareStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormHardwareStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormPaintStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormPaintStatus;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormPaintStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormPackingMaterialStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormPackingMaterialStatus;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormPackingMaterialStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormGeneralMaterialStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormGeneralMaterialStatus;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormGeneralMaterialStatus;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormColorProccessStatus;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormCarcassProccessStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormColorProccessStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormColorProccessStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormCarcassProccessStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormCarcassProccessStatus;
        private BOSComponent.BOSButton fld_btnEditMMProductionNormWoodStatus;
        private BOSComponent.BOSButton fld_btnApproveMMProductionNormWoodStatus;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private MMProductionNormItemHavePaintGridControl fld_dgcMMProductionNormItemHavePaint;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPackaging;
        private BOSComponent.BOSLabel bosLabel37;
        private BOSComponent.BOSTextBox fld_txtDepreciationRate;
        private BOSComponent.BOSLabel bosLabel38;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSButton bosButton3;
        private BOSComponent.BOSRadioGroup fld_radPackaging;
        private SemiProductsGridControl fld_dgcICProducts;
        private BOSComponent.BOSButton fld_btnViewDetailPain;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackageNo;
        private Panel fld_pnlPackageDetail;
        private BOSComponent.BOSLabel bosLabel45;
        private DevExpress.XtraEditors.SplitContainerControl fld_splTicket;
        private BOSComponent.BOSLine bosLine8;
        private ICProductPackagesGridControl fld_dgcICProductPackages;
        private BOSComponent.BOSLine bosLine9;
        private MMProductionNormItemPackingsGridControl fld_dgcMMProductionNormItemPackings;
        private BOSComponent.BOSButton fld_btnSavePackeNo;
        private BOSComponent.BOSLabel fld_lblHeigth;
        private BOSComponent.BOSLabel bosLabel46;
        private BOSComponent.BOSLabel fld_lblWidth;
        private BOSComponent.BOSLabel bosLabel47;
        private BOSComponent.BOSLabel fld_lblLength;
        private BOSComponent.BOSLabel bosLabel48;
        private BOSComponent.BOSLabel fld_lblVolumn;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormDesc;
        private BOSComponent.BOSLabel bosLabel49;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnApprovedAll;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeProductID;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel6;
        private Button button1;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSLabel bosLabel40;
        private BOSComponent.BOSLabel bosLabel39;
        private Button button4;
        private Button button2;
        private Button button5;
        private BOSComponent.BOSCheckEdit fld_lkeShowProductNotBOM;
        private BOSComponent.BOSCheckEdit fld_lkeShowProductHasBOM;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroup;
        private BOSComponent.BOSComboBox fld_cbbBOMType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSButton bosButton1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSLine bosLine7;
        private BOSComponent.BOSMemoEdit bosMemoEdit2;
        private BOSComponent.BOSLine bosLine10;
        private BOSComponent.BOSMemoEdit bosMemoEdit3;
        private BOSComponent.BOSLine bosLine11;
        private BOSComponent.BOSMemoEdit bosMemoEdit4;
        private BOSComponent.BOSButton bosButton4;
        private BOSComponent.BOSButton fld_btnPrintSemiProduct;
        private BOSComponent.BOSButton fld_btnHardware;
        private BOSComponent.BOSButton fld_btnPrintPaint;
        private BOSComponent.BOSButton fld_btnPrintPLDG;
        private BOSComponent.BOSButton fld_btnPrintVTK;
        private BOSComponent.BOSButton fld_btnGetDefualtProcess;
        private BOSComponent.BOSButton fld_btnUnCanceled;
        private BOSComponent.BOSButton bosButton5;
        private DevExpress.XtraTab.XtraTabPage fld_xtpProfile;
        private ProfileManagementItemsGridControl fld_dgcMMProfileManagementItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSButton fld_btnSaveProfile;
        private BOSComponent.BOSLine bosLine12;
        private BOSComponent.BOSButton fld_btnCopyHW;
        private BOSComponent.BOSLabel bosLabel42;
        private BOSComponent.BOSLookupEdit fld_lkeHWBomTemp;
        private BOSComponent.BOSLine bosLine13;
        private BOSComponent.BOSButton fld_btnPackCopy;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkePackTemp;
        private BOSComponent.BOSLine bosLine14;
        private BOSComponent.BOSButton fld_btnCopyPaint;
        private BOSComponent.BOSLabel bosLabel43;
        private BOSComponent.BOSLookupEdit fld_lkePaintTemp;
        private ProductionNormItemsPackagingTreeListControl fld_tlcProctionNormItemPackings;
        private BOSComponent.BOSButton bosButton6;
        private BOSComponent.BOSButton bosButton7;
        private BOSComponent.BOSLabel bosLabel44;
        private CheckedComboBoxEdit fld_cbbBOMStatus;
        private BOSComponent.BOSLabel bosLabel50;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIdentifyWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel bosLabel51;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel52;
        private BOSComponent.BOSTextBox fld_txtDepreciationRateHardware;
        private BOSComponent.BOSTextBox fld_txtDepreciationRateIngredientPaint;
        private BOSComponent.BOSLabel bosLabel53;
        private BOSComponent.BOSTextBox fld_txtDepreciationRateIngredientPackaging;
        private BOSComponent.BOSLabel bosLabel54;
        private BOSComponent.BOSTextBox fld_txtDepreciationRateGeneralMaterial;
        private BOSComponent.BOSLabel bosLabel55;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLabel bosLabel60;
        private BOSComponent.BOSButton fld_btnUpdatePaint;
        private BOSComponent.BOSButton fld_btnPrintMaterial;
    }
}
