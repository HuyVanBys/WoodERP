using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO100
    /// </summary>
    partial class DMSO100
    {
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSubTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalAmount;
        private BOSComponent.BOSLine fld_Line3;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSO100));
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_btnItemDesc = new BOSComponent.BOSButton(this.components);
            this.fld_recARSaleOrderComment = new BOSComponent.BOSRichEditControl(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_recARSaleOrderInternalComment = new BOSComponent.BOSRichEditControl(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkViewDiffPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderPartialShipment = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderTranshipment = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel39 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel40 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnMain = new BOSComponent.BOSLine(this.components);
            this.bosLabel49 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel48 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel46 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel45 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderItemGrantedFrom = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit5 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel43 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel42 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderPortOFLoading = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel95 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbhtbhValidate = new BOSComponent.BOSLabel(this.components);
            this.bosLabel96 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderExchangeRate21 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel93 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID21 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderPortOFDischarge = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARShippingType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lbPono = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderTotalProduct = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderContQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblContQty = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderSaleType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedFK_ARDiscountProgramID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedARSalesman = new BOSComponent.BOSButtonEdit(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_ckeARSaleOrderIsContainerLoader = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ARDeliveryMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeARSaleOrderIsVehicleAllocation = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeARSaleOrderIsInvoiceAndShipment = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeARSaleOrderIsAcceptance = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeARSaleOrderIsDeliveryPlan = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeARSaleOrderIsSaleOrderShipment = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLookupEdit9 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel84 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit10 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel85 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel88 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel97 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel89 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel90 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteARSaleOrderDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkChooseProspectCustomer = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel58 = new BOSComponent.BOSLabel(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel60 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel61 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel86 = new BOSComponent.BOSLabel(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel87 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox20 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel91 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox21 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel92 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit4 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.flt_txtARSaleOrderPriceCostTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderTotalDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderSOCommissionAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderCustomerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_txtARSalesOrderDeliveryFloorNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkARSaleOrderPreDeliverySurveyFalse = new DevExpress.XtraEditors.CheckEdit();
            this.fld_chkARSaleOrderPreDeliverySurveyTrue = new DevExpress.XtraEditors.CheckEdit();
            this.fld_dteARSalesOrderDeliveryTime = new BOSComponent.BOSTimeEdit(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSalesOrderDeliveryFloorType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSOItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnImportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderPaymentTimes = new BOSERP.Modules.SaleOrder.ARSaleOrderPaymentTimesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel50 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSaveCommision = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddCommission = new BOSComponent.BOSButton(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCommissionRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACCustomerObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_dgcCommissionsGridControl = new BOSERP.Modules.SaleOrder.ARCommissionsGridControl();
            this.xtraTabCostList = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddCost = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemCosts = new BOSERP.Modules.SaleOrder.ARSaleOrderItemCostGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddWork = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemWorksGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorksGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductMaterialItem = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorkMaterialsGridControl();
            this.xtraTabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductAssetItem = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorkAssetsGridControl();
            this.xtraTabWorkTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderItemWorkTasksGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorkTasksGridControl();
            this.fld_tabSOItemContainers = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderItemContainers = new BOSERP.Modules.SaleOrder.ARSaleOrderItemContainersGridControl();
            this.fld_Line4 = new BOSComponent.BOSLine(this.components);
            this.fld_lblARSaleOrderInvoiceContactName = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditShippingInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblARSaleOrderDeliveryContactName = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPartialShipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTranshipment.Properties)).BeginInit();
            this.fld_lnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderItemGrantedFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderPortOFLoading.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPortOFDischarge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderContQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderSaleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ARDiscountProgramID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedARSalesman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsContainerLoader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsVehicleAllocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsInvoiceAndShipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsAcceptance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsDeliveryPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsSaleOrderShipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSaleOrderProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox20.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flt_txtARSaleOrderPriceCostTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSalesOrderDeliveryFloorNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPreDeliverySurveyFalse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPreDeliverySurveyTrue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSalesOrderDeliveryTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSalesOrderDeliveryFloorType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.fld_tabSOItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCommissionRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCustomerObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommissionsGridControl)).BeginInit();
            this.xtraTabCostList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemCosts)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorksGridControl)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkMaterialsGridControl)).BeginInit();
            this.xtraTabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkAssetsGridControl)).BeginInit();
            this.xtraTabWorkTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkTasksGridControl)).BeginInit();
            this.fld_tabSOItemContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemContainers)).BeginInit();
            this.fld_Line4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = null;
            this.fld_lblLabel44.BOSDataMember = null;
            this.fld_lblLabel44.BOSDataSource = null;
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = null;
            this.fld_lblLabel44.BOSFieldRelation = null;
            this.fld_lblLabel44.BOSPrivilege = null;
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(108, 41);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 46;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(106, 93);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel46.TabIndex = 48;
            this.fld_lblLabel46.Text = "Chiết khấu";
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = null;
            this.fld_lblLabel47.BOSDataMember = null;
            this.fld_lblLabel47.BOSDataSource = null;
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = null;
            this.fld_lblLabel47.BOSFieldRelation = null;
            this.fld_lblLabel47.BOSPrivilege = null;
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(90, 195);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 49;
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtARSaleOrderDiscountPerCent
            // 
            this.fld_txtARSaleOrderDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderDiscountPerCent.BOSComment = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSDataMember = "ARSaleOrderDiscountPerCent";
            this.fld_txtARSaleOrderDiscountPerCent.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDiscountPerCent.BOSDescription = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSError = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSFieldGroup = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSFieldRelation = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSPrivilege = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderDiscountPerCent.EditValue = "0.00";
            this.fld_txtARSaleOrderDiscountPerCent.Location = new System.Drawing.Point(174, 90);
            this.fld_txtARSaleOrderDiscountPerCent.Name = "fld_txtARSaleOrderDiscountPerCent";
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDiscountPerCent.Screen = null;
            this.fld_txtARSaleOrderDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARSaleOrderDiscountPerCent.TabIndex = 4;
            this.fld_txtARSaleOrderDiscountPerCent.Tag = "DC";
            this.fld_txtARSaleOrderDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARSaleOrderDiscountPerCent_Validated);
            // 
            // fld_txtARSaleOrderDiscountFix
            // 
            this.fld_txtARSaleOrderDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderDiscountFix.BOSComment = null;
            this.fld_txtARSaleOrderDiscountFix.BOSDataMember = "ARSaleOrderDiscountFix";
            this.fld_txtARSaleOrderDiscountFix.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDiscountFix.BOSDescription = null;
            this.fld_txtARSaleOrderDiscountFix.BOSError = null;
            this.fld_txtARSaleOrderDiscountFix.BOSFieldGroup = null;
            this.fld_txtARSaleOrderDiscountFix.BOSFieldRelation = null;
            this.fld_txtARSaleOrderDiscountFix.BOSPrivilege = null;
            this.fld_txtARSaleOrderDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderDiscountFix.EditValue = "0.00";
            this.fld_txtARSaleOrderDiscountFix.Location = new System.Drawing.Point(252, 90);
            this.fld_txtARSaleOrderDiscountFix.Name = "fld_txtARSaleOrderDiscountFix";
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDiscountFix.Screen = null;
            this.fld_txtARSaleOrderDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderDiscountFix.TabIndex = 5;
            this.fld_txtARSaleOrderDiscountFix.Tag = "DC";
            this.fld_txtARSaleOrderDiscountFix.Validated += new System.EventHandler(this.fld_txtARSaleOrderDiscountFix_Validated);
            // 
            // fld_txtARSaleOrderSubTotalAmount
            // 
            this.fld_txtARSaleOrderSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderSubTotalAmount.BOSComment = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSDataMember = "ARSaleOrderSubTotalAmount";
            this.fld_txtARSaleOrderSubTotalAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSubTotalAmount.BOSDescription = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSError = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSubTotalAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderSubTotalAmount.Location = new System.Drawing.Point(175, 38);
            this.fld_txtARSaleOrderSubTotalAmount.Name = "fld_txtARSaleOrderSubTotalAmount";
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSubTotalAmount.Screen = null;
            this.fld_txtARSaleOrderSubTotalAmount.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARSaleOrderSubTotalAmount.TabIndex = 2;
            this.fld_txtARSaleOrderSubTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleOrderTotalAmount
            // 
            this.fld_txtARSaleOrderTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderTotalAmount.BOSComment = null;
            this.fld_txtARSaleOrderTotalAmount.BOSDataMember = "ARSaleOrderTotalAmount";
            this.fld_txtARSaleOrderTotalAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalAmount.BOSDescription = null;
            this.fld_txtARSaleOrderTotalAmount.BOSError = null;
            this.fld_txtARSaleOrderTotalAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTotalAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTotalAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTotalAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderTotalAmount.Location = new System.Drawing.Point(173, 192);
            this.fld_txtARSaleOrderTotalAmount.Name = "fld_txtARSaleOrderTotalAmount";
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalAmount.Screen = null;
            this.fld_txtARSaleOrderTotalAmount.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleOrderTotalAmount.TabIndex = 11;
            this.fld_txtARSaleOrderTotalAmount.Tag = "DC";
            // 
            // fld_Line3
            // 
            this.fld_Line3.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.BOSComment = null;
            this.fld_Line3.BOSDataMember = null;
            this.fld_Line3.BOSDataSource = null;
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = null;
            this.fld_Line3.BOSFieldRelation = null;
            this.fld_Line3.BOSPrivilege = null;
            this.fld_Line3.BOSPropertyName = null;
            this.fld_Line3.Controls.Add(this.fld_btnItemDesc);
            this.fld_Line3.Controls.Add(this.fld_recARSaleOrderComment);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(3, 661);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(350, 109);
            this.fld_Line3.TabIndex = 30;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Text = "Ghi chú in ra";
            // 
            // fld_btnItemDesc
            // 
            this.fld_btnItemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnItemDesc.BOSComment = null;
            this.fld_btnItemDesc.BOSDataMember = null;
            this.fld_btnItemDesc.BOSDataSource = null;
            this.fld_btnItemDesc.BOSDescription = null;
            this.fld_btnItemDesc.BOSError = null;
            this.fld_btnItemDesc.BOSFieldGroup = null;
            this.fld_btnItemDesc.BOSFieldRelation = null;
            this.fld_btnItemDesc.BOSPrivilege = null;
            this.fld_btnItemDesc.BOSPropertyName = null;
            this.fld_btnItemDesc.Location = new System.Drawing.Point(331, 9);
            this.fld_btnItemDesc.Margin = new System.Windows.Forms.Padding(0);
            this.fld_btnItemDesc.Name = "fld_btnItemDesc";
            this.fld_btnItemDesc.Screen = null;
            this.fld_btnItemDesc.Size = new System.Drawing.Size(22, 22);
            this.fld_btnItemDesc.TabIndex = 408;
            this.fld_btnItemDesc.Text = "❐";
            this.fld_btnItemDesc.ToolTip = "Phóng to";
            this.fld_btnItemDesc.Click += new System.EventHandler(this.fld_btnItemDesc_Click);
            // 
            // fld_recARSaleOrderComment
            // 
            this.fld_recARSaleOrderComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARSaleOrderComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_recARSaleOrderComment.BOSComment = null;
            this.fld_recARSaleOrderComment.BOSDataMember = null;
            this.fld_recARSaleOrderComment.BOSDataSource = null;
            this.fld_recARSaleOrderComment.BOSDescription = null;
            this.fld_recARSaleOrderComment.BOSError = null;
            this.fld_recARSaleOrderComment.BOSFieldGroup = null;
            this.fld_recARSaleOrderComment.BOSFieldRelation = null;
            this.fld_recARSaleOrderComment.BOSPrivilege = null;
            this.fld_recARSaleOrderComment.BOSPropertyName = null;
            this.fld_recARSaleOrderComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARSaleOrderComment.Location = new System.Drawing.Point(1, 17);
            this.fld_recARSaleOrderComment.MenuManager = this.screenToolbar;
            this.fld_recARSaleOrderComment.Name = "fld_recARSaleOrderComment";
            this.fld_recARSaleOrderComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleOrderComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleOrderComment.Screen = null;
            this.fld_recARSaleOrderComment.Size = new System.Drawing.Size(346, 88);
            this.fld_recARSaleOrderComment.TabIndex = 0;
            this.fld_recARSaleOrderComment.Tag = "DC";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel4.Appearance.Options.UseBackColor = true;
            this.BOSLabel4.Appearance.Options.UseFont = true;
            this.BOSLabel4.Appearance.Options.UseForeColor = true;
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(89, 222);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(67, 13);
            this.BOSLabel4.TabIndex = 49;
            this.BOSLabel4.Text = "ĐẶT TRƯỚC";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel5.Appearance.Options.UseBackColor = true;
            this.BOSLabel5.Appearance.Options.UseFont = true;
            this.BOSLabel5.Appearance.Options.UseForeColor = true;
            this.BOSLabel5.BOSComment = null;
            this.BOSLabel5.BOSDataMember = null;
            this.BOSLabel5.BOSDataSource = null;
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = null;
            this.BOSLabel5.BOSFieldRelation = null;
            this.BOSLabel5.BOSPrivilege = null;
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(112, 247);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel5.TabIndex = 49;
            this.BOSLabel5.Text = "CÒN LẠI";
            // 
            // fld_txtARSaleOrderDepositBalance
            // 
            this.fld_txtARSaleOrderDepositBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderDepositBalance.BOSComment = null;
            this.fld_txtARSaleOrderDepositBalance.BOSDataMember = "ARSaleOrderDepositBalance";
            this.fld_txtARSaleOrderDepositBalance.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDepositBalance.BOSDescription = null;
            this.fld_txtARSaleOrderDepositBalance.BOSError = null;
            this.fld_txtARSaleOrderDepositBalance.BOSFieldGroup = null;
            this.fld_txtARSaleOrderDepositBalance.BOSFieldRelation = null;
            this.fld_txtARSaleOrderDepositBalance.BOSPrivilege = null;
            this.fld_txtARSaleOrderDepositBalance.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderDepositBalance.EditValue = "0.00";
            this.fld_txtARSaleOrderDepositBalance.Location = new System.Drawing.Point(173, 219);
            this.fld_txtARSaleOrderDepositBalance.Name = "fld_txtARSaleOrderDepositBalance";
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDepositBalance.Screen = null;
            this.fld_txtARSaleOrderDepositBalance.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleOrderDepositBalance.TabIndex = 12;
            this.fld_txtARSaleOrderDepositBalance.Tag = "DC";
            this.fld_txtARSaleOrderDepositBalance.Validated += new System.EventHandler(this.fld_txtARSaleOrderDepositBalance_Validated);
            // 
            // fld_txtARSaleOrderBalanceDue
            // 
            this.fld_txtARSaleOrderBalanceDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderBalanceDue.BOSComment = null;
            this.fld_txtARSaleOrderBalanceDue.BOSDataMember = "ARSaleOrderBalanceDue";
            this.fld_txtARSaleOrderBalanceDue.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderBalanceDue.BOSDescription = null;
            this.fld_txtARSaleOrderBalanceDue.BOSError = null;
            this.fld_txtARSaleOrderBalanceDue.BOSFieldGroup = null;
            this.fld_txtARSaleOrderBalanceDue.BOSFieldRelation = null;
            this.fld_txtARSaleOrderBalanceDue.BOSPrivilege = null;
            this.fld_txtARSaleOrderBalanceDue.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderBalanceDue.EditValue = "0.00";
            this.fld_txtARSaleOrderBalanceDue.Location = new System.Drawing.Point(173, 244);
            this.fld_txtARSaleOrderBalanceDue.Name = "fld_txtARSaleOrderBalanceDue";
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderBalanceDue.Screen = null;
            this.fld_txtARSaleOrderBalanceDue.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleOrderBalanceDue.TabIndex = 13;
            this.fld_txtARSaleOrderBalanceDue.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_recARSaleOrderInternalComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(3, 787);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(350, 100);
            this.bosLine1.TabIndex = 29;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú không in ra";
            // 
            // fld_recARSaleOrderInternalComment
            // 
            this.fld_recARSaleOrderInternalComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARSaleOrderInternalComment.BOSComment = null;
            this.fld_recARSaleOrderInternalComment.BOSDataMember = null;
            this.fld_recARSaleOrderInternalComment.BOSDataSource = null;
            this.fld_recARSaleOrderInternalComment.BOSDescription = null;
            this.fld_recARSaleOrderInternalComment.BOSError = null;
            this.fld_recARSaleOrderInternalComment.BOSFieldGroup = null;
            this.fld_recARSaleOrderInternalComment.BOSFieldRelation = null;
            this.fld_recARSaleOrderInternalComment.BOSPrivilege = null;
            this.fld_recARSaleOrderInternalComment.BOSPropertyName = null;
            this.fld_recARSaleOrderInternalComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARSaleOrderInternalComment.Location = new System.Drawing.Point(4, 17);
            this.fld_recARSaleOrderInternalComment.MenuManager = this.screenToolbar;
            this.fld_recARSaleOrderInternalComment.Name = "fld_recARSaleOrderInternalComment";
            this.fld_recARSaleOrderInternalComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleOrderInternalComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleOrderInternalComment.Screen = null;
            this.fld_recARSaleOrderInternalComment.Size = new System.Drawing.Size(346, 77);
            this.fld_recARSaleOrderInternalComment.TabIndex = 0;
            this.fld_recARSaleOrderInternalComment.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(133, 169);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(24, 13);
            this.bosLabel9.TabIndex = 48;
            this.bosLabel9.Text = "Thuế";
            // 
            // fld_txtARSaleOrderTaxPercent
            // 
            this.fld_txtARSaleOrderTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderTaxPercent.BOSComment = null;
            this.fld_txtARSaleOrderTaxPercent.BOSDataMember = "ARSaleOrderTaxPercent";
            this.fld_txtARSaleOrderTaxPercent.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTaxPercent.BOSDescription = null;
            this.fld_txtARSaleOrderTaxPercent.BOSError = null;
            this.fld_txtARSaleOrderTaxPercent.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTaxPercent.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTaxPercent.BOSPrivilege = null;
            this.fld_txtARSaleOrderTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTaxPercent.EditValue = "0.00";
            this.fld_txtARSaleOrderTaxPercent.Location = new System.Drawing.Point(174, 166);
            this.fld_txtARSaleOrderTaxPercent.Name = "fld_txtARSaleOrderTaxPercent";
            this.fld_txtARSaleOrderTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTaxPercent.Screen = null;
            this.fld_txtARSaleOrderTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARSaleOrderTaxPercent.TabIndex = 9;
            this.fld_txtARSaleOrderTaxPercent.Tag = "DC";
            this.fld_txtARSaleOrderTaxPercent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtARSaleOrderTaxPercent_KeyUp);
            this.fld_txtARSaleOrderTaxPercent.Validated += new System.EventHandler(this.fld_txtARSaleOrderTaxPercent_Validated);
            // 
            // fld_txtARSaleOrderTaxAmount
            // 
            this.fld_txtARSaleOrderTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderTaxAmount.BOSComment = null;
            this.fld_txtARSaleOrderTaxAmount.BOSDataMember = "ARSaleOrderTaxAmount";
            this.fld_txtARSaleOrderTaxAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTaxAmount.BOSDescription = null;
            this.fld_txtARSaleOrderTaxAmount.BOSError = null;
            this.fld_txtARSaleOrderTaxAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTaxAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTaxAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTaxAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderTaxAmount.Location = new System.Drawing.Point(252, 166);
            this.fld_txtARSaleOrderTaxAmount.Name = "fld_txtARSaleOrderTaxAmount";
            this.fld_txtARSaleOrderTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTaxAmount.Screen = null;
            this.fld_txtARSaleOrderTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderTaxAmount.TabIndex = 10;
            this.fld_txtARSaleOrderTaxAmount.Tag = "DC";
            this.fld_txtARSaleOrderTaxAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderTaxAmount_Validated);
            // 
            // fld_lnkViewDiffPrice
            // 
            this.fld_lnkViewDiffPrice.EditValue = "Xem chênh lệch giá kê";
            this.fld_lnkViewDiffPrice.Location = new System.Drawing.Point(803, 926);
            this.fld_lnkViewDiffPrice.MenuManager = this.screenToolbar;
            this.fld_lnkViewDiffPrice.Name = "fld_lnkViewDiffPrice";
            this.fld_lnkViewDiffPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkViewDiffPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkViewDiffPrice.Size = new System.Drawing.Size(177, 20);
            this.fld_lnkViewDiffPrice.TabIndex = 42;
            this.fld_lnkViewDiffPrice.Visible = false;
            this.fld_lnkViewDiffPrice.Click += new System.EventHandler(this.fld_lnkViewDiffPrice_Click);
            // 
            // bosPanel1
            // 
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
            this.bosPanel1.Controls.Add(this.bosLine5);
            this.bosPanel1.Controls.Add(this.fld_lnMain);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_Line4);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lnkViewDiffPrice);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1520, 1028);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLine5
            // 
            this.bosLine5.BackColor = System.Drawing.Color.Transparent;
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosTextBox8);
            this.bosLine5.Controls.Add(this.bosLabel47);
            this.bosLine5.Controls.Add(this.fld_txtARSaleOrderPartialShipment);
            this.bosLine5.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosLine5.Controls.Add(this.fld_txtARSaleOrderTranshipment);
            this.bosLine5.Controls.Add(this.bosLabel39);
            this.bosLine5.Controls.Add(this.fld_lblLabel43);
            this.bosLine5.Controls.Add(this.bosLabel40);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine5.Location = new System.Drawing.Point(772, 793);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine5, true);
            this.bosLine5.Size = new System.Drawing.Size(278, 127);
            this.bosLine5.TabIndex = 762;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Thông tin khác";
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = null;
            this.bosTextBox8.BOSDataMember = "ARSaleOrderPortShippingLineText";
            this.bosTextBox8.BOSDataSource = "ARSaleOrders";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = null;
            this.bosTextBox8.BOSFieldRelation = null;
            this.bosTextBox8.BOSPrivilege = null;
            this.bosTextBox8.BOSPropertyName = "EditValue";
            this.bosTextBox8.Location = new System.Drawing.Point(92, 70);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(165, 20);
            this.bosTextBox8.TabIndex = 762;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosLabel47
            // 
            this.bosLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel47.Appearance.Options.UseBackColor = true;
            this.bosLabel47.Appearance.Options.UseForeColor = true;
            this.bosLabel47.BOSComment = null;
            this.bosLabel47.BOSDataMember = null;
            this.bosLabel47.BOSDataSource = null;
            this.bosLabel47.BOSDescription = null;
            this.bosLabel47.BOSError = null;
            this.bosLabel47.BOSFieldGroup = null;
            this.bosLabel47.BOSFieldRelation = null;
            this.bosLabel47.BOSPrivilege = null;
            this.bosLabel47.BOSPropertyName = null;
            this.bosLabel47.Location = new System.Drawing.Point(10, 73);
            this.bosLabel47.Name = "bosLabel47";
            this.bosLabel47.Screen = null;
            this.bosLabel47.Size = new System.Drawing.Size(62, 13);
            this.bosLabel47.TabIndex = 763;
            this.bosLabel47.Text = "Shipping Line";
            // 
            // fld_txtARSaleOrderPartialShipment
            // 
            this.fld_txtARSaleOrderPartialShipment.BOSComment = null;
            this.fld_txtARSaleOrderPartialShipment.BOSDataMember = "ARSaleOrderPortPartialShipmentText";
            this.fld_txtARSaleOrderPartialShipment.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderPartialShipment.BOSDescription = null;
            this.fld_txtARSaleOrderPartialShipment.BOSError = null;
            this.fld_txtARSaleOrderPartialShipment.BOSFieldGroup = null;
            this.fld_txtARSaleOrderPartialShipment.BOSFieldRelation = null;
            this.fld_txtARSaleOrderPartialShipment.BOSPrivilege = null;
            this.fld_txtARSaleOrderPartialShipment.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderPartialShipment.Location = new System.Drawing.Point(92, 20);
            this.fld_txtARSaleOrderPartialShipment.Name = "fld_txtARSaleOrderPartialShipment";
            this.fld_txtARSaleOrderPartialShipment.Screen = null;
            this.fld_txtARSaleOrderPartialShipment.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARSaleOrderPartialShipment.TabIndex = 758;
            this.fld_txtARSaleOrderPartialShipment.Tag = "DC";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = null;
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = null;
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = null;
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = null;
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = null;
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(92, 96);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Mức giá", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 0;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_txtARSaleOrderTranshipment
            // 
            this.fld_txtARSaleOrderTranshipment.BOSComment = null;
            this.fld_txtARSaleOrderTranshipment.BOSDataMember = "ARSaleOrderPortTranShipmentText";
            this.fld_txtARSaleOrderTranshipment.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTranshipment.BOSDescription = null;
            this.fld_txtARSaleOrderTranshipment.BOSError = null;
            this.fld_txtARSaleOrderTranshipment.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTranshipment.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTranshipment.BOSPrivilege = null;
            this.fld_txtARSaleOrderTranshipment.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTranshipment.Location = new System.Drawing.Point(92, 46);
            this.fld_txtARSaleOrderTranshipment.Name = "fld_txtARSaleOrderTranshipment";
            this.fld_txtARSaleOrderTranshipment.Screen = null;
            this.fld_txtARSaleOrderTranshipment.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARSaleOrderTranshipment.TabIndex = 760;
            this.fld_txtARSaleOrderTranshipment.Tag = "DC";
            // 
            // bosLabel39
            // 
            this.bosLabel39.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel39.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel39.Appearance.Options.UseBackColor = true;
            this.bosLabel39.Appearance.Options.UseForeColor = true;
            this.bosLabel39.BOSComment = null;
            this.bosLabel39.BOSDataMember = null;
            this.bosLabel39.BOSDataSource = null;
            this.bosLabel39.BOSDescription = null;
            this.bosLabel39.BOSError = null;
            this.bosLabel39.BOSFieldGroup = null;
            this.bosLabel39.BOSFieldRelation = null;
            this.bosLabel39.BOSPrivilege = null;
            this.bosLabel39.BOSPropertyName = null;
            this.bosLabel39.Location = new System.Drawing.Point(10, 23);
            this.bosLabel39.Name = "bosLabel39";
            this.bosLabel39.Screen = null;
            this.bosLabel39.Size = new System.Drawing.Size(77, 13);
            this.bosLabel39.TabIndex = 759;
            this.bosLabel39.Text = "Partial Shipment";
            // 
            // fld_lblLabel43
            // 
            this.fld_lblLabel43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel43.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel43.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel43.BOSComment = null;
            this.fld_lblLabel43.BOSDataMember = null;
            this.fld_lblLabel43.BOSDataSource = null;
            this.fld_lblLabel43.BOSDescription = null;
            this.fld_lblLabel43.BOSError = null;
            this.fld_lblLabel43.BOSFieldGroup = null;
            this.fld_lblLabel43.BOSFieldRelation = null;
            this.fld_lblLabel43.BOSPrivilege = null;
            this.fld_lblLabel43.BOSPropertyName = null;
            this.fld_lblLabel43.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
            this.fld_lblLabel43.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel43.TabIndex = 558;
            this.fld_lblLabel43.Text = "Mức giá";
            // 
            // bosLabel40
            // 
            this.bosLabel40.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel40.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel40.Appearance.Options.UseBackColor = true;
            this.bosLabel40.Appearance.Options.UseForeColor = true;
            this.bosLabel40.BOSComment = null;
            this.bosLabel40.BOSDataMember = null;
            this.bosLabel40.BOSDataSource = null;
            this.bosLabel40.BOSDescription = null;
            this.bosLabel40.BOSError = null;
            this.bosLabel40.BOSFieldGroup = null;
            this.bosLabel40.BOSFieldRelation = null;
            this.bosLabel40.BOSPrivilege = null;
            this.bosLabel40.BOSPropertyName = null;
            this.bosLabel40.Location = new System.Drawing.Point(10, 49);
            this.bosLabel40.Name = "bosLabel40";
            this.bosLabel40.Screen = null;
            this.bosLabel40.Size = new System.Drawing.Size(65, 13);
            this.bosLabel40.TabIndex = 761;
            this.bosLabel40.Text = "Transhipment";
            // 
            // fld_lnMain
            // 
            this.fld_lnMain.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnMain.BOSComment = null;
            this.fld_lnMain.BOSDataMember = null;
            this.fld_lnMain.BOSDataSource = null;
            this.fld_lnMain.BOSDescription = null;
            this.fld_lnMain.BOSError = null;
            this.fld_lnMain.BOSFieldGroup = null;
            this.fld_lnMain.BOSFieldRelation = null;
            this.fld_lnMain.BOSPrivilege = null;
            this.fld_lnMain.BOSPropertyName = null;
            this.fld_lnMain.Controls.Add(this.bosLabel49);
            this.fld_lnMain.Controls.Add(this.bosTextBox9);
            this.fld_lnMain.Controls.Add(this.bosLabel48);
            this.fld_lnMain.Controls.Add(this.bosLabel46);
            this.fld_lnMain.Controls.Add(this.bosTextBox7);
            this.fld_lnMain.Controls.Add(this.bosLabel45);
            this.fld_lnMain.Controls.Add(this.bosLabel44);
            this.fld_lnMain.Controls.Add(this.fld_lkeARSaleOrderItemGrantedFrom);
            this.fld_lnMain.Controls.Add(this.bosLookupEdit5);
            this.fld_lnMain.Controls.Add(this.bosLabel43);
            this.fld_lnMain.Controls.Add(this.bosLabel42);
            this.fld_lnMain.Controls.Add(this.bosTextBox6);
            this.fld_lnMain.Controls.Add(this.bosTextBox4);
            this.fld_lnMain.Controls.Add(this.bosLabel41);
            this.fld_lnMain.Controls.Add(this.fld_lkeARSaleOrderPortOFLoading);
            this.fld_lnMain.Controls.Add(this.bosLabel95);
            this.fld_lnMain.Controls.Add(this.bosLabel18);
            this.fld_lnMain.Controls.Add(this.bosLabel38);
            this.fld_lnMain.Controls.Add(this.fld_lbhtbhValidate);
            this.fld_lnMain.Controls.Add(this.bosLabel96);
            this.fld_lnMain.Controls.Add(this.fld_txtARSaleOrderExchangeRate21);
            this.fld_lnMain.Controls.Add(this.bosLabel33);
            this.fld_lnMain.Controls.Add(this.bosLabel93);
            this.fld_lnMain.Controls.Add(this.bosLabel34);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_GECurrencyID21);
            this.fld_lnMain.Controls.Add(this.bosLabel36);
            this.fld_lnMain.Controls.Add(this.fld_txtARSaleOrderPortOFDischarge);
            this.fld_lnMain.Controls.Add(this.bosLabel23);
            this.fld_lnMain.Controls.Add(this.fld_lbWoodType);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.fld_lnMain.Controls.Add(this.bosLabel20);
            this.fld_lnMain.Controls.Add(this.fld_lkeARShippingType);
            this.fld_lnMain.Controls.Add(this.bosTextBox3);
            this.fld_lnMain.Controls.Add(this.fld_lbPono);
            this.fld_lnMain.Controls.Add(this.fld_txtARSaleOrderTotalProduct);
            this.fld_lnMain.Controls.Add(this.bosLabel11);
            this.fld_lnMain.Controls.Add(this.fld_txtARSaleOrderContQty);
            this.fld_lnMain.Controls.Add(this.fld_lblContQty);
            this.fld_lnMain.Controls.Add(this.bosLabel8);
            this.fld_lnMain.Controls.Add(this.fld_lkeARSaleOrderSaleType);
            this.fld_lnMain.Controls.Add(this.bosLabel7);
            this.fld_lnMain.Controls.Add(this.fld_lkeARSaleOrderType);
            this.fld_lnMain.Controls.Add(this.fld_bedFK_ARDiscountProgramID);
            this.fld_lnMain.Controls.Add(this.fld_lblLabel28);
            this.fld_lnMain.Controls.Add(this.fld_bedARSalesman);
            this.fld_lnMain.Controls.Add(this.bosTextBox2);
            this.fld_lnMain.Controls.Add(this.bosLabel3);
            this.fld_lnMain.Controls.Add(this.bosLine4);
            this.fld_lnMain.Controls.Add(this.bosLookupEdit9);
            this.fld_lnMain.Controls.Add(this.bosLabel84);
            this.fld_lnMain.Controls.Add(this.bosLookupEdit10);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.fld_lnMain.Controls.Add(this.bosLabel85);
            this.fld_lnMain.Controls.Add(this.bosLabel88);
            this.fld_lnMain.Controls.Add(this.bosLabel97);
            this.fld_lnMain.Controls.Add(this.fld_txtARSaleOrderExchangeRate);
            this.fld_lnMain.Controls.Add(this.bosLabel89);
            this.fld_lnMain.Controls.Add(this.bosLabel90);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.fld_lnMain.Controls.Add(this.fld_dteARSaleOrderDeliveryDate);
            this.fld_lnMain.Controls.Add(this.bosLookupEdit4);
            this.fld_lnMain.Controls.Add(this.bosTextBox1);
            this.fld_lnMain.Controls.Add(this.fld_lnkChooseProspectCustomer);
            this.fld_lnMain.Controls.Add(this.bosLabel58);
            this.fld_lnMain.Controls.Add(this.bosButton2);
            this.fld_lnMain.Controls.Add(this.bosLabel60);
            this.fld_lnMain.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.fld_lnMain.Controls.Add(this.bosLabel61);
            this.fld_lnMain.Controls.Add(this.bosLabel62);
            this.fld_lnMain.Controls.Add(this.fld_lkeSaleOrderProductType);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.fld_lnMain.Controls.Add(this.bosLabel86);
            this.fld_lnMain.Controls.Add(this.bosMemoEdit1);
            this.fld_lnMain.Controls.Add(this.bosLabel87);
            this.fld_lnMain.Controls.Add(this.bosTextBox20);
            this.fld_lnMain.Controls.Add(this.bosLabel91);
            this.fld_lnMain.Controls.Add(this.bosTextBox21);
            this.fld_lnMain.Controls.Add(this.bosLabel92);
            this.fld_lnMain.Controls.Add(this.bosLabel94);
            this.fld_lnMain.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.fld_lnMain.Controls.Add(this.bosDateEdit4);
            this.fld_lnMain.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.fld_lnMain.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.fld_lnMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_lnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lnMain.Location = new System.Drawing.Point(6, 3);
            this.fld_lnMain.Name = "fld_lnMain";
            this.fld_lnMain.Screen = null;
            this.fld_lnMain.Size = new System.Drawing.Size(1417, 277);
            this.fld_lnMain.TabIndex = 0;
            this.fld_lnMain.TabStop = false;
            // 
            // bosLabel49
            // 
            this.bosLabel49.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel49.Appearance.Options.UseForeColor = true;
            this.bosLabel49.BOSComment = null;
            this.bosLabel49.BOSDataMember = null;
            this.bosLabel49.BOSDataSource = null;
            this.bosLabel49.BOSDescription = null;
            this.bosLabel49.BOSError = null;
            this.bosLabel49.BOSFieldGroup = null;
            this.bosLabel49.BOSFieldRelation = null;
            this.bosLabel49.BOSPrivilege = null;
            this.bosLabel49.BOSPropertyName = null;
            this.bosLabel49.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel49.Location = new System.Drawing.Point(902, 68);
            this.bosLabel49.Name = "bosLabel49";
            this.bosLabel49.Screen = null;
            this.bosLabel49.Size = new System.Drawing.Size(6, 13);
            this.bosLabel49.TabIndex = 852;
            this.bosLabel49.Text = "*";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = null;
            this.bosTextBox9.BOSDataMember = "ARSaleOrderName";
            this.bosTextBox9.BOSDataSource = "ARSaleOrders";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = null;
            this.bosTextBox9.BOSFieldRelation = null;
            this.bosTextBox9.BOSPrivilege = null;
            this.bosTextBox9.BOSPropertyName = "EditValue";
            this.bosTextBox9.Location = new System.Drawing.Point(770, 221);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(128, 20);
            this.bosTextBox9.TabIndex = 69;
            this.bosTextBox9.Tag = "DC";
            // 
            // bosLabel48
            // 
            this.bosLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel48.Appearance.Options.UseBackColor = true;
            this.bosLabel48.Appearance.Options.UseForeColor = true;
            this.bosLabel48.BOSComment = "";
            this.bosLabel48.BOSDataMember = "";
            this.bosLabel48.BOSDataSource = "";
            this.bosLabel48.BOSDescription = null;
            this.bosLabel48.BOSError = null;
            this.bosLabel48.BOSFieldGroup = "";
            this.bosLabel48.BOSFieldRelation = "";
            this.bosLabel48.BOSPrivilege = "";
            this.bosLabel48.BOSPropertyName = null;
            this.bosLabel48.Location = new System.Drawing.Point(650, 224);
            this.bosLabel48.Name = "bosLabel48";
            this.bosLabel48.Screen = null;
            this.bosLabel48.Size = new System.Drawing.Size(94, 13);
            this.bosLabel48.TabIndex = 68;
            this.bosLabel48.Tag = "";
            this.bosLabel48.Text = "Mã đơn hàng nội bộ";
            // 
            // bosLabel46
            // 
            this.bosLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel46.Appearance.Options.UseBackColor = true;
            this.bosLabel46.Appearance.Options.UseForeColor = true;
            this.bosLabel46.BOSComment = "";
            this.bosLabel46.BOSDataMember = "";
            this.bosLabel46.BOSDataSource = "";
            this.bosLabel46.BOSDescription = null;
            this.bosLabel46.BOSError = null;
            this.bosLabel46.BOSFieldGroup = "";
            this.bosLabel46.BOSFieldRelation = "";
            this.bosLabel46.BOSPrivilege = "";
            this.bosLabel46.BOSPropertyName = null;
            this.bosLabel46.Location = new System.Drawing.Point(378, 199);
            this.bosLabel46.Name = "bosLabel46";
            this.bosLabel46.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel46, true);
            this.bosLabel46.Size = new System.Drawing.Size(48, 13);
            this.bosLabel46.TabIndex = 60;
            this.bosLabel46.Tag = "";
            this.bosLabel46.Text = "Tổng CBM";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = "";
            this.bosTextBox7.BOSDataMember = "ARSaleOrderCBM";
            this.bosTextBox7.BOSDataSource = "ARSaleOrders";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = "";
            this.bosTextBox7.BOSFieldRelation = "";
            this.bosTextBox7.BOSPrivilege = "";
            this.bosTextBox7.BOSPropertyName = "EditValue";
            this.bosTextBox7.EditValue = "";
            this.bosTextBox7.Location = new System.Drawing.Point(476, 196);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox7, true);
            this.bosTextBox7.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox7.TabIndex = 61;
            this.bosTextBox7.Tag = "DC";
            // 
            // bosLabel45
            // 
            this.bosLabel45.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel45.Appearance.Options.UseForeColor = true;
            this.bosLabel45.BOSComment = null;
            this.bosLabel45.BOSDataMember = null;
            this.bosLabel45.BOSDataSource = null;
            this.bosLabel45.BOSDescription = null;
            this.bosLabel45.BOSError = null;
            this.bosLabel45.BOSFieldGroup = null;
            this.bosLabel45.BOSFieldRelation = null;
            this.bosLabel45.BOSPrivilege = null;
            this.bosLabel45.BOSPropertyName = null;
            this.bosLabel45.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel45.Location = new System.Drawing.Point(632, 224);
            this.bosLabel45.Name = "bosLabel45";
            this.bosLabel45.Screen = null;
            this.bosLabel45.Size = new System.Drawing.Size(6, 13);
            this.bosLabel45.TabIndex = 847;
            this.bosLabel45.Text = "*";
            // 
            // bosLabel44
            // 
            this.bosLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel44.Appearance.Options.UseBackColor = true;
            this.bosLabel44.Appearance.Options.UseForeColor = true;
            this.bosLabel44.BOSComment = null;
            this.bosLabel44.BOSDataMember = null;
            this.bosLabel44.BOSDataSource = null;
            this.bosLabel44.BOSDescription = null;
            this.bosLabel44.BOSError = null;
            this.bosLabel44.BOSFieldGroup = null;
            this.bosLabel44.BOSFieldRelation = null;
            this.bosLabel44.BOSPrivilege = null;
            this.bosLabel44.BOSPropertyName = null;
            this.bosLabel44.Location = new System.Drawing.Point(378, 226);
            this.bosLabel44.Name = "bosLabel44";
            this.bosLabel44.Screen = null;
            this.bosLabel44.Size = new System.Drawing.Size(33, 13);
            this.bosLabel44.TabIndex = 66;
            this.bosLabel44.Text = "Cấp từ";
            // 
            // fld_lkeARSaleOrderItemGrantedFrom
            // 
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSComment = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSDataMember = "ARSaleOrderItemGrantedFrom";
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSDescription = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSError = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSFieldParent = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSPrivilege = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSSelectType = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.Location = new System.Drawing.Point(476, 223);
            this.fld_lkeARSaleOrderItemGrantedFrom.Name = "fld_lkeARSaleOrderItemGrantedFrom";
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.NullText = "";
            this.fld_lkeARSaleOrderItemGrantedFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderItemGrantedFrom.Screen = null;
            this.fld_lkeARSaleOrderItemGrantedFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderItemGrantedFrom.TabIndex = 67;
            this.fld_lkeARSaleOrderItemGrantedFrom.Tag = "DC";
            this.fld_lkeARSaleOrderItemGrantedFrom.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeARSaleOrderItemGrantedFrom_CloseUp);
            // 
            // bosLookupEdit5
            // 
            this.bosLookupEdit5.BOSAllowAddNew = false;
            this.bosLookupEdit5.BOSAllowDummy = false;
            this.bosLookupEdit5.BOSComment = null;
            this.bosLookupEdit5.BOSDataMember = "ARListOfSalesChannelType";
            this.bosLookupEdit5.BOSDataSource = "ARSaleOrders";
            this.bosLookupEdit5.BOSDescription = null;
            this.bosLookupEdit5.BOSError = null;
            this.bosLookupEdit5.BOSFieldGroup = null;
            this.bosLookupEdit5.BOSFieldParent = null;
            this.bosLookupEdit5.BOSFieldRelation = null;
            this.bosLookupEdit5.BOSPrivilege = null;
            this.bosLookupEdit5.BOSPropertyName = "EditValue";
            this.bosLookupEdit5.BOSSelectType = "";
            this.bosLookupEdit5.BOSSelectTypeValue = "";
            this.bosLookupEdit5.CurrentDisplayText = null;
            this.bosLookupEdit5.Location = new System.Drawing.Point(210, 197);
            this.bosLookupEdit5.Name = "bosLookupEdit5";
            this.bosLookupEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit5.Properties.ColumnName = null;
            this.bosLookupEdit5.Properties.NullText = "";
            this.bosLookupEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit5, true);
            this.bosLookupEdit5.Size = new System.Drawing.Size(155, 20);
            this.bosLookupEdit5.TabIndex = 59;
            this.bosLookupEdit5.Tag = "DC";
            // 
            // bosLabel43
            // 
            this.bosLabel43.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel43.Appearance.Options.UseForeColor = true;
            this.bosLabel43.BOSComment = null;
            this.bosLabel43.BOSDataMember = null;
            this.bosLabel43.BOSDataSource = null;
            this.bosLabel43.BOSDescription = null;
            this.bosLabel43.BOSError = null;
            this.bosLabel43.BOSFieldGroup = null;
            this.bosLabel43.BOSFieldRelation = null;
            this.bosLabel43.BOSPrivilege = null;
            this.bosLabel43.BOSPropertyName = null;
            this.bosLabel43.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel43.Location = new System.Drawing.Point(368, 199);
            this.bosLabel43.Name = "bosLabel43";
            this.bosLabel43.Screen = null;
            this.bosLabel43.Size = new System.Drawing.Size(6, 13);
            this.bosLabel43.TabIndex = 843;
            this.bosLabel43.Text = "*";
            // 
            // bosLabel42
            // 
            this.bosLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel42.Appearance.Options.UseBackColor = true;
            this.bosLabel42.Appearance.Options.UseForeColor = true;
            this.bosLabel42.BOSComment = null;
            this.bosLabel42.BOSDataMember = null;
            this.bosLabel42.BOSDataSource = null;
            this.bosLabel42.BOSDescription = null;
            this.bosLabel42.BOSError = null;
            this.bosLabel42.BOSFieldGroup = null;
            this.bosLabel42.BOSFieldRelation = null;
            this.bosLabel42.BOSPrivilege = null;
            this.bosLabel42.BOSPropertyName = null;
            this.bosLabel42.Location = new System.Drawing.Point(116, 199);
            this.bosLabel42.Name = "bosLabel42";
            this.bosLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel42, true);
            this.bosLabel42.Size = new System.Drawing.Size(72, 13);
            this.bosLabel42.TabIndex = 58;
            this.bosLabel42.Text = "Kênh bán hàng";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARSaleOrderSaleContract";
            this.bosTextBox6.BOSDataSource = "ARSaleOrders";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(770, 247);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(128, 20);
            this.bosTextBox6.TabIndex = 73;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARSaleOrderProject";
            this.bosTextBox4.BOSDataSource = "ARSaleOrders";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(210, 171);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(155, 20);
            this.bosTextBox4.TabIndex = 53;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.Options.UseBackColor = true;
            this.bosLabel41.Appearance.Options.UseForeColor = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(116, 174);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(45, 13);
            this.bosLabel41.TabIndex = 52;
            this.bosLabel41.Text = "Mã dự án";
            // 
            // fld_lkeARSaleOrderPortOFLoading
            // 
            this.fld_lkeARSaleOrderPortOFLoading.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderPortOFLoading.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderPortOFLoading.BOSComment = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSDataMember = "FK_GETerminalID";
            this.fld_lkeARSaleOrderPortOFLoading.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderPortOFLoading.BOSDescription = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSError = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSFieldParent = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSPrivilege = null;
            this.fld_lkeARSaleOrderPortOFLoading.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderPortOFLoading.BOSSelectType = "";
            this.fld_lkeARSaleOrderPortOFLoading.BOSSelectTypeValue = "";
            this.fld_lkeARSaleOrderPortOFLoading.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderPortOFLoading.Location = new System.Drawing.Point(770, 169);
            this.fld_lkeARSaleOrderPortOFLoading.Name = "fld_lkeARSaleOrderPortOFLoading";
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderPortOFLoading.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderPortOFLoading.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã cảng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên cảng")});
            this.fld_lkeARSaleOrderPortOFLoading.Properties.DisplayMember = "GETerminalName";
            this.fld_lkeARSaleOrderPortOFLoading.Properties.NullText = "";
            this.fld_lkeARSaleOrderPortOFLoading.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderPortOFLoading.Properties.ValueMember = "GETerminalID";
            this.fld_lkeARSaleOrderPortOFLoading.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderPortOFLoading, true);
            this.fld_lkeARSaleOrderPortOFLoading.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeARSaleOrderPortOFLoading.TabIndex = 57;
            this.fld_lkeARSaleOrderPortOFLoading.Tag = "DC";
            // 
            // bosLabel95
            // 
            this.bosLabel95.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel95.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel95.Appearance.Options.UseBackColor = true;
            this.bosLabel95.Appearance.Options.UseForeColor = true;
            this.bosLabel95.BOSComment = null;
            this.bosLabel95.BOSDataMember = null;
            this.bosLabel95.BOSDataSource = null;
            this.bosLabel95.BOSDescription = null;
            this.bosLabel95.BOSError = null;
            this.bosLabel95.BOSFieldGroup = null;
            this.bosLabel95.BOSFieldRelation = null;
            this.bosLabel95.BOSPrivilege = null;
            this.bosLabel95.BOSPropertyName = null;
            this.bosLabel95.Location = new System.Drawing.Point(650, 18);
            this.bosLabel95.Name = "bosLabel95";
            this.bosLabel95.Screen = null;
            this.bosLabel95.Size = new System.Drawing.Size(75, 13);
            this.bosLabel95.TabIndex = 6;
            this.bosLabel95.Text = "Ngày giao hàng";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.bosLabel18.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel18.Location = new System.Drawing.Point(366, 120);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(6, 13);
            this.bosLabel18.TabIndex = 835;
            this.bosLabel18.Text = "*";
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = null;
            this.bosLabel38.BOSDataMember = null;
            this.bosLabel38.BOSDataSource = null;
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = null;
            this.bosLabel38.BOSFieldRelation = null;
            this.bosLabel38.BOSPrivilege = null;
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel38.Location = new System.Drawing.Point(902, 42);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(6, 13);
            this.bosLabel38.TabIndex = 834;
            this.bosLabel38.Text = "*";
            // 
            // fld_lbhtbhValidate
            // 
            this.fld_lbhtbhValidate.Appearance.ForeColor = System.Drawing.Color.Red;
            this.fld_lbhtbhValidate.Appearance.Options.UseForeColor = true;
            this.fld_lbhtbhValidate.BOSComment = null;
            this.fld_lbhtbhValidate.BOSDataMember = null;
            this.fld_lbhtbhValidate.BOSDataSource = null;
            this.fld_lbhtbhValidate.BOSDescription = null;
            this.fld_lbhtbhValidate.BOSError = null;
            this.fld_lbhtbhValidate.BOSFieldGroup = null;
            this.fld_lbhtbhValidate.BOSFieldRelation = null;
            this.fld_lbhtbhValidate.BOSPrivilege = null;
            this.fld_lbhtbhValidate.BOSPropertyName = null;
            this.fld_lbhtbhValidate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.fld_lbhtbhValidate.Location = new System.Drawing.Point(632, 121);
            this.fld_lbhtbhValidate.Name = "fld_lbhtbhValidate";
            this.fld_lbhtbhValidate.Screen = null;
            this.fld_lbhtbhValidate.Size = new System.Drawing.Size(6, 13);
            this.fld_lbhtbhValidate.TabIndex = 833;
            this.fld_lbhtbhValidate.Text = "*";
            // 
            // bosLabel96
            // 
            this.bosLabel96.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel96.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel96.Appearance.Options.UseBackColor = true;
            this.bosLabel96.Appearance.Options.UseForeColor = true;
            this.bosLabel96.BOSComment = null;
            this.bosLabel96.BOSDataMember = null;
            this.bosLabel96.BOSDataSource = null;
            this.bosLabel96.BOSDescription = null;
            this.bosLabel96.BOSError = null;
            this.bosLabel96.BOSFieldGroup = null;
            this.bosLabel96.BOSFieldRelation = null;
            this.bosLabel96.BOSPrivilege = null;
            this.bosLabel96.BOSPropertyName = null;
            this.bosLabel96.Location = new System.Drawing.Point(378, 18);
            this.bosLabel96.Name = "bosLabel96";
            this.bosLabel96.Screen = null;
            this.bosLabel96.Size = new System.Drawing.Size(72, 13);
            this.bosLabel96.TabIndex = 4;
            this.bosLabel96.Text = "Ngày chứng từ";
            // 
            // fld_txtARSaleOrderExchangeRate21
            // 
            this.fld_txtARSaleOrderExchangeRate21.BOSComment = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSDataMember = "ARSaleOrderExchangeRate2";
            this.fld_txtARSaleOrderExchangeRate21.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderExchangeRate21.BOSDescription = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSError = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSFieldGroup = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSFieldRelation = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSPrivilege = null;
            this.fld_txtARSaleOrderExchangeRate21.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderExchangeRate21.Location = new System.Drawing.Point(770, 144);
            this.fld_txtARSaleOrderExchangeRate21.Name = "fld_txtARSaleOrderExchangeRate21";
            this.fld_txtARSaleOrderExchangeRate21.Screen = null;
            this.fld_txtARSaleOrderExchangeRate21.Size = new System.Drawing.Size(128, 20);
            this.fld_txtARSaleOrderExchangeRate21.TabIndex = 49;
            this.fld_txtARSaleOrderExchangeRate21.Tag = "DC";
            this.fld_txtARSaleOrderExchangeRate21.Validated += new System.EventHandler(this.fld_txtARSaleOrderExchangeRate21_Validated);
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = null;
            this.bosLabel33.BOSDataMember = null;
            this.bosLabel33.BOSDataSource = null;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = null;
            this.bosLabel33.BOSFieldRelation = null;
            this.bosLabel33.BOSPrivilege = null;
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(650, 146);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(38, 13);
            this.bosLabel33.TabIndex = 48;
            this.bosLabel33.Text = "Tỷ giá 2";
            // 
            // bosLabel93
            // 
            this.bosLabel93.BOSComment = null;
            this.bosLabel93.BOSDataMember = null;
            this.bosLabel93.BOSDataSource = null;
            this.bosLabel93.BOSDescription = null;
            this.bosLabel93.BOSError = null;
            this.bosLabel93.BOSFieldGroup = null;
            this.bosLabel93.BOSFieldRelation = null;
            this.bosLabel93.BOSPrivilege = null;
            this.bosLabel93.BOSPropertyName = null;
            this.bosLabel93.Location = new System.Drawing.Point(116, 18);
            this.bosLabel93.Name = "bosLabel93";
            this.bosLabel93.Screen = null;
            this.bosLabel93.Size = new System.Drawing.Size(78, 13);
            this.bosLabel93.TabIndex = 2;
            this.bosLabel93.Text = "P.I/Số bán hàng";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(650, 121);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(49, 13);
            this.bosLabel34.TabIndex = 40;
            this.bosLabel34.Text = "Loại tiền 2";
            // 
            // fld_lkeFK_GECurrencyID21
            // 
            this.fld_lkeFK_GECurrencyID21.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID21.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID21.BOSComment = null;
            this.fld_lkeFK_GECurrencyID21.BOSDataMember = "FK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID21.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_GECurrencyID21.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID21.BOSError = null;
            this.fld_lkeFK_GECurrencyID21.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID21.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID21.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID21.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID21.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID21.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID21.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID21.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID21.Location = new System.Drawing.Point(770, 118);
            this.fld_lkeFK_GECurrencyID21.Name = "fld_lkeFK_GECurrencyID21";
            this.fld_lkeFK_GECurrencyID21.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_GECurrencyID21.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID21.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID21.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID21.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID21.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID21.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID21.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID21.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID21.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID21.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID21.Screen = null;
            this.fld_lkeFK_GECurrencyID21.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_GECurrencyID21.TabIndex = 41;
            this.fld_lkeFK_GECurrencyID21.Tag = "DC";
            this.fld_lkeFK_GECurrencyID21.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID2_CloseUp);
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(650, 198);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel36, true);
            this.bosLabel36.Size = new System.Drawing.Size(77, 13);
            this.bosLabel36.TabIndex = 62;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Cảng Nhập POD";
            // 
            // fld_txtARSaleOrderPortOFDischarge
            // 
            this.fld_txtARSaleOrderPortOFDischarge.BOSComment = "";
            this.fld_txtARSaleOrderPortOFDischarge.BOSDataMember = "ARSaleOrderPortOFDischarge";
            this.fld_txtARSaleOrderPortOFDischarge.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderPortOFDischarge.BOSDescription = null;
            this.fld_txtARSaleOrderPortOFDischarge.BOSError = null;
            this.fld_txtARSaleOrderPortOFDischarge.BOSFieldGroup = "";
            this.fld_txtARSaleOrderPortOFDischarge.BOSFieldRelation = "";
            this.fld_txtARSaleOrderPortOFDischarge.BOSPrivilege = "";
            this.fld_txtARSaleOrderPortOFDischarge.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderPortOFDischarge.EditValue = "";
            this.fld_txtARSaleOrderPortOFDischarge.Location = new System.Drawing.Point(770, 195);
            this.fld_txtARSaleOrderPortOFDischarge.Name = "fld_txtARSaleOrderPortOFDischarge";
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderPortOFDischarge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderPortOFDischarge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderPortOFDischarge.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleOrderPortOFDischarge, true);
            this.fld_txtARSaleOrderPortOFDischarge.Size = new System.Drawing.Size(128, 20);
            this.fld_txtARSaleOrderPortOFDischarge.TabIndex = 63;
            this.fld_txtARSaleOrderPortOFDischarge.Tag = "DC";
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
            this.bosLabel23.Location = new System.Drawing.Point(650, 173);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(72, 13);
            this.bosLabel23.TabIndex = 56;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Cảng xuất POL";
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
            this.fld_lbWoodType.Location = new System.Drawing.Point(378, 252);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(19, 13);
            this.fld_lbWoodType.TabIndex = 70;
            this.fld_lbWoodType.Text = "FSC";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ARSaleOrders";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(476, 249);
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 71;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(650, 44);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(96, 13);
            this.bosLabel20.TabIndex = 15;
            this.bosLabel20.Text = "Hình thức giao hàng";
            // 
            // fld_lkeARShippingType
            // 
            this.fld_lkeARShippingType.BOSAllowAddNew = false;
            this.fld_lkeARShippingType.BOSAllowDummy = false;
            this.fld_lkeARShippingType.BOSComment = null;
            this.fld_lkeARShippingType.BOSDataMember = "ARShippingType";
            this.fld_lkeARShippingType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARShippingType.BOSDescription = null;
            this.fld_lkeARShippingType.BOSError = null;
            this.fld_lkeARShippingType.BOSFieldGroup = null;
            this.fld_lkeARShippingType.BOSFieldParent = null;
            this.fld_lkeARShippingType.BOSFieldRelation = null;
            this.fld_lkeARShippingType.BOSPrivilege = null;
            this.fld_lkeARShippingType.BOSPropertyName = "EditValue";
            this.fld_lkeARShippingType.BOSSelectType = null;
            this.fld_lkeARShippingType.BOSSelectTypeValue = null;
            this.fld_lkeARShippingType.CurrentDisplayText = null;
            this.fld_lkeARShippingType.Location = new System.Drawing.Point(770, 41);
            this.fld_lkeARShippingType.Name = "fld_lkeARShippingType";
            this.fld_lkeARShippingType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARShippingType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARShippingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARShippingType.Properties.ColumnName = null;
            this.fld_lkeARShippingType.Properties.NullText = "";
            this.fld_lkeARShippingType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARShippingType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARShippingType, true);
            this.fld_lkeARShippingType.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeARShippingType.TabIndex = 16;
            this.fld_lkeARShippingType.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ARSaleOrderPONo";
            this.bosTextBox3.BOSDataSource = "ARSaleOrders";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(476, 41);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 14;
            this.bosTextBox3.Tag = "DC";
            this.bosTextBox3.Validated += new System.EventHandler(this.bosTextBox3_Validated);
            // 
            // fld_lbPono
            // 
            this.fld_lbPono.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPono.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPono.Appearance.Options.UseBackColor = true;
            this.fld_lbPono.Appearance.Options.UseForeColor = true;
            this.fld_lbPono.BOSComment = null;
            this.fld_lbPono.BOSDataMember = null;
            this.fld_lbPono.BOSDataSource = null;
            this.fld_lbPono.BOSDescription = null;
            this.fld_lbPono.BOSError = null;
            this.fld_lbPono.BOSFieldGroup = null;
            this.fld_lbPono.BOSFieldRelation = null;
            this.fld_lbPono.BOSPrivilege = null;
            this.fld_lbPono.BOSPropertyName = null;
            this.fld_lbPono.Location = new System.Drawing.Point(378, 44);
            this.fld_lbPono.Name = "fld_lbPono";
            this.fld_lbPono.Screen = null;
            this.fld_lbPono.Size = new System.Drawing.Size(46, 13);
            this.fld_lbPono.TabIndex = 13;
            this.fld_lbPono.Text = "Số PO.No";
            // 
            // fld_txtARSaleOrderTotalProduct
            // 
            this.fld_txtARSaleOrderTotalProduct.BOSComment = null;
            this.fld_txtARSaleOrderTotalProduct.BOSDataMember = "ARSaleOrderTotalProduct";
            this.fld_txtARSaleOrderTotalProduct.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalProduct.BOSDescription = null;
            this.fld_txtARSaleOrderTotalProduct.BOSError = null;
            this.fld_txtARSaleOrderTotalProduct.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTotalProduct.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTotalProduct.BOSPrivilege = null;
            this.fld_txtARSaleOrderTotalProduct.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTotalProduct.Location = new System.Drawing.Point(476, 171);
            this.fld_txtARSaleOrderTotalProduct.Name = "fld_txtARSaleOrderTotalProduct";
            this.fld_txtARSaleOrderTotalProduct.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderTotalProduct.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalProduct.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalProduct.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalProduct.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTotalProduct.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalProduct.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleOrderTotalProduct, true);
            this.fld_txtARSaleOrderTotalProduct.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderTotalProduct.TabIndex = 55;
            this.fld_txtARSaleOrderTotalProduct.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(378, 174);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(60, 13);
            this.bosLabel11.TabIndex = 54;
            this.bosLabel11.Text = "SL sản phẩm";
            // 
            // fld_txtARSaleOrderContQty
            // 
            this.fld_txtARSaleOrderContQty.BOSComment = null;
            this.fld_txtARSaleOrderContQty.BOSDataMember = "ARSaleOrderContQty";
            this.fld_txtARSaleOrderContQty.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderContQty.BOSDescription = null;
            this.fld_txtARSaleOrderContQty.BOSError = null;
            this.fld_txtARSaleOrderContQty.BOSFieldGroup = null;
            this.fld_txtARSaleOrderContQty.BOSFieldRelation = null;
            this.fld_txtARSaleOrderContQty.BOSPrivilege = null;
            this.fld_txtARSaleOrderContQty.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderContQty.Location = new System.Drawing.Point(476, 145);
            this.fld_txtARSaleOrderContQty.Name = "fld_txtARSaleOrderContQty";
            this.fld_txtARSaleOrderContQty.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderContQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderContQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderContQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderContQty.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderContQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderContQty.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderContQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderContQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleOrderContQty, true);
            this.fld_txtARSaleOrderContQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderContQty.TabIndex = 47;
            this.fld_txtARSaleOrderContQty.Tag = "DC";
            // 
            // fld_lblContQty
            // 
            this.fld_lblContQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblContQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblContQty.Appearance.Options.UseBackColor = true;
            this.fld_lblContQty.Appearance.Options.UseForeColor = true;
            this.fld_lblContQty.BOSComment = null;
            this.fld_lblContQty.BOSDataMember = null;
            this.fld_lblContQty.BOSDataSource = null;
            this.fld_lblContQty.BOSDescription = null;
            this.fld_lblContQty.BOSError = null;
            this.fld_lblContQty.BOSFieldGroup = null;
            this.fld_lblContQty.BOSFieldRelation = null;
            this.fld_lblContQty.BOSPrivilege = null;
            this.fld_lblContQty.BOSPropertyName = null;
            this.fld_lblContQty.Location = new System.Drawing.Point(378, 147);
            this.fld_lblContQty.Name = "fld_lblContQty";
            this.fld_lblContQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblContQty, true);
            this.fld_lblContQty.Size = new System.Drawing.Size(68, 13);
            this.fld_lblContQty.TabIndex = 46;
            this.fld_lblContQty.Text = "Số lượng Cont";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(378, 122);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(94, 13);
            this.bosLabel8.TabIndex = 38;
            this.bosLabel8.Text = "Hình thức bán hàng";
            // 
            // fld_lkeARSaleOrderSaleType
            // 
            this.fld_lkeARSaleOrderSaleType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderSaleType.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderSaleType.BOSComment = null;
            this.fld_lkeARSaleOrderSaleType.BOSDataMember = "ARSaleOrderSaleType";
            this.fld_lkeARSaleOrderSaleType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderSaleType.BOSDescription = null;
            this.fld_lkeARSaleOrderSaleType.BOSError = null;
            this.fld_lkeARSaleOrderSaleType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderSaleType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderSaleType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderSaleType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderSaleType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderSaleType.BOSSelectType = null;
            this.fld_lkeARSaleOrderSaleType.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderSaleType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderSaleType.Location = new System.Drawing.Point(476, 119);
            this.fld_lkeARSaleOrderSaleType.Name = "fld_lkeARSaleOrderSaleType";
            this.fld_lkeARSaleOrderSaleType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderSaleType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderSaleType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderSaleType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderSaleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderSaleType.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderSaleType.Properties.NullText = "";
            this.fld_lkeARSaleOrderSaleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderSaleType.Screen = null;
            this.fld_lkeARSaleOrderSaleType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderSaleType.TabIndex = 39;
            this.fld_lkeARSaleOrderSaleType.Tag = "DC";
            this.fld_lkeARSaleOrderSaleType.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.Fld_lkeARSaleOrderSaleType_Closed);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel7.Location = new System.Drawing.Point(116, 147);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(67, 13);
            this.bosLabel7.TabIndex = 44;
            this.bosLabel7.Text = "Loại đơn hàng";
            // 
            // fld_lkeARSaleOrderType
            // 
            this.fld_lkeARSaleOrderType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderType.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderType.BOSComment = null;
            this.fld_lkeARSaleOrderType.BOSDataMember = "ARSaleOrderType";
            this.fld_lkeARSaleOrderType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderType.BOSDescription = null;
            this.fld_lkeARSaleOrderType.BOSError = null;
            this.fld_lkeARSaleOrderType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderType.BOSSelectType = null;
            this.fld_lkeARSaleOrderType.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderType.Location = new System.Drawing.Point(210, 145);
            this.fld_lkeARSaleOrderType.Name = "fld_lkeARSaleOrderType";
            this.fld_lkeARSaleOrderType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderType.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderType.Properties.NullText = "";
            this.fld_lkeARSaleOrderType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderType.Screen = null;
            this.fld_lkeARSaleOrderType.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeARSaleOrderType.TabIndex = 45;
            this.fld_lkeARSaleOrderType.Tag = "DC";
            // 
            // fld_bedFK_ARDiscountProgramID
            // 
            this.fld_bedFK_ARDiscountProgramID.BOSComment = null;
            this.fld_bedFK_ARDiscountProgramID.BOSDataMember = "ARDiscountProgramName";
            this.fld_bedFK_ARDiscountProgramID.BOSDataSource = "ARSaleOrders";
            this.fld_bedFK_ARDiscountProgramID.BOSDescription = null;
            this.fld_bedFK_ARDiscountProgramID.BOSError = null;
            this.fld_bedFK_ARDiscountProgramID.BOSFieldGroup = null;
            this.fld_bedFK_ARDiscountProgramID.BOSFieldRelation = null;
            this.fld_bedFK_ARDiscountProgramID.BOSPrivilege = null;
            this.fld_bedFK_ARDiscountProgramID.BOSPropertyName = "Text";
            this.fld_bedFK_ARDiscountProgramID.Location = new System.Drawing.Point(1026, 142);
            this.fld_bedFK_ARDiscountProgramID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ARDiscountProgramID.Name = "fld_bedFK_ARDiscountProgramID";
            this.fld_bedFK_ARDiscountProgramID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_bedFK_ARDiscountProgramID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_bedFK_ARDiscountProgramID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ARDiscountProgramID.Properties.ReadOnly = true;
            this.fld_bedFK_ARDiscountProgramID.Screen = null;
            this.fld_bedFK_ARDiscountProgramID.Size = new System.Drawing.Size(122, 20);
            this.fld_bedFK_ARDiscountProgramID.TabIndex = 51;
            this.fld_bedFK_ARDiscountProgramID.Tag = "DC";
            this.fld_bedFK_ARDiscountProgramID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ARDiscountProgramID_ButtonClick);
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(925, 145);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel28.TabIndex = 50;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "CTKM";
            // 
            // fld_bedARSalesman
            // 
            this.fld_bedARSalesman.BOSComment = null;
            this.fld_bedARSalesman.BOSDataMember = "";
            this.fld_bedARSalesman.BOSDataSource = "";
            this.fld_bedARSalesman.BOSDescription = null;
            this.fld_bedARSalesman.BOSError = null;
            this.fld_bedARSalesman.BOSFieldGroup = null;
            this.fld_bedARSalesman.BOSFieldRelation = null;
            this.fld_bedARSalesman.BOSPrivilege = null;
            this.fld_bedARSalesman.BOSPropertyName = "Text";
            this.fld_bedARSalesman.Location = new System.Drawing.Point(1026, 168);
            this.fld_bedARSalesman.MenuManager = this.screenToolbar;
            this.fld_bedARSalesman.Name = "fld_bedARSalesman";
            this.fld_bedARSalesman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedARSalesman.Properties.ReadOnly = true;
            this.fld_bedARSalesman.Screen = null;
            this.fld_bedARSalesman.Size = new System.Drawing.Size(122, 20);
            this.fld_bedARSalesman.TabIndex = 800;
            this.fld_bedARSalesman.Tag = "DC";
            this.fld_bedARSalesman.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bedARSalesman_ButtonClick);
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARSaleOrderTaxNumber";
            this.bosTextBox2.BOSDataSource = "ARSaleOrders";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(1026, 118);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(122, 20);
            this.bosTextBox2.TabIndex = 43;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(925, 120);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 42;
            this.bosLabel3.Text = "Mã số thuế";
            // 
            // bosLine4
            // 
            this.bosLine4.BackColor = System.Drawing.Color.Transparent;
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsContainerLoader);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ARDeliveryMethodID);
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsVehicleAllocation);
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsInvoiceAndShipment);
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsAcceptance);
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsDeliveryPlan);
            this.bosLine4.Controls.Add(this.fld_ckeARSaleOrderIsSaleOrderShipment);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(1161, 10);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine4, true);
            this.bosLine4.Size = new System.Drawing.Size(194, 261);
            this.bosLine4.TabIndex = 74;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Phương thức giao hàng";
            // 
            // fld_ckeARSaleOrderIsContainerLoader
            // 
            this.fld_ckeARSaleOrderIsContainerLoader.BOSComment = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSDataMember = "ARSaleOrderIsContainerLoader";
            this.fld_ckeARSaleOrderIsContainerLoader.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsContainerLoader.BOSDescription = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSError = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsContainerLoader.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsContainerLoader.Location = new System.Drawing.Point(89, 139);
            this.fld_ckeARSaleOrderIsContainerLoader.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsContainerLoader.Name = "fld_ckeARSaleOrderIsContainerLoader";
            this.fld_ckeARSaleOrderIsContainerLoader.Properties.Caption = "Load hàng";
            this.fld_ckeARSaleOrderIsContainerLoader.Screen = null;
            this.fld_ckeARSaleOrderIsContainerLoader.Size = new System.Drawing.Size(94, 20);
            this.fld_ckeARSaleOrderIsContainerLoader.TabIndex = 6;
            this.fld_ckeARSaleOrderIsContainerLoader.Tag = "DC";
            this.fld_ckeARSaleOrderIsContainerLoader.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsContainerLoader_CheckedChanged);
            // 
            // fld_lkeFK_ARDeliveryMethodID
            // 
            this.fld_lkeFK_ARDeliveryMethodID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARDeliveryMethodID.BOSAllowDummy = true;
            this.fld_lkeFK_ARDeliveryMethodID.BOSComment = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSDataMember = "FK_ARDeliveryMethodID";
            this.fld_lkeFK_ARDeliveryMethodID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARDeliveryMethodID.BOSDescription = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSError = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSFieldGroup = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSFieldParent = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSFieldRelation = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSPrivilege = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARDeliveryMethodID.BOSSelectType = null;
            this.fld_lkeFK_ARDeliveryMethodID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARDeliveryMethodID.CurrentDisplayText = null;
            this.fld_lkeFK_ARDeliveryMethodID.Location = new System.Drawing.Point(11, 16);
            this.fld_lkeFK_ARDeliveryMethodID.Name = "fld_lkeFK_ARDeliveryMethodID";
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARDeliveryMethodID.Properties.ColumnName = null;
            this.fld_lkeFK_ARDeliveryMethodID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryMethodName", "PT Giao hàng")});
            this.fld_lkeFK_ARDeliveryMethodID.Properties.DisplayMember = "ARDeliveryMethodName";
            this.fld_lkeFK_ARDeliveryMethodID.Properties.NullText = "";
            this.fld_lkeFK_ARDeliveryMethodID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARDeliveryMethodID.Properties.ValueMember = "ARDeliveryMethodID";
            this.fld_lkeFK_ARDeliveryMethodID.Screen = null;
            this.fld_lkeFK_ARDeliveryMethodID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_ARDeliveryMethodID.TabIndex = 0;
            this.fld_lkeFK_ARDeliveryMethodID.Tag = "DC";
            this.fld_lkeFK_ARDeliveryMethodID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARDeliveryMethodID_CloseUp);
            // 
            // fld_ckeARSaleOrderIsVehicleAllocation
            // 
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSComment = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSDataMember = "ARSaleOrderIsVehicleAllocation";
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSDescription = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSError = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsVehicleAllocation.Location = new System.Drawing.Point(9, 139);
            this.fld_ckeARSaleOrderIsVehicleAllocation.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsVehicleAllocation.Name = "fld_ckeARSaleOrderIsVehicleAllocation";
            this.fld_ckeARSaleOrderIsVehicleAllocation.Properties.Caption = "Điều xe";
            this.fld_ckeARSaleOrderIsVehicleAllocation.Screen = null;
            this.fld_ckeARSaleOrderIsVehicleAllocation.Size = new System.Drawing.Size(74, 20);
            this.fld_ckeARSaleOrderIsVehicleAllocation.TabIndex = 5;
            this.fld_ckeARSaleOrderIsVehicleAllocation.Tag = "DC";
            this.fld_ckeARSaleOrderIsVehicleAllocation.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsVehicleAllocation_CheckedChanged);
            // 
            // fld_ckeARSaleOrderIsInvoiceAndShipment
            // 
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSComment = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSDataMember = "ARSaleOrderIsInvoiceAndShipment";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSDescription = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSError = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Location = new System.Drawing.Point(9, 114);
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Name = "fld_ckeARSaleOrderIsInvoiceAndShipment";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Properties.Caption = "Hóa đơn kiêm phiếu xuất";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Screen = null;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Size = new System.Drawing.Size(148, 20);
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.TabIndex = 4;
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.Tag = "DC";
            this.fld_ckeARSaleOrderIsInvoiceAndShipment.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsInvoiceAndShipment_CheckedChanged);
            // 
            // fld_ckeARSaleOrderIsAcceptance
            // 
            this.fld_ckeARSaleOrderIsAcceptance.BOSComment = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSDataMember = "ARSaleOrderIsAcceptance";
            this.fld_ckeARSaleOrderIsAcceptance.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsAcceptance.BOSDescription = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSError = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsAcceptance.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsAcceptance.Location = new System.Drawing.Point(9, 89);
            this.fld_ckeARSaleOrderIsAcceptance.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsAcceptance.Name = "fld_ckeARSaleOrderIsAcceptance";
            this.fld_ckeARSaleOrderIsAcceptance.Properties.Caption = "Nghiệm thu bán hàng";
            this.fld_ckeARSaleOrderIsAcceptance.Screen = null;
            this.fld_ckeARSaleOrderIsAcceptance.Size = new System.Drawing.Size(136, 20);
            this.fld_ckeARSaleOrderIsAcceptance.TabIndex = 3;
            this.fld_ckeARSaleOrderIsAcceptance.Tag = "DC";
            this.fld_ckeARSaleOrderIsAcceptance.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsAcceptance_CheckedChanged);
            // 
            // fld_ckeARSaleOrderIsDeliveryPlan
            // 
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSComment = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDataMember = "ARSaleOrderIsDeliveryPlan";
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDescription = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSError = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Location = new System.Drawing.Point(9, 39);
            this.fld_ckeARSaleOrderIsDeliveryPlan.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Name = "fld_ckeARSaleOrderIsDeliveryPlan";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Properties.Caption = "Đề nghi xuất kho";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Screen = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Size = new System.Drawing.Size(136, 20);
            this.fld_ckeARSaleOrderIsDeliveryPlan.TabIndex = 1;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Tag = "DC";
            this.fld_ckeARSaleOrderIsDeliveryPlan.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsDeliveryPlan_CheckedChanged);
            // 
            // fld_ckeARSaleOrderIsSaleOrderShipment
            // 
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSComment = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSDataMember = "ARSaleOrderIsSaleOrderShipment";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSDataSource = "ARSaleOrders";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSDescription = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSError = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Location = new System.Drawing.Point(9, 64);
            this.fld_ckeARSaleOrderIsSaleOrderShipment.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Name = "fld_ckeARSaleOrderIsSaleOrderShipment";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Properties.Caption = "Xuất kho bán hàng";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Screen = null;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Size = new System.Drawing.Size(136, 20);
            this.fld_ckeARSaleOrderIsSaleOrderShipment.TabIndex = 2;
            this.fld_ckeARSaleOrderIsSaleOrderShipment.Tag = "DC";
            this.fld_ckeARSaleOrderIsSaleOrderShipment.CheckedChanged += new System.EventHandler(this.fld_ckeARSaleOrderIsSaleOrderShipment_CheckedChanged);
            // 
            // bosLookupEdit9
            // 
            this.bosLookupEdit9.BOSAllowAddNew = false;
            this.bosLookupEdit9.BOSAllowDummy = false;
            this.bosLookupEdit9.BOSComment = "";
            this.bosLookupEdit9.BOSDataMember = "ARSaleOrderBatchStatus";
            this.bosLookupEdit9.BOSDataSource = "ARSaleOrders";
            this.bosLookupEdit9.BOSDescription = null;
            this.bosLookupEdit9.BOSError = null;
            this.bosLookupEdit9.BOSFieldGroup = "";
            this.bosLookupEdit9.BOSFieldParent = "";
            this.bosLookupEdit9.BOSFieldRelation = "";
            this.bosLookupEdit9.BOSPrivilege = "";
            this.bosLookupEdit9.BOSPropertyName = "EditValue";
            this.bosLookupEdit9.BOSSelectType = "";
            this.bosLookupEdit9.BOSSelectTypeValue = "";
            this.bosLookupEdit9.CurrentDisplayText = "";
            this.bosLookupEdit9.Location = new System.Drawing.Point(1026, 92);
            this.bosLookupEdit9.Name = "bosLookupEdit9";
            this.bosLookupEdit9.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bosLookupEdit9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit9.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit9.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit9.Properties.ColumnName = null;
            this.bosLookupEdit9.Properties.NullText = "";
            this.bosLookupEdit9.Properties.ReadOnly = true;
            this.bosLookupEdit9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit9, true);
            this.bosLookupEdit9.Size = new System.Drawing.Size(122, 20);
            this.bosLookupEdit9.TabIndex = 34;
            this.bosLookupEdit9.Tag = "DC";
            // 
            // bosLabel84
            // 
            this.bosLabel84.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel84.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel84.Appearance.Options.UseBackColor = true;
            this.bosLabel84.Appearance.Options.UseForeColor = true;
            this.bosLabel84.BOSComment = "";
            this.bosLabel84.BOSDataMember = "";
            this.bosLabel84.BOSDataSource = "";
            this.bosLabel84.BOSDescription = null;
            this.bosLabel84.BOSError = null;
            this.bosLabel84.BOSFieldGroup = "";
            this.bosLabel84.BOSFieldRelation = "";
            this.bosLabel84.BOSPrivilege = "";
            this.bosLabel84.BOSPropertyName = null;
            this.bosLabel84.Location = new System.Drawing.Point(925, 95);
            this.bosLabel84.Name = "bosLabel84";
            this.bosLabel84.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel84, true);
            this.bosLabel84.Size = new System.Drawing.Size(64, 13);
            this.bosLabel84.TabIndex = 33;
            this.bosLabel84.Tag = "";
            this.bosLabel84.Text = "Tình trạng SX";
            // 
            // bosLookupEdit10
            // 
            this.bosLookupEdit10.BOSAllowAddNew = false;
            this.bosLookupEdit10.BOSAllowDummy = false;
            this.bosLookupEdit10.BOSComment = null;
            this.bosLookupEdit10.BOSDataMember = "ARSaleOrderStatus";
            this.bosLookupEdit10.BOSDataSource = "ARSaleOrders";
            this.bosLookupEdit10.BOSDescription = null;
            this.bosLookupEdit10.BOSError = null;
            this.bosLookupEdit10.BOSFieldGroup = null;
            this.bosLookupEdit10.BOSFieldParent = null;
            this.bosLookupEdit10.BOSFieldRelation = null;
            this.bosLookupEdit10.BOSPrivilege = null;
            this.bosLookupEdit10.BOSPropertyName = "EditValue";
            this.bosLookupEdit10.BOSSelectType = null;
            this.bosLookupEdit10.BOSSelectTypeValue = null;
            this.bosLookupEdit10.CurrentDisplayText = null;
            this.bosLookupEdit10.Location = new System.Drawing.Point(1026, 67);
            this.bosLookupEdit10.MenuManager = this.screenToolbar;
            this.bosLookupEdit10.Name = "bosLookupEdit10";
            this.bosLookupEdit10.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bosLookupEdit10.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit10.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit10.Properties.ColumnName = null;
            this.bosLookupEdit10.Properties.NullText = "";
            this.bosLookupEdit10.Properties.ReadOnly = true;
            this.bosLookupEdit10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit10.Screen = null;
            this.bosLookupEdit10.Size = new System.Drawing.Size(122, 20);
            this.bosLookupEdit10.TabIndex = 26;
            this.bosLookupEdit10.Tag = "DC";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = null;
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = null;
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = null;
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(210, 93);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên")});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 28;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            // 
            // bosLabel85
            // 
            this.bosLabel85.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.Options.UseBackColor = true;
            this.bosLabel85.Appearance.Options.UseForeColor = true;
            this.bosLabel85.BOSComment = null;
            this.bosLabel85.BOSDataMember = null;
            this.bosLabel85.BOSDataSource = null;
            this.bosLabel85.BOSDescription = null;
            this.bosLabel85.BOSError = null;
            this.bosLabel85.BOSFieldGroup = null;
            this.bosLabel85.BOSFieldRelation = null;
            this.bosLabel85.BOSPrivilege = null;
            this.bosLabel85.BOSPropertyName = null;
            this.bosLabel85.Location = new System.Drawing.Point(650, 250);
            this.bosLabel85.Name = "bosLabel85";
            this.bosLabel85.Screen = null;
            this.bosLabel85.Size = new System.Drawing.Size(60, 13);
            this.bosLabel85.TabIndex = 72;
            this.bosLabel85.Text = "Số hợp đồng";
            // 
            // bosLabel88
            // 
            this.bosLabel88.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel88.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel88.Appearance.Options.UseBackColor = true;
            this.bosLabel88.Appearance.Options.UseForeColor = true;
            this.bosLabel88.BOSComment = null;
            this.bosLabel88.BOSDataMember = "";
            this.bosLabel88.BOSDataSource = "";
            this.bosLabel88.BOSDescription = null;
            this.bosLabel88.BOSError = null;
            this.bosLabel88.BOSFieldGroup = "";
            this.bosLabel88.BOSFieldRelation = null;
            this.bosLabel88.BOSPrivilege = null;
            this.bosLabel88.BOSPropertyName = null;
            this.bosLabel88.Location = new System.Drawing.Point(116, 96);
            this.bosLabel88.Name = "bosLabel88";
            this.bosLabel88.Screen = null;
            this.bosLabel88.Size = new System.Drawing.Size(52, 13);
            this.bosLabel88.TabIndex = 27;
            this.bosLabel88.Text = "Ngân hàng";
            // 
            // bosLabel97
            // 
            this.bosLabel97.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel97.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel97.Appearance.Options.UseBackColor = true;
            this.bosLabel97.Appearance.Options.UseForeColor = true;
            this.bosLabel97.BOSComment = null;
            this.bosLabel97.BOSDataMember = null;
            this.bosLabel97.BOSDataSource = null;
            this.bosLabel97.BOSDescription = null;
            this.bosLabel97.BOSError = null;
            this.bosLabel97.BOSFieldGroup = null;
            this.bosLabel97.BOSFieldRelation = null;
            this.bosLabel97.BOSPrivilege = null;
            this.bosLabel97.BOSPropertyName = null;
            this.bosLabel97.Location = new System.Drawing.Point(925, 70);
            this.bosLabel97.Name = "bosLabel97";
            this.bosLabel97.Screen = null;
            this.bosLabel97.Size = new System.Drawing.Size(96, 13);
            this.bosLabel97.TabIndex = 25;
            this.bosLabel97.Text = "Tình trạng chứng từ";
            // 
            // fld_txtARSaleOrderExchangeRate
            // 
            this.fld_txtARSaleOrderExchangeRate.BOSComment = null;
            this.fld_txtARSaleOrderExchangeRate.BOSDataMember = "ARSaleOrderExchangeRate";
            this.fld_txtARSaleOrderExchangeRate.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderExchangeRate.BOSDescription = null;
            this.fld_txtARSaleOrderExchangeRate.BOSError = null;
            this.fld_txtARSaleOrderExchangeRate.BOSFieldGroup = null;
            this.fld_txtARSaleOrderExchangeRate.BOSFieldRelation = null;
            this.fld_txtARSaleOrderExchangeRate.BOSPrivilege = null;
            this.fld_txtARSaleOrderExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderExchangeRate.Location = new System.Drawing.Point(770, 92);
            this.fld_txtARSaleOrderExchangeRate.Name = "fld_txtARSaleOrderExchangeRate";
            this.fld_txtARSaleOrderExchangeRate.Screen = null;
            this.fld_txtARSaleOrderExchangeRate.Size = new System.Drawing.Size(128, 20);
            this.fld_txtARSaleOrderExchangeRate.TabIndex = 32;
            this.fld_txtARSaleOrderExchangeRate.Tag = "DC";
            this.fld_txtARSaleOrderExchangeRate.Validated += new System.EventHandler(this.Fld_txtARSaleOrderExchangeRate_Validated_1);
            // 
            // bosLabel89
            // 
            this.bosLabel89.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel89.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel89.Appearance.Options.UseBackColor = true;
            this.bosLabel89.Appearance.Options.UseForeColor = true;
            this.bosLabel89.BOSComment = null;
            this.bosLabel89.BOSDataMember = null;
            this.bosLabel89.BOSDataSource = null;
            this.bosLabel89.BOSDescription = null;
            this.bosLabel89.BOSError = null;
            this.bosLabel89.BOSFieldGroup = null;
            this.bosLabel89.BOSFieldRelation = null;
            this.bosLabel89.BOSPrivilege = null;
            this.bosLabel89.BOSPropertyName = null;
            this.bosLabel89.Location = new System.Drawing.Point(650, 95);
            this.bosLabel89.Name = "bosLabel89";
            this.bosLabel89.Screen = null;
            this.bosLabel89.Size = new System.Drawing.Size(29, 13);
            this.bosLabel89.TabIndex = 31;
            this.bosLabel89.Text = "Tỷ giá";
            // 
            // bosLabel90
            // 
            this.bosLabel90.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel90.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel90.Appearance.Options.UseBackColor = true;
            this.bosLabel90.Appearance.Options.UseForeColor = true;
            this.bosLabel90.BOSComment = null;
            this.bosLabel90.BOSDataMember = null;
            this.bosLabel90.BOSDataSource = null;
            this.bosLabel90.BOSDescription = null;
            this.bosLabel90.BOSError = null;
            this.bosLabel90.BOSFieldGroup = null;
            this.bosLabel90.BOSFieldRelation = null;
            this.bosLabel90.BOSPrivilege = null;
            this.bosLabel90.BOSPropertyName = null;
            this.bosLabel90.Location = new System.Drawing.Point(650, 70);
            this.bosLabel90.Name = "bosLabel90";
            this.bosLabel90.Screen = null;
            this.bosLabel90.Size = new System.Drawing.Size(53, 13);
            this.bosLabel90.TabIndex = 23;
            this.bosLabel90.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(770, 67);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 24;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_dteARSaleOrderDeliveryDate
            // 
            this.fld_dteARSaleOrderDeliveryDate.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSDataMember = "ARSaleOrderDeliveryDate";
            this.fld_dteARSaleOrderDeliveryDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteARSaleOrderDeliveryDate.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDate.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDate.Location = new System.Drawing.Point(770, 15);
            this.fld_dteARSaleOrderDeliveryDate.Name = "fld_dteARSaleOrderDeliveryDate";
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.fld_dteARSaleOrderDeliveryDate.Screen = null;
            this.fld_dteARSaleOrderDeliveryDate.Size = new System.Drawing.Size(128, 20);
            this.fld_dteARSaleOrderDeliveryDate.TabIndex = 7;
            this.fld_dteARSaleOrderDeliveryDate.Tag = "DC";
            this.fld_dteARSaleOrderDeliveryDate.Validated += new System.EventHandler(this.fld_dteARSaleOrderDeliveryDate_Validated);
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = false;
            this.bosLookupEdit4.BOSComment = null;
            this.bosLookupEdit4.BOSDataMember = "FK_ARSellerID";
            this.bosLookupEdit4.BOSDataSource = "ARSaleOrders";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = null;
            this.bosLookupEdit4.BOSFieldParent = null;
            this.bosLookupEdit4.BOSFieldRelation = null;
            this.bosLookupEdit4.BOSPrivilege = null;
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = null;
            this.bosLookupEdit4.BOSSelectTypeValue = null;
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(476, 93);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.bosLookupEdit4.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit4.Properties.NullText = "";
            this.bosLookupEdit4.Properties.PopupWidth = 40;
            this.bosLookupEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit4.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit4.TabIndex = 30;
            this.bosLookupEdit4.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARSaleOrderProspectCustomer";
            this.bosTextBox1.BOSDataSource = "ARSaleOrders";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(210, 67);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(155, 20);
            this.bosTextBox1.TabIndex = 20;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lnkChooseProspectCustomer
            // 
            this.fld_lnkChooseProspectCustomer.EditValue = "Chọn KH tiềm năng";
            this.fld_lnkChooseProspectCustomer.Location = new System.Drawing.Point(114, 68);
            this.fld_lnkChooseProspectCustomer.Name = "fld_lnkChooseProspectCustomer";
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkChooseProspectCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkChooseProspectCustomer.Size = new System.Drawing.Size(100, 18);
            this.fld_lnkChooseProspectCustomer.TabIndex = 19;
            this.fld_lnkChooseProspectCustomer.TabStop = false;
            // 
            // bosLabel58
            // 
            this.bosLabel58.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel58.Appearance.Options.UseForeColor = true;
            this.bosLabel58.BOSComment = null;
            this.bosLabel58.BOSDataMember = null;
            this.bosLabel58.BOSDataSource = null;
            this.bosLabel58.BOSDescription = null;
            this.bosLabel58.BOSError = null;
            this.bosLabel58.BOSFieldGroup = null;
            this.bosLabel58.BOSFieldRelation = null;
            this.bosLabel58.BOSPrivilege = null;
            this.bosLabel58.BOSPropertyName = null;
            this.bosLabel58.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel58.Location = new System.Drawing.Point(326, 42);
            this.bosLabel58.Name = "bosLabel58";
            this.bosLabel58.Screen = null;
            this.bosLabel58.Size = new System.Drawing.Size(6, 13);
            this.bosLabel58.TabIndex = 12;
            this.bosLabel58.Text = "*";
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
            this.bosButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bosButton2.ImageOptions.Image")));
            this.bosButton2.Location = new System.Drawing.Point(335, 39);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton2, true);
            this.bosButton2.Size = new System.Drawing.Size(30, 24);
            this.bosButton2.TabIndex = 781;
            this.bosButton2.Click += new System.EventHandler(this.fld_btnAddCustomers_Click);
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
            this.bosLabel60.Location = new System.Drawing.Point(116, 44);
            this.bosLabel60.Name = "bosLabel60";
            this.bosLabel60.Screen = null;
            this.bosLabel60.Size = new System.Drawing.Size(56, 13);
            this.bosLabel60.TabIndex = 10;
            this.bosLabel60.Tag = "";
            this.bosLabel60.Text = "Khách hàng";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARSaleOrders";
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
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(210, 41);
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
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(113, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 11;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            this.fld_lkeACObjectAccessKey.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLabel61
            // 
            this.bosLabel61.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel61.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel61.Appearance.Options.UseBackColor = true;
            this.bosLabel61.Appearance.Options.UseForeColor = true;
            this.bosLabel61.BOSComment = null;
            this.bosLabel61.BOSDataMember = null;
            this.bosLabel61.BOSDataSource = null;
            this.bosLabel61.BOSDescription = null;
            this.bosLabel61.BOSError = null;
            this.bosLabel61.BOSFieldGroup = null;
            this.bosLabel61.BOSFieldRelation = null;
            this.bosLabel61.BOSPrivilege = null;
            this.bosLabel61.BOSPropertyName = null;
            this.bosLabel61.Location = new System.Drawing.Point(925, 171);
            this.bosLabel61.Name = "bosLabel61";
            this.bosLabel61.Screen = null;
            this.bosLabel61.Size = new System.Drawing.Size(70, 13);
            this.bosLabel61.TabIndex = 788;
            this.bosLabel61.Text = "Người bán phụ";
            // 
            // bosLabel62
            // 
            this.bosLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.Options.UseBackColor = true;
            this.bosLabel62.Appearance.Options.UseForeColor = true;
            this.bosLabel62.BOSComment = null;
            this.bosLabel62.BOSDataMember = null;
            this.bosLabel62.BOSDataSource = null;
            this.bosLabel62.BOSDescription = null;
            this.bosLabel62.BOSError = null;
            this.bosLabel62.BOSFieldGroup = null;
            this.bosLabel62.BOSFieldRelation = null;
            this.bosLabel62.BOSPrivilege = null;
            this.bosLabel62.BOSPropertyName = null;
            this.bosLabel62.Location = new System.Drawing.Point(116, 122);
            this.bosLabel62.Name = "bosLabel62";
            this.bosLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel62, true);
            this.bosLabel62.Size = new System.Drawing.Size(67, 13);
            this.bosLabel62.TabIndex = 35;
            this.bosLabel62.Text = "Loại hàng hóa";
            // 
            // fld_lkeSaleOrderProductType
            // 
            this.fld_lkeSaleOrderProductType.BOSAllowAddNew = false;
            this.fld_lkeSaleOrderProductType.BOSAllowDummy = false;
            this.fld_lkeSaleOrderProductType.BOSComment = null;
            this.fld_lkeSaleOrderProductType.BOSDataMember = "ARSaleOrderProductType";
            this.fld_lkeSaleOrderProductType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeSaleOrderProductType.BOSDescription = null;
            this.fld_lkeSaleOrderProductType.BOSError = null;
            this.fld_lkeSaleOrderProductType.BOSFieldGroup = null;
            this.fld_lkeSaleOrderProductType.BOSFieldParent = null;
            this.fld_lkeSaleOrderProductType.BOSFieldRelation = null;
            this.fld_lkeSaleOrderProductType.BOSPrivilege = null;
            this.fld_lkeSaleOrderProductType.BOSPropertyName = "EditValue";
            this.fld_lkeSaleOrderProductType.BOSSelectType = "";
            this.fld_lkeSaleOrderProductType.BOSSelectTypeValue = "";
            this.fld_lkeSaleOrderProductType.CurrentDisplayText = null;
            this.fld_lkeSaleOrderProductType.Location = new System.Drawing.Point(210, 119);
            this.fld_lkeSaleOrderProductType.Name = "fld_lkeSaleOrderProductType";
            this.fld_lkeSaleOrderProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSaleOrderProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSaleOrderProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSaleOrderProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSaleOrderProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSaleOrderProductType.Properties.ColumnName = null;
            this.fld_lkeSaleOrderProductType.Properties.NullText = "";
            this.fld_lkeSaleOrderProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSaleOrderProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeSaleOrderProductType, true);
            this.fld_lkeSaleOrderProductType.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeSaleOrderProductType.TabIndex = 36;
            this.fld_lkeSaleOrderProductType.Tag = "DC";
            this.fld_lkeSaleOrderProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeSaleOrderProductType_CloseUp);
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = false;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_GEPaymentTermID.BOSDescription = null;
            this.fld_lkeFK_GEPaymentTermID.BOSError = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldGroup = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldParent = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldRelation = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPrivilege = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectType = null;
            this.fld_lkeFK_GEPaymentTermID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEPaymentTermID.CurrentDisplayText = null;
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(1026, 41);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", "Điều khoản thanh toán", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = "";
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(122, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 18;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            this.fld_lkeFK_GEPaymentTermID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEPaymentTermID_CloseUp);
            // 
            // bosLabel86
            // 
            this.bosLabel86.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel86.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel86.Appearance.Options.UseBackColor = true;
            this.bosLabel86.Appearance.Options.UseForeColor = true;
            this.bosLabel86.BOSComment = "";
            this.bosLabel86.BOSDataMember = "";
            this.bosLabel86.BOSDataSource = "";
            this.bosLabel86.BOSDescription = null;
            this.bosLabel86.BOSError = null;
            this.bosLabel86.BOSFieldGroup = "";
            this.bosLabel86.BOSFieldRelation = "";
            this.bosLabel86.BOSPrivilege = "";
            this.bosLabel86.BOSPropertyName = null;
            this.bosLabel86.Location = new System.Drawing.Point(925, 44);
            this.bosLabel86.Name = "bosLabel86";
            this.bosLabel86.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel86, true);
            this.bosLabel86.Size = new System.Drawing.Size(69, 13);
            this.bosLabel86.TabIndex = 17;
            this.bosLabel86.Tag = "";
            this.bosLabel86.Text = "Điều khoản TT";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "ARSaleOrderDesc";
            this.bosMemoEdit1.BOSDataSource = "ARSaleOrders";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(210, 224);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosMemoEdit1, true);
            this.bosMemoEdit1.Size = new System.Drawing.Size(155, 42);
            this.bosMemoEdit1.TabIndex = 65;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosLabel87
            // 
            this.bosLabel87.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel87.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel87.Appearance.Options.UseBackColor = true;
            this.bosLabel87.Appearance.Options.UseForeColor = true;
            this.bosLabel87.BOSComment = "";
            this.bosLabel87.BOSDataMember = "";
            this.bosLabel87.BOSDataSource = "";
            this.bosLabel87.BOSDescription = null;
            this.bosLabel87.BOSError = null;
            this.bosLabel87.BOSFieldGroup = "";
            this.bosLabel87.BOSFieldRelation = "";
            this.bosLabel87.BOSPrivilege = "";
            this.bosLabel87.BOSPropertyName = null;
            this.bosLabel87.Location = new System.Drawing.Point(116, 226);
            this.bosLabel87.Name = "bosLabel87";
            this.bosLabel87.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel87, true);
            this.bosLabel87.Size = new System.Drawing.Size(71, 13);
            this.bosLabel87.TabIndex = 64;
            this.bosLabel87.Tag = "";
            this.bosLabel87.Text = "Đặc điểm riêng";
            // 
            // bosTextBox20
            // 
            this.bosTextBox20.BOSComment = null;
            this.bosTextBox20.BOSDataMember = "ARSaleOrderNo";
            this.bosTextBox20.BOSDataSource = "ARSaleOrders";
            this.bosTextBox20.BOSDescription = null;
            this.bosTextBox20.BOSError = null;
            this.bosTextBox20.BOSFieldGroup = null;
            this.bosTextBox20.BOSFieldRelation = null;
            this.bosTextBox20.BOSPrivilege = null;
            this.bosTextBox20.BOSPropertyName = "EditValue";
            this.bosTextBox20.Location = new System.Drawing.Point(210, 15);
            this.bosTextBox20.MenuManager = this.screenToolbar;
            this.bosTextBox20.Name = "bosTextBox20";
            this.bosTextBox20.Screen = null;
            this.bosTextBox20.Size = new System.Drawing.Size(155, 20);
            this.bosTextBox20.TabIndex = 3;
            this.bosTextBox20.Tag = "DC";
            // 
            // bosLabel91
            // 
            this.bosLabel91.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel91.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel91.Appearance.Options.UseBackColor = true;
            this.bosLabel91.Appearance.Options.UseForeColor = true;
            this.bosLabel91.BOSComment = null;
            this.bosLabel91.BOSDataMember = null;
            this.bosLabel91.BOSDataSource = null;
            this.bosLabel91.BOSDescription = null;
            this.bosLabel91.BOSError = null;
            this.bosLabel91.BOSFieldGroup = null;
            this.bosLabel91.BOSFieldRelation = null;
            this.bosLabel91.BOSPrivilege = null;
            this.bosLabel91.BOSPropertyName = null;
            this.bosLabel91.Location = new System.Drawing.Point(378, 96);
            this.bosLabel91.Name = "bosLabel91";
            this.bosLabel91.Screen = null;
            this.bosLabel91.Size = new System.Drawing.Size(61, 13);
            this.bosLabel91.TabIndex = 29;
            this.bosLabel91.Text = "NV bán hàng";
            // 
            // bosTextBox21
            // 
            this.bosTextBox21.BOSComment = null;
            this.bosTextBox21.BOSDataMember = "ARSaleOrderSOContactName";
            this.bosTextBox21.BOSDataSource = "ARSaleOrders";
            this.bosTextBox21.BOSDescription = null;
            this.bosTextBox21.BOSError = null;
            this.bosTextBox21.BOSFieldGroup = null;
            this.bosTextBox21.BOSFieldRelation = null;
            this.bosTextBox21.BOSPrivilege = null;
            this.bosTextBox21.BOSPropertyName = "EditValue";
            this.bosTextBox21.Location = new System.Drawing.Point(476, 67);
            this.bosTextBox21.Name = "bosTextBox21";
            this.bosTextBox21.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox21.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox21.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox21.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox21.Properties.Mask.EditMask = "n";
            this.bosTextBox21.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox21.Screen = null;
            this.bosTextBox21.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox21.TabIndex = 22;
            this.bosTextBox21.Tag = "DC";
            // 
            // bosLabel92
            // 
            this.bosLabel92.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel92.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel92.Appearance.Options.UseBackColor = true;
            this.bosLabel92.Appearance.Options.UseForeColor = true;
            this.bosLabel92.BOSComment = null;
            this.bosLabel92.BOSDataMember = null;
            this.bosLabel92.BOSDataSource = null;
            this.bosLabel92.BOSDescription = null;
            this.bosLabel92.BOSError = null;
            this.bosLabel92.BOSFieldGroup = null;
            this.bosLabel92.BOSFieldRelation = null;
            this.bosLabel92.BOSPrivilege = null;
            this.bosLabel92.BOSPropertyName = null;
            this.bosLabel92.Location = new System.Drawing.Point(378, 70);
            this.bosLabel92.Name = "bosLabel92";
            this.bosLabel92.Screen = null;
            this.bosLabel92.Size = new System.Drawing.Size(33, 13);
            this.bosLabel92.TabIndex = 21;
            this.bosLabel92.Text = "Mô giới";
            // 
            // bosLabel94
            // 
            this.bosLabel94.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel94.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel94.Appearance.Options.UseBackColor = true;
            this.bosLabel94.Appearance.Options.UseForeColor = true;
            this.bosLabel94.BOSComment = null;
            this.bosLabel94.BOSDataMember = null;
            this.bosLabel94.BOSDataSource = null;
            this.bosLabel94.BOSDescription = null;
            this.bosLabel94.BOSError = null;
            this.bosLabel94.BOSFieldGroup = null;
            this.bosLabel94.BOSFieldRelation = null;
            this.bosLabel94.BOSPrivilege = null;
            this.bosLabel94.BOSPropertyName = null;
            this.bosLabel94.Location = new System.Drawing.Point(925, 19);
            this.bosLabel94.Name = "bosLabel94";
            this.bosLabel94.Screen = null;
            this.bosLabel94.Size = new System.Drawing.Size(77, 13);
            this.bosLabel94.TabIndex = 8;
            this.bosLabel94.Text = "Phương thức TT";
            // 
            // fld_lkeARPaymentMethodCombo
            // 
            this.fld_lkeARPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeARPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeARPaymentMethodCombo.BOSComment = null;
            this.fld_lkeARPaymentMethodCombo.BOSDataMember = "ARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeARPaymentMethodCombo.BOSError = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldGroup = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldParent = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldRelation = null;
            this.fld_lkeARPaymentMethodCombo.BOSPrivilege = null;
            this.fld_lkeARPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARPaymentMethodCombo.BOSSelectType = null;
            this.fld_lkeARPaymentMethodCombo.BOSSelectTypeValue = null;
            this.fld_lkeARPaymentMethodCombo.CurrentDisplayText = null;
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(1026, 15);
            this.fld_lkeARPaymentMethodCombo.Name = "fld_lkeARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeARPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeARPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARPaymentMethodCombo.Screen = null;
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(122, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 9;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            this.fld_lkeARPaymentMethodCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeARPaymentMethodCombo_CloseUp);
            // 
            // bosDateEdit4
            // 
            this.bosDateEdit4.BOSComment = null;
            this.bosDateEdit4.BOSDataMember = "ARSaleOrderDate";
            this.bosDateEdit4.BOSDataSource = "ARSaleOrders";
            this.bosDateEdit4.BOSDescription = null;
            this.bosDateEdit4.BOSError = null;
            this.bosDateEdit4.BOSFieldGroup = null;
            this.bosDateEdit4.BOSFieldRelation = null;
            this.bosDateEdit4.BOSPrivilege = null;
            this.bosDateEdit4.BOSPropertyName = "EditValue";
            this.bosDateEdit4.EditValue = null;
            this.bosDateEdit4.Location = new System.Drawing.Point(476, 15);
            this.bosDateEdit4.Name = "bosDateEdit4";
            this.bosDateEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit4.Screen = null;
            this.bosDateEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit4.TabIndex = 5;
            this.bosDateEdit4.Tag = "DC";
            this.bosDateEdit4.Validated += new System.EventHandler(this.fld_dteARSaleOrderDate_Validated);
            // 
            // fld_pteARSaleOrderEmployeePicture
            // 
            this.fld_pteARSaleOrderEmployeePicture.BOSComment = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSDataMember = "ARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataSource = "ARSaleOrders";
            this.fld_pteARSaleOrderEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSError = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleOrderEmployeePicture.FileName = null;
            this.fld_pteARSaleOrderEmployeePicture.FilePath = null;
            this.fld_pteARSaleOrderEmployeePicture.Location = new System.Drawing.Point(1, 10);
            this.fld_pteARSaleOrderEmployeePicture.Name = "fld_pteARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARSaleOrderEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderEmployeePicture.Screen = null;
            this.fld_pteARSaleOrderEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARSaleOrderEmployeePicture.TabIndex = 0;
            this.fld_pteARSaleOrderEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(1, 112);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_lblLabel18);
            this.bosLine3.Controls.Add(this.fld_lblLabel44);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderSubTotalAmount);
            this.bosLine3.Controls.Add(this.flt_txtARSaleOrderPriceCostTotalAmount);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderTotalCost);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderDiscountFix);
            this.bosLine3.Controls.Add(this.fld_lblLabel46);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderDiscountPerCent);
            this.bosLine3.Controls.Add(this.bosLabel35);
            this.bosLine3.Controls.Add(this.bosLabel16);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderTotalDiscountFix);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderSOCommissionAmount);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderTaxAmount);
            this.bosLine3.Controls.Add(this.bosLabel2);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderCustomerCommissionPercent);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderTaxPercent);
            this.bosLine3.Controls.Add(this.bosLabel9);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderTotalAmount);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderDepositBalance);
            this.bosLine3.Controls.Add(this.BOSLabel4);
            this.bosLine3.Controls.Add(this.fld_lblLabel47);
            this.bosLine3.Controls.Add(this.fld_txtARSaleOrderBalanceDue);
            this.bosLine3.Controls.Add(this.BOSLabel5);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(1062, 661);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(361, 269);
            this.bosLine3.TabIndex = 33;
            this.bosLine3.TabStop = false;
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = null;
            this.fld_lblLabel18.BOSDataMember = null;
            this.fld_lblLabel18.BOSDataSource = null;
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = null;
            this.fld_lblLabel18.BOSFieldRelation = null;
            this.fld_lblLabel18.BOSPrivilege = null;
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(89, 18);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel18.TabIndex = 565;
            this.fld_lblLabel18.Text = "Tổng trước CK";
            // 
            // flt_txtARSaleOrderPriceCostTotalAmount
            // 
            this.flt_txtARSaleOrderPriceCostTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSComment = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSDataMember = "ARSaleOrderPriceCostTotalAmount";
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSDataSource = "ARSaleOrders";
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSDescription = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSError = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSFieldGroup = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSFieldRelation = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSPrivilege = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.BOSPropertyName = "EditValue";
            this.flt_txtARSaleOrderPriceCostTotalAmount.EditValue = "0.00";
            this.flt_txtARSaleOrderPriceCostTotalAmount.Location = new System.Drawing.Point(175, 14);
            this.flt_txtARSaleOrderPriceCostTotalAmount.Name = "flt_txtARSaleOrderPriceCostTotalAmount";
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Mask.EditMask = "n";
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Properties.ReadOnly = true;
            this.flt_txtARSaleOrderPriceCostTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Screen = null;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Size = new System.Drawing.Size(177, 20);
            this.flt_txtARSaleOrderPriceCostTotalAmount.TabIndex = 1;
            this.flt_txtARSaleOrderPriceCostTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleOrderTotalCost
            // 
            this.fld_txtARSaleOrderTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderTotalCost.BOSComment = null;
            this.fld_txtARSaleOrderTotalCost.BOSDataMember = "ARSaleOrderTotalCost";
            this.fld_txtARSaleOrderTotalCost.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalCost.BOSDescription = null;
            this.fld_txtARSaleOrderTotalCost.BOSError = null;
            this.fld_txtARSaleOrderTotalCost.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTotalCost.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTotalCost.BOSPrivilege = null;
            this.fld_txtARSaleOrderTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTotalCost.EditValue = "0.00";
            this.fld_txtARSaleOrderTotalCost.Location = new System.Drawing.Point(175, 64);
            this.fld_txtARSaleOrderTotalCost.Name = "fld_txtARSaleOrderTotalCost";
            this.fld_txtARSaleOrderTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalCost.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalCost.Screen = null;
            this.fld_txtARSaleOrderTotalCost.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARSaleOrderTotalCost.TabIndex = 3;
            this.fld_txtARSaleOrderTotalCost.Tag = "DC";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(126, 67);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(33, 13);
            this.bosLabel35.TabIndex = 554;
            this.bosLabel35.Text = "Chi phí";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(80, 119);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(76, 13);
            this.bosLabel16.TabIndex = 564;
            this.bosLabel16.Text = "Tổng chiết khấu";
            // 
            // fld_txtARSaleOrderTotalDiscountFix
            // 
            this.fld_txtARSaleOrderTotalDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderTotalDiscountFix.BOSComment = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSDataMember = "ARSaleOrderTotalDiscountFix";
            this.fld_txtARSaleOrderTotalDiscountFix.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalDiscountFix.BOSDescription = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSError = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSPrivilege = null;
            this.fld_txtARSaleOrderTotalDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTotalDiscountFix.EditValue = "0.00";
            this.fld_txtARSaleOrderTotalDiscountFix.Location = new System.Drawing.Point(174, 116);
            this.fld_txtARSaleOrderTotalDiscountFix.Name = "fld_txtARSaleOrderTotalDiscountFix";
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalDiscountFix.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalDiscountFix.Screen = null;
            this.fld_txtARSaleOrderTotalDiscountFix.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARSaleOrderTotalDiscountFix.TabIndex = 6;
            this.fld_txtARSaleOrderTotalDiscountFix.Tag = "DC";
            // 
            // fld_txtARSaleOrderSOCommissionAmount
            // 
            this.fld_txtARSaleOrderSOCommissionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderSOCommissionAmount.BOSComment = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDataMember = "ARSaleOrderSOCommissionAmount";
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDescription = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSError = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSOCommissionAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderSOCommissionAmount.Location = new System.Drawing.Point(251, 140);
            this.fld_txtARSaleOrderSOCommissionAmount.Name = "fld_txtARSaleOrderSOCommissionAmount";
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSOCommissionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSOCommissionAmount.Screen = null;
            this.fld_txtARSaleOrderSOCommissionAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderSOCommissionAmount.TabIndex = 8;
            this.fld_txtARSaleOrderSOCommissionAmount.Tag = "DC";
            this.fld_txtARSaleOrderSOCommissionAmount.EditValueChanged += new System.EventHandler(this.fld_txtARSaleOrderSOCommissionAmount_EditValueChanged);
            this.fld_txtARSaleOrderSOCommissionAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderSOCommissionAmount_Validated);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(9, 143);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(149, 13);
            this.bosLabel2.TabIndex = 48;
            this.bosLabel2.Text = "Chi phí Giới thiệu/Giảm trừ khác";
            // 
            // fld_txtARSaleOrderCustomerCommissionPercent
            // 
            this.fld_txtARSaleOrderCustomerCommissionPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSComment = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDataMember = "ARSaleOrderSOCommissionPercent";
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDescription = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSError = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSFieldGroup = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSFieldRelation = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSPrivilege = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderCustomerCommissionPercent.EditValue = "0.00";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Location = new System.Drawing.Point(174, 140);
            this.fld_txtARSaleOrderCustomerCommissionPercent.Name = "fld_txtARSaleOrderCustomerCommissionPercent";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Screen = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARSaleOrderCustomerCommissionPercent.TabIndex = 7;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Tag = "DC";
            this.fld_txtARSaleOrderCustomerCommissionPercent.EditValueChanged += new System.EventHandler(this.fld_txtARSaleOrderCustomerCommissionPercent_EditValueChanged);
            this.fld_txtARSaleOrderCustomerCommissionPercent.Validated += new System.EventHandler(this.fld_txtARSaleOrderCustomerCommissionPercent_Validated);
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_txtARSalesOrderDeliveryFloorNumber);
            this.bosLine2.Controls.Add(this.bosLabel32);
            this.bosLine2.Controls.Add(this.fld_chkARSaleOrderPreDeliverySurveyFalse);
            this.bosLine2.Controls.Add(this.fld_chkARSaleOrderPreDeliverySurveyTrue);
            this.bosLine2.Controls.Add(this.fld_dteARSalesOrderDeliveryTime);
            this.bosLine2.Controls.Add(this.bosLabel31);
            this.bosLine2.Controls.Add(this.bosLabel30);
            this.bosLine2.Controls.Add(this.fld_lkeARSalesOrderDeliveryFloorType);
            this.bosLine2.Controls.Add(this.bosLabel24);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(772, 661);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine2, true);
            this.bosLine2.Size = new System.Drawing.Size(278, 126);
            this.bosLine2.TabIndex = 32;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Khảo sát giao hàng";
            // 
            // fld_txtARSalesOrderDeliveryFloorNumber
            // 
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSComment = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSDataMember = "ARSalesOrderDeliveryFloorNumber";
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSDescription = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSError = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSFieldGroup = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSFieldRelation = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSPrivilege = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.BOSPropertyName = "EditValue";
            this.fld_txtARSalesOrderDeliveryFloorNumber.Location = new System.Drawing.Point(93, 47);
            this.fld_txtARSalesOrderDeliveryFloorNumber.Name = "fld_txtARSalesOrderDeliveryFloorNumber";
            this.fld_txtARSalesOrderDeliveryFloorNumber.Screen = null;
            this.fld_txtARSalesOrderDeliveryFloorNumber.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARSalesOrderDeliveryFloorNumber.TabIndex = 1;
            this.fld_txtARSalesOrderDeliveryFloorNumber.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = null;
            this.bosLabel32.BOSDataSource = null;
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(11, 50);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(38, 13);
            this.bosLabel32.TabIndex = 574;
            this.bosLabel32.Text = "Tầng số";
            // 
            // fld_chkARSaleOrderPreDeliverySurveyFalse
            // 
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.Location = new System.Drawing.Point(192, 70);
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.MenuManager = this.screenToolbar;
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.Name = "fld_chkARSaleOrderPreDeliverySurveyFalse";
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.Properties.Caption = "Không";
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.Size = new System.Drawing.Size(66, 20);
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.TabIndex = 2;
            this.fld_chkARSaleOrderPreDeliverySurveyFalse.CheckedChanged += new System.EventHandler(this.fld_chkARSaleOrderPreDeliverySurveyFalse_CheckedChanged);
            // 
            // fld_chkARSaleOrderPreDeliverySurveyTrue
            // 
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.Location = new System.Drawing.Point(146, 70);
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.MenuManager = this.screenToolbar;
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.Name = "fld_chkARSaleOrderPreDeliverySurveyTrue";
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.Properties.Caption = "Có";
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.Size = new System.Drawing.Size(47, 20);
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.TabIndex = 572;
            this.fld_chkARSaleOrderPreDeliverySurveyTrue.CheckedChanged += new System.EventHandler(this.fld_chkARSaleOrderPreDeliverySurveyTrue_CheckedChanged);
            // 
            // fld_dteARSalesOrderDeliveryTime
            // 
            this.fld_dteARSalesOrderDeliveryTime.BOSComment = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSDataMember = "ARSalesOrderDeliveryTime";
            this.fld_dteARSalesOrderDeliveryTime.BOSDataSource = "ARSaleOrders";
            this.fld_dteARSalesOrderDeliveryTime.BOSDescription = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSError = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSFieldGroup = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSFieldRelation = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSPrivilege = null;
            this.fld_dteARSalesOrderDeliveryTime.BOSPropertyName = null;
            this.fld_dteARSalesOrderDeliveryTime.EditValue = new System.DateTime(2018, 8, 28, 0, 0, 0, 0);
            this.fld_dteARSalesOrderDeliveryTime.Location = new System.Drawing.Point(93, 95);
            this.fld_dteARSalesOrderDeliveryTime.MenuManager = this.screenToolbar;
            this.fld_dteARSalesOrderDeliveryTime.Name = "fld_dteARSalesOrderDeliveryTime";
            this.fld_dteARSalesOrderDeliveryTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSalesOrderDeliveryTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_dteARSalesOrderDeliveryTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteARSalesOrderDeliveryTime.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_dteARSalesOrderDeliveryTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteARSalesOrderDeliveryTime.Properties.Mask.EditMask = "HH:mm";
            this.fld_dteARSalesOrderDeliveryTime.Screen = null;
            this.fld_dteARSalesOrderDeliveryTime.Size = new System.Drawing.Size(165, 20);
            this.fld_dteARSalesOrderDeliveryTime.TabIndex = 4;
            this.fld_dteARSalesOrderDeliveryTime.TabStop = false;
            this.fld_dteARSalesOrderDeliveryTime.EditValueChanged += new System.EventHandler(this.fld_dteARSalesOrderDeliveryTime_EditValueChanged);
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(11, 98);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(64, 13);
            this.bosLabel31.TabIndex = 27;
            this.bosLabel31.Text = "Giao hàng lúc";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = null;
            this.bosLabel30.BOSDataMember = null;
            this.bosLabel30.BOSDataSource = null;
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = null;
            this.bosLabel30.BOSFieldRelation = null;
            this.bosLabel30.BOSPrivilege = null;
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(11, 72);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(121, 13);
            this.bosLabel30.TabIndex = 26;
            this.bosLabel30.Text = "Khảo sát trước giao hàng";
            // 
            // fld_lkeARSalesOrderDeliveryFloorType
            // 
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSAllowAddNew = false;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSAllowDummy = false;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSComment = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSDataMember = "ARSalesOrderDeliveryFloorType";
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSDescription = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSError = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSFieldGroup = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSFieldParent = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSFieldRelation = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSPrivilege = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSPropertyName = "EditValue";
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSSelectType = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.BOSSelectTypeValue = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.CurrentDisplayText = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.Location = new System.Drawing.Point(93, 21);
            this.fld_lkeARSalesOrderDeliveryFloorType.MenuManager = this.screenToolbar;
            this.fld_lkeARSalesOrderDeliveryFloorType.Name = "fld_lkeARSalesOrderDeliveryFloorType";
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.ColumnName = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.NullText = "";
            this.fld_lkeARSalesOrderDeliveryFloorType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSalesOrderDeliveryFloorType.Screen = null;
            this.fld_lkeARSalesOrderDeliveryFloorType.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeARSalesOrderDeliveryFloorType.TabIndex = 0;
            this.fld_lkeARSalesOrderDeliveryFloorType.Tag = "DC";
            this.fld_lkeARSalesOrderDeliveryFloorType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeARSalesOrderDeliveryFloorType_CloseUp);
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
            this.bosLabel24.Location = new System.Drawing.Point(11, 24);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(63, 13);
            this.bosLabel24.TabIndex = 16;
            this.bosLabel24.Text = "Giao hàng tại";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = "";
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(6, 286);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.fld_tabSOItems;
            this.bosTabControl1.Size = new System.Drawing.Size(1417, 369);
            this.bosTabControl1.TabIndex = 1;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSOItems,
            this.xtraTabPage2,
            this.xtraTabPage5,
            this.xtraTabCostList,
            this.xtraTabPage4,
            this.xtraTabPage3,
            this.xtraTabAsset,
            this.xtraTabWorkTask,
            this.fld_tabSOItemContainers});
            // 
            // fld_tabSOItems
            // 
            this.fld_tabSOItems.Controls.Add(this.fld_btnImportTemplate);
            this.fld_tabSOItems.Controls.Add(this.fld_btnExportTemplate);
            this.fld_tabSOItems.Controls.Add(this.fld_btnUpdateInventoryStock);
            this.fld_tabSOItems.Controls.Add(this.fld_lblLabel48);
            this.fld_tabSOItems.Controls.Add(this.fld_pteARSaleOrderItemProductPicture);
            this.fld_tabSOItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabSOItems.Controls.Add(this.fld_dgcARSaleOrderItems);
            this.fld_tabSOItems.Controls.Add(this.fld_btnShowInventoryStock);
            this.fld_tabSOItems.Name = "fld_tabSOItems";
            this.fld_tabSOItems.Size = new System.Drawing.Size(1415, 344);
            this.fld_tabSOItems.Text = "Danh sách sản phẩm";
            // 
            // fld_btnImportTemplate
            // 
            this.fld_btnImportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnImportTemplate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_btnImportTemplate.Appearance.Options.UseForeColor = true;
            this.fld_btnImportTemplate.BOSComment = null;
            this.fld_btnImportTemplate.BOSDataMember = null;
            this.fld_btnImportTemplate.BOSDataSource = null;
            this.fld_btnImportTemplate.BOSDescription = null;
            this.fld_btnImportTemplate.BOSError = null;
            this.fld_btnImportTemplate.BOSFieldGroup = null;
            this.fld_btnImportTemplate.BOSFieldRelation = null;
            this.fld_btnImportTemplate.BOSPrivilege = null;
            this.fld_btnImportTemplate.BOSPropertyName = null;
            this.fld_btnImportTemplate.Location = new System.Drawing.Point(1271, 219);
            this.fld_btnImportTemplate.Name = "fld_btnImportTemplate";
            this.fld_btnImportTemplate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnImportTemplate, true);
            this.fld_btnImportTemplate.Size = new System.Drawing.Size(141, 27);
            this.fld_btnImportTemplate.TabIndex = 60;
            this.fld_btnImportTemplate.Text = "Import SP";
            this.fld_btnImportTemplate.Click += new System.EventHandler(this.fld_btnImportTemplate_Click);
            // 
            // fld_btnExportTemplate
            // 
            this.fld_btnExportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportTemplate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_btnExportTemplate.Appearance.Options.UseForeColor = true;
            this.fld_btnExportTemplate.BOSComment = null;
            this.fld_btnExportTemplate.BOSDataMember = null;
            this.fld_btnExportTemplate.BOSDataSource = null;
            this.fld_btnExportTemplate.BOSDescription = null;
            this.fld_btnExportTemplate.BOSError = null;
            this.fld_btnExportTemplate.BOSFieldGroup = null;
            this.fld_btnExportTemplate.BOSFieldRelation = null;
            this.fld_btnExportTemplate.BOSPrivilege = null;
            this.fld_btnExportTemplate.BOSPropertyName = null;
            this.fld_btnExportTemplate.Location = new System.Drawing.Point(1271, 186);
            this.fld_btnExportTemplate.Name = "fld_btnExportTemplate";
            this.fld_btnExportTemplate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportTemplate, true);
            this.fld_btnExportTemplate.Size = new System.Drawing.Size(141, 27);
            this.fld_btnExportTemplate.TabIndex = 59;
            this.fld_btnExportTemplate.Text = "Export Template";
            this.fld_btnExportTemplate.Click += new System.EventHandler(this.fld_btnExportTemplate_Click);
            // 
            // fld_btnUpdateInventoryStock
            // 
            this.fld_btnUpdateInventoryStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdateInventoryStock.BOSComment = null;
            this.fld_btnUpdateInventoryStock.BOSDataMember = null;
            this.fld_btnUpdateInventoryStock.BOSDataSource = null;
            this.fld_btnUpdateInventoryStock.BOSDescription = null;
            this.fld_btnUpdateInventoryStock.BOSError = null;
            this.fld_btnUpdateInventoryStock.BOSFieldGroup = null;
            this.fld_btnUpdateInventoryStock.BOSFieldRelation = null;
            this.fld_btnUpdateInventoryStock.BOSPrivilege = null;
            this.fld_btnUpdateInventoryStock.BOSPropertyName = null;
            this.fld_btnUpdateInventoryStock.Location = new System.Drawing.Point(1271, 7);
            this.fld_btnUpdateInventoryStock.Name = "fld_btnUpdateInventoryStock";
            this.fld_btnUpdateInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateInventoryStock, true);
            this.fld_btnUpdateInventoryStock.Size = new System.Drawing.Size(141, 27);
            this.fld_btnUpdateInventoryStock.TabIndex = 58;
            this.fld_btnUpdateInventoryStock.Text = "Xem tồn kho";
            this.fld_btnUpdateInventoryStock.Click += new System.EventHandler(this.fld_btnUpdateInventoryStock_Click);
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(6, 10);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_pteARSaleOrderItemProductPicture
            // 
            this.fld_pteARSaleOrderItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARSaleOrderItemProductPicture.BOSComment = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSDataMember = "ARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.BOSDataSource = "ARSaleOrderItems";
            this.fld_pteARSaleOrderItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSError = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleOrderItemProductPicture.FileName = null;
            this.fld_pteARSaleOrderItemProductPicture.FilePath = null;
            this.fld_pteARSaleOrderItemProductPicture.Location = new System.Drawing.Point(1271, 40);
            this.fld_pteARSaleOrderItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARSaleOrderItemProductPicture.Name = "fld_pteARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderItemProductPicture.Screen = null;
            this.fld_pteARSaleOrderItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARSaleOrderItemProductPicture.TabIndex = 4;
            this.fld_pteARSaleOrderItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = null;
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(59, 8);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(1206, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 2;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductAttributeID_QueryPopUp);
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARSaleOrderItems
            // 
            this.fld_dgcARSaleOrderItems.AllowDrop = true;
            this.fld_dgcARSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItems.BOSComment = null;
            this.fld_dgcARSaleOrderItems.BOSDataMember = null;
            this.fld_dgcARSaleOrderItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.BOSDescription = null;
            this.fld_dgcARSaleOrderItems.BOSError = null;
            this.fld_dgcARSaleOrderItems.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItems.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItems.BOSGridType = null;
            this.fld_dgcARSaleOrderItems.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItems.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItems.CommodityType = "";
            this.fld_dgcARSaleOrderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcARSaleOrderItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(1262, 305);
            this.fld_dgcARSaleOrderItems.TabIndex = 3;
            this.fld_dgcARSaleOrderItems.Tag = "DC";
            this.fld_dgcARSaleOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARSaleOrderItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_btnShowInventoryStock
            // 
            this.fld_btnShowInventoryStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnShowInventoryStock.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_btnShowInventoryStock.Appearance.Options.UseForeColor = true;
            this.fld_btnShowInventoryStock.BOSComment = null;
            this.fld_btnShowInventoryStock.BOSDataMember = null;
            this.fld_btnShowInventoryStock.BOSDataSource = null;
            this.fld_btnShowInventoryStock.BOSDescription = null;
            this.fld_btnShowInventoryStock.BOSError = null;
            this.fld_btnShowInventoryStock.BOSFieldGroup = null;
            this.fld_btnShowInventoryStock.BOSFieldRelation = null;
            this.fld_btnShowInventoryStock.BOSPrivilege = null;
            this.fld_btnShowInventoryStock.BOSPropertyName = null;
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(1271, 252);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(141, 27);
            this.fld_btnShowInventoryStock.TabIndex = 1;
            this.fld_btnShowInventoryStock.Text = "Chọn từ tồn kho";
            this.fld_btnShowInventoryStock.Visible = false;
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARSaleOrderPaymentTimes);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabPage2.Text = "Danh sách đợt thanh toán";
            // 
            // fld_dgcARSaleOrderPaymentTimes
            // 
            this.fld_dgcARSaleOrderPaymentTimes.AllowDrop = true;
            this.fld_dgcARSaleOrderPaymentTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderPaymentTimes.BOSComment = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSDataMember = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSDataSource = "ARSaleOrderPaymentTimes";
            this.fld_dgcARSaleOrderPaymentTimes.BOSDescription = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSError = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSGridType = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSPrivilege = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSPropertyName = null;
            this.fld_dgcARSaleOrderPaymentTimes.CommodityType = "";
            this.fld_dgcARSaleOrderPaymentTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderPaymentTimes.Location = new System.Drawing.Point(0, 3);
            this.fld_dgcARSaleOrderPaymentTimes.MainView = this.gridView1;
            this.fld_dgcARSaleOrderPaymentTimes.Name = "fld_dgcARSaleOrderPaymentTimes";
            this.fld_dgcARSaleOrderPaymentTimes.PrintReport = false;
            this.fld_dgcARSaleOrderPaymentTimes.Screen = null;
            this.fld_dgcARSaleOrderPaymentTimes.Size = new System.Drawing.Size(1415, 341);
            this.fld_dgcARSaleOrderPaymentTimes.TabIndex = 26;
            this.fld_dgcARSaleOrderPaymentTimes.Tag = "DC";
            this.fld_dgcARSaleOrderPaymentTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARSaleOrderPaymentTimes;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.bosLookupEdit1);
            this.xtraTabPage5.Controls.Add(this.bosLabel50);
            this.xtraTabPage5.Controls.Add(this.bosLabel6);
            this.xtraTabPage5.Controls.Add(this.fld_btnSaveCommision);
            this.xtraTabPage5.Controls.Add(this.fld_btnAddCommission);
            this.xtraTabPage5.Controls.Add(this.bosLabel37);
            this.xtraTabPage5.Controls.Add(this.fld_txtARCommissionRate);
            this.xtraTabPage5.Controls.Add(this.fld_lkeACCustomerObjectID);
            this.xtraTabPage5.Controls.Add(this.fld_dgcCommissionsGridControl);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabPage5.Text = "Chi phí giảm trừ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ARCommissionType";
            this.bosLookupEdit1.BOSDataSource = "ARCommissions";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(513, 9);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(128, 20);
            this.bosLookupEdit1.TabIndex = 816;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel50
            // 
            this.bosLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel50.Appearance.Options.UseBackColor = true;
            this.bosLabel50.Appearance.Options.UseForeColor = true;
            this.bosLabel50.BOSComment = null;
            this.bosLabel50.BOSDataMember = null;
            this.bosLabel50.BOSDataSource = null;
            this.bosLabel50.BOSDescription = null;
            this.bosLabel50.BOSError = null;
            this.bosLabel50.BOSFieldGroup = null;
            this.bosLabel50.BOSFieldRelation = null;
            this.bosLabel50.BOSPrivilege = null;
            this.bosLabel50.BOSPropertyName = null;
            this.bosLabel50.Location = new System.Drawing.Point(455, 12);
            this.bosLabel50.Name = "bosLabel50";
            this.bosLabel50.Screen = null;
            this.bosLabel50.Size = new System.Drawing.Size(52, 13);
            this.bosLabel50.TabIndex = 565;
            this.bosLabel50.Text = "Loại chi phí";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(15, 12);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 564;
            this.bosLabel6.Text = "Đối tượng";
            this.bosLabel6.Click += new System.EventHandler(this.bosLabel6_Click);
            // 
            // fld_btnSaveCommision
            // 
            this.fld_btnSaveCommision.BOSComment = null;
            this.fld_btnSaveCommision.BOSDataMember = null;
            this.fld_btnSaveCommision.BOSDataSource = null;
            this.fld_btnSaveCommision.BOSDescription = null;
            this.fld_btnSaveCommision.BOSError = null;
            this.fld_btnSaveCommision.BOSFieldGroup = null;
            this.fld_btnSaveCommision.BOSFieldRelation = null;
            this.fld_btnSaveCommision.BOSPrivilege = null;
            this.fld_btnSaveCommision.BOSPropertyName = null;
            this.fld_btnSaveCommision.Location = new System.Drawing.Point(735, 5);
            this.fld_btnSaveCommision.Name = "fld_btnSaveCommision";
            this.fld_btnSaveCommision.Screen = null;
            this.fld_btnSaveCommision.Size = new System.Drawing.Size(80, 27);
            this.fld_btnSaveCommision.TabIndex = 563;
            this.fld_btnSaveCommision.Tag = "";
            this.fld_btnSaveCommision.Text = "Lưu";
            this.fld_btnSaveCommision.Visible = false;
            this.fld_btnSaveCommision.Click += new System.EventHandler(this.fld_btnSaveCommision_Click);
            // 
            // fld_btnAddCommission
            // 
            this.fld_btnAddCommission.BOSComment = null;
            this.fld_btnAddCommission.BOSDataMember = null;
            this.fld_btnAddCommission.BOSDataSource = null;
            this.fld_btnAddCommission.BOSDescription = null;
            this.fld_btnAddCommission.BOSError = null;
            this.fld_btnAddCommission.BOSFieldGroup = null;
            this.fld_btnAddCommission.BOSFieldRelation = null;
            this.fld_btnAddCommission.BOSPrivilege = null;
            this.fld_btnAddCommission.BOSPropertyName = null;
            this.fld_btnAddCommission.Location = new System.Drawing.Point(649, 4);
            this.fld_btnAddCommission.Name = "fld_btnAddCommission";
            this.fld_btnAddCommission.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddCommission, true);
            this.fld_btnAddCommission.Size = new System.Drawing.Size(80, 27);
            this.fld_btnAddCommission.TabIndex = 563;
            this.fld_btnAddCommission.Tag = "";
            this.fld_btnAddCommission.Text = "Thêm";
            this.fld_btnAddCommission.Click += new System.EventHandler(this.fld_btnAddCommission_Click);
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = null;
            this.bosLabel37.BOSDataMember = null;
            this.bosLabel37.BOSDataSource = null;
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = null;
            this.bosLabel37.BOSFieldRelation = null;
            this.bosLabel37.BOSPrivilege = null;
            this.bosLabel37.BOSPropertyName = null;
            this.bosLabel37.Location = new System.Drawing.Point(188, 12);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(103, 13);
            this.bosLabel37.TabIndex = 562;
            this.bosLabel37.Text = "% Giới thiệu/Giảm trừ";
            // 
            // fld_txtARCommissionRate
            // 
            this.fld_txtARCommissionRate.BOSComment = null;
            this.fld_txtARCommissionRate.BOSDataMember = "ARCommissionRate";
            this.fld_txtARCommissionRate.BOSDataSource = "ARCommissions";
            this.fld_txtARCommissionRate.BOSDescription = null;
            this.fld_txtARCommissionRate.BOSError = null;
            this.fld_txtARCommissionRate.BOSFieldGroup = null;
            this.fld_txtARCommissionRate.BOSFieldRelation = null;
            this.fld_txtARCommissionRate.BOSPrivilege = null;
            this.fld_txtARCommissionRate.BOSPropertyName = "EditValue";
            this.fld_txtARCommissionRate.Location = new System.Drawing.Point(299, 9);
            this.fld_txtARCommissionRate.Name = "fld_txtARCommissionRate";
            this.fld_txtARCommissionRate.Screen = null;
            this.fld_txtARCommissionRate.Size = new System.Drawing.Size(146, 20);
            this.fld_txtARCommissionRate.TabIndex = 21;
            this.fld_txtARCommissionRate.Tag = "DC";
            // 
            // fld_lkeACCustomerObjectID
            // 
            this.fld_lkeACCustomerObjectID.BOSAllowAddNew = false;
            this.fld_lkeACCustomerObjectID.BOSAllowDummy = true;
            this.fld_lkeACCustomerObjectID.BOSComment = "";
            this.fld_lkeACCustomerObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACCustomerObjectID.BOSDataSource = "ARCommissions";
            this.fld_lkeACCustomerObjectID.BOSDescription = null;
            this.fld_lkeACCustomerObjectID.BOSError = null;
            this.fld_lkeACCustomerObjectID.BOSFieldGroup = "";
            this.fld_lkeACCustomerObjectID.BOSFieldParent = "";
            this.fld_lkeACCustomerObjectID.BOSFieldRelation = "";
            this.fld_lkeACCustomerObjectID.BOSModuleType = null;
            this.fld_lkeACCustomerObjectID.BOSPrivilege = "";
            this.fld_lkeACCustomerObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeACCustomerObjectID.BOSSelectType = "";
            this.fld_lkeACCustomerObjectID.BOSSelectTypeValue = "";
            this.fld_lkeACCustomerObjectID.CurrentDisplayText = null;
            this.fld_lkeACCustomerObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACCustomerObjectID.Location = new System.Drawing.Point(69, 9);
            this.fld_lkeACCustomerObjectID.Name = "fld_lkeACCustomerObjectID";
            this.fld_lkeACCustomerObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACCustomerObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACCustomerObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACCustomerObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACCustomerObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCustomerObjectID.Properties.ColumnName = null;
            this.fld_lkeACCustomerObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACCustomerObjectID.Properties.NullText = "";
            this.fld_lkeACCustomerObjectID.Properties.PopupWidth = 40;
            this.fld_lkeACCustomerObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACCustomerObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACCustomerObjectID.Screen = null;
            this.fld_lkeACCustomerObjectID.Size = new System.Drawing.Size(113, 20);
            this.fld_lkeACCustomerObjectID.TabIndex = 20;
            this.fld_lkeACCustomerObjectID.Tag = "DC";
            this.fld_lkeACCustomerObjectID.EditValueChanged += new System.EventHandler(this.fld_lkeACCustomerObjectID_EditValueChanged);
            this.fld_lkeACCustomerObjectID.Validated += new System.EventHandler(this.Fld_lkeACCustomerObjectID_Validated);
            // 
            // fld_dgcCommissionsGridControl
            // 
            this.fld_dgcCommissionsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCommissionsGridControl.BOSComment = null;
            this.fld_dgcCommissionsGridControl.BOSDataMember = null;
            this.fld_dgcCommissionsGridControl.BOSDataSource = "ARCommissions";
            this.fld_dgcCommissionsGridControl.BOSDescription = null;
            this.fld_dgcCommissionsGridControl.BOSError = null;
            this.fld_dgcCommissionsGridControl.BOSFieldGroup = null;
            this.fld_dgcCommissionsGridControl.BOSFieldRelation = null;
            this.fld_dgcCommissionsGridControl.BOSGridType = null;
            this.fld_dgcCommissionsGridControl.BOSPrivilege = null;
            this.fld_dgcCommissionsGridControl.BOSPropertyName = null;
            this.fld_dgcCommissionsGridControl.CommodityType = "";
            this.fld_dgcCommissionsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcCommissionsGridControl.Location = new System.Drawing.Point(3, 37);
            this.fld_dgcCommissionsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcCommissionsGridControl.Name = "fld_dgcCommissionsGridControl";
            this.fld_dgcCommissionsGridControl.PrintReport = false;
            this.fld_dgcCommissionsGridControl.Screen = null;
            this.fld_dgcCommissionsGridControl.Size = new System.Drawing.Size(1408, 305);
            this.fld_dgcCommissionsGridControl.TabIndex = 1;
            // 
            // xtraTabCostList
            // 
            this.xtraTabCostList.Controls.Add(this.fld_btnAddCost);
            this.xtraTabCostList.Controls.Add(this.fld_dgcARSaleOrderItemCosts);
            this.xtraTabCostList.Name = "xtraTabCostList";
            this.xtraTabCostList.PageVisible = false;
            this.xtraTabCostList.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabCostList.Text = "Danh sách chi phí";
            // 
            // fld_btnAddCost
            // 
            this.fld_btnAddCost.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddCost.Appearance.Options.UseForeColor = true;
            this.fld_btnAddCost.BOSComment = "";
            this.fld_btnAddCost.BOSDataMember = null;
            this.fld_btnAddCost.BOSDataSource = null;
            this.fld_btnAddCost.BOSDescription = null;
            this.fld_btnAddCost.BOSError = null;
            this.fld_btnAddCost.BOSFieldGroup = "";
            this.fld_btnAddCost.BOSFieldRelation = "";
            this.fld_btnAddCost.BOSPrivilege = "";
            this.fld_btnAddCost.BOSPropertyName = null;
            this.fld_btnAddCost.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddCost.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddCost.Name = "fld_btnAddCost";
            this.fld_btnAddCost.Screen = null;
            this.fld_btnAddCost.Size = new System.Drawing.Size(112, 27);
            this.fld_btnAddCost.TabIndex = 15;
            this.fld_btnAddCost.Tag = "";
            this.fld_btnAddCost.Text = "Thêm chi phí";
            this.fld_btnAddCost.Click += new System.EventHandler(this.fld_btnAddCost_Click);
            // 
            // fld_dgcARSaleOrderItemCosts
            // 
            this.fld_dgcARSaleOrderItemCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemCosts.BOSComment = null;
            this.fld_dgcARSaleOrderItemCosts.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemCosts.BOSDataSource = "ARSaleOrderItemWorks";
            this.fld_dgcARSaleOrderItemCosts.BOSDescription = null;
            this.fld_dgcARSaleOrderItemCosts.BOSError = null;
            this.fld_dgcARSaleOrderItemCosts.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemCosts.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemCosts.BOSGridType = null;
            this.fld_dgcARSaleOrderItemCosts.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemCosts.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemCosts.CommodityType = "";
            this.fld_dgcARSaleOrderItemCosts.Location = new System.Drawing.Point(0, 36);
            this.fld_dgcARSaleOrderItemCosts.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemCosts.Name = "fld_dgcARSaleOrderItemCosts";
            this.fld_dgcARSaleOrderItemCosts.PrintReport = false;
            this.fld_dgcARSaleOrderItemCosts.Screen = null;
            this.fld_dgcARSaleOrderItemCosts.Size = new System.Drawing.Size(1412, 305);
            this.fld_dgcARSaleOrderItemCosts.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_btnAddWork);
            this.xtraTabPage4.Controls.Add(this.fld_dgcARSaleOrderItemWorksGridControl);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.PageVisible = false;
            this.xtraTabPage4.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabPage4.Text = "Danh sách công việc";
            // 
            // fld_btnAddWork
            // 
            this.fld_btnAddWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddWork.BOSComment = "";
            this.fld_btnAddWork.BOSDataMember = null;
            this.fld_btnAddWork.BOSDataSource = null;
            this.fld_btnAddWork.BOSDescription = null;
            this.fld_btnAddWork.BOSError = null;
            this.fld_btnAddWork.BOSFieldGroup = "";
            this.fld_btnAddWork.BOSFieldRelation = "";
            this.fld_btnAddWork.BOSPrivilege = "";
            this.fld_btnAddWork.BOSPropertyName = null;
            this.fld_btnAddWork.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddWork.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddWork.Name = "fld_btnAddWork";
            this.fld_btnAddWork.Screen = null;
            this.fld_btnAddWork.Size = new System.Drawing.Size(112, 27);
            this.fld_btnAddWork.TabIndex = 14;
            this.fld_btnAddWork.Tag = "";
            this.fld_btnAddWork.Text = "Thêm công việc";
            this.fld_btnAddWork.Click += new System.EventHandler(this.fld_btnAddWork_Click);
            // 
            // fld_dgcARSaleOrderItemWorksGridControl
            // 
            this.fld_dgcARSaleOrderItemWorksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSDataSource = "ARSaleOrderItemWorks";
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemWorksGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARSaleOrderItemWorksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemWorksGridControl.Name = "fld_dgcARSaleOrderItemWorksGridControl";
            this.fld_dgcARSaleOrderItemWorksGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemWorksGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemWorksGridControl.Size = new System.Drawing.Size(1408, 305);
            this.fld_dgcARSaleOrderItemWorksGridControl.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_btnAddProductMaterialItem);
            this.xtraTabPage3.Controls.Add(this.fld_dgcARSaleOrderItemWorkMaterialsGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.PageVisible = false;
            this.xtraTabPage3.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabPage3.Text = "Danh sách vật tư";
            // 
            // fld_btnAddProductMaterialItem
            // 
            this.fld_btnAddProductMaterialItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductMaterialItem.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductMaterialItem.BOSComment = "";
            this.fld_btnAddProductMaterialItem.BOSDataMember = null;
            this.fld_btnAddProductMaterialItem.BOSDataSource = null;
            this.fld_btnAddProductMaterialItem.BOSDescription = null;
            this.fld_btnAddProductMaterialItem.BOSError = null;
            this.fld_btnAddProductMaterialItem.BOSFieldGroup = "";
            this.fld_btnAddProductMaterialItem.BOSFieldRelation = "";
            this.fld_btnAddProductMaterialItem.BOSPrivilege = "";
            this.fld_btnAddProductMaterialItem.BOSPropertyName = null;
            this.fld_btnAddProductMaterialItem.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddProductMaterialItem.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddProductMaterialItem.Name = "fld_btnAddProductMaterialItem";
            this.fld_btnAddProductMaterialItem.Screen = null;
            this.fld_btnAddProductMaterialItem.Size = new System.Drawing.Size(113, 27);
            this.fld_btnAddProductMaterialItem.TabIndex = 12;
            this.fld_btnAddProductMaterialItem.Tag = "";
            this.fld_btnAddProductMaterialItem.Text = "Thêm vật tư";
            this.fld_btnAddProductMaterialItem.Click += new System.EventHandler(this.fld_btnAddProductMaterialItem_Click);
            // 
            // fld_dgcARSaleOrderItemWorkMaterialsGridControl
            // 
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSDataSource = "ARSaleOrderItemWorks";
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.Name = "fld_dgcARSaleOrderItemWorkMaterialsGridControl";
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.Size = new System.Drawing.Size(1408, 305);
            this.fld_dgcARSaleOrderItemWorkMaterialsGridControl.TabIndex = 0;
            // 
            // xtraTabAsset
            // 
            this.xtraTabAsset.Controls.Add(this.fld_btnAddProductAssetItem);
            this.xtraTabAsset.Controls.Add(this.fld_dgcARSaleOrderItemWorkAssetsGridControl);
            this.xtraTabAsset.Name = "xtraTabAsset";
            this.xtraTabAsset.PageVisible = false;
            this.xtraTabAsset.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabAsset.Text = "Danh sách MMTB";
            // 
            // fld_btnAddProductAssetItem
            // 
            this.fld_btnAddProductAssetItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductAssetItem.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductAssetItem.BOSComment = "";
            this.fld_btnAddProductAssetItem.BOSDataMember = null;
            this.fld_btnAddProductAssetItem.BOSDataSource = null;
            this.fld_btnAddProductAssetItem.BOSDescription = null;
            this.fld_btnAddProductAssetItem.BOSError = null;
            this.fld_btnAddProductAssetItem.BOSFieldGroup = "";
            this.fld_btnAddProductAssetItem.BOSFieldRelation = "";
            this.fld_btnAddProductAssetItem.BOSPrivilege = "";
            this.fld_btnAddProductAssetItem.BOSPropertyName = null;
            this.fld_btnAddProductAssetItem.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddProductAssetItem.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddProductAssetItem.Name = "fld_btnAddProductAssetItem";
            this.fld_btnAddProductAssetItem.Screen = null;
            this.fld_btnAddProductAssetItem.Size = new System.Drawing.Size(144, 27);
            this.fld_btnAddProductAssetItem.TabIndex = 13;
            this.fld_btnAddProductAssetItem.Tag = "";
            this.fld_btnAddProductAssetItem.Text = "Thêm máy móc thiết bị";
            this.fld_btnAddProductAssetItem.Click += new System.EventHandler(this.fld_btnAddProductAssetItem_Click);
            // 
            // fld_dgcARSaleOrderItemWorkAssetsGridControl
            // 
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSDataSource = "ARSaleOrderItemWorks";
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.Name = "fld_dgcARSaleOrderItemWorkAssetsGridControl";
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.Size = new System.Drawing.Size(1411, 304);
            this.fld_dgcARSaleOrderItemWorkAssetsGridControl.TabIndex = 0;
            // 
            // xtraTabWorkTask
            // 
            this.xtraTabWorkTask.Controls.Add(this.fld_dgcARSaleOrderItemWorkTasksGridControl);
            this.xtraTabWorkTask.Name = "xtraTabWorkTask";
            this.xtraTabWorkTask.PageVisible = false;
            this.xtraTabWorkTask.Size = new System.Drawing.Size(1415, 344);
            this.xtraTabWorkTask.Text = "Danh sách task";
            // 
            // fld_dgcARSaleOrderItemWorkTasksGridControl
            // 
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSDataSource = "ARSaleOrderItemWorkTasks";
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.Name = "fld_dgcARSaleOrderItemWorkTasksGridControl";
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.Size = new System.Drawing.Size(1408, 338);
            this.fld_dgcARSaleOrderItemWorkTasksGridControl.TabIndex = 1;
            // 
            // fld_tabSOItemContainers
            // 
            this.fld_tabSOItemContainers.Controls.Add(this.fld_dgcARSaleOrderItemContainers);
            this.fld_tabSOItemContainers.Name = "fld_tabSOItemContainers";
            this.fld_tabSOItemContainers.Size = new System.Drawing.Size(1415, 344);
            this.fld_tabSOItemContainers.Text = "Cont";
            // 
            // fld_dgcARSaleOrderItemContainers
            // 
            this.fld_dgcARSaleOrderItemContainers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemContainers.BOSComment = null;
            this.fld_dgcARSaleOrderItemContainers.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemContainers.BOSDataSource = "ARSaleOrderItemContainers";
            this.fld_dgcARSaleOrderItemContainers.BOSDescription = null;
            this.fld_dgcARSaleOrderItemContainers.BOSError = null;
            this.fld_dgcARSaleOrderItemContainers.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemContainers.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemContainers.BOSGridType = null;
            this.fld_dgcARSaleOrderItemContainers.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemContainers.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemContainers.CommodityType = "";
            this.fld_dgcARSaleOrderItemContainers.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcARSaleOrderItemContainers.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemContainers.Name = "fld_dgcARSaleOrderItemContainers";
            this.fld_dgcARSaleOrderItemContainers.PrintReport = false;
            this.fld_dgcARSaleOrderItemContainers.Screen = null;
            this.fld_dgcARSaleOrderItemContainers.Size = new System.Drawing.Size(1408, 338);
            this.fld_dgcARSaleOrderItemContainers.TabIndex = 2;
            // 
            // fld_Line4
            // 
            this.fld_Line4.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line4.BOSComment = null;
            this.fld_Line4.BOSDataMember = null;
            this.fld_Line4.BOSDataSource = null;
            this.fld_Line4.BOSDescription = null;
            this.fld_Line4.BOSError = null;
            this.fld_Line4.BOSFieldGroup = null;
            this.fld_Line4.BOSFieldRelation = null;
            this.fld_Line4.BOSPrivilege = null;
            this.fld_Line4.BOSPropertyName = null;
            this.fld_Line4.Controls.Add(this.fld_lblARSaleOrderInvoiceContactName);
            this.fld_Line4.Controls.Add(this.bosLabel29);
            this.fld_Line4.Controls.Add(this.bosLabel28);
            this.fld_Line4.Controls.Add(this.bosLabel26);
            this.fld_Line4.Controls.Add(this.bosLabel25);
            this.fld_Line4.Controls.Add(this.bosLabel10);
            this.fld_Line4.Controls.Add(this.bosLabel13);
            this.fld_Line4.Controls.Add(this.bosLabel19);
            this.fld_Line4.Controls.Add(this.bosLabel14);
            this.fld_Line4.Controls.Add(this.bosLabel21);
            this.fld_Line4.Controls.Add(this.bosLabel15);
            this.fld_Line4.Controls.Add(this.bosButton1);
            this.fld_Line4.Controls.Add(this.fld_btnEditShippingInfo);
            this.fld_Line4.Controls.Add(this.fld_lblLabel29);
            this.fld_Line4.Controls.Add(this.fld_lblLabel42);
            this.fld_Line4.Controls.Add(this.fld_lblARSaleOrderDeliveryContactName);
            this.fld_Line4.Controls.Add(this.fld_lblLabel37);
            this.fld_Line4.Controls.Add(this.fld_Line1);
            this.fld_Line4.Controls.Add(this.fld_lblLabel36);
            this.fld_Line4.Controls.Add(this.fld_lblLabel34);
            this.fld_Line4.Controls.Add(this.fld_lblLabel30);
            this.fld_Line4.Controls.Add(this.fld_Line);
            this.fld_Line4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line4.Location = new System.Drawing.Point(359, 661);
            this.fld_Line4.Name = "fld_Line4";
            this.fld_Line4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line4, true);
            this.fld_Line4.Size = new System.Drawing.Size(407, 231);
            this.fld_Line4.TabIndex = 31;
            this.fld_Line4.TabStop = false;
            this.fld_Line4.Text = "Thông tin giao hàng";
            // 
            // fld_lblARSaleOrderInvoiceContactName
            // 
            this.fld_lblARSaleOrderInvoiceContactName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleOrderInvoiceContactName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleOrderInvoiceContactName.Appearance.Options.UseBackColor = true;
            this.fld_lblARSaleOrderInvoiceContactName.Appearance.Options.UseForeColor = true;
            this.fld_lblARSaleOrderInvoiceContactName.BOSComment = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSDataMember = "ARSaleOrderInvoiceContactName";
            this.fld_lblARSaleOrderInvoiceContactName.BOSDataSource = "ARSaleOrders";
            this.fld_lblARSaleOrderInvoiceContactName.BOSDescription = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSError = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSFieldGroup = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSFieldRelation = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSPrivilege = null;
            this.fld_lblARSaleOrderInvoiceContactName.BOSPropertyName = null;
            this.fld_lblARSaleOrderInvoiceContactName.Location = new System.Drawing.Point(9, 41);
            this.fld_lblARSaleOrderInvoiceContactName.Name = "fld_lblARSaleOrderInvoiceContactName";
            this.fld_lblARSaleOrderInvoiceContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblARSaleOrderInvoiceContactName, true);
            this.fld_lblARSaleOrderInvoiceContactName.Size = new System.Drawing.Size(136, 13);
            this.fld_lblARSaleOrderInvoiceContactName.TabIndex = 78;
            this.fld_lblARSaleOrderInvoiceContactName.Text = "LamViet Join Stock Company";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = "";
            this.bosLabel29.BOSDataSource = "";
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(273, 176);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(18, 13);
            this.bosLabel29.TabIndex = 75;
            this.bosLabel29.Text = "Fax";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = "";
            this.bosLabel28.BOSDataSource = "";
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(273, 79);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel28, true);
            this.bosLabel28.Size = new System.Drawing.Size(18, 13);
            this.bosLabel28.TabIndex = 74;
            this.bosLabel28.Text = "Fax";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(161, 176);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel26, true);
            this.bosLabel26.Size = new System.Drawing.Size(14, 13);
            this.bosLabel26.TabIndex = 72;
            this.bosLabel26.Text = "Tel";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(161, 79);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, true);
            this.bosLabel25.Size = new System.Drawing.Size(14, 13);
            this.bosLabel25.TabIndex = 71;
            this.bosLabel25.Text = "Tel";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(9, 176);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(44, 13);
            this.bosLabel10.TabIndex = 69;
            this.bosLabel10.Text = "Tax code";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(9, 79);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(44, 13);
            this.bosLabel13.TabIndex = 68;
            this.bosLabel13.Text = "Tax code";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = "ARSaleOrderInvoiceAddressFax";
            this.bosLabel19.BOSDataSource = "ARSaleOrders";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(296, 79);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(12, 13);
            this.bosLabel19.TabIndex = 67;
            this.bosLabel19.Text = "08";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = "ARSaleOrderInvoiceAddressTel";
            this.bosLabel14.BOSDataSource = "ARSaleOrders";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(181, 79);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(12, 13);
            this.bosLabel14.TabIndex = 67;
            this.bosLabel14.Text = "08";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = "ARSaleOrderDeliveryAddressFax";
            this.bosLabel21.BOSDataSource = "ARSaleOrders";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(293, 176);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(12, 13);
            this.bosLabel21.TabIndex = 66;
            this.bosLabel21.Text = "08";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = "ARSaleOrderDeliveryAddressTel";
            this.bosLabel15.BOSDataSource = "ARSaleOrders";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(181, 176);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(12, 13);
            this.bosLabel15.TabIndex = 66;
            this.bosLabel15.Text = "08";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(326, 100);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(75, 20);
            this.bosButton1.TabIndex = 0;
            this.bosButton1.Text = "Sửa";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_btnEditShippingInfo
            // 
            this.fld_btnEditShippingInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEditShippingInfo.Appearance.Options.UseForeColor = true;
            this.fld_btnEditShippingInfo.BOSComment = null;
            this.fld_btnEditShippingInfo.BOSDataMember = null;
            this.fld_btnEditShippingInfo.BOSDataSource = null;
            this.fld_btnEditShippingInfo.BOSDescription = null;
            this.fld_btnEditShippingInfo.BOSError = null;
            this.fld_btnEditShippingInfo.BOSFieldGroup = null;
            this.fld_btnEditShippingInfo.BOSFieldRelation = null;
            this.fld_btnEditShippingInfo.BOSPrivilege = null;
            this.fld_btnEditShippingInfo.BOSPropertyName = null;
            this.fld_btnEditShippingInfo.Location = new System.Drawing.Point(326, 197);
            this.fld_btnEditShippingInfo.Name = "fld_btnEditShippingInfo";
            this.fld_btnEditShippingInfo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnEditShippingInfo, true);
            this.fld_btnEditShippingInfo.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditShippingInfo.TabIndex = 1;
            this.fld_btnEditShippingInfo.Text = "Sửa";
            this.fld_btnEditShippingInfo.Click += new System.EventHandler(this.fld_btnEditShippingInfo_Click_1);
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseFont = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = null;
            this.fld_lblLabel29.BOSDataMember = null;
            this.fld_lblLabel29.BOSDataSource = null;
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = null;
            this.fld_lblLabel29.BOSFieldRelation = null;
            this.fld_lblLabel29.BOSPrivilege = null;
            this.fld_lblLabel29.BOSPropertyName = null;
            this.fld_lblLabel29.Location = new System.Drawing.Point(9, 21);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel29, true);
            this.fld_lblLabel29.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel29.TabIndex = 0;
            this.fld_lblLabel29.Text = "Địa chỉ hóa đơn";
            // 
            // fld_lblLabel42
            // 
            this.fld_lblLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel42.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel42.BOSComment = null;
            this.fld_lblLabel42.BOSDataMember = "ARSaleOrderDeliveryAddressTaxCode";
            this.fld_lblLabel42.BOSDataSource = "ARSaleOrders";
            this.fld_lblLabel42.BOSDescription = null;
            this.fld_lblLabel42.BOSError = null;
            this.fld_lblLabel42.BOSFieldGroup = null;
            this.fld_lblLabel42.BOSFieldRelation = null;
            this.fld_lblLabel42.BOSPrivilege = null;
            this.fld_lblLabel42.BOSPropertyName = null;
            this.fld_lblLabel42.Location = new System.Drawing.Point(59, 176);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel42, true);
            this.fld_lblLabel42.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel42.TabIndex = 44;
            this.fld_lblLabel42.Text = "08";
            // 
            // fld_lblARSaleOrderDeliveryContactName
            // 
            this.fld_lblARSaleOrderDeliveryContactName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleOrderDeliveryContactName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleOrderDeliveryContactName.Appearance.Options.UseBackColor = true;
            this.fld_lblARSaleOrderDeliveryContactName.Appearance.Options.UseForeColor = true;
            this.fld_lblARSaleOrderDeliveryContactName.BOSComment = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSDataMember = "ARSaleOrderDeliveryContactName";
            this.fld_lblARSaleOrderDeliveryContactName.BOSDataSource = "ARSaleOrders";
            this.fld_lblARSaleOrderDeliveryContactName.BOSDescription = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSError = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSFieldGroup = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSFieldRelation = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSPrivilege = null;
            this.fld_lblARSaleOrderDeliveryContactName.BOSPropertyName = null;
            this.fld_lblARSaleOrderDeliveryContactName.Location = new System.Drawing.Point(9, 136);
            this.fld_lblARSaleOrderDeliveryContactName.Name = "fld_lblARSaleOrderDeliveryContactName";
            this.fld_lblARSaleOrderDeliveryContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblARSaleOrderDeliveryContactName, true);
            this.fld_lblARSaleOrderDeliveryContactName.Size = new System.Drawing.Size(136, 13);
            this.fld_lblARSaleOrderDeliveryContactName.TabIndex = 3;
            this.fld_lblARSaleOrderDeliveryContactName.Text = "LamViet Join Stock Company";
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = null;
            this.fld_lblLabel37.BOSDataMember = "ARSaleOrderDeliveryAddressLine3";
            this.fld_lblLabel37.BOSDataSource = "ARSaleOrders";
            this.fld_lblLabel37.BOSDescription = null;
            this.fld_lblLabel37.BOSError = null;
            this.fld_lblLabel37.BOSFieldGroup = null;
            this.fld_lblLabel37.BOSFieldRelation = null;
            this.fld_lblLabel37.BOSPrivilege = null;
            this.fld_lblLabel37.BOSPropertyName = null;
            this.fld_lblLabel37.Location = new System.Drawing.Point(9, 155);
            this.fld_lblLabel37.Name = "fld_lblLabel37";
            this.fld_lblLabel37.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel37, true);
            this.fld_lblLabel37.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel37.TabIndex = 3;
            this.fld_lblLabel37.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line1.BOSComment = null;
            this.fld_Line1.BOSDataMember = null;
            this.fld_Line1.BOSDataSource = null;
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = null;
            this.fld_Line1.BOSFieldRelation = null;
            this.fld_Line1.BOSPrivilege = null;
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line1.Location = new System.Drawing.Point(114, 116);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line1, true);
            this.fld_Line1.Size = new System.Drawing.Size(280, 10);
            this.fld_Line1.TabIndex = 1;
            this.fld_Line1.TabStop = false;
            // 
            // fld_lblLabel36
            // 
            this.fld_lblLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel36.Appearance.Options.UseFont = true;
            this.fld_lblLabel36.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel36.BOSComment = null;
            this.fld_lblLabel36.BOSDataMember = null;
            this.fld_lblLabel36.BOSDataSource = null;
            this.fld_lblLabel36.BOSDescription = null;
            this.fld_lblLabel36.BOSError = null;
            this.fld_lblLabel36.BOSFieldGroup = null;
            this.fld_lblLabel36.BOSFieldRelation = null;
            this.fld_lblLabel36.BOSPrivilege = null;
            this.fld_lblLabel36.BOSPropertyName = null;
            this.fld_lblLabel36.Location = new System.Drawing.Point(9, 113);
            this.fld_lblLabel36.Name = "fld_lblLabel36";
            this.fld_lblLabel36.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel36, true);
            this.fld_lblLabel36.Size = new System.Drawing.Size(96, 13);
            this.fld_lblLabel36.TabIndex = 1;
            this.fld_lblLabel36.Text = "Địa chỉ giao hàng";
            // 
            // fld_lblLabel34
            // 
            this.fld_lblLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel34.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel34.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel34.BOSComment = null;
            this.fld_lblLabel34.BOSDataMember = "ARSaleOrderInvoiceAddressTaxCode";
            this.fld_lblLabel34.BOSDataSource = "ARSaleOrders";
            this.fld_lblLabel34.BOSDescription = null;
            this.fld_lblLabel34.BOSError = null;
            this.fld_lblLabel34.BOSFieldGroup = null;
            this.fld_lblLabel34.BOSFieldRelation = null;
            this.fld_lblLabel34.BOSPrivilege = null;
            this.fld_lblLabel34.BOSPropertyName = null;
            this.fld_lblLabel34.Location = new System.Drawing.Point(59, 79);
            this.fld_lblLabel34.Name = "fld_lblLabel34";
            this.fld_lblLabel34.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel34, true);
            this.fld_lblLabel34.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel34.TabIndex = 35;
            this.fld_lblLabel34.Text = "08";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = null;
            this.fld_lblLabel30.BOSDataMember = "ARSaleOrderInvoiceAddressLine3";
            this.fld_lblLabel30.BOSDataSource = "ARSaleOrders";
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = null;
            this.fld_lblLabel30.BOSFieldRelation = null;
            this.fld_lblLabel30.BOSPrivilege = null;
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(9, 60);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel30, true);
            this.fld_lblLabel30.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel30.TabIndex = 1;
            this.fld_lblLabel30.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = null;
            this.fld_Line.BOSDataMember = null;
            this.fld_Line.BOSDataSource = null;
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = null;
            this.fld_Line.BOSFieldRelation = null;
            this.fld_Line.BOSPrivilege = null;
            this.fld_Line.BOSPropertyName = null;
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Location = new System.Drawing.Point(97, 24);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line, true);
            this.fld_Line.Size = new System.Drawing.Size(300, 10);
            this.fld_Line.TabIndex = 0;
            this.fld_Line.TabStop = false;
            // 
            // DMSO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1520, 1028);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSO100.IconOptions.Icon")));
            this.Name = "DMSO100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPartialShipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTranshipment.Properties)).EndInit();
            this.fld_lnMain.ResumeLayout(false);
            this.fld_lnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderItemGrantedFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderPortOFLoading.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPortOFDischarge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderContQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderSaleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ARDiscountProgramID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedARSalesman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsContainerLoader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsVehicleAllocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsInvoiceAndShipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsAcceptance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsDeliveryPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsSaleOrderShipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSaleOrderProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox20.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flt_txtARSaleOrderPriceCostTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSalesOrderDeliveryFloorNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPreDeliverySurveyFalse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPreDeliverySurveyTrue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSalesOrderDeliveryTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSalesOrderDeliveryFloorType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.fld_tabSOItems.ResumeLayout(false);
            this.fld_tabSOItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCommissionRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCustomerObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommissionsGridControl)).EndInit();
            this.xtraTabCostList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemCosts)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorksGridControl)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkMaterialsGridControl)).EndInit();
            this.xtraTabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkAssetsGridControl)).EndInit();
            this.xtraTabWorkTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemWorkTasksGridControl)).EndInit();
            this.fld_tabSOItemContainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemContainers)).EndInit();
            this.fld_Line4.ResumeLayout(false);
            this.fld_Line4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderDepositBalance;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderBalanceDue;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTaxAmount;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkViewDiffPrice;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderCustomerCommissionPercent;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSOCommissionAmount;
        private BOSComponent.BOSLine fld_Line4;
        private BOSComponent.BOSLabel fld_lblARSaleOrderInvoiceContactName;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton fld_btnEditShippingInfo;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblARSaleOrderDeliveryContactName;
        private BOSComponent.BOSLabel fld_lblLabel37;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel36;
        private BOSComponent.BOSLabel fld_lblLabel34;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage fld_tabSOItems;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ARSaleOrderPaymentTimesGridControl fld_dgcARSaleOrderPaymentTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ARSaleOrderItemWorkMaterialsGridControl fld_dgcARSaleOrderItemWorkMaterialsGridControl;
        private ARSaleOrderItemWorksGridControl fld_dgcARSaleOrderItemWorksGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabWorkTask;
        //private ARSaleOrderWorkItemMaterialsGridControl fld_dgcARSaleOrderItemWorkTasksGridControl;
        private ARSaleOrderItemWorkTasksGridControl fld_dgcARSaleOrderItemWorkTasksGridControl;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalCost;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private DevExpress.XtraTab.XtraTabPage xtraTabCostList;
        private ARSaleOrderItemCostGridControl fld_dgcARSaleOrderItemCosts;
        private BOSComponent.BOSButton fld_btnAddProductMaterialItem;
        private DevExpress.XtraTab.XtraTabPage xtraTabAsset;
        private ARSaleOrderItemWorkAssetsGridControl fld_dgcARSaleOrderItemWorkAssetsGridControl;

        private BOSComponent.BOSButton fld_btnAddWork;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalDiscountFix;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSButton fld_btnAddProductAssetItem;
        private BOSComponent.BOSButton fld_btnAddCost;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLookupEdit fld_lkeARSalesOrderDeliveryFloorType;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTimeEdit fld_dteARSalesOrderDeliveryTime;
        private DevExpress.XtraEditors.CheckEdit fld_chkARSaleOrderPreDeliverySurveyFalse;
        private DevExpress.XtraEditors.CheckEdit fld_chkARSaleOrderPreDeliverySurveyTrue;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSTextBox fld_txtARSalesOrderDeliveryFloorNumber;
        private BOSComponent.BOSTextBox flt_txtARSaleOrderPriceCostTotalAmount;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private ARCommissionsGridControl fld_dgcCommissionsGridControl;
        private BOSComponent.BOSLabel bosLabel37;
        private BOSComponent.BOSTextBox fld_txtARCommissionRate;
        private AccObjectLookupEdit fld_lkeACCustomerObjectID;
        private BOSComponent.BOSButton fld_btnAddCommission;
        private BOSComponent.BOSLabel bosLabel93;
        private BOSComponent.BOSLabel bosLabel96;
        private BOSComponent.BOSLabel bosLabel95;
        private BOSComponent.BOSLabel bosLabel6;
        private DevExpress.XtraTab.XtraTabPage fld_tabSOItemContainers;
        private ARSaleOrderItemContainersGridControl fld_dgcARSaleOrderItemContainers;
        private BOSComponent.BOSLine fld_lnMain;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSLabel fld_lbhtbhValidate;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderExchangeRate21;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID21;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderPortOFDischarge;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeARShippingType;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel fld_lbPono;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalProduct;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderContQty;
        private BOSComponent.BOSLabel fld_lblContQty;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderSaleType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderType;
        private BOSComponent.BOSButtonEdit fld_bedFK_ARDiscountProgramID;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSButtonEdit fld_bedARSalesman;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsContainerLoader;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARDeliveryMethodID;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsVehicleAllocation;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsInvoiceAndShipment;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsAcceptance;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsDeliveryPlan;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsSaleOrderShipment;
        private BOSComponent.BOSLookupEdit bosLookupEdit9;
        private BOSComponent.BOSLabel bosLabel84;
        private BOSComponent.BOSLookupEdit bosLookupEdit10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSLabel bosLabel85;
        private BOSComponent.BOSLabel bosLabel88;
        private BOSComponent.BOSLabel bosLabel97;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderExchangeRate;
        private BOSComponent.BOSLabel bosLabel89;
        private BOSComponent.BOSLabel bosLabel90;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDate;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSTextBox bosTextBox1;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkChooseProspectCustomer;
        private BOSComponent.BOSLabel bosLabel58;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSLabel bosLabel60;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLabel bosLabel61;
        private BOSComponent.BOSLabel bosLabel62;
        private BOSComponent.BOSLookupEdit fld_lkeSaleOrderProductType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel bosLabel86;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel87;
        private BOSComponent.BOSTextBox bosTextBox20;
        private BOSComponent.BOSLabel bosLabel91;
        private BOSComponent.BOSTextBox bosTextBox21;
        private BOSComponent.BOSLabel bosLabel92;
        private BOSComponent.BOSLabel bosLabel94;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSDateEdit bosDateEdit4;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderPortOFLoading;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderPartialShipment;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTranshipment;
        private BOSComponent.BOSLabel bosLabel39;
        private BOSComponent.BOSLabel bosLabel40;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel42;
        private BOSComponent.BOSLabel bosLabel43;
        private BOSComponent.BOSLookupEdit bosLookupEdit5;
        private BOSComponent.BOSButton fld_btnUpdateInventoryStock;
        private BOSComponent.BOSLabel bosLabel44;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderItemGrantedFrom;
        private BOSComponent.BOSLabel bosLabel45;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel47;
        private BOSComponent.BOSLabel bosLabel46;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSRichEditControl fld_recARSaleOrderComment;
        private BOSComponent.BOSRichEditControl fld_recARSaleOrderInternalComment;
        private BOSComponent.BOSButton fld_btnImportTemplate;
        private BOSComponent.BOSButton fld_btnExportTemplate;
        private BOSComponent.BOSButton fld_btnItemDesc;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSLabel bosLabel48;
        private BOSComponent.BOSLabel bosLabel49;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel50;
        private BOSComponent.BOSButton fld_btnSaveCommision;
    }
}
