using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleForecast.UI
{
    /// <summary>
    /// Summary description for DMSF100
    /// </summary>
    partial class DMSF100
    {
        private BOSComponent.BOSPictureEdit fld_pteARSaleForecastEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID1;
        private BOSComponent.BOSLabel fld_lblLabel24;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSDateEdit fld_dteARSaleForecastDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSDateEdit fld_dteARSaleForecastDeliveryDate;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastDiscountPerCentForItem;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastSubTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private ARSaleForecastItemsGridControl fld_dgcARSaleForecastItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecast;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSF100));
            this.fld_pteARSaleForecastEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteARSaleForecastDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleForecastDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_pteARSaleForecastItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnImport = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleForecastItems = new BOSERP.Modules.SaleForecast.ARSaleForecastItemsGridControl();
            this.fld_dgvARSaleForecast = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleForecastDiscountPerCentForItem = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_recARSaleForecastComment = new BOSComponent.BOSRichEditControl(this.components);
            this.fld_lkeARSaleForecastStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_recARSaleForecastInternalComment = new BOSComponent.BOSRichEditControl(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastSFContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkViewDiffPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFromProposal = new BOSComponent.BOSButton(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Line4 = new BOSComponent.BOSLine(this.components);
            this.fld_lblARSaleForecastInvoiceContactName = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditShippingInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblARSaleForecastDeliveryContactName = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbPaymentTerm = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleForecastTransshipment = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnUpdateQty = new BOSComponent.BOSButton(this.components);
            this.fld_btnViewHistorySF = new BOSComponent.BOSButton(this.components);
            this.fld_lkeARShippingType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleForecastContQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblContQty = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastPONo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_ARSaleForecastPODate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARSaleForecastTotalProduct = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabelSaleForecastType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleForecastType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleForecastExchangeRate2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastPercentQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleForecastExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARAssociatedSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleForecastSFCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleForecastSFCommissionAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleForecastEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleForecastItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountPerCentForItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTotalAmount.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo1.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).BeginInit();
            this.fld_Line4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastTransshipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastContQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ARSaleForecastPODate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ARSaleForecastPODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTotalProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastExchangeRate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastPercentQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARAssociatedSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFCommissionAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pteARSaleForecastEmployeePicture
            // 
            this.fld_pteARSaleForecastEmployeePicture.BOSComment = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSDataMember = "ARSaleForecastEmployeePicture";
            this.fld_pteARSaleForecastEmployeePicture.BOSDataSource = "ARSaleForecasts";
            this.fld_pteARSaleForecastEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSError = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSPrivilege = null;
            this.fld_pteARSaleForecastEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleForecastEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleForecastEmployeePicture.FileName = null;
            this.fld_pteARSaleForecastEmployeePicture.FilePath = null;
            this.fld_pteARSaleForecastEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARSaleForecastEmployeePicture.Name = "fld_pteARSaleForecastEmployeePicture";
            this.fld_pteARSaleForecastEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARSaleForecastEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARSaleForecastEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARSaleForecastEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARSaleForecastEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleForecastEmployeePicture.Screen = null;
            this.fld_pteARSaleForecastEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARSaleForecastEmployeePicture.TabIndex = 0;
            this.fld_pteARSaleForecastEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_HREmployeeID1.TabStop = false;
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
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(365, 12);
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
            this.fld_lkeFK_ARCustomerID1.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_ARCustomerID1.Location = new System.Drawing.Point(448, 9);
            this.fld_lkeFK_ARCustomerID1.Name = "fld_lkeFK_ARCustomerID1";
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID1.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactAddressLine3", "Địa chỉ liên lạc")});
            this.fld_lkeFK_ARCustomerID1.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID1.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID1.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.Screen = null;
            this.fld_lkeFK_ARCustomerID1.Size = new System.Drawing.Size(149, 20);
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
            this.fld_lblLabel24.Location = new System.Drawing.Point(925, 38);
            this.fld_lblLabel24.Name = "fld_lblLabel24";
            this.fld_lblLabel24.Screen = null;
            this.fld_lblLabel24.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel24.TabIndex = 13;
            this.fld_lblLabel24.Text = "Phương thức tt";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(119, 90);
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
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(1048, 35);
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
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 7;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // fld_dteARSaleForecastDate
            // 
            this.fld_dteARSaleForecastDate.BOSComment = null;
            this.fld_dteARSaleForecastDate.BOSDataMember = "ARSaleForecastDate";
            this.fld_dteARSaleForecastDate.BOSDataSource = "ARSaleForecasts";
            this.fld_dteARSaleForecastDate.BOSDescription = null;
            this.fld_dteARSaleForecastDate.BOSError = null;
            this.fld_dteARSaleForecastDate.BOSFieldGroup = null;
            this.fld_dteARSaleForecastDate.BOSFieldRelation = null;
            this.fld_dteARSaleForecastDate.BOSPrivilege = null;
            this.fld_dteARSaleForecastDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleForecastDate.EditValue = null;
            this.fld_dteARSaleForecastDate.Location = new System.Drawing.Point(201, 35);
            this.fld_dteARSaleForecastDate.Name = "fld_dteARSaleForecastDate";
            this.fld_dteARSaleForecastDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleForecastDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleForecastDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleForecastDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleForecastDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleForecastDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleForecastDate.Screen = null;
            this.fld_dteARSaleForecastDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleForecastDate.TabIndex = 4;
            this.fld_dteARSaleForecastDate.Tag = "DC";
            this.fld_dteARSaleForecastDate.Validated += new System.EventHandler(this.Fld_dteARSaleForecastDate_Validated);
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(119, 38);
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(629, 12);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(117, 13);
            this.fld_lblLabel27.TabIndex = 19;
            this.fld_lblLabel27.Text = "Ngày giao hàng trễ nhất";
            // 
            // fld_dteARSaleForecastDeliveryDate
            // 
            this.fld_dteARSaleForecastDeliveryDate.BOSComment = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSDataMember = "ARSaleForecastDeliveryDate";
            this.fld_dteARSaleForecastDeliveryDate.BOSDataSource = "ARSaleForecasts";
            this.fld_dteARSaleForecastDeliveryDate.BOSDescription = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSError = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSFieldGroup = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSFieldRelation = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSPrivilege = null;
            this.fld_dteARSaleForecastDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleForecastDeliveryDate.EditValue = null;
            this.fld_dteARSaleForecastDeliveryDate.Location = new System.Drawing.Point(757, 9);
            this.fld_dteARSaleForecastDeliveryDate.Name = "fld_dteARSaleForecastDeliveryDate";
            this.fld_dteARSaleForecastDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleForecastDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleForecastDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleForecastDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleForecastDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleForecastDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleForecastDeliveryDate.Screen = null;
            this.fld_dteARSaleForecastDeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleForecastDeliveryDate.TabIndex = 2;
            this.fld_dteARSaleForecastDeliveryDate.Tag = "DC";
            this.fld_dteARSaleForecastDeliveryDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dteARSaleForecastDeliveryDate_CloseUp);
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = null;
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = null;
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = null;
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_pteARSaleForecastItemProductPicture);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel48);
            this.fld_grcGroupControl3.Controls.Add(this.fld_btnExportTemplate);
            this.fld_grcGroupControl3.Controls.Add(this.fld_btnImport);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcARSaleForecastItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(0, 190);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(1320, 321);
            this.fld_grcGroupControl3.TabIndex = 29;
            this.fld_grcGroupControl3.Text = "Danh sách sản phẩm";
            // 
            // fld_pteARSaleForecastItemProductPicture
            // 
            this.fld_pteARSaleForecastItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARSaleForecastItemProductPicture.BOSComment = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSDataMember = "ARSaleForecastItemProductPicture";
            this.fld_pteARSaleForecastItemProductPicture.BOSDataSource = "ARSaleForecastItems";
            this.fld_pteARSaleForecastItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSError = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSPrivilege = null;
            this.fld_pteARSaleForecastItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleForecastItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleForecastItemProductPicture.FileName = null;
            this.fld_pteARSaleForecastItemProductPicture.FilePath = null;
            this.fld_pteARSaleForecastItemProductPicture.Location = new System.Drawing.Point(1176, 59);
            this.fld_pteARSaleForecastItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARSaleForecastItemProductPicture.Name = "fld_pteARSaleForecastItemProductPicture";
            this.fld_pteARSaleForecastItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleForecastItemProductPicture.Screen = null;
            this.fld_pteARSaleForecastItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARSaleForecastItemProductPicture.TabIndex = 2;
            this.fld_pteARSaleForecastItemProductPicture.Tag = "DC";
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
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 31);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_btnExportTemplate
            // 
            this.fld_btnExportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportTemplate.BOSComment = null;
            this.fld_btnExportTemplate.BOSDataMember = null;
            this.fld_btnExportTemplate.BOSDataSource = null;
            this.fld_btnExportTemplate.BOSDescription = null;
            this.fld_btnExportTemplate.BOSError = null;
            this.fld_btnExportTemplate.BOSFieldGroup = null;
            this.fld_btnExportTemplate.BOSFieldRelation = null;
            this.fld_btnExportTemplate.BOSPrivilege = null;
            this.fld_btnExportTemplate.BOSPropertyName = null;
            this.fld_btnExportTemplate.Location = new System.Drawing.Point(1040, 29);
            this.fld_btnExportTemplate.Name = "fld_btnExportTemplate";
            this.fld_btnExportTemplate.Screen = null;
            this.fld_btnExportTemplate.Size = new System.Drawing.Size(120, 20);
            this.fld_btnExportTemplate.TabIndex = 1;
            this.fld_btnExportTemplate.Text = "Export Template";
            this.fld_btnExportTemplate.Click += new System.EventHandler(this.fld_btnExportTemplate_Click);
            // 
            // fld_btnImport
            // 
            this.fld_btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnImport.BOSComment = null;
            this.fld_btnImport.BOSDataMember = null;
            this.fld_btnImport.BOSDataSource = null;
            this.fld_btnImport.BOSDescription = null;
            this.fld_btnImport.BOSError = null;
            this.fld_btnImport.BOSFieldGroup = null;
            this.fld_btnImport.BOSFieldRelation = null;
            this.fld_btnImport.BOSPrivilege = null;
            this.fld_btnImport.BOSPropertyName = null;
            this.fld_btnImport.Location = new System.Drawing.Point(1176, 29);
            this.fld_btnImport.Name = "fld_btnImport";
            this.fld_btnImport.Screen = null;
            this.fld_btnImport.Size = new System.Drawing.Size(141, 20);
            this.fld_btnImport.TabIndex = 2;
            this.fld_btnImport.Text = "ImportSP";
            this.fld_btnImport.Click += new System.EventHandler(this.fld_btnImport_Click);
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARSaleForecastItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(66, 29);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(968, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARSaleForecastItems
            // 
            this.fld_dgcARSaleForecastItems.AllowDrop = true;
            this.fld_dgcARSaleForecastItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleForecastItems.BOSComment = null;
            this.fld_dgcARSaleForecastItems.BOSDataMember = null;
            this.fld_dgcARSaleForecastItems.BOSDataSource = "ARSaleForecastItems";
            this.fld_dgcARSaleForecastItems.BOSDescription = null;
            this.fld_dgcARSaleForecastItems.BOSError = null;
            this.fld_dgcARSaleForecastItems.BOSFieldGroup = null;
            this.fld_dgcARSaleForecastItems.BOSFieldRelation = null;
            this.fld_dgcARSaleForecastItems.BOSGridType = null;
            this.fld_dgcARSaleForecastItems.BOSPrivilege = null;
            this.fld_dgcARSaleForecastItems.BOSPropertyName = null;
            this.fld_dgcARSaleForecastItems.CommodityType = "";
            this.fld_dgcARSaleForecastItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleForecastItems.Location = new System.Drawing.Point(11, 59);
            this.fld_dgcARSaleForecastItems.MainView = this.fld_dgvARSaleForecast;
            this.fld_dgcARSaleForecastItems.Name = "fld_dgcARSaleForecastItems";
            this.fld_dgcARSaleForecastItems.PrintReport = false;
            this.fld_dgcARSaleForecastItems.Screen = null;
            this.fld_dgcARSaleForecastItems.Size = new System.Drawing.Size(1149, 257);
            this.fld_dgcARSaleForecastItems.TabIndex = 1;
            this.fld_dgcARSaleForecastItems.Tag = "DC";
            this.fld_dgcARSaleForecastItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecast});
            // 
            // fld_dgvARSaleForecast
            // 
            this.fld_dgvARSaleForecast.GridControl = this.fld_dgcARSaleForecastItems;
            this.fld_dgvARSaleForecast.Name = "fld_dgvARSaleForecast";
            this.fld_dgvARSaleForecast.PaintStyleName = "Office2003";
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
            this.fld_lblLabel43.Location = new System.Drawing.Point(1061, 756);
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
            this.fld_lblLabel44.Location = new System.Drawing.Point(1048, 547);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 46;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_lblLabel46
            // 
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
            this.fld_lblLabel46.Location = new System.Drawing.Point(629, 168);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel46.TabIndex = 48;
            this.fld_lblLabel46.Text = "% Chiết khấu";
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
            this.fld_lblLabel47.Location = new System.Drawing.Point(1032, 651);
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
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(1131, 753);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(177, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 40;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.Visible = false;
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_txtARSaleForecastDiscountPerCentForItem
            // 
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSComment = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSDataMember = "ARSaleForecastDiscountPerCentForItem";
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSDescription = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSError = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSFieldGroup = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSFieldRelation = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSPrivilege = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastDiscountPerCentForItem.EditValue = "0.00";
            this.fld_txtARSaleForecastDiscountPerCentForItem.Location = new System.Drawing.Point(757, 165);
            this.fld_txtARSaleForecastDiscountPerCentForItem.Name = "fld_txtARSaleForecastDiscountPerCentForItem";
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastDiscountPerCentForItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Screen = null;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Size = new System.Drawing.Size(149, 20);
            this.fld_txtARSaleForecastDiscountPerCentForItem.TabIndex = 26;
            this.fld_txtARSaleForecastDiscountPerCentForItem.Tag = "DC";
            this.fld_txtARSaleForecastDiscountPerCentForItem.Validated += new System.EventHandler(this.fld_txtARSaleForecastDiscountPerCent_Validated);
            // 
            // fld_txtARSaleForecastSubTotalAmount
            // 
            this.fld_txtARSaleForecastSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastSubTotalAmount.BOSComment = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSDataMember = "ARSaleForecastSubTotalAmount";
            this.fld_txtARSaleForecastSubTotalAmount.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastSubTotalAmount.BOSDescription = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSError = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSPrivilege = null;
            this.fld_txtARSaleForecastSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastSubTotalAmount.EditValue = "0.00";
            this.fld_txtARSaleForecastSubTotalAmount.Location = new System.Drawing.Point(1131, 544);
            this.fld_txtARSaleForecastSubTotalAmount.Name = "fld_txtARSaleForecastSubTotalAmount";
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleForecastSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastSubTotalAmount.Screen = null;
            this.fld_txtARSaleForecastSubTotalAmount.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARSaleForecastSubTotalAmount.TabIndex = 34;
            this.fld_txtARSaleForecastSubTotalAmount.TabStop = false;
            this.fld_txtARSaleForecastSubTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleForecastTotalAmount
            // 
            this.fld_txtARSaleForecastTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastTotalAmount.BOSComment = null;
            this.fld_txtARSaleForecastTotalAmount.BOSDataMember = "ARSaleForecastTotalAmount";
            this.fld_txtARSaleForecastTotalAmount.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastTotalAmount.BOSDescription = null;
            this.fld_txtARSaleForecastTotalAmount.BOSError = null;
            this.fld_txtARSaleForecastTotalAmount.BOSFieldGroup = null;
            this.fld_txtARSaleForecastTotalAmount.BOSFieldRelation = null;
            this.fld_txtARSaleForecastTotalAmount.BOSPrivilege = null;
            this.fld_txtARSaleForecastTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastTotalAmount.EditValue = "0.00";
            this.fld_txtARSaleForecastTotalAmount.Location = new System.Drawing.Point(1131, 648);
            this.fld_txtARSaleForecastTotalAmount.Name = "fld_txtARSaleForecastTotalAmount";
            this.fld_txtARSaleForecastTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleForecastTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastTotalAmount.Screen = null;
            this.fld_txtARSaleForecastTotalAmount.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleForecastTotalAmount.TabIndex = 37;
            this.fld_txtARSaleForecastTotalAmount.TabStop = false;
            this.fld_txtARSaleForecastTotalAmount.Tag = "DC";
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
            this.fld_Line3.Controls.Add(this.fld_recARSaleForecastComment);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(3, 536);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(350, 100);
            this.fld_Line3.TabIndex = 30;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Text = "Ghi chú in ra";
            // 
            // fld_recARSaleForecastComment
            // 
            this.fld_recARSaleForecastComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARSaleForecastComment.BOSComment = null;
            this.fld_recARSaleForecastComment.BOSDataMember = null;
            this.fld_recARSaleForecastComment.BOSDataSource = null;
            this.fld_recARSaleForecastComment.BOSDescription = null;
            this.fld_recARSaleForecastComment.BOSError = null;
            this.fld_recARSaleForecastComment.BOSFieldGroup = null;
            this.fld_recARSaleForecastComment.BOSFieldRelation = null;
            this.fld_recARSaleForecastComment.BOSPrivilege = null;
            this.fld_recARSaleForecastComment.BOSPropertyName = null;
            this.fld_recARSaleForecastComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARSaleForecastComment.Location = new System.Drawing.Point(2, 20);
            this.fld_recARSaleForecastComment.MenuManager = this.screenToolbar;
            this.fld_recARSaleForecastComment.Name = "fld_recARSaleForecastComment";
            this.fld_recARSaleForecastComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleForecastComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleForecastComment.Screen = null;
            this.fld_recARSaleForecastComment.Size = new System.Drawing.Size(346, 74);
            this.fld_recARSaleForecastComment.TabIndex = 1;
            this.fld_recARSaleForecastComment.Tag = "DC";
            // 
            // fld_lkeARSaleForecastStatus
            // 
            this.fld_lkeARSaleForecastStatus.BOSAllowAddNew = false;
            this.fld_lkeARSaleForecastStatus.BOSAllowDummy = false;
            this.fld_lkeARSaleForecastStatus.BOSComment = null;
            this.fld_lkeARSaleForecastStatus.BOSDataMember = "ARSaleForecastStatus";
            this.fld_lkeARSaleForecastStatus.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeARSaleForecastStatus.BOSDescription = null;
            this.fld_lkeARSaleForecastStatus.BOSError = null;
            this.fld_lkeARSaleForecastStatus.BOSFieldGroup = null;
            this.fld_lkeARSaleForecastStatus.BOSFieldParent = null;
            this.fld_lkeARSaleForecastStatus.BOSFieldRelation = null;
            this.fld_lkeARSaleForecastStatus.BOSPrivilege = null;
            this.fld_lkeARSaleForecastStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleForecastStatus.BOSSelectType = null;
            this.fld_lkeARSaleForecastStatus.BOSSelectTypeValue = null;
            this.fld_lkeARSaleForecastStatus.CurrentDisplayText = null;
            this.fld_lkeARSaleForecastStatus.Location = new System.Drawing.Point(201, 87);
            this.fld_lkeARSaleForecastStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARSaleForecastStatus.Name = "fld_lkeARSaleForecastStatus";
            this.fld_lkeARSaleForecastStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARSaleForecastStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleForecastStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleForecastStatus.Properties.ColumnName = null;
            this.fld_lkeARSaleForecastStatus.Properties.NullText = "";
            this.fld_lkeARSaleForecastStatus.Properties.ReadOnly = true;
            this.fld_lkeARSaleForecastStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleForecastStatus.Screen = null;
            this.fld_lkeARSaleForecastStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleForecastStatus.TabIndex = 12;
            this.fld_lkeARSaleForecastStatus.TabStop = false;
            this.fld_lkeARSaleForecastStatus.Tag = "DC";
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
            this.BOSLabel4.Location = new System.Drawing.Point(1031, 678);
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
            this.BOSLabel5.Location = new System.Drawing.Point(1054, 703);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel5.TabIndex = 49;
            this.BOSLabel5.Text = "CÒN LẠI";
            // 
            // fld_txtARSaleForecastDepositBalance
            // 
            this.fld_txtARSaleForecastDepositBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastDepositBalance.BOSComment = null;
            this.fld_txtARSaleForecastDepositBalance.BOSDataMember = "ARSaleForecastDepositBalance";
            this.fld_txtARSaleForecastDepositBalance.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastDepositBalance.BOSDescription = null;
            this.fld_txtARSaleForecastDepositBalance.BOSError = null;
            this.fld_txtARSaleForecastDepositBalance.BOSFieldGroup = null;
            this.fld_txtARSaleForecastDepositBalance.BOSFieldRelation = null;
            this.fld_txtARSaleForecastDepositBalance.BOSPrivilege = null;
            this.fld_txtARSaleForecastDepositBalance.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastDepositBalance.EditValue = "0.00";
            this.fld_txtARSaleForecastDepositBalance.Location = new System.Drawing.Point(1131, 675);
            this.fld_txtARSaleForecastDepositBalance.Name = "fld_txtARSaleForecastDepositBalance";
            this.fld_txtARSaleForecastDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastDepositBalance.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastDepositBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastDepositBalance.Properties.ReadOnly = true;
            this.fld_txtARSaleForecastDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastDepositBalance.Screen = null;
            this.fld_txtARSaleForecastDepositBalance.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleForecastDepositBalance.TabIndex = 38;
            this.fld_txtARSaleForecastDepositBalance.TabStop = false;
            this.fld_txtARSaleForecastDepositBalance.Tag = "DC";
            this.fld_txtARSaleForecastDepositBalance.Validated += new System.EventHandler(this.fld_txtARSaleForecastDepositBalance_Validated);
            // 
            // fld_txtARSaleForecastBalanceDue
            // 
            this.fld_txtARSaleForecastBalanceDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastBalanceDue.BOSComment = null;
            this.fld_txtARSaleForecastBalanceDue.BOSDataMember = "ARSaleForecastBalanceDue";
            this.fld_txtARSaleForecastBalanceDue.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastBalanceDue.BOSDescription = null;
            this.fld_txtARSaleForecastBalanceDue.BOSError = null;
            this.fld_txtARSaleForecastBalanceDue.BOSFieldGroup = null;
            this.fld_txtARSaleForecastBalanceDue.BOSFieldRelation = null;
            this.fld_txtARSaleForecastBalanceDue.BOSPrivilege = null;
            this.fld_txtARSaleForecastBalanceDue.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastBalanceDue.EditValue = "0.00";
            this.fld_txtARSaleForecastBalanceDue.Location = new System.Drawing.Point(1131, 700);
            this.fld_txtARSaleForecastBalanceDue.Name = "fld_txtARSaleForecastBalanceDue";
            this.fld_txtARSaleForecastBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastBalanceDue.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastBalanceDue.Properties.ReadOnly = true;
            this.fld_txtARSaleForecastBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastBalanceDue.Screen = null;
            this.fld_txtARSaleForecastBalanceDue.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARSaleForecastBalanceDue.TabIndex = 39;
            this.fld_txtARSaleForecastBalanceDue.TabStop = false;
            this.fld_txtARSaleForecastBalanceDue.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(119, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_txtARSaleForecastNo1
            // 
            this.fld_txtARSaleForecastNo1.BOSComment = null;
            this.fld_txtARSaleForecastNo1.BOSDataMember = "ARSaleForecastNo";
            this.fld_txtARSaleForecastNo1.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastNo1.BOSDescription = null;
            this.fld_txtARSaleForecastNo1.BOSError = null;
            this.fld_txtARSaleForecastNo1.BOSFieldGroup = null;
            this.fld_txtARSaleForecastNo1.BOSFieldRelation = null;
            this.fld_txtARSaleForecastNo1.BOSPrivilege = null;
            this.fld_txtARSaleForecastNo1.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastNo1.Location = new System.Drawing.Point(201, 9);
            this.fld_txtARSaleForecastNo1.MenuManager = this.screenToolbar;
            this.fld_txtARSaleForecastNo1.Name = "fld_txtARSaleForecastNo1";
            this.fld_txtARSaleForecastNo1.Screen = null;
            this.fld_txtARSaleForecastNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastNo1.TabIndex = 0;
            this.fld_txtARSaleForecastNo1.Tag = "DC";
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
            this.bosLine1.Controls.Add(this.fld_recARSaleForecastInternalComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(3, 653);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(350, 100);
            this.bosLine1.TabIndex = 31;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú không in ra";
            // 
            // fld_recARSaleForecastInternalComment
            // 
            this.fld_recARSaleForecastInternalComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARSaleForecastInternalComment.BOSComment = null;
            this.fld_recARSaleForecastInternalComment.BOSDataMember = null;
            this.fld_recARSaleForecastInternalComment.BOSDataSource = null;
            this.fld_recARSaleForecastInternalComment.BOSDescription = null;
            this.fld_recARSaleForecastInternalComment.BOSError = null;
            this.fld_recARSaleForecastInternalComment.BOSFieldGroup = null;
            this.fld_recARSaleForecastInternalComment.BOSFieldRelation = null;
            this.fld_recARSaleForecastInternalComment.BOSPrivilege = null;
            this.fld_recARSaleForecastInternalComment.BOSPropertyName = null;
            this.fld_recARSaleForecastInternalComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARSaleForecastInternalComment.Location = new System.Drawing.Point(2, 20);
            this.fld_recARSaleForecastInternalComment.MenuManager = this.screenToolbar;
            this.fld_recARSaleForecastInternalComment.Name = "fld_recARSaleForecastInternalComment";
            this.fld_recARSaleForecastInternalComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleForecastInternalComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleForecastInternalComment.Screen = null;
            this.fld_recARSaleForecastInternalComment.Size = new System.Drawing.Size(346, 74);
            this.fld_recARSaleForecastInternalComment.TabIndex = 2;
            this.fld_recARSaleForecastInternalComment.Tag = "DC";
            // 
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSellerID.BOSComment = null;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_ARSellerID.Location = new System.Drawing.Point(448, 61);
            this.fld_lkeFK_ARSellerID.Name = "fld_lkeFK_ARSellerID";
            this.fld_lkeFK_ARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSellerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_ARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARSellerID.Properties.NullText = "";
            this.fld_lkeFK_ARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARSellerID.Screen = null;
            this.fld_lkeFK_ARSellerID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_ARSellerID.TabIndex = 9;
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
            this.bosLabel8.Location = new System.Drawing.Point(365, 64);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(49, 13);
            this.bosLabel8.TabIndex = 72;
            this.bosLabel8.Text = "Người bán";
            // 
            // fld_txtARSaleForecastSFContactName
            // 
            this.fld_txtARSaleForecastSFContactName.BOSComment = null;
            this.fld_txtARSaleForecastSFContactName.BOSDataMember = "ARSaleForecastSFContactName";
            this.fld_txtARSaleForecastSFContactName.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastSFContactName.BOSDescription = null;
            this.fld_txtARSaleForecastSFContactName.BOSError = null;
            this.fld_txtARSaleForecastSFContactName.BOSFieldGroup = null;
            this.fld_txtARSaleForecastSFContactName.BOSFieldRelation = null;
            this.fld_txtARSaleForecastSFContactName.BOSPrivilege = null;
            this.fld_txtARSaleForecastSFContactName.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastSFContactName.Location = new System.Drawing.Point(448, 35);
            this.fld_txtARSaleForecastSFContactName.Name = "fld_txtARSaleForecastSFContactName";
            this.fld_txtARSaleForecastSFContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastSFContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastSFContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastSFContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastSFContactName.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastSFContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastSFContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastSFContactName.Screen = null;
            this.fld_txtARSaleForecastSFContactName.Size = new System.Drawing.Size(149, 20);
            this.fld_txtARSaleForecastSFContactName.TabIndex = 5;
            this.fld_txtARSaleForecastSFContactName.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(365, 38);
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
            this.bosLabel9.Location = new System.Drawing.Point(1074, 625);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(24, 13);
            this.bosLabel9.TabIndex = 48;
            this.bosLabel9.Text = "Thuế";
            // 
            // fld_txtARSaleForecastTaxPercent
            // 
            this.fld_txtARSaleForecastTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastTaxPercent.BOSComment = null;
            this.fld_txtARSaleForecastTaxPercent.BOSDataMember = "ARSaleForecastTaxPercent";
            this.fld_txtARSaleForecastTaxPercent.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastTaxPercent.BOSDescription = null;
            this.fld_txtARSaleForecastTaxPercent.BOSError = null;
            this.fld_txtARSaleForecastTaxPercent.BOSFieldGroup = null;
            this.fld_txtARSaleForecastTaxPercent.BOSFieldRelation = null;
            this.fld_txtARSaleForecastTaxPercent.BOSPrivilege = null;
            this.fld_txtARSaleForecastTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastTaxPercent.EditValue = "0.00";
            this.fld_txtARSaleForecastTaxPercent.Location = new System.Drawing.Point(1131, 622);
            this.fld_txtARSaleForecastTaxPercent.Name = "fld_txtARSaleForecastTaxPercent";
            this.fld_txtARSaleForecastTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastTaxPercent.Screen = null;
            this.fld_txtARSaleForecastTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARSaleForecastTaxPercent.TabIndex = 35;
            this.fld_txtARSaleForecastTaxPercent.Tag = "DC";
            this.fld_txtARSaleForecastTaxPercent.Validated += new System.EventHandler(this.fld_txtARSaleForecastTaxPercent_Validated);
            // 
            // fld_txtARSaleForecastTaxAmount
            // 
            this.fld_txtARSaleForecastTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastTaxAmount.BOSComment = null;
            this.fld_txtARSaleForecastTaxAmount.BOSDataMember = "ARSaleForecastTaxAmount";
            this.fld_txtARSaleForecastTaxAmount.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastTaxAmount.BOSDescription = null;
            this.fld_txtARSaleForecastTaxAmount.BOSError = null;
            this.fld_txtARSaleForecastTaxAmount.BOSFieldGroup = null;
            this.fld_txtARSaleForecastTaxAmount.BOSFieldRelation = null;
            this.fld_txtARSaleForecastTaxAmount.BOSPrivilege = null;
            this.fld_txtARSaleForecastTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastTaxAmount.EditValue = "0.00";
            this.fld_txtARSaleForecastTaxAmount.Location = new System.Drawing.Point(1209, 622);
            this.fld_txtARSaleForecastTaxAmount.Name = "fld_txtARSaleForecastTaxAmount";
            this.fld_txtARSaleForecastTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastTaxAmount.Screen = null;
            this.fld_txtARSaleForecastTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleForecastTaxAmount.TabIndex = 36;
            this.fld_txtARSaleForecastTaxAmount.Tag = "DC";
            this.fld_txtARSaleForecastTaxAmount.Validated += new System.EventHandler(this.fld_txtARSaleForecastTaxAmount_Validated);
            // 
            // fld_lnkViewDiffPrice
            // 
            this.fld_lnkViewDiffPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lnkViewDiffPrice.EditValue = "Xem chênh lệch giá kê";
            this.fld_lnkViewDiffPrice.Location = new System.Drawing.Point(808, 761);
            this.fld_lnkViewDiffPrice.MenuManager = this.screenToolbar;
            this.fld_lnkViewDiffPrice.Name = "fld_lnkViewDiffPrice";
            this.fld_lnkViewDiffPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkViewDiffPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkViewDiffPrice.Size = new System.Drawing.Size(177, 20);
            this.fld_lnkViewDiffPrice.TabIndex = 43;
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
            this.bosPanel1.Controls.Add(this.bosLabel35);
            this.bosPanel1.Controls.Add(this.fld_txtARProposalTotalCost);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastDiscountFix);
            this.bosPanel1.Controls.Add(this.bosLabel30);
            this.bosPanel1.Controls.Add(this.fld_btnFromProposal);
            this.bosPanel1.Controls.Add(this.bosLookupEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderProductType);
            this.bosPanel1.Controls.Add(this.fld_Line4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.bosPanel1.Controls.Add(this.fld_lbPaymentTerm);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleForecastTransshipment);
            this.bosPanel1.Controls.Add(this.fld_btnUpdateQty);
            this.bosPanel1.Controls.Add(this.fld_btnViewHistorySF);
            this.bosPanel1.Controls.Add(this.fld_lkeARShippingType);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastContQty);
            this.bosPanel1.Controls.Add(this.fld_lblContQty);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastPONo);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_ARSaleForecastPODate);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastTotalProduct);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lblLabelSaleForecastType);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleForecastType);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleForecastEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.BOSLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastExchangeRate2);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastPercentQty);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastNo1);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastDepositBalance);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastSFContactName);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastBalanceDue);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARAssociatedSellerID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lnkViewDiffPrice);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastSFCommissionPercent);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastDiscountPerCentForItem);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleForecastStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_lblLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel43);
            this.bosPanel1.Controls.Add(this.fld_lblLabel27);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleForecastSFCommissionAmount);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleForecastDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleForecastDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1335, 784);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
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
            this.bosLabel35.Location = new System.Drawing.Point(1064, 730);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(32, 13);
            this.bosLabel35.TabIndex = 559;
            this.bosLabel35.Text = "Chi phí";
            this.bosLabel35.Visible = false;
            // 
            // fld_txtARProposalTotalCost
            // 
            this.fld_txtARProposalTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalTotalCost.BOSComment = null;
            this.fld_txtARProposalTotalCost.BOSDataMember = "ARSaleForecastTotalCost";
            this.fld_txtARProposalTotalCost.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARProposalTotalCost.BOSDescription = null;
            this.fld_txtARProposalTotalCost.BOSError = null;
            this.fld_txtARProposalTotalCost.BOSFieldGroup = null;
            this.fld_txtARProposalTotalCost.BOSFieldRelation = null;
            this.fld_txtARProposalTotalCost.BOSPrivilege = null;
            this.fld_txtARProposalTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtARProposalTotalCost.EditValue = "0.00";
            this.fld_txtARProposalTotalCost.Location = new System.Drawing.Point(1130, 727);
            this.fld_txtARProposalTotalCost.Name = "fld_txtARProposalTotalCost";
            this.fld_txtARProposalTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARProposalTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalTotalCost.Properties.ReadOnly = true;
            this.fld_txtARProposalTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalTotalCost.Screen = null;
            this.fld_txtARProposalTotalCost.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARProposalTotalCost.TabIndex = 558;
            this.fld_txtARProposalTotalCost.Tag = "DC";
            this.fld_txtARProposalTotalCost.Visible = false;
            // 
            // fld_txtARSaleForecastDiscountPerCent
            // 
            this.fld_txtARSaleForecastDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastDiscountPerCent.BOSComment = "";
            this.fld_txtARSaleForecastDiscountPerCent.BOSDataMember = "ARSaleForecastDiscountPerCent";
            this.fld_txtARSaleForecastDiscountPerCent.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastDiscountPerCent.BOSDescription = null;
            this.fld_txtARSaleForecastDiscountPerCent.BOSError = null;
            this.fld_txtARSaleForecastDiscountPerCent.BOSFieldGroup = null;
            this.fld_txtARSaleForecastDiscountPerCent.BOSFieldRelation = null;
            this.fld_txtARSaleForecastDiscountPerCent.BOSPrivilege = null;
            this.fld_txtARSaleForecastDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastDiscountPerCent.EditValue = "0.00";
            this.fld_txtARSaleForecastDiscountPerCent.Location = new System.Drawing.Point(1131, 596);
            this.fld_txtARSaleForecastDiscountPerCent.Name = "fld_txtARSaleForecastDiscountPerCent";
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastDiscountPerCent.Screen = null;
            this.fld_txtARSaleForecastDiscountPerCent.Size = new System.Drawing.Size(71, 20);
            this.fld_txtARSaleForecastDiscountPerCent.TabIndex = 557;
            this.fld_txtARSaleForecastDiscountPerCent.Tag = "DC";
            this.fld_txtARSaleForecastDiscountPerCent.Validated += new System.EventHandler(this.Fld_txtARSaleForecastDiscountPerCent_Validated_1);
            // 
            // fld_txtARSaleForecastDiscountFix
            // 
            this.fld_txtARSaleForecastDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastDiscountFix.BOSComment = null;
            this.fld_txtARSaleForecastDiscountFix.BOSDataMember = "ARSaleForecastDiscountFix";
            this.fld_txtARSaleForecastDiscountFix.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastDiscountFix.BOSDescription = null;
            this.fld_txtARSaleForecastDiscountFix.BOSError = null;
            this.fld_txtARSaleForecastDiscountFix.BOSFieldGroup = null;
            this.fld_txtARSaleForecastDiscountFix.BOSFieldRelation = null;
            this.fld_txtARSaleForecastDiscountFix.BOSPrivilege = null;
            this.fld_txtARSaleForecastDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastDiscountFix.EditValue = "0.00";
            this.fld_txtARSaleForecastDiscountFix.Location = new System.Drawing.Point(1209, 596);
            this.fld_txtARSaleForecastDiscountFix.Name = "fld_txtARSaleForecastDiscountFix";
            this.fld_txtARSaleForecastDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARSaleForecastDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastDiscountFix.Screen = null;
            this.fld_txtARSaleForecastDiscountFix.Size = new System.Drawing.Size(99, 20);
            this.fld_txtARSaleForecastDiscountFix.TabIndex = 33;
            this.fld_txtARSaleForecastDiscountFix.TabStop = false;
            this.fld_txtARSaleForecastDiscountFix.Tag = "DC";
            this.fld_txtARSaleForecastDiscountFix.Validated += new System.EventHandler(this.fld_txtARSaleForecastDiscountFix_Validated);
            // 
            // bosLabel30
            // 
            this.bosLabel30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel30.Location = new System.Drawing.Point(1048, 599);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(51, 13);
            this.bosLabel30.TabIndex = 556;
            this.bosLabel30.Text = "Chiết khấu";
            // 
            // fld_btnFromProposal
            // 
            this.fld_btnFromProposal.BOSComment = null;
            this.fld_btnFromProposal.BOSDataMember = null;
            this.fld_btnFromProposal.BOSDataSource = null;
            this.fld_btnFromProposal.BOSDescription = null;
            this.fld_btnFromProposal.BOSError = null;
            this.fld_btnFromProposal.BOSFieldGroup = null;
            this.fld_btnFromProposal.BOSFieldRelation = null;
            this.fld_btnFromProposal.BOSPrivilege = null;
            this.fld_btnFromProposal.BOSPropertyName = null;
            this.fld_btnFromProposal.Location = new System.Drawing.Point(1081, 165);
            this.fld_btnFromProposal.Name = "fld_btnFromProposal";
            this.fld_btnFromProposal.Screen = null;
            this.fld_btnFromProposal.Size = new System.Drawing.Size(117, 20);
            this.fld_btnFromProposal.TabIndex = 28;
            this.fld_btnFromProposal.Text = "Chọn từ báo giá";
            this.fld_btnFromProposal.Click += new System.EventHandler(this.fld_btnFromProposal_Click);
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "ARSaleForecastSaleType";
            this.bosLookupEdit2.BOSDataSource = "ARSaleForecasts";
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
            this.bosLookupEdit2.Location = new System.Drawing.Point(756, 61);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit2, true);
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 10;
            this.bosLookupEdit2.Tag = "DC";
            this.bosLookupEdit2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit2_CloseUp);
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
            this.bosLabel23.Location = new System.Drawing.Point(629, 64);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(94, 13);
            this.bosLabel23.TabIndex = 552;
            this.bosLabel23.Text = "Hình thức bán hàng";
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
            this.bosLabel27.Location = new System.Drawing.Point(119, 142);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(67, 13);
            this.bosLabel27.TabIndex = 550;
            this.bosLabel27.Text = "Loại hàng hóa";
            // 
            // fld_lkeARSaleOrderProductType
            // 
            this.fld_lkeARSaleOrderProductType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderProductType.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderProductType.BOSComment = null;
            this.fld_lkeARSaleOrderProductType.BOSDataMember = "ARSaleForecastProductType";
            this.fld_lkeARSaleOrderProductType.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeARSaleOrderProductType.BOSDescription = null;
            this.fld_lkeARSaleOrderProductType.BOSError = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderProductType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderProductType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderProductType.BOSSelectType = "";
            this.fld_lkeARSaleOrderProductType.BOSSelectTypeValue = "";
            this.fld_lkeARSaleOrderProductType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderProductType.Location = new System.Drawing.Point(200, 139);
            this.fld_lkeARSaleOrderProductType.Name = "fld_lkeARSaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderProductType.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderProductType.Properties.NullText = "";
            this.fld_lkeARSaleOrderProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderProductType, true);
            this.fld_lkeARSaleOrderProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderProductType.TabIndex = 20;
            this.fld_lkeARSaleOrderProductType.Tag = "DC";
            this.fld_lkeARSaleOrderProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARSaleOrderProductType_CloseUp);
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
            this.fld_Line4.Controls.Add(this.bosLabel32);
            this.fld_Line4.Controls.Add(this.fld_lblARSaleForecastInvoiceContactName);
            this.fld_Line4.Controls.Add(this.bosLabel29);
            this.fld_Line4.Controls.Add(this.bosLabel28);
            this.fld_Line4.Controls.Add(this.bosLabel26);
            this.fld_Line4.Controls.Add(this.bosLabel25);
            this.fld_Line4.Controls.Add(this.bosLabel10);
            this.fld_Line4.Controls.Add(this.bosLabel14);
            this.fld_Line4.Controls.Add(this.bosLabel19);
            this.fld_Line4.Controls.Add(this.bosLabel16);
            this.fld_Line4.Controls.Add(this.bosLabel21);
            this.fld_Line4.Controls.Add(this.bosLabel20);
            this.fld_Line4.Controls.Add(this.bosButton1);
            this.fld_Line4.Controls.Add(this.fld_btnEditShippingInfo);
            this.fld_Line4.Controls.Add(this.fld_lblLabel29);
            this.fld_Line4.Controls.Add(this.fld_lblLabel42);
            this.fld_Line4.Controls.Add(this.fld_lblARSaleForecastDeliveryContactName);
            this.fld_Line4.Controls.Add(this.fld_lblLabel37);
            this.fld_Line4.Controls.Add(this.fld_Line1);
            this.fld_Line4.Controls.Add(this.fld_lblLabel36);
            this.fld_Line4.Controls.Add(this.fld_lblLabel34);
            this.fld_Line4.Controls.Add(this.fld_lblLabel30);
            this.fld_Line4.Controls.Add(this.fld_Line);
            this.fld_Line4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line4.Location = new System.Drawing.Point(365, 536);
            this.fld_Line4.Name = "fld_Line4";
            this.fld_Line4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line4, true);
            this.fld_Line4.Size = new System.Drawing.Size(407, 237);
            this.fld_Line4.TabIndex = 32;
            this.fld_Line4.TabStop = false;
            this.fld_Line4.Text = "Thông tin giao hàng";
            // 
            // fld_lblARSaleForecastInvoiceContactName
            // 
            this.fld_lblARSaleForecastInvoiceContactName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleForecastInvoiceContactName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleForecastInvoiceContactName.Appearance.Options.UseBackColor = true;
            this.fld_lblARSaleForecastInvoiceContactName.Appearance.Options.UseForeColor = true;
            this.fld_lblARSaleForecastInvoiceContactName.BOSComment = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSDataMember = "ARSaleForecastInvoiceContactName";
            this.fld_lblARSaleForecastInvoiceContactName.BOSDataSource = "ARSaleForecasts";
            this.fld_lblARSaleForecastInvoiceContactName.BOSDescription = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSError = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSFieldGroup = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSFieldRelation = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSPrivilege = null;
            this.fld_lblARSaleForecastInvoiceContactName.BOSPropertyName = null;
            this.fld_lblARSaleForecastInvoiceContactName.Location = new System.Drawing.Point(9, 41);
            this.fld_lblARSaleForecastInvoiceContactName.Name = "fld_lblARSaleForecastInvoiceContactName";
            this.fld_lblARSaleForecastInvoiceContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblARSaleForecastInvoiceContactName, true);
            this.fld_lblARSaleForecastInvoiceContactName.Size = new System.Drawing.Size(136, 13);
            this.fld_lblARSaleForecastInvoiceContactName.TabIndex = 78;
            this.fld_lblARSaleForecastInvoiceContactName.Text = "LamViet Join Stock Company";
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
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(9, 79);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(44, 13);
            this.bosLabel14.TabIndex = 68;
            this.bosLabel14.Text = "Tax code";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = "ARSaleForecastInvoiceAddressFax";
            this.bosLabel19.BOSDataSource = "ARSaleForecasts";
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
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = "ARSaleForecastInvoiceAddressTel";
            this.bosLabel16.BOSDataSource = "ARSaleForecasts";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(181, 79);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(12, 13);
            this.bosLabel16.TabIndex = 67;
            this.bosLabel16.Text = "08";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = "ARSaleForecastDeliveryAddressFax";
            this.bosLabel21.BOSDataSource = "ARSaleForecasts";
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
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = "ARSaleForecastDeliveryAddressTel";
            this.bosLabel20.BOSDataSource = "ARSaleForecasts";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(181, 176);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(12, 13);
            this.bosLabel20.TabIndex = 66;
            this.bosLabel20.Text = "08";
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
            this.fld_btnEditShippingInfo.Location = new System.Drawing.Point(326, 211);
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
            this.fld_lblLabel42.BOSDataMember = "ARSaleForecastDeliveryAddressTaxCode";
            this.fld_lblLabel42.BOSDataSource = "ARSaleForecasts";
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
            // fld_lblARSaleForecastDeliveryContactName
            // 
            this.fld_lblARSaleForecastDeliveryContactName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleForecastDeliveryContactName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblARSaleForecastDeliveryContactName.Appearance.Options.UseBackColor = true;
            this.fld_lblARSaleForecastDeliveryContactName.Appearance.Options.UseForeColor = true;
            this.fld_lblARSaleForecastDeliveryContactName.BOSComment = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSDataMember = "ARSaleForecastDeliveryContactName";
            this.fld_lblARSaleForecastDeliveryContactName.BOSDataSource = "ARSaleForecasts";
            this.fld_lblARSaleForecastDeliveryContactName.BOSDescription = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSError = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSFieldGroup = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSFieldRelation = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSPrivilege = null;
            this.fld_lblARSaleForecastDeliveryContactName.BOSPropertyName = null;
            this.fld_lblARSaleForecastDeliveryContactName.Location = new System.Drawing.Point(9, 136);
            this.fld_lblARSaleForecastDeliveryContactName.Name = "fld_lblARSaleForecastDeliveryContactName";
            this.fld_lblARSaleForecastDeliveryContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblARSaleForecastDeliveryContactName, true);
            this.fld_lblARSaleForecastDeliveryContactName.Size = new System.Drawing.Size(136, 13);
            this.fld_lblARSaleForecastDeliveryContactName.TabIndex = 3;
            this.fld_lblARSaleForecastDeliveryContactName.Text = "LamViet Join Stock Company";
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = null;
            this.fld_lblLabel37.BOSDataMember = "ARSaleForecastDeliveryAddressLine3";
            this.fld_lblLabel37.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lblLabel34.BOSDataMember = "ARSaleForecastInvoiceAddressTaxCode";
            this.fld_lblLabel34.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lblLabel30.BOSDataMember = "ARSaleForecastInvoiceAddressLine3";
            this.fld_lblLabel30.BOSDataSource = "ARSaleForecasts";
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
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(200, 113);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 16;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = false;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(1048, 61);
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
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 11;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            // 
            // fld_lbPaymentTerm
            // 
            this.fld_lbPaymentTerm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTerm.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTerm.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTerm.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTerm.BOSComment = "";
            this.fld_lbPaymentTerm.BOSDataMember = "";
            this.fld_lbPaymentTerm.BOSDataSource = "";
            this.fld_lbPaymentTerm.BOSDescription = null;
            this.fld_lbPaymentTerm.BOSError = null;
            this.fld_lbPaymentTerm.BOSFieldGroup = "";
            this.fld_lbPaymentTerm.BOSFieldRelation = "";
            this.fld_lbPaymentTerm.BOSPrivilege = "";
            this.fld_lbPaymentTerm.BOSPropertyName = null;
            this.fld_lbPaymentTerm.Location = new System.Drawing.Point(925, 64);
            this.fld_lbPaymentTerm.Name = "fld_lbPaymentTerm";
            this.fld_lbPaymentTerm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbPaymentTerm, true);
            this.fld_lbPaymentTerm.Size = new System.Drawing.Size(69, 13);
            this.fld_lbPaymentTerm.TabIndex = 115;
            this.fld_lbPaymentTerm.Tag = "";
            this.fld_lbPaymentTerm.Text = "Điều khoản TT";
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
            this.bosLabel17.Location = new System.Drawing.Point(925, 12);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(117, 13);
            this.bosLabel17.TabIndex = 113;
            this.bosLabel17.Text = "Phương tiện vận chuyển";
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
            this.bosLabel6.Location = new System.Drawing.Point(629, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(96, 13);
            this.bosLabel6.TabIndex = 109;
            this.bosLabel6.Text = "Hình thức giao hàng";
            // 
            // fld_lkeARSaleForecastTransshipment
            // 
            this.fld_lkeARSaleForecastTransshipment.BOSAllowAddNew = false;
            this.fld_lkeARSaleForecastTransshipment.BOSAllowDummy = false;
            this.fld_lkeARSaleForecastTransshipment.BOSComment = null;
            this.fld_lkeARSaleForecastTransshipment.BOSDataMember = "ARSaleForecastTransshipment";
            this.fld_lkeARSaleForecastTransshipment.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeARSaleForecastTransshipment.BOSDescription = null;
            this.fld_lkeARSaleForecastTransshipment.BOSError = null;
            this.fld_lkeARSaleForecastTransshipment.BOSFieldGroup = null;
            this.fld_lkeARSaleForecastTransshipment.BOSFieldParent = null;
            this.fld_lkeARSaleForecastTransshipment.BOSFieldRelation = null;
            this.fld_lkeARSaleForecastTransshipment.BOSPrivilege = null;
            this.fld_lkeARSaleForecastTransshipment.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleForecastTransshipment.BOSSelectType = null;
            this.fld_lkeARSaleForecastTransshipment.BOSSelectTypeValue = null;
            this.fld_lkeARSaleForecastTransshipment.CurrentDisplayText = null;
            this.fld_lkeARSaleForecastTransshipment.Location = new System.Drawing.Point(1048, 9);
            this.fld_lkeARSaleForecastTransshipment.Name = "fld_lkeARSaleForecastTransshipment";
            this.fld_lkeARSaleForecastTransshipment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleForecastTransshipment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleForecastTransshipment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleForecastTransshipment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleForecastTransshipment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleForecastTransshipment.Properties.ColumnName = null;
            this.fld_lkeARSaleForecastTransshipment.Properties.NullText = "";
            this.fld_lkeARSaleForecastTransshipment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleForecastTransshipment.Screen = null;
            this.fld_lkeARSaleForecastTransshipment.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleForecastTransshipment.TabIndex = 3;
            this.fld_lkeARSaleForecastTransshipment.Tag = "DC";
            // 
            // fld_btnUpdateQty
            // 
            this.fld_btnUpdateQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateQty.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateQty.BOSComment = null;
            this.fld_btnUpdateQty.BOSDataMember = null;
            this.fld_btnUpdateQty.BOSDataSource = null;
            this.fld_btnUpdateQty.BOSDescription = null;
            this.fld_btnUpdateQty.BOSError = null;
            this.fld_btnUpdateQty.BOSFieldGroup = null;
            this.fld_btnUpdateQty.BOSFieldRelation = null;
            this.fld_btnUpdateQty.BOSPrivilege = null;
            this.fld_btnUpdateQty.BOSPropertyName = null;
            this.fld_btnUpdateQty.Location = new System.Drawing.Point(448, 164);
            this.fld_btnUpdateQty.Name = "fld_btnUpdateQty";
            this.fld_btnUpdateQty.Screen = null;
            this.fld_btnUpdateQty.Size = new System.Drawing.Size(149, 20);
            this.fld_btnUpdateQty.TabIndex = 25;
            this.fld_btnUpdateQty.Text = "Tính lại số lượng theo %";
            this.fld_btnUpdateQty.Click += new System.EventHandler(this.fld_btnUpdateQty_Click);
            // 
            // fld_btnViewHistorySF
            // 
            this.fld_btnViewHistorySF.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnViewHistorySF.Appearance.Options.UseForeColor = true;
            this.fld_btnViewHistorySF.BOSComment = null;
            this.fld_btnViewHistorySF.BOSDataMember = null;
            this.fld_btnViewHistorySF.BOSDataSource = null;
            this.fld_btnViewHistorySF.BOSDescription = null;
            this.fld_btnViewHistorySF.BOSError = null;
            this.fld_btnViewHistorySF.BOSFieldGroup = null;
            this.fld_btnViewHistorySF.BOSFieldRelation = null;
            this.fld_btnViewHistorySF.BOSPrivilege = null;
            this.fld_btnViewHistorySF.BOSPropertyName = null;
            this.fld_btnViewHistorySF.Location = new System.Drawing.Point(925, 164);
            this.fld_btnViewHistorySF.Name = "fld_btnViewHistorySF";
            this.fld_btnViewHistorySF.Screen = null;
            this.fld_btnViewHistorySF.Size = new System.Drawing.Size(150, 20);
            this.fld_btnViewHistorySF.TabIndex = 27;
            this.fld_btnViewHistorySF.Text = "Xem lịch sử SaleForecast";
            this.fld_btnViewHistorySF.Click += new System.EventHandler(this.fld_btnViewHistorySF_Click);
            // 
            // fld_lkeARShippingType
            // 
            this.fld_lkeARShippingType.BOSAllowAddNew = false;
            this.fld_lkeARShippingType.BOSAllowDummy = false;
            this.fld_lkeARShippingType.BOSComment = null;
            this.fld_lkeARShippingType.BOSDataMember = "ARShippingType";
            this.fld_lkeARShippingType.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeARShippingType.Location = new System.Drawing.Point(757, 35);
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
            this.fld_lkeARShippingType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARShippingType.TabIndex = 6;
            this.fld_lkeARShippingType.Tag = "DC";
            // 
            // fld_txtARSaleForecastContQty
            // 
            this.fld_txtARSaleForecastContQty.BOSComment = null;
            this.fld_txtARSaleForecastContQty.BOSDataMember = "ARSaleForecastContQty";
            this.fld_txtARSaleForecastContQty.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastContQty.BOSDescription = null;
            this.fld_txtARSaleForecastContQty.BOSError = null;
            this.fld_txtARSaleForecastContQty.BOSFieldGroup = null;
            this.fld_txtARSaleForecastContQty.BOSFieldRelation = null;
            this.fld_txtARSaleForecastContQty.BOSPrivilege = null;
            this.fld_txtARSaleForecastContQty.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastContQty.Location = new System.Drawing.Point(1048, 139);
            this.fld_txtARSaleForecastContQty.Name = "fld_txtARSaleForecastContQty";
            this.fld_txtARSaleForecastContQty.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastContQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastContQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastContQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastContQty.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastContQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastContQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastContQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleForecastContQty, true);
            this.fld_txtARSaleForecastContQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastContQty.TabIndex = 23;
            this.fld_txtARSaleForecastContQty.Tag = "DC";
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
            this.fld_lblContQty.Location = new System.Drawing.Point(925, 142);
            this.fld_lblContQty.Name = "fld_lblContQty";
            this.fld_lblContQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblContQty, true);
            this.fld_lblContQty.Size = new System.Drawing.Size(68, 13);
            this.fld_lblContQty.TabIndex = 107;
            this.fld_lblContQty.Text = "Số lượng Cont";
            // 
            // fld_txtARSaleForecastPONo
            // 
            this.fld_txtARSaleForecastPONo.BOSComment = null;
            this.fld_txtARSaleForecastPONo.BOSDataMember = "ARSaleForecastPONo";
            this.fld_txtARSaleForecastPONo.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastPONo.BOSDescription = null;
            this.fld_txtARSaleForecastPONo.BOSError = null;
            this.fld_txtARSaleForecastPONo.BOSFieldGroup = null;
            this.fld_txtARSaleForecastPONo.BOSFieldRelation = null;
            this.fld_txtARSaleForecastPONo.BOSPrivilege = null;
            this.fld_txtARSaleForecastPONo.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastPONo.Location = new System.Drawing.Point(448, 113);
            this.fld_txtARSaleForecastPONo.Name = "fld_txtARSaleForecastPONo";
            this.fld_txtARSaleForecastPONo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastPONo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastPONo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastPONo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastPONo.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastPONo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastPONo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastPONo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleForecastPONo, true);
            this.fld_txtARSaleForecastPONo.Size = new System.Drawing.Size(149, 20);
            this.fld_txtARSaleForecastPONo.TabIndex = 17;
            this.fld_txtARSaleForecastPONo.Tag = "DC";
            this.fld_txtARSaleForecastPONo.Validated += new System.EventHandler(this.fld_txtARSaleForecastPONo_Validated);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel18.Location = new System.Drawing.Point(365, 116);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(33, 13);
            this.bosLabel18.TabIndex = 105;
            this.bosLabel18.Text = "Số P.O";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(365, 142);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(46, 13);
            this.bosLabel15.TabIndex = 104;
            this.bosLabel15.Text = "Ngày P.O";
            // 
            // fld_ARSaleForecastPODate
            // 
            this.fld_ARSaleForecastPODate.BOSComment = null;
            this.fld_ARSaleForecastPODate.BOSDataMember = "ARSaleForecastPODate";
            this.fld_ARSaleForecastPODate.BOSDataSource = "ARSaleForecasts";
            this.fld_ARSaleForecastPODate.BOSDescription = null;
            this.fld_ARSaleForecastPODate.BOSError = null;
            this.fld_ARSaleForecastPODate.BOSFieldGroup = null;
            this.fld_ARSaleForecastPODate.BOSFieldRelation = null;
            this.fld_ARSaleForecastPODate.BOSPrivilege = null;
            this.fld_ARSaleForecastPODate.BOSPropertyName = "EditValue";
            this.fld_ARSaleForecastPODate.EditValue = null;
            this.fld_ARSaleForecastPODate.Location = new System.Drawing.Point(448, 139);
            this.fld_ARSaleForecastPODate.Name = "fld_ARSaleForecastPODate";
            this.fld_ARSaleForecastPODate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ARSaleForecastPODate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ARSaleForecastPODate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ARSaleForecastPODate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ARSaleForecastPODate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ARSaleForecastPODate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_ARSaleForecastPODate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ARSaleForecastPODate, true);
            this.fld_ARSaleForecastPODate.Size = new System.Drawing.Size(149, 20);
            this.fld_ARSaleForecastPODate.TabIndex = 21;
            this.fld_ARSaleForecastPODate.Tag = "DC";
            // 
            // fld_txtARSaleForecastTotalProduct
            // 
            this.fld_txtARSaleForecastTotalProduct.BOSComment = null;
            this.fld_txtARSaleForecastTotalProduct.BOSDataMember = "ARSaleForecastTotalProduct";
            this.fld_txtARSaleForecastTotalProduct.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastTotalProduct.BOSDescription = null;
            this.fld_txtARSaleForecastTotalProduct.BOSError = null;
            this.fld_txtARSaleForecastTotalProduct.BOSFieldGroup = null;
            this.fld_txtARSaleForecastTotalProduct.BOSFieldRelation = null;
            this.fld_txtARSaleForecastTotalProduct.BOSPrivilege = null;
            this.fld_txtARSaleForecastTotalProduct.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastTotalProduct.Location = new System.Drawing.Point(757, 139);
            this.fld_txtARSaleForecastTotalProduct.Name = "fld_txtARSaleForecastTotalProduct";
            this.fld_txtARSaleForecastTotalProduct.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleForecastTotalProduct.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastTotalProduct.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastTotalProduct.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastTotalProduct.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastTotalProduct.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastTotalProduct.Properties.ReadOnly = true;
            this.fld_txtARSaleForecastTotalProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastTotalProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleForecastTotalProduct, true);
            this.fld_txtARSaleForecastTotalProduct.Size = new System.Drawing.Size(149, 20);
            this.fld_txtARSaleForecastTotalProduct.TabIndex = 22;
            this.fld_txtARSaleForecastTotalProduct.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(629, 142);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(60, 13);
            this.bosLabel3.TabIndex = 101;
            this.bosLabel3.Text = "SL sản phẩm";
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
            this.fld_lbWoodType.Location = new System.Drawing.Point(119, 116);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 99;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_lblLabelSaleForecastType
            // 
            this.fld_lblLabelSaleForecastType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleForecastType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleForecastType.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelSaleForecastType.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelSaleForecastType.BOSComment = null;
            this.fld_lblLabelSaleForecastType.BOSDataMember = null;
            this.fld_lblLabelSaleForecastType.BOSDataSource = null;
            this.fld_lblLabelSaleForecastType.BOSDescription = null;
            this.fld_lblLabelSaleForecastType.BOSError = null;
            this.fld_lblLabelSaleForecastType.BOSFieldGroup = null;
            this.fld_lblLabelSaleForecastType.BOSFieldRelation = null;
            this.fld_lblLabelSaleForecastType.BOSPrivilege = null;
            this.fld_lblLabelSaleForecastType.BOSPropertyName = null;
            this.fld_lblLabelSaleForecastType.Location = new System.Drawing.Point(119, 64);
            this.fld_lblLabelSaleForecastType.Name = "fld_lblLabelSaleForecastType";
            this.fld_lblLabelSaleForecastType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelSaleForecastType, true);
            this.fld_lblLabelSaleForecastType.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabelSaleForecastType.TabIndex = 90;
            this.fld_lblLabelSaleForecastType.Text = "Loại đơn hàng";
            // 
            // fld_lkeARSaleForecastType
            // 
            this.fld_lkeARSaleForecastType.BOSAllowAddNew = false;
            this.fld_lkeARSaleForecastType.BOSAllowDummy = true;
            this.fld_lkeARSaleForecastType.BOSComment = null;
            this.fld_lkeARSaleForecastType.BOSDataMember = "ARSaleForecastType";
            this.fld_lkeARSaleForecastType.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeARSaleForecastType.BOSDescription = null;
            this.fld_lkeARSaleForecastType.BOSError = null;
            this.fld_lkeARSaleForecastType.BOSFieldGroup = null;
            this.fld_lkeARSaleForecastType.BOSFieldParent = null;
            this.fld_lkeARSaleForecastType.BOSFieldRelation = null;
            this.fld_lkeARSaleForecastType.BOSPrivilege = null;
            this.fld_lkeARSaleForecastType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleForecastType.BOSSelectType = "";
            this.fld_lkeARSaleForecastType.BOSSelectTypeValue = "";
            this.fld_lkeARSaleForecastType.CurrentDisplayText = null;
            this.fld_lkeARSaleForecastType.Location = new System.Drawing.Point(201, 61);
            this.fld_lkeARSaleForecastType.Name = "fld_lkeARSaleForecastType";
            this.fld_lkeARSaleForecastType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleForecastType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleForecastType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleForecastType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleForecastType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleForecastType.Properties.ColumnName = null;
            this.fld_lkeARSaleForecastType.Properties.NullText = "";
            this.fld_lkeARSaleForecastType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleForecastType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleForecastType, true);
            this.fld_lkeARSaleForecastType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleForecastType.TabIndex = 8;
            this.fld_lkeARSaleForecastType.Tag = "DC";
            this.fld_lkeARSaleForecastType.EditValueChanged += new System.EventHandler(this.fld_lkeARSaleForecastType_EditValueChanged);
            // 
            // fld_txtARSaleForecastExchangeRate2
            // 
            this.fld_txtARSaleForecastExchangeRate2.BOSComment = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSDataMember = "ARSaleForecastExchangeRate2";
            this.fld_txtARSaleForecastExchangeRate2.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastExchangeRate2.BOSDescription = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSError = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSFieldGroup = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSFieldRelation = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSPrivilege = null;
            this.fld_txtARSaleForecastExchangeRate2.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastExchangeRate2.Location = new System.Drawing.Point(1048, 113);
            this.fld_txtARSaleForecastExchangeRate2.Name = "fld_txtARSaleForecastExchangeRate2";
            this.fld_txtARSaleForecastExchangeRate2.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastExchangeRate2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastExchangeRate2.Screen = null;
            this.fld_txtARSaleForecastExchangeRate2.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastExchangeRate2.TabIndex = 19;
            this.fld_txtARSaleForecastExchangeRate2.Tag = "DC";
            this.fld_txtARSaleForecastExchangeRate2.Validated += new System.EventHandler(this.fld_txtARSaleForecastExchangeRate2_Validated);
            // 
            // fld_txtARSaleForecastPercentQty
            // 
            this.fld_txtARSaleForecastPercentQty.BOSComment = null;
            this.fld_txtARSaleForecastPercentQty.BOSDataMember = "ARSaleForecastPercentQty";
            this.fld_txtARSaleForecastPercentQty.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastPercentQty.BOSDescription = null;
            this.fld_txtARSaleForecastPercentQty.BOSError = null;
            this.fld_txtARSaleForecastPercentQty.BOSFieldGroup = null;
            this.fld_txtARSaleForecastPercentQty.BOSFieldRelation = null;
            this.fld_txtARSaleForecastPercentQty.BOSPrivilege = null;
            this.fld_txtARSaleForecastPercentQty.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastPercentQty.Location = new System.Drawing.Point(200, 165);
            this.fld_txtARSaleForecastPercentQty.Name = "fld_txtARSaleForecastPercentQty";
            this.fld_txtARSaleForecastPercentQty.Screen = null;
            this.fld_txtARSaleForecastPercentQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastPercentQty.TabIndex = 24;
            this.fld_txtARSaleForecastPercentQty.Tag = "DC";
            // 
            // fld_txtARSaleForecastExchangeRate
            // 
            this.fld_txtARSaleForecastExchangeRate.BOSComment = null;
            this.fld_txtARSaleForecastExchangeRate.BOSDataMember = "ARSaleForecastExchangeRate";
            this.fld_txtARSaleForecastExchangeRate.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastExchangeRate.BOSDescription = null;
            this.fld_txtARSaleForecastExchangeRate.BOSError = null;
            this.fld_txtARSaleForecastExchangeRate.BOSFieldGroup = null;
            this.fld_txtARSaleForecastExchangeRate.BOSFieldRelation = null;
            this.fld_txtARSaleForecastExchangeRate.BOSPrivilege = null;
            this.fld_txtARSaleForecastExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastExchangeRate.Location = new System.Drawing.Point(757, 113);
            this.fld_txtARSaleForecastExchangeRate.Name = "fld_txtARSaleForecastExchangeRate";
            this.fld_txtARSaleForecastExchangeRate.Screen = null;
            this.fld_txtARSaleForecastExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastExchangeRate.TabIndex = 18;
            this.fld_txtARSaleForecastExchangeRate.Tag = "DC";
            this.fld_txtARSaleForecastExchangeRate.Validated += new System.EventHandler(this.fld_txtARSaleForecastExchangeRate_Validated);
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
            this.bosLabel22.Location = new System.Drawing.Point(925, 116);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(67, 13);
            this.bosLabel22.TabIndex = 72;
            this.bosLabel22.Text = "Tỷ giá quy đổi";
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
            this.bosLabel24.Location = new System.Drawing.Point(119, 168);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(61, 13);
            this.bosLabel24.TabIndex = 72;
            this.bosLabel24.Text = "% tăng giảm";
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
            this.bosLabel12.Location = new System.Drawing.Point(629, 116);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 72;
            this.bosLabel12.Text = "Tỷ giá";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(925, 90);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(91, 13);
            this.bosLabel13.TabIndex = 72;
            this.bosLabel13.Text = "Loại tiền tệ quy đổi";
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
            this.bosLabel11.Location = new System.Drawing.Point(629, 90);
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
            this.bosLabel1.Location = new System.Drawing.Point(365, 90);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(70, 13);
            this.bosLabel1.TabIndex = 72;
            this.bosLabel1.Text = "Người bán phụ";
            // 
            // fld_lkeFK_ARAssociatedSellerID
            // 
            this.fld_lkeFK_ARAssociatedSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARAssociatedSellerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARAssociatedSellerID.BOSComment = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSDataMember = "FK_ARAssociatedSellerID";
            this.fld_lkeFK_ARAssociatedSellerID.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeFK_ARAssociatedSellerID.BOSDescription = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSError = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSFieldParent = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSPrivilege = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARAssociatedSellerID.BOSSelectType = null;
            this.fld_lkeFK_ARAssociatedSellerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARAssociatedSellerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARAssociatedSellerID.Location = new System.Drawing.Point(448, 87);
            this.fld_lkeFK_ARAssociatedSellerID.Name = "fld_lkeFK_ARAssociatedSellerID";
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARAssociatedSellerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARAssociatedSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_ARAssociatedSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARAssociatedSellerID.Properties.NullText = "";
            this.fld_lkeFK_ARAssociatedSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARAssociatedSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARAssociatedSellerID.Screen = null;
            this.fld_lkeFK_ARAssociatedSellerID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_ARAssociatedSellerID.TabIndex = 13;
            this.fld_lkeFK_ARAssociatedSellerID.Tag = "DC";
            // 
            // fld_txtARSaleForecastSFCommissionPercent
            // 
            this.fld_txtARSaleForecastSFCommissionPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastSFCommissionPercent.BOSComment = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSDataMember = "ARSaleForecastSFCommissionPercent";
            this.fld_txtARSaleForecastSFCommissionPercent.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastSFCommissionPercent.BOSDescription = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSError = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSFieldGroup = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSFieldRelation = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSPrivilege = null;
            this.fld_txtARSaleForecastSFCommissionPercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastSFCommissionPercent.EditValue = "0.00";
            this.fld_txtARSaleForecastSFCommissionPercent.Location = new System.Drawing.Point(1130, 570);
            this.fld_txtARSaleForecastSFCommissionPercent.Name = "fld_txtARSaleForecastSFCommissionPercent";
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastSFCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastSFCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastSFCommissionPercent.Screen = null;
            this.fld_txtARSaleForecastSFCommissionPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARSaleForecastSFCommissionPercent.TabIndex = 41;
            this.fld_txtARSaleForecastSFCommissionPercent.Tag = "DC";
            this.fld_txtARSaleForecastSFCommissionPercent.Validated += new System.EventHandler(this.fld_txtARSaleForecastCustomerCommissionPercent_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(1051, 573);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 48;
            this.bosLabel2.Text = "Hoa hồng";
            // 
            // fld_lkeFK_GECurrencyID2
            // 
            this.fld_lkeFK_GECurrencyID2.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID2.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID2.BOSComment = null;
            this.fld_lkeFK_GECurrencyID2.BOSDataMember = "FK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_GECurrencyID2.Location = new System.Drawing.Point(1048, 87);
            this.fld_lkeFK_GECurrencyID2.Name = "fld_lkeFK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID2.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID2.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID2.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID2.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID2.Screen = null;
            this.fld_lkeFK_GECurrencyID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID2.TabIndex = 15;
            this.fld_lkeFK_GECurrencyID2.Tag = "DC";
            this.fld_lkeFK_GECurrencyID2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID2_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARSaleForecasts";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(757, 87);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 14;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtARSaleForecastSFCommissionAmount
            // 
            this.fld_txtARSaleForecastSFCommissionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleForecastSFCommissionAmount.BOSComment = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSDataMember = "ARSaleForecastSFCommissionAmount";
            this.fld_txtARSaleForecastSFCommissionAmount.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastSFCommissionAmount.BOSDescription = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSError = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSFieldGroup = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSFieldRelation = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSPrivilege = null;
            this.fld_txtARSaleForecastSFCommissionAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastSFCommissionAmount.EditValue = "0.00";
            this.fld_txtARSaleForecastSFCommissionAmount.Location = new System.Drawing.Point(1208, 570);
            this.fld_txtARSaleForecastSFCommissionAmount.Name = "fld_txtARSaleForecastSFCommissionAmount";
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleForecastSFCommissionAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastSFCommissionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastSFCommissionAmount.Screen = null;
            this.fld_txtARSaleForecastSFCommissionAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleForecastSFCommissionAmount.TabIndex = 42;
            this.fld_txtARSaleForecastSFCommissionAmount.Tag = "DC";
            this.fld_txtARSaleForecastSFCommissionAmount.Validated += new System.EventHandler(this.fld_txtARSaleForecastSOCommissionAmount_Validated);
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = "ARSaleForecastDeliveryContactEmail1";
            this.bosLabel32.BOSDataSource = "ARSaleForecasts";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(9, 195);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel32, true);
            this.bosLabel32.Size = new System.Drawing.Size(34, 13);
            this.bosLabel32.TabIndex = 80;
            this.bosLabel32.Text = "@gmail";
            // 
            // DMSF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1335, 784);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSF100.IconOptions.Icon")));
            this.Name = "DMSF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleForecastEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleForecastDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleForecastItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountPerCentForItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTotalAmount.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo1.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkViewDiffPrice.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).EndInit();
            this.fld_Line4.ResumeLayout(false);
            this.fld_Line4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastTransshipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastContQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ARSaleForecastPODate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ARSaleForecastPODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastTotalProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleForecastType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastExchangeRate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastPercentQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARAssociatedSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastSFCommissionAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteARSaleForecastItemProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleForecastStatus;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastDepositBalance;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastBalanceDue;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastNo1;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastSFContactName;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastTaxAmount;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkViewDiffPrice;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARAssociatedSellerID;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastSFCommissionPercent;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastSFCommissionAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastTotalProduct;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLabel fld_lblLabelSaleForecastType;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleForecastType;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastContQty;
        private BOSComponent.BOSLabel fld_lblContQty;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastPONo;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSDateEdit fld_ARSaleForecastPODate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel fld_lbPaymentTerm;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeARShippingType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLine fld_Line4;
        private BOSComponent.BOSLabel fld_lblARSaleForecastInvoiceContactName;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton fld_btnEditShippingInfo;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblARSaleForecastDeliveryContactName;
        private BOSComponent.BOSLabel fld_lblLabel37;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel36;
        private BOSComponent.BOSLabel fld_lblLabel34;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLine fld_Line;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderProductType;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleForecastTransshipment;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastExchangeRate2;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID2;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSButton fld_btnViewHistorySF;
        private BOSComponent.BOSButton fld_btnUpdateQty;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastPercentQty;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSButton fld_btnFromProposal;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastDiscountFix;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSButton fld_btnImport;
        private BOSComponent.BOSButton fld_btnExportTemplate;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastDiscountPerCent;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSTextBox fld_txtARProposalTotalCost;
        private BOSComponent.BOSRichEditControl fld_recARSaleForecastComment;
        private BOSComponent.BOSRichEditControl fld_recARSaleForecastInternalComment;
        private BOSComponent.BOSLabel bosLabel32;
    }
}
