using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RetailVAT.UI
{
    /// <summary>
    /// Summary description for DMIV100
    /// </summary>
    partial class DMRVAT100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRVAT100));
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.arInvoiceItemsGridControl1 = new BOSERP.Modules.RetailVAT.ACRetailVATItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemLookupEdit1 = new BOSERP.ItemLookupEdit(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.baseDocumentEntryGridControl1 = new BOSERP.BaseDocumentEntryGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddCost = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemCosts = new BOSERP.Modules.SaleOrder.ARSaleOrderItemCostGridControl();
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_medACRetailVATComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabInvoiceItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pteACRetailVATItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcACRetailVATItems = new BOSERP.Modules.RetailVAT.ACRetailVATItemsGridControl();
            this.fld_dgvARInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_txtACRetailVATInvoiceRequest = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID123 = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACRetailVATDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRetailVATVATPaymentContactInformation = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATSOContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAROutputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRetailVATVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATVATTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRetailVATNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACRetailVATDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACRetailVATStatus1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRetailVATExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteACRetailVATEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtACRetailVATTotalAmount123 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATSubTotalAmount123 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATDiscountPerCent123 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATTaxAmount123 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATDiscountAmount123 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACRetailVATTaxPercent123 = new BOSComponent.BOSTextBox(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_medACRetailVATInternalComment = new BOSComponent.BOSMemoEdit(this.components);
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
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).BeginInit();
            this.fld_tabInvoiceItems.SuspendLayout();
            this.fld_tabPageInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACRetailVATItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRetailVATItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATInvoiceRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRetailVATDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRetailVATDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATPaymentContactInformation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATSOContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRetailVATStatus1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACRetailVATEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTotalAmount123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATSubTotalAmount123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATDiscountPerCent123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTaxAmount123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATDiscountAmount123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTaxPercent123.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATInternalComment.Properties)).BeginInit();
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
            this.fld_lblLabel44.Location = new System.Drawing.Point(1011, 623);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 46;
            this.fld_lblLabel44.Tag = "";
            this.fld_lblLabel44.Text = "Tổng cộng";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(1008, 675);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 72;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Thuế GTGT";
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
            this.fld_lblLabel46.Location = new System.Drawing.Point(1010, 649);
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
            this.fld_Line3.Controls.Add(this.fld_medACRetailVATComment);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(7, 609);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(367, 109);
            this.fld_Line3.TabIndex = 5;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Tag = "";
            this.fld_Line3.Text = "Ghi chú in ra";
            // 
            // fld_medACRetailVATComment
            // 
            this.fld_medACRetailVATComment.BOSComment = null;
            this.fld_medACRetailVATComment.BOSDataMember = "ACRetailVATComment";
            this.fld_medACRetailVATComment.BOSDataSource = "ACRetailVATs";
            this.fld_medACRetailVATComment.BOSDescription = null;
            this.fld_medACRetailVATComment.BOSError = null;
            this.fld_medACRetailVATComment.BOSFieldGroup = null;
            this.fld_medACRetailVATComment.BOSFieldRelation = null;
            this.fld_medACRetailVATComment.BOSPrivilege = null;
            this.fld_medACRetailVATComment.BOSPropertyName = "EditValue";
            this.fld_medACRetailVATComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medACRetailVATComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medACRetailVATComment.MenuManager = this.screenToolbar;
            this.fld_medACRetailVATComment.Name = "fld_medACRetailVATComment";
            this.fld_medACRetailVATComment.Screen = null;
            this.fld_medACRetailVATComment.Size = new System.Drawing.Size(361, 89);
            this.fld_medACRetailVATComment.TabIndex = 0;
            this.fld_medACRetailVATComment.Tag = "DC";
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
            this.fld_lblLabel47.Location = new System.Drawing.Point(995, 701);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 49;
            this.fld_lblLabel47.Tag = "";
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
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
            this.fld_tabInvoiceItems.Location = new System.Drawing.Point(3, 192);
            this.fld_tabInvoiceItems.Name = "fld_tabInvoiceItems";
            this.fld_tabInvoiceItems.Screen = null;
            this.fld_tabInvoiceItems.SelectedTabPage = this.fld_tabPageInvoiceItems;
            this.fld_tabInvoiceItems.Size = new System.Drawing.Size(1258, 411);
            this.fld_tabInvoiceItems.TabIndex = 4;
            this.fld_tabInvoiceItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceItems});
            // 
            // fld_tabPageInvoiceItems
            // 
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_pteACRetailVATItemProductPicture);
            this.fld_tabPageInvoiceItems.Controls.Add(this.fld_dgcACRetailVATItems);
            this.fld_tabPageInvoiceItems.Name = "fld_tabPageInvoiceItems";
            this.fld_tabPageInvoiceItems.Size = new System.Drawing.Size(1256, 386);
            this.fld_tabPageInvoiceItems.Text = "Danh sách sản phẩm";
            // 
            // fld_pteACRetailVATItemProductPicture
            // 
            this.fld_pteACRetailVATItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteACRetailVATItemProductPicture.BOSComment = "";
            this.fld_pteACRetailVATItemProductPicture.BOSDataMember = "ACRetailVATItemProductPicture";
            this.fld_pteACRetailVATItemProductPicture.BOSDataSource = "ACRetailVATItems";
            this.fld_pteACRetailVATItemProductPicture.BOSDescription = null;
            this.fld_pteACRetailVATItemProductPicture.BOSError = null;
            this.fld_pteACRetailVATItemProductPicture.BOSFieldGroup = "";
            this.fld_pteACRetailVATItemProductPicture.BOSFieldRelation = "";
            this.fld_pteACRetailVATItemProductPicture.BOSPrivilege = "";
            this.fld_pteACRetailVATItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteACRetailVATItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACRetailVATItemProductPicture.EditValue = "";
            this.fld_pteACRetailVATItemProductPicture.FileName = null;
            this.fld_pteACRetailVATItemProductPicture.FilePath = null;
            this.fld_pteACRetailVATItemProductPicture.Location = new System.Drawing.Point(1112, 3);
            this.fld_pteACRetailVATItemProductPicture.Name = "fld_pteACRetailVATItemProductPicture";
            this.fld_pteACRetailVATItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteACRetailVATItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteACRetailVATItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteACRetailVATItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteACRetailVATItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACRetailVATItemProductPicture.Screen = null;
            this.fld_pteACRetailVATItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteACRetailVATItemProductPicture.TabIndex = 0;
            this.fld_pteACRetailVATItemProductPicture.Tag = "DC";
            // 
            // fld_dgcACRetailVATItems
            // 
            this.fld_dgcACRetailVATItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACRetailVATItems.BOSComment = null;
            this.fld_dgcACRetailVATItems.BOSDataMember = null;
            this.fld_dgcACRetailVATItems.BOSDataSource = "ACRetailVATItems";
            this.fld_dgcACRetailVATItems.BOSDescription = null;
            this.fld_dgcACRetailVATItems.BOSError = null;
            this.fld_dgcACRetailVATItems.BOSFieldGroup = null;
            this.fld_dgcACRetailVATItems.BOSFieldRelation = null;
            this.fld_dgcACRetailVATItems.BOSGridType = null;
            this.fld_dgcACRetailVATItems.BOSPrivilege = null;
            this.fld_dgcACRetailVATItems.BOSPropertyName = null;
            this.fld_dgcACRetailVATItems.CommodityType = "";
            this.fld_dgcACRetailVATItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcACRetailVATItems.MainView = this.fld_dgvARInvoice;
            this.fld_dgcACRetailVATItems.Name = "fld_dgcACRetailVATItems";
            this.fld_dgcACRetailVATItems.PrintReport = false;
            this.fld_dgcACRetailVATItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.fld_dgcACRetailVATItems.Screen = null;
            this.fld_dgcACRetailVATItems.Size = new System.Drawing.Size(1103, 380);
            this.fld_dgcACRetailVATItems.TabIndex = 1;
            this.fld_dgcACRetailVATItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoice});
            // 
            // fld_dgvARInvoice
            // 
            this.fld_dgvARInvoice.GridControl = this.fld_dgcACRetailVATItems;
            this.fld_dgvARInvoice.Name = "fld_dgvARInvoice";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATInvoiceRequest);
            this.bosLine3.Controls.Add(this.bosLabel27);
            this.bosLine3.Controls.Add(this.fld_lblLabel5);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACObjectID123);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosLine3.Controls.Add(this.bosLabel7);
            this.bosLine3.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosLine3.Controls.Add(this.bosLabel3);
            this.bosLine3.Controls.Add(this.fld_lblLabel26);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.fld_dteACRetailVATDate);
            this.bosLine3.Controls.Add(this.fld_lblLabel2);
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATVATPaymentContactInformation);
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATSOContactName);
            this.bosLine3.Controls.Add(this.bosLabel20);
            this.bosLine3.Controls.Add(this.bosLabel19);
            this.bosLine3.Controls.Add(this.fld_lkeAROutputVATDocumentType);
            this.bosLine3.Controls.Add(this.bosLabel14);
            this.bosLine3.Controls.Add(this.bosLabel4);
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATVATInvoiceNo);
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATVATTaxNumber);
            this.bosLine3.Controls.Add(this.fld_txtACRetailVATVATFormNo);
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
            // fld_txtACRetailVATInvoiceRequest
            // 
            this.fld_txtACRetailVATInvoiceRequest.BOSComment = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSDataMember = "ACRetailVATInvoiceRequest";
            this.fld_txtACRetailVATInvoiceRequest.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATInvoiceRequest.BOSDescription = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSError = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSFieldGroup = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSFieldRelation = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSPrivilege = null;
            this.fld_txtACRetailVATInvoiceRequest.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATInvoiceRequest.Location = new System.Drawing.Point(344, 151);
            this.fld_txtACRetailVATInvoiceRequest.Name = "fld_txtACRetailVATInvoiceRequest";
            this.fld_txtACRetailVATInvoiceRequest.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATInvoiceRequest.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATInvoiceRequest.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATInvoiceRequest.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATInvoiceRequest.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATInvoiceRequest.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATInvoiceRequest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATInvoiceRequest.Screen = null;
            this.fld_txtACRetailVATInvoiceRequest.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATInvoiceRequest.TabIndex = 11;
            this.fld_txtACRetailVATInvoiceRequest.Tag = "DC";
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
            // fld_lkeFK_ACObjectID123
            // 
            this.fld_lkeFK_ACObjectID123.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID123.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID123.BOSComment = "";
            this.fld_lkeFK_ACObjectID123.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID123.BOSDataSource = "ACRetailVATs";
            this.fld_lkeFK_ACObjectID123.BOSDescription = null;
            this.fld_lkeFK_ACObjectID123.BOSError = null;
            this.fld_lkeFK_ACObjectID123.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID123.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID123.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID123.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID123.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID123.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID123.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID123.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID123.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID123.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID123.Location = new System.Drawing.Point(102, 99);
            this.fld_lkeFK_ACObjectID123.Name = "fld_lkeFK_ACObjectID123";
            this.fld_lkeFK_ACObjectID123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID123.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID123.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID123.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID123.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID123.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID123.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID123.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID123.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID123.Screen = null;
            this.fld_lkeFK_ACObjectID123.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ACObjectID123.TabIndex = 6;
            this.fld_lkeFK_ACObjectID123.Tag = "DC";
            this.fld_lkeFK_ACObjectID123.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            this.fld_lkeFK_ACObjectID123.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_ACObjectID_EditValueChanging);
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
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ACRetailVATs";
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
            // fld_dteACRetailVATDate
            // 
            this.fld_dteACRetailVATDate.BOSComment = "";
            this.fld_dteACRetailVATDate.BOSDataMember = "ACRetailVATDate";
            this.fld_dteACRetailVATDate.BOSDataSource = "ACRetailVATs";
            this.fld_dteACRetailVATDate.BOSDescription = null;
            this.fld_dteACRetailVATDate.BOSError = null;
            this.fld_dteACRetailVATDate.BOSFieldGroup = "";
            this.fld_dteACRetailVATDate.BOSFieldRelation = "";
            this.fld_dteACRetailVATDate.BOSPrivilege = "";
            this.fld_dteACRetailVATDate.BOSPropertyName = "EditValue";
            this.fld_dteACRetailVATDate.EditValue = null;
            this.fld_dteACRetailVATDate.Location = new System.Drawing.Point(344, 73);
            this.fld_dteACRetailVATDate.Name = "fld_dteACRetailVATDate";
            this.fld_dteACRetailVATDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACRetailVATDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACRetailVATDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACRetailVATDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACRetailVATDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACRetailVATDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACRetailVATDate.Screen = null;
            this.fld_dteACRetailVATDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACRetailVATDate.TabIndex = 5;
            this.fld_dteACRetailVATDate.Tag = "DC";
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
            this.fld_lblLabel2.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel2.TabIndex = 20;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Người mua hàng";
            // 
            // fld_txtACRetailVATVATPaymentContactInformation
            // 
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSComment = "";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSDataMember = "ACRetailVATVATPaymentContactInformation";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSDescription = null;
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSError = null;
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSFieldGroup = "";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSFieldRelation = "";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSPrivilege = "";
            this.fld_txtACRetailVATVATPaymentContactInformation.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATVATPaymentContactInformation.EditValue = "";
            this.fld_txtACRetailVATVATPaymentContactInformation.Location = new System.Drawing.Point(102, 151);
            this.fld_txtACRetailVATVATPaymentContactInformation.Name = "fld_txtACRetailVATVATPaymentContactInformation";
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATVATPaymentContactInformation.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATVATPaymentContactInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATVATPaymentContactInformation.Screen = null;
            this.fld_txtACRetailVATVATPaymentContactInformation.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATVATPaymentContactInformation.TabIndex = 10;
            this.fld_txtACRetailVATVATPaymentContactInformation.Tag = "DC";
            // 
            // fld_txtACRetailVATSOContactName
            // 
            this.fld_txtACRetailVATSOContactName.BOSComment = "";
            this.fld_txtACRetailVATSOContactName.BOSDataMember = "ACRetailVATSOContactName";
            this.fld_txtACRetailVATSOContactName.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATSOContactName.BOSDescription = null;
            this.fld_txtACRetailVATSOContactName.BOSError = null;
            this.fld_txtACRetailVATSOContactName.BOSFieldGroup = "";
            this.fld_txtACRetailVATSOContactName.BOSFieldRelation = "";
            this.fld_txtACRetailVATSOContactName.BOSPrivilege = "";
            this.fld_txtACRetailVATSOContactName.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATSOContactName.EditValue = "";
            this.fld_txtACRetailVATSOContactName.Location = new System.Drawing.Point(344, 99);
            this.fld_txtACRetailVATSOContactName.Name = "fld_txtACRetailVATSOContactName";
            this.fld_txtACRetailVATSOContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATSOContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATSOContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATSOContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATSOContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATSOContactName.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATSOContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATSOContactName.Screen = null;
            this.fld_txtACRetailVATSOContactName.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATSOContactName.TabIndex = 7;
            this.fld_txtACRetailVATSOContactName.Tag = "DC";
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
            this.fld_lkeAROutputVATDocumentType.BOSDataSource = "ACRetailVATs";
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
            // fld_txtACRetailVATVATInvoiceNo
            // 
            this.fld_txtACRetailVATVATInvoiceNo.BOSComment = "";
            this.fld_txtACRetailVATVATInvoiceNo.BOSDataMember = "ACRetailVATVATInvoiceNo";
            this.fld_txtACRetailVATVATInvoiceNo.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATVATInvoiceNo.BOSDescription = null;
            this.fld_txtACRetailVATVATInvoiceNo.BOSError = null;
            this.fld_txtACRetailVATVATInvoiceNo.BOSFieldGroup = "";
            this.fld_txtACRetailVATVATInvoiceNo.BOSFieldRelation = "";
            this.fld_txtACRetailVATVATInvoiceNo.BOSPrivilege = "";
            this.fld_txtACRetailVATVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATVATInvoiceNo.EditValue = "";
            this.fld_txtACRetailVATVATInvoiceNo.Location = new System.Drawing.Point(102, 73);
            this.fld_txtACRetailVATVATInvoiceNo.Name = "fld_txtACRetailVATVATInvoiceNo";
            this.fld_txtACRetailVATVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATVATInvoiceNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATVATInvoiceNo.Screen = null;
            this.fld_txtACRetailVATVATInvoiceNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATVATInvoiceNo.TabIndex = 4;
            this.fld_txtACRetailVATVATInvoiceNo.Tag = "DC";
            // 
            // fld_txtACRetailVATVATTaxNumber
            // 
            this.fld_txtACRetailVATVATTaxNumber.BOSComment = "";
            this.fld_txtACRetailVATVATTaxNumber.BOSDataMember = "ACRetailVATTaxNumber";
            this.fld_txtACRetailVATVATTaxNumber.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATVATTaxNumber.BOSDescription = null;
            this.fld_txtACRetailVATVATTaxNumber.BOSError = null;
            this.fld_txtACRetailVATVATTaxNumber.BOSFieldGroup = "";
            this.fld_txtACRetailVATVATTaxNumber.BOSFieldRelation = "";
            this.fld_txtACRetailVATVATTaxNumber.BOSPrivilege = "";
            this.fld_txtACRetailVATVATTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATVATTaxNumber.EditValue = "";
            this.fld_txtACRetailVATVATTaxNumber.Location = new System.Drawing.Point(344, 125);
            this.fld_txtACRetailVATVATTaxNumber.Name = "fld_txtACRetailVATVATTaxNumber";
            this.fld_txtACRetailVATVATTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATVATTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATVATTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATVATTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATVATTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATVATTaxNumber.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATVATTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATVATTaxNumber.Screen = null;
            this.fld_txtACRetailVATVATTaxNumber.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATVATTaxNumber.TabIndex = 9;
            this.fld_txtACRetailVATVATTaxNumber.Tag = "DC";
            // 
            // fld_txtACRetailVATVATFormNo
            // 
            this.fld_txtACRetailVATVATFormNo.BOSComment = "";
            this.fld_txtACRetailVATVATFormNo.BOSDataMember = "ACRetailVATVATFormNo";
            this.fld_txtACRetailVATVATFormNo.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATVATFormNo.BOSDescription = null;
            this.fld_txtACRetailVATVATFormNo.BOSError = null;
            this.fld_txtACRetailVATVATFormNo.BOSFieldGroup = "";
            this.fld_txtACRetailVATVATFormNo.BOSFieldRelation = "";
            this.fld_txtACRetailVATVATFormNo.BOSPrivilege = "";
            this.fld_txtACRetailVATVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATVATFormNo.EditValue = "";
            this.fld_txtACRetailVATVATFormNo.Location = new System.Drawing.Point(102, 47);
            this.fld_txtACRetailVATVATFormNo.Name = "fld_txtACRetailVATVATFormNo";
            this.fld_txtACRetailVATVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATVATFormNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATVATFormNo.Screen = null;
            this.fld_txtACRetailVATVATFormNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATVATFormNo.TabIndex = 2;
            this.fld_txtACRetailVATVATFormNo.Tag = "DC";
            // 
            // fld_txtARInvoiceVATSymbol
            // 
            this.fld_txtARInvoiceVATSymbol.BOSComment = "";
            this.fld_txtARInvoiceVATSymbol.BOSDataMember = "ACRetailVATVATSymbol";
            this.fld_txtARInvoiceVATSymbol.BOSDataSource = "ACRetailVATs";
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
            this.bosLine4.Controls.Add(this.bosLabel16);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.bosLine4.Controls.Add(this.bosLabel6);
            this.bosLine4.Controls.Add(this.bosLabel11);
            this.bosLine4.Controls.Add(this.fld_txtACRetailVATNo);
            this.bosLine4.Controls.Add(this.fld_medACRetailVATDesc);
            this.bosLine4.Controls.Add(this.fld_lblLabel25);
            this.bosLine4.Controls.Add(this.fld_lkeACRetailVATStatus1);
            this.bosLine4.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine4.Controls.Add(this.bosLabel1);
            this.bosLine4.Controls.Add(this.fld_txtACRetailVATExchangeRate);
            this.bosLine4.Controls.Add(this.bosLabel5);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(151, 5);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(490, 181);
            this.bosLine4.TabIndex = 2;
            this.bosLine4.TabStop = false;
            this.bosLine4.Tag = "";
            this.bosLine4.Text = "Thông tin chung";
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
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSellerID.BOSComment = null;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ACRetailVATs";
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
            // fld_txtACRetailVATNo
            // 
            this.fld_txtACRetailVATNo.BOSComment = null;
            this.fld_txtACRetailVATNo.BOSDataMember = "ACRetailVATNo";
            this.fld_txtACRetailVATNo.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATNo.BOSDescription = null;
            this.fld_txtACRetailVATNo.BOSError = null;
            this.fld_txtACRetailVATNo.BOSFieldGroup = null;
            this.fld_txtACRetailVATNo.BOSFieldRelation = null;
            this.fld_txtACRetailVATNo.BOSPrivilege = null;
            this.fld_txtACRetailVATNo.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATNo.Location = new System.Drawing.Point(125, 21);
            this.fld_txtACRetailVATNo.MenuManager = this.screenToolbar;
            this.fld_txtACRetailVATNo.Name = "fld_txtACRetailVATNo";
            this.fld_txtACRetailVATNo.Screen = null;
            this.fld_txtACRetailVATNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATNo.TabIndex = 0;
            this.fld_txtACRetailVATNo.Tag = "DC";
            // 
            // fld_medACRetailVATDesc
            // 
            this.fld_medACRetailVATDesc.BOSComment = "";
            this.fld_medACRetailVATDesc.BOSDataMember = "ACRetailVATDesc";
            this.fld_medACRetailVATDesc.BOSDataSource = "ACRetailVATs";
            this.fld_medACRetailVATDesc.BOSDescription = null;
            this.fld_medACRetailVATDesc.BOSError = null;
            this.fld_medACRetailVATDesc.BOSFieldGroup = "";
            this.fld_medACRetailVATDesc.BOSFieldRelation = "";
            this.fld_medACRetailVATDesc.BOSPrivilege = "";
            this.fld_medACRetailVATDesc.BOSPropertyName = "EditValue";
            this.fld_medACRetailVATDesc.EditValue = "";
            this.fld_medACRetailVATDesc.Location = new System.Drawing.Point(125, 99);
            this.fld_medACRetailVATDesc.Name = "fld_medACRetailVATDesc";
            this.fld_medACRetailVATDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACRetailVATDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACRetailVATDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACRetailVATDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACRetailVATDesc.Screen = null;
            this.fld_medACRetailVATDesc.Size = new System.Drawing.Size(352, 40);
            this.fld_medACRetailVATDesc.TabIndex = 5;
            this.fld_medACRetailVATDesc.Tag = "DC";
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
            // fld_lkeACRetailVATStatus1
            // 
            this.fld_lkeACRetailVATStatus1.BOSAllowAddNew = false;
            this.fld_lkeACRetailVATStatus1.BOSAllowDummy = false;
            this.fld_lkeACRetailVATStatus1.BOSComment = "";
            this.fld_lkeACRetailVATStatus1.BOSDataMember = "ACRetailVATStatus";
            this.fld_lkeACRetailVATStatus1.BOSDataSource = "ACRetailVATs";
            this.fld_lkeACRetailVATStatus1.BOSDescription = null;
            this.fld_lkeACRetailVATStatus1.BOSError = null;
            this.fld_lkeACRetailVATStatus1.BOSFieldGroup = "";
            this.fld_lkeACRetailVATStatus1.BOSFieldParent = "";
            this.fld_lkeACRetailVATStatus1.BOSFieldRelation = "";
            this.fld_lkeACRetailVATStatus1.BOSPrivilege = "";
            this.fld_lkeACRetailVATStatus1.BOSPropertyName = "EditValue";
            this.fld_lkeACRetailVATStatus1.BOSSelectType = "";
            this.fld_lkeACRetailVATStatus1.BOSSelectTypeValue = "";
            this.fld_lkeACRetailVATStatus1.CurrentDisplayText = "";
            this.fld_lkeACRetailVATStatus1.Location = new System.Drawing.Point(125, 47);
            this.fld_lkeACRetailVATStatus1.Name = "fld_lkeACRetailVATStatus1";
            this.fld_lkeACRetailVATStatus1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeACRetailVATStatus1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACRetailVATStatus1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACRetailVATStatus1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACRetailVATStatus1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACRetailVATStatus1.Properties.ColumnName = null;
            this.fld_lkeACRetailVATStatus1.Properties.NullText = "";
            this.fld_lkeACRetailVATStatus1.Properties.ReadOnly = true;
            this.fld_lkeACRetailVATStatus1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACRetailVATStatus1.Screen = null;
            this.fld_lkeACRetailVATStatus1.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACRetailVATStatus1.TabIndex = 2;
            this.fld_lkeACRetailVATStatus1.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACRetailVATs";
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
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
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
            this.bosLabel1.Location = new System.Drawing.Point(11, 106);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 24;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Diễn giải";
            // 
            // fld_txtACRetailVATExchangeRate
            // 
            this.fld_txtACRetailVATExchangeRate.BOSComment = "";
            this.fld_txtACRetailVATExchangeRate.BOSDataMember = "ACRetailVATExchangeRate";
            this.fld_txtACRetailVATExchangeRate.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATExchangeRate.BOSDescription = null;
            this.fld_txtACRetailVATExchangeRate.BOSError = null;
            this.fld_txtACRetailVATExchangeRate.BOSFieldGroup = "";
            this.fld_txtACRetailVATExchangeRate.BOSFieldRelation = "";
            this.fld_txtACRetailVATExchangeRate.BOSPrivilege = "";
            this.fld_txtACRetailVATExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACRetailVATExchangeRate.EditValue = "";
            this.fld_txtACRetailVATExchangeRate.Location = new System.Drawing.Point(346, 73);
            this.fld_txtACRetailVATExchangeRate.Name = "fld_txtACRetailVATExchangeRate";
            this.fld_txtACRetailVATExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATExchangeRate.Screen = null;
            this.fld_txtACRetailVATExchangeRate.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACRetailVATExchangeRate.TabIndex = 4;
            this.fld_txtACRetailVATExchangeRate.Tag = "DC";
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
            // fld_pteACRetailVATEmployeePicture
            // 
            this.fld_pteACRetailVATEmployeePicture.BOSComment = null;
            this.fld_pteACRetailVATEmployeePicture.BOSDataMember = "ACRetailVATEmployeePicture";
            this.fld_pteACRetailVATEmployeePicture.BOSDataSource = "ACRetailVATs";
            this.fld_pteACRetailVATEmployeePicture.BOSDescription = null;
            this.fld_pteACRetailVATEmployeePicture.BOSError = null;
            this.fld_pteACRetailVATEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACRetailVATEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACRetailVATEmployeePicture.BOSPrivilege = null;
            this.fld_pteACRetailVATEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACRetailVATEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACRetailVATEmployeePicture.FileName = null;
            this.fld_pteACRetailVATEmployeePicture.FilePath = null;
            this.fld_pteACRetailVATEmployeePicture.Location = new System.Drawing.Point(12, 12);
            this.fld_pteACRetailVATEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACRetailVATEmployeePicture.Name = "fld_pteACRetailVATEmployeePicture";
            this.fld_pteACRetailVATEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACRetailVATEmployeePicture.Screen = null;
            this.fld_pteACRetailVATEmployeePicture.Size = new System.Drawing.Size(127, 136);
            this.fld_pteACRetailVATEmployeePicture.TabIndex = 0;
            this.fld_pteACRetailVATEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACRetailVATs";
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
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATTotalAmount123);
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATSubTotalAmount123);
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATDiscountPerCent123);
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATTaxAmount123);
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATDiscountAmount123);
            this.bosPanel1.Controls.Add(this.fld_txtACRetailVATTaxPercent123);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_pteACRetailVATEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceItems);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1273, 733);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_txtACRetailVATTotalAmount123
            // 
            this.fld_txtACRetailVATTotalAmount123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATTotalAmount123.BOSComment = "";
            this.fld_txtACRetailVATTotalAmount123.BOSDataMember = "ACRetailVATTotalAmount";
            this.fld_txtACRetailVATTotalAmount123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATTotalAmount123.BOSDescription = null;
            this.fld_txtACRetailVATTotalAmount123.BOSError = "";
            this.fld_txtACRetailVATTotalAmount123.BOSFieldGroup = "";
            this.fld_txtACRetailVATTotalAmount123.BOSFieldRelation = "";
            this.fld_txtACRetailVATTotalAmount123.BOSPrivilege = "";
            this.fld_txtACRetailVATTotalAmount123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATTotalAmount123.Location = new System.Drawing.Point(1078, 698);
            this.fld_txtACRetailVATTotalAmount123.Name = "fld_txtACRetailVATTotalAmount123";
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.Options.UseFont = true;
            this.fld_txtACRetailVATTotalAmount123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATTotalAmount123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATTotalAmount123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATTotalAmount123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATTotalAmount123.Properties.ReadOnly = true;
            this.fld_txtACRetailVATTotalAmount123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATTotalAmount123.Screen = null;
            this.fld_txtACRetailVATTotalAmount123.Size = new System.Drawing.Size(183, 20);
            this.fld_txtACRetailVATTotalAmount123.TabIndex = 11111;
            this.fld_txtACRetailVATTotalAmount123.Tag = "DC";
            // 
            // fld_txtACRetailVATSubTotalAmount123
            // 
            this.fld_txtACRetailVATSubTotalAmount123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATSubTotalAmount123.BOSComment = "";
            this.fld_txtACRetailVATSubTotalAmount123.BOSDataMember = "ACRetailVATSubTotalAmount";
            this.fld_txtACRetailVATSubTotalAmount123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATSubTotalAmount123.BOSDescription = null;
            this.fld_txtACRetailVATSubTotalAmount123.BOSError = "";
            this.fld_txtACRetailVATSubTotalAmount123.BOSFieldGroup = "";
            this.fld_txtACRetailVATSubTotalAmount123.BOSFieldRelation = "";
            this.fld_txtACRetailVATSubTotalAmount123.BOSPrivilege = "";
            this.fld_txtACRetailVATSubTotalAmount123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATSubTotalAmount123.Location = new System.Drawing.Point(1078, 620);
            this.fld_txtACRetailVATSubTotalAmount123.Name = "fld_txtACRetailVATSubTotalAmount123";
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.Options.UseFont = true;
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATSubTotalAmount123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATSubTotalAmount123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATSubTotalAmount123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATSubTotalAmount123.Properties.ReadOnly = true;
            this.fld_txtACRetailVATSubTotalAmount123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATSubTotalAmount123.Screen = null;
            this.fld_txtACRetailVATSubTotalAmount123.Size = new System.Drawing.Size(183, 20);
            this.fld_txtACRetailVATSubTotalAmount123.TabIndex = 1116;
            this.fld_txtACRetailVATSubTotalAmount123.Tag = "DC";
            // 
            // fld_txtACRetailVATDiscountPerCent123
            // 
            this.fld_txtACRetailVATDiscountPerCent123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATDiscountPerCent123.BOSComment = "";
            this.fld_txtACRetailVATDiscountPerCent123.BOSDataMember = "ACRetailVATDiscountPerCent";
            this.fld_txtACRetailVATDiscountPerCent123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATDiscountPerCent123.BOSDescription = null;
            this.fld_txtACRetailVATDiscountPerCent123.BOSError = "";
            this.fld_txtACRetailVATDiscountPerCent123.BOSFieldGroup = "";
            this.fld_txtACRetailVATDiscountPerCent123.BOSFieldRelation = "";
            this.fld_txtACRetailVATDiscountPerCent123.BOSPrivilege = "";
            this.fld_txtACRetailVATDiscountPerCent123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATDiscountPerCent123.Location = new System.Drawing.Point(1078, 646);
            this.fld_txtACRetailVATDiscountPerCent123.Name = "fld_txtACRetailVATDiscountPerCent123";
            this.fld_txtACRetailVATDiscountPerCent123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATDiscountPerCent123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATDiscountPerCent123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATDiscountPerCent123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATDiscountPerCent123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATDiscountPerCent123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATDiscountPerCent123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATDiscountPerCent123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATDiscountPerCent123.Screen = null;
            this.fld_txtACRetailVATDiscountPerCent123.Size = new System.Drawing.Size(60, 20);
            this.fld_txtACRetailVATDiscountPerCent123.TabIndex = 1117;
            this.fld_txtACRetailVATDiscountPerCent123.Tag = "DC";
            // 
            // fld_txtACRetailVATTaxAmount123
            // 
            this.fld_txtACRetailVATTaxAmount123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATTaxAmount123.BOSComment = "";
            this.fld_txtACRetailVATTaxAmount123.BOSDataMember = "ACRetailVATTaxAmount";
            this.fld_txtACRetailVATTaxAmount123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATTaxAmount123.BOSDescription = null;
            this.fld_txtACRetailVATTaxAmount123.BOSError = "";
            this.fld_txtACRetailVATTaxAmount123.BOSFieldGroup = "";
            this.fld_txtACRetailVATTaxAmount123.BOSFieldRelation = "";
            this.fld_txtACRetailVATTaxAmount123.BOSPrivilege = "";
            this.fld_txtACRetailVATTaxAmount123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATTaxAmount123.Location = new System.Drawing.Point(1144, 672);
            this.fld_txtACRetailVATTaxAmount123.Name = "fld_txtACRetailVATTaxAmount123";
            this.fld_txtACRetailVATTaxAmount123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATTaxAmount123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATTaxAmount123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATTaxAmount123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATTaxAmount123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATTaxAmount123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATTaxAmount123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATTaxAmount123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATTaxAmount123.Screen = null;
            this.fld_txtACRetailVATTaxAmount123.Size = new System.Drawing.Size(117, 20);
            this.fld_txtACRetailVATTaxAmount123.TabIndex = 11110;
            this.fld_txtACRetailVATTaxAmount123.Tag = "DC";
            // 
            // fld_txtACRetailVATDiscountAmount123
            // 
            this.fld_txtACRetailVATDiscountAmount123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATDiscountAmount123.BOSComment = "";
            this.fld_txtACRetailVATDiscountAmount123.BOSDataMember = "ACRetailVATDiscountAmount";
            this.fld_txtACRetailVATDiscountAmount123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATDiscountAmount123.BOSDescription = null;
            this.fld_txtACRetailVATDiscountAmount123.BOSError = "";
            this.fld_txtACRetailVATDiscountAmount123.BOSFieldGroup = "";
            this.fld_txtACRetailVATDiscountAmount123.BOSFieldRelation = "";
            this.fld_txtACRetailVATDiscountAmount123.BOSPrivilege = "";
            this.fld_txtACRetailVATDiscountAmount123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATDiscountAmount123.Location = new System.Drawing.Point(1144, 646);
            this.fld_txtACRetailVATDiscountAmount123.Name = "fld_txtACRetailVATDiscountAmount123";
            this.fld_txtACRetailVATDiscountAmount123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATDiscountAmount123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATDiscountAmount123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATDiscountAmount123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATDiscountAmount123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATDiscountAmount123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATDiscountAmount123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATDiscountAmount123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATDiscountAmount123.Screen = null;
            this.fld_txtACRetailVATDiscountAmount123.Size = new System.Drawing.Size(117, 20);
            this.fld_txtACRetailVATDiscountAmount123.TabIndex = 1118;
            this.fld_txtACRetailVATDiscountAmount123.Tag = "DC";
            // 
            // fld_txtACRetailVATTaxPercent123
            // 
            this.fld_txtACRetailVATTaxPercent123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACRetailVATTaxPercent123.BOSComment = "";
            this.fld_txtACRetailVATTaxPercent123.BOSDataMember = "ACRetailVATTaxPercent";
            this.fld_txtACRetailVATTaxPercent123.BOSDataSource = "ACRetailVATs";
            this.fld_txtACRetailVATTaxPercent123.BOSDescription = null;
            this.fld_txtACRetailVATTaxPercent123.BOSError = "";
            this.fld_txtACRetailVATTaxPercent123.BOSFieldGroup = "";
            this.fld_txtACRetailVATTaxPercent123.BOSFieldRelation = "";
            this.fld_txtACRetailVATTaxPercent123.BOSPrivilege = "";
            this.fld_txtACRetailVATTaxPercent123.BOSPropertyName = "Text";
            this.fld_txtACRetailVATTaxPercent123.Location = new System.Drawing.Point(1078, 672);
            this.fld_txtACRetailVATTaxPercent123.Name = "fld_txtACRetailVATTaxPercent123";
            this.fld_txtACRetailVATTaxPercent123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRetailVATTaxPercent123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRetailVATTaxPercent123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRetailVATTaxPercent123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRetailVATTaxPercent123.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRetailVATTaxPercent123.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtACRetailVATTaxPercent123.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtACRetailVATTaxPercent123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRetailVATTaxPercent123.Screen = null;
            this.fld_txtACRetailVATTaxPercent123.Size = new System.Drawing.Size(60, 20);
            this.fld_txtACRetailVATTaxPercent123.TabIndex = 1119;
            this.fld_txtACRetailVATTaxPercent123.Tag = "DC";
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
            this.bosLine2.Controls.Add(this.fld_medACRetailVATInternalComment);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(380, 609);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(367, 109);
            this.bosLine2.TabIndex = 6;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Ghi chú không in ra";
            // 
            // fld_medACRetailVATInternalComment
            // 
            this.fld_medACRetailVATInternalComment.BOSComment = null;
            this.fld_medACRetailVATInternalComment.BOSDataMember = "ACRetailVATInternalComment";
            this.fld_medACRetailVATInternalComment.BOSDataSource = "ACRetailVATs";
            this.fld_medACRetailVATInternalComment.BOSDescription = null;
            this.fld_medACRetailVATInternalComment.BOSError = null;
            this.fld_medACRetailVATInternalComment.BOSFieldGroup = null;
            this.fld_medACRetailVATInternalComment.BOSFieldRelation = null;
            this.fld_medACRetailVATInternalComment.BOSPrivilege = null;
            this.fld_medACRetailVATInternalComment.BOSPropertyName = "EditValue";
            this.fld_medACRetailVATInternalComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medACRetailVATInternalComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medACRetailVATInternalComment.Name = "fld_medACRetailVATInternalComment";
            this.fld_medACRetailVATInternalComment.Screen = null;
            this.fld_medACRetailVATInternalComment.Size = new System.Drawing.Size(361, 89);
            this.fld_medACRetailVATInternalComment.TabIndex = 0;
            this.fld_medACRetailVATInternalComment.Tag = "DC";
            // 
            // DMRVAT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1273, 733);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMRVAT100.IconOptions.Icon")));
            this.Name = "DMRVAT100";
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
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceItems)).EndInit();
            this.fld_tabInvoiceItems.ResumeLayout(false);
            this.fld_tabPageInvoiceItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACRetailVATItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRetailVATItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATInvoiceRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRetailVATDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRetailVATDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATPaymentContactInformation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATSOContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAROutputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRetailVATStatus1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACRetailVATEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTotalAmount123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATSubTotalAmount123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATDiscountPerCent123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTaxAmount123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATDiscountAmount123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRetailVATTaxPercent123.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRetailVATInternalComment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private BOSComponent.BOSLabel bosLabel2;
        private ACRetailVATItemsGridControl arInvoiceItemsGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private ItemLookupEdit itemLookupEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BaseDocumentEntryGridControl baseDocumentEntryGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddCost;
        private BOSERP.Modules.SaleOrder.ARSaleOrderItemCostGridControl fld_dgcARSaleOrderItemCosts;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLine fld_Line3;
        private BOSComponent.BOSMemoEdit fld_medACRetailVATComment;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTabControl fld_tabInvoiceItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceItems;
        private BOSComponent.BOSPictureEdit fld_pteACRetailVATItemProductPicture;
        private ACRetailVATItemsGridControl fld_dgcACRetailVATItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID123;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSDateEdit fld_dteACRetailVATDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtACRetailVATVATPaymentContactInformation;
        private BOSComponent.BOSTextBox fld_txtACRetailVATSOContactName;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeAROutputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtACRetailVATVATInvoiceNo;
        private BOSComponent.BOSTextBox fld_txtACRetailVATVATTaxNumber;
        private BOSComponent.BOSTextBox fld_txtACRetailVATVATFormNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATSymbol;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACRetailVATNo;
        private BOSComponent.BOSMemoEdit fld_medACRetailVATDesc;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeACRetailVATStatus1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACRetailVATExchangeRate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSPictureEdit fld_pteACRetailVATEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtACRetailVATInvoiceRequest;
        private BOSComponent.BOSTextBox fld_txtACRetailVATDiscountPerCent123;
        private BOSComponent.BOSTextBox fld_txtACRetailVATTaxAmount123;
        private BOSComponent.BOSTextBox fld_txtACRetailVATDiscountAmount123;
        private BOSComponent.BOSTextBox fld_txtACRetailVATTaxPercent123;
        private BOSComponent.BOSTextBox fld_txtACRetailVATTotalAmount123;
        private BOSComponent.BOSTextBox fld_txtACRetailVATSubTotalAmount123;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSMemoEdit fld_medACRetailVATInternalComment;
        //private IContainer components;
    }
}
