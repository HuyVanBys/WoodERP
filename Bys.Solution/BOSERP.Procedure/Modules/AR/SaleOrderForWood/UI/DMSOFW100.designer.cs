using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleOrderForWood.UI
{
    /// <summary>
    /// Summary description for DMSO100
    /// </summary>
    partial class DMSOFW100
    {
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID1;
        private BOSComponent.BOSLabel fld_lblLabel24;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDate;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderComment;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
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
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medARSaleOrderComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medARSaleOrderInternalComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderSOContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkViewDiffPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtARSaleOrderSaleAgreement = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.SaleOrderForWood.ARSaleOrderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TabLumber = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.itemLookupEdit1 = new BOSERP.ItemLookupEdit(this.components);
            this.LumberGridControl = new BOSERP.Modules.SaleOrderForWood.LumberItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TabRoundWood = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.RoundWoodGridControl = new BOSERP.Modules.SaleOrderForWood.RoundWoodtemsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderPaymentTimes = new BOSERP.Modules.SaleOrderForWood.ARSaleOrderPaymentTimesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.fld_lkeARSaleOrderBatchStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARShippingType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARSaleOrderStatus1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderContQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblContQty = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkARSaleOrderPortTranShipment = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkARSaleOrderPortPartialShipment = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtARSaleOrderPONo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbPaymentTerm = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabelSaleOrderType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderTotalProduct = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderPortOFDischarge = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderReference = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderExchangeRate2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderCustomerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderSOCommissionAmount = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo1.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderInternalComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.TabLumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LumberGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.TabRoundWood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundWoodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_Line4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderBatchStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderStatus1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderContQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPortTranShipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPortPartialShipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPortOFDischarge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_pteARSaleOrderEmployeePicture.Location = new System.Drawing.Point(3, 4);
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 106);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(116, 38);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 7;
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARCustomerID1
            // 
            this.fld_lkeFK_ARCustomerID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID1.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID1.BOSComment = null;
            this.fld_lkeFK_ARCustomerID1.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARCustomerID1.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID1.BOSError = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID1.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID1.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID1.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID1.Location = new System.Drawing.Point(210, 35);
            this.fld_lkeFK_ARCustomerID1.Name = "fld_lkeFK_ARCustomerID1";
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID1.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID1.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.Screen = null;
            this.fld_lkeFK_ARCustomerID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID1.TabIndex = 1;
            this.fld_lkeFK_ARCustomerID1.Tag = "DC";
            this.fld_lkeFK_ARCustomerID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID1_CloseUp);
            // 
            // fld_lblLabel24
            // 
            this.fld_lblLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel24.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel24.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel24.BOSComment = null;
            this.fld_lblLabel24.BOSDataMember = null;
            this.fld_lblLabel24.BOSDataSource = null;
            this.fld_lblLabel24.BOSDescription = null;
            this.fld_lblLabel24.BOSError = null;
            this.fld_lblLabel24.BOSFieldGroup = null;
            this.fld_lblLabel24.BOSFieldRelation = null;
            this.fld_lblLabel24.BOSPrivilege = null;
            this.fld_lblLabel24.BOSPropertyName = null;
            this.fld_lblLabel24.Location = new System.Drawing.Point(918, 12);
            this.fld_lblLabel24.Name = "fld_lblLabel24";
            this.fld_lblLabel24.Screen = null;
            this.fld_lblLabel24.Size = new System.Drawing.Size(77, 13);
            this.fld_lblLabel24.TabIndex = 13;
            this.fld_lblLabel24.Text = "Phương thức TT";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(919, 64);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 14;
            this.fld_lblLabel25.Text = "Tình trạng";
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
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(1000, 9);
            this.fld_lkeARPaymentMethodCombo.Name = "fld_lkeARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPaymentMethodCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARPaymentMethodCombo.Screen = null;
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 21;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // fld_dteARSaleOrderDate
            // 
            this.fld_dteARSaleOrderDate.BOSComment = null;
            this.fld_dteARSaleOrderDate.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteARSaleOrderDate.BOSDescription = null;
            this.fld_dteARSaleOrderDate.BOSError = null;
            this.fld_dteARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDate.EditValue = null;
            this.fld_dteARSaleOrderDate.Location = new System.Drawing.Point(469, 9);
            this.fld_dteARSaleOrderDate.Name = "fld_dteARSaleOrderDate";
            this.fld_dteARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDate.Screen = null;
            this.fld_dteARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleOrderDate.TabIndex = 6;
            this.fld_dteARSaleOrderDate.Tag = "DC";
            this.fld_dteARSaleOrderDate.Validated += new System.EventHandler(this.fld_dteARSaleOrderDate_Validated);
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(375, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = null;
            this.fld_lblLabel27.BOSDataMember = null;
            this.fld_lblLabel27.BOSDataSource = null;
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = null;
            this.fld_lblLabel27.BOSFieldRelation = null;
            this.fld_lblLabel27.BOSPrivilege = null;
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(641, 12);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel27.TabIndex = 19;
            this.fld_lblLabel27.Text = "Ngày giao hàng";
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
            this.fld_dteARSaleOrderDeliveryDate.Location = new System.Drawing.Point(743, 9);
            this.fld_dteARSaleOrderDeliveryDate.Name = "fld_dteARSaleOrderDeliveryDate";
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDate.Screen = null;
            this.fld_dteARSaleOrderDeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleOrderDeliveryDate.TabIndex = 14;
            this.fld_dteARSaleOrderDeliveryDate.Tag = "DC";
            this.fld_dteARSaleOrderDeliveryDate.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_dteARSaleOrderDeliveryDate_Closed);
            this.fld_dteARSaleOrderDeliveryDate.Validated += new System.EventHandler(this.fld_dteARSaleOrderDeliveryDate_Validated);
            // 
            // fld_medARSaleOrderComment
            // 
            this.fld_medARSaleOrderComment.BOSComment = null;
            this.fld_medARSaleOrderComment.BOSDataMember = "ARSaleOrderComment";
            this.fld_medARSaleOrderComment.BOSDataSource = "ARSaleOrders";
            this.fld_medARSaleOrderComment.BOSDescription = null;
            this.fld_medARSaleOrderComment.BOSError = null;
            this.fld_medARSaleOrderComment.BOSFieldGroup = null;
            this.fld_medARSaleOrderComment.BOSFieldRelation = null;
            this.fld_medARSaleOrderComment.BOSPrivilege = null;
            this.fld_medARSaleOrderComment.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARSaleOrderComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARSaleOrderComment.Name = "fld_medARSaleOrderComment";
            this.fld_medARSaleOrderComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderComment.Screen = null;
            this.fld_medARSaleOrderComment.Size = new System.Drawing.Size(344, 80);
            this.fld_medARSaleOrderComment.TabIndex = 0;
            this.fld_medARSaleOrderComment.Tag = "DC";
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
            this.fld_lblLabel43.Location = new System.Drawing.Point(906, 670);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
            this.fld_lblLabel43.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel43.TabIndex = 45;
            this.fld_lblLabel43.Text = "Mức giá";
            this.fld_lblLabel43.Visible = false;
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
            this.fld_lblLabel44.Location = new System.Drawing.Point(893, 515);
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
            this.fld_lblLabel46.Location = new System.Drawing.Point(892, 541);
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
            this.fld_lblLabel47.Location = new System.Drawing.Point(877, 593);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 49;
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(976, 667);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(177, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 38;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.Visible = false;
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
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
            this.fld_txtARSaleOrderDiscountPerCent.Location = new System.Drawing.Point(976, 538);
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
            this.fld_txtARSaleOrderDiscountPerCent.TabIndex = 31;
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
            this.fld_txtARSaleOrderDiscountFix.Location = new System.Drawing.Point(1054, 538);
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
            this.fld_txtARSaleOrderDiscountFix.TabIndex = 32;
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
            this.fld_txtARSaleOrderSubTotalAmount.Location = new System.Drawing.Point(976, 512);
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
            this.fld_txtARSaleOrderSubTotalAmount.TabIndex = 30;
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
            this.fld_txtARSaleOrderTotalAmount.Location = new System.Drawing.Point(976, 590);
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
            this.fld_txtARSaleOrderTotalAmount.TabIndex = 35;
            this.fld_txtARSaleOrderTotalAmount.Tag = "DC";
            // 
            // fld_Line3
            // 
            this.fld_Line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fld_Line3.Controls.Add(this.fld_medARSaleOrderComment);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(3, 498);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(350, 100);
            this.fld_Line3.TabIndex = 27;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Text = "Ghi chú in ra";
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
            this.BOSLabel4.Location = new System.Drawing.Point(876, 620);
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
            this.BOSLabel5.Location = new System.Drawing.Point(899, 645);
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
            this.fld_txtARSaleOrderDepositBalance.Location = new System.Drawing.Point(976, 617);
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
            this.fld_txtARSaleOrderDepositBalance.TabIndex = 36;
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
            this.fld_txtARSaleOrderBalanceDue.Location = new System.Drawing.Point(976, 642);
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
            this.fld_txtARSaleOrderBalanceDue.TabIndex = 37;
            this.fld_txtARSaleOrderBalanceDue.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(116, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(86, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "P.I/Đơn bán hàng";
            // 
            // fld_txtARSaleOrderNo1
            // 
            this.fld_txtARSaleOrderNo1.BOSComment = null;
            this.fld_txtARSaleOrderNo1.BOSDataMember = "ARSaleOrderNo";
            this.fld_txtARSaleOrderNo1.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderNo1.BOSDescription = null;
            this.fld_txtARSaleOrderNo1.BOSError = null;
            this.fld_txtARSaleOrderNo1.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo1.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo1.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo1.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderNo1.Location = new System.Drawing.Point(210, 9);
            this.fld_txtARSaleOrderNo1.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderNo1.Name = "fld_txtARSaleOrderNo1";
            this.fld_txtARSaleOrderNo1.Screen = null;
            this.fld_txtARSaleOrderNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderNo1.TabIndex = 0;
            this.fld_txtARSaleOrderNo1.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.bosLine1.Controls.Add(this.fld_medARSaleOrderInternalComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(3, 615);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(350, 100);
            this.bosLine1.TabIndex = 28;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú không in ra";
            // 
            // fld_medARSaleOrderInternalComment
            // 
            this.fld_medARSaleOrderInternalComment.BOSComment = null;
            this.fld_medARSaleOrderInternalComment.BOSDataMember = "ARSaleOrderInternalComment";
            this.fld_medARSaleOrderInternalComment.BOSDataSource = "ARSaleOrders";
            this.fld_medARSaleOrderInternalComment.BOSDescription = null;
            this.fld_medARSaleOrderInternalComment.BOSError = null;
            this.fld_medARSaleOrderInternalComment.BOSFieldGroup = null;
            this.fld_medARSaleOrderInternalComment.BOSFieldRelation = null;
            this.fld_medARSaleOrderInternalComment.BOSPrivilege = null;
            this.fld_medARSaleOrderInternalComment.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderInternalComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARSaleOrderInternalComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARSaleOrderInternalComment.Name = "fld_medARSaleOrderInternalComment";
            this.fld_medARSaleOrderInternalComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderInternalComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderInternalComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderInternalComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderInternalComment.Screen = null;
            this.fld_medARSaleOrderInternalComment.Size = new System.Drawing.Size(344, 80);
            this.fld_medARSaleOrderInternalComment.TabIndex = 0;
            this.fld_medARSaleOrderInternalComment.Tag = "DC";
            // 
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSellerID.BOSComment = null;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARSellerID.BOSDescription = null;
            this.fld_lkeFK_ARSellerID.BOSError = null;
            this.fld_lkeFK_ARSellerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSellerID.BOSFieldParent = null;
            this.fld_lkeFK_ARSellerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSellerID.BOSPrivilege = null;
            this.fld_lkeFK_ARSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSellerID.BOSSelectType = null;
            this.fld_lkeFK_ARSellerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSellerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSellerID.Location = new System.Drawing.Point(210, 61);
            this.fld_lkeFK_ARSellerID.Name = "fld_lkeFK_ARSellerID";
            this.fld_lkeFK_ARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_ARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARSellerID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARSellerID.Screen = null;
            this.fld_lkeFK_ARSellerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSellerID.TabIndex = 2;
            this.fld_lkeFK_ARSellerID.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(116, 64);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(49, 13);
            this.bosLabel8.TabIndex = 72;
            this.bosLabel8.Text = "Người bán";
            // 
            // fld_txtARSaleOrderSOContactName
            // 
            this.fld_txtARSaleOrderSOContactName.BOSComment = null;
            this.fld_txtARSaleOrderSOContactName.BOSDataMember = "ARSaleOrderSOContactName";
            this.fld_txtARSaleOrderSOContactName.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSOContactName.BOSDescription = null;
            this.fld_txtARSaleOrderSOContactName.BOSError = null;
            this.fld_txtARSaleOrderSOContactName.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSOContactName.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSOContactName.BOSPrivilege = null;
            this.fld_txtARSaleOrderSOContactName.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSOContactName.Location = new System.Drawing.Point(469, 35);
            this.fld_txtARSaleOrderSOContactName.Name = "fld_txtARSaleOrderSOContactName";
            this.fld_txtARSaleOrderSOContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSOContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSOContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSOContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSOContactName.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSOContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSOContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSOContactName.Screen = null;
            this.fld_txtARSaleOrderSOContactName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderSOContactName.TabIndex = 7;
            this.fld_txtARSaleOrderSOContactName.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = null;
            this.fld_lblLabel2.BOSDataMember = null;
            this.fld_lblLabel2.BOSDataSource = null;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = null;
            this.fld_lblLabel2.BOSFieldRelation = null;
            this.fld_lblLabel2.BOSPrivilege = null;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(375, 38);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel2.TabIndex = 76;
            this.fld_lblLabel2.Text = "Người mua hàng";
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
            this.bosLabel9.Location = new System.Drawing.Point(919, 567);
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
            this.fld_txtARSaleOrderTaxPercent.Location = new System.Drawing.Point(976, 564);
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
            this.fld_txtARSaleOrderTaxPercent.TabIndex = 33;
            this.fld_txtARSaleOrderTaxPercent.Tag = "DC";
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
            this.fld_txtARSaleOrderTaxAmount.Location = new System.Drawing.Point(1054, 564);
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
            this.fld_txtARSaleOrderTaxAmount.TabIndex = 34;
            this.fld_txtARSaleOrderTaxAmount.Tag = "DC";
            this.fld_txtARSaleOrderTaxAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderTaxAmount_Validated);
            // 
            // fld_lnkViewDiffPrice
            // 
            this.fld_lnkViewDiffPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lnkViewDiffPrice.EditValue = "Xem chênh lệch giá kê";
            this.fld_lnkViewDiffPrice.Location = new System.Drawing.Point(976, 715);
            this.fld_lnkViewDiffPrice.MenuManager = this.screenToolbar;
            this.fld_lnkViewDiffPrice.Name = "fld_lnkViewDiffPrice";
            this.fld_lnkViewDiffPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkViewDiffPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkViewDiffPrice.Size = new System.Drawing.Size(177, 20);
            this.fld_lnkViewDiffPrice.TabIndex = 41;
            this.fld_lnkViewDiffPrice.Visible = false;
            this.fld_lnkViewDiffPrice.Click += new System.EventHandler(this.fld_lnkViewDiffPrice_Click);
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
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderSaleAgreement);
            this.bosPanel1.Controls.Add(this.bosLabel34);
            this.bosPanel1.Controls.Add(this.bosLabel33);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderProductType);
            this.bosPanel1.Controls.Add(this.fld_btnShowInventoryStock);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_Line4);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderBatchStatus);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeARShippingType);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderStatus1);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderContQty);
            this.bosPanel1.Controls.Add(this.fld_lblContQty);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.fld_chkARSaleOrderPortTranShipment);
            this.bosPanel1.Controls.Add(this.fld_chkARSaleOrderPortPartialShipment);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderPONo);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.bosPanel1.Controls.Add(this.fld_lbPaymentTerm);
            this.bosPanel1.Controls.Add(this.fld_lblLabelSaleOrderType);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderType);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderTotalProduct);
            this.bosPanel1.Controls.Add(this.bosLabel32);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderPortOFDischarge);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderReference);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.BOSLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderExchangeRate2);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderNo1);
            this.bosPanel1.Controls.Add(this.bosLabel31);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel30);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderDepositBalance);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderSOContactName);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderBalanceDue);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lnkViewDiffPrice);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderCustomerCommissionPercent);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderDiscountPerCent);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_lblLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel43);
            this.bosPanel1.Controls.Add(this.fld_lblLabel27);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderSOCommissionAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleOrderDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleOrderDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1180, 746);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_txtARSaleOrderSaleAgreement
            // 
            this.fld_txtARSaleOrderSaleAgreement.BOSComment = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSDataMember = "ARSaleOrderSaleAgreement";
            this.fld_txtARSaleOrderSaleAgreement.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSaleAgreement.BOSDescription = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSError = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPrivilege = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSaleAgreement.Location = new System.Drawing.Point(743, 191);
            this.fld_txtARSaleOrderSaleAgreement.Name = "fld_txtARSaleOrderSaleAgreement";
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSaleAgreement.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSaleAgreement.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSaleAgreement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSaleAgreement.Screen = null;
            this.fld_txtARSaleOrderSaleAgreement.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderSaleAgreement.TabIndex = 557;
            this.fld_txtARSaleOrderSaleAgreement.Tag = "DC";
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
            this.bosLabel34.Location = new System.Drawing.Point(641, 194);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(76, 13);
            this.bosLabel34.TabIndex = 558;
            this.bosLabel34.Text = "Sale Agreement";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.Location = new System.Drawing.Point(375, 194);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(59, 13);
            this.bosLabel33.TabIndex = 556;
            this.bosLabel33.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel33.Text = "Thành phẩm";
            // 
            // fld_lkeFK_ICProductID1
            // 
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID1.Location = new System.Drawing.Point(469, 191);
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.fld_lkeFK_ICProductID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductID1.TabIndex = 13;
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(116, 116);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(67, 13);
            this.bosLabel27.TabIndex = 548;
            this.bosLabel27.Text = "Loại hàng hóa";
            // 
            // fld_lkeARSaleOrderProductType
            // 
            this.fld_lkeARSaleOrderProductType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderProductType.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderProductType.BOSComment = null;
            this.fld_lkeARSaleOrderProductType.BOSDataMember = "ARSaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderProductType.BOSDescription = null;
            this.fld_lkeARSaleOrderProductType.BOSError = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderProductType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderProductType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderProductType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderProductType.Location = new System.Drawing.Point(210, 113);
            this.fld_lkeARSaleOrderProductType.Name = "fld_lkeARSaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderProductType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderProductType, true);
            this.fld_lkeARSaleOrderProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderProductType.TabIndex = 4;
            this.fld_lkeARSaleOrderProductType.Tag = "DC";
            this.fld_lkeARSaleOrderProductType.EditValueChanged += new System.EventHandler(this.fld_lkeARSaleOrderProductType_EditValueChanged);
            // 
            // fld_btnShowInventoryStock
            // 
            this.fld_btnShowInventoryStock.BOSComment = null;
            this.fld_btnShowInventoryStock.BOSDataMember = null;
            this.fld_btnShowInventoryStock.BOSDataSource = null;
            this.fld_btnShowInventoryStock.BOSDescription = null;
            this.fld_btnShowInventoryStock.BOSError = null;
            this.fld_btnShowInventoryStock.BOSFieldGroup = null;
            this.fld_btnShowInventoryStock.BOSFieldRelation = null;
            this.fld_btnShowInventoryStock.BOSPrivilege = null;
            this.fld_btnShowInventoryStock.BOSPropertyName = null;
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(963, 191);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(150, 27);
            this.fld_btnShowInventoryStock.TabIndex = 29;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Visible = false;
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // bosLabel16
            // 
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
            this.bosLabel16.Location = new System.Drawing.Point(375, 168);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(52, 13);
            this.bosLabel16.TabIndex = 130;
            this.bosLabel16.Text = "Mã lệnh SX";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(469, 165);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã lệnh SX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 12;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(6, 224);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1162, 268);
            this.bosTabControl1.TabIndex = 30;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.TabLumber,
            this.TabRoundWood,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel48);
            this.xtraTabPage1.Controls.Add(this.fld_pteARSaleOrderItemProductPicture);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.xtraTabPage1.Controls.Add(this.fld_dgcARSaleOrderItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1155, 239);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
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
            this.fld_lblLabel48.Location = new System.Drawing.Point(11, 6);
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
            this.fld_pteARSaleOrderItemProductPicture.Location = new System.Drawing.Point(1010, 3);
            this.fld_pteARSaleOrderItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARSaleOrderItemProductPicture.Name = "fld_pteARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderItemProductPicture.Screen = null;
            this.fld_pteARSaleOrderItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARSaleOrderItemProductPicture.TabIndex = 2;
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
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARSaleOrderItems";
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
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(64, 3);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(941, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
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
            this.fld_dgcARSaleOrderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(3, 29);
            this.fld_dgcARSaleOrderItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(1002, 207);
            this.fld_dgcARSaleOrderItems.TabIndex = 1;
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
            // TabLumber
            // 
            this.TabLumber.Controls.Add(this.bosLabel17);
            this.TabLumber.Controls.Add(this.itemLookupEdit1);
            this.TabLumber.Controls.Add(this.LumberGridControl);
            this.TabLumber.Name = "TabLumber";
            this.TabLumber.Size = new System.Drawing.Size(1155, 239);
            this.TabLumber.Text = "Phách";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(5, 9);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(47, 13);
            this.bosLabel17.TabIndex = 59;
            this.bosLabel17.Text = "Sản phẩm";
            // 
            // itemLookupEdit1
            // 
            this.itemLookupEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.itemLookupEdit1.BOSAllowAddNew = false;
            this.itemLookupEdit1.BOSAllowDummy = false;
            this.itemLookupEdit1.BOSComment = null;
            this.itemLookupEdit1.BOSDataMember = "FK_ICProductID";
            this.itemLookupEdit1.BOSDataSource = "ARSaleOrderItems";
            this.itemLookupEdit1.BOSDescription = null;
            this.itemLookupEdit1.BOSError = null;
            this.itemLookupEdit1.BOSFieldGroup = null;
            this.itemLookupEdit1.BOSFieldParent = null;
            this.itemLookupEdit1.BOSFieldRelation = null;
            this.itemLookupEdit1.BOSPrivilege = null;
            this.itemLookupEdit1.BOSPropertyName = "EditValue";
            this.itemLookupEdit1.BOSSelectType = "ICProductType";
            this.itemLookupEdit1.BOSSelectTypeValue = "Lumber;Verneer;ArtificialBoard;Reuse;Detail";
            this.itemLookupEdit1.CurrentDisplayText = null;
            this.itemLookupEdit1.Location = new System.Drawing.Point(58, 6);
            this.itemLookupEdit1.Name = "itemLookupEdit1";
            this.itemLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.itemLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.itemLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookupEdit1.Properties.DisplayMember = "ICProductDesc";
            this.itemLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemLookupEdit1.Properties.ValueMember = "ICProductID";
            this.itemLookupEdit1.Screen = null;
            this.itemLookupEdit1.Size = new System.Drawing.Size(1097, 20);
            this.itemLookupEdit1.TabIndex = 58;
            this.itemLookupEdit1.Tag = "DC";
            this.itemLookupEdit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemLookupEdit1_KeyUp);
            // 
            // LumberGridControl
            // 
            this.LumberGridControl.AllowDrop = true;
            this.LumberGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LumberGridControl.BOSComment = null;
            this.LumberGridControl.BOSDataMember = null;
            this.LumberGridControl.BOSDataSource = "ARSaleOrderItems";
            this.LumberGridControl.BOSDescription = null;
            this.LumberGridControl.BOSError = null;
            this.LumberGridControl.BOSFieldGroup = null;
            this.LumberGridControl.BOSFieldRelation = null;
            this.LumberGridControl.BOSGridType = null;
            this.LumberGridControl.BOSPrivilege = null;
            this.LumberGridControl.BOSPropertyName = null;
            this.LumberGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LumberGridControl.Location = new System.Drawing.Point(0, 32);
            this.LumberGridControl.MainView = this.gridView2;
            this.LumberGridControl.Name = "LumberGridControl";
            this.LumberGridControl.PrintReport = false;
            this.LumberGridControl.Screen = null;
            this.LumberGridControl.Size = new System.Drawing.Size(1155, 207);
            this.LumberGridControl.TabIndex = 2;
            this.LumberGridControl.Tag = "DC";
            this.LumberGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.LumberGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // TabRoundWood
            // 
            this.TabRoundWood.Controls.Add(this.fld_lkeFK_ICProductID);
            this.TabRoundWood.Controls.Add(this.bosLabel18);
            this.TabRoundWood.Controls.Add(this.RoundWoodGridControl);
            this.TabRoundWood.Name = "TabRoundWood";
            this.TabRoundWood.Size = new System.Drawing.Size(1155, 239);
            this.TabRoundWood.Text = "Gỗ tròn";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARSaleOrderItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Roundwood";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(58, 3);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1094, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 62;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
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
            this.bosLabel18.Location = new System.Drawing.Point(5, 6);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(47, 13);
            this.bosLabel18.TabIndex = 61;
            this.bosLabel18.Text = "Sản phẩm";
            // 
            // RoundWoodGridControl
            // 
            this.RoundWoodGridControl.AllowDrop = true;
            this.RoundWoodGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RoundWoodGridControl.BOSComment = null;
            this.RoundWoodGridControl.BOSDataMember = null;
            this.RoundWoodGridControl.BOSDataSource = "ARSaleOrderItems";
            this.RoundWoodGridControl.BOSDescription = null;
            this.RoundWoodGridControl.BOSError = null;
            this.RoundWoodGridControl.BOSFieldGroup = null;
            this.RoundWoodGridControl.BOSFieldRelation = null;
            this.RoundWoodGridControl.BOSGridType = null;
            this.RoundWoodGridControl.BOSPrivilege = null;
            this.RoundWoodGridControl.BOSPropertyName = null;
            this.RoundWoodGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RoundWoodGridControl.Location = new System.Drawing.Point(0, 29);
            this.RoundWoodGridControl.MainView = this.gridView3;
            this.RoundWoodGridControl.Name = "RoundWoodGridControl";
            this.RoundWoodGridControl.PrintReport = false;
            this.RoundWoodGridControl.Screen = null;
            this.RoundWoodGridControl.Size = new System.Drawing.Size(1155, 207);
            this.RoundWoodGridControl.TabIndex = 3;
            this.RoundWoodGridControl.Tag = "DC";
            this.RoundWoodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.RoundWoodGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARSaleOrderPaymentTimes);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1155, 239);
            this.xtraTabPage2.Text = "Danh sách đợt thanh toán";
            // 
            // fld_dgcARSaleOrderPaymentTimes
            // 
            this.fld_dgcARSaleOrderPaymentTimes.AllowDrop = true;
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
            this.fld_dgcARSaleOrderPaymentTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderPaymentTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderPaymentTimes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARSaleOrderPaymentTimes.MainView = this.gridView1;
            this.fld_dgcARSaleOrderPaymentTimes.Name = "fld_dgcARSaleOrderPaymentTimes";
            this.fld_dgcARSaleOrderPaymentTimes.PrintReport = false;
            this.fld_dgcARSaleOrderPaymentTimes.Screen = null;
            this.fld_dgcARSaleOrderPaymentTimes.Size = new System.Drawing.Size(1155, 239);
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
            // fld_Line4
            // 
            this.fld_Line4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fld_Line4.Location = new System.Drawing.Point(359, 498);
            this.fld_Line4.Name = "fld_Line4";
            this.fld_Line4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line4, true);
            this.fld_Line4.Size = new System.Drawing.Size(407, 222);
            this.fld_Line4.TabIndex = 29;
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
            this.bosLabel29.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel29.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel28.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel28.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel26.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel26.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel25.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_lblLabel36.Size = new System.Drawing.Size(100, 13);
            this.fld_lblLabel36.TabIndex = 1;
            this.fld_lblLabel36.Text = "Địa chỉ nhận hàng";
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
            // fld_lkeARSaleOrderBatchStatus
            // 
            this.fld_lkeARSaleOrderBatchStatus.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderBatchStatus.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderBatchStatus.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSDataMember = "ARSaleOrderBatchStatus";
            this.fld_lkeARSaleOrderBatchStatus.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderBatchStatus.BOSDescription = null;
            this.fld_lkeARSaleOrderBatchStatus.BOSError = null;
            this.fld_lkeARSaleOrderBatchStatus.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderBatchStatus.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.Location = new System.Drawing.Point(1000, 140);
            this.fld_lkeARSaleOrderBatchStatus.Name = "fld_lkeARSaleOrderBatchStatus";
            this.fld_lkeARSaleOrderBatchStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARSaleOrderBatchStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderBatchStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderBatchStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderBatchStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderBatchStatus.Properties.ReadOnly = true;
            this.fld_lkeARSaleOrderBatchStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderBatchStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderBatchStatus, true);
            this.fld_lkeARSaleOrderBatchStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderBatchStatus.TabIndex = 26;
            this.fld_lkeARSaleOrderBatchStatus.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(918, 142);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(64, 13);
            this.bosLabel20.TabIndex = 128;
            this.bosLabel20.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.Text = "Tình trạng SX";
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
            this.bosLabel6.Location = new System.Drawing.Point(641, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(96, 13);
            this.bosLabel6.TabIndex = 126;
            this.bosLabel6.Text = "Hình thức giao hàng";
            // 
            // fld_lkeARShippingType
            // 
            this.fld_lkeARShippingType.BOSAllowAddNew = false;
            this.fld_lkeARShippingType.BOSAllowDummy = true;
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
            this.fld_lkeARShippingType.Location = new System.Drawing.Point(743, 35);
            this.fld_lkeARShippingType.Name = "fld_lkeARShippingType";
            this.fld_lkeARShippingType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARShippingType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARShippingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARShippingType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARShippingType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARShippingType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARShippingType, true);
            this.fld_lkeARShippingType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARShippingType.TabIndex = 15;
            this.fld_lkeARShippingType.Tag = "DC";
            // 
            // fld_lkeARSaleOrderStatus1
            // 
            this.fld_lkeARSaleOrderStatus1.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderStatus1.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderStatus1.BOSComment = null;
            this.fld_lkeARSaleOrderStatus1.BOSDataMember = "ARSaleOrderStatus";
            this.fld_lkeARSaleOrderStatus1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderStatus1.BOSDescription = null;
            this.fld_lkeARSaleOrderStatus1.BOSError = null;
            this.fld_lkeARSaleOrderStatus1.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderStatus1.BOSFieldParent = null;
            this.fld_lkeARSaleOrderStatus1.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderStatus1.BOSPrivilege = null;
            this.fld_lkeARSaleOrderStatus1.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderStatus1.BOSSelectType = null;
            this.fld_lkeARSaleOrderStatus1.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderStatus1.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderStatus1.Location = new System.Drawing.Point(1000, 61);
            this.fld_lkeARSaleOrderStatus1.MenuManager = this.screenToolbar;
            this.fld_lkeARSaleOrderStatus1.Name = "fld_lkeARSaleOrderStatus1";
            this.fld_lkeARSaleOrderStatus1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARSaleOrderStatus1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderStatus1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderStatus1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderStatus1.Properties.ReadOnly = true;
            this.fld_lkeARSaleOrderStatus1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderStatus1.Screen = null;
            this.fld_lkeARSaleOrderStatus1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderStatus1.TabIndex = 23;
            this.fld_lkeARSaleOrderStatus1.Tag = "DC";
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
            this.fld_txtARSaleOrderContQty.Location = new System.Drawing.Point(469, 139);
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
            this.fld_txtARSaleOrderContQty.TabIndex = 11;
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
            this.fld_lblContQty.Location = new System.Drawing.Point(375, 142);
            this.fld_lblContQty.Name = "fld_lblContQty";
            this.fld_lblContQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblContQty, true);
            this.fld_lblContQty.Size = new System.Drawing.Size(68, 13);
            this.fld_lblContQty.TabIndex = 123;
            this.fld_lblContQty.Text = "Số lượng Cont";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ARAssociatedSellerID";
            this.bosLookupEdit1.BOSDataSource = "ARSaleOrders";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(743, 61);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", 150, "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Người giao hàng")});
            this.bosLookupEdit1.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 16;
            this.bosLookupEdit1.Tag = "DC";
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
            this.fld_lbWoodType.Location = new System.Drawing.Point(375, 90);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 121;
            this.fld_lbWoodType.Text = "TTMT";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(469, 87);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 9;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // fld_chkARSaleOrderPortTranShipment
            // 
            this.fld_chkARSaleOrderPortTranShipment.BOSComment = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSDataMember = "ARSaleOrderPortTranShipment";
            this.fld_chkARSaleOrderPortTranShipment.BOSDataSource = "ARSaleOrders";
            this.fld_chkARSaleOrderPortTranShipment.BOSDescription = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSError = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSFieldGroup = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSFieldRelation = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSPrivilege = null;
            this.fld_chkARSaleOrderPortTranShipment.BOSPropertyName = "EditValue";
            this.fld_chkARSaleOrderPortTranShipment.Location = new System.Drawing.Point(1060, 166);
            this.fld_chkARSaleOrderPortTranShipment.MenuManager = this.screenToolbar;
            this.fld_chkARSaleOrderPortTranShipment.Name = "fld_chkARSaleOrderPortTranShipment";
            this.fld_chkARSaleOrderPortTranShipment.Properties.Caption = "Tran shipment";
            this.fld_chkARSaleOrderPortTranShipment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkARSaleOrderPortTranShipment, true);
            this.fld_chkARSaleOrderPortTranShipment.Size = new System.Drawing.Size(93, 19);
            this.fld_chkARSaleOrderPortTranShipment.TabIndex = 28;
            this.fld_chkARSaleOrderPortTranShipment.Tag = "DC";
            // 
            // fld_chkARSaleOrderPortPartialShipment
            // 
            this.fld_chkARSaleOrderPortPartialShipment.BOSComment = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSDataMember = "ARSaleOrderPortPartialShipment";
            this.fld_chkARSaleOrderPortPartialShipment.BOSDataSource = "ARSaleOrders";
            this.fld_chkARSaleOrderPortPartialShipment.BOSDescription = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSError = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSFieldGroup = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSFieldRelation = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSPrivilege = null;
            this.fld_chkARSaleOrderPortPartialShipment.BOSPropertyName = "EditValue";
            this.fld_chkARSaleOrderPortPartialShipment.Location = new System.Drawing.Point(919, 165);
            this.fld_chkARSaleOrderPortPartialShipment.MenuManager = this.screenToolbar;
            this.fld_chkARSaleOrderPortPartialShipment.Name = "fld_chkARSaleOrderPortPartialShipment";
            this.fld_chkARSaleOrderPortPartialShipment.Properties.Caption = "Partial shipment";
            this.fld_chkARSaleOrderPortPartialShipment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkARSaleOrderPortPartialShipment, true);
            this.fld_chkARSaleOrderPortPartialShipment.Size = new System.Drawing.Size(107, 19);
            this.fld_chkARSaleOrderPortPartialShipment.TabIndex = 27;
            this.fld_chkARSaleOrderPortPartialShipment.Tag = "DC";
            // 
            // fld_txtARSaleOrderPONo
            // 
            this.fld_txtARSaleOrderPONo.BOSComment = null;
            this.fld_txtARSaleOrderPONo.BOSDataMember = "ARSaleOrderPONo";
            this.fld_txtARSaleOrderPONo.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderPONo.BOSDescription = null;
            this.fld_txtARSaleOrderPONo.BOSError = null;
            this.fld_txtARSaleOrderPONo.BOSFieldGroup = null;
            this.fld_txtARSaleOrderPONo.BOSFieldRelation = null;
            this.fld_txtARSaleOrderPONo.BOSPrivilege = null;
            this.fld_txtARSaleOrderPONo.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderPONo.Location = new System.Drawing.Point(743, 165);
            this.fld_txtARSaleOrderPONo.Name = "fld_txtARSaleOrderPONo";
            this.fld_txtARSaleOrderPONo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderPONo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderPONo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderPONo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderPONo.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderPONo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderPONo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderPONo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleOrderPONo, true);
            this.fld_txtARSaleOrderPONo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderPONo.TabIndex = 20;
            this.fld_txtARSaleOrderPONo.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(641, 168);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(33, 13);
            this.bosLabel23.TabIndex = 120;
            this.bosLabel23.Text = "Số P.O";
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
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(1000, 35);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", 150, "Điều khoản thanh toán")});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 22;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            this.fld_lkeFK_GEPaymentTermID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEPaymentTermID_CloseUp);
            // 
            // fld_lbPaymentTerm
            // 
            this.fld_lbPaymentTerm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTerm.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTerm.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTerm.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTerm.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSDescription = null;
            this.fld_lbPaymentTerm.BOSError = null;
            this.fld_lbPaymentTerm.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.BOSPropertyName = null;
            this.fld_lbPaymentTerm.Location = new System.Drawing.Point(918, 38);
            this.fld_lbPaymentTerm.Name = "fld_lbPaymentTerm";
            this.fld_lbPaymentTerm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbPaymentTerm, true);
            this.fld_lbPaymentTerm.Size = new System.Drawing.Size(69, 13);
            this.fld_lbPaymentTerm.TabIndex = 111;
            this.fld_lbPaymentTerm.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTerm.Text = "Điều khoản TT";
            // 
            // fld_lblLabelSaleOrderType
            // 
            this.fld_lblLabelSaleOrderType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleOrderType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleOrderType.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelSaleOrderType.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelSaleOrderType.BOSComment = null;
            this.fld_lblLabelSaleOrderType.BOSDataMember = null;
            this.fld_lblLabelSaleOrderType.BOSDataSource = null;
            this.fld_lblLabelSaleOrderType.BOSDescription = null;
            this.fld_lblLabelSaleOrderType.BOSError = null;
            this.fld_lblLabelSaleOrderType.BOSFieldGroup = null;
            this.fld_lblLabelSaleOrderType.BOSFieldRelation = null;
            this.fld_lblLabelSaleOrderType.BOSPrivilege = null;
            this.fld_lblLabelSaleOrderType.BOSPropertyName = null;
            this.fld_lblLabelSaleOrderType.Location = new System.Drawing.Point(116, 90);
            this.fld_lblLabelSaleOrderType.Name = "fld_lblLabelSaleOrderType";
            this.fld_lblLabelSaleOrderType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelSaleOrderType, true);
            this.fld_lblLabelSaleOrderType.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabelSaleOrderType.TabIndex = 105;
            this.fld_lblLabelSaleOrderType.Text = "Loại đơn hàng";
            // 
            // fld_lkeARSaleOrderType
            // 
            this.fld_lkeARSaleOrderType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderType.BOSAllowDummy = false;
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
            this.fld_lkeARSaleOrderType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderType.Location = new System.Drawing.Point(210, 87);
            this.fld_lkeARSaleOrderType.Name = "fld_lkeARSaleOrderType";
            this.fld_lkeARSaleOrderType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderType, true);
            this.fld_lkeARSaleOrderType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderType.TabIndex = 3;
            this.fld_lkeARSaleOrderType.Tag = "DC";
            this.fld_lkeARSaleOrderType.EditValueChanged += new System.EventHandler(this.fld_lkeARSaleOrderType_EditValueChanged);
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
            this.fld_txtARSaleOrderTotalProduct.Location = new System.Drawing.Point(469, 113);
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
            this.fld_txtARSaleOrderTotalProduct.TabIndex = 10;
            this.fld_txtARSaleOrderTotalProduct.Tag = "DC";
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
            this.bosLabel32.Location = new System.Drawing.Point(375, 116);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel32, true);
            this.bosLabel32.Size = new System.Drawing.Size(60, 13);
            this.bosLabel32.TabIndex = 103;
            this.bosLabel32.Text = "SL sản phẩm";
            // 
            // fld_txtARSaleOrderPortOFDischarge
            // 
            this.fld_txtARSaleOrderPortOFDischarge.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderPortOFDischarge.BOSDataMember = "ARSaleOrderPortOFDischarge";
            this.fld_txtARSaleOrderPortOFDischarge.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderPortOFDischarge.BOSDescription = null;
            this.fld_txtARSaleOrderPortOFDischarge.BOSError = null;
            this.fld_txtARSaleOrderPortOFDischarge.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderPortOFDischarge.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderPortOFDischarge.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderPortOFDischarge.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderPortOFDischarge.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderPortOFDischarge.Location = new System.Drawing.Point(743, 139);
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
            this.fld_txtARSaleOrderPortOFDischarge.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderPortOFDischarge.TabIndex = 19;
            this.fld_txtARSaleOrderPortOFDischarge.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(641, 142);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(50, 13);
            this.bosLabel24.TabIndex = 98;
            this.bosLabel24.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.Text = "Cảng xuất";
            // 
            // fld_txtARSaleOrderReference
            // 
            this.fld_txtARSaleOrderReference.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderReference.BOSDataMember = "ARSaleOrderReference";
            this.fld_txtARSaleOrderReference.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderReference.BOSDescription = null;
            this.fld_txtARSaleOrderReference.BOSError = null;
            this.fld_txtARSaleOrderReference.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderReference.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderReference.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderReference.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderReference.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderReference.Location = new System.Drawing.Point(469, 61);
            this.fld_txtARSaleOrderReference.Name = "fld_txtARSaleOrderReference";
            this.fld_txtARSaleOrderReference.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderReference.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderReference.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleOrderReference, true);
            this.fld_txtARSaleOrderReference.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderReference.TabIndex = 8;
            this.fld_txtARSaleOrderReference.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(375, 64);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(65, 13);
            this.bosLabel22.TabIndex = 80;
            this.bosLabel22.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.Text = "Sale Forecast";
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARSaleOrders";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(210, 139);
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARSaleOrderDesc, true);
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(150, 68);
            this.fld_medARSaleOrderDesc.TabIndex = 5;
            this.fld_medARSaleOrderDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(116, 143);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_txtARSaleOrderExchangeRate2
            // 
            this.fld_txtARSaleOrderExchangeRate2.BOSComment = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSDataMember = "ARSaleOrderExchangeRate2";
            this.fld_txtARSaleOrderExchangeRate2.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderExchangeRate2.BOSDescription = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSError = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSFieldGroup = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSFieldRelation = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSPrivilege = null;
            this.fld_txtARSaleOrderExchangeRate2.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderExchangeRate2.Location = new System.Drawing.Point(1000, 113);
            this.fld_txtARSaleOrderExchangeRate2.Name = "fld_txtARSaleOrderExchangeRate2";
            this.fld_txtARSaleOrderExchangeRate2.Screen = null;
            this.fld_txtARSaleOrderExchangeRate2.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderExchangeRate2.TabIndex = 25;
            this.fld_txtARSaleOrderExchangeRate2.Tag = "DC";
            this.fld_txtARSaleOrderExchangeRate2.Validated += new System.EventHandler(this.fld_txtARSaleOrderExchangeRate2_Validated);
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
            this.fld_txtARSaleOrderExchangeRate.Location = new System.Drawing.Point(743, 113);
            this.fld_txtARSaleOrderExchangeRate.Name = "fld_txtARSaleOrderExchangeRate";
            this.fld_txtARSaleOrderExchangeRate.Screen = null;
            this.fld_txtARSaleOrderExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderExchangeRate.TabIndex = 18;
            this.fld_txtARSaleOrderExchangeRate.Tag = "DC";
            this.fld_txtARSaleOrderExchangeRate.Validated += new System.EventHandler(this.fld_txtARSaleOrderExchangeRate_Validated);
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
            this.bosLabel31.Location = new System.Drawing.Point(918, 116);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(38, 13);
            this.bosLabel31.TabIndex = 72;
            this.bosLabel31.Text = "Tỷ giá 2";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(641, 116);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 72;
            this.bosLabel12.Text = "Tỷ giá";
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
            this.bosLabel30.Location = new System.Drawing.Point(918, 90);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(62, 13);
            this.bosLabel30.TabIndex = 72;
            this.bosLabel30.Text = "Loại tiền tệ 2";
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
            this.bosLabel11.Location = new System.Drawing.Point(641, 90);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 72;
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(641, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(78, 13);
            this.bosLabel1.TabIndex = 72;
            this.bosLabel1.Text = "Người giao hàng";
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
            this.fld_txtARSaleOrderCustomerCommissionPercent.Location = new System.Drawing.Point(975, 692);
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
            this.fld_txtARSaleOrderCustomerCommissionPercent.TabIndex = 40;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Tag = "DC";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Visible = false;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Validated += new System.EventHandler(this.fld_txtARSaleOrderCustomerCommissionPercent_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(896, 695);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 48;
            this.bosLabel2.Text = "Hoa hồng";
            this.bosLabel2.Visible = false;
            // 
            // fld_lkeFK_GECurrencyID2
            // 
            this.fld_lkeFK_GECurrencyID2.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID2.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID2.BOSComment = null;
            this.fld_lkeFK_GECurrencyID2.BOSDataMember = "FK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_GECurrencyID2.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID2.BOSError = null;
            this.fld_lkeFK_GECurrencyID2.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID2.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID2.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID2.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID2.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID2.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID2.Location = new System.Drawing.Point(1000, 87);
            this.fld_lkeFK_GECurrencyID2.Name = "fld_lkeFK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID2.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID2.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID2.Properties.ReadOnly = true;
            this.fld_lkeFK_GECurrencyID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID2.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID2.Screen = null;
            this.fld_lkeFK_GECurrencyID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID2.TabIndex = 24;
            this.fld_lkeFK_GECurrencyID2.Tag = "DC";
            this.fld_lkeFK_GECurrencyID2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID2_CloseUp);
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(743, 87);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 17;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.fld_txtARSaleOrderSOCommissionAmount.Location = new System.Drawing.Point(1053, 692);
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
            this.fld_txtARSaleOrderSOCommissionAmount.TabIndex = 2;
            this.fld_txtARSaleOrderSOCommissionAmount.Tag = "DC";
            this.fld_txtARSaleOrderSOCommissionAmount.Visible = false;
            this.fld_txtARSaleOrderSOCommissionAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderSOCommissionAmount_Validated);
            // 
            // DMSOFW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSOFW100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo1.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderInternalComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.TabLumber.ResumeLayout(false);
            this.TabLumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LumberGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.TabRoundWood.ResumeLayout(false);
            this.TabRoundWood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundWoodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_Line4.ResumeLayout(false);
            this.fld_Line4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderBatchStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderStatus1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderContQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPortTranShipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARSaleOrderPortPartialShipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderPortOFDischarge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderDepositBalance;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderBalanceDue;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo1;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderInternalComment;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSOContactName;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTaxAmount;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkViewDiffPrice;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderCustomerCommissionPercent;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSOCommissionAmount;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderReference;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderPortOFDischarge;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalProduct;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLabel fld_lblLabelSaleOrderType;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel fld_lbPaymentTerm;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSCheckEdit fld_chkARSaleOrderPortTranShipment;
        private BOSComponent.BOSCheckEdit fld_chkARSaleOrderPortPartialShipment;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderPONo;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderContQty;
        private BOSComponent.BOSLabel fld_lblContQty;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderStatus1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeARShippingType;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderBatchStatus;
        private BOSComponent.BOSLabel bosLabel20;
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
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ARSaleOrderPaymentTimesGridControl fld_dgcARSaleOrderPaymentTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private DevExpress.XtraTab.XtraTabPage TabLumber;
        private LumberItemsGridControl LumberGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage TabRoundWood;
        private RoundWoodtemsGridControl RoundWoodGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSLabel bosLabel17;
        private ItemLookupEdit itemLookupEdit1;
        private BOSComponent.BOSLabel bosLabel18;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderProductType;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderExchangeRate2;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID2;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID1;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSaleAgreement;
        private BOSComponent.BOSLabel bosLabel34;
    }
}
