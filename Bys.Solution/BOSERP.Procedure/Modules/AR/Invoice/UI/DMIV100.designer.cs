using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Invoice.UI
{
    /// <summary>
    /// Summary description for DMIV100
    /// </summary>
    partial class DMIV100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMIV100));
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.arInvoiceItemsGridControl1 = new BOSERP.Modules.Invoice.ARInvoiceItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemLookupEdit1 = new BOSERP.ItemLookupEdit(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.baseDocumentEntryGridControl1 = new BOSERP.BaseDocumentEntryGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddCost = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemCosts = new BOSERP.Modules.SaleOrder.ARSaleOrderItemCostGridControl();
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARInvoiceSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_medARInvoiceComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_medARInvoiceInternalComment = new BOSComponent.BOSMemoEdit(this.components);
            this.BOSLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_Line4 = new BOSComponent.BOSLine(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnEditShippingInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_tabInvoiceItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pteARInvoiceItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARInvoiceItems = new BOSERP.Modules.Invoice.ARInvoiceItemsGridControl();
            this.fld_dgvARInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_tabPageInvoiceCost = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARInvoiceItemCosts = new BOSERP.Modules.Invoice.ARInvoiceItemCostGridControl();
            this.fld_tabPageInvoiceCommission = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcCommissionsGridControl = new BOSERP.Modules.Invoice.ARInvoiceCommissionsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATPaymentContactInformation = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceSOContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAROutputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARInvoiceValidateDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel85 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARInvoiceProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARInvoiceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteARInvoiceDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARInvoiceStatus1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARInvoiceEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderCustomerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderSOCommissionAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_txtARInvoiceWaybillNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoicePortEndShipmentText = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoicePortOFDischarge = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GETerminalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arInvoiceItemsGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookupEdit1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDocumentEntryGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceComment.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceInternalComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).BeginInit();
            this.fld_Line4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).BeginInit();
            this.fld_tabInvoiceItems.SuspendLayout();
            this.fld_tabPageInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            this.fld_tabPageInvoiceCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItemCosts)).BeginInit();
            this.fld_tabPageInvoiceCommission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommissionsGridControl)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATPaymentContactInformation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceValidateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceWaybillNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoicePortEndShipmentText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoicePortOFDischarge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPictureEdit1);
            this.xtraTabPage1.Controls.Add(this.bosLabel2);
            this.xtraTabPage1.Controls.Add(this.arInvoiceItemsGridControl1);
            this.xtraTabPage1.Controls.Add(this.itemLookupEdit1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(984, 270);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // bosPictureEdit1
            // 
            this.bosPictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPictureEdit1.BOSComment = "";
            this.bosPictureEdit1.BOSDataMember = "ARInvoiceItemProductPicture";
            this.bosPictureEdit1.BOSDataSource = "ARInvoiceItems";
            this.bosPictureEdit1.BOSDescription = null;
            this.bosPictureEdit1.BOSError = null;
            this.bosPictureEdit1.BOSFieldGroup = "";
            this.bosPictureEdit1.BOSFieldRelation = "";
            this.bosPictureEdit1.BOSPrivilege = "";
            this.bosPictureEdit1.BOSPropertyName = "EditValue";
            this.bosPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit1.EditValue = "";
            this.bosPictureEdit1.FileName = null;
            this.bosPictureEdit1.FilePath = null;
            this.bosPictureEdit1.Location = new System.Drawing.Point(840, 3);
            this.bosPictureEdit1.Name = "bosPictureEdit1";
            this.bosPictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosPictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosPictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit1.Screen = null;
            this.bosPictureEdit1.Size = new System.Drawing.Size(141, 140);
            this.bosPictureEdit1.TabIndex = 1;
            this.bosPictureEdit1.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(7, 8);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 57;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Sản phẩm";
            // 
            // arInvoiceItemsGridControl1
            // 
            this.arInvoiceItemsGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arInvoiceItemsGridControl1.BOSComment = null;
            this.arInvoiceItemsGridControl1.BOSDataMember = null;
            this.arInvoiceItemsGridControl1.BOSDataSource = "ARInvoiceItems";
            this.arInvoiceItemsGridControl1.BOSDescription = null;
            this.arInvoiceItemsGridControl1.BOSError = null;
            this.arInvoiceItemsGridControl1.BOSFieldGroup = null;
            this.arInvoiceItemsGridControl1.BOSFieldRelation = null;
            this.arInvoiceItemsGridControl1.BOSGridType = null;
            this.arInvoiceItemsGridControl1.BOSPrivilege = null;
            this.arInvoiceItemsGridControl1.BOSPropertyName = null;
            this.arInvoiceItemsGridControl1.CommodityType = "";
            this.arInvoiceItemsGridControl1.Location = new System.Drawing.Point(3, 31);
            this.arInvoiceItemsGridControl1.MainView = this.gridView1;
            this.arInvoiceItemsGridControl1.Name = "arInvoiceItemsGridControl1";
            this.arInvoiceItemsGridControl1.PrintReport = false;
            this.arInvoiceItemsGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.arInvoiceItemsGridControl1.Screen = null;
            this.arInvoiceItemsGridControl1.Size = new System.Drawing.Size(831, 236);
            this.arInvoiceItemsGridControl1.TabIndex = 2;
            this.arInvoiceItemsGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.arInvoiceItemsGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // itemLookupEdit1
            // 
            this.itemLookupEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemLookupEdit1.BOSAllowAddNew = false;
            this.itemLookupEdit1.BOSAllowDummy = false;
            this.itemLookupEdit1.BOSComment = "";
            this.itemLookupEdit1.BOSDataMember = "FK_ICProductID";
            this.itemLookupEdit1.BOSDataSource = "ARInvoiceItems";
            this.itemLookupEdit1.BOSDescription = null;
            this.itemLookupEdit1.BOSError = null;
            this.itemLookupEdit1.BOSFieldGroup = "";
            this.itemLookupEdit1.BOSFieldParent = "";
            this.itemLookupEdit1.BOSFieldRelation = "";
            this.itemLookupEdit1.BOSPrivilege = "";
            this.itemLookupEdit1.BOSPropertyName = "EditValue";
            this.itemLookupEdit1.BOSSelectType = "";
            this.itemLookupEdit1.BOSSelectTypeValue = "";
            this.itemLookupEdit1.CurrentDisplayText = "";
            this.itemLookupEdit1.Location = new System.Drawing.Point(60, 5);
            this.itemLookupEdit1.Name = "itemLookupEdit1";
            this.itemLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.itemLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.itemLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookupEdit1.Properties.ColumnName = null;
            this.itemLookupEdit1.Properties.DisplayMember = "ICProductNo";
            this.itemLookupEdit1.Properties.NullText = "";
            this.itemLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemLookupEdit1.Properties.ValueMember = "ICProductID";
            this.itemLookupEdit1.Screen = null;
            this.itemLookupEdit1.Size = new System.Drawing.Size(774, 20);
            this.itemLookupEdit1.TabIndex = 0;
            this.itemLookupEdit1.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.baseDocumentEntryGridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(984, 270);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // baseDocumentEntryGridControl1
            // 
            this.baseDocumentEntryGridControl1.AllowDrop = true;
            this.baseDocumentEntryGridControl1.BOSComment = "";
            this.baseDocumentEntryGridControl1.BOSDataMember = "";
            this.baseDocumentEntryGridControl1.BOSDataSource = "ACDocumentEntrys";
            this.baseDocumentEntryGridControl1.BOSDescription = null;
            this.baseDocumentEntryGridControl1.BOSError = null;
            this.baseDocumentEntryGridControl1.BOSFieldGroup = "";
            this.baseDocumentEntryGridControl1.BOSFieldRelation = "";
            this.baseDocumentEntryGridControl1.BOSGridType = null;
            this.baseDocumentEntryGridControl1.BOSPrivilege = "";
            this.baseDocumentEntryGridControl1.BOSPropertyName = "";
            this.baseDocumentEntryGridControl1.CommodityType = "";
            this.baseDocumentEntryGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDocumentEntryGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.baseDocumentEntryGridControl1.Location = new System.Drawing.Point(0, 0);
            this.baseDocumentEntryGridControl1.MainView = this.gridView2;
            this.baseDocumentEntryGridControl1.Name = "baseDocumentEntryGridControl1";
            this.baseDocumentEntryGridControl1.PrintReport = false;
            this.baseDocumentEntryGridControl1.Screen = null;
            this.baseDocumentEntryGridControl1.Size = new System.Drawing.Size(984, 270);
            this.baseDocumentEntryGridControl1.TabIndex = 1;
            this.baseDocumentEntryGridControl1.Tag = "DC";
            this.baseDocumentEntryGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.baseDocumentEntryGridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.fld_dgcARSaleOrderItemCosts.Size = new System.Drawing.Size(1342, 170);
            this.fld_dgcARSaleOrderItemCosts.TabIndex = 1;
            // 
            // fld_lblLabel43
            // 
            this.fld_lblLabel43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel43.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel43.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel43.BOSComment = "";
            this.fld_lblLabel43.BOSDataMember = "";
            this.fld_lblLabel43.BOSDataSource = "";
            this.fld_lblLabel43.BOSDescription = null;
            this.fld_lblLabel43.BOSError = null;
            this.fld_lblLabel43.BOSFieldGroup = "";
            this.fld_lblLabel43.BOSFieldRelation = "";
            this.fld_lblLabel43.BOSPrivilege = "";
            this.fld_lblLabel43.BOSPropertyName = null;
            this.fld_lblLabel43.Location = new System.Drawing.Point(974, 712);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
            this.fld_lblLabel43.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel43.TabIndex = 45;
            this.fld_lblLabel43.Tag = "";
            this.fld_lblLabel43.Text = "Mức giá";
            this.fld_lblLabel43.Visible = false;
            // 
            // fld_txtARInvoiceTaxPercent
            // 
            this.fld_txtARInvoiceTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTaxPercent.BOSComment = "";
            this.fld_txtARInvoiceTaxPercent.BOSDataMember = "ARInvoiceTaxPercent";
            this.fld_txtARInvoiceTaxPercent.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTaxPercent.BOSDescription = null;
            this.fld_txtARInvoiceTaxPercent.BOSError = null;
            this.fld_txtARInvoiceTaxPercent.BOSFieldGroup = "";
            this.fld_txtARInvoiceTaxPercent.BOSFieldRelation = "";
            this.fld_txtARInvoiceTaxPercent.BOSPrivilege = "";
            this.fld_txtARInvoiceTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceTaxPercent.EditValue = "";
            this.fld_txtARInvoiceTaxPercent.Location = new System.Drawing.Point(1028, 840);
            this.fld_txtARInvoiceTaxPercent.Name = "fld_txtARInvoiceTaxPercent";
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTaxPercent.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceTaxPercent.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTaxPercent.Screen = null;
            this.fld_txtARInvoiceTaxPercent.Size = new System.Drawing.Size(70, 20);
            this.fld_txtARInvoiceTaxPercent.TabIndex = 6;
            this.fld_txtARInvoiceTaxPercent.Tag = "DC";
            this.fld_txtARInvoiceTaxPercent.Validated += new System.EventHandler(this.fld_txtARInvoiceTaxPercent_Validated);
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = "";
            this.fld_lblLabel44.BOSDataMember = "";
            this.fld_lblLabel44.BOSDataSource = "";
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = "";
            this.fld_lblLabel44.BOSFieldRelation = "";
            this.fld_lblLabel44.BOSPrivilege = "";
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(961, 738);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 46;
            this.fld_lblLabel44.Tag = "";
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = false;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = "";
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = null;
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(1028, 709);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.NullText = "";
            this.fld_lkeFK_ARPriceLevelID.Properties.PopupWidth = 20;
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(175, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 1;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.Visible = false;
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_txtARInvoiceSubTotalAmount
            // 
            this.fld_txtARInvoiceSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceSubTotalAmount.BOSComment = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSDataMember = "ARInvoiceSubTotalAmount";
            this.fld_txtARInvoiceSubTotalAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceSubTotalAmount.BOSDescription = null;
            this.fld_txtARInvoiceSubTotalAmount.BOSError = null;
            this.fld_txtARInvoiceSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceSubTotalAmount.EditValue = "0.00";
            this.fld_txtARInvoiceSubTotalAmount.Location = new System.Drawing.Point(1028, 735);
            this.fld_txtARInvoiceSubTotalAmount.Name = "fld_txtARInvoiceSubTotalAmount";
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceSubTotalAmount.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARInvoiceSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSubTotalAmount.Screen = null;
            this.fld_txtARInvoiceSubTotalAmount.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARInvoiceSubTotalAmount.TabIndex = 2;
            this.fld_txtARInvoiceSubTotalAmount.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(958, 843);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 72;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Thuế GTGT";
            // 
            // BOSLabel8
            // 
            this.BOSLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel8.Appearance.Options.UseBackColor = true;
            this.BOSLabel8.Appearance.Options.UseFont = true;
            this.BOSLabel8.Appearance.Options.UseForeColor = true;
            this.BOSLabel8.BOSComment = "";
            this.BOSLabel8.BOSDataMember = "";
            this.BOSLabel8.BOSDataSource = "";
            this.BOSLabel8.BOSDescription = null;
            this.BOSLabel8.BOSError = null;
            this.BOSLabel8.BOSFieldGroup = "";
            this.BOSLabel8.BOSFieldRelation = "";
            this.BOSLabel8.BOSPrivilege = "";
            this.BOSLabel8.BOSPropertyName = null;
            this.BOSLabel8.Location = new System.Drawing.Point(969, 896);
            this.BOSLabel8.Name = "BOSLabel8";
            this.BOSLabel8.Screen = null;
            this.BOSLabel8.Size = new System.Drawing.Size(43, 13);
            this.BOSLabel8.TabIndex = 49;
            this.BOSLabel8.Tag = "";
            this.BOSLabel8.Text = "ĐÃ TRẢ";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = "";
            this.fld_lblLabel46.BOSDataMember = "";
            this.fld_lblLabel46.BOSDataSource = "";
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = "";
            this.fld_lblLabel46.BOSFieldRelation = "";
            this.fld_lblLabel46.BOSPrivilege = "";
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(960, 790);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel46.TabIndex = 48;
            this.fld_lblLabel46.Tag = "";
            this.fld_lblLabel46.Text = "Chiết khấu";
            // 
            // fld_Line3
            // 
            this.fld_Line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_Line3.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.BOSComment = "";
            this.fld_Line3.BOSDataMember = "";
            this.fld_Line3.BOSDataSource = "";
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = "";
            this.fld_Line3.BOSFieldRelation = "";
            this.fld_Line3.BOSPrivilege = "";
            this.fld_Line3.BOSPropertyName = null;
            this.fld_Line3.Controls.Add(this.fld_medARInvoiceComment);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(8, 710);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(300, 119);
            this.fld_Line3.TabIndex = 3;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Tag = "";
            this.fld_Line3.Text = "Ghi chú in ra";
            // 
            // fld_medARInvoiceComment
            // 
            this.fld_medARInvoiceComment.BOSComment = null;
            this.fld_medARInvoiceComment.BOSDataMember = "ARInvoiceComment";
            this.fld_medARInvoiceComment.BOSDataSource = "ARInvoices";
            this.fld_medARInvoiceComment.BOSDescription = null;
            this.fld_medARInvoiceComment.BOSError = null;
            this.fld_medARInvoiceComment.BOSFieldGroup = null;
            this.fld_medARInvoiceComment.BOSFieldRelation = null;
            this.fld_medARInvoiceComment.BOSPrivilege = null;
            this.fld_medARInvoiceComment.BOSPropertyName = "EditValue";
            this.fld_medARInvoiceComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARInvoiceComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARInvoiceComment.MenuManager = this.screenToolbar;
            this.fld_medARInvoiceComment.Name = "fld_medARInvoiceComment";
            this.fld_medARInvoiceComment.Screen = null;
            this.fld_medARInvoiceComment.Size = new System.Drawing.Size(294, 99);
            this.fld_medARInvoiceComment.TabIndex = 0;
            this.fld_medARInvoiceComment.Tag = "DC";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = "";
            this.bosLine2.BOSDataMember = "";
            this.bosLine2.BOSDataSource = "";
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = "";
            this.bosLine2.BOSFieldRelation = "";
            this.bosLine2.BOSPrivilege = "";
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_medARInvoiceInternalComment);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(8, 832);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(300, 103);
            this.bosLine2.TabIndex = 4;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Ghi chú không in ra";
            // 
            // fld_medARInvoiceInternalComment
            // 
            this.fld_medARInvoiceInternalComment.BOSComment = null;
            this.fld_medARInvoiceInternalComment.BOSDataMember = "ARInvoiceInternalComment";
            this.fld_medARInvoiceInternalComment.BOSDataSource = "ARInvoices";
            this.fld_medARInvoiceInternalComment.BOSDescription = null;
            this.fld_medARInvoiceInternalComment.BOSError = null;
            this.fld_medARInvoiceInternalComment.BOSFieldGroup = null;
            this.fld_medARInvoiceInternalComment.BOSFieldRelation = null;
            this.fld_medARInvoiceInternalComment.BOSPrivilege = null;
            this.fld_medARInvoiceInternalComment.BOSPropertyName = "EditValue";
            this.fld_medARInvoiceInternalComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARInvoiceInternalComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARInvoiceInternalComment.Name = "fld_medARInvoiceInternalComment";
            this.fld_medARInvoiceInternalComment.Screen = null;
            this.fld_medARInvoiceInternalComment.Size = new System.Drawing.Size(294, 83);
            this.fld_medARInvoiceInternalComment.TabIndex = 0;
            this.fld_medARInvoiceInternalComment.Tag = "DC";
            // 
            // BOSLabel9
            // 
            this.BOSLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel9.Appearance.Options.UseBackColor = true;
            this.BOSLabel9.Appearance.Options.UseFont = true;
            this.BOSLabel9.Appearance.Options.UseForeColor = true;
            this.BOSLabel9.BOSComment = "";
            this.BOSLabel9.BOSDataMember = "";
            this.BOSLabel9.BOSDataSource = "";
            this.BOSLabel9.BOSDescription = null;
            this.BOSLabel9.BOSError = null;
            this.BOSLabel9.BOSFieldGroup = "";
            this.BOSLabel9.BOSFieldRelation = "";
            this.BOSLabel9.BOSPrivilege = "";
            this.BOSLabel9.BOSPropertyName = null;
            this.BOSLabel9.Location = new System.Drawing.Point(967, 922);
            this.BOSLabel9.Name = "BOSLabel9";
            this.BOSLabel9.Screen = null;
            this.BOSLabel9.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel9.TabIndex = 49;
            this.BOSLabel9.Tag = "";
            this.BOSLabel9.Text = "CÒN LẠI";
            // 
            // fld_txtARInvoiceDiscountPerCent
            // 
            this.fld_txtARInvoiceDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceDiscountPerCent.BOSComment = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSDataMember = "ARInvoiceDiscountPerCent";
            this.fld_txtARInvoiceDiscountPerCent.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceDiscountPerCent.BOSDescription = null;
            this.fld_txtARInvoiceDiscountPerCent.BOSError = null;
            this.fld_txtARInvoiceDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceDiscountPerCent.EditValue = "0.00";
            this.fld_txtARInvoiceDiscountPerCent.Location = new System.Drawing.Point(1028, 787);
            this.fld_txtARInvoiceDiscountPerCent.Name = "fld_txtARInvoiceDiscountPerCent";
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDiscountPerCent.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceDiscountPerCent.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDiscountPerCent.Screen = null;
            this.fld_txtARInvoiceDiscountPerCent.Size = new System.Drawing.Size(70, 20);
            this.fld_txtARInvoiceDiscountPerCent.TabIndex = 4;
            this.fld_txtARInvoiceDiscountPerCent.Tag = "DC";
            this.fld_txtARInvoiceDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountPerCent_Validated);
            // 
            // fld_txtARInvoiceDiscountFix
            // 
            this.fld_txtARInvoiceDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceDiscountFix.BOSComment = "";
            this.fld_txtARInvoiceDiscountFix.BOSDataMember = "ARInvoiceDiscountFix";
            this.fld_txtARInvoiceDiscountFix.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceDiscountFix.BOSDescription = null;
            this.fld_txtARInvoiceDiscountFix.BOSError = null;
            this.fld_txtARInvoiceDiscountFix.BOSFieldGroup = "";
            this.fld_txtARInvoiceDiscountFix.BOSFieldRelation = "";
            this.fld_txtARInvoiceDiscountFix.BOSPrivilege = "";
            this.fld_txtARInvoiceDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceDiscountFix.EditValue = "0.00";
            this.fld_txtARInvoiceDiscountFix.Location = new System.Drawing.Point(1103, 787);
            this.fld_txtARInvoiceDiscountFix.Name = "fld_txtARInvoiceDiscountFix";
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDiscountFix.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceDiscountFix.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDiscountFix.Screen = null;
            this.fld_txtARInvoiceDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARInvoiceDiscountFix.TabIndex = 5;
            this.fld_txtARInvoiceDiscountFix.Tag = "DC";
            this.fld_txtARInvoiceDiscountFix.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountFix_Validated);
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
            this.fld_lblLabel47.BOSComment = "";
            this.fld_lblLabel47.BOSDataMember = "";
            this.fld_lblLabel47.BOSDataSource = "";
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = "";
            this.fld_lblLabel47.BOSFieldRelation = "";
            this.fld_lblLabel47.BOSPrivilege = "";
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(945, 869);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 49;
            this.fld_lblLabel47.Tag = "";
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtARInvoiceBalanceDue
            // 
            this.fld_txtARInvoiceBalanceDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceBalanceDue.BOSComment = "";
            this.fld_txtARInvoiceBalanceDue.BOSDataMember = "ARInvoiceBalanceDue";
            this.fld_txtARInvoiceBalanceDue.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceBalanceDue.BOSDescription = null;
            this.fld_txtARInvoiceBalanceDue.BOSError = null;
            this.fld_txtARInvoiceBalanceDue.BOSFieldGroup = "";
            this.fld_txtARInvoiceBalanceDue.BOSFieldRelation = "";
            this.fld_txtARInvoiceBalanceDue.BOSPrivilege = "";
            this.fld_txtARInvoiceBalanceDue.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceBalanceDue.EditValue = "0.00";
            this.fld_txtARInvoiceBalanceDue.Location = new System.Drawing.Point(1028, 919);
            this.fld_txtARInvoiceBalanceDue.Name = "fld_txtARInvoiceBalanceDue";
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceBalanceDue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceBalanceDue.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceBalanceDue.Properties.ReadOnly = true;
            this.fld_txtARInvoiceBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceBalanceDue.Screen = null;
            this.fld_txtARInvoiceBalanceDue.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARInvoiceBalanceDue.TabIndex = 10;
            this.fld_txtARInvoiceBalanceDue.Tag = "DC";
            // 
            // fld_txtARInvoiceTaxAmount
            // 
            this.fld_txtARInvoiceTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTaxAmount.BOSComment = "";
            this.fld_txtARInvoiceTaxAmount.BOSDataMember = "ARInvoiceTaxAmount";
            this.fld_txtARInvoiceTaxAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTaxAmount.BOSDescription = null;
            this.fld_txtARInvoiceTaxAmount.BOSError = null;
            this.fld_txtARInvoiceTaxAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceTaxAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceTaxAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceTaxAmount.EditValue = "0.00";
            this.fld_txtARInvoiceTaxAmount.Location = new System.Drawing.Point(1103, 840);
            this.fld_txtARInvoiceTaxAmount.Name = "fld_txtARInvoiceTaxAmount";
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTaxAmount.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTaxAmount.Screen = null;
            this.fld_txtARInvoiceTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARInvoiceTaxAmount.TabIndex = 7;
            this.fld_txtARInvoiceTaxAmount.Tag = "DC";
            this.fld_txtARInvoiceTaxAmount.Validated += new System.EventHandler(this.fld_txtARInvoiceTaxAmount_Validated);
            // 
            // fld_txtARInvoiceDepositBalance
            // 
            this.fld_txtARInvoiceDepositBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceDepositBalance.BOSComment = "";
            this.fld_txtARInvoiceDepositBalance.BOSDataMember = "ARInvoiceDepositBalance";
            this.fld_txtARInvoiceDepositBalance.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceDepositBalance.BOSDescription = null;
            this.fld_txtARInvoiceDepositBalance.BOSError = null;
            this.fld_txtARInvoiceDepositBalance.BOSFieldGroup = "";
            this.fld_txtARInvoiceDepositBalance.BOSFieldRelation = "";
            this.fld_txtARInvoiceDepositBalance.BOSPrivilege = "";
            this.fld_txtARInvoiceDepositBalance.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceDepositBalance.EditValue = "0.00";
            this.fld_txtARInvoiceDepositBalance.Location = new System.Drawing.Point(1028, 893);
            this.fld_txtARInvoiceDepositBalance.Name = "fld_txtARInvoiceDepositBalance";
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDepositBalance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceDepositBalance.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDepositBalance.Screen = null;
            this.fld_txtARInvoiceDepositBalance.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARInvoiceDepositBalance.TabIndex = 9;
            this.fld_txtARInvoiceDepositBalance.Tag = "DC";
            this.fld_txtARInvoiceDepositBalance.Validated += new System.EventHandler(this.fld_txtARInvoiceDepositBalance_Validated);
            // 
            // fld_txtARInvoiceTotalAmount
            // 
            this.fld_txtARInvoiceTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTotalAmount.BOSComment = "";
            this.fld_txtARInvoiceTotalAmount.BOSDataMember = "ARInvoiceTotalAmount";
            this.fld_txtARInvoiceTotalAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTotalAmount.BOSDescription = null;
            this.fld_txtARInvoiceTotalAmount.BOSError = null;
            this.fld_txtARInvoiceTotalAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceTotalAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceTotalAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceTotalAmount.EditValue = "0.00";
            this.fld_txtARInvoiceTotalAmount.Location = new System.Drawing.Point(1028, 866);
            this.fld_txtARInvoiceTotalAmount.Name = "fld_txtARInvoiceTotalAmount";
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTotalAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARInvoiceTotalAmount.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARInvoiceTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTotalAmount.Screen = null;
            this.fld_txtARInvoiceTotalAmount.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARInvoiceTotalAmount.TabIndex = 8;
            this.fld_txtARInvoiceTotalAmount.Tag = "DC";
            // 
            // fld_Line4
            // 
            this.fld_Line4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_Line4.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line4.BOSComment = "";
            this.fld_Line4.BOSDataMember = "";
            this.fld_Line4.BOSDataSource = "";
            this.fld_Line4.BOSDescription = null;
            this.fld_Line4.BOSError = null;
            this.fld_Line4.BOSFieldGroup = "";
            this.fld_Line4.BOSFieldRelation = "";
            this.fld_Line4.BOSPrivilege = "";
            this.fld_Line4.BOSPropertyName = null;
            this.fld_Line4.Controls.Add(this.bosLabel15);
            this.fld_Line4.Controls.Add(this.bosLabel13);
            this.fld_Line4.Controls.Add(this.bosLabel12);
            this.fld_Line4.Controls.Add(this.bosLine1);
            this.fld_Line4.Controls.Add(this.fld_lblLabel34);
            this.fld_Line4.Controls.Add(this.fld_lblLabel42);
            this.fld_Line4.Controls.Add(this.fld_lblLabel36);
            this.fld_Line4.Controls.Add(this.fld_btnEditShippingInfo);
            this.fld_Line4.Controls.Add(this.fld_lblLabel37);
            this.fld_Line4.Controls.Add(this.fld_lblLabel29);
            this.fld_Line4.Controls.Add(this.fld_Line);
            this.fld_Line4.Controls.Add(this.fld_lblLabel30);
            this.fld_Line4.Controls.Add(this.fld_Line1);
            this.fld_Line4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line4.Location = new System.Drawing.Point(314, 706);
            this.fld_Line4.Name = "fld_Line4";
            this.fld_Line4.Screen = null;
            this.fld_Line4.Size = new System.Drawing.Size(372, 229);
            this.fld_Line4.TabIndex = 5;
            this.fld_Line4.TabStop = false;
            this.fld_Line4.Tag = "";
            this.fld_Line4.Text = "Thông tin giao hàng";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "ARInvoicePaymentAddressPostalCode";
            this.bosLabel15.BOSDataSource = "ARInvoices";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(7, 179);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(12, 13);
            this.bosLabel15.TabIndex = 49;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "08";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "ARInvoicePaymentAddressLine3";
            this.bosLabel13.BOSDataSource = "ARInvoices";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(6, 156);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(111, 13);
            this.bosLabel13.TabIndex = 47;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.bosLabel12.Location = new System.Drawing.Point(6, 137);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(85, 13);
            this.bosLabel12.TabIndex = 45;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Địa chỉ thu tiền";
            // 
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = "";
            this.bosLine1.BOSDataMember = "";
            this.bosLine1.BOSDataSource = "";
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = "";
            this.bosLine1.BOSFieldRelation = "";
            this.bosLine1.BOSPrivilege = "";
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(94, 139);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(272, 10);
            this.bosLine1.TabIndex = 46;
            this.bosLine1.TabStop = false;
            this.bosLine1.Tag = "";
            // 
            // fld_lblLabel34
            // 
            this.fld_lblLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel34.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel34.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel34.BOSComment = "";
            this.fld_lblLabel34.BOSDataMember = "ARInvoiceInvoiceAddressPostalCode";
            this.fld_lblLabel34.BOSDataSource = "ARInvoices";
            this.fld_lblLabel34.BOSDescription = null;
            this.fld_lblLabel34.BOSError = null;
            this.fld_lblLabel34.BOSFieldGroup = "";
            this.fld_lblLabel34.BOSFieldRelation = "";
            this.fld_lblLabel34.BOSPrivilege = "";
            this.fld_lblLabel34.BOSPropertyName = null;
            this.fld_lblLabel34.Location = new System.Drawing.Point(8, 58);
            this.fld_lblLabel34.Name = "fld_lblLabel34";
            this.fld_lblLabel34.Screen = null;
            this.fld_lblLabel34.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel34.TabIndex = 35;
            this.fld_lblLabel34.Tag = "";
            this.fld_lblLabel34.Text = "08";
            // 
            // fld_lblLabel42
            // 
            this.fld_lblLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel42.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel42.BOSComment = "";
            this.fld_lblLabel42.BOSDataMember = "ARInvoiceDeliveryAddressPostalCode";
            this.fld_lblLabel42.BOSDataSource = "ARInvoices";
            this.fld_lblLabel42.BOSDescription = null;
            this.fld_lblLabel42.BOSError = null;
            this.fld_lblLabel42.BOSFieldGroup = "";
            this.fld_lblLabel42.BOSFieldRelation = "";
            this.fld_lblLabel42.BOSPrivilege = "";
            this.fld_lblLabel42.BOSPropertyName = null;
            this.fld_lblLabel42.Location = new System.Drawing.Point(8, 117);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.fld_lblLabel42.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel42.TabIndex = 44;
            this.fld_lblLabel42.Tag = "";
            this.fld_lblLabel42.Text = "08";
            // 
            // fld_lblLabel36
            // 
            this.fld_lblLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel36.Appearance.Options.UseFont = true;
            this.fld_lblLabel36.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel36.BOSComment = "";
            this.fld_lblLabel36.BOSDataMember = "";
            this.fld_lblLabel36.BOSDataSource = "";
            this.fld_lblLabel36.BOSDescription = null;
            this.fld_lblLabel36.BOSError = null;
            this.fld_lblLabel36.BOSFieldGroup = "";
            this.fld_lblLabel36.BOSFieldRelation = "";
            this.fld_lblLabel36.BOSPrivilege = "";
            this.fld_lblLabel36.BOSPropertyName = null;
            this.fld_lblLabel36.Location = new System.Drawing.Point(8, 75);
            this.fld_lblLabel36.Name = "fld_lblLabel36";
            this.fld_lblLabel36.Screen = null;
            this.fld_lblLabel36.Size = new System.Drawing.Size(100, 13);
            this.fld_lblLabel36.TabIndex = 37;
            this.fld_lblLabel36.Tag = "";
            this.fld_lblLabel36.Text = "Địa chỉ nhận hàng";
            // 
            // fld_btnEditShippingInfo
            // 
            this.fld_btnEditShippingInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEditShippingInfo.Appearance.Options.UseForeColor = true;
            this.fld_btnEditShippingInfo.BOSComment = "";
            this.fld_btnEditShippingInfo.BOSDataMember = "";
            this.fld_btnEditShippingInfo.BOSDataSource = "";
            this.fld_btnEditShippingInfo.BOSDescription = null;
            this.fld_btnEditShippingInfo.BOSError = null;
            this.fld_btnEditShippingInfo.BOSFieldGroup = "";
            this.fld_btnEditShippingInfo.BOSFieldRelation = "";
            this.fld_btnEditShippingInfo.BOSPrivilege = "";
            this.fld_btnEditShippingInfo.BOSPropertyName = null;
            this.fld_btnEditShippingInfo.Location = new System.Drawing.Point(291, 189);
            this.fld_btnEditShippingInfo.Name = "fld_btnEditShippingInfo";
            this.fld_btnEditShippingInfo.Screen = null;
            this.fld_btnEditShippingInfo.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditShippingInfo.TabIndex = 0;
            this.fld_btnEditShippingInfo.Tag = "";
            this.fld_btnEditShippingInfo.Text = "Sửa";
            this.fld_btnEditShippingInfo.Click += new System.EventHandler(this.fld_btnEditShippingInfo_Click);
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = "";
            this.fld_lblLabel37.BOSDataMember = "ARInvoiceDeliveryAddressLine3";
            this.fld_lblLabel37.BOSDataSource = "ARInvoices";
            this.fld_lblLabel37.BOSDescription = null;
            this.fld_lblLabel37.BOSError = null;
            this.fld_lblLabel37.BOSFieldGroup = "";
            this.fld_lblLabel37.BOSFieldRelation = "";
            this.fld_lblLabel37.BOSPrivilege = "";
            this.fld_lblLabel37.BOSPropertyName = null;
            this.fld_lblLabel37.Location = new System.Drawing.Point(7, 93);
            this.fld_lblLabel37.Name = "fld_lblLabel37";
            this.fld_lblLabel37.Screen = null;
            this.fld_lblLabel37.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel37.TabIndex = 39;
            this.fld_lblLabel37.Tag = "";
            this.fld_lblLabel37.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.fld_lblLabel29.BOSPropertyName = null;
            this.fld_lblLabel29.Location = new System.Drawing.Point(8, 20);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel29.TabIndex = 29;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "Địa chỉ hóa đơn";
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = "";
            this.fld_Line.BOSDataMember = "";
            this.fld_Line.BOSDataSource = "";
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = "";
            this.fld_Line.BOSFieldRelation = "";
            this.fld_Line.BOSPrivilege = "";
            this.fld_Line.BOSPropertyName = null;
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Location = new System.Drawing.Point(97, 23);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.fld_Line.Size = new System.Drawing.Size(273, 10);
            this.fld_Line.TabIndex = 30;
            this.fld_Line.TabStop = false;
            this.fld_Line.Tag = "";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = "";
            this.fld_lblLabel30.BOSDataMember = "ARInvoiceInvoiceAddressLine3";
            this.fld_lblLabel30.BOSDataSource = "ARInvoices";
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = "";
            this.fld_lblLabel30.BOSFieldRelation = "";
            this.fld_lblLabel30.BOSPrivilege = "";
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(6, 37);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.fld_lblLabel30.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel30.TabIndex = 31;
            this.fld_lblLabel30.Tag = "";
            this.fld_lblLabel30.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line1.BOSComment = "";
            this.fld_Line1.BOSDataMember = "";
            this.fld_Line1.BOSDataSource = "";
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = "";
            this.fld_Line1.BOSFieldRelation = "";
            this.fld_Line1.BOSPrivilege = "";
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line1.Location = new System.Drawing.Point(112, 78);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(258, 10);
            this.fld_Line1.TabIndex = 38;
            this.fld_Line1.TabStop = false;
            this.fld_Line1.Tag = "";
            // 
            // fld_tabInvoiceItems
            // 
            this.fld_tabInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabInvoiceItems.BOSComment = null;
            this.fld_tabInvoiceItems.BOSDataMember = null;
            this.fld_tabInvoiceItems.BOSDataSource = null;
            this.fld_tabInvoiceItems.BOSDescription = null;
            this.fld_tabInvoiceItems.BOSError = null;
            this.fld_tabInvoiceItems.BOSFieldGroup = null;
            this.fld_tabInvoiceItems.BOSFieldRelation = null;
            this.fld_tabInvoiceItems.BOSPrivilege = null;
            this.fld_tabInvoiceItems.BOSPropertyName = null;
            this.fld_tabInvoiceItems.Location = new System.Drawing.Point(3, 289);
            this.fld_tabInvoiceItems.Name = "fld_tabInvoiceItems";
            this.fld_tabInvoiceItems.Screen = null;
            this.fld_tabInvoiceItems.SelectedTabPage = this.fld_tabPageInvoiceItems;
            this.fld_tabInvoiceItems.Size = new System.Drawing.Size(1208, 413);
            this.fld_tabInvoiceItems.TabIndex = 5;
            this.fld_tabInvoiceItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceItems,
            this.fld_tabPageInvoiceCost,
            this.fld_tabPageInvoiceCommission,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageInvoiceItems
            // 
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_pteARInvoiceItemProductPicture);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lblLabel48);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_dgcARInvoiceItems);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabPageInvoiceItems.Name = "fld_tabPageInvoiceItems";
            this.fld_tabPageInvoiceItems.Size = new System.Drawing.Size(1206, 388);
            this.fld_tabPageInvoiceItems.Text = "Danh sách sản phẩm";
            // 
            // fld_pteARInvoiceItemProductPicture
            // 
            this.fld_pteARInvoiceItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARInvoiceItemProductPicture.BOSComment = "";
            this.fld_pteARInvoiceItemProductPicture.BOSDataMember = "ARInvoiceItemProductPicture";
            this.fld_pteARInvoiceItemProductPicture.BOSDataSource = "ARInvoiceItems";
            this.fld_pteARInvoiceItemProductPicture.BOSDescription = null;
            this.fld_pteARInvoiceItemProductPicture.BOSError = null;
            this.fld_pteARInvoiceItemProductPicture.BOSFieldGroup = "";
            this.fld_pteARInvoiceItemProductPicture.BOSFieldRelation = "";
            this.fld_pteARInvoiceItemProductPicture.BOSPrivilege = "";
            this.fld_pteARInvoiceItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARInvoiceItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARInvoiceItemProductPicture.EditValue = "";
            this.fld_pteARInvoiceItemProductPicture.FileName = null;
            this.fld_pteARInvoiceItemProductPicture.FilePath = null;
            this.fld_pteARInvoiceItemProductPicture.Location = new System.Drawing.Point(1062, 3);
            this.fld_pteARInvoiceItemProductPicture.Name = "fld_pteARInvoiceItemProductPicture";
            this.fld_pteARInvoiceItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARInvoiceItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARInvoiceItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARInvoiceItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARInvoiceItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARInvoiceItemProductPicture.Screen = null;
            this.fld_pteARInvoiceItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARInvoiceItemProductPicture.TabIndex = 2;
            this.fld_pteARInvoiceItemProductPicture.Tag = "DC";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = "";
            this.fld_lblLabel48.BOSDataMember = "";
            this.fld_lblLabel48.BOSDataSource = "";
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = "";
            this.fld_lblLabel48.BOSFieldRelation = "";
            this.fld_lblLabel48.BOSPrivilege = "";
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(7, 8);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Tag = "";
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_dgcARInvoiceItems
            // 
            this.fld_dgcARInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoiceItems.BOSComment = null;
            this.fld_dgcARInvoiceItems.BOSDataMember = null;
            this.fld_dgcARInvoiceItems.BOSDataSource = "ARInvoiceItems";
            this.fld_dgcARInvoiceItems.BOSDescription = null;
            this.fld_dgcARInvoiceItems.BOSError = null;
            this.fld_dgcARInvoiceItems.BOSFieldGroup = null;
            this.fld_dgcARInvoiceItems.BOSFieldRelation = null;
            this.fld_dgcARInvoiceItems.BOSGridType = null;
            this.fld_dgcARInvoiceItems.BOSPrivilege = null;
            this.fld_dgcARInvoiceItems.BOSPropertyName = null;
            this.fld_dgcARInvoiceItems.CommodityType = "";
            this.fld_dgcARInvoiceItems.Location = new System.Drawing.Point(3, 31);
            this.fld_dgcARInvoiceItems.MainView = this.fld_dgvARInvoice;
            this.fld_dgcARInvoiceItems.Name = "fld_dgcARInvoiceItems";
            this.fld_dgcARInvoiceItems.PrintReport = false;
            this.fld_dgcARInvoiceItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.fld_dgcARInvoiceItems.Screen = null;
            this.fld_dgcARInvoiceItems.Size = new System.Drawing.Size(1053, 354);
            this.fld_dgcARInvoiceItems.TabIndex = 1;
            this.fld_dgcARInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoice});
            // 
            // fld_dgvARInvoice
            // 
            this.fld_dgvARInvoice.GridControl = this.fld_dgcARInvoiceItems;
            this.fld_dgvARInvoice.Name = "fld_dgvARInvoice";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARInvoiceItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(60, 5);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(996, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeFK_ICProductAttributeID_QueryPopUp);
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_tabPageInvoiceCost
            // 
            this.fld_tabPageInvoiceCost.Controls.Add(this.fld_dgcARInvoiceItemCosts);
            this.fld_tabPageInvoiceCost.Name = "fld_tabPageInvoiceCost";
            this.fld_tabPageInvoiceCost.Size = new System.Drawing.Size(1192, 381);
            this.fld_tabPageInvoiceCost.Text = "Danh sách chi phí";
            // 
            // fld_dgcARInvoiceItemCosts
            // 
            this.fld_dgcARInvoiceItemCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoiceItemCosts.BOSComment = null;
            this.fld_dgcARInvoiceItemCosts.BOSDataMember = "";
            this.fld_dgcARInvoiceItemCosts.BOSDataSource = "ARInvoiceItemWorks";
            this.fld_dgcARInvoiceItemCosts.BOSDescription = null;
            this.fld_dgcARInvoiceItemCosts.BOSError = null;
            this.fld_dgcARInvoiceItemCosts.BOSFieldGroup = null;
            this.fld_dgcARInvoiceItemCosts.BOSFieldRelation = null;
            this.fld_dgcARInvoiceItemCosts.BOSGridType = null;
            this.fld_dgcARInvoiceItemCosts.BOSPrivilege = null;
            this.fld_dgcARInvoiceItemCosts.BOSPropertyName = null;
            this.fld_dgcARInvoiceItemCosts.CommodityType = "";
            this.fld_dgcARInvoiceItemCosts.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcARInvoiceItemCosts.MenuManager = this.screenToolbar;
            this.fld_dgcARInvoiceItemCosts.Name = "fld_dgcARInvoiceItemCosts";
            this.fld_dgcARInvoiceItemCosts.PrintReport = false;
            this.fld_dgcARInvoiceItemCosts.Screen = null;
            this.fld_dgcARInvoiceItemCosts.Size = new System.Drawing.Size(1185, 375);
            this.fld_dgcARInvoiceItemCosts.TabIndex = 0;
            // 
            // fld_tabPageInvoiceCommission
            // 
            this.fld_tabPageInvoiceCommission.Controls.Add(this.fld_dgcCommissionsGridControl);
            this.fld_tabPageInvoiceCommission.Name = "fld_tabPageInvoiceCommission";
            this.fld_tabPageInvoiceCommission.Size = new System.Drawing.Size(1192, 381);
            this.fld_tabPageInvoiceCommission.Text = "Người giới thiệu";
            // 
            // fld_dgcCommissionsGridControl
            // 
            this.fld_dgcCommissionsGridControl.BOSComment = null;
            this.fld_dgcCommissionsGridControl.BOSDataMember = null;
            this.fld_dgcCommissionsGridControl.BOSDataSource = "ARInvoiceCommissions";
            this.fld_dgcCommissionsGridControl.BOSDescription = null;
            this.fld_dgcCommissionsGridControl.BOSError = null;
            this.fld_dgcCommissionsGridControl.BOSFieldGroup = null;
            this.fld_dgcCommissionsGridControl.BOSFieldRelation = null;
            this.fld_dgcCommissionsGridControl.BOSGridType = null;
            this.fld_dgcCommissionsGridControl.BOSPrivilege = null;
            this.fld_dgcCommissionsGridControl.BOSPropertyName = null;
            this.fld_dgcCommissionsGridControl.CommodityType = "";
            this.fld_dgcCommissionsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcCommissionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCommissionsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcCommissionsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcCommissionsGridControl.Name = "fld_dgcCommissionsGridControl";
            this.fld_dgcCommissionsGridControl.PrintReport = false;
            this.fld_dgcCommissionsGridControl.Screen = null;
            this.fld_dgcCommissionsGridControl.Size = new System.Drawing.Size(1192, 381);
            this.fld_dgcCommissionsGridControl.TabIndex = 2;
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1192, 381);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1192, 381);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
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
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = "";
            this.bosLine3.BOSDataMember = "";
            this.bosLine3.BOSDataSource = "";
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = "";
            this.bosLine3.BOSFieldRelation = "";
            this.bosLine3.BOSPrivilege = "";
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.bosTextBox6);
            this.bosLine3.Controls.Add(this.bosLabel27);
            this.bosLine3.Controls.Add(this.fld_lblLabel5);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosLine3.Controls.Add(this.bosLabel7);
            this.bosLine3.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosLine3.Controls.Add(this.bosLabel3);
            this.bosLine3.Controls.Add(this.fld_lblLabel26);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosLine3.Controls.Add(this.fld_lblLabel2);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATPaymentContactInformation);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceSOContactName);
            this.bosLine3.Controls.Add(this.bosLabel20);
            this.bosLine3.Controls.Add(this.bosLabel19);
            this.bosLine3.Controls.Add(this.fld_lkeAROutputVATDocumentType);
            this.bosLine3.Controls.Add(this.bosLabel14);
            this.bosLine3.Controls.Add(this.bosLabel4);
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATInvoiceNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATTaxNumber);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATFormNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATSymbol);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(647, 5);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(487, 181);
            this.bosLine3.TabIndex = 3;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin VAT";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARInvoiceInvoiceRequest";
            this.bosTextBox6.BOSDataSource = "ARInvoices";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(344, 151);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox6.TabIndex = 840;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
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
            this.bosLabel27.Location = new System.Drawing.Point(253, 154);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(81, 13);
            this.bosLabel27.TabIndex = 716;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Yêu cầu xuất HĐ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(15, 102);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 94;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARInvoices";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(102, 99);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 6;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            this.fld_lkeFK_ACObjectID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_ACObjectID_EditValueChanging);
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDescription = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSError = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectType = "ACEInvoiceTypeCombo";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectTypeValue = "Sell";
            this.fld_lkeFK_ACEInvoiceTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(344, 21);
            this.fld_lkeFK_ACEInvoiceTypeID.Name = "fld_lkeFK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeTemplateCode", "Kí hiệu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeSeries", "Mẫu số")});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.DisplayMember = "ACEInvoiceTypeNo";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.NullText = "";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ValueMember = "ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Screen = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 1;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEInvoiceTypeID_CloseUp);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(253, 23);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(85, 13);
            this.bosLabel7.TabIndex = 92;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Mã hóa đơn GTGT";
            // 
            // fld_lkeARPaymentMethodCombo
            // 
            this.fld_lkeARPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeARPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeARPaymentMethodCombo.BOSComment = null;
            this.fld_lkeARPaymentMethodCombo.BOSDataMember = "ARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ARInvoices";
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
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(102, 125);
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
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 8;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(15, 23);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 75;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại hóa đơn";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = "";
            this.fld_lblLabel26.BOSDataMember = "";
            this.fld_lblLabel26.BOSDataSource = "";
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = "";
            this.fld_lblLabel26.BOSFieldRelation = "";
            this.fld_lblLabel26.BOSPrivilege = "";
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(253, 76);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel26.TabIndex = 4;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày hóa đơn";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "ARInvoices";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(15, 128);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(24, 13);
            this.bosLabel21.TabIndex = 90;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "PTTT";
            // 
            // fld_dteARInvoiceDate
            // 
            this.fld_dteARInvoiceDate.BOSComment = "";
            this.fld_dteARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteARInvoiceDate.BOSDescription = null;
            this.fld_dteARInvoiceDate.BOSError = null;
            this.fld_dteARInvoiceDate.BOSFieldGroup = "";
            this.fld_dteARInvoiceDate.BOSFieldRelation = "";
            this.fld_dteARInvoiceDate.BOSPrivilege = "";
            this.fld_dteARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDate.EditValue = null;
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(344, 73);
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteARInvoiceDate.TabIndex = 5;
            this.fld_dteARInvoiceDate.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(253, 102);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel2.TabIndex = 20;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Người MH";
            // 
            // fld_txtARInvoiceVATPaymentContactInformation
            // 
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSComment = "";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSDataMember = "ARInvoiceVATPaymentContactInformation";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSDescription = null;
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSError = null;
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSPrivilege = "";
            this.fld_txtARInvoiceVATPaymentContactInformation.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATPaymentContactInformation.EditValue = "";
            this.fld_txtARInvoiceVATPaymentContactInformation.Location = new System.Drawing.Point(102, 151);
            this.fld_txtARInvoiceVATPaymentContactInformation.Name = "fld_txtARInvoiceVATPaymentContactInformation";
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATPaymentContactInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATPaymentContactInformation.Screen = null;
            this.fld_txtARInvoiceVATPaymentContactInformation.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceVATPaymentContactInformation.TabIndex = 10;
            this.fld_txtARInvoiceVATPaymentContactInformation.Tag = "DC";
            // 
            // fld_txtARInvoiceSOContactName
            // 
            this.fld_txtARInvoiceSOContactName.BOSComment = "";
            this.fld_txtARInvoiceSOContactName.BOSDataMember = "ARInvoiceSOContactName";
            this.fld_txtARInvoiceSOContactName.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceSOContactName.BOSDescription = null;
            this.fld_txtARInvoiceSOContactName.BOSError = null;
            this.fld_txtARInvoiceSOContactName.BOSFieldGroup = "";
            this.fld_txtARInvoiceSOContactName.BOSFieldRelation = "";
            this.fld_txtARInvoiceSOContactName.BOSPrivilege = "";
            this.fld_txtARInvoiceSOContactName.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceSOContactName.EditValue = "";
            this.fld_txtARInvoiceSOContactName.Location = new System.Drawing.Point(344, 99);
            this.fld_txtARInvoiceSOContactName.Name = "fld_txtARInvoiceSOContactName";
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSOContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSOContactName.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceSOContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSOContactName.Screen = null;
            this.fld_txtARInvoiceSOContactName.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceSOContactName.TabIndex = 7;
            this.fld_txtARInvoiceSOContactName.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
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
            this.bosLabel20.Location = new System.Drawing.Point(253, 50);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(35, 13);
            this.bosLabel20.TabIndex = 86;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Ký hiệu";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(15, 76);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(54, 13);
            this.bosLabel19.TabIndex = 85;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Số hóa đơn";
            // 
            // fld_lkeAROutputVATDocumentType
            // 
            this.fld_lkeAROutputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeAROutputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeAROutputVATDocumentType.BOSComment = "";
            this.fld_lkeAROutputVATDocumentType.BOSDataMember = "AROutputVATDocumentType";
            this.fld_lkeAROutputVATDocumentType.BOSDataSource = "ARInvoices";
            this.fld_lkeAROutputVATDocumentType.BOSDescription = null;
            this.fld_lkeAROutputVATDocumentType.BOSError = null;
            this.fld_lkeAROutputVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeAROutputVATDocumentType.BOSFieldParent = "";
            this.fld_lkeAROutputVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeAROutputVATDocumentType.BOSPrivilege = "";
            this.fld_lkeAROutputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeAROutputVATDocumentType.BOSSelectType = "";
            this.fld_lkeAROutputVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeAROutputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeAROutputVATDocumentType.Location = new System.Drawing.Point(102, 21);
            this.fld_lkeAROutputVATDocumentType.Name = "fld_lkeAROutputVATDocumentType";
            this.fld_lkeAROutputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAROutputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAROutputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAROutputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAROutputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAROutputVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeAROutputVATDocumentType.Properties.NullText = "";
            this.fld_lkeAROutputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAROutputVATDocumentType.Screen = null;
            this.fld_lkeAROutputVATDocumentType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeAROutputVATDocumentType.TabIndex = 0;
            this.fld_lkeAROutputVATDocumentType.Tag = "DC";
            this.fld_lkeAROutputVATDocumentType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAROutputVATDocumentType_CloseUp);
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(15, 154);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(59, 13);
            this.bosLabel14.TabIndex = 83;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Đơn vị (Cty)";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(15, 50);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(34, 13);
            this.bosLabel4.TabIndex = 76;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mẫu số";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(253, 128);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(20, 13);
            this.bosLabel18.TabIndex = 84;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "MST";
            // 
            // fld_txtARInvoiceVATInvoiceNo
            // 
            this.fld_txtARInvoiceVATInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataMember = "ARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATInvoiceNo.EditValue = "";
            this.fld_txtARInvoiceVATInvoiceNo.Location = new System.Drawing.Point(102, 73);
            this.fld_txtARInvoiceVATInvoiceNo.Name = "fld_txtARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATInvoiceNo.Screen = null;
            this.fld_txtARInvoiceVATInvoiceNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceVATInvoiceNo.TabIndex = 4;
            this.fld_txtARInvoiceVATInvoiceNo.Tag = "DC";
            // 
            // fld_txtARInvoiceVATTaxNumber
            // 
            this.fld_txtARInvoiceVATTaxNumber.BOSComment = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSDataMember = "ARInvoiceTaxNumber";
            this.fld_txtARInvoiceVATTaxNumber.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceVATTaxNumber.BOSDescription = null;
            this.fld_txtARInvoiceVATTaxNumber.BOSError = null;
            this.fld_txtARInvoiceVATTaxNumber.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSPrivilege = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATTaxNumber.EditValue = "";
            this.fld_txtARInvoiceVATTaxNumber.Location = new System.Drawing.Point(344, 125);
            this.fld_txtARInvoiceVATTaxNumber.Name = "fld_txtARInvoiceVATTaxNumber";
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATTaxNumber.Screen = null;
            this.fld_txtARInvoiceVATTaxNumber.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceVATTaxNumber.TabIndex = 9;
            this.fld_txtARInvoiceVATTaxNumber.Tag = "DC";
            // 
            // fld_txtARInvoiceVATFormNo
            // 
            this.fld_txtARInvoiceVATFormNo.BOSComment = "";
            this.fld_txtARInvoiceVATFormNo.BOSDataMember = "ARInvoiceVATFormNo";
            this.fld_txtARInvoiceVATFormNo.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceVATFormNo.BOSDescription = null;
            this.fld_txtARInvoiceVATFormNo.BOSError = null;
            this.fld_txtARInvoiceVATFormNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATFormNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATFormNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATFormNo.EditValue = "";
            this.fld_txtARInvoiceVATFormNo.Location = new System.Drawing.Point(102, 47);
            this.fld_txtARInvoiceVATFormNo.Name = "fld_txtARInvoiceVATFormNo";
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATFormNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATFormNo.Screen = null;
            this.fld_txtARInvoiceVATFormNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceVATFormNo.TabIndex = 2;
            this.fld_txtARInvoiceVATFormNo.Tag = "DC";
            // 
            // fld_txtARInvoiceVATSymbol
            // 
            this.fld_txtARInvoiceVATSymbol.BOSComment = "";
            this.fld_txtARInvoiceVATSymbol.BOSDataMember = "ARInvoiceVATSymbol";
            this.fld_txtARInvoiceVATSymbol.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceVATSymbol.BOSDescription = null;
            this.fld_txtARInvoiceVATSymbol.BOSError = null;
            this.fld_txtARInvoiceVATSymbol.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATSymbol.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATSymbol.BOSPrivilege = "";
            this.fld_txtARInvoiceVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATSymbol.EditValue = "";
            this.fld_txtARInvoiceVATSymbol.Location = new System.Drawing.Point(344, 47);
            this.fld_txtARInvoiceVATSymbol.Name = "fld_txtARInvoiceVATSymbol";
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATSymbol.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATSymbol.Screen = null;
            this.fld_txtARInvoiceVATSymbol.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceVATSymbol.TabIndex = 3;
            this.fld_txtARInvoiceVATSymbol.Tag = "DC";
            // 
            // bosLine4
            // 
            this.bosLine4.BackColor = System.Drawing.Color.Transparent;
            this.bosLine4.BOSComment = "";
            this.bosLine4.BOSDataMember = "";
            this.bosLine4.BOSDataSource = "";
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = "";
            this.bosLine4.BOSFieldRelation = "";
            this.bosLine4.BOSPrivilege = "";
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.bosLabel26);
            this.bosLine4.Controls.Add(this.bosLookupEdit3);
            this.bosLine4.Controls.Add(this.bosTextBox5);
            this.bosLine4.Controls.Add(this.bosLabel33);
            this.bosLine4.Controls.Add(this.fld_dteARInvoiceValidateDate);
            this.bosLine4.Controls.Add(this.bosLabel29);
            this.bosLine4.Controls.Add(this.bosLookupEdit2);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosLine4.Controls.Add(this.fld_Lablel3);
            this.bosLine4.Controls.Add(this.bosLabel85);
            this.bosLine4.Controls.Add(this.bosLabel25);
            this.bosLine4.Controls.Add(this.bosLabel23);
            this.bosLine4.Controls.Add(this.bosTextBox1);
            this.bosLine4.Controls.Add(this.bosLabel22);
            this.bosLine4.Controls.Add(this.bosLookupEdit1);
            this.bosLine4.Controls.Add(this.bosLabel17);
            this.bosLine4.Controls.Add(this.fld_lkeARInvoiceProductType);
            this.bosLine4.Controls.Add(this.bosTextBox4);
            this.bosLine4.Controls.Add(this.bosTextBox2);
            this.bosLine4.Controls.Add(this.bosLabel16);
            this.bosLine4.Controls.Add(this.bosLabel10);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.bosLine4.Controls.Add(this.bosLabel6);
            this.bosLine4.Controls.Add(this.bosLabel11);
            this.bosLine4.Controls.Add(this.fld_txtARInvoiceNo1);
            this.bosLine4.Controls.Add(this.fld_lblLabel27);
            this.bosLine4.Controls.Add(this.fld_medARInvoiceDesc);
            this.bosLine4.Controls.Add(this.fld_dteARInvoiceDeliveryDate);
            this.bosLine4.Controls.Add(this.fld_lblLabel25);
            this.bosLine4.Controls.Add(this.fld_lkeARInvoiceStatus1);
            this.bosLine4.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine4.Controls.Add(this.bosLabel1);
            this.bosLine4.Controls.Add(this.fld_txtARInvoiceExchangeRate);
            this.bosLine4.Controls.Add(this.bosLabel5);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(151, 5);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(490, 278);
            this.bosLine4.TabIndex = 2;
            this.bosLine4.TabStop = false;
            this.bosLine4.Tag = "";
            this.bosLine4.Text = "Thông tin chung";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(273, 206);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel26, true);
            this.bosLabel26.Size = new System.Drawing.Size(72, 13);
            this.bosLabel26.TabIndex = 846;
            this.bosLabel26.Text = "Kênh bán hàng";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "ARListOfSalesChannelType";
            this.bosLookupEdit3.BOSDataSource = "ARInvoices";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = "";
            this.bosLookupEdit3.BOSSelectTypeValue = "";
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(346, 203);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit3, true);
            this.bosLookupEdit3.Size = new System.Drawing.Size(131, 20);
            this.bosLookupEdit3.TabIndex = 845;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARInvoiceProject";
            this.bosTextBox5.BOSDataSource = "ARInvoices";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(125, 151);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox5, true);
            this.bosTextBox5.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox5.TabIndex = 844;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(11, 102);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(75, 13);
            this.bosLabel33.TabIndex = 715;
            this.bosLabel33.Tag = "";
            this.bosLabel33.Text = "Hạn thanh toán";
            // 
            // fld_dteARInvoiceValidateDate
            // 
            this.fld_dteARInvoiceValidateDate.BOSComment = "";
            this.fld_dteARInvoiceValidateDate.BOSDataMember = "ARInvoiceValidateDate";
            this.fld_dteARInvoiceValidateDate.BOSDataSource = "ARInvoices";
            this.fld_dteARInvoiceValidateDate.BOSDescription = null;
            this.fld_dteARInvoiceValidateDate.BOSError = null;
            this.fld_dteARInvoiceValidateDate.BOSFieldGroup = "";
            this.fld_dteARInvoiceValidateDate.BOSFieldRelation = "";
            this.fld_dteARInvoiceValidateDate.BOSPrivilege = "";
            this.fld_dteARInvoiceValidateDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceValidateDate.EditValue = null;
            this.fld_dteARInvoiceValidateDate.Location = new System.Drawing.Point(125, 99);
            this.fld_dteARInvoiceValidateDate.Name = "fld_dteARInvoiceValidateDate";
            this.fld_dteARInvoiceValidateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARInvoiceValidateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARInvoiceValidateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARInvoiceValidateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARInvoiceValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceValidateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceValidateDate.Screen = null;
            this.fld_dteARInvoiceValidateDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteARInvoiceValidateDate.TabIndex = 6;
            this.fld_dteARInvoiceValidateDate.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(273, 180);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, false);
            this.bosLabel29.Size = new System.Drawing.Size(52, 13);
            this.bosLabel29.TabIndex = 713;
            this.bosLabel29.Text = "Ngân hàng";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "FK_ARCustomerContactPaymentID";
            this.bosLookupEdit2.BOSDataSource = "ARInvoices";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(346, 177);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.bosLookupEdit2.Properties.DisplayMember = "CSCompanyBankName";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "CSCompanyBankID";
            this.bosLookupEdit2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit2, true);
            this.bosLookupEdit2.Size = new System.Drawing.Size(131, 20);
            this.bosLookupEdit2.TabIndex = 13;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ICStockID1.BOSDescription = null;
            this.fld_lkeFK_ICStockID1.BOSError = "";
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(125, 177);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 12;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ICStockID1_CloseUp);
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = "";
            this.fld_Lablel3.BOSDataSource = "";
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = "";
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(11, 180);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 711;
            this.fld_Lablel3.Text = "Kho";
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
            this.bosLabel85.Location = new System.Drawing.Point(273, 154);
            this.bosLabel85.Name = "bosLabel85";
            this.bosLabel85.Screen = null;
            this.bosLabel85.Size = new System.Drawing.Size(14, 13);
            this.bosLabel85.TabIndex = 709;
            this.bosLabel85.Text = "PO";
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
            this.bosLabel25.Location = new System.Drawing.Point(11, 154);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, true);
            this.bosLabel25.Size = new System.Drawing.Size(45, 13);
            this.bosLabel25.TabIndex = 587;
            this.bosLabel25.Text = "Mã dự án";
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
            this.bosLabel23.BOSPropertyName = "";
            this.bosLabel23.Location = new System.Drawing.Point(11, 128);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(62, 13);
            this.bosLabel23.TabIndex = 422;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Mã đơn hàng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARInvoicePONo";
            this.bosTextBox1.BOSDataSource = "ARInvoices";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(125, 125);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(273, 128);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(34, 13);
            this.bosLabel22.TabIndex = 113;
            this.bosLabel22.Text = "Mã LSX";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_MMBatchProductID";
            this.bosLookupEdit1.BOSDataSource = "ARInvoices";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(346, 125);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.bosLookupEdit1.Properties.DisplayMember = "MMBatchProductNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "MMBatchProductID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(131, 20);
            this.bosLookupEdit1.TabIndex = 9;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel17.Location = new System.Drawing.Point(273, 102);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 111;
            this.bosLabel17.Text = "Loại hàng hóa";
            // 
            // fld_lkeARInvoiceProductType
            // 
            this.fld_lkeARInvoiceProductType.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceProductType.BOSAllowDummy = false;
            this.fld_lkeARInvoiceProductType.BOSComment = null;
            this.fld_lkeARInvoiceProductType.BOSDataMember = "ARInvoiceProductType";
            this.fld_lkeARInvoiceProductType.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceProductType.BOSDescription = null;
            this.fld_lkeARInvoiceProductType.BOSError = null;
            this.fld_lkeARInvoiceProductType.BOSFieldGroup = null;
            this.fld_lkeARInvoiceProductType.BOSFieldParent = null;
            this.fld_lkeARInvoiceProductType.BOSFieldRelation = null;
            this.fld_lkeARInvoiceProductType.BOSPrivilege = null;
            this.fld_lkeARInvoiceProductType.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceProductType.BOSSelectType = "";
            this.fld_lkeARInvoiceProductType.BOSSelectTypeValue = "";
            this.fld_lkeARInvoiceProductType.CurrentDisplayText = null;
            this.fld_lkeARInvoiceProductType.Location = new System.Drawing.Point(346, 99);
            this.fld_lkeARInvoiceProductType.Name = "fld_lkeARInvoiceProductType";
            this.fld_lkeARInvoiceProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARInvoiceProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceProductType.Properties.ColumnName = null;
            this.fld_lkeARInvoiceProductType.Properties.NullText = "";
            this.fld_lkeARInvoiceProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARInvoiceProductType, true);
            this.fld_lkeARInvoiceProductType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeARInvoiceProductType.TabIndex = 7;
            this.fld_lkeARInvoiceProductType.Tag = "DC";
            this.fld_lkeARInvoiceProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARInvoiceProductType_CloseUp);
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARInvoiceSaleAgreement";
            this.bosTextBox4.BOSDataSource = "ARInvoices";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(346, 151);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox4.TabIndex = 11;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARInvoiceVehicle";
            this.bosTextBox2.BOSDataSource = "ARInvoices";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(125, 203);
            this.bosTextBox2.MenuManager = this.screenToolbar;
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, false);
            this.bosTextBox2.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox2.TabIndex = 14;
            this.bosTextBox2.Tag = "DC";
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
            this.bosLabel16.Location = new System.Drawing.Point(273, 23);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(49, 13);
            this.bosLabel16.TabIndex = 27;
            this.bosLabel16.Text = "Người bán";
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
            this.bosLabel10.Location = new System.Drawing.Point(11, 206);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(108, 13);
            this.bosLabel10.TabIndex = 28;
            this.bosLabel10.Text = "Phương tiện giao hàng";
            // 
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSellerID.BOSComment = null;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ARInvoices";
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
            this.fld_lkeFK_ARSellerID.Location = new System.Drawing.Point(346, 21);
            this.fld_lkeFK_ARSellerID.Name = "fld_lkeFK_ARSellerID";
            this.fld_lkeFK_ARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSellerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_ARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARSellerID.Screen = null;
            this.fld_lkeFK_ARSellerID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ARSellerID.TabIndex = 1;
            this.fld_lkeFK_ARSellerID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(273, 76);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 25;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tỷ giá";
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
            this.bosLabel11.Location = new System.Drawing.Point(11, 23);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(80, 13);
            this.bosLabel11.TabIndex = 2;
            this.bosLabel11.Text = "Mã hóa đơn (NB)";
            // 
            // fld_txtARInvoiceNo1
            // 
            this.fld_txtARInvoiceNo1.BOSComment = null;
            this.fld_txtARInvoiceNo1.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo1.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceNo1.BOSDescription = null;
            this.fld_txtARInvoiceNo1.BOSError = null;
            this.fld_txtARInvoiceNo1.BOSFieldGroup = null;
            this.fld_txtARInvoiceNo1.BOSFieldRelation = null;
            this.fld_txtARInvoiceNo1.BOSPrivilege = null;
            this.fld_txtARInvoiceNo1.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceNo1.Location = new System.Drawing.Point(125, 21);
            this.fld_txtARInvoiceNo1.MenuManager = this.screenToolbar;
            this.fld_txtARInvoiceNo1.Name = "fld_txtARInvoiceNo1";
            this.fld_txtARInvoiceNo1.Screen = null;
            this.fld_txtARInvoiceNo1.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceNo1.TabIndex = 0;
            this.fld_txtARInvoiceNo1.Tag = "DC";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(273, 50);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel27.TabIndex = 6;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Ngày giao";
            // 
            // fld_medARInvoiceDesc
            // 
            this.fld_medARInvoiceDesc.BOSComment = "";
            this.fld_medARInvoiceDesc.BOSDataMember = "ARInvoiceDesc";
            this.fld_medARInvoiceDesc.BOSDataSource = "ARInvoices";
            this.fld_medARInvoiceDesc.BOSDescription = null;
            this.fld_medARInvoiceDesc.BOSError = null;
            this.fld_medARInvoiceDesc.BOSFieldGroup = "";
            this.fld_medARInvoiceDesc.BOSFieldRelation = "";
            this.fld_medARInvoiceDesc.BOSPrivilege = "";
            this.fld_medARInvoiceDesc.BOSPropertyName = "EditValue";
            this.fld_medARInvoiceDesc.EditValue = "";
            this.fld_medARInvoiceDesc.Location = new System.Drawing.Point(125, 229);
            this.fld_medARInvoiceDesc.Name = "fld_medARInvoiceDesc";
            this.fld_medARInvoiceDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARInvoiceDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARInvoiceDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARInvoiceDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARInvoiceDesc.Screen = null;
            this.fld_medARInvoiceDesc.Size = new System.Drawing.Size(352, 40);
            this.fld_medARInvoiceDesc.TabIndex = 15;
            this.fld_medARInvoiceDesc.Tag = "DC";
            // 
            // fld_dteARInvoiceDeliveryDate
            // 
            this.fld_dteARInvoiceDeliveryDate.BOSComment = "";
            this.fld_dteARInvoiceDeliveryDate.BOSDataMember = "ARInvoiceDeliveryDate";
            this.fld_dteARInvoiceDeliveryDate.BOSDataSource = "ARInvoices";
            this.fld_dteARInvoiceDeliveryDate.BOSDescription = null;
            this.fld_dteARInvoiceDeliveryDate.BOSError = null;
            this.fld_dteARInvoiceDeliveryDate.BOSFieldGroup = "";
            this.fld_dteARInvoiceDeliveryDate.BOSFieldRelation = "";
            this.fld_dteARInvoiceDeliveryDate.BOSPrivilege = "";
            this.fld_dteARInvoiceDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDeliveryDate.EditValue = null;
            this.fld_dteARInvoiceDeliveryDate.Location = new System.Drawing.Point(346, 47);
            this.fld_dteARInvoiceDeliveryDate.Name = "fld_dteARInvoiceDeliveryDate";
            this.fld_dteARInvoiceDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARInvoiceDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARInvoiceDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARInvoiceDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARInvoiceDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDeliveryDate.Screen = null;
            this.fld_dteARInvoiceDeliveryDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteARInvoiceDeliveryDate.TabIndex = 3;
            this.fld_dteARInvoiceDeliveryDate.Tag = "DC";
            this.fld_dteARInvoiceDeliveryDate.Validated += new System.EventHandler(this.fld_dteARInvoiceDeliveryDate_Validated);
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = "";
            this.fld_lblLabel25.BOSDataMember = "";
            this.fld_lblLabel25.BOSDataSource = "";
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = "";
            this.fld_lblLabel25.BOSFieldRelation = "";
            this.fld_lblLabel25.BOSPrivilege = "";
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(11, 50);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 24;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // fld_lkeARInvoiceStatus1
            // 
            this.fld_lkeARInvoiceStatus1.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceStatus1.BOSAllowDummy = false;
            this.fld_lkeARInvoiceStatus1.BOSComment = "";
            this.fld_lkeARInvoiceStatus1.BOSDataMember = "ARInvoiceStatus";
            this.fld_lkeARInvoiceStatus1.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceStatus1.BOSDescription = null;
            this.fld_lkeARInvoiceStatus1.BOSError = null;
            this.fld_lkeARInvoiceStatus1.BOSFieldGroup = "";
            this.fld_lkeARInvoiceStatus1.BOSFieldParent = "";
            this.fld_lkeARInvoiceStatus1.BOSFieldRelation = "";
            this.fld_lkeARInvoiceStatus1.BOSPrivilege = "";
            this.fld_lkeARInvoiceStatus1.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceStatus1.BOSSelectType = "";
            this.fld_lkeARInvoiceStatus1.BOSSelectTypeValue = "";
            this.fld_lkeARInvoiceStatus1.CurrentDisplayText = "";
            this.fld_lkeARInvoiceStatus1.Location = new System.Drawing.Point(125, 47);
            this.fld_lkeARInvoiceStatus1.Name = "fld_lkeARInvoiceStatus1";
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceStatus1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceStatus1.Properties.ColumnName = null;
            this.fld_lkeARInvoiceStatus1.Properties.NullText = "";
            this.fld_lkeARInvoiceStatus1.Properties.ReadOnly = true;
            this.fld_lkeARInvoiceStatus1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceStatus1.Screen = null;
            this.fld_lkeARInvoiceStatus1.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeARInvoiceStatus1.TabIndex = 2;
            this.fld_lkeARInvoiceStatus1.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(125, 73);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(11, 236);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 24;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Diễn giải";
            // 
            // fld_txtARInvoiceExchangeRate
            // 
            this.fld_txtARInvoiceExchangeRate.BOSComment = "";
            this.fld_txtARInvoiceExchangeRate.BOSDataMember = "ARInvoiceExchangeRate";
            this.fld_txtARInvoiceExchangeRate.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceExchangeRate.BOSDescription = null;
            this.fld_txtARInvoiceExchangeRate.BOSError = null;
            this.fld_txtARInvoiceExchangeRate.BOSFieldGroup = "";
            this.fld_txtARInvoiceExchangeRate.BOSFieldRelation = "";
            this.fld_txtARInvoiceExchangeRate.BOSPrivilege = "";
            this.fld_txtARInvoiceExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceExchangeRate.EditValue = "";
            this.fld_txtARInvoiceExchangeRate.Location = new System.Drawing.Point(346, 73);
            this.fld_txtARInvoiceExchangeRate.Name = "fld_txtARInvoiceExchangeRate";
            this.fld_txtARInvoiceExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceExchangeRate.Screen = null;
            this.fld_txtARInvoiceExchangeRate.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceExchangeRate.TabIndex = 5;
            this.fld_txtARInvoiceExchangeRate.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(11, 76);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(53, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại tiền tệ";
            // 
            // fld_pteARInvoiceEmployeePicture
            // 
            this.fld_pteARInvoiceEmployeePicture.BOSComment = null;
            this.fld_pteARInvoiceEmployeePicture.BOSDataMember = "ARInvoiceEmployeePicture";
            this.fld_pteARInvoiceEmployeePicture.BOSDataSource = "ARInvoices";
            this.fld_pteARInvoiceEmployeePicture.BOSDescription = null;
            this.fld_pteARInvoiceEmployeePicture.BOSError = null;
            this.fld_pteARInvoiceEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARInvoiceEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARInvoiceEmployeePicture.BOSPrivilege = null;
            this.fld_pteARInvoiceEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARInvoiceEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARInvoiceEmployeePicture.FileName = null;
            this.fld_pteARInvoiceEmployeePicture.FilePath = null;
            this.fld_pteARInvoiceEmployeePicture.Location = new System.Drawing.Point(12, 12);
            this.fld_pteARInvoiceEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteARInvoiceEmployeePicture.Name = "fld_pteARInvoiceEmployeePicture";
            this.fld_pteARInvoiceEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARInvoiceEmployeePicture.Screen = null;
            this.fld_pteARInvoiceEmployeePicture.Size = new System.Drawing.Size(127, 136);
            this.fld_pteARInvoiceEmployeePicture.TabIndex = 0;
            this.fld_pteARInvoiceEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(12, 154);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(127, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
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
            this.bosLabel24.Location = new System.Drawing.Point(979, 764);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(33, 13);
            this.bosLabel24.TabIndex = 74;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Chi phí";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "ARInvoiceTotalCost";
            this.bosTextBox3.BOSDataSource = "ARInvoices";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.EditValue = "0.00";
            this.bosTextBox3.Location = new System.Drawing.Point(1028, 761);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox3.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox3.Properties.ReadOnly = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(175, 20);
            this.bosTextBox3.TabIndex = 3;
            this.bosTextBox3.Tag = "DC";
            // 
            // fld_txtARSaleOrderCustomerCommissionPercent
            // 
            this.fld_txtARSaleOrderCustomerCommissionPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSComment = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDataMember = "ARInvoiceCommissionPercent";
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDataSource = "ARInvoices";
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSDescription = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSError = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSFieldGroup = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSFieldRelation = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSPrivilege = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderCustomerCommissionPercent.EditValue = "0.00";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Location = new System.Drawing.Point(1028, 814);
            this.fld_txtARSaleOrderCustomerCommissionPercent.Name = "fld_txtARSaleOrderCustomerCommissionPercent";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARSaleOrderCustomerCommissionPercent.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARSaleOrderCustomerCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Screen = null;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Size = new System.Drawing.Size(70, 20);
            this.fld_txtARSaleOrderCustomerCommissionPercent.TabIndex = 75;
            this.fld_txtARSaleOrderCustomerCommissionPercent.Tag = "DC";
            this.fld_txtARSaleOrderCustomerCommissionPercent.Validated += new System.EventHandler(this.fld_txtARSaleOrderCustomerCommissionPercent_Validated);
            // 
            // bosLabel28
            // 
            this.bosLabel28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(966, 817);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(46, 13);
            this.bosLabel28.TabIndex = 77;
            this.bosLabel28.Text = "Hoa hồng";
            // 
            // fld_txtARSaleOrderSOCommissionAmount
            // 
            this.fld_txtARSaleOrderSOCommissionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleOrderSOCommissionAmount.BOSComment = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDataMember = "ARInvoiceCommissionAmount";
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARSaleOrderSOCommissionAmount.BOSDescription = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSError = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderSOCommissionAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSOCommissionAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderSOCommissionAmount.Location = new System.Drawing.Point(1103, 814);
            this.fld_txtARSaleOrderSOCommissionAmount.Name = "fld_txtARSaleOrderSOCommissionAmount";
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtARSaleOrderSOCommissionAmount.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARSaleOrderSOCommissionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSOCommissionAmount.Screen = null;
            this.fld_txtARSaleOrderSOCommissionAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderSOCommissionAmount.TabIndex = 76;
            this.fld_txtARSaleOrderSOCommissionAmount.Tag = "DC";
            this.fld_txtARSaleOrderSOCommissionAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderSOCommissionAmount_Validated);
            // 
            // bosLine5
            // 
            this.bosLine5.BackColor = System.Drawing.Color.Transparent;
            this.bosLine5.BOSComment = "";
            this.bosLine5.BOSDataMember = "";
            this.bosLine5.BOSDataSource = "";
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = "";
            this.bosLine5.BOSFieldRelation = "";
            this.bosLine5.BOSPrivilege = "";
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_txtARInvoiceWaybillNumber);
            this.bosLine5.Controls.Add(this.bosLabel32);
            this.bosLine5.Controls.Add(this.fld_txtARInvoicePortEndShipmentText);
            this.bosLine5.Controls.Add(this.bosLabel31);
            this.bosLine5.Controls.Add(this.fld_txtARInvoicePortOFDischarge);
            this.bosLine5.Controls.Add(this.fld_lkeFK_GETerminalID);
            this.bosLine5.Controls.Add(this.bosLabel30);
            this.bosLine5.Controls.Add(this.bosLabel36);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine5.Location = new System.Drawing.Point(647, 192);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(487, 91);
            this.bosLine5.TabIndex = 4;
            this.bosLine5.TabStop = false;
            this.bosLine5.Tag = "";
            this.bosLine5.Text = "Thông tin khác";
            // 
            // fld_txtARInvoiceWaybillNumber
            // 
            this.fld_txtARInvoiceWaybillNumber.BOSComment = "";
            this.fld_txtARInvoiceWaybillNumber.BOSDataMember = "ARInvoiceWaybillNumber";
            this.fld_txtARInvoiceWaybillNumber.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceWaybillNumber.BOSDescription = null;
            this.fld_txtARInvoiceWaybillNumber.BOSError = null;
            this.fld_txtARInvoiceWaybillNumber.BOSFieldGroup = "";
            this.fld_txtARInvoiceWaybillNumber.BOSFieldRelation = "";
            this.fld_txtARInvoiceWaybillNumber.BOSPrivilege = "";
            this.fld_txtARInvoiceWaybillNumber.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceWaybillNumber.EditValue = "";
            this.fld_txtARInvoiceWaybillNumber.Location = new System.Drawing.Point(344, 46);
            this.fld_txtARInvoiceWaybillNumber.Name = "fld_txtARInvoiceWaybillNumber";
            this.fld_txtARInvoiceWaybillNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceWaybillNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceWaybillNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceWaybillNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceWaybillNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceWaybillNumber.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceWaybillNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceWaybillNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARInvoiceWaybillNumber, true);
            this.fld_txtARInvoiceWaybillNumber.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoiceWaybillNumber.TabIndex = 3;
            this.fld_txtARInvoiceWaybillNumber.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(253, 49);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel32, true);
            this.bosLabel32.Size = new System.Drawing.Size(54, 13);
            this.bosLabel32.TabIndex = 844;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Số vận đơn";
            // 
            // fld_txtARInvoicePortEndShipmentText
            // 
            this.fld_txtARInvoicePortEndShipmentText.BOSComment = "";
            this.fld_txtARInvoicePortEndShipmentText.BOSDataMember = "ARInvoicePortEndShipmentText";
            this.fld_txtARInvoicePortEndShipmentText.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoicePortEndShipmentText.BOSDescription = null;
            this.fld_txtARInvoicePortEndShipmentText.BOSError = null;
            this.fld_txtARInvoicePortEndShipmentText.BOSFieldGroup = "";
            this.fld_txtARInvoicePortEndShipmentText.BOSFieldRelation = "";
            this.fld_txtARInvoicePortEndShipmentText.BOSPrivilege = "";
            this.fld_txtARInvoicePortEndShipmentText.BOSPropertyName = "EditValue";
            this.fld_txtARInvoicePortEndShipmentText.EditValue = "";
            this.fld_txtARInvoicePortEndShipmentText.Location = new System.Drawing.Point(344, 20);
            this.fld_txtARInvoicePortEndShipmentText.Name = "fld_txtARInvoicePortEndShipmentText";
            this.fld_txtARInvoicePortEndShipmentText.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoicePortEndShipmentText.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoicePortEndShipmentText.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoicePortEndShipmentText.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoicePortEndShipmentText.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoicePortEndShipmentText.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoicePortEndShipmentText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoicePortEndShipmentText.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARInvoicePortEndShipmentText, true);
            this.fld_txtARInvoicePortEndShipmentText.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoicePortEndShipmentText.TabIndex = 1;
            this.fld_txtARInvoicePortEndShipmentText.Tag = "DC";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(253, 23);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel31, true);
            this.bosLabel31.Size = new System.Drawing.Size(68, 13);
            this.bosLabel31.TabIndex = 842;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "Cảng đến cuối";
            // 
            // fld_txtARInvoicePortOFDischarge
            // 
            this.fld_txtARInvoicePortOFDischarge.BOSComment = "";
            this.fld_txtARInvoicePortOFDischarge.BOSDataMember = "ARInvoicePortOFDischarge";
            this.fld_txtARInvoicePortOFDischarge.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoicePortOFDischarge.BOSDescription = null;
            this.fld_txtARInvoicePortOFDischarge.BOSError = null;
            this.fld_txtARInvoicePortOFDischarge.BOSFieldGroup = "";
            this.fld_txtARInvoicePortOFDischarge.BOSFieldRelation = "";
            this.fld_txtARInvoicePortOFDischarge.BOSPrivilege = "";
            this.fld_txtARInvoicePortOFDischarge.BOSPropertyName = "EditValue";
            this.fld_txtARInvoicePortOFDischarge.EditValue = "";
            this.fld_txtARInvoicePortOFDischarge.Location = new System.Drawing.Point(102, 46);
            this.fld_txtARInvoicePortOFDischarge.Name = "fld_txtARInvoicePortOFDischarge";
            this.fld_txtARInvoicePortOFDischarge.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoicePortOFDischarge.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoicePortOFDischarge.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoicePortOFDischarge.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoicePortOFDischarge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoicePortOFDischarge.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoicePortOFDischarge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoicePortOFDischarge.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARInvoicePortOFDischarge, true);
            this.fld_txtARInvoicePortOFDischarge.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARInvoicePortOFDischarge.TabIndex = 2;
            this.fld_txtARInvoicePortOFDischarge.Tag = "DC";
            // 
            // fld_lkeFK_GETerminalID
            // 
            this.fld_lkeFK_GETerminalID.BOSAllowAddNew = false;
            this.fld_lkeFK_GETerminalID.BOSAllowDummy = true;
            this.fld_lkeFK_GETerminalID.BOSComment = null;
            this.fld_lkeFK_GETerminalID.BOSDataMember = "FK_GETerminalID";
            this.fld_lkeFK_GETerminalID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_GETerminalID.BOSDescription = null;
            this.fld_lkeFK_GETerminalID.BOSError = null;
            this.fld_lkeFK_GETerminalID.BOSFieldGroup = null;
            this.fld_lkeFK_GETerminalID.BOSFieldParent = null;
            this.fld_lkeFK_GETerminalID.BOSFieldRelation = null;
            this.fld_lkeFK_GETerminalID.BOSPrivilege = null;
            this.fld_lkeFK_GETerminalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GETerminalID.BOSSelectType = "";
            this.fld_lkeFK_GETerminalID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GETerminalID.CurrentDisplayText = null;
            this.fld_lkeFK_GETerminalID.Location = new System.Drawing.Point(102, 20);
            this.fld_lkeFK_GETerminalID.Name = "fld_lkeFK_GETerminalID";
            this.fld_lkeFK_GETerminalID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GETerminalID.Properties.ColumnName = null;
            this.fld_lkeFK_GETerminalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã cảng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên cảng")});
            this.fld_lkeFK_GETerminalID.Properties.DisplayMember = "GETerminalName";
            this.fld_lkeFK_GETerminalID.Properties.NullText = "";
            this.fld_lkeFK_GETerminalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GETerminalID.Properties.ValueMember = "GETerminalID";
            this.fld_lkeFK_GETerminalID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GETerminalID, true);
            this.fld_lkeFK_GETerminalID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_GETerminalID.TabIndex = 0;
            this.fld_lkeFK_GETerminalID.Tag = "DC";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
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
            this.bosLabel30.Location = new System.Drawing.Point(15, 23);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel30, true);
            this.bosLabel30.Size = new System.Drawing.Size(72, 13);
            this.bosLabel30.TabIndex = 838;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Cảng xuất POL";
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
            this.bosLabel36.Location = new System.Drawing.Point(15, 49);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel36, true);
            this.bosLabel36.Size = new System.Drawing.Size(76, 13);
            this.bosLabel36.TabIndex = 839;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Cảng nhập POD";
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
            this.bosPanel1.Controls.Add(this.bosLine5);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderSOCommissionAmount);
            this.bosPanel1.Controls.Add(this.bosLabel28);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderCustomerCommissionPercent);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_pteARInvoiceEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceItems);
            this.bosPanel1.Controls.Add(this.fld_Line4);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDepositBalance);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceBalanceDue);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDiscountPerCent);
            this.bosPanel1.Controls.Add(this.BOSLabel9);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.BOSLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel43);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1223, 961);
            this.bosPanel1.TabIndex = 0;
            // 
            // DMIV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1223, 961);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMIV100.IconOptions.Icon")));
            this.Name = "DMIV100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arInvoiceItemsGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookupEdit1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDocumentEntryGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceComment.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceInternalComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).EndInit();
            this.fld_Line4.ResumeLayout(false);
            this.fld_Line4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).EndInit();
            this.fld_tabInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            this.fld_tabPageInvoiceCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItemCosts)).EndInit();
            this.fld_tabPageInvoiceCommission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommissionsGridControl)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATPaymentContactInformation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceValidateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderCustomerCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSOCommissionAmount.Properties)).EndInit();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceWaybillNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoicePortEndShipmentText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoicePortOFDischarge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private BOSComponent.BOSLabel bosLabel2;
        private ARInvoiceItemsGridControl arInvoiceItemsGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private ItemLookupEdit itemLookupEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BaseDocumentEntryGridControl baseDocumentEntryGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddCost;
        private BOSERP.Modules.SaleOrder.ARSaleOrderItemCostGridControl fld_dgcARSaleOrderItemCosts;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTaxPercent;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSubTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel BOSLabel8;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLine fld_Line3;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceComment;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceInternalComment;
        private BOSComponent.BOSLabel BOSLabel9;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDiscountFix;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtARInvoiceBalanceDue;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTaxAmount;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDepositBalance;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTotalAmount;
        private BOSComponent.BOSLine fld_Line4;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel fld_lblLabel34;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel36;
        private BOSComponent.BOSButton fld_btnEditShippingInfo;
        private BOSComponent.BOSLabel fld_lblLabel37;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSTabControl fld_tabInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceItems;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceItemProductPicture;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private ARInvoiceItemsGridControl fld_dgcARInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceCost;
        private ARInvoiceItemCostGridControl fld_dgcARInvoiceItemCosts;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceCommission;
        private ARInvoiceCommissionsGridControl fld_dgcCommissionsGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATPaymentContactInformation;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSOContactName;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeAROutputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATInvoiceNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATTaxNumber;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATFormNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATSymbol;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceValidateDate;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel85;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceProductType;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo1;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceDesc;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDeliveryDate;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceStatus1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARInvoiceExchangeRate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderCustomerCommissionPercent;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSOCommissionAmount;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSTextBox fld_txtARInvoiceWaybillNumber;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSTextBox fld_txtARInvoicePortEndShipmentText;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTextBox fld_txtARInvoicePortOFDischarge;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GETerminalID;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        //private IContainer components;
    }
}
