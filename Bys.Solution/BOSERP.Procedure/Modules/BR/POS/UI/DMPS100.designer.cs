using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.POS.UI
{
    /// <summary>
    /// Summary description for DMPS100
    /// </summary>
    partial class DMPS100
    {
        private BOSComponent.BOSLabel fld_lblLabel4;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private ARInoviceItemsGridControl fld_dgcARInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoiceItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSubTotalAmount;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceEmployeePicture;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceItemProductPicture;
        private BOSComponent.BOSLabel fld_lblBRPOSDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDiscountPerCent;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPS100));
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARInvoiceItems = new BOSERP.Modules.POS.ARInoviceItemsGridControl();
            this.fld_dgvARInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteARInvoiceItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARInvoiceTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteARInvoiceEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblBRPOSDate = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARInvoiceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeARInvoiceStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medARInvoiceComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_txtARInvoiceSOContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceSOContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceSOContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeInvoiceIsReceiveBill = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnAddCustomers = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATPaymentContactInformation = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAROutputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.BOSLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabInvoiceItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAutoSelectProductSerialNo = new BOSComponent.BOSButton(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceShippingFees = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceExchangeRate.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceComment.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactName.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeInvoiceIsReceiveBill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATPaymentContactInformation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).BeginInit();
            this.fld_tabInvoiceItems.SuspendLayout();
            this.fld_tabPageInvoiceItems.SuspendLayout();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceShippingFees.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(7, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 387;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            //this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARInvoiceItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(70, 9);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "Barcode", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(1011, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductAttributeID_QueryPopUp);
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARInvoiceItems
            // 
            this.fld_dgcARInvoiceItems.AllowDrop = true;
            this.fld_dgcARInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoiceItems.BOSComment = "";
            this.fld_dgcARInvoiceItems.BOSDataMember = null;
            this.fld_dgcARInvoiceItems.BOSDataSource = "ARInvoiceItems";
            this.fld_dgcARInvoiceItems.BOSDescription = null;
            this.fld_dgcARInvoiceItems.BOSError = "";
            this.fld_dgcARInvoiceItems.BOSFieldGroup = "";
            this.fld_dgcARInvoiceItems.BOSFieldRelation = null;
            this.fld_dgcARInvoiceItems.BOSGridType = null;
            this.fld_dgcARInvoiceItems.BOSPrivilege = "";
            this.fld_dgcARInvoiceItems.BOSPropertyName = null;
            this.fld_dgcARInvoiceItems.CommodityType = "";
            this.fld_dgcARInvoiceItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoiceItems.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcARInvoiceItems.MainView = this.fld_dgvARInvoiceItems;
            this.fld_dgcARInvoiceItems.Name = "fld_dgcARInvoiceItems";
            this.fld_dgcARInvoiceItems.PrintReport = false;
            this.fld_dgcARInvoiceItems.Screen = null;
            this.fld_dgcARInvoiceItems.Size = new System.Drawing.Size(1074, 263);
            this.fld_dgcARInvoiceItems.TabIndex = 1;
            this.fld_dgcARInvoiceItems.Tag = "DC";
            this.fld_dgcARInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoiceItems});
            // 
            // fld_dgvARInvoiceItems
            // 
            this.fld_dgvARInvoiceItems.GridControl = this.fld_dgcARInvoiceItems;
            this.fld_dgvARInvoiceItems.Name = "fld_dgvARInvoiceItems";
            this.fld_dgvARInvoiceItems.PaintStyleName = "Office2003";
            // 
            // fld_pteARInvoiceItemProductPicture
            // 
            this.fld_pteARInvoiceItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARInvoiceItemProductPicture.BOSComment = "";
            this.fld_pteARInvoiceItemProductPicture.BOSDataMember = "ARInvoiceItemProductPicture";
            this.fld_pteARInvoiceItemProductPicture.BOSDataSource = "ARInvoiceItems";
            this.fld_pteARInvoiceItemProductPicture.BOSDescription = null;
            this.fld_pteARInvoiceItemProductPicture.BOSError = "";
            this.fld_pteARInvoiceItemProductPicture.BOSFieldGroup = "";
            this.fld_pteARInvoiceItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARInvoiceItemProductPicture.BOSPrivilege = "";
            this.fld_pteARInvoiceItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARInvoiceItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARInvoiceItemProductPicture.FileName = null;
            this.fld_pteARInvoiceItemProductPicture.FilePath = null;
            this.fld_pteARInvoiceItemProductPicture.Location = new System.Drawing.Point(1087, 37);
            this.fld_pteARInvoiceItemProductPicture.Name = "fld_pteARInvoiceItemProductPicture";
            this.fld_pteARInvoiceItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARInvoiceItemProductPicture.Screen = null;
            this.fld_pteARInvoiceItemProductPicture.Size = new System.Drawing.Size(140, 132);
            this.fld_pteARInvoiceItemProductPicture.TabIndex = 2;
            this.fld_pteARInvoiceItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 104);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 9;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "";
            this.fld_lblLabel15.BOSDataSource = "";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = null;
            this.fld_lblLabel15.Location = new System.Drawing.Point(998, 579);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel15.TabIndex = 22;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tổng cộng";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseFont = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = null;
            this.fld_lblLabel19.Location = new System.Drawing.Point(975, 681);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(73, 14);
            this.fld_lblLabel19.TabIndex = 32;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "THÀNH TIỀN";
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = "";
            this.fld_lblLabel20.BOSDataMember = "";
            this.fld_lblLabel20.BOSDataSource = "";
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = "";
            this.fld_lblLabel20.BOSFieldRelation = "";
            this.fld_lblLabel20.BOSPrivilege = "ChangePriceLevel";
            this.fld_lblLabel20.BOSPropertyName = null;
            this.fld_lblLabel20.Location = new System.Drawing.Point(1011, 554);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel20.TabIndex = 20;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Mức giá";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = "";
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(1065, 551);
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
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 4;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_txtARInvoiceTotalAmount
            // 
            this.fld_txtARInvoiceTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTotalAmount.BOSComment = "";
            this.fld_txtARInvoiceTotalAmount.BOSDataMember = "ARInvoiceTotalAmount";
            this.fld_txtARInvoiceTotalAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTotalAmount.BOSDescription = null;
            this.fld_txtARInvoiceTotalAmount.BOSError = "";
            this.fld_txtARInvoiceTotalAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceTotalAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceTotalAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARInvoiceTotalAmount.Location = new System.Drawing.Point(1065, 679);
            this.fld_txtARInvoiceTotalAmount.Name = "fld_txtARInvoiceTotalAmount";
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARInvoiceTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARInvoiceTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTotalAmount.Screen = null;
            this.fld_txtARInvoiceTotalAmount.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARInvoiceTotalAmount.TabIndex = 11;
            this.fld_txtARInvoiceTotalAmount.Tag = "DC";
            // 
            // fld_txtARInvoiceDiscountFix
            // 
            this.fld_txtARInvoiceDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceDiscountFix.BOSComment = "";
            this.fld_txtARInvoiceDiscountFix.BOSDataMember = "ARInvoiceDiscountFix";
            this.fld_txtARInvoiceDiscountFix.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceDiscountFix.BOSDescription = null;
            this.fld_txtARInvoiceDiscountFix.BOSError = "";
            this.fld_txtARInvoiceDiscountFix.BOSFieldGroup = "";
            this.fld_txtARInvoiceDiscountFix.BOSFieldRelation = "";
            this.fld_txtARInvoiceDiscountFix.BOSPrivilege = "";
            this.fld_txtARInvoiceDiscountFix.BOSPropertyName = "Text";
            this.fld_txtARInvoiceDiscountFix.Location = new System.Drawing.Point(1129, 601);
            this.fld_txtARInvoiceDiscountFix.Name = "fld_txtARInvoiceDiscountFix";
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDiscountFix.Screen = null;
            this.fld_txtARInvoiceDiscountFix.Size = new System.Drawing.Size(104, 20);
            this.fld_txtARInvoiceDiscountFix.TabIndex = 7;
            this.fld_txtARInvoiceDiscountFix.Tag = "DC";
            this.fld_txtARInvoiceDiscountFix.Validated += new System.EventHandler(this.fld_txtBRPOSDiscountAmount_Validated);
            // 
            // fld_txtARInvoiceSubTotalAmount
            // 
            this.fld_txtARInvoiceSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceSubTotalAmount.BOSComment = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSDataMember = "ARInvoiceSubTotalAmount";
            this.fld_txtARInvoiceSubTotalAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceSubTotalAmount.BOSDescription = null;
            this.fld_txtARInvoiceSubTotalAmount.BOSError = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARInvoiceSubTotalAmount.Location = new System.Drawing.Point(1065, 576);
            this.fld_txtARInvoiceSubTotalAmount.Name = "fld_txtARInvoiceSubTotalAmount";
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARInvoiceSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSubTotalAmount.Screen = null;
            this.fld_txtARInvoiceSubTotalAmount.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARInvoiceSubTotalAmount.TabIndex = 5;
            this.fld_txtARInvoiceSubTotalAmount.Tag = "DC";
            // 
            // fld_pteARInvoiceEmployeePicture
            // 
            this.fld_pteARInvoiceEmployeePicture.BOSComment = "";
            this.fld_pteARInvoiceEmployeePicture.BOSDataMember = "ARInvoiceEmployeePicture";
            this.fld_pteARInvoiceEmployeePicture.BOSDataSource = "ARInvoices";
            this.fld_pteARInvoiceEmployeePicture.BOSDescription = null;
            this.fld_pteARInvoiceEmployeePicture.BOSError = "";
            this.fld_pteARInvoiceEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARInvoiceEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARInvoiceEmployeePicture.BOSPrivilege = "";
            this.fld_pteARInvoiceEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARInvoiceEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARInvoiceEmployeePicture.FileName = null;
            this.fld_pteARInvoiceEmployeePicture.FilePath = null;
            this.fld_pteARInvoiceEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARInvoiceEmployeePicture.Name = "fld_pteARInvoiceEmployeePicture";
            this.fld_pteARInvoiceEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARInvoiceEmployeePicture.Screen = null;
            this.fld_pteARInvoiceEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARInvoiceEmployeePicture.TabIndex = 0;
            this.fld_pteARInvoiceEmployeePicture.Tag = "DC";
            // 
            // fld_lblBRPOSDate
            // 
            this.fld_lblBRPOSDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblBRPOSDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_lblBRPOSDate.Appearance.Options.UseBackColor = true;
            this.fld_lblBRPOSDate.Appearance.Options.UseForeColor = true;
            this.fld_lblBRPOSDate.BOSComment = "";
            this.fld_lblBRPOSDate.BOSDataMember = "";
            this.fld_lblBRPOSDate.BOSDataSource = "";
            this.fld_lblBRPOSDate.BOSDescription = null;
            this.fld_lblBRPOSDate.BOSError = null;
            this.fld_lblBRPOSDate.BOSFieldGroup = "";
            this.fld_lblBRPOSDate.BOSFieldRelation = "";
            this.fld_lblBRPOSDate.BOSPrivilege = "";
            this.fld_lblBRPOSDate.BOSPropertyName = null;
            this.fld_lblBRPOSDate.Location = new System.Drawing.Point(13, 101);
            this.fld_lblBRPOSDate.Name = "fld_lblBRPOSDate";
            this.fld_lblBRPOSDate.Screen = null;
            this.fld_lblBRPOSDate.Size = new System.Drawing.Size(67, 13);
            this.fld_lblBRPOSDate.TabIndex = 3;
            this.fld_lblBRPOSDate.Tag = "";
            this.fld_lblBRPOSDate.Text = "Ngày hóa đơn";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(272, 23);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel2.TabIndex = 5;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Tình trạng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(997, 604);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel7.TabIndex = 24;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Chiết khấu";
            // 
            // fld_txtARInvoiceDiscountPerCent
            // 
            this.fld_txtARInvoiceDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceDiscountPerCent.BOSComment = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSDataMember = "ARInvoiceDiscountPerCent";
            this.fld_txtARInvoiceDiscountPerCent.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceDiscountPerCent.BOSDescription = null;
            this.fld_txtARInvoiceDiscountPerCent.BOSError = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARInvoiceDiscountPerCent.BOSPropertyName = "Text";
            this.fld_txtARInvoiceDiscountPerCent.Location = new System.Drawing.Point(1065, 601);
            this.fld_txtARInvoiceDiscountPerCent.Name = "fld_txtARInvoiceDiscountPerCent";
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDiscountPerCent.Screen = null;
            this.fld_txtARInvoiceDiscountPerCent.Size = new System.Drawing.Size(60, 20);
            this.fld_txtARInvoiceDiscountPerCent.TabIndex = 6;
            this.fld_txtARInvoiceDiscountPerCent.Tag = "DC";
            this.fld_txtARInvoiceDiscountPerCent.Validated += new System.EventHandler(this.fld_txtBRPOSDiscountPerCent_Validated);
            // 
            // fld_dteARInvoiceDate
            // 
            this.fld_dteARInvoiceDate.BOSComment = null;
            this.fld_dteARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteARInvoiceDate.BOSDescription = null;
            this.fld_dteARInvoiceDate.BOSError = null;
            this.fld_dteARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteARInvoiceDate.BOSPrivilege = null;
            this.fld_dteARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDate.EditValue = null;
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(90, 98);
            this.fld_dteARInvoiceDate.MenuManager = this.screenToolbar;
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(162, 20);
            this.fld_dteARInvoiceDate.TabIndex = 6;
            this.fld_dteARInvoiceDate.Tag = "DC";
            this.fld_dteARInvoiceDate.Validated += new System.EventHandler(this.fld_dteARInvoiceDate_Validated);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel1.Location = new System.Drawing.Point(13, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã hóa đơn";
            // 
            // fld_txtARInvoiceNo
            // 
            this.fld_txtARInvoiceNo.BOSComment = null;
            this.fld_txtARInvoiceNo.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceNo.BOSFieldGroup = null;
            this.fld_txtARInvoiceNo.BOSFieldRelation = null;
            this.fld_txtARInvoiceNo.BOSPrivilege = null;
            this.fld_txtARInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceNo.Location = new System.Drawing.Point(90, 20);
            this.fld_txtARInvoiceNo.MenuManager = this.screenToolbar;
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Screen = null;
            this.fld_txtARInvoiceNo.Size = new System.Drawing.Size(162, 20);
            this.fld_txtARInvoiceNo.TabIndex = 0;
            this.fld_txtARInvoiceNo.Tag = "DC";
            // 
            // fld_medARInvoiceDesc
            // 
            this.fld_medARInvoiceDesc.BOSComment = null;
            this.fld_medARInvoiceDesc.BOSDataMember = "ARInvoiceDesc";
            this.fld_medARInvoiceDesc.BOSDataSource = "ARInvoices";
            this.fld_medARInvoiceDesc.BOSDescription = null;
            this.fld_medARInvoiceDesc.BOSError = null;
            this.fld_medARInvoiceDesc.BOSFieldGroup = null;
            this.fld_medARInvoiceDesc.BOSFieldRelation = null;
            this.fld_medARInvoiceDesc.BOSPrivilege = null;
            this.fld_medARInvoiceDesc.BOSPropertyName = "EditValue";
            this.fld_medARInvoiceDesc.Location = new System.Drawing.Point(90, 153);
            this.fld_medARInvoiceDesc.MenuManager = this.screenToolbar;
            this.fld_medARInvoiceDesc.Name = "fld_medARInvoiceDesc";
            this.fld_medARInvoiceDesc.Screen = null;
            this.fld_medARInvoiceDesc.Size = new System.Drawing.Size(404, 32);
            this.fld_medARInvoiceDesc.TabIndex = 8;
            this.fld_medARInvoiceDesc.Tag = "DC";
            // 
            // fld_lkeARInvoiceStatus
            // 
            this.fld_lkeARInvoiceStatus.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceStatus.BOSAllowDummy = false;
            this.fld_lkeARInvoiceStatus.BOSComment = null;
            this.fld_lkeARInvoiceStatus.BOSDataMember = "ARInvoiceStatus";
            this.fld_lkeARInvoiceStatus.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceStatus.BOSDescription = null;
            this.fld_lkeARInvoiceStatus.BOSError = null;
            this.fld_lkeARInvoiceStatus.BOSFieldGroup = null;
            this.fld_lkeARInvoiceStatus.BOSFieldParent = null;
            this.fld_lkeARInvoiceStatus.BOSFieldRelation = null;
            this.fld_lkeARInvoiceStatus.BOSPrivilege = null;
            this.fld_lkeARInvoiceStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceStatus.BOSSelectType = null;
            this.fld_lkeARInvoiceStatus.BOSSelectTypeValue = null;
            this.fld_lkeARInvoiceStatus.CurrentDisplayText = null;
            this.fld_lkeARInvoiceStatus.Location = new System.Drawing.Point(344, 20);
            this.fld_lkeARInvoiceStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARInvoiceStatus.Name = "fld_lkeARInvoiceStatus";
            this.fld_lkeARInvoiceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceStatus.Properties.ColumnName = null;
            this.fld_lkeARInvoiceStatus.Properties.NullText = "";
            this.fld_lkeARInvoiceStatus.Properties.ReadOnly = true;
            this.fld_lkeARInvoiceStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceStatus.Screen = null;
            this.fld_lkeARInvoiceStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceStatus.TabIndex = 1;
            this.fld_lkeARInvoiceStatus.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel2.Location = new System.Drawing.Point(1024, 656);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(24, 13);
            this.bosLabel2.TabIndex = 29;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Thuế";
            // 
            // fld_txtARInvoiceTaxPercent
            // 
            this.fld_txtARInvoiceTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTaxPercent.BOSComment = "";
            this.fld_txtARInvoiceTaxPercent.BOSDataMember = "ARInvoiceTaxPercent";
            this.fld_txtARInvoiceTaxPercent.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTaxPercent.BOSDescription = null;
            this.fld_txtARInvoiceTaxPercent.BOSError = "";
            this.fld_txtARInvoiceTaxPercent.BOSFieldGroup = "";
            this.fld_txtARInvoiceTaxPercent.BOSFieldRelation = "";
            this.fld_txtARInvoiceTaxPercent.BOSPrivilege = "";
            this.fld_txtARInvoiceTaxPercent.BOSPropertyName = "Text";
            this.fld_txtARInvoiceTaxPercent.Location = new System.Drawing.Point(1065, 653);
            this.fld_txtARInvoiceTaxPercent.Name = "fld_txtARInvoiceTaxPercent";
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTaxPercent.Screen = null;
            this.fld_txtARInvoiceTaxPercent.Size = new System.Drawing.Size(60, 20);
            this.fld_txtARInvoiceTaxPercent.TabIndex = 9;
            this.fld_txtARInvoiceTaxPercent.Tag = "DC";
            this.fld_txtARInvoiceTaxPercent.Validated += new System.EventHandler(this.fld_txtBRPOSDiscountAmount_Validated);
            // 
            // fld_txtARInvoiceTaxAmount
            // 
            this.fld_txtARInvoiceTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceTaxAmount.BOSComment = "";
            this.fld_txtARInvoiceTaxAmount.BOSDataMember = "ARInvoiceTaxAmount";
            this.fld_txtARInvoiceTaxAmount.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceTaxAmount.BOSDescription = null;
            this.fld_txtARInvoiceTaxAmount.BOSError = "";
            this.fld_txtARInvoiceTaxAmount.BOSFieldGroup = "";
            this.fld_txtARInvoiceTaxAmount.BOSFieldRelation = "";
            this.fld_txtARInvoiceTaxAmount.BOSPrivilege = "";
            this.fld_txtARInvoiceTaxAmount.BOSPropertyName = "Text";
            this.fld_txtARInvoiceTaxAmount.Location = new System.Drawing.Point(1129, 653);
            this.fld_txtARInvoiceTaxAmount.Name = "fld_txtARInvoiceTaxAmount";
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceTaxAmount.Screen = null;
            this.fld_txtARInvoiceTaxAmount.Size = new System.Drawing.Size(104, 20);
            this.fld_txtARInvoiceTaxAmount.TabIndex = 10;
            this.fld_txtARInvoiceTaxAmount.Tag = "DC";
            this.fld_txtARInvoiceTaxAmount.Validated += new System.EventHandler(this.fld_txtBRPOSDiscountAmount_Validated);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 75);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 11;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARInvoices";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(90, 72);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(162, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel4.Location = new System.Drawing.Point(272, 75);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_txtARInvoiceExchangeRate
            // 
            this.fld_txtARInvoiceExchangeRate.BOSComment = null;
            this.fld_txtARInvoiceExchangeRate.BOSDataMember = "ARInvoiceExchangeRate";
            this.fld_txtARInvoiceExchangeRate.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceExchangeRate.BOSDescription = null;
            this.fld_txtARInvoiceExchangeRate.BOSError = null;
            this.fld_txtARInvoiceExchangeRate.BOSFieldGroup = null;
            this.fld_txtARInvoiceExchangeRate.BOSFieldRelation = null;
            this.fld_txtARInvoiceExchangeRate.BOSPrivilege = null;
            this.fld_txtARInvoiceExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceExchangeRate.Location = new System.Drawing.Point(344, 72);
            this.fld_txtARInvoiceExchangeRate.Name = "fld_txtARInvoiceExchangeRate";
            this.fld_txtARInvoiceExchangeRate.Screen = null;
            this.fld_txtARInvoiceExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARInvoiceExchangeRate.TabIndex = 5;
            this.fld_txtARInvoiceExchangeRate.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medARInvoiceComment);
            this.bosLine1.Location = new System.Drawing.Point(3, 554);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(364, 195);
            this.bosLine1.TabIndex = 3;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
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
            this.fld_medARInvoiceComment.Name = "fld_medARInvoiceComment";
            this.fld_medARInvoiceComment.Screen = null;
            this.fld_medARInvoiceComment.Size = new System.Drawing.Size(358, 175);
            this.fld_medARInvoiceComment.TabIndex = 0;
            this.fld_medARInvoiceComment.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDepositBalance);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceBalanceDue);
            this.bosPanel1.Controls.Add(this.BOSLabel9);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceItems);
            this.bosPanel1.Controls.Add(this.fld_pteARInvoiceEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceShippingFees);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel19);
            this.bosPanel1.Controls.Add(this.fld_lblLabel15);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceSubTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTaxAmount);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1247, 761);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLine2
            // 
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
            this.bosLine2.Controls.Add(this.fld_txtARInvoiceSOContactEmail1);
            this.bosLine2.Controls.Add(this.bosLabel24);
            this.bosLine2.Controls.Add(this.bosLabel25);
            this.bosLine2.Controls.Add(this.bosLabel26);
            this.bosLine2.Controls.Add(this.fld_txtARInvoiceSOContactPhone);
            this.bosLine2.Controls.Add(this.fld_txtARInvoiceSOContactName);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(626, 136);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(512, 75);
            this.bosLine2.TabIndex = 52;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Thông tin người mua hàng";
            // 
            // fld_txtARInvoiceSOContactEmail1
            // 
            this.fld_txtARInvoiceSOContactEmail1.BOSComment = "";
            this.fld_txtARInvoiceSOContactEmail1.BOSDataMember = "ARInvoiceSOContactEmail1";
            this.fld_txtARInvoiceSOContactEmail1.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceSOContactEmail1.BOSDescription = null;
            this.fld_txtARInvoiceSOContactEmail1.BOSError = null;
            this.fld_txtARInvoiceSOContactEmail1.BOSFieldGroup = "";
            this.fld_txtARInvoiceSOContactEmail1.BOSFieldRelation = "";
            this.fld_txtARInvoiceSOContactEmail1.BOSPrivilege = "";
            this.fld_txtARInvoiceSOContactEmail1.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceSOContactEmail1.EditValue = "";
            this.fld_txtARInvoiceSOContactEmail1.Location = new System.Drawing.Point(102, 46);
            this.fld_txtARInvoiceSOContactEmail1.Name = "fld_txtARInvoiceSOContactEmail1";
            this.fld_txtARInvoiceSOContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceSOContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSOContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSOContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSOContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSOContactEmail1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceSOContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSOContactEmail1.Screen = null;
            this.fld_txtARInvoiceSOContactEmail1.Size = new System.Drawing.Size(392, 20);
            this.fld_txtARInvoiceSOContactEmail1.TabIndex = 87;
            this.fld_txtARInvoiceSOContactEmail1.Tag = "DC";
            // 
            // bosLabel24
            // 
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
            this.bosLabel24.Location = new System.Drawing.Point(260, 23);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(62, 13);
            this.bosLabel24.TabIndex = 85;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Số điện thoại";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
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
            this.bosLabel25.Location = new System.Drawing.Point(15, 53);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(24, 13);
            this.bosLabel25.TabIndex = 83;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Email";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
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
            this.bosLabel26.Location = new System.Drawing.Point(15, 23);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(78, 13);
            this.bosLabel26.TabIndex = 76;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Người mua hàng";
            // 
            // fld_txtARInvoiceSOContactPhone
            // 
            this.fld_txtARInvoiceSOContactPhone.BOSComment = "";
            this.fld_txtARInvoiceSOContactPhone.BOSDataMember = "ARInvoiceSOContactPhone";
            this.fld_txtARInvoiceSOContactPhone.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceSOContactPhone.BOSDescription = null;
            this.fld_txtARInvoiceSOContactPhone.BOSError = null;
            this.fld_txtARInvoiceSOContactPhone.BOSFieldGroup = "";
            this.fld_txtARInvoiceSOContactPhone.BOSFieldRelation = "";
            this.fld_txtARInvoiceSOContactPhone.BOSPrivilege = "";
            this.fld_txtARInvoiceSOContactPhone.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceSOContactPhone.EditValue = "";
            this.fld_txtARInvoiceSOContactPhone.Location = new System.Drawing.Point(351, 20);
            this.fld_txtARInvoiceSOContactPhone.Name = "fld_txtARInvoiceSOContactPhone";
            this.fld_txtARInvoiceSOContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceSOContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSOContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSOContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSOContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSOContactPhone.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceSOContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSOContactPhone.Screen = null;
            this.fld_txtARInvoiceSOContactPhone.Size = new System.Drawing.Size(143, 20);
            this.fld_txtARInvoiceSOContactPhone.TabIndex = 4;
            this.fld_txtARInvoiceSOContactPhone.Tag = "DC";
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
            this.fld_txtARInvoiceSOContactName.Location = new System.Drawing.Point(102, 20);
            this.fld_txtARInvoiceSOContactName.Name = "fld_txtARInvoiceSOContactName";
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceSOContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceSOContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceSOContactName.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceSOContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceSOContactName.Screen = null;
            this.fld_txtARInvoiceSOContactName.Size = new System.Drawing.Size(143, 20);
            this.fld_txtARInvoiceSOContactName.TabIndex = 5;
            this.fld_txtARInvoiceSOContactName.Tag = "DC";
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
            this.bosLine4.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosLine4.Controls.Add(this.fld_Lablel3);
            this.bosLine4.Controls.Add(this.bosLabel10);
            this.bosLine4.Controls.Add(this.bosLookupEdit1);
            this.bosLine4.Controls.Add(this.fld_medARInvoiceDesc);
            this.bosLine4.Controls.Add(this.fld_lkeARSellerID);
            this.bosLine4.Controls.Add(this.fld_ckeInvoiceIsReceiveBill);
            this.bosLine4.Controls.Add(this.fld_lblLabel2);
            this.bosLine4.Controls.Add(this.fld_btnAddCustomers);
            this.bosLine4.Controls.Add(this.bosLabel6);
            this.bosLine4.Controls.Add(this.fld_lblLabel5);
            this.bosLine4.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosLine4.Controls.Add(this.fld_txtARInvoiceNo);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine4.Controls.Add(this.fld_txtARInvoiceExchangeRate);
            this.bosLine4.Controls.Add(this.fld_lkeARInvoiceStatus);
            this.bosLine4.Controls.Add(this.bosLabel1);
            this.bosLine4.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine4.Controls.Add(this.bosLabel4);
            this.bosLine4.Controls.Add(this.bosLabel3);
            this.bosLine4.Controls.Add(this.bosLabel5);
            this.bosLine4.Controls.Add(this.fld_lblBRPOSDate);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(109, 4);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(511, 207);
            this.bosLine4.TabIndex = 0;
            this.bosLine4.TabStop = false;
            this.bosLine4.Tag = "";
            this.bosLine4.Text = "Thông tin khác";
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(344, 98);
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
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 712;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
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
            this.fld_Lablel3.Location = new System.Drawing.Point(272, 101);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 713;
            this.fld_Lablel3.Text = "Kho";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(13, 127);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(72, 13);
            this.bosLabel10.TabIndex = 99;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Kênh bán hàng";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "ARListOfSalesChannelType";
            this.bosLookupEdit1.BOSDataSource = "ARInvoices";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(90, 124);
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
            this.bosLookupEdit1.Size = new System.Drawing.Size(162, 20);
            this.bosLookupEdit1.TabIndex = 98;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_lkeARSellerID
            // 
            this.fld_lkeARSellerID.BOSAllowAddNew = false;
            this.fld_lkeARSellerID.BOSAllowDummy = false;
            this.fld_lkeARSellerID.BOSComment = "";
            this.fld_lkeARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeARSellerID.BOSDataSource = "ARInvoices";
            this.fld_lkeARSellerID.BOSDescription = null;
            this.fld_lkeARSellerID.BOSError = "";
            this.fld_lkeARSellerID.BOSFieldGroup = "";
            this.fld_lkeARSellerID.BOSFieldParent = "";
            this.fld_lkeARSellerID.BOSFieldRelation = "";
            this.fld_lkeARSellerID.BOSPrivilege = "";
            this.fld_lkeARSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeARSellerID.BOSSelectType = "";
            this.fld_lkeARSellerID.BOSSelectTypeValue = "";
            this.fld_lkeARSellerID.CurrentDisplayText = "";
            this.fld_lkeARSellerID.Location = new System.Drawing.Point(344, 46);
            this.fld_lkeARSellerID.Name = "fld_lkeARSellerID";
            this.fld_lkeARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSellerID.Properties.ColumnName = null;
            this.fld_lkeARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeARSellerID.Properties.NullText = "";
            this.fld_lkeARSellerID.Properties.PopupWidth = 40;
            this.fld_lkeARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeARSellerID.Screen = null;
            this.fld_lkeARSellerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSellerID.TabIndex = 3;
            this.fld_lkeARSellerID.Tag = "DC";
            // 
            // fld_ckeInvoiceIsReceiveBill
            // 
            this.fld_ckeInvoiceIsReceiveBill.BOSComment = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSDataMember = "ARInvoiceIsReceiveBill";
            this.fld_ckeInvoiceIsReceiveBill.BOSDataSource = "ARInvoices";
            this.fld_ckeInvoiceIsReceiveBill.BOSDescription = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSError = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSFieldGroup = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSFieldRelation = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSPrivilege = null;
            this.fld_ckeInvoiceIsReceiveBill.BOSPropertyName = "EditValue";
            this.fld_ckeInvoiceIsReceiveBill.Location = new System.Drawing.Point(344, 124);
            this.fld_ckeInvoiceIsReceiveBill.Name = "fld_ckeInvoiceIsReceiveBill";
            this.fld_ckeInvoiceIsReceiveBill.Properties.Caption = "Xuất hóa đơn";
            this.fld_ckeInvoiceIsReceiveBill.Screen = null;
            this.fld_ckeInvoiceIsReceiveBill.Size = new System.Drawing.Size(96, 20);
            this.fld_ckeInvoiceIsReceiveBill.TabIndex = 7;
            this.fld_ckeInvoiceIsReceiveBill.Tag = "DC";
            // 
            // fld_btnAddCustomers
            // 
            this.fld_btnAddCustomers.BOSComment = null;
            this.fld_btnAddCustomers.BOSDataMember = null;
            this.fld_btnAddCustomers.BOSDataSource = null;
            this.fld_btnAddCustomers.BOSDescription = null;
            this.fld_btnAddCustomers.BOSError = null;
            this.fld_btnAddCustomers.BOSFieldGroup = null;
            this.fld_btnAddCustomers.BOSFieldRelation = null;
            this.fld_btnAddCustomers.BOSPrivilege = null;
            this.fld_btnAddCustomers.BOSPropertyName = null;
            this.fld_btnAddCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnAddCustomers.ImageOptions.Image")));
            this.fld_btnAddCustomers.Location = new System.Drawing.Point(222, 42);
            this.fld_btnAddCustomers.Name = "fld_btnAddCustomers";
            this.fld_btnAddCustomers.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddCustomers, true);
            this.fld_btnAddCustomers.Size = new System.Drawing.Size(30, 24);
            this.fld_btnAddCustomers.TabIndex = 97;
            this.fld_btnAddCustomers.Click += new System.EventHandler(this.fld_btnAddCustomers_Click);
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(13, 155);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 13;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Diễn giải";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 49);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 96;
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(90, 46);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(126, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel5.Location = new System.Drawing.Point(272, 49);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 9;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Người bán";
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
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosLine3.Controls.Add(this.bosLabel11);
            this.bosLine3.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosLine3.Controls.Add(this.bosLabel12);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATPaymentContactInformation);
            this.bosLine3.Controls.Add(this.bosLabel20);
            this.bosLine3.Controls.Add(this.bosLabel19);
            this.bosLine3.Controls.Add(this.fld_lkeAROutputVATDocumentType);
            this.bosLine3.Controls.Add(this.bosLabel14);
            this.bosLine3.Controls.Add(this.bosLabel15);
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATInvoiceNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATTaxNumber);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATFormNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATSymbol);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(626, 4);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(512, 126);
            this.bosLine3.TabIndex = 1;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin VAT";
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
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(351, 20);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeTemplateCode", "Mẫu số"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeSeries", "Kí hiệu")});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.DisplayMember = "ACEInvoiceTypeNo";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.NullText = "";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ValueMember = "ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Screen = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 1;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEInvoiceTypeID_CloseUp);
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(260, 23);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(85, 13);
            this.bosLabel11.TabIndex = 92;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Mã hóa đơn GTGT";
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
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(102, 98);
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
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 6;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(15, 23);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 75;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Loại hóa đơn";
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
            this.bosLabel21.Location = new System.Drawing.Point(15, 101);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(24, 13);
            this.bosLabel21.TabIndex = 90;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "PTTT";
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
            this.fld_txtARInvoiceVATPaymentContactInformation.Location = new System.Drawing.Point(351, 72);
            this.fld_txtARInvoiceVATPaymentContactInformation.Name = "fld_txtARInvoiceVATPaymentContactInformation";
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATPaymentContactInformation.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATPaymentContactInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATPaymentContactInformation.Screen = null;
            this.fld_txtARInvoiceVATPaymentContactInformation.Size = new System.Drawing.Size(143, 20);
            this.fld_txtARInvoiceVATPaymentContactInformation.TabIndex = 8;
            this.fld_txtARInvoiceVATPaymentContactInformation.Tag = "DC";
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
            this.bosLabel20.Location = new System.Drawing.Point(260, 49);
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
            this.bosLabel19.Location = new System.Drawing.Point(15, 75);
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
            this.fld_lkeAROutputVATDocumentType.Location = new System.Drawing.Point(102, 20);
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
            this.fld_lkeAROutputVATDocumentType.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeAROutputVATDocumentType.TabIndex = 0;
            this.fld_lkeAROutputVATDocumentType.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(260, 75);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(59, 13);
            this.bosLabel14.TabIndex = 83;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Đơn vị (Cty)";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(15, 49);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(34, 13);
            this.bosLabel15.TabIndex = 76;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Mẫu số";
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
            this.bosLabel18.Location = new System.Drawing.Point(260, 101);
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
            this.fld_txtARInvoiceVATInvoiceNo.Location = new System.Drawing.Point(102, 72);
            this.fld_txtARInvoiceVATInvoiceNo.Name = "fld_txtARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATInvoiceNo.Screen = null;
            this.fld_txtARInvoiceVATInvoiceNo.Size = new System.Drawing.Size(143, 20);
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
            this.fld_txtARInvoiceVATTaxNumber.Location = new System.Drawing.Point(351, 98);
            this.fld_txtARInvoiceVATTaxNumber.Name = "fld_txtARInvoiceVATTaxNumber";
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATTaxNumber.Screen = null;
            this.fld_txtARInvoiceVATTaxNumber.Size = new System.Drawing.Size(143, 20);
            this.fld_txtARInvoiceVATTaxNumber.TabIndex = 7;
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
            this.fld_txtARInvoiceVATFormNo.Location = new System.Drawing.Point(102, 46);
            this.fld_txtARInvoiceVATFormNo.Name = "fld_txtARInvoiceVATFormNo";
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATFormNo.Screen = null;
            this.fld_txtARInvoiceVATFormNo.Size = new System.Drawing.Size(143, 20);
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
            this.fld_txtARInvoiceVATSymbol.Location = new System.Drawing.Point(351, 46);
            this.fld_txtARInvoiceVATSymbol.Name = "fld_txtARInvoiceVATSymbol";
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATSymbol.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARInvoiceVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATSymbol.Screen = null;
            this.fld_txtARInvoiceVATSymbol.Size = new System.Drawing.Size(143, 20);
            this.fld_txtARInvoiceVATSymbol.TabIndex = 3;
            this.fld_txtARInvoiceVATSymbol.Tag = "DC";
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
            this.fld_txtARInvoiceDepositBalance.Location = new System.Drawing.Point(1065, 705);
            this.fld_txtARInvoiceDepositBalance.Name = "fld_txtARInvoiceDepositBalance";
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceDepositBalance.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceDepositBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceDepositBalance.Screen = null;
            this.fld_txtARInvoiceDepositBalance.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARInvoiceDepositBalance.TabIndex = 12;
            this.fld_txtARInvoiceDepositBalance.Tag = "DC";
            this.fld_txtARInvoiceDepositBalance.Validated += new System.EventHandler(this.fld_txtARInvoiceDepositBalance_Validated);
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
            this.fld_txtARInvoiceBalanceDue.Location = new System.Drawing.Point(1065, 731);
            this.fld_txtARInvoiceBalanceDue.Name = "fld_txtARInvoiceBalanceDue";
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceBalanceDue.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARInvoiceBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceBalanceDue.Properties.ReadOnly = true;
            this.fld_txtARInvoiceBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceBalanceDue.Screen = null;
            this.fld_txtARInvoiceBalanceDue.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARInvoiceBalanceDue.TabIndex = 13;
            this.fld_txtARInvoiceBalanceDue.Tag = "DC";
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
            this.BOSLabel9.Location = new System.Drawing.Point(1004, 734);
            this.BOSLabel9.Name = "BOSLabel9";
            this.BOSLabel9.Screen = null;
            this.BOSLabel9.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel9.TabIndex = 51;
            this.BOSLabel9.Tag = "";
            this.BOSLabel9.Text = "CÒN LẠI";
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
            this.fld_tabInvoiceItems.Location = new System.Drawing.Point(3, 217);
            this.fld_tabInvoiceItems.Name = "fld_tabInvoiceItems";
            this.fld_tabInvoiceItems.Screen = null;
            this.fld_tabInvoiceItems.SelectedTabPage = this.fld_tabPageInvoiceItems;
            this.fld_tabInvoiceItems.Size = new System.Drawing.Size(1232, 328);
            this.fld_tabInvoiceItems.TabIndex = 2;
            this.fld_tabInvoiceItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageInvoiceItems
            // 
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_btnAutoSelectProductSerialNo);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lblLabel4);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_dgcARInvoiceItems);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_pteARInvoiceItemProductPicture);
            this.fld_tabPageInvoiceItems.Name = "fld_tabPageInvoiceItems";
            this.fld_tabPageInvoiceItems.Size = new System.Drawing.Size(1230, 303);
            this.fld_tabPageInvoiceItems.Text = "Danh sách sản phẩm";
            // 
            // fld_btnAutoSelectProductSerialNo
            // 
            this.fld_btnAutoSelectProductSerialNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAutoSelectProductSerialNo.BOSComment = null;
            this.fld_btnAutoSelectProductSerialNo.BOSDataMember = null;
            this.fld_btnAutoSelectProductSerialNo.BOSDataSource = null;
            this.fld_btnAutoSelectProductSerialNo.BOSDescription = null;
            this.fld_btnAutoSelectProductSerialNo.BOSError = null;
            this.fld_btnAutoSelectProductSerialNo.BOSFieldGroup = null;
            this.fld_btnAutoSelectProductSerialNo.BOSFieldRelation = null;
            this.fld_btnAutoSelectProductSerialNo.BOSPrivilege = null;
            this.fld_btnAutoSelectProductSerialNo.BOSPropertyName = null;
            this.fld_btnAutoSelectProductSerialNo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnAutoSelectProductSerialNo.Location = new System.Drawing.Point(1087, 6);
            this.fld_btnAutoSelectProductSerialNo.Name = "fld_btnAutoSelectProductSerialNo";
            this.fld_btnAutoSelectProductSerialNo.Screen = null;
            this.fld_btnAutoSelectProductSerialNo.Size = new System.Drawing.Size(140, 23);
            this.fld_btnAutoSelectProductSerialNo.TabIndex = 388;
            this.fld_btnAutoSelectProductSerialNo.Text = "Tự động gắn lô";
            this.fld_btnAutoSelectProductSerialNo.Click += new System.EventHandler(this.fld_btnAutoSelectProductSerialNo_Click);
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1216, 296);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1216, 296);
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
            // bosLabel8
            // 
            this.bosLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel8.Location = new System.Drawing.Point(1005, 708);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(43, 13);
            this.bosLabel8.TabIndex = 27;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "ĐÃ TRẢ";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.bosLabel7.Location = new System.Drawing.Point(975, 629);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(73, 13);
            this.bosLabel7.TabIndex = 27;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Phí vận chuyển";
            // 
            // fld_txtARInvoiceShippingFees
            // 
            this.fld_txtARInvoiceShippingFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARInvoiceShippingFees.BOSComment = null;
            this.fld_txtARInvoiceShippingFees.BOSDataMember = "ARInvoiceShippingFees";
            this.fld_txtARInvoiceShippingFees.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceShippingFees.BOSDescription = null;
            this.fld_txtARInvoiceShippingFees.BOSError = null;
            this.fld_txtARInvoiceShippingFees.BOSFieldGroup = null;
            this.fld_txtARInvoiceShippingFees.BOSFieldRelation = null;
            this.fld_txtARInvoiceShippingFees.BOSPrivilege = null;
            this.fld_txtARInvoiceShippingFees.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceShippingFees.Location = new System.Drawing.Point(1065, 627);
            this.fld_txtARInvoiceShippingFees.Name = "fld_txtARInvoiceShippingFees";
            this.fld_txtARInvoiceShippingFees.Screen = null;
            this.fld_txtARInvoiceShippingFees.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARInvoiceShippingFees.TabIndex = 8;
            this.fld_txtARInvoiceShippingFees.Tag = "DC";
            this.fld_txtARInvoiceShippingFees.Validated += new System.EventHandler(this.fld_txtARInvoiceShippingFees_Validated);
            // 
            // DMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1247, 761);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPS100.IconOptions.Icon")));
            this.Name = "DMPS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceExchangeRate.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceComment.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSOContactName.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeInvoiceIsReceiveBill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATPaymentContactInformation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).EndInit();
            this.fld_tabInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.PerformLayout();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceShippingFees.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceDesc;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTaxAmount;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtARInvoiceExchangeRate;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeARSellerID;
        private BOSComponent.BOSTabControl fld_tabInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceComment;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARInvoiceShippingFees;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARInvoiceBalanceDue;
        private BOSComponent.BOSLabel BOSLabel9;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDepositBalance;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSButton fld_btnAddCustomers;
        private BOSComponent.BOSCheckEdit fld_ckeInvoiceIsReceiveBill;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATPaymentContactInformation;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSOContactName;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeAROutputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATInvoiceNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATTaxNumber;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATFormNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATSymbol;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSOContactPhone;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSOContactEmail1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSButton fld_btnAutoSelectProductSerialNo;
    }
}
