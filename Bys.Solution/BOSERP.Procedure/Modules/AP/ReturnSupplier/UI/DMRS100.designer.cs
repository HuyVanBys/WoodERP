using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReturnSupplier.UI
{
	/// <summary>
	/// Summary description for DMRS100
	/// </summary>
	partial class DMRS100
    {
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
		private APReturnSupplierItemsGridControl fld_dgcAPReturnSupplierItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPReturnSupplierItems;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSPictureEdit fld_pteAPReturnSupplierEmployeePicture;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSTextBox fld_txtAPReturnSupplierReference;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSTextBox fld_txtAPReturnSupplierSubTotalCost;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierTotalCost;
        private BOSComponent.BOSMemoEdit fld_medAPReturnSupplierReason;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRS100));
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcAPReturnSupplierItems = new BOSERP.Modules.ReturnSupplier.APReturnSupplierItemsGridControl();
            this.fld_dgvAPReturnSupplierItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteAPReturnSupplierEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierReference = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPReturnSupplierTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_medAPReturnSupplierReason = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteReturnSupplierDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeAPReturnSupplierStatusCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.ReturnSupplier.ACDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageInvoiceInItems = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteAPReturnSupplierItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_tabInvoiceInItems = new BOSComponent.BOSTabControl(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_APPurchaseContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPReturnSupplierReceiptType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPReturnSupplierReasonType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPReturnSupplierTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPReturnSupplierDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPReturnSupplierDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInSupplierNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPReturnSupplierItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPReturnSupplierItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPReturnSupplierEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPReturnSupplierReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReturnSupplierDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReturnSupplierDate.Properties)).BeginInit();
            this.BOSLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierStatusCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.fld_tabPageInvoiceInItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPReturnSupplierItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).BeginInit();
            this.fld_tabInvoiceInItems.SuspendLayout();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseContractID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierReceiptType.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierReasonType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "APReturnSupplierItems";
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
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(60, 9);
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
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(918, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 4;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcAPReturnSupplierItems
            // 
            this.fld_dgcAPReturnSupplierItems.AllowDrop = true;
            this.fld_dgcAPReturnSupplierItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPReturnSupplierItems.BOSComment = "";
            this.fld_dgcAPReturnSupplierItems.BOSDataMember = null;
            this.fld_dgcAPReturnSupplierItems.BOSDataSource = "APReturnSupplierItems";
            this.fld_dgcAPReturnSupplierItems.BOSDescription = null;
            this.fld_dgcAPReturnSupplierItems.BOSError = "";
            this.fld_dgcAPReturnSupplierItems.BOSFieldGroup = "";
            this.fld_dgcAPReturnSupplierItems.BOSFieldRelation = null;
            this.fld_dgcAPReturnSupplierItems.BOSGridType = null;
            this.fld_dgcAPReturnSupplierItems.BOSPrivilege = "";
            this.fld_dgcAPReturnSupplierItems.BOSPropertyName = null;
            this.fld_dgcAPReturnSupplierItems.CommodityType = "";
            this.fld_dgcAPReturnSupplierItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPReturnSupplierItems.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcAPReturnSupplierItems.MainView = this.fld_dgvAPReturnSupplierItems;
            this.fld_dgcAPReturnSupplierItems.Name = "fld_dgcAPReturnSupplierItems";
            this.fld_dgcAPReturnSupplierItems.PrintReport = false;
            this.fld_dgcAPReturnSupplierItems.Screen = null;
            this.fld_dgcAPReturnSupplierItems.Size = new System.Drawing.Size(975, 216);
            this.fld_dgcAPReturnSupplierItems.TabIndex = 20;
            this.fld_dgcAPReturnSupplierItems.Tag = "DC";
            this.fld_dgcAPReturnSupplierItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPReturnSupplierItems});
            // 
            // fld_dgvAPReturnSupplierItems
            // 
            this.fld_dgvAPReturnSupplierItems.GridControl = this.fld_dgcAPReturnSupplierItems;
            this.fld_dgvAPReturnSupplierItems.Name = "fld_dgvAPReturnSupplierItems";
            this.fld_dgvAPReturnSupplierItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 102);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(908, 511);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel15.TabIndex = 414;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tổng cộng";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseFont = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "";
            this.fld_Lablel2.BOSDataMember = "";
            this.fld_Lablel2.BOSDataSource = "";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "";
            this.fld_Lablel2.BOSFieldRelation = "";
            this.fld_Lablel2.BOSPrivilege = "";
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(860, 589);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(98, 17);
            this.fld_Lablel2.TabIndex = 415;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "TIỀN TRẢ LẠI";
            // 
            // fld_pteAPReturnSupplierEmployeePicture
            // 
            this.fld_pteAPReturnSupplierEmployeePicture.BOSComment = "";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSDataMember = "APReturnSupplierEmployeePicture";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSDataSource = "APReturnSuppliers";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSDescription = null;
            this.fld_pteAPReturnSupplierEmployeePicture.BOSError = "";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSFieldGroup = "";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPReturnSupplierEmployeePicture.BOSPrivilege = "";
            this.fld_pteAPReturnSupplierEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPReturnSupplierEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPReturnSupplierEmployeePicture.FileName = null;
            this.fld_pteAPReturnSupplierEmployeePicture.FilePath = null;
            this.fld_pteAPReturnSupplierEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteAPReturnSupplierEmployeePicture.Name = "fld_pteAPReturnSupplierEmployeePicture";
            this.fld_pteAPReturnSupplierEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPReturnSupplierEmployeePicture.Screen = null;
            this.fld_pteAPReturnSupplierEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteAPReturnSupplierEmployeePicture.TabIndex = 0;
            this.fld_pteAPReturnSupplierEmployeePicture.Tag = "DC";
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
            this.fld_lblLabel11.Location = new System.Drawing.Point(14, 47);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel11.TabIndex = 470;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Nhà cung cấp";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(507, 73);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel2.TabIndex = 478;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Tình trạng";
            // 
            // fld_txtAPReturnSupplierReference
            // 
            this.fld_txtAPReturnSupplierReference.BOSComment = "";
            this.fld_txtAPReturnSupplierReference.BOSDataMember = "APReturnSupplierReference";
            this.fld_txtAPReturnSupplierReference.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierReference.BOSDescription = null;
            this.fld_txtAPReturnSupplierReference.BOSError = "";
            this.fld_txtAPReturnSupplierReference.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierReference.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierReference.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierReference.BOSPropertyName = "Text";
            this.fld_txtAPReturnSupplierReference.Location = new System.Drawing.Point(341, 44);
            this.fld_txtAPReturnSupplierReference.Name = "fld_txtAPReturnSupplierReference";
            this.fld_txtAPReturnSupplierReference.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPReturnSupplierReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierReference.Screen = null;
            this.fld_txtAPReturnSupplierReference.Size = new System.Drawing.Size(140, 20);
            this.fld_txtAPReturnSupplierReference.TabIndex = 3;
            this.fld_txtAPReturnSupplierReference.Tag = "DC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(261, 47);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel.TabIndex = 483;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Số tham chiếu";
            // 
            // fld_txtAPReturnSupplierSubTotalCost
            // 
            this.fld_txtAPReturnSupplierSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierSubTotalCost.BOSComment = "";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSDataMember = "APReturnSupplierSubTotalCost";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSDescription = null;
            this.fld_txtAPReturnSupplierSubTotalCost.BOSError = "";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierSubTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPReturnSupplierSubTotalCost.Location = new System.Drawing.Point(982, 508);
            this.fld_txtAPReturnSupplierSubTotalCost.Name = "fld_txtAPReturnSupplierSubTotalCost";
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPReturnSupplierSubTotalCost.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPReturnSupplierSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierSubTotalCost.Screen = null;
            this.fld_txtAPReturnSupplierSubTotalCost.Size = new System.Drawing.Size(144, 20);
            this.fld_txtAPReturnSupplierSubTotalCost.TabIndex = 6;
            this.fld_txtAPReturnSupplierSubTotalCost.Tag = "DC";
            // 
            // fld_txtAPReturnSupplierTotalCost
            // 
            this.fld_txtAPReturnSupplierTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierTotalCost.BOSComment = "";
            this.fld_txtAPReturnSupplierTotalCost.BOSDataMember = "APReturnSupplierTotalCost";
            this.fld_txtAPReturnSupplierTotalCost.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierTotalCost.BOSDescription = null;
            this.fld_txtAPReturnSupplierTotalCost.BOSError = "";
            this.fld_txtAPReturnSupplierTotalCost.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierTotalCost.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierTotalCost.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPReturnSupplierTotalCost.Location = new System.Drawing.Point(982, 586);
            this.fld_txtAPReturnSupplierTotalCost.Name = "fld_txtAPReturnSupplierTotalCost";
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPReturnSupplierTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierTotalCost.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPReturnSupplierTotalCost.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPReturnSupplierTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierTotalCost.Screen = null;
            this.fld_txtAPReturnSupplierTotalCost.Size = new System.Drawing.Size(144, 20);
            this.fld_txtAPReturnSupplierTotalCost.TabIndex = 7;
            this.fld_txtAPReturnSupplierTotalCost.Tag = "DC";
            // 
            // fld_medAPReturnSupplierReason
            // 
            this.fld_medAPReturnSupplierReason.BOSComment = "";
            this.fld_medAPReturnSupplierReason.BOSDataMember = "APReturnSupplierReason";
            this.fld_medAPReturnSupplierReason.BOSDataSource = "APReturnSuppliers";
            this.fld_medAPReturnSupplierReason.BOSDescription = null;
            this.fld_medAPReturnSupplierReason.BOSError = "";
            this.fld_medAPReturnSupplierReason.BOSFieldGroup = "";
            this.fld_medAPReturnSupplierReason.BOSFieldRelation = "";
            this.fld_medAPReturnSupplierReason.BOSPrivilege = "";
            this.fld_medAPReturnSupplierReason.BOSPropertyName = "Text";
            this.fld_medAPReturnSupplierReason.Location = new System.Drawing.Point(6, 14);
            this.fld_medAPReturnSupplierReason.Name = "fld_medAPReturnSupplierReason";
            this.fld_medAPReturnSupplierReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPReturnSupplierReason.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPReturnSupplierReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPReturnSupplierReason.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPReturnSupplierReason.Screen = null;
            this.fld_medAPReturnSupplierReason.Size = new System.Drawing.Size(378, 74);
            this.fld_medAPReturnSupplierReason.TabIndex = 0;
            this.fld_medAPReturnSupplierReason.Tag = "DC";
            // 
            // fld_dteReturnSupplierDate
            // 
            this.fld_dteReturnSupplierDate.BOSComment = null;
            this.fld_dteReturnSupplierDate.BOSDataMember = "APReturnSupplierDate";
            this.fld_dteReturnSupplierDate.BOSDataSource = "APReturnSuppliers";
            this.fld_dteReturnSupplierDate.BOSDescription = null;
            this.fld_dteReturnSupplierDate.BOSError = null;
            this.fld_dteReturnSupplierDate.BOSFieldGroup = null;
            this.fld_dteReturnSupplierDate.BOSFieldRelation = null;
            this.fld_dteReturnSupplierDate.BOSPrivilege = null;
            this.fld_dteReturnSupplierDate.BOSPropertyName = "EditValue";
            this.fld_dteReturnSupplierDate.EditValue = null;
            this.fld_dteReturnSupplierDate.Location = new System.Drawing.Point(341, 18);
            this.fld_dteReturnSupplierDate.MenuManager = this.screenToolbar;
            this.fld_dteReturnSupplierDate.Name = "fld_dteReturnSupplierDate";
            this.fld_dteReturnSupplierDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteReturnSupplierDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteReturnSupplierDate.Screen = null;
            this.fld_dteReturnSupplierDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteReturnSupplierDate.TabIndex = 1;
            this.fld_dteReturnSupplierDate.Tag = "DC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel2.Appearance.Options.UseBackColor = true;
            this.BOSLabel2.Appearance.Options.UseForeColor = true;
            this.BOSLabel2.BOSComment = "";
            this.BOSLabel2.BOSDataMember = "";
            this.BOSLabel2.BOSDataSource = "";
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = "";
            this.BOSLabel2.BOSFieldRelation = "";
            this.BOSLabel2.BOSPrivilege = "";
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(261, 21);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 478;
            this.BOSLabel2.Tag = "";
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // BOSLine1
            // 
            this.BOSLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BOSLine1.BOSComment = null;
            this.BOSLine1.BOSDataMember = null;
            this.BOSLine1.BOSDataSource = null;
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = null;
            this.BOSLine1.BOSFieldRelation = null;
            this.BOSLine1.BOSPrivilege = null;
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Controls.Add(this.fld_medAPReturnSupplierReason);
            this.BOSLine1.Location = new System.Drawing.Point(12, 511);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(384, 95);
            this.BOSLine1.TabIndex = 5;
            this.BOSLine1.TabStop = false;
            this.BOSLine1.Text = "Lý do";
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
            this.bosLabel1.Location = new System.Drawing.Point(14, 21);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 490;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtAPReturnSupplierNo
            // 
            this.fld_txtAPReturnSupplierNo.BOSComment = null;
            this.fld_txtAPReturnSupplierNo.BOSDataMember = "APReturnSupplierNo";
            this.fld_txtAPReturnSupplierNo.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierNo.BOSDescription = null;
            this.fld_txtAPReturnSupplierNo.BOSError = null;
            this.fld_txtAPReturnSupplierNo.BOSFieldGroup = null;
            this.fld_txtAPReturnSupplierNo.BOSFieldRelation = null;
            this.fld_txtAPReturnSupplierNo.BOSPrivilege = null;
            this.fld_txtAPReturnSupplierNo.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierNo.Location = new System.Drawing.Point(97, 18);
            this.fld_txtAPReturnSupplierNo.MenuManager = this.screenToolbar;
            this.fld_txtAPReturnSupplierNo.Name = "fld_txtAPReturnSupplierNo";
            this.fld_txtAPReturnSupplierNo.Screen = null;
            this.fld_txtAPReturnSupplierNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtAPReturnSupplierNo.TabIndex = 0;
            this.fld_txtAPReturnSupplierNo.Tag = "DC";
            // 
            // fld_lkeAPReturnSupplierStatusCombo
            // 
            this.fld_lkeAPReturnSupplierStatusCombo.BOSAllowAddNew = false;
            this.fld_lkeAPReturnSupplierStatusCombo.BOSAllowDummy = false;
            this.fld_lkeAPReturnSupplierStatusCombo.BOSComment = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSDataMember = "APReturnSupplierStatusCombo";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSDescription = null;
            this.fld_lkeAPReturnSupplierStatusCombo.BOSError = null;
            this.fld_lkeAPReturnSupplierStatusCombo.BOSFieldGroup = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSFieldParent = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSFieldRelation = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSPrivilege = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSSelectType = "";
            this.fld_lkeAPReturnSupplierStatusCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPReturnSupplierStatusCombo.CurrentDisplayText = null;
            this.fld_lkeAPReturnSupplierStatusCombo.Location = new System.Drawing.Point(598, 70);
            this.fld_lkeAPReturnSupplierStatusCombo.Name = "fld_lkeAPReturnSupplierStatusCombo";
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.ColumnName = null;
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.NullText = "";
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.ReadOnly = true;
            this.fld_lkeAPReturnSupplierStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPReturnSupplierStatusCombo.Screen = null;
            this.fld_lkeAPReturnSupplierStatusCombo.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeAPReturnSupplierStatusCombo.TabIndex = 8;
            this.fld_lkeAPReturnSupplierStatusCombo.Tag = "DC";
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(14, 73);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 493;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại tiền tệ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(12, 99);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(31, 13);
            this.bosLabel5.TabIndex = 494;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Kí hiệu";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 177);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 495;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Ngày hóa đơn";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "APInvoiceInDate";
            this.bosDateEdit1.BOSDataSource = "APReturnSuppliers";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(107, 174);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(140, 20);
            this.bosDateEdit1.TabIndex = 6;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(14, 125);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(40, 13);
            this.bosLabel7.TabIndex = 497;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Diễn giải";
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
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(261, 73);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(29, 13);
            this.bosLabel8.TabIndex = 498;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tỷ giá";
            // 
            // fld_txtICReceiptExchangeRate
            // 
            this.fld_txtICReceiptExchangeRate.BOSComment = null;
            this.fld_txtICReceiptExchangeRate.BOSDataMember = "APReturnSupplierExchangeRate";
            this.fld_txtICReceiptExchangeRate.BOSDataSource = "APReturnSuppliers";
            this.fld_txtICReceiptExchangeRate.BOSDescription = null;
            this.fld_txtICReceiptExchangeRate.BOSError = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldGroup = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldRelation = null;
            this.fld_txtICReceiptExchangeRate.BOSPrivilege = null;
            this.fld_txtICReceiptExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(341, 70);
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 5;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(97, 70);
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
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "APReturnSupplierVATSymbol";
            this.bosTextBox3.BOSDataSource = "APReturnSuppliers";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(107, 96);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(140, 20);
            this.bosTextBox3.TabIndex = 3;
            this.bosTextBox3.Tag = "DC";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "APReturnSupplierDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "APReturnSuppliers";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(97, 122);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(384, 44);
            this.fld_medICReceiptDesc.TabIndex = 10;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APReturnSuppliers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(97, 44);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1101, 244);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1101, 244);
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
            // fld_tabPageInvoiceInItems
            // 
            this.fld_tabPageInvoiceInItems.Controls.Add(this.bosLabel9);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_pteAPReturnSupplierItemProductPicture);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_dgcAPReturnSupplierItems);
            this.fld_tabPageInvoiceInItems.Name = "fld_tabPageInvoiceInItems";
            this.fld_tabPageInvoiceInItems.Size = new System.Drawing.Size(1127, 254);
            this.fld_tabPageInvoiceInItems.Text = "Danh sách sản phẩm";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel9.Location = new System.Drawing.Point(7, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 0;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Sản phẩm";
            // 
            // fld_pteAPReturnSupplierItemProductPicture
            // 
            this.fld_pteAPReturnSupplierItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPReturnSupplierItemProductPicture.BOSComment = "";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSDataMember = "APReturnSupplierItemProductPicture";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSDataSource = "APReturnSupplierItems";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSDescription = null;
            this.fld_pteAPReturnSupplierItemProductPicture.BOSError = "";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSFieldGroup = "";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSFieldRelation = null;
            this.fld_pteAPReturnSupplierItemProductPicture.BOSPrivilege = "";
            this.fld_pteAPReturnSupplierItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPReturnSupplierItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPReturnSupplierItemProductPicture.FileName = null;
            this.fld_pteAPReturnSupplierItemProductPicture.FilePath = null;
            this.fld_pteAPReturnSupplierItemProductPicture.Location = new System.Drawing.Point(984, 9);
            this.fld_pteAPReturnSupplierItemProductPicture.Name = "fld_pteAPReturnSupplierItemProductPicture";
            this.fld_pteAPReturnSupplierItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPReturnSupplierItemProductPicture.Screen = null;
            this.fld_pteAPReturnSupplierItemProductPicture.Size = new System.Drawing.Size(140, 140);
            this.fld_pteAPReturnSupplierItemProductPicture.TabIndex = 471;
            this.fld_pteAPReturnSupplierItemProductPicture.Tag = "DC";
            // 
            // fld_tabInvoiceInItems
            // 
            this.fld_tabInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabInvoiceInItems.BOSComment = null;
            this.fld_tabInvoiceInItems.BOSDataMember = null;
            this.fld_tabInvoiceInItems.BOSDataSource = null;
            this.fld_tabInvoiceInItems.BOSDescription = null;
            this.fld_tabInvoiceInItems.BOSError = null;
            this.fld_tabInvoiceInItems.BOSFieldGroup = null;
            this.fld_tabInvoiceInItems.BOSFieldRelation = null;
            this.fld_tabInvoiceInItems.BOSPrivilege = null;
            this.fld_tabInvoiceInItems.BOSPropertyName = null;
            this.fld_tabInvoiceInItems.Location = new System.Drawing.Point(3, 207);
            this.fld_tabInvoiceInItems.Name = "fld_tabInvoiceInItems";
            this.fld_tabInvoiceInItems.Screen = null;
            this.fld_tabInvoiceInItems.SelectedTabPage = this.fld_tabPageInvoiceInItems;
            this.fld_tabInvoiceInItems.Size = new System.Drawing.Size(1129, 279);
            this.fld_tabInvoiceInItems.TabIndex = 4;
            this.fld_tabInvoiceInItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceInItems,
            this.fld_tabPageDocumentEntrys});
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
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.fld_txtAPReturnSupplierTaxNumber);
            this.bosLine3.Controls.Add(this.bosLabel19);
            this.bosLine3.Controls.Add(this.bosLabel12);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATFormNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATInvoiceNo);
            this.bosLine3.Controls.Add(this.bosTextBox3);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosLine3.Controls.Add(this.bosLabel11);
            this.bosLine3.Controls.Add(this.bosLabel10);
            this.bosLine3.Controls.Add(this.bosDateEdit1);
            this.bosLine3.Controls.Add(this.bosLabel6);
            this.bosLine3.Controls.Add(this.fld_lkeAPInputVATDocumentType);
            this.bosLine3.Controls.Add(this.bosLabel5);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(866, -1);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(260, 202);
            this.bosLine3.TabIndex = 3;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin VAT";
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
            this.bosLabel18.Location = new System.Drawing.Point(12, 151);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(20, 13);
            this.bosLabel18.TabIndex = 497;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "MST";
            // 
            // fld_txtAPReturnSupplierTaxNumber
            // 
            this.fld_txtAPReturnSupplierTaxNumber.BOSComment = "";
            this.fld_txtAPReturnSupplierTaxNumber.BOSDataMember = "APReturnSupplierTaxNumber";
            this.fld_txtAPReturnSupplierTaxNumber.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierTaxNumber.BOSDescription = null;
            this.fld_txtAPReturnSupplierTaxNumber.BOSError = null;
            this.fld_txtAPReturnSupplierTaxNumber.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierTaxNumber.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierTaxNumber.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierTaxNumber.EditValue = "";
            this.fld_txtAPReturnSupplierTaxNumber.Location = new System.Drawing.Point(107, 148);
            this.fld_txtAPReturnSupplierTaxNumber.Name = "fld_txtAPReturnSupplierTaxNumber";
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtAPReturnSupplierTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierTaxNumber.Screen = null;
            this.fld_txtAPReturnSupplierTaxNumber.Size = new System.Drawing.Size(140, 20);
            this.fld_txtAPReturnSupplierTaxNumber.TabIndex = 5;
            this.fld_txtAPReturnSupplierTaxNumber.Tag = "DC";
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
            this.bosLabel19.Location = new System.Drawing.Point(12, 125);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(54, 13);
            this.bosLabel19.TabIndex = 98;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Số hóa đơn";
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
            this.bosLabel12.Location = new System.Drawing.Point(12, 73);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(34, 13);
            this.bosLabel12.TabIndex = 96;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Mẫu số";
            // 
            // fld_txtARInvoiceVATFormNo
            // 
            this.fld_txtARInvoiceVATFormNo.BOSComment = "";
            this.fld_txtARInvoiceVATFormNo.BOSDataMember = "APReturnSupplierVATFormNo";
            this.fld_txtARInvoiceVATFormNo.BOSDataSource = "APReturnSuppliers";
            this.fld_txtARInvoiceVATFormNo.BOSDescription = null;
            this.fld_txtARInvoiceVATFormNo.BOSError = null;
            this.fld_txtARInvoiceVATFormNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATFormNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATFormNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATFormNo.EditValue = "";
            this.fld_txtARInvoiceVATFormNo.Location = new System.Drawing.Point(107, 70);
            this.fld_txtARInvoiceVATFormNo.Name = "fld_txtARInvoiceVATFormNo";
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATFormNo.Screen = null;
            this.fld_txtARInvoiceVATFormNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtARInvoiceVATFormNo.TabIndex = 2;
            this.fld_txtARInvoiceVATFormNo.Tag = "DC";
            // 
            // fld_txtARInvoiceVATInvoiceNo
            // 
            this.fld_txtARInvoiceVATInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataMember = "APReturnSupplierVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataSource = "APReturnSuppliers";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATInvoiceNo.EditValue = "";
            this.fld_txtARInvoiceVATInvoiceNo.Location = new System.Drawing.Point(107, 122);
            this.fld_txtARInvoiceVATInvoiceNo.Name = "fld_txtARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATInvoiceNo.Screen = null;
            this.fld_txtARInvoiceVATInvoiceNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtARInvoiceVATInvoiceNo.TabIndex = 4;
            this.fld_txtARInvoiceVATInvoiceNo.Tag = "DC";
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDescription = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSError = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectType = "ACEInvoiceTypeCombo";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectTypeValue = "Purchase";
            this.fld_lkeFK_ACEInvoiceTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(107, 44);
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
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(140, 20);
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
            this.bosLabel11.Location = new System.Drawing.Point(12, 47);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(85, 13);
            this.bosLabel11.TabIndex = 94;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Mã hóa đơn GTGT";
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 21);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(61, 13);
            this.bosLabel10.TabIndex = 77;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Loại hóa đơn";
            // 
            // fld_lkeAPInputVATDocumentType
            // 
            this.fld_lkeAPInputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeAPInputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeAPInputVATDocumentType.BOSComment = "";
            this.fld_lkeAPInputVATDocumentType.BOSDataMember = "APInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeAPInputVATDocumentType.BOSDescription = null;
            this.fld_lkeAPInputVATDocumentType.BOSError = null;
            this.fld_lkeAPInputVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldParent = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeAPInputVATDocumentType.BOSPrivilege = "";
            this.fld_lkeAPInputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInputVATDocumentType.BOSSelectType = "";
            this.fld_lkeAPInputVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeAPInputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeAPInputVATDocumentType.Location = new System.Drawing.Point(107, 18);
            this.fld_lkeAPInputVATDocumentType.Name = "fld_lkeAPInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInputVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeAPInputVATDocumentType.Properties.NullText = "";
            this.fld_lkeAPInputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInputVATDocumentType.Screen = null;
            this.fld_lkeAPInputVATDocumentType.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeAPInputVATDocumentType.TabIndex = 0;
            this.fld_lkeAPInputVATDocumentType.Tag = "DC";
            // 
            // fld_lkeFK_APPurchaseContractID
            // 
            this.fld_lkeFK_APPurchaseContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseContractID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchaseContractID.BOSComment = "";
            this.fld_lkeFK_APPurchaseContractID.BOSDataMember = "FK_APPurchaseContractID";
            this.fld_lkeFK_APPurchaseContractID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_APPurchaseContractID.BOSDescription = null;
            this.fld_lkeFK_APPurchaseContractID.BOSError = null;
            this.fld_lkeFK_APPurchaseContractID.BOSFieldGroup = "";
            this.fld_lkeFK_APPurchaseContractID.BOSFieldParent = "";
            this.fld_lkeFK_APPurchaseContractID.BOSFieldRelation = "";
            this.fld_lkeFK_APPurchaseContractID.BOSPrivilege = "";
            this.fld_lkeFK_APPurchaseContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchaseContractID.BOSSelectType = "";
            this.fld_lkeFK_APPurchaseContractID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APPurchaseContractID.CurrentDisplayText = "";
            this.fld_lkeFK_APPurchaseContractID.Location = new System.Drawing.Point(341, 96);
            this.fld_lkeFK_APPurchaseContractID.Name = "fld_lkeFK_APPurchaseContractID";
            this.fld_lkeFK_APPurchaseContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchaseContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchaseContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchaseContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchaseContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchaseContractID.Properties.ColumnName = null;
            this.fld_lkeFK_APPurchaseContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractName", "Tên hợp đồng")});
            this.fld_lkeFK_APPurchaseContractID.Properties.DisplayMember = "APPurchaseContractNo";
            this.fld_lkeFK_APPurchaseContractID.Properties.NullText = "";
            this.fld_lkeFK_APPurchaseContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchaseContractID.Properties.ValueMember = "APPurchaseContractID";
            this.fld_lkeFK_APPurchaseContractID.Screen = null;
            this.fld_lkeFK_APPurchaseContractID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_APPurchaseContractID.TabIndex = 7;
            this.fld_lkeFK_APPurchaseContractID.Tag = "DC";
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
            this.bosLabel13.Location = new System.Drawing.Point(261, 99);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(60, 13);
            this.bosLabel13.TabIndex = 604;
            this.bosLabel13.Text = "Số hợp đồng";
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
            this.bosLabel17.Location = new System.Drawing.Point(14, 99);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 607;
            this.bosLabel17.Text = "Loại hàng hóa";
            // 
            // fld_lkeAPReturnSupplierReceiptType
            // 
            this.fld_lkeAPReturnSupplierReceiptType.BOSAllowAddNew = false;
            this.fld_lkeAPReturnSupplierReceiptType.BOSAllowDummy = false;
            this.fld_lkeAPReturnSupplierReceiptType.BOSComment = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSDataMember = "APReturnSupplierReceiptType";
            this.fld_lkeAPReturnSupplierReceiptType.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeAPReturnSupplierReceiptType.BOSDescription = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSError = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSFieldGroup = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSFieldParent = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSFieldRelation = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSPrivilege = null;
            this.fld_lkeAPReturnSupplierReceiptType.BOSPropertyName = "EditValue";
            this.fld_lkeAPReturnSupplierReceiptType.BOSSelectType = "";
            this.fld_lkeAPReturnSupplierReceiptType.BOSSelectTypeValue = "";
            this.fld_lkeAPReturnSupplierReceiptType.CurrentDisplayText = null;
            this.fld_lkeAPReturnSupplierReceiptType.Location = new System.Drawing.Point(97, 96);
            this.fld_lkeAPReturnSupplierReceiptType.Name = "fld_lkeAPReturnSupplierReceiptType";
            this.fld_lkeAPReturnSupplierReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPReturnSupplierReceiptType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPReturnSupplierReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPReturnSupplierReceiptType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPReturnSupplierReceiptType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPReturnSupplierReceiptType.Properties.ColumnName = null;
            this.fld_lkeAPReturnSupplierReceiptType.Properties.NullText = "";
            this.fld_lkeAPReturnSupplierReceiptType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPReturnSupplierReceiptType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPReturnSupplierReceiptType, true);
            this.fld_lkeAPReturnSupplierReceiptType.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeAPReturnSupplierReceiptType.TabIndex = 6;
            this.fld_lkeAPReturnSupplierReceiptType.Tag = "DC";
            this.fld_lkeAPReturnSupplierReceiptType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPReturnSupplierReceiptType_CloseUp);
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
            this.bosLine2.Controls.Add(this.fld_lblLabel26);
            this.bosLine2.Controls.Add(this.bosLabel15);
            this.bosLine2.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosLine2.Controls.Add(this.fld_lkeAPReturnSupplierReasonType);
            this.bosLine2.Controls.Add(this.bosLabel26);
            this.bosLine2.Controls.Add(this.fld_medICReceiptDesc);
            this.bosLine2.Controls.Add(this.fld_txtAPInvoiceInSupplierNo);
            this.bosLine2.Controls.Add(this.fld_lkeFK_APPurchaseContractID);
            this.bosLine2.Controls.Add(this.bosLabel13);
            this.bosLine2.Controls.Add(this.fld_lkeAPReturnSupplierStatusCombo);
            this.bosLine2.Controls.Add(this.bosLabel17);
            this.bosLine2.Controls.Add(this.fld_lblLabel);
            this.bosLine2.Controls.Add(this.fld_lblLabel2);
            this.bosLine2.Controls.Add(this.fld_lkeAPReturnSupplierReceiptType);
            this.bosLine2.Controls.Add(this.fld_txtAPReturnSupplierReference);
            this.bosLine2.Controls.Add(this.fld_lblLabel11);
            this.bosLine2.Controls.Add(this.BOSLabel2);
            this.bosLine2.Controls.Add(this.fld_dteReturnSupplierDate);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine2.Controls.Add(this.fld_txtAPReturnSupplierNo);
            this.bosLine2.Controls.Add(this.bosLabel4);
            this.bosLine2.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosLine2.Controls.Add(this.bosLabel7);
            this.bosLine2.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine2.Controls.Add(this.bosLabel8);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(110, -1);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(750, 202);
            this.bosLine2.TabIndex = 2;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Thông tin chung";
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
            this.bosLabel15.Location = new System.Drawing.Point(507, 99);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(70, 13);
            this.bosLabel15.TabIndex = 609;
            this.bosLabel15.Text = "Lý do trả hàng";
            // 
            // fld_lkeAPReturnSupplierReasonType
            // 
            this.fld_lkeAPReturnSupplierReasonType.BOSAllowAddNew = false;
            this.fld_lkeAPReturnSupplierReasonType.BOSAllowDummy = false;
            this.fld_lkeAPReturnSupplierReasonType.BOSComment = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSDataMember = "APReturnSupplierReasonType";
            this.fld_lkeAPReturnSupplierReasonType.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeAPReturnSupplierReasonType.BOSDescription = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSError = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSFieldGroup = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSFieldParent = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSFieldRelation = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSPrivilege = null;
            this.fld_lkeAPReturnSupplierReasonType.BOSPropertyName = "EditValue";
            this.fld_lkeAPReturnSupplierReasonType.BOSSelectType = "";
            this.fld_lkeAPReturnSupplierReasonType.BOSSelectTypeValue = "";
            this.fld_lkeAPReturnSupplierReasonType.CurrentDisplayText = null;
            this.fld_lkeAPReturnSupplierReasonType.Location = new System.Drawing.Point(598, 96);
            this.fld_lkeAPReturnSupplierReasonType.Name = "fld_lkeAPReturnSupplierReasonType";
            this.fld_lkeAPReturnSupplierReasonType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPReturnSupplierReasonType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPReturnSupplierReasonType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPReturnSupplierReasonType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPReturnSupplierReasonType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPReturnSupplierReasonType.Properties.ColumnName = null;
            this.fld_lkeAPReturnSupplierReasonType.Properties.NullText = "";
            this.fld_lkeAPReturnSupplierReasonType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPReturnSupplierReasonType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPReturnSupplierReasonType, true);
            this.fld_lkeAPReturnSupplierReasonType.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeAPReturnSupplierReasonType.TabIndex = 9;
            this.fld_lkeAPReturnSupplierReasonType.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(934, 563);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(24, 13);
            this.bosLabel3.TabIndex = 418;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Thuế";
            // 
            // fld_txtAPReturnSupplierTaxPercent
            // 
            this.fld_txtAPReturnSupplierTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierTaxPercent.BOSComment = "";
            this.fld_txtAPReturnSupplierTaxPercent.BOSDataMember = "APReturnSupplierTaxPercent";
            this.fld_txtAPReturnSupplierTaxPercent.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierTaxPercent.BOSDescription = null;
            this.fld_txtAPReturnSupplierTaxPercent.BOSError = null;
            this.fld_txtAPReturnSupplierTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierTaxPercent.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierTaxPercent.EditValue = "";
            this.fld_txtAPReturnSupplierTaxPercent.Location = new System.Drawing.Point(982, 560);
            this.fld_txtAPReturnSupplierTaxPercent.Name = "fld_txtAPReturnSupplierTaxPercent";
            this.fld_txtAPReturnSupplierTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierTaxPercent.Screen = null;
            this.fld_txtAPReturnSupplierTaxPercent.Size = new System.Drawing.Size(56, 20);
            this.fld_txtAPReturnSupplierTaxPercent.TabIndex = 416;
            this.fld_txtAPReturnSupplierTaxPercent.Tag = "DC";
            // 
            // fld_txtAPReturnSupplierTaxAmount
            // 
            this.fld_txtAPReturnSupplierTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierTaxAmount.BOSComment = "";
            this.fld_txtAPReturnSupplierTaxAmount.BOSDataMember = "APReturnSupplierTaxAmount";
            this.fld_txtAPReturnSupplierTaxAmount.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierTaxAmount.BOSDescription = null;
            this.fld_txtAPReturnSupplierTaxAmount.BOSError = null;
            this.fld_txtAPReturnSupplierTaxAmount.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierTaxAmount.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierTaxAmount.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierTaxAmount.EditValue = "";
            this.fld_txtAPReturnSupplierTaxAmount.Location = new System.Drawing.Point(1044, 560);
            this.fld_txtAPReturnSupplierTaxAmount.Name = "fld_txtAPReturnSupplierTaxAmount";
            this.fld_txtAPReturnSupplierTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierTaxAmount.Screen = null;
            this.fld_txtAPReturnSupplierTaxAmount.Size = new System.Drawing.Size(82, 20);
            this.fld_txtAPReturnSupplierTaxAmount.TabIndex = 417;
            this.fld_txtAPReturnSupplierTaxAmount.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(907, 537);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(51, 13);
            this.bosLabel14.TabIndex = 421;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Chiết khấu";
            // 
            // fld_txtAPReturnSupplierDiscountPercent
            // 
            this.fld_txtAPReturnSupplierDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierDiscountPercent.BOSComment = "";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSDataMember = "APReturnSupplierDiscountPerCent";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSDescription = null;
            this.fld_txtAPReturnSupplierDiscountPercent.BOSError = null;
            this.fld_txtAPReturnSupplierDiscountPercent.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierDiscountPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierDiscountPercent.EditValue = "";
            this.fld_txtAPReturnSupplierDiscountPercent.Location = new System.Drawing.Point(982, 534);
            this.fld_txtAPReturnSupplierDiscountPercent.Name = "fld_txtAPReturnSupplierDiscountPercent";
            this.fld_txtAPReturnSupplierDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierDiscountPercent.Screen = null;
            this.fld_txtAPReturnSupplierDiscountPercent.Size = new System.Drawing.Size(56, 20);
            this.fld_txtAPReturnSupplierDiscountPercent.TabIndex = 419;
            this.fld_txtAPReturnSupplierDiscountPercent.Tag = "DC";
            // 
            // fld_txtAPReturnSupplierDiscountFix
            // 
            this.fld_txtAPReturnSupplierDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPReturnSupplierDiscountFix.BOSComment = "";
            this.fld_txtAPReturnSupplierDiscountFix.BOSDataMember = "APReturnSupplierDiscountFix";
            this.fld_txtAPReturnSupplierDiscountFix.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierDiscountFix.BOSDescription = null;
            this.fld_txtAPReturnSupplierDiscountFix.BOSError = null;
            this.fld_txtAPReturnSupplierDiscountFix.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierDiscountFix.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierDiscountFix.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtAPReturnSupplierDiscountFix.EditValue = "";
            this.fld_txtAPReturnSupplierDiscountFix.Location = new System.Drawing.Point(1044, 534);
            this.fld_txtAPReturnSupplierDiscountFix.Name = "fld_txtAPReturnSupplierDiscountFix";
            this.fld_txtAPReturnSupplierDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierDiscountFix.Screen = null;
            this.fld_txtAPReturnSupplierDiscountFix.Size = new System.Drawing.Size(82, 20);
            this.fld_txtAPReturnSupplierDiscountFix.TabIndex = 420;
            this.fld_txtAPReturnSupplierDiscountFix.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(507, 47);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(85, 13);
            this.fld_lblLabel26.TabIndex = 424;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày hóa đơn MH";
            // 
            // fld_dteARInvoiceDate
            // 
            this.fld_dteARInvoiceDate.BOSComment = "";
            this.fld_dteARInvoiceDate.BOSDataMember = "APInvoiceInVATDate";
            this.fld_dteARInvoiceDate.BOSDataSource = "APReturnSuppliers";
            this.fld_dteARInvoiceDate.BOSDescription = null;
            this.fld_dteARInvoiceDate.BOSError = null;
            this.fld_dteARInvoiceDate.BOSFieldGroup = "";
            this.fld_dteARInvoiceDate.BOSFieldRelation = "";
            this.fld_dteARInvoiceDate.BOSPrivilege = "";
            this.fld_dteARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDate.EditValue = null;
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(598, 44);
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Properties.ReadOnly = true;
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteARInvoiceDate.TabIndex = 423;
            this.fld_dteARInvoiceDate.Tag = "DC";
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
            this.bosLabel26.Location = new System.Drawing.Point(507, 21);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(72, 13);
            this.bosLabel26.TabIndex = 425;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Số hóa đơn MH";
            // 
            // fld_txtAPInvoiceInSupplierNo
            // 
            this.fld_txtAPInvoiceInSupplierNo.BOSComment = "";
            this.fld_txtAPInvoiceInSupplierNo.BOSDataMember = "APInvoiceInSupplierNo";
            this.fld_txtAPInvoiceInSupplierNo.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPInvoiceInSupplierNo.BOSDescription = null;
            this.fld_txtAPInvoiceInSupplierNo.BOSError = null;
            this.fld_txtAPInvoiceInSupplierNo.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInSupplierNo.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInSupplierNo.BOSPrivilege = "";
            this.fld_txtAPInvoiceInSupplierNo.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInSupplierNo.EditValue = "";
            this.fld_txtAPInvoiceInSupplierNo.Location = new System.Drawing.Point(598, 18);
            this.fld_txtAPInvoiceInSupplierNo.Name = "fld_txtAPInvoiceInSupplierNo";
            this.fld_txtAPInvoiceInSupplierNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInSupplierNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInSupplierNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInSupplierNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInSupplierNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInSupplierNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPInvoiceInSupplierNo.Properties.ReadOnly = true;
            this.fld_txtAPInvoiceInSupplierNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInSupplierNo.Screen = null;
            this.fld_txtAPInvoiceInSupplierNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtAPInvoiceInSupplierNo.TabIndex = 422;
            this.fld_txtAPInvoiceInSupplierNo.Tag = "DC";
            // 
            // DMRS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1138, 612);
            this.Controls.Add(this.bosLabel14);
            this.Controls.Add(this.fld_txtAPReturnSupplierDiscountPercent);
            this.Controls.Add(this.fld_txtAPReturnSupplierDiscountFix);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtAPReturnSupplierTaxPercent);
            this.Controls.Add(this.fld_txtAPReturnSupplierTaxAmount);
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.bosLine3);
            this.Controls.Add(this.fld_tabInvoiceInItems);
            this.Controls.Add(this.BOSLine1);
            this.Controls.Add(this.fld_pteAPReturnSupplierEmployeePicture);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lblLabel15);
            this.Controls.Add(this.fld_Lablel2);
            this.Controls.Add(this.fld_txtAPReturnSupplierSubTotalCost);
            this.Controls.Add(this.fld_txtAPReturnSupplierTotalCost);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMRS100.IconOptions.Icon")));
            this.Name = "DMRS100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierTotalCost, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierSubTotalCost, 0);
            this.Controls.SetChildIndex(this.fld_Lablel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel15, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_pteAPReturnSupplierEmployeePicture, 0);
            this.Controls.SetChildIndex(this.BOSLine1, 0);
            this.Controls.SetChildIndex(this.fld_tabInvoiceInItems, 0);
            this.Controls.SetChildIndex(this.bosLine3, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierTaxAmount, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierTaxPercent, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierDiscountFix, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierDiscountPercent, 0);
            this.Controls.SetChildIndex(this.bosLabel14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPReturnSupplierItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPReturnSupplierItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPReturnSupplierEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPReturnSupplierReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReturnSupplierDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReturnSupplierDate.Properties)).EndInit();
            this.BOSLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierStatusCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.fld_tabPageInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPReturnSupplierItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).EndInit();
            this.fld_tabInvoiceInItems.ResumeLayout(false);
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseContractID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierReceiptType.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPReturnSupplierReasonType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteReturnSupplierDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierNo;
        private BOSComponent.BOSLookupEdit fld_lkeAPReturnSupplierStatusCombo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICReceiptExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceInItems;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSPictureEdit fld_pteAPReturnSupplierItemProductPicture;
        private BOSComponent.BOSTabControl fld_tabInvoiceInItems;
        private BOSERP.Modules.ReturnSupplier.ACDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeAPInputVATDocumentType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATFormNo;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATInvoiceNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseContractID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeAPReturnSupplierReceiptType;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierTaxNumber;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierTaxPercent;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierTaxAmount;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierDiscountPercent;
        private BOSComponent.BOSTextBox fld_txtAPReturnSupplierDiscountFix;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeAPReturnSupplierReasonType;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDate;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInSupplierNo;
    }
}
