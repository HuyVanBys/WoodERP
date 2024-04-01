using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleReturn.UI
{
	/// <summary>
	/// Summary description for DMPS100
	/// </summary>
	partial class DMPS100
    {
		private BOSComponent.BOSLabel fld_lblLabel4;
        private ItemLookupEdit fld_lkeFK_ICProductID;
		private ARSaleReturnItemsGridControl fld_dgcARSaleReturnItems;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleReturnItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARSaleReturnEmployeePicture;
        private BOSComponent.BOSPictureEdit fld_pteARSaleReturnItemProductPicture;
        private BOSComponent.BOSLabel fld_lblLabel7;


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
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleReturnItems = new BOSERP.Modules.SaleReturn.ARSaleReturnItemsGridControl();
            this.fld_dgvARSaleReturnItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteARSaleReturnItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARSaleReturnEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleReturnDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleReturnNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARSaleReturnDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeARSaleReturnStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleReturnExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleReturnTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleReturnDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleReturnTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleReturnSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleReturnDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleReturnTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_txtARSaleReturnSerialNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleReturnGetPriceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARInvoiceProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAROutputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARInvoiceVATTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_recARSaleReturnNote = new BOSComponent.BOSRichEditControl(this.components);
            this.fld_tabSaleReturnItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageSaleReturnItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleReturnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleReturnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleReturnItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleReturnEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleReturnDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleReturnStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTaxPercent.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnGetPriceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnGetPriceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabSaleReturnItems)).BeginInit();
            this.fld_tabSaleReturnItems.SuspendLayout();
            this.fld_tabPageSaleReturnItems.SuspendLayout();
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(6, 13);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARSaleReturnItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = "";
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(59, 10);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "Barcode", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1150, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_dgcARSaleReturnItems
            // 
            this.fld_dgcARSaleReturnItems.AllowDrop = true;
            this.fld_dgcARSaleReturnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleReturnItems.BOSComment = "";
            this.fld_dgcARSaleReturnItems.BOSDataMember = null;
            this.fld_dgcARSaleReturnItems.BOSDataSource = "ARSaleReturnItems";
            this.fld_dgcARSaleReturnItems.BOSDescription = null;
            this.fld_dgcARSaleReturnItems.BOSError = "";
            this.fld_dgcARSaleReturnItems.BOSFieldGroup = "Accept";
            this.fld_dgcARSaleReturnItems.BOSFieldRelation = null;
            this.fld_dgcARSaleReturnItems.BOSGridType = null;
            this.fld_dgcARSaleReturnItems.BOSPrivilege = "";
            this.fld_dgcARSaleReturnItems.BOSPropertyName = null;
            this.fld_dgcARSaleReturnItems.CommodityType = "";
            this.fld_dgcARSaleReturnItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleReturnItems.ListInvoiceItemsInfo = null;
            this.fld_dgcARSaleReturnItems.Location = new System.Drawing.Point(3, 38);
            this.fld_dgcARSaleReturnItems.MainView = this.fld_dgvARSaleReturnItems;
            this.fld_dgcARSaleReturnItems.Name = "fld_dgcARSaleReturnItems";
            this.fld_dgcARSaleReturnItems.PrintReport = false;
            this.fld_dgcARSaleReturnItems.Screen = null;
            this.fld_dgcARSaleReturnItems.Size = new System.Drawing.Size(1206, 443);
            this.fld_dgcARSaleReturnItems.TabIndex = 20;
            this.fld_dgcARSaleReturnItems.Tag = "DC";
            this.fld_dgcARSaleReturnItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleReturnItems});
            // 
            // fld_dgvARSaleReturnItems
            // 
            this.fld_dgvARSaleReturnItems.GridControl = this.fld_dgcARSaleReturnItems;
            this.fld_dgvARSaleReturnItems.Name = "fld_dgvARSaleReturnItems";
            this.fld_dgvARSaleReturnItems.PaintStyleName = "Office2003";
            // 
            // fld_pteARSaleReturnItemProductPicture
            // 
            this.fld_pteARSaleReturnItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARSaleReturnItemProductPicture.BOSComment = "";
            this.fld_pteARSaleReturnItemProductPicture.BOSDataMember = "ARSaleReturnItemProductPicture";
            this.fld_pteARSaleReturnItemProductPicture.BOSDataSource = "ARSaleReturnItems";
            this.fld_pteARSaleReturnItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleReturnItemProductPicture.BOSError = "";
            this.fld_pteARSaleReturnItemProductPicture.BOSFieldGroup = "";
            this.fld_pteARSaleReturnItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleReturnItemProductPicture.BOSPrivilege = "";
            this.fld_pteARSaleReturnItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleReturnItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleReturnItemProductPicture.FileName = null;
            this.fld_pteARSaleReturnItemProductPicture.FilePath = null;
            this.fld_pteARSaleReturnItemProductPicture.Location = new System.Drawing.Point(1215, 3);
            this.fld_pteARSaleReturnItemProductPicture.Name = "fld_pteARSaleReturnItemProductPicture";
            this.fld_pteARSaleReturnItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleReturnItemProductPicture.Screen = null;
            this.fld_pteARSaleReturnItemProductPicture.Size = new System.Drawing.Size(123, 135);
            this.fld_pteARSaleReturnItemProductPicture.TabIndex = 2;
            this.fld_pteARSaleReturnItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
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
            // fld_pteARSaleReturnEmployeePicture
            // 
            this.fld_pteARSaleReturnEmployeePicture.BOSComment = "";
            this.fld_pteARSaleReturnEmployeePicture.BOSDataMember = "ARSaleReturnEmployeePicture";
            this.fld_pteARSaleReturnEmployeePicture.BOSDataSource = "ARSaleReturns";
            this.fld_pteARSaleReturnEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleReturnEmployeePicture.BOSError = "";
            this.fld_pteARSaleReturnEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARSaleReturnEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleReturnEmployeePicture.BOSPrivilege = "";
            this.fld_pteARSaleReturnEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleReturnEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleReturnEmployeePicture.FileName = null;
            this.fld_pteARSaleReturnEmployeePicture.FilePath = null;
            this.fld_pteARSaleReturnEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARSaleReturnEmployeePicture.Name = "fld_pteARSaleReturnEmployeePicture";
            this.fld_pteARSaleReturnEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleReturnEmployeePicture.Screen = null;
            this.fld_pteARSaleReturnEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARSaleReturnEmployeePicture.TabIndex = 0;
            this.fld_pteARSaleReturnEmployeePicture.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(574, 52);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel7.TabIndex = 12;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Tình trạng";
            // 
            // fld_dteARSaleReturnDate
            // 
            this.fld_dteARSaleReturnDate.BOSComment = null;
            this.fld_dteARSaleReturnDate.BOSDataMember = "ARSaleReturnDate";
            this.fld_dteARSaleReturnDate.BOSDataSource = "ARSaleReturns";
            this.fld_dteARSaleReturnDate.BOSDescription = null;
            this.fld_dteARSaleReturnDate.BOSError = null;
            this.fld_dteARSaleReturnDate.BOSFieldGroup = null;
            this.fld_dteARSaleReturnDate.BOSFieldRelation = null;
            this.fld_dteARSaleReturnDate.BOSPrivilege = null;
            this.fld_dteARSaleReturnDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleReturnDate.EditValue = null;
            this.fld_dteARSaleReturnDate.Location = new System.Drawing.Point(386, 23);
            this.fld_dteARSaleReturnDate.MenuManager = this.screenToolbar;
            this.fld_dteARSaleReturnDate.Name = "fld_dteARSaleReturnDate";
            this.fld_dteARSaleReturnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleReturnDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleReturnDate.Screen = null;
            this.fld_dteARSaleReturnDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleReturnDate.TabIndex = 1;
            this.fld_dteARSaleReturnDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(295, 27);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(23, 26);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARSaleReturnNo1
            // 
            this.fld_txtARSaleReturnNo1.BOSComment = null;
            this.fld_txtARSaleReturnNo1.BOSDataMember = "ARSaleReturnNo";
            this.fld_txtARSaleReturnNo1.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnNo1.BOSDescription = null;
            this.fld_txtARSaleReturnNo1.BOSError = null;
            this.fld_txtARSaleReturnNo1.BOSFieldGroup = null;
            this.fld_txtARSaleReturnNo1.BOSFieldRelation = null;
            this.fld_txtARSaleReturnNo1.BOSPrivilege = null;
            this.fld_txtARSaleReturnNo1.BOSPropertyName = "EditValue";
            this.fld_txtARSaleReturnNo1.Location = new System.Drawing.Point(105, 23);
            this.fld_txtARSaleReturnNo1.MenuManager = this.screenToolbar;
            this.fld_txtARSaleReturnNo1.Name = "fld_txtARSaleReturnNo1";
            this.fld_txtARSaleReturnNo1.Screen = null;
            this.fld_txtARSaleReturnNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleReturnNo1.TabIndex = 0;
            this.fld_txtARSaleReturnNo1.Tag = "DC";
            // 
            // fld_medARSaleReturnDesc
            // 
            this.fld_medARSaleReturnDesc.BOSComment = null;
            this.fld_medARSaleReturnDesc.BOSDataMember = "ARSaleReturnDesc";
            this.fld_medARSaleReturnDesc.BOSDataSource = "ARSaleReturns";
            this.fld_medARSaleReturnDesc.BOSDescription = null;
            this.fld_medARSaleReturnDesc.BOSError = null;
            this.fld_medARSaleReturnDesc.BOSFieldGroup = null;
            this.fld_medARSaleReturnDesc.BOSFieldRelation = null;
            this.fld_medARSaleReturnDesc.BOSPrivilege = null;
            this.fld_medARSaleReturnDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleReturnDesc.Location = new System.Drawing.Point(105, 153);
            this.fld_medARSaleReturnDesc.MenuManager = this.screenToolbar;
            this.fld_medARSaleReturnDesc.Name = "fld_medARSaleReturnDesc";
            this.fld_medARSaleReturnDesc.Screen = null;
            this.fld_medARSaleReturnDesc.Size = new System.Drawing.Size(431, 46);
            this.fld_medARSaleReturnDesc.TabIndex = 14;
            this.fld_medARSaleReturnDesc.Tag = "DC";
            // 
            // fld_lkeARSaleReturnStatus
            // 
            this.fld_lkeARSaleReturnStatus.BOSAllowAddNew = false;
            this.fld_lkeARSaleReturnStatus.BOSAllowDummy = false;
            this.fld_lkeARSaleReturnStatus.BOSComment = null;
            this.fld_lkeARSaleReturnStatus.BOSDataMember = "ARSaleReturnStatus";
            this.fld_lkeARSaleReturnStatus.BOSDataSource = "ARSaleReturns";
            this.fld_lkeARSaleReturnStatus.BOSDescription = null;
            this.fld_lkeARSaleReturnStatus.BOSError = null;
            this.fld_lkeARSaleReturnStatus.BOSFieldGroup = null;
            this.fld_lkeARSaleReturnStatus.BOSFieldParent = null;
            this.fld_lkeARSaleReturnStatus.BOSFieldRelation = null;
            this.fld_lkeARSaleReturnStatus.BOSPrivilege = null;
            this.fld_lkeARSaleReturnStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleReturnStatus.BOSSelectType = null;
            this.fld_lkeARSaleReturnStatus.BOSSelectTypeValue = null;
            this.fld_lkeARSaleReturnStatus.CurrentDisplayText = null;
            this.fld_lkeARSaleReturnStatus.Location = new System.Drawing.Point(672, 49);
            this.fld_lkeARSaleReturnStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARSaleReturnStatus.Name = "fld_lkeARSaleReturnStatus";
            this.fld_lkeARSaleReturnStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleReturnStatus.Properties.ColumnName = null;
            this.fld_lkeARSaleReturnStatus.Properties.NullText = "";
            this.fld_lkeARSaleReturnStatus.Properties.ReadOnly = true;
            this.fld_lkeARSaleReturnStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleReturnStatus.Screen = null;
            this.fld_lkeARSaleReturnStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleReturnStatus.TabIndex = 5;
            this.fld_lkeARSaleReturnStatus.Tag = "DC";
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
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(574, 78);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(56, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Mã hóa đơn";
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
            this.bosLabel4.Location = new System.Drawing.Point(23, 52);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Đối tượng";
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
            this.bosLabel5.Location = new System.Drawing.Point(295, 52);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(53, 13);
            this.bosLabel5.TabIndex = 8;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại tiền tệ";
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
            this.bosLabel6.Location = new System.Drawing.Point(295, 78);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 10;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tỷ giá";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(386, 49);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtARSaleReturnExchangeRate
            // 
            this.fld_txtARSaleReturnExchangeRate.BOSComment = null;
            this.fld_txtARSaleReturnExchangeRate.BOSDataMember = "ARSaleReturnExchangeRate";
            this.fld_txtARSaleReturnExchangeRate.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnExchangeRate.BOSDescription = null;
            this.fld_txtARSaleReturnExchangeRate.BOSError = null;
            this.fld_txtARSaleReturnExchangeRate.BOSFieldGroup = null;
            this.fld_txtARSaleReturnExchangeRate.BOSFieldRelation = null;
            this.fld_txtARSaleReturnExchangeRate.BOSPrivilege = null;
            this.fld_txtARSaleReturnExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARSaleReturnExchangeRate.Location = new System.Drawing.Point(386, 75);
            this.fld_txtARSaleReturnExchangeRate.Name = "fld_txtARSaleReturnExchangeRate";
            this.fld_txtARSaleReturnExchangeRate.Screen = null;
            this.fld_txtARSaleReturnExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleReturnExchangeRate.TabIndex = 7;
            this.fld_txtARSaleReturnExchangeRate.Tag = "DC";
            // 
            // fld_txtARInvoiceNo
            // 
            this.fld_txtARInvoiceNo.BOSComment = null;
            this.fld_txtARInvoiceNo.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo.BOSDataSource = "ARSaleReturns";
            this.fld_txtARInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceNo.BOSFieldGroup = null;
            this.fld_txtARInvoiceNo.BOSFieldRelation = null;
            this.fld_txtARInvoiceNo.BOSPrivilege = null;
            this.fld_txtARInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceNo.Location = new System.Drawing.Point(672, 75);
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Properties.ReadOnly = true;
            this.fld_txtARInvoiceNo.Screen = null;
            this.fld_txtARInvoiceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARInvoiceNo.TabIndex = 8;
            this.fld_txtARInvoiceNo.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(574, 104);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(88, 13);
            this.bosLabel8.TabIndex = 16;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Ngày hóa đơn bán";
            // 
            // fld_dteARInvoiceDate
            // 
            this.fld_dteARInvoiceDate.BOSComment = null;
            this.fld_dteARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteARInvoiceDate.BOSDataSource = "ARSaleReturns";
            this.fld_dteARInvoiceDate.BOSDescription = null;
            this.fld_dteARInvoiceDate.BOSError = null;
            this.fld_dteARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteARInvoiceDate.BOSPrivilege = null;
            this.fld_dteARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDate.EditValue = null;
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(672, 101);
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Properties.ReadOnly = true;
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARInvoiceDate.TabIndex = 11;
            this.fld_dteARInvoiceDate.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_tabSaleReturnItems);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleReturnEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1358, 870);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_lblLabel19);
            this.bosLine4.Controls.Add(this.fld_lblLabel15);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnTotalAmount);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnDiscountFix);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnTaxAmount);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnSubTotalAmount);
            this.bosLine4.Controls.Add(this.fld_lblLabel14);
            this.bosLine4.Controls.Add(this.bosLabel7);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnDiscountPerCent);
            this.bosLine4.Controls.Add(this.fld_txtARSaleReturnTaxPercent);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(1025, 734);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(314, 121);
            this.bosLine4.TabIndex = 416;
            this.bosLine4.TabStop = false;
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
            this.fld_lblLabel19.Location = new System.Drawing.Point(15, 94);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(74, 17);
            this.fld_lblLabel19.TabIndex = 425;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Thành tiền";
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(32, 18);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel15.TabIndex = 424;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tổng cộng";
            // 
            // fld_txtARSaleReturnTotalAmount
            // 
            this.fld_txtARSaleReturnTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnTotalAmount.BOSComment = "";
            this.fld_txtARSaleReturnTotalAmount.BOSDataMember = "ARSaleReturnTotalAmount";
            this.fld_txtARSaleReturnTotalAmount.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnTotalAmount.BOSDescription = null;
            this.fld_txtARSaleReturnTotalAmount.BOSError = "";
            this.fld_txtARSaleReturnTotalAmount.BOSFieldGroup = "";
            this.fld_txtARSaleReturnTotalAmount.BOSFieldRelation = "";
            this.fld_txtARSaleReturnTotalAmount.BOSPrivilege = "";
            this.fld_txtARSaleReturnTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnTotalAmount.Location = new System.Drawing.Point(111, 93);
            this.fld_txtARSaleReturnTotalAmount.Name = "fld_txtARSaleReturnTotalAmount";
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARSaleReturnTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleReturnTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnTotalAmount.Screen = null;
            this.fld_txtARSaleReturnTotalAmount.Size = new System.Drawing.Size(189, 20);
            this.fld_txtARSaleReturnTotalAmount.TabIndex = 421;
            this.fld_txtARSaleReturnTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleReturnDiscountFix
            // 
            this.fld_txtARSaleReturnDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnDiscountFix.BOSComment = "";
            this.fld_txtARSaleReturnDiscountFix.BOSDataMember = "ARSaleReturnDiscountFix";
            this.fld_txtARSaleReturnDiscountFix.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnDiscountFix.BOSDescription = null;
            this.fld_txtARSaleReturnDiscountFix.BOSError = "";
            this.fld_txtARSaleReturnDiscountFix.BOSFieldGroup = "Accept";
            this.fld_txtARSaleReturnDiscountFix.BOSFieldRelation = "";
            this.fld_txtARSaleReturnDiscountFix.BOSPrivilege = "";
            this.fld_txtARSaleReturnDiscountFix.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnDiscountFix.Location = new System.Drawing.Point(180, 40);
            this.fld_txtARSaleReturnDiscountFix.Name = "fld_txtARSaleReturnDiscountFix";
            this.fld_txtARSaleReturnDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleReturnDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnDiscountFix.Screen = null;
            this.fld_txtARSaleReturnDiscountFix.Size = new System.Drawing.Size(120, 20);
            this.fld_txtARSaleReturnDiscountFix.TabIndex = 418;
            this.fld_txtARSaleReturnDiscountFix.Tag = "DC";
            // 
            // fld_txtARSaleReturnTaxAmount
            // 
            this.fld_txtARSaleReturnTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnTaxAmount.BOSComment = "";
            this.fld_txtARSaleReturnTaxAmount.BOSDataMember = "ARSaleReturnTaxAmount";
            this.fld_txtARSaleReturnTaxAmount.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnTaxAmount.BOSDescription = null;
            this.fld_txtARSaleReturnTaxAmount.BOSError = "";
            this.fld_txtARSaleReturnTaxAmount.BOSFieldGroup = "Accept";
            this.fld_txtARSaleReturnTaxAmount.BOSFieldRelation = "";
            this.fld_txtARSaleReturnTaxAmount.BOSPrivilege = "";
            this.fld_txtARSaleReturnTaxAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnTaxAmount.Location = new System.Drawing.Point(180, 66);
            this.fld_txtARSaleReturnTaxAmount.Name = "fld_txtARSaleReturnTaxAmount";
            this.fld_txtARSaleReturnTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleReturnTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnTaxAmount.Screen = null;
            this.fld_txtARSaleReturnTaxAmount.Size = new System.Drawing.Size(120, 20);
            this.fld_txtARSaleReturnTaxAmount.TabIndex = 420;
            this.fld_txtARSaleReturnTaxAmount.Tag = "DC";
            // 
            // fld_txtARSaleReturnSubTotalAmount
            // 
            this.fld_txtARSaleReturnSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnSubTotalAmount.BOSComment = "";
            this.fld_txtARSaleReturnSubTotalAmount.BOSDataMember = "ARSaleReturnSubTotalAmount";
            this.fld_txtARSaleReturnSubTotalAmount.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnSubTotalAmount.BOSDescription = null;
            this.fld_txtARSaleReturnSubTotalAmount.BOSError = "";
            this.fld_txtARSaleReturnSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARSaleReturnSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARSaleReturnSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARSaleReturnSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnSubTotalAmount.Location = new System.Drawing.Point(111, 15);
            this.fld_txtARSaleReturnSubTotalAmount.Name = "fld_txtARSaleReturnSubTotalAmount";
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleReturnSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnSubTotalAmount.Screen = null;
            this.fld_txtARSaleReturnSubTotalAmount.Size = new System.Drawing.Size(189, 20);
            this.fld_txtARSaleReturnSubTotalAmount.TabIndex = 416;
            this.fld_txtARSaleReturnSubTotalAmount.Tag = "DC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(32, 43);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel14.TabIndex = 422;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Chiết khấu";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel7.Location = new System.Drawing.Point(58, 69);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(24, 13);
            this.bosLabel7.TabIndex = 423;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Thuế";
            // 
            // fld_txtARSaleReturnDiscountPerCent
            // 
            this.fld_txtARSaleReturnDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnDiscountPerCent.BOSComment = "";
            this.fld_txtARSaleReturnDiscountPerCent.BOSDataMember = "ARSaleReturnDiscountPerCent";
            this.fld_txtARSaleReturnDiscountPerCent.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnDiscountPerCent.BOSDescription = null;
            this.fld_txtARSaleReturnDiscountPerCent.BOSError = "";
            this.fld_txtARSaleReturnDiscountPerCent.BOSFieldGroup = "Accept";
            this.fld_txtARSaleReturnDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARSaleReturnDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARSaleReturnDiscountPerCent.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnDiscountPerCent.Location = new System.Drawing.Point(111, 40);
            this.fld_txtARSaleReturnDiscountPerCent.Name = "fld_txtARSaleReturnDiscountPerCent";
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnDiscountPerCent.Screen = null;
            this.fld_txtARSaleReturnDiscountPerCent.Size = new System.Drawing.Size(63, 20);
            this.fld_txtARSaleReturnDiscountPerCent.TabIndex = 417;
            this.fld_txtARSaleReturnDiscountPerCent.Tag = "DC";
            this.fld_txtARSaleReturnDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARSaleReturnDiscountPerCent_Validated_1);
            // 
            // fld_txtARSaleReturnTaxPercent
            // 
            this.fld_txtARSaleReturnTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARSaleReturnTaxPercent.BOSComment = "";
            this.fld_txtARSaleReturnTaxPercent.BOSDataMember = "ARSaleReturnTaxPercent";
            this.fld_txtARSaleReturnTaxPercent.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnTaxPercent.BOSDescription = null;
            this.fld_txtARSaleReturnTaxPercent.BOSError = "";
            this.fld_txtARSaleReturnTaxPercent.BOSFieldGroup = "";
            this.fld_txtARSaleReturnTaxPercent.BOSFieldRelation = "";
            this.fld_txtARSaleReturnTaxPercent.BOSPrivilege = "";
            this.fld_txtARSaleReturnTaxPercent.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnTaxPercent.Location = new System.Drawing.Point(111, 66);
            this.fld_txtARSaleReturnTaxPercent.Name = "fld_txtARSaleReturnTaxPercent";
            this.fld_txtARSaleReturnTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleReturnTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleReturnTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleReturnTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnTaxPercent.Screen = null;
            this.fld_txtARSaleReturnTaxPercent.Size = new System.Drawing.Size(63, 20);
            this.fld_txtARSaleReturnTaxPercent.TabIndex = 419;
            this.fld_txtARSaleReturnTaxPercent.Tag = "DC";
            this.fld_txtARSaleReturnTaxPercent.Validated += new System.EventHandler(this.fld_txtARSaleReturnTaxPercent_Validated_1);
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
            this.bosLine2.Controls.Add(this.fld_txtARSaleReturnSerialNo);
            this.bosLine2.Controls.Add(this.bosLabel20);
            this.bosLine2.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosLine2.Controls.Add(this.fld_Lablel3);
            this.bosLine2.Controls.Add(this.fld_dteARSaleReturnGetPriceDate);
            this.bosLine2.Controls.Add(this.bosLabel19);
            this.bosLine2.Controls.Add(this.bosLabel16);
            this.bosLine2.Controls.Add(this.bosTextBox6);
            this.bosLine2.Controls.Add(this.bosTextBox2);
            this.bosLine2.Controls.Add(this.bosTextBox5);
            this.bosLine2.Controls.Add(this.bosLabel24);
            this.bosLine2.Controls.Add(this.bosLabel12);
            this.bosLine2.Controls.Add(this.fld_lkeARSaleReturnStatus);
            this.bosLine2.Controls.Add(this.bosLabel5);
            this.bosLine2.Controls.Add(this.bosTextBox1);
            this.bosLine2.Controls.Add(this.bosLabel6);
            this.bosLine2.Controls.Add(this.bosLabel4);
            this.bosLine2.Controls.Add(this.bosLabel11);
            this.bosLine2.Controls.Add(this.bosLabel8);
            this.bosLine2.Controls.Add(this.bosLabel2);
            this.bosLine2.Controls.Add(this.bosLabel17);
            this.bosLine2.Controls.Add(this.bosLabel3);
            this.bosLine2.Controls.Add(this.fld_lkeARInvoiceProductType);
            this.bosLine2.Controls.Add(this.fld_dteARSaleReturnDate);
            this.bosLine2.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine2.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosLine2.Controls.Add(this.fld_lblLabel7);
            this.bosLine2.Controls.Add(this.fld_medARSaleReturnDesc);
            this.bosLine2.Controls.Add(this.bosLabel9);
            this.bosLine2.Controls.Add(this.fld_txtARSaleReturnNo1);
            this.bosLine2.Controls.Add(this.fld_txtARSaleReturnExchangeRate);
            this.bosLine2.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine2.Controls.Add(this.BOSLabel1);
            this.bosLine2.Controls.Add(this.fld_txtARInvoiceNo);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(110, 4);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(828, 209);
            this.bosLine2.TabIndex = 2;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Thông tin chung";
            // 
            // fld_txtARSaleReturnSerialNo
            // 
            this.fld_txtARSaleReturnSerialNo.BOSComment = null;
            this.fld_txtARSaleReturnSerialNo.BOSDataMember = "ARSaleReturnSerialNo";
            this.fld_txtARSaleReturnSerialNo.BOSDataSource = "ARSaleReturns";
            this.fld_txtARSaleReturnSerialNo.BOSDescription = null;
            this.fld_txtARSaleReturnSerialNo.BOSError = null;
            this.fld_txtARSaleReturnSerialNo.BOSFieldGroup = null;
            this.fld_txtARSaleReturnSerialNo.BOSFieldRelation = null;
            this.fld_txtARSaleReturnSerialNo.BOSPrivilege = null;
            this.fld_txtARSaleReturnSerialNo.BOSPropertyName = "Text";
            this.fld_txtARSaleReturnSerialNo.Location = new System.Drawing.Point(672, 179);
            this.fld_txtARSaleReturnSerialNo.Name = "fld_txtARSaleReturnSerialNo";
            this.fld_txtARSaleReturnSerialNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleReturnSerialNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleReturnSerialNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleReturnSerialNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleReturnSerialNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleReturnSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleReturnSerialNo.Screen = null;
            this.fld_txtARSaleReturnSerialNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleReturnSerialNo.TabIndex = 16;
            this.fld_txtARSaleReturnSerialNo.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel20.Location = new System.Drawing.Point(574, 181);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(52, 13);
            this.bosLabel20.TabIndex = 850;
            this.bosLabel20.Text = "Mã lô hàng";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(672, 153);
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
            this.fld_lkeFK_ICStockID1.TabIndex = 15;
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
            this.fld_Lablel3.Location = new System.Drawing.Point(574, 156);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 848;
            this.fld_Lablel3.Text = "Kho";
            // 
            // fld_dteARSaleReturnGetPriceDate
            // 
            this.fld_dteARSaleReturnGetPriceDate.BOSComment = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSDataMember = "ARSaleReturnGetPriceDate";
            this.fld_dteARSaleReturnGetPriceDate.BOSDataSource = "ARSaleReturns";
            this.fld_dteARSaleReturnGetPriceDate.BOSDescription = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSError = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSFieldGroup = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSFieldRelation = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSPrivilege = null;
            this.fld_dteARSaleReturnGetPriceDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleReturnGetPriceDate.EditValue = null;
            this.fld_dteARSaleReturnGetPriceDate.Location = new System.Drawing.Point(672, 23);
            this.fld_dteARSaleReturnGetPriceDate.MenuManager = this.screenToolbar;
            this.fld_dteARSaleReturnGetPriceDate.Name = "fld_dteARSaleReturnGetPriceDate";
            this.fld_dteARSaleReturnGetPriceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleReturnGetPriceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleReturnGetPriceDate.Screen = null;
            this.fld_dteARSaleReturnGetPriceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARSaleReturnGetPriceDate.TabIndex = 2;
            this.fld_dteARSaleReturnGetPriceDate.Tag = "DC";
            this.fld_dteARSaleReturnGetPriceDate.Validated += new System.EventHandler(this.fld_dteARSaleReturnGetPriceDate_Validated);
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
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(574, 27);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(59, 13);
            this.bosLabel19.TabIndex = 846;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Ngày lấy giá";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(574, 130);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(75, 13);
            this.bosLabel16.TabIndex = 426;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Số hóa đơn bán";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARSaleReturnSaleContract";
            this.bosTextBox6.BOSDataSource = "ARSaleReturns";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(105, 101);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox6.TabIndex = 9;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ARSaleReturnInvoiceVATNo";
            this.bosTextBox2.BOSDataSource = "ARSaleReturns";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(672, 127);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 13;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARSaleReturnProject";
            this.bosTextBox5.BOSDataSource = "ARSaleReturns";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(386, 101);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox5, true);
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 10;
            this.bosTextBox5.Tag = "DC";
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
            this.bosLabel24.BOSPropertyName = "";
            this.bosLabel24.Location = new System.Drawing.Point(295, 104);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(45, 13);
            this.bosLabel24.TabIndex = 616;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Mã dự án";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(23, 104);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(60, 13);
            this.bosLabel12.TabIndex = 615;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Số hợp đồng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ACObjectContactAddressLine3";
            this.bosTextBox1.BOSDataSource = "ARSaleReturns";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(105, 127);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n";
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(431, 20);
            this.bosTextBox1.TabIndex = 12;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(23, 130);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(32, 13);
            this.bosLabel11.TabIndex = 425;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Địa chỉ";
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
            this.bosLabel17.Location = new System.Drawing.Point(23, 78);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 417;
            this.bosLabel17.Text = "Loại hàng hóa";
            // 
            // fld_lkeARInvoiceProductType
            // 
            this.fld_lkeARInvoiceProductType.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceProductType.BOSAllowDummy = false;
            this.fld_lkeARInvoiceProductType.BOSComment = null;
            this.fld_lkeARInvoiceProductType.BOSDataMember = "ARSaleReturnProductType";
            this.fld_lkeARInvoiceProductType.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeARInvoiceProductType.Location = new System.Drawing.Point(105, 75);
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
            this.fld_lkeARInvoiceProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceProductType.TabIndex = 6;
            this.fld_lkeARInvoiceProductType.Tag = "DC";
            this.fld_lkeARInvoiceProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeARInvoiceProductType_CloseUp);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(105, 49);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
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
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(23, 156);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(40, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Diễn giải";
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
            this.bosLine3.Controls.Add(this.bosLabel13);
            this.bosLine3.Controls.Add(this.bosLabel25);
            this.bosLine3.Controls.Add(this.bosLabel26);
            this.bosLine3.Controls.Add(this.bosDateEdit1);
            this.bosLine3.Controls.Add(this.bosLabel14);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATSymbol);
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.bosLabel10);
            this.bosLine3.Controls.Add(this.fld_lkeAROutputVATDocumentType);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATTaxNumber);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATInvoiceNo);
            this.bosLine3.Controls.Add(this.bosLabel15);
            this.bosLine3.Controls.Add(this.bosTextBox4);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(944, 4);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(249, 209);
            this.bosLine3.TabIndex = 3;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin VAT";
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(105, 153);
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
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 5;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEInvoiceTypeID_CloseUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(14, 156);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(85, 13);
            this.bosLabel13.TabIndex = 93;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Mã hóa đơn GTGT";
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
            this.bosLabel25.Location = new System.Drawing.Point(14, 76);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(35, 13);
            this.bosLabel25.TabIndex = 92;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Ký hiệu";
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
            this.bosLabel26.Location = new System.Drawing.Point(14, 104);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(54, 13);
            this.bosLabel26.TabIndex = 91;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Số hóa đơn";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ARSaleReturnTransferredDate";
            this.bosDateEdit1.BOSDataSource = "ARSaleReturns";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(105, 179);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(136, 20);
            this.bosDateEdit1.TabIndex = 8;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(14, 30);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(61, 13);
            this.bosLabel14.TabIndex = 79;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Loại hóa đơn";
            // 
            // fld_txtARInvoiceVATSymbol
            // 
            this.fld_txtARInvoiceVATSymbol.BOSComment = "";
            this.fld_txtARInvoiceVATSymbol.BOSDataMember = "ARSaleReturnVATSymbol";
            this.fld_txtARInvoiceVATSymbol.BOSDataSource = "ARSaleReturns";
            this.fld_txtARInvoiceVATSymbol.BOSDescription = null;
            this.fld_txtARInvoiceVATSymbol.BOSError = null;
            this.fld_txtARInvoiceVATSymbol.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATSymbol.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATSymbol.BOSPrivilege = "";
            this.fld_txtARInvoiceVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATSymbol.EditValue = "";
            this.fld_txtARInvoiceVATSymbol.Location = new System.Drawing.Point(105, 75);
            this.fld_txtARInvoiceVATSymbol.Name = "fld_txtARInvoiceVATSymbol";
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATSymbol.Screen = null;
            this.fld_txtARInvoiceVATSymbol.Size = new System.Drawing.Size(136, 20);
            this.fld_txtARInvoiceVATSymbol.TabIndex = 2;
            this.fld_txtARInvoiceVATSymbol.Tag = "DC";
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
            this.bosLabel18.Location = new System.Drawing.Point(14, 130);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(20, 13);
            this.bosLabel18.TabIndex = 422;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "MST";
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
            this.bosLabel10.Location = new System.Drawing.Point(14, 181);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(67, 13);
            this.bosLabel10.TabIndex = 424;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Ngày hóa đơn";
            // 
            // fld_lkeAROutputVATDocumentType
            // 
            this.fld_lkeAROutputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeAROutputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeAROutputVATDocumentType.BOSComment = "";
            this.fld_lkeAROutputVATDocumentType.BOSDataMember = "AROutputVATDocumentType";
            this.fld_lkeAROutputVATDocumentType.BOSDataSource = "ARSaleReturns";
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
            this.fld_lkeAROutputVATDocumentType.Location = new System.Drawing.Point(105, 23);
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
            this.fld_lkeAROutputVATDocumentType.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeAROutputVATDocumentType.TabIndex = 0;
            this.fld_lkeAROutputVATDocumentType.Tag = "DC";
            this.fld_lkeAROutputVATDocumentType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAROutputVATDocumentType_CloseUp);
            // 
            // fld_txtARInvoiceVATTaxNumber
            // 
            this.fld_txtARInvoiceVATTaxNumber.BOSComment = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSDataMember = "ARSaleReturnTaxNumber";
            this.fld_txtARInvoiceVATTaxNumber.BOSDataSource = "ARSaleReturns";
            this.fld_txtARInvoiceVATTaxNumber.BOSDescription = null;
            this.fld_txtARInvoiceVATTaxNumber.BOSError = null;
            this.fld_txtARInvoiceVATTaxNumber.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSPrivilege = "";
            this.fld_txtARInvoiceVATTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATTaxNumber.EditValue = "";
            this.fld_txtARInvoiceVATTaxNumber.Location = new System.Drawing.Point(105, 127);
            this.fld_txtARInvoiceVATTaxNumber.Name = "fld_txtARInvoiceVATTaxNumber";
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATTaxNumber.Screen = null;
            this.fld_txtARInvoiceVATTaxNumber.Size = new System.Drawing.Size(136, 20);
            this.fld_txtARInvoiceVATTaxNumber.TabIndex = 4;
            this.fld_txtARInvoiceVATTaxNumber.Tag = "DC";
            // 
            // fld_txtARInvoiceVATInvoiceNo
            // 
            this.fld_txtARInvoiceVATInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataMember = "ARSaleReturnVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataSource = "ARSaleReturns";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATInvoiceNo.EditValue = "";
            this.fld_txtARInvoiceVATInvoiceNo.Location = new System.Drawing.Point(105, 101);
            this.fld_txtARInvoiceVATInvoiceNo.Name = "fld_txtARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATInvoiceNo.Screen = null;
            this.fld_txtARInvoiceVATInvoiceNo.Size = new System.Drawing.Size(136, 20);
            this.fld_txtARInvoiceVATInvoiceNo.TabIndex = 3;
            this.fld_txtARInvoiceVATInvoiceNo.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(14, 52);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(34, 13);
            this.bosLabel15.TabIndex = 80;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Mẫu số";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "ARSaleReturnVATFormNo";
            this.bosTextBox4.BOSDataSource = "ARSaleReturns";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.EditValue = "";
            this.bosTextBox4.Location = new System.Drawing.Point(105, 49);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.EditMask = "n";
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(136, 20);
            this.bosTextBox4.TabIndex = 1;
            this.bosTextBox4.Tag = "DC";
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
            this.bosLine1.Controls.Add(this.fld_recARSaleReturnNote);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(5, 734);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(767, 124);
            this.bosLine1.TabIndex = 5;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_recARSaleReturnNote
            // 
            this.fld_recARSaleReturnNote.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARSaleReturnNote.BOSComment = null;
            this.fld_recARSaleReturnNote.BOSDataMember = null;
            this.fld_recARSaleReturnNote.BOSDataSource = null;
            this.fld_recARSaleReturnNote.BOSDescription = null;
            this.fld_recARSaleReturnNote.BOSError = null;
            this.fld_recARSaleReturnNote.BOSFieldGroup = null;
            this.fld_recARSaleReturnNote.BOSFieldRelation = null;
            this.fld_recARSaleReturnNote.BOSPrivilege = null;
            this.fld_recARSaleReturnNote.BOSPropertyName = null;
            this.fld_recARSaleReturnNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_recARSaleReturnNote.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARSaleReturnNote.Location = new System.Drawing.Point(3, 17);
            this.fld_recARSaleReturnNote.MenuManager = this.screenToolbar;
            this.fld_recARSaleReturnNote.Name = "fld_recARSaleReturnNote";
            this.fld_recARSaleReturnNote.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleReturnNote.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARSaleReturnNote.Screen = null;
            this.fld_recARSaleReturnNote.Size = new System.Drawing.Size(761, 104);
            this.fld_recARSaleReturnNote.TabIndex = 2;
            this.fld_recARSaleReturnNote.Tag = "DC";
            // 
            // fld_tabSaleReturnItems
            // 
            this.fld_tabSaleReturnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabSaleReturnItems.BOSComment = null;
            this.fld_tabSaleReturnItems.BOSDataMember = null;
            this.fld_tabSaleReturnItems.BOSDataSource = null;
            this.fld_tabSaleReturnItems.BOSDescription = null;
            this.fld_tabSaleReturnItems.BOSError = null;
            this.fld_tabSaleReturnItems.BOSFieldGroup = null;
            this.fld_tabSaleReturnItems.BOSFieldRelation = null;
            this.fld_tabSaleReturnItems.BOSPrivilege = null;
            this.fld_tabSaleReturnItems.BOSPropertyName = null;
            this.fld_tabSaleReturnItems.Location = new System.Drawing.Point(4, 219);
            this.fld_tabSaleReturnItems.Name = "fld_tabSaleReturnItems";
            this.fld_tabSaleReturnItems.Screen = null;
            this.fld_tabSaleReturnItems.SelectedTabPage = this.fld_tabPageSaleReturnItems;
            this.fld_tabSaleReturnItems.Size = new System.Drawing.Size(1343, 509);
            this.fld_tabSaleReturnItems.TabIndex = 4;
            this.fld_tabSaleReturnItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageSaleReturnItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageSaleReturnItems
            // 
            this.fld_tabPageSaleReturnItems.AutoScroll = true;
            this.fld_tabPageSaleReturnItems.Controls.Add(this.fld_lblLabel4);
            this.fld_tabPageSaleReturnItems.Controls.Add(this.fld_dgcARSaleReturnItems);
            this.fld_tabPageSaleReturnItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageSaleReturnItems.Controls.Add(this.fld_pteARSaleReturnItemProductPicture);
            this.fld_tabPageSaleReturnItems.Name = "fld_tabPageSaleReturnItems";
            this.fld_tabPageSaleReturnItems.Size = new System.Drawing.Size(1341, 484);
            this.fld_tabPageSaleReturnItems.Text = "Danh sách sản phẩm";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1327, 477);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1327, 477);
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
            // DMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1358, 870);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPS100.IconOptions.Icon")));
            this.Name = "DMPS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleReturnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleReturnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleReturnItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleReturnEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleReturnDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleReturnStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnTaxPercent.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleReturnSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnGetPriceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleReturnGetPriceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabSaleReturnItems)).EndInit();
            this.fld_tabSaleReturnItems.ResumeLayout(false);
            this.fld_tabPageSaleReturnItems.ResumeLayout(false);
            this.fld_tabPageSaleReturnItems.PerformLayout();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARSaleReturnDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnNo1;
        private BOSComponent.BOSMemoEdit fld_medARSaleReturnDesc;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleReturnStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnExchangeRate;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDate;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabSaleReturnItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageSaleReturnItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLine bosLine1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceProductType;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATInvoiceNo;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATTaxNumber;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATSymbol;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeAROutputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnTaxAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnSubTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnTaxPercent;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSDateEdit fld_dteARSaleReturnGetPriceDate;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSTextBox fld_txtARSaleReturnSerialNo;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSRichEditControl fld_recARSaleReturnNote;
    }
}
