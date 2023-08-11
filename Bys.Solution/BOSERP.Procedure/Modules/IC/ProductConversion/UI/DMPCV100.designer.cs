using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConversion.UI
{
	/// <summary>
	/// Summary description for DMPCV100
	/// </summary>
	partial class DMPCV100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPCV100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnGroupPackage = new BOSComponent.BOSButton(this.components);
            this.fld_btnClearPackage = new BOSComponent.BOSButton(this.components);
            this.btnGenPackage = new BOSComponent.BOSButton(this.components);
            this.fld_btnShipment = new BOSComponent.BOSButton(this.components);
            this.fld_lkeGenerationHSPB = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddFromPurchaseReceipt = new BOSComponent.BOSButton(this.components);
            this.fld_lkeProductConversionProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabTransferItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProductSource = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_grpProductSource = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcICProductConversionItems = new BOSERP.Modules.ProductConversion.ICProductConversionItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCopyAllProduct = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCopyProduct = new DevExpress.XtraEditors.SimpleButton();
            this.fld_grpProductTarget = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcICProductConversionItemTargetsGridControl = new BOSERP.Modules.ProductConversion.ICProductConversionItemTargetsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ICFromStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICProductConversionDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteICProductConversionEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductConversionStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductConversionDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductConversionNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGenerationHSPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductConversionProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).BeginInit();
            this.fld_tabTransferItems.SuspendLayout();
            this.fld_tabProductSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductSource)).BeginInit();
            this.fld_grpProductSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductTarget)).BeginInit();
            this.fld_grpProductTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversionItemTargetsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductConversionDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductConversionEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductConversionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductConversionNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_btnGroupPackage);
            this.bosPanel1.Controls.Add(this.fld_btnClearPackage);
            this.bosPanel1.Controls.Add(this.btnGenPackage);
            this.bosPanel1.Controls.Add(this.fld_btnShipment);
            this.bosPanel1.Controls.Add(this.fld_lkeGenerationHSPB);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_btnAddFromPurchaseReceipt);
            this.bosPanel1.Controls.Add(this.fld_lkeProductConversionProductType);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_tabTransferItems);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICFromStockID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICToStockID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_medICProductConversionDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICProductConversionEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductConversionStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICProductConversionDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtICProductConversionNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1146, 706);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_btnGroupPackage
            // 
            this.fld_btnGroupPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnGroupPackage.Appearance.Options.UseForeColor = true;
            this.fld_btnGroupPackage.BOSComment = "";
            this.fld_btnGroupPackage.BOSDataMember = "";
            this.fld_btnGroupPackage.BOSDataSource = "";
            this.fld_btnGroupPackage.BOSDescription = null;
            this.fld_btnGroupPackage.BOSError = null;
            this.fld_btnGroupPackage.BOSFieldGroup = "";
            this.fld_btnGroupPackage.BOSFieldRelation = "";
            this.fld_btnGroupPackage.BOSPrivilege = "";
            this.fld_btnGroupPackage.BOSPropertyName = "";
            this.fld_btnGroupPackage.Location = new System.Drawing.Point(889, 85);
            this.fld_btnGroupPackage.Name = "fld_btnGroupPackage";
            this.fld_btnGroupPackage.Screen = null;
            this.fld_btnGroupPackage.Size = new System.Drawing.Size(137, 29);
            this.fld_btnGroupPackage.TabIndex = 576;
            this.fld_btnGroupPackage.Tag = "";
            this.fld_btnGroupPackage.Text = "Gộp kiện";
            this.fld_btnGroupPackage.Visible = false;
            this.fld_btnGroupPackage.Click += new System.EventHandler(this.fld_btnGroupPackage_Click);
            // 
            // fld_btnClearPackage
            // 
            this.fld_btnClearPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnClearPackage.Appearance.Options.UseForeColor = true;
            this.fld_btnClearPackage.BOSComment = "";
            this.fld_btnClearPackage.BOSDataMember = "";
            this.fld_btnClearPackage.BOSDataSource = "";
            this.fld_btnClearPackage.BOSDescription = null;
            this.fld_btnClearPackage.BOSError = null;
            this.fld_btnClearPackage.BOSFieldGroup = "";
            this.fld_btnClearPackage.BOSFieldRelation = "";
            this.fld_btnClearPackage.BOSPrivilege = "";
            this.fld_btnClearPackage.BOSPropertyName = "";
            this.fld_btnClearPackage.Location = new System.Drawing.Point(889, 120);
            this.fld_btnClearPackage.Name = "fld_btnClearPackage";
            this.fld_btnClearPackage.Screen = null;
            this.fld_btnClearPackage.Size = new System.Drawing.Size(137, 29);
            this.fld_btnClearPackage.TabIndex = 577;
            this.fld_btnClearPackage.Tag = "";
            this.fld_btnClearPackage.Text = "Xóa mã kiện";
            this.fld_btnClearPackage.Visible = false;
            this.fld_btnClearPackage.Click += new System.EventHandler(this.fld_btnClearPackage_Click);
            // 
            // btnGenPackage
            // 
            this.btnGenPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenPackage.Appearance.Options.UseForeColor = true;
            this.btnGenPackage.BOSComment = "";
            this.btnGenPackage.BOSDataMember = "";
            this.btnGenPackage.BOSDataSource = "";
            this.btnGenPackage.BOSDescription = null;
            this.btnGenPackage.BOSError = null;
            this.btnGenPackage.BOSFieldGroup = "";
            this.btnGenPackage.BOSFieldRelation = "";
            this.btnGenPackage.BOSPrivilege = "";
            this.btnGenPackage.BOSPropertyName = "";
            this.btnGenPackage.Location = new System.Drawing.Point(889, 50);
            this.btnGenPackage.Name = "btnGenPackage";
            this.btnGenPackage.Screen = null;
            this.btnGenPackage.Size = new System.Drawing.Size(137, 29);
            this.btnGenPackage.TabIndex = 578;
            this.btnGenPackage.Tag = "";
            this.btnGenPackage.Text = "Tạo kiện";
            this.btnGenPackage.Visible = false;
            this.btnGenPackage.Click += new System.EventHandler(this.btnGenPackage_Click);
            // 
            // fld_btnShipment
            // 
            this.fld_btnShipment.BOSComment = null;
            this.fld_btnShipment.BOSDataMember = null;
            this.fld_btnShipment.BOSDataSource = null;
            this.fld_btnShipment.BOSDescription = null;
            this.fld_btnShipment.BOSError = null;
            this.fld_btnShipment.BOSFieldGroup = null;
            this.fld_btnShipment.BOSFieldRelation = null;
            this.fld_btnShipment.BOSPrivilege = null;
            this.fld_btnShipment.BOSPropertyName = null;
            this.fld_btnShipment.Location = new System.Drawing.Point(703, 122);
            this.fld_btnShipment.Name = "fld_btnShipment";
            this.fld_btnShipment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShipment, true);
            this.fld_btnShipment.Size = new System.Drawing.Size(150, 27);
            this.fld_btnShipment.TabIndex = 575;
            this.fld_btnShipment.Text = "Xuất kho";
            this.fld_btnShipment.Click += new System.EventHandler(this.fld_btnShipment_Click);
            // 
            // fld_lkeGenerationHSPB
            // 
            this.fld_lkeGenerationHSPB.BOSAllowAddNew = false;
            this.fld_lkeGenerationHSPB.BOSAllowDummy = true;
            this.fld_lkeGenerationHSPB.BOSComment = null;
            this.fld_lkeGenerationHSPB.BOSDataMember = "ICProductConversionRuleOfAllocationFactorGeneration";
            this.fld_lkeGenerationHSPB.BOSDataSource = "ICProductConversions";
            this.fld_lkeGenerationHSPB.BOSDescription = null;
            this.fld_lkeGenerationHSPB.BOSError = null;
            this.fld_lkeGenerationHSPB.BOSFieldGroup = null;
            this.fld_lkeGenerationHSPB.BOSFieldParent = null;
            this.fld_lkeGenerationHSPB.BOSFieldRelation = null;
            this.fld_lkeGenerationHSPB.BOSPrivilege = null;
            this.fld_lkeGenerationHSPB.BOSPropertyName = "EditValue";
            this.fld_lkeGenerationHSPB.BOSSelectType = null;
            this.fld_lkeGenerationHSPB.BOSSelectTypeValue = null;
            this.fld_lkeGenerationHSPB.CurrentDisplayText = null;
            this.fld_lkeGenerationHSPB.Location = new System.Drawing.Point(703, 62);
            this.fld_lkeGenerationHSPB.MenuManager = this.screenToolbar;
            this.fld_lkeGenerationHSPB.Name = "fld_lkeGenerationHSPB";
            this.fld_lkeGenerationHSPB.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeGenerationHSPB.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGenerationHSPB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGenerationHSPB.Properties.ColumnName = null;
            this.fld_lkeGenerationHSPB.Properties.NullText = "";
            this.fld_lkeGenerationHSPB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGenerationHSPB.Screen = null;
            this.fld_lkeGenerationHSPB.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGenerationHSPB.TabIndex = 573;
            this.fld_lkeGenerationHSPB.Tag = "DC";
            this.fld_lkeGenerationHSPB.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeGenerationHSPB_CloseUp);
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
            this.bosLabel7.Location = new System.Drawing.Point(624, 66);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(74, 13);
            this.bosLabel7.TabIndex = 574;
            this.bosLabel7.Text = "Cách sinh HSPB";
            // 
            // fld_btnAddFromPurchaseReceipt
            // 
            this.fld_btnAddFromPurchaseReceipt.BOSComment = null;
            this.fld_btnAddFromPurchaseReceipt.BOSDataMember = null;
            this.fld_btnAddFromPurchaseReceipt.BOSDataSource = null;
            this.fld_btnAddFromPurchaseReceipt.BOSDescription = null;
            this.fld_btnAddFromPurchaseReceipt.BOSError = null;
            this.fld_btnAddFromPurchaseReceipt.BOSFieldGroup = null;
            this.fld_btnAddFromPurchaseReceipt.BOSFieldRelation = null;
            this.fld_btnAddFromPurchaseReceipt.BOSPrivilege = null;
            this.fld_btnAddFromPurchaseReceipt.BOSPropertyName = null;
            this.fld_btnAddFromPurchaseReceipt.Location = new System.Drawing.Point(703, 90);
            this.fld_btnAddFromPurchaseReceipt.Name = "fld_btnAddFromPurchaseReceipt";
            this.fld_btnAddFromPurchaseReceipt.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddFromPurchaseReceipt, true);
            this.fld_btnAddFromPurchaseReceipt.Size = new System.Drawing.Size(150, 27);
            this.fld_btnAddFromPurchaseReceipt.TabIndex = 572;
            this.fld_btnAddFromPurchaseReceipt.Text = "Thêm từ NKMH";
            this.fld_btnAddFromPurchaseReceipt.Click += new System.EventHandler(this.fld_btnAddFromPurchaseReceipt_Click);
            // 
            // fld_lkeProductConversionProductType
            // 
            this.fld_lkeProductConversionProductType.BOSAllowAddNew = false;
            this.fld_lkeProductConversionProductType.BOSAllowDummy = true;
            this.fld_lkeProductConversionProductType.BOSComment = null;
            this.fld_lkeProductConversionProductType.BOSDataMember = "ICProductConversionProductType";
            this.fld_lkeProductConversionProductType.BOSDataSource = "ICProductConversions";
            this.fld_lkeProductConversionProductType.BOSDescription = null;
            this.fld_lkeProductConversionProductType.BOSError = null;
            this.fld_lkeProductConversionProductType.BOSFieldGroup = null;
            this.fld_lkeProductConversionProductType.BOSFieldParent = null;
            this.fld_lkeProductConversionProductType.BOSFieldRelation = null;
            this.fld_lkeProductConversionProductType.BOSPrivilege = null;
            this.fld_lkeProductConversionProductType.BOSPropertyName = "EditValue";
            this.fld_lkeProductConversionProductType.BOSSelectType = null;
            this.fld_lkeProductConversionProductType.BOSSelectTypeValue = null;
            this.fld_lkeProductConversionProductType.CurrentDisplayText = null;
            this.fld_lkeProductConversionProductType.Location = new System.Drawing.Point(456, 35);
            this.fld_lkeProductConversionProductType.MenuManager = this.screenToolbar;
            this.fld_lkeProductConversionProductType.Name = "fld_lkeProductConversionProductType";
            this.fld_lkeProductConversionProductType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeProductConversionProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeProductConversionProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductConversionProductType.Properties.ColumnName = null;
            this.fld_lkeProductConversionProductType.Properties.NullText = "";
            this.fld_lkeProductConversionProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeProductConversionProductType.Screen = null;
            this.fld_lkeProductConversionProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeProductConversionProductType.TabIndex = 570;
            this.fld_lkeProductConversionProductType.Tag = "DC";
            this.fld_lkeProductConversionProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeProductConversionProductType_CloseUp);
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
            this.bosLabel6.Location = new System.Drawing.Point(371, 39);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 571;
            this.bosLabel6.Text = "Loại hàng hóa";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ICProductConversionType";
            this.bosLookupEdit1.BOSDataSource = "ICProductConversions";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(703, 9);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 2;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.Validated += new System.EventHandler(this.bosLookupEdit1_Validated);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(624, 13);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(66, 13);
            this.bosLabel5.TabIndex = 568;
            this.bosLabel5.Text = "Loại chứng từ";
            // 
            // fld_tabTransferItems
            // 
            this.fld_tabTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabTransferItems.BOSComment = null;
            this.fld_tabTransferItems.BOSDataMember = null;
            this.fld_tabTransferItems.BOSDataSource = null;
            this.fld_tabTransferItems.BOSDescription = null;
            this.fld_tabTransferItems.BOSError = null;
            this.fld_tabTransferItems.BOSFieldGroup = null;
            this.fld_tabTransferItems.BOSFieldRelation = null;
            this.fld_tabTransferItems.BOSPrivilege = null;
            this.fld_tabTransferItems.BOSPropertyName = null;
            this.fld_tabTransferItems.Location = new System.Drawing.Point(8, 155);
            this.fld_tabTransferItems.Name = "fld_tabTransferItems";
            this.fld_tabTransferItems.Screen = null;
            this.fld_tabTransferItems.SelectedTabPage = this.fld_tabProductSource;
            this.ScreenHelper.SetShowHelp(this.fld_tabTransferItems, true);
            this.fld_tabTransferItems.Size = new System.Drawing.Size(1135, 548);
            this.fld_tabTransferItems.TabIndex = 566;
            this.fld_tabTransferItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductSource,
            this.fld_tabDocumentEntrys});
            // 
            // fld_tabProductSource
            // 
            this.fld_tabProductSource.Controls.Add(this.splitContainerControl1);
            this.fld_tabProductSource.Name = "fld_tabProductSource";
            this.ScreenHelper.SetShowHelp(this.fld_tabProductSource, true);
            this.fld_tabProductSource.Size = new System.Drawing.Size(1133, 523);
            this.fld_tabProductSource.Text = "Danh sách chuyển mã";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grpProductSource);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnCopyAllProduct);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnCopyProduct);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_grpProductTarget);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1133, 523);
            this.splitContainerControl1.SplitterPosition = 513;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // fld_grpProductSource
            // 
            this.fld_grpProductSource.Controls.Add(this.fld_dgcICProductConversionItems);
            this.fld_grpProductSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grpProductSource.Location = new System.Drawing.Point(0, 0);
            this.fld_grpProductSource.Name = "fld_grpProductSource";
            this.fld_grpProductSource.Size = new System.Drawing.Size(513, 523);
            this.fld_grpProductSource.TabIndex = 0;
            this.fld_grpProductSource.Text = "Danh sách mã gốc";
            // 
            // fld_dgcICProductConversionItems
            // 
            this.fld_dgcICProductConversionItems.AllowDrop = true;
            this.fld_dgcICProductConversionItems.BOSComment = "";
            this.fld_dgcICProductConversionItems.BOSDataMember = "";
            this.fld_dgcICProductConversionItems.BOSDataSource = "ICProductConversionItems";
            this.fld_dgcICProductConversionItems.BOSDescription = null;
            this.fld_dgcICProductConversionItems.BOSError = null;
            this.fld_dgcICProductConversionItems.BOSFieldGroup = "";
            this.fld_dgcICProductConversionItems.BOSFieldRelation = "";
            this.fld_dgcICProductConversionItems.BOSGridType = null;
            this.fld_dgcICProductConversionItems.BOSPrivilege = "";
            this.fld_dgcICProductConversionItems.BOSPropertyName = null;
            this.fld_dgcICProductConversionItems.CommodityType = "";
            this.fld_dgcICProductConversionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductConversionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductConversionItems.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductConversionItems.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICProductConversionItems.Name = "fld_dgcICProductConversionItems";
            this.fld_dgcICProductConversionItems.PrintReport = false;
            this.fld_dgcICProductConversionItems.Screen = null;
            this.fld_dgcICProductConversionItems.Size = new System.Drawing.Size(509, 498);
            this.fld_dgcICProductConversionItems.TabIndex = 2;
            this.fld_dgcICProductConversionItems.Tag = "DC";
            this.fld_dgcICProductConversionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICProductConversionItems;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 36);
            this.simpleButton1.TabIndex = 570;
            this.simpleButton1.Click += new System.EventHandler(this.fld_btnViewAllProduct_Click);
            // 
            // fld_btnCopyAllProduct
            // 
            this.fld_btnCopyAllProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fld_btnCopyAllProduct.ImageOptions.SvgImage")));
            this.fld_btnCopyAllProduct.Location = new System.Drawing.Point(1, 62);
            this.fld_btnCopyAllProduct.Name = "fld_btnCopyAllProduct";
            this.fld_btnCopyAllProduct.Size = new System.Drawing.Size(39, 36);
            this.fld_btnCopyAllProduct.TabIndex = 571;
            this.fld_btnCopyAllProduct.Text = ">>>>";
            this.fld_btnCopyAllProduct.Click += new System.EventHandler(this.fld_btnCopyAllProduct_Click);
            // 
            // fld_btnCopyProduct
            // 
            this.fld_btnCopyProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fld_btnCopyProduct.ImageOptions.SvgImage")));
            this.fld_btnCopyProduct.Location = new System.Drawing.Point(1, 20);
            this.fld_btnCopyProduct.Name = "fld_btnCopyProduct";
            this.fld_btnCopyProduct.Size = new System.Drawing.Size(39, 36);
            this.fld_btnCopyProduct.TabIndex = 570;
            this.fld_btnCopyProduct.Click += new System.EventHandler(this.fld_btnCopyProduct_Click);
            // 
            // fld_grpProductTarget
            // 
            this.fld_grpProductTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpProductTarget.Controls.Add(this.fld_dgcICProductConversionItemTargetsGridControl);
            this.fld_grpProductTarget.Location = new System.Drawing.Point(45, 0);
            this.fld_grpProductTarget.Name = "fld_grpProductTarget";
            this.fld_grpProductTarget.Size = new System.Drawing.Size(570, 523);
            this.fld_grpProductTarget.TabIndex = 1;
            this.fld_grpProductTarget.Text = "Danh sách mã đích";
            // 
            // fld_dgcICProductConversionItemTargetsGridControl
            // 
            this.fld_dgcICProductConversionItemTargetsGridControl.AllowDrop = true;
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSComment = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSDataMember = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSDataSource = "ICProductConversionItems";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSDescription = null;
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSError = null;
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSFieldGroup = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSFieldRelation = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSGridType = null;
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSPrivilege = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductConversionItemTargetsGridControl.CommodityType = "";
            this.fld_dgcICProductConversionItemTargetsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductConversionItemTargetsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductConversionItemTargetsGridControl.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductConversionItemTargetsGridControl.MainView = this.gridView1;
            this.fld_dgcICProductConversionItemTargetsGridControl.Name = "fld_dgcICProductConversionItemTargetsGridControl";
            this.fld_dgcICProductConversionItemTargetsGridControl.PrintReport = false;
            this.fld_dgcICProductConversionItemTargetsGridControl.Screen = null;
            this.fld_dgcICProductConversionItemTargetsGridControl.Size = new System.Drawing.Size(566, 498);
            this.fld_dgcICProductConversionItemTargetsGridControl.TabIndex = 392;
            this.fld_dgcICProductConversionItemTargetsGridControl.Tag = "DC";
            this.fld_dgcICProductConversionItemTargetsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICProductConversionItemTargetsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabDocumentEntrys
            // 
            this.fld_tabDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabDocumentEntrys.Name = "fld_tabDocumentEntrys";
            this.fld_tabDocumentEntrys.Size = new System.Drawing.Size(1119, 516);
            this.fld_tabDocumentEntrys.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1119, 516);
            this.fld_dgcACDocumentEntrys.TabIndex = 2;
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
            // fld_lkeFK_ICFromStockID
            // 
            this.fld_lkeFK_ICFromStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID.BOSComment = "";
            this.fld_lkeFK_ICFromStockID.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_ICFromStockID.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID.BOSError = "";
            this.fld_lkeFK_ICFromStockID.BOSFieldGroup = "";
            this.fld_lkeFK_ICFromStockID.BOSFieldParent = "";
            this.fld_lkeFK_ICFromStockID.BOSFieldRelation = "";
            this.fld_lkeFK_ICFromStockID.BOSPrivilege = "";
            this.fld_lkeFK_ICFromStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID.BOSSelectType = "";
            this.fld_lkeFK_ICFromStockID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICFromStockID.CurrentDisplayText = "";
            this.fld_lkeFK_ICFromStockID.Location = new System.Drawing.Point(207, 62);
            this.fld_lkeFK_ICFromStockID.Name = "fld_lkeFK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICFromStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID.Properties.NullText = "";
            this.fld_lkeFK_ICFromStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID.Screen = null;
            this.fld_lkeFK_ICFromStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID.TabIndex = 5;
            this.fld_lkeFK_ICFromStockID.Tag = "DC";
            this.fld_lkeFK_ICFromStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICSourceStockID_CloseUp);
            // 
            // fld_lkeFK_ICToStockID
            // 
            this.fld_lkeFK_ICToStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID.BOSComment = "";
            this.fld_lkeFK_ICToStockID.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_ICToStockID.BOSDescription = null;
            this.fld_lkeFK_ICToStockID.BOSError = "";
            this.fld_lkeFK_ICToStockID.BOSFieldGroup = "";
            this.fld_lkeFK_ICToStockID.BOSFieldParent = "";
            this.fld_lkeFK_ICToStockID.BOSFieldRelation = "";
            this.fld_lkeFK_ICToStockID.BOSPrivilege = "";
            this.fld_lkeFK_ICToStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID.BOSSelectType = "";
            this.fld_lkeFK_ICToStockID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICToStockID.CurrentDisplayText = "";
            this.fld_lkeFK_ICToStockID.Location = new System.Drawing.Point(456, 62);
            this.fld_lkeFK_ICToStockID.Name = "fld_lkeFK_ICToStockID";
            this.fld_lkeFK_ICToStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICToStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID.Properties.NullText = "";
            this.fld_lkeFK_ICToStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID.Screen = null;
            this.fld_lkeFK_ICToStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID.TabIndex = 6;
            this.fld_lkeFK_ICToStockID.Tag = "DC";
            this.fld_lkeFK_ICToStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockTargetID_CloseUp);
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(371, 66);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 565;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Đến kho";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(134, 66);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 564;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Từ kho";
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
            this.bosLabel2.Location = new System.Drawing.Point(134, 39);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(65, 13);
            this.bosLabel2.TabIndex = 561;
            this.bosLabel2.Text = "Tên chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ICProductConversionName";
            this.bosTextBox1.BOSDataSource = "ICProductConversions";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(207, 35);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 3;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_medICProductConversionDesc
            // 
            this.fld_medICProductConversionDesc.BOSComment = "";
            this.fld_medICProductConversionDesc.BOSDataMember = "ICProductConversionDesc";
            this.fld_medICProductConversionDesc.BOSDataSource = "ICProductConversions";
            this.fld_medICProductConversionDesc.BOSDescription = null;
            this.fld_medICProductConversionDesc.BOSError = "";
            this.fld_medICProductConversionDesc.BOSFieldGroup = "";
            this.fld_medICProductConversionDesc.BOSFieldRelation = "";
            this.fld_medICProductConversionDesc.BOSPrivilege = "";
            this.fld_medICProductConversionDesc.BOSPropertyName = "Text";
            this.fld_medICProductConversionDesc.Location = new System.Drawing.Point(207, 88);
            this.fld_medICProductConversionDesc.Name = "fld_medICProductConversionDesc";
            this.fld_medICProductConversionDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductConversionDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductConversionDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductConversionDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductConversionDesc.Screen = null;
            this.fld_medICProductConversionDesc.Size = new System.Drawing.Size(399, 49);
            this.fld_medICProductConversionDesc.TabIndex = 7;
            this.fld_medICProductConversionDesc.Tag = "DC";
            // 
            // fld_pteICProductConversionEmployeePicture
            // 
            this.fld_pteICProductConversionEmployeePicture.BOSComment = "";
            this.fld_pteICProductConversionEmployeePicture.BOSDataMember = "ICProductConversionEmployeePicture";
            this.fld_pteICProductConversionEmployeePicture.BOSDataSource = "ICProductConversions";
            this.fld_pteICProductConversionEmployeePicture.BOSDescription = null;
            this.fld_pteICProductConversionEmployeePicture.BOSError = "";
            this.fld_pteICProductConversionEmployeePicture.BOSFieldGroup = "";
            this.fld_pteICProductConversionEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICProductConversionEmployeePicture.BOSPrivilege = "";
            this.fld_pteICProductConversionEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICProductConversionEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICProductConversionEmployeePicture.FileName = null;
            this.fld_pteICProductConversionEmployeePicture.FilePath = null;
            this.fld_pteICProductConversionEmployeePicture.Location = new System.Drawing.Point(8, 9);
            this.fld_pteICProductConversionEmployeePicture.Name = "fld_pteICProductConversionEmployeePicture";
            this.fld_pteICProductConversionEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICProductConversionEmployeePicture.Screen = null;
            this.fld_pteICProductConversionEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICProductConversionEmployeePicture.TabIndex = 557;
            this.fld_pteICProductConversionEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICProductConversions";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(8, 111);
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
            this.fld_lkeFK_HREmployeeID.TabIndex = 558;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(134, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 556;
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_lkeICProductConversionStatus
            // 
            this.fld_lkeICProductConversionStatus.BOSAllowAddNew = false;
            this.fld_lkeICProductConversionStatus.BOSAllowDummy = false;
            this.fld_lkeICProductConversionStatus.BOSComment = null;
            this.fld_lkeICProductConversionStatus.BOSDataMember = "ICProductConversionStatus";
            this.fld_lkeICProductConversionStatus.BOSDataSource = "ICProductConversions";
            this.fld_lkeICProductConversionStatus.BOSDescription = null;
            this.fld_lkeICProductConversionStatus.BOSError = null;
            this.fld_lkeICProductConversionStatus.BOSFieldGroup = null;
            this.fld_lkeICProductConversionStatus.BOSFieldParent = null;
            this.fld_lkeICProductConversionStatus.BOSFieldRelation = null;
            this.fld_lkeICProductConversionStatus.BOSPrivilege = null;
            this.fld_lkeICProductConversionStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICProductConversionStatus.BOSSelectType = null;
            this.fld_lkeICProductConversionStatus.BOSSelectTypeValue = null;
            this.fld_lkeICProductConversionStatus.CurrentDisplayText = null;
            this.fld_lkeICProductConversionStatus.Location = new System.Drawing.Point(703, 35);
            this.fld_lkeICProductConversionStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICProductConversionStatus.Name = "fld_lkeICProductConversionStatus";
            this.fld_lkeICProductConversionStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICProductConversionStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductConversionStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductConversionStatus.Properties.ColumnName = null;
            this.fld_lkeICProductConversionStatus.Properties.NullText = "";
            this.fld_lkeICProductConversionStatus.Properties.ReadOnly = true;
            this.fld_lkeICProductConversionStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductConversionStatus.Screen = null;
            this.fld_lkeICProductConversionStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductConversionStatus.TabIndex = 4;
            this.fld_lkeICProductConversionStatus.Tag = "DC";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(624, 39);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 17;
            this.fld_lblLabel25.Text = "Trạng thái";
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
            this.bosLabel4.Location = new System.Drawing.Point(371, 13);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Ngày chứng từ";
            // 
            // fld_dteICProductConversionDate
            // 
            this.fld_dteICProductConversionDate.BOSComment = null;
            this.fld_dteICProductConversionDate.BOSDataMember = "ICProductConversionDate";
            this.fld_dteICProductConversionDate.BOSDataSource = "ICProductConversions";
            this.fld_dteICProductConversionDate.BOSDescription = null;
            this.fld_dteICProductConversionDate.BOSError = null;
            this.fld_dteICProductConversionDate.BOSFieldGroup = null;
            this.fld_dteICProductConversionDate.BOSFieldRelation = null;
            this.fld_dteICProductConversionDate.BOSPrivilege = null;
            this.fld_dteICProductConversionDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductConversionDate.EditValue = null;
            this.fld_dteICProductConversionDate.Location = new System.Drawing.Point(456, 9);
            this.fld_dteICProductConversionDate.Name = "fld_dteICProductConversionDate";
            this.fld_dteICProductConversionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductConversionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductConversionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductConversionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductConversionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductConversionDate.Screen = null;
            this.fld_dteICProductConversionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICProductConversionDate.TabIndex = 1;
            this.fld_dteICProductConversionDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(134, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICProductConversionNo
            // 
            this.fld_txtICProductConversionNo.BOSComment = "";
            this.fld_txtICProductConversionNo.BOSDataMember = "ICProductConversionNo";
            this.fld_txtICProductConversionNo.BOSDataSource = "ICProductConversions";
            this.fld_txtICProductConversionNo.BOSDescription = null;
            this.fld_txtICProductConversionNo.BOSError = null;
            this.fld_txtICProductConversionNo.BOSFieldGroup = "";
            this.fld_txtICProductConversionNo.BOSFieldRelation = "";
            this.fld_txtICProductConversionNo.BOSPrivilege = "";
            this.fld_txtICProductConversionNo.BOSPropertyName = "Text";
            this.fld_txtICProductConversionNo.EditValue = "";
            this.fld_txtICProductConversionNo.Location = new System.Drawing.Point(207, 9);
            this.fld_txtICProductConversionNo.Name = "fld_txtICProductConversionNo";
            this.fld_txtICProductConversionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductConversionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductConversionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductConversionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductConversionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductConversionNo.Properties.ReadOnly = true;
            this.fld_txtICProductConversionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductConversionNo.Screen = null;
            this.fld_txtICProductConversionNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductConversionNo.TabIndex = 0;
            this.fld_txtICProductConversionNo.Tag = "DC";
            // 
            // DMPCV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1146, 706);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPCV100.IconOptions.Icon")));
            this.Name = "DMPCV100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGenerationHSPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductConversionProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).EndInit();
            this.fld_tabTransferItems.ResumeLayout(false);
            this.fld_tabProductSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductSource)).EndInit();
            this.fld_grpProductSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductTarget)).EndInit();
            this.fld_grpProductTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversionItemTargetsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductConversionDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductConversionEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductConversionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductConversionNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductConversionNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteICProductConversionDate;
        private BOSComponent.BOSLookupEdit fld_lkeICProductConversionStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSPictureEdit fld_pteICProductConversionEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSMemoEdit fld_medICProductConversionDesc;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private ICProductConversionItemsGridControl fld_dgcICProductConversionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private BOSComponent.BOSTabControl fld_tabTransferItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductSource;
        private ICProductConversionItemTargetsGridControl fld_dgcICProductConversionItemTargetsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage fld_tabDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl fld_grpProductSource;
        private DevExpress.XtraEditors.GroupControl fld_grpProductTarget;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel5;
        private DevExpress.XtraEditors.SimpleButton fld_btnCopyProduct;
        private DevExpress.XtraEditors.SimpleButton fld_btnCopyAllProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private BOSComponent.BOSLookupEdit fld_lkeProductConversionProductType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnAddFromPurchaseReceipt;
        private BOSComponent.BOSLookupEdit fld_lkeGenerationHSPB;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnShipment;
        private BOSComponent.BOSButton fld_btnGroupPackage;
        private BOSComponent.BOSButton fld_btnClearPackage;
        private BOSComponent.BOSButton btnGenPackage;
    }
}
