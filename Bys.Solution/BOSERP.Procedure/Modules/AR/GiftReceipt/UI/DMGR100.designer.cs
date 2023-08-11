using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.GiftReceipt.UI
{
    /// <summary>
    /// Summary description for DMGR100
    /// </summary>
    partial class DMGR100
    {
        private BOSComponent.BOSLabel fld_lblLabel4;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private ARInoviceItemsGridControl fld_dgcARInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoiceItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARInvoiceTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARInvoiceDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARInvoiceSubTotalAmount;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceEmployeePicture;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSPictureEdit fld_pteARInvoiceItemProductPicture;
        private BOSComponent.BOSLabel fld_lblARInvoiceDate;
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
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARInvoiceItems = new BOSERP.Modules.GiftReceipt.ARInoviceItemsGridControl();
            this.fld_dgvARInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteARInvoiceItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARInvoiceTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteARInvoiceEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblARInvoiceDate = new BOSComponent.BOSLabel(this.components);
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
            this.fld_tabInvoiceItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).BeginInit();
            this.fld_tabInvoiceItems.SuspendLayout();
            this.fld_tabPageInvoiceItems.SuspendLayout();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
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
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARInvoiceItems";
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
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", 50, "Barcode")});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(648, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
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
            this.fld_dgcARInvoiceItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoiceItems.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcARInvoiceItems.MainView = this.fld_dgvARInvoiceItems;
            this.fld_dgcARInvoiceItems.Name = "fld_dgcARInvoiceItems";
            this.fld_dgcARInvoiceItems.Screen = null;
            this.fld_dgcARInvoiceItems.Size = new System.Drawing.Size(711, 255);
            this.fld_dgcARInvoiceItems.TabIndex = 2;
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
            this.fld_pteARInvoiceItemProductPicture.Location = new System.Drawing.Point(724, 3);
            this.fld_pteARInvoiceItemProductPicture.Name = "fld_pteARInvoiceItemProductPicture";
            this.fld_pteARInvoiceItemProductPicture.Screen = null;
            this.fld_pteARInvoiceItemProductPicture.Size = new System.Drawing.Size(140, 132);
            this.fld_pteARInvoiceItemProductPicture.TabIndex = 1;
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
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = "";
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(217, 36);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 5;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            this.fld_lkeFK_ARCustomerID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID_CloseUp);
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(642, 497);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel15.TabIndex = 414;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tổng cộng";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.fld_lblLabel19.Location = new System.Drawing.Point(624, 572);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(68, 16);
            this.fld_lblLabel19.TabIndex = 415;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Thành tiền";
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
            this.fld_lblLabel20.Location = new System.Drawing.Point(655, 473);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel20.TabIndex = 417;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Mức giá";
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
            this.fld_lkeFK_ARPriceLevelID.BOSError = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(709, 470);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.NullText = "";
            this.fld_lkeFK_ARPriceLevelID.Properties.PopupWidth = 20;
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(169, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 14;
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
            this.fld_txtARInvoiceTotalAmount.Location = new System.Drawing.Point(709, 571);
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
            this.fld_txtARInvoiceTotalAmount.TabIndex = 20;
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
            this.fld_txtARInvoiceDiscountFix.Location = new System.Drawing.Point(775, 519);
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
            this.fld_txtARInvoiceDiscountFix.Size = new System.Drawing.Size(102, 20);
            this.fld_txtARInvoiceDiscountFix.TabIndex = 17;
            this.fld_txtARInvoiceDiscountFix.Tag = "DC";
            this.fld_txtARInvoiceDiscountFix.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountAmount_Validated);
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
            this.fld_txtARInvoiceSubTotalAmount.Location = new System.Drawing.Point(709, 494);
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
            this.fld_txtARInvoiceSubTotalAmount.Size = new System.Drawing.Size(169, 20);
            this.fld_txtARInvoiceSubTotalAmount.TabIndex = 15;
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
            this.fld_pteARInvoiceEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARInvoiceEmployeePicture.Name = "fld_pteARInvoiceEmployeePicture";
            this.fld_pteARInvoiceEmployeePicture.Screen = null;
            this.fld_pteARInvoiceEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARInvoiceEmployeePicture.TabIndex = 0;
            this.fld_pteARInvoiceEmployeePicture.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(125, 39);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel11.TabIndex = 470;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Khách hàng";
            // 
            // fld_lblARInvoiceDate
            // 
            this.fld_lblARInvoiceDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblARInvoiceDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_lblARInvoiceDate.Appearance.Options.UseBackColor = true;
            this.fld_lblARInvoiceDate.Appearance.Options.UseForeColor = true;
            this.fld_lblARInvoiceDate.BOSComment = "";
            this.fld_lblARInvoiceDate.BOSDataMember = "";
            this.fld_lblARInvoiceDate.BOSDataSource = "";
            this.fld_lblARInvoiceDate.BOSDescription = null;
            this.fld_lblARInvoiceDate.BOSError = null;
            this.fld_lblARInvoiceDate.BOSFieldGroup = "";
            this.fld_lblARInvoiceDate.BOSFieldRelation = "";
            this.fld_lblARInvoiceDate.BOSPrivilege = "";
            this.fld_lblARInvoiceDate.BOSPropertyName = null;
            this.fld_lblARInvoiceDate.Location = new System.Drawing.Point(395, 13);
            this.fld_lblARInvoiceDate.Name = "fld_lblARInvoiceDate";
            this.fld_lblARInvoiceDate.Screen = null;
            this.fld_lblARInvoiceDate.Size = new System.Drawing.Size(67, 13);
            this.fld_lblARInvoiceDate.TabIndex = 473;
            this.fld_lblARInvoiceDate.Tag = "";
            this.fld_lblARInvoiceDate.Text = "Ngày hóa đơn";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(658, 13);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel2.TabIndex = 478;
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(641, 522);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel7.TabIndex = 480;
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
            this.fld_txtARInvoiceDiscountPerCent.Location = new System.Drawing.Point(709, 519);
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
            this.fld_txtARInvoiceDiscountPerCent.TabIndex = 16;
            this.fld_txtARInvoiceDiscountPerCent.Tag = "DC";
            this.fld_txtARInvoiceDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountPerCent_Validated);
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
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(487, 10);
            this.fld_dteARInvoiceDate.MenuManager = this.screenToolbar;
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARInvoiceDate.TabIndex = 3;
            this.fld_dteARInvoiceDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(125, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 473;
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
            this.fld_txtARInvoiceNo.Location = new System.Drawing.Point(217, 10);
            this.fld_txtARInvoiceNo.MenuManager = this.screenToolbar;
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Screen = null;
            this.fld_txtARInvoiceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARInvoiceNo.TabIndex = 2;
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
            this.fld_medARInvoiceDesc.Location = new System.Drawing.Point(217, 62);
            this.fld_medARInvoiceDesc.MenuManager = this.screenToolbar;
            this.fld_medARInvoiceDesc.Name = "fld_medARInvoiceDesc";
            this.fld_medARInvoiceDesc.Screen = null;
            this.fld_medARInvoiceDesc.Size = new System.Drawing.Size(656, 32);
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
            this.fld_lkeARInvoiceStatus.Location = new System.Drawing.Point(723, 10);
            this.fld_lkeARInvoiceStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARInvoiceStatus.Name = "fld_lkeARInvoiceStatus";
            this.fld_lkeARInvoiceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceStatus.Properties.NullText = "";
            this.fld_lkeARInvoiceStatus.Properties.ReadOnly = true;
            this.fld_lkeARInvoiceStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceStatus.Screen = null;
            this.fld_lkeARInvoiceStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceStatus.TabIndex = 4;
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
            this.bosLabel2.Location = new System.Drawing.Point(668, 546);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(24, 13);
            this.bosLabel2.TabIndex = 480;
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
            this.fld_txtARInvoiceTaxPercent.Location = new System.Drawing.Point(709, 543);
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
            this.fld_txtARInvoiceTaxPercent.TabIndex = 18;
            this.fld_txtARInvoiceTaxPercent.Tag = "DC";
            this.fld_txtARInvoiceTaxPercent.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountAmount_Validated);
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
            this.fld_txtARInvoiceTaxAmount.Location = new System.Drawing.Point(775, 543);
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
            this.fld_txtARInvoiceTaxAmount.Size = new System.Drawing.Size(102, 20);
            this.fld_txtARInvoiceTaxAmount.TabIndex = 19;
            this.fld_txtARInvoiceTaxAmount.Tag = "DC";
            this.fld_txtARInvoiceTaxAmount.Validated += new System.EventHandler(this.fld_txtARInvoiceDiscountAmount_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(395, 39);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 473;
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(487, 36);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 6;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(658, 39);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 473;
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
            this.fld_txtARInvoiceExchangeRate.Location = new System.Drawing.Point(723, 36);
            this.fld_txtARInvoiceExchangeRate.Name = "fld_txtARInvoiceExchangeRate";
            this.fld_txtARInvoiceExchangeRate.Screen = null;
            this.fld_txtARInvoiceExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARInvoiceExchangeRate.TabIndex = 7;
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
            this.bosLine1.Location = new System.Drawing.Point(3, 460);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(311, 128);
            this.bosLine1.TabIndex = 13;
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
            this.fld_medARInvoiceComment.Size = new System.Drawing.Size(305, 108);
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
            this.bosPanel1.Controls.Add(this.fld_medARInvoiceDesc);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceItems);
            this.bosPanel1.Controls.Add(this.fld_pteARInvoiceEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lblARInvoiceDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeARInvoiceStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel19);
            this.bosPanel1.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel11);
            this.bosPanel1.Controls.Add(this.fld_lblLabel15);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceDiscountPerCent);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtARInvoiceSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
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
            this.bosPanel1.Size = new System.Drawing.Size(889, 603);
            this.bosPanel1.TabIndex = 481;
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
            this.fld_tabInvoiceItems.Location = new System.Drawing.Point(3, 130);
            this.fld_tabInvoiceItems.Name = "fld_tabInvoiceItems";
            this.fld_tabInvoiceItems.Screen = null;
            this.fld_tabInvoiceItems.SelectedTabPage = this.fld_tabPageInvoiceItems;
            this.fld_tabInvoiceItems.Size = new System.Drawing.Size(874, 324);
            this.fld_tabInvoiceItems.TabIndex = 12;
            this.fld_tabInvoiceItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageInvoiceItems
            // 
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lblLabel4);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_dgcARInvoiceItems);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_pteARInvoiceItemProductPicture);
            this.fld_tabPageInvoiceItems.Name = "fld_tabPageInvoiceItems";
            this.fld_tabPageInvoiceItems.Size = new System.Drawing.Size(867, 295);
            this.fld_tabPageInvoiceItems.Text = "Danh sách sản phẩm";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(867, 295);
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
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(867, 295);
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
            this.bosLabel6.Location = new System.Drawing.Point(125, 65);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 478;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Diễn giải";
            // 
            // DMGR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(889, 603);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMGR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARInvoiceEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).EndInit();
            this.fld_tabInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.PerformLayout();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

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
        private BOSComponent.BOSTabControl fld_tabInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceComment;
    }
}
