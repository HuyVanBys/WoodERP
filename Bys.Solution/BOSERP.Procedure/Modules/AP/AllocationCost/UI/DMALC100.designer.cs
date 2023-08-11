using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AllocationCost.UI
{
	/// <summary>
	/// Summary description for DMALC100
	/// </summary>
	partial class DMALC100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPAllocationCostType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPAllocationCostCriterion = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPAllocationCostDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteAPInvoiceInEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnCalculate = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteReceiptToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteReceiptFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnFindReceipt = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPAllocationCostItems = new BOSERP.Modules.AllocationCost.APAllocationCostItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_gLumberOutSourcing = new BOSComponent.BOSGroupControl(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_btnFindInvoiceIn = new BOSComponent.BOSButton(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPAllocationCostItemInvoiceIns = new BOSERP.Modules.AllocationCost.APAllocationCostItemInvoiceInsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnFindShipment = new BOSComponent.BOSButton(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPAllocationCostItemShipments = new BOSERP.Modules.AllocationCost.APAllocationCostItemShipmentsGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_gImport = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnRefresh = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPAllocationCostItemInvoices = new BOSERP.Modules.AllocationCost.APAllocationCostItemInvoicesGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPAllocationCostStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPAllocationCostDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPAllocationCostNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostCriterion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPAllocationCostDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gLumberOutSourcing)).BeginInit();
            this.fld_gLumberOutSourcing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemInvoiceIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemShipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gImport)).BeginInit();
            this.fld_gImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPAllocationCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeAPAllocationCostType);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APPurchaseOrderID);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel34);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_lkeAPAllocationCostCriterion);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_medAPAllocationCostDesc);
            this.bosPanel1.Controls.Add(this.fld_pteAPInvoiceInEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.statusStrip1);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_lkeAPAllocationCostStatus);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteAPAllocationCostDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel35);
            this.bosPanel1.Controls.Add(this.fld_txtAPAllocationCostNo);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1110, 577);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = string.Empty;
            this.bosLabel10.BOSDataMember = string.Empty;
            this.bosLabel10.BOSDataSource = string.Empty;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = string.Empty;
            this.bosLabel10.BOSFieldRelation = string.Empty;
            this.bosLabel10.BOSPrivilege = string.Empty;
            this.bosLabel10.BOSPropertyName = string.Empty;
            this.bosLabel10.Location = new System.Drawing.Point(380, 116);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(19, 13);
            this.bosLabel10.TabIndex = 845;
            this.bosLabel10.Tag = string.Empty;
            this.bosLabel10.Text = "Loại";
            // 
            // fld_lkeAPAllocationCostType
            // 
            this.fld_lkeAPAllocationCostType.BOSAllowAddNew = false;
            this.fld_lkeAPAllocationCostType.BOSAllowDummy = false;
            this.fld_lkeAPAllocationCostType.BOSComment = null;
            this.fld_lkeAPAllocationCostType.BOSDataMember = "APAllocationCostType";
            this.fld_lkeAPAllocationCostType.BOSDataSource = "APAllocationCosts";
            this.fld_lkeAPAllocationCostType.BOSDescription = null;
            this.fld_lkeAPAllocationCostType.BOSError = null;
            this.fld_lkeAPAllocationCostType.BOSFieldGroup = null;
            this.fld_lkeAPAllocationCostType.BOSFieldParent = null;
            this.fld_lkeAPAllocationCostType.BOSFieldRelation = null;
            this.fld_lkeAPAllocationCostType.BOSPrivilege = null;
            this.fld_lkeAPAllocationCostType.BOSPropertyName = "EditValue";
            this.fld_lkeAPAllocationCostType.BOSSelectType = null;
            this.fld_lkeAPAllocationCostType.BOSSelectTypeValue = null;
            this.fld_lkeAPAllocationCostType.CurrentDisplayText = null;
            this.fld_lkeAPAllocationCostType.Location = new System.Drawing.Point(492, 113);
            this.fld_lkeAPAllocationCostType.MenuManager = this.screenToolbar;
            this.fld_lkeAPAllocationCostType.Name = "fld_lkeAPAllocationCostType";
            this.fld_lkeAPAllocationCostType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPAllocationCostType.Properties.NullText = string.Empty;
            this.fld_lkeAPAllocationCostType.Properties.ReadOnly = true;
            this.fld_lkeAPAllocationCostType.Screen = null;
            this.fld_lkeAPAllocationCostType.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPAllocationCostType.TabIndex = 844;
            this.fld_lkeAPAllocationCostType.Tag = "DC";
            this.fld_lkeAPAllocationCostType.EditValueChanged += new System.EventHandler(this.fld_lkeAPAllocationCostType_EditValueChanged);
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(115, 117);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(70, 13);
            this.bosLabel9.TabIndex = 843;
            this.bosLabel9.Text = "Đơn mua hàng";
            // 
            // fld_lkeFK_APPurchaseOrderID
            // 
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_APPurchaseOrderID.BOSComment = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSDataMember = "FK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_APPurchaseOrderID.BOSDescription = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSError = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldParent = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSPrivilege = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectType = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APPurchaseOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_APPurchaseOrderID.Location = new System.Drawing.Point(201, 114);
            this.fld_lkeFK_APPurchaseOrderID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APPurchaseOrderID.Name = "fld_lkeFK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchaseOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseOrderNo", "DMH")});
            this.fld_lkeFK_APPurchaseOrderID.Properties.DisplayMember = "APPurchaseOrderNo";
            this.fld_lkeFK_APPurchaseOrderID.Properties.ValueMember = "APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Screen = null;
            this.fld_lkeFK_APPurchaseOrderID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_APPurchaseOrderID.TabIndex = 842;
            this.fld_lkeFK_APPurchaseOrderID.Tag = "DC";
            this.fld_lkeFK_APPurchaseOrderID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_APPurchaseOrderID_EditValueChanged);
            this.fld_lkeFK_APPurchaseOrderID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APPurchaseOrderID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(380, 90);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(52, 13);
            this.bosLabel8.TabIndex = 841;
            this.bosLabel8.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(492, 87);
            this.fld_lkeFK_MMOperationID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 840;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(115, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(17, 13);
            this.bosLabel4.TabIndex = 839;
            this.bosLabel4.Text = "LSX";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "APAllocationCosts";
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
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(201, 87);
            this.fld_lkeFK_MMBatchProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 838;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            // 
            // bosLabel34
            // 
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(380, 38);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(31, 13);
            this.bosLabel34.TabIndex = 837;
            this.bosLabel34.Text = "Đơn vị";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_BRBranchID";
            this.bosLookupEdit1.BOSDataSource = "APAllocationCosts";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(492, 35);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Đơn vị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchCompanyName", "Công ty")});
            this.bosLookupEdit1.Properties.DisplayMember = "BRBranchName";
            this.bosLookupEdit1.Properties.ValueMember = "BRBranchID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(133, 20);
            this.bosLookupEdit1.TabIndex = 836;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_lkeAPAllocationCostCriterion
            // 
            this.fld_lkeAPAllocationCostCriterion.BOSAllowAddNew = false;
            this.fld_lkeAPAllocationCostCriterion.BOSAllowDummy = false;
            this.fld_lkeAPAllocationCostCriterion.BOSComment = null;
            this.fld_lkeAPAllocationCostCriterion.BOSDataMember = "APAllocationCostCriterion";
            this.fld_lkeAPAllocationCostCriterion.BOSDataSource = "APAllocationCosts";
            this.fld_lkeAPAllocationCostCriterion.BOSDescription = null;
            this.fld_lkeAPAllocationCostCriterion.BOSError = null;
            this.fld_lkeAPAllocationCostCriterion.BOSFieldGroup = null;
            this.fld_lkeAPAllocationCostCriterion.BOSFieldParent = null;
            this.fld_lkeAPAllocationCostCriterion.BOSFieldRelation = null;
            this.fld_lkeAPAllocationCostCriterion.BOSPrivilege = null;
            this.fld_lkeAPAllocationCostCriterion.BOSPropertyName = "EditValue";
            this.fld_lkeAPAllocationCostCriterion.BOSSelectType = null;
            this.fld_lkeAPAllocationCostCriterion.BOSSelectTypeValue = null;
            this.fld_lkeAPAllocationCostCriterion.CurrentDisplayText = null;
            this.fld_lkeAPAllocationCostCriterion.Location = new System.Drawing.Point(492, 61);
            this.fld_lkeAPAllocationCostCriterion.MenuManager = this.screenToolbar;
            this.fld_lkeAPAllocationCostCriterion.Name = "fld_lkeAPAllocationCostCriterion";
            this.fld_lkeAPAllocationCostCriterion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeAPAllocationCostCriterion.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPAllocationCostCriterion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPAllocationCostCriterion.Properties.NullText = string.Empty;
            this.fld_lkeAPAllocationCostCriterion.Screen = null;
            this.fld_lkeAPAllocationCostCriterion.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPAllocationCostCriterion.TabIndex = 7;
            this.fld_lkeAPAllocationCostCriterion.Tag = "DC";
            this.fld_lkeAPAllocationCostCriterion.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPAllocationCostCriterion_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = string.Empty;
            this.bosLabel2.Location = new System.Drawing.Point(380, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(87, 13);
            this.bosLabel2.TabIndex = 676;
            this.bosLabel2.Tag = string.Empty;
            this.bosLabel2.Text = "Tiêu thức phân bổ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = string.Empty;
            this.bosLabel5.BOSDataMember = string.Empty;
            this.bosLabel5.BOSDataSource = string.Empty;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = string.Empty;
            this.bosLabel5.BOSFieldRelation = string.Empty;
            this.bosLabel5.BOSPrivilege = string.Empty;
            this.bosLabel5.BOSPropertyName = string.Empty;
            this.bosLabel5.Location = new System.Drawing.Point(114, 143);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 674;
            this.bosLabel5.Tag = string.Empty;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_medAPAllocationCostDesc
            // 
            this.fld_medAPAllocationCostDesc.BOSComment = string.Empty;
            this.fld_medAPAllocationCostDesc.BOSDataMember = "APAllocationCostDesc";
            this.fld_medAPAllocationCostDesc.BOSDataSource = "APAllocationCosts";
            this.fld_medAPAllocationCostDesc.BOSDescription = null;
            this.fld_medAPAllocationCostDesc.BOSError = null;
            this.fld_medAPAllocationCostDesc.BOSFieldGroup = string.Empty;
            this.fld_medAPAllocationCostDesc.BOSFieldRelation = string.Empty;
            this.fld_medAPAllocationCostDesc.BOSPrivilege = string.Empty;
            this.fld_medAPAllocationCostDesc.BOSPropertyName = "Text";
            this.fld_medAPAllocationCostDesc.EditValue = string.Empty;
            this.fld_medAPAllocationCostDesc.Location = new System.Drawing.Point(201, 140);
            this.fld_medAPAllocationCostDesc.Name = "fld_medAPAllocationCostDesc";
            this.fld_medAPAllocationCostDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPAllocationCostDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPAllocationCostDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPAllocationCostDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPAllocationCostDesc.Screen = null;
            this.fld_medAPAllocationCostDesc.Size = new System.Drawing.Size(424, 42);
            this.fld_medAPAllocationCostDesc.TabIndex = 8;
            this.fld_medAPAllocationCostDesc.Tag = "DC";
            // 
            // fld_pteAPInvoiceInEmployeePicture
            // 
            this.fld_pteAPInvoiceInEmployeePicture.BOSComment = string.Empty;
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataMember = "APInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataSource = "APInvoiceIns";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDescription = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSError = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldGroup = string.Empty;
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldRelation = string.Empty;
            this.fld_pteAPInvoiceInEmployeePicture.BOSPrivilege = string.Empty;
            this.fld_pteAPInvoiceInEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPInvoiceInEmployeePicture.EditValue = string.Empty;
            this.fld_pteAPInvoiceInEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteAPInvoiceInEmployeePicture.Name = "fld_pteAPInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPInvoiceInEmployeePicture.Screen = null;
            this.fld_pteAPInvoiceInEmployeePicture.Size = new System.Drawing.Size(99, 90);
            this.fld_pteAPInvoiceInEmployeePicture.TabIndex = 0;
            this.fld_pteAPInvoiceInEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = string.Empty;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 98);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = string.Empty;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 175);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1104, 399);
            this.bosTabControl1.TabIndex = 9;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainer1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1097, 370);
            this.xtraTabPage1.Text = "Chi tiết";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bosGroupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fld_gLumberOutSourcing);
            this.splitContainer1.Panel2.Controls.Add(this.fld_gImport);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 370);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 632;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_btnCalculate);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_dteReceiptToDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_dteReceiptFromDate);
            this.bosGroupControl1.Controls.Add(this.fld_btnFindReceipt);
            this.bosGroupControl1.Controls.Add(this.fld_dgcAPAllocationCostItems);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(635, 370);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Nhập kho mua hàng";
            // 
            // fld_btnCalculate
            // 
            this.fld_btnCalculate.BOSComment = null;
            this.fld_btnCalculate.BOSDataMember = null;
            this.fld_btnCalculate.BOSDataSource = null;
            this.fld_btnCalculate.BOSDescription = null;
            this.fld_btnCalculate.BOSError = null;
            this.fld_btnCalculate.BOSFieldGroup = null;
            this.fld_btnCalculate.BOSFieldRelation = null;
            this.fld_btnCalculate.BOSPrivilege = null;
            this.fld_btnCalculate.BOSPropertyName = null;
            this.fld_btnCalculate.Location = new System.Drawing.Point(512, 25);
            this.fld_btnCalculate.Name = "fld_btnCalculate";
            this.fld_btnCalculate.Screen = null;
            this.fld_btnCalculate.Size = new System.Drawing.Size(108, 27);
            this.fld_btnCalculate.TabIndex = 7;
            this.fld_btnCalculate.Text = "Tính chi phí";
            this.fld_btnCalculate.Click += new System.EventHandler(this.fld_btnCalculate_Click);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = string.Empty;
            this.bosLabel6.BOSDataMember = string.Empty;
            this.bosLabel6.BOSDataSource = string.Empty;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = string.Empty;
            this.bosLabel6.BOSFieldRelation = string.Empty;
            this.bosLabel6.BOSPrivilege = string.Empty;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(213, 32);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Tag = string.Empty;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_dteReceiptToDate
            // 
            this.fld_dteReceiptToDate.BOSComment = string.Empty;
            this.fld_dteReceiptToDate.BOSDataMember = string.Empty;
            this.fld_dteReceiptToDate.BOSDataSource = string.Empty;
            this.fld_dteReceiptToDate.BOSDescription = null;
            this.fld_dteReceiptToDate.BOSError = null;
            this.fld_dteReceiptToDate.BOSFieldGroup = string.Empty;
            this.fld_dteReceiptToDate.BOSFieldRelation = string.Empty;
            this.fld_dteReceiptToDate.BOSPrivilege = string.Empty;
            this.fld_dteReceiptToDate.BOSPropertyName = "EditValue";
            this.fld_dteReceiptToDate.EditValue = null;
            this.fld_dteReceiptToDate.Location = new System.Drawing.Point(266, 29);
            this.fld_dteReceiptToDate.Name = "fld_dteReceiptToDate";
            this.fld_dteReceiptToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteReceiptToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteReceiptToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteReceiptToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteReceiptToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteReceiptToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteReceiptToDate.Screen = null;
            this.fld_dteReceiptToDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteReceiptToDate.TabIndex = 1;
            this.fld_dteReceiptToDate.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(7, 32);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Từ ngày";
            // 
            // fld_dteReceiptFromDate
            // 
            this.fld_dteReceiptFromDate.BOSComment = string.Empty;
            this.fld_dteReceiptFromDate.BOSDataMember = string.Empty;
            this.fld_dteReceiptFromDate.BOSDataSource = string.Empty;
            this.fld_dteReceiptFromDate.BOSDescription = null;
            this.fld_dteReceiptFromDate.BOSError = null;
            this.fld_dteReceiptFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteReceiptFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteReceiptFromDate.BOSPrivilege = string.Empty;
            this.fld_dteReceiptFromDate.BOSPropertyName = "EditValue";
            this.fld_dteReceiptFromDate.EditValue = null;
            this.fld_dteReceiptFromDate.Location = new System.Drawing.Point(53, 29);
            this.fld_dteReceiptFromDate.Name = "fld_dteReceiptFromDate";
            this.fld_dteReceiptFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteReceiptFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteReceiptFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteReceiptFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteReceiptFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteReceiptFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteReceiptFromDate.Screen = null;
            this.fld_dteReceiptFromDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteReceiptFromDate.TabIndex = 0;
            this.fld_dteReceiptFromDate.Tag = "DC";
            // 
            // fld_btnFindReceipt
            // 
            this.fld_btnFindReceipt.BOSComment = null;
            this.fld_btnFindReceipt.BOSDataMember = null;
            this.fld_btnFindReceipt.BOSDataSource = null;
            this.fld_btnFindReceipt.BOSDescription = null;
            this.fld_btnFindReceipt.BOSError = null;
            this.fld_btnFindReceipt.BOSFieldGroup = null;
            this.fld_btnFindReceipt.BOSFieldRelation = null;
            this.fld_btnFindReceipt.BOSPrivilege = null;
            this.fld_btnFindReceipt.BOSPropertyName = null;
            this.fld_btnFindReceipt.Image = global::BOSERP.Procedure.Properties.Resources.View;
            this.fld_btnFindReceipt.Location = new System.Drawing.Point(405, 25);
            this.fld_btnFindReceipt.Name = "fld_btnFindReceipt";
            this.fld_btnFindReceipt.Screen = null;
            this.fld_btnFindReceipt.Size = new System.Drawing.Size(101, 27);
            this.fld_btnFindReceipt.TabIndex = 2;
            this.fld_btnFindReceipt.Text = "Tìm nhập kho";
            this.fld_btnFindReceipt.Click += new System.EventHandler(this.fld_btnFindReceipt_Click);
            // 
            // fld_dgcAPAllocationCostItems
            // 
            this.fld_dgcAPAllocationCostItems.AllowDrop = true;
            this.fld_dgcAPAllocationCostItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPAllocationCostItems.BOSComment = null;
            this.fld_dgcAPAllocationCostItems.BOSDataMember = null;
            this.fld_dgcAPAllocationCostItems.BOSDataSource = "APAllocationCostItems";
            this.fld_dgcAPAllocationCostItems.BOSDescription = null;
            this.fld_dgcAPAllocationCostItems.BOSError = null;
            this.fld_dgcAPAllocationCostItems.BOSFieldGroup = null;
            this.fld_dgcAPAllocationCostItems.BOSFieldRelation = null;
            this.fld_dgcAPAllocationCostItems.BOSGridType = null;
            this.fld_dgcAPAllocationCostItems.BOSPrivilege = null;
            this.fld_dgcAPAllocationCostItems.BOSPropertyName = null;
            this.fld_dgcAPAllocationCostItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPAllocationCostItems.Location = new System.Drawing.Point(2, 59);
            this.fld_dgcAPAllocationCostItems.MainView = this.gridView2;
            this.fld_dgcAPAllocationCostItems.Name = "fld_dgcAPAllocationCostItems";
            this.fld_dgcAPAllocationCostItems.PrintReport = false;
            this.fld_dgcAPAllocationCostItems.Screen = null;
            this.fld_dgcAPAllocationCostItems.Size = new System.Drawing.Size(631, 308);
            this.fld_dgcAPAllocationCostItems.TabIndex = 3;
            this.fld_dgcAPAllocationCostItems.Tag = "DC";
            this.fld_dgcAPAllocationCostItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcAPAllocationCostItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_gLumberOutSourcing
            // 
            this.fld_gLumberOutSourcing.BOSComment = null;
            this.fld_gLumberOutSourcing.BOSDataMember = null;
            this.fld_gLumberOutSourcing.BOSDataSource = null;
            this.fld_gLumberOutSourcing.BOSDescription = null;
            this.fld_gLumberOutSourcing.BOSError = null;
            this.fld_gLumberOutSourcing.BOSFieldGroup = null;
            this.fld_gLumberOutSourcing.BOSFieldRelation = null;
            this.fld_gLumberOutSourcing.BOSPrivilege = null;
            this.fld_gLumberOutSourcing.BOSPropertyName = null;
            this.fld_gLumberOutSourcing.Controls.Add(this.splitContainerControl1);
            this.fld_gLumberOutSourcing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_gLumberOutSourcing.Location = new System.Drawing.Point(0, 0);
            this.fld_gLumberOutSourcing.Name = "fld_gLumberOutSourcing";
            this.fld_gLumberOutSourcing.Screen = null;
            this.fld_gLumberOutSourcing.Size = new System.Drawing.Size(458, 370);
            this.fld_gLumberOutSourcing.TabIndex = 1;
            this.fld_gLumberOutSourcing.Text = "Chi phí";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 22);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_btnFindInvoiceIn);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosLabel11);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcAPAllocationCostItemInvoiceIns);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnFindShipment);
            this.splitContainerControl1.Panel2.Controls.Add(this.bosLabel12);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_dgcAPAllocationCostItemShipments);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(454, 346);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_btnFindInvoiceIn
            // 
            this.fld_btnFindInvoiceIn.BOSComment = null;
            this.fld_btnFindInvoiceIn.BOSDataMember = null;
            this.fld_btnFindInvoiceIn.BOSDataSource = null;
            this.fld_btnFindInvoiceIn.BOSDescription = null;
            this.fld_btnFindInvoiceIn.BOSError = null;
            this.fld_btnFindInvoiceIn.BOSFieldGroup = null;
            this.fld_btnFindInvoiceIn.BOSFieldRelation = null;
            this.fld_btnFindInvoiceIn.BOSPrivilege = null;
            this.fld_btnFindInvoiceIn.BOSPropertyName = null;
            this.fld_btnFindInvoiceIn.Image = global::BOSERP.Procedure.Properties.Resources.View;
            this.fld_btnFindInvoiceIn.Location = new System.Drawing.Point(115, 4);
            this.fld_btnFindInvoiceIn.Name = "fld_btnFindInvoiceIn";
            this.fld_btnFindInvoiceIn.Screen = null;
            this.fld_btnFindInvoiceIn.Size = new System.Drawing.Size(101, 27);
            this.fld_btnFindInvoiceIn.TabIndex = 4;
            this.fld_btnFindInvoiceIn.Text = "Tìm hóa đơn";
            this.fld_btnFindInvoiceIn.Click += new System.EventHandler(this.fld_btnFindInvoiceIn_Click);
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(4, 10);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(105, 13);
            this.bosLabel11.TabIndex = 3;
            this.bosLabel11.Text = "Hóa đơn mua hàng";
            // 
            // fld_dgcAPAllocationCostItemInvoiceIns
            // 
            this.fld_dgcAPAllocationCostItemInvoiceIns.AllowDrop = true;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSComment = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSDataMember = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSDataSource = "APAllocationCostItemInvoiceIns";
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSDescription = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSError = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSFieldGroup = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSFieldRelation = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSGridType = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSPrivilege = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.BOSPropertyName = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPAllocationCostItemInvoiceIns.Location = new System.Drawing.Point(4, 37);
            this.fld_dgcAPAllocationCostItemInvoiceIns.MainView = this.gridView4;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Name = "fld_dgcAPAllocationCostItemInvoiceIns";
            this.fld_dgcAPAllocationCostItemInvoiceIns.PrintReport = false;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Screen = null;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Size = new System.Drawing.Size(247, 307);
            this.fld_dgcAPAllocationCostItemInvoiceIns.TabIndex = 2;
            this.fld_dgcAPAllocationCostItemInvoiceIns.Tag = "DC";
            this.fld_dgcAPAllocationCostItemInvoiceIns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcAPAllocationCostItemInvoiceIns;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // fld_btnFindShipment
            // 
            this.fld_btnFindShipment.BOSComment = null;
            this.fld_btnFindShipment.BOSDataMember = null;
            this.fld_btnFindShipment.BOSDataSource = null;
            this.fld_btnFindShipment.BOSDescription = null;
            this.fld_btnFindShipment.BOSError = null;
            this.fld_btnFindShipment.BOSFieldGroup = null;
            this.fld_btnFindShipment.BOSFieldRelation = null;
            this.fld_btnFindShipment.BOSPrivilege = null;
            this.fld_btnFindShipment.BOSPropertyName = null;
            this.fld_btnFindShipment.Image = global::BOSERP.Procedure.Properties.Resources.View;
            this.fld_btnFindShipment.Location = new System.Drawing.Point(63, 4);
            this.fld_btnFindShipment.Name = "fld_btnFindShipment";
            this.fld_btnFindShipment.Screen = null;
            this.fld_btnFindShipment.Size = new System.Drawing.Size(101, 27);
            this.fld_btnFindShipment.TabIndex = 5;
            this.fld_btnFindShipment.Text = "Tìm xuất kho";
            this.fld_btnFindShipment.Click += new System.EventHandler(this.fld_btnFindShipment_Click);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(7, 10);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(50, 13);
            this.bosLabel12.TabIndex = 4;
            this.bosLabel12.Text = "Xuất kho";
            // 
            // fld_dgcAPAllocationCostItemShipments
            // 
            this.fld_dgcAPAllocationCostItemShipments.AllowDrop = true;
            this.fld_dgcAPAllocationCostItemShipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPAllocationCostItemShipments.BOSComment = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSDataMember = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSDataSource = "APAllocationCostItemShipments";
            this.fld_dgcAPAllocationCostItemShipments.BOSDescription = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSError = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSFieldGroup = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSFieldRelation = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSGridType = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSPrivilege = null;
            this.fld_dgcAPAllocationCostItemShipments.BOSPropertyName = null;
            this.fld_dgcAPAllocationCostItemShipments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPAllocationCostItemShipments.Location = new System.Drawing.Point(0, 37);
            this.fld_dgcAPAllocationCostItemShipments.MainView = this.gridView5;
            this.fld_dgcAPAllocationCostItemShipments.Name = "fld_dgcAPAllocationCostItemShipments";
            this.fld_dgcAPAllocationCostItemShipments.PrintReport = false;
            this.fld_dgcAPAllocationCostItemShipments.Screen = null;
            this.fld_dgcAPAllocationCostItemShipments.Size = new System.Drawing.Size(194, 307);
            this.fld_dgcAPAllocationCostItemShipments.TabIndex = 2;
            this.fld_dgcAPAllocationCostItemShipments.Tag = "DC";
            this.fld_dgcAPAllocationCostItemShipments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcAPAllocationCostItemShipments;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // fld_gImport
            // 
            this.fld_gImport.BOSComment = null;
            this.fld_gImport.BOSDataMember = null;
            this.fld_gImport.BOSDataSource = null;
            this.fld_gImport.BOSDescription = null;
            this.fld_gImport.BOSError = null;
            this.fld_gImport.BOSFieldGroup = null;
            this.fld_gImport.BOSFieldRelation = null;
            this.fld_gImport.BOSPrivilege = null;
            this.fld_gImport.BOSPropertyName = null;
            this.fld_gImport.Controls.Add(this.fld_btnRefresh);
            this.fld_gImport.Controls.Add(this.fld_dgcAPAllocationCostItemInvoices);
            this.fld_gImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_gImport.Location = new System.Drawing.Point(0, 0);
            this.fld_gImport.Name = "fld_gImport";
            this.fld_gImport.Screen = null;
            this.fld_gImport.Size = new System.Drawing.Size(458, 370);
            this.fld_gImport.TabIndex = 0;
            this.fld_gImport.Text = "Hóa đơn mua hàng - Thanh toán phí";
            // 
            // fld_btnRefresh
            // 
            this.fld_btnRefresh.BOSComment = null;
            this.fld_btnRefresh.BOSDataMember = null;
            this.fld_btnRefresh.BOSDataSource = null;
            this.fld_btnRefresh.BOSDescription = null;
            this.fld_btnRefresh.BOSError = null;
            this.fld_btnRefresh.BOSFieldGroup = null;
            this.fld_btnRefresh.BOSFieldRelation = null;
            this.fld_btnRefresh.BOSPrivilege = null;
            this.fld_btnRefresh.BOSPropertyName = null;
            this.fld_btnRefresh.Location = new System.Drawing.Point(6, 26);
            this.fld_btnRefresh.Name = "fld_btnRefresh";
            this.fld_btnRefresh.Screen = null;
            this.fld_btnRefresh.Size = new System.Drawing.Size(101, 27);
            this.fld_btnRefresh.TabIndex = 0;
            this.fld_btnRefresh.Text = "Refresh";
            this.fld_btnRefresh.Click += new System.EventHandler(this.fld_btnRefresh_Click);
            // 
            // fld_dgcAPAllocationCostItemInvoices
            // 
            this.fld_dgcAPAllocationCostItemInvoices.AllowDrop = true;
            this.fld_dgcAPAllocationCostItemInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPAllocationCostItemInvoices.BOSComment = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSDataMember = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSDataSource = "APAllocationCostItemInvoices";
            this.fld_dgcAPAllocationCostItemInvoices.BOSDescription = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSError = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSFieldGroup = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSFieldRelation = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSGridType = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSPrivilege = null;
            this.fld_dgcAPAllocationCostItemInvoices.BOSPropertyName = null;
            this.fld_dgcAPAllocationCostItemInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPAllocationCostItemInvoices.Location = new System.Drawing.Point(2, 59);
            this.fld_dgcAPAllocationCostItemInvoices.MainView = this.gridView3;
            this.fld_dgcAPAllocationCostItemInvoices.Name = "fld_dgcAPAllocationCostItemInvoices";
            this.fld_dgcAPAllocationCostItemInvoices.PrintReport = false;
            this.fld_dgcAPAllocationCostItemInvoices.Screen = null;
            this.fld_dgcAPAllocationCostItemInvoices.Size = new System.Drawing.Size(454, 309);
            this.fld_dgcAPAllocationCostItemInvoices.TabIndex = 1;
            this.fld_dgcAPAllocationCostItemInvoices.Tag = "DC";
            this.fld_dgcAPAllocationCostItemInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcAPAllocationCostItemInvoices;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1097, 263);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataMember = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = string.Empty;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1097, 263);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 665;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = string.Empty;
            this.fld_Lablel2.BOSDataMember = string.Empty;
            this.fld_Lablel2.BOSDataSource = string.Empty;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = string.Empty;
            this.fld_Lablel2.BOSFieldRelation = string.Empty;
            this.fld_Lablel2.BOSPrivilege = string.Empty;
            this.fld_Lablel2.BOSPropertyName = string.Empty;
            this.fld_Lablel2.Location = new System.Drawing.Point(114, 38);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 22;
            this.fld_Lablel2.Tag = string.Empty;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lkeAPAllocationCostStatus
            // 
            this.fld_lkeAPAllocationCostStatus.BOSAllowAddNew = false;
            this.fld_lkeAPAllocationCostStatus.BOSAllowDummy = false;
            this.fld_lkeAPAllocationCostStatus.BOSComment = null;
            this.fld_lkeAPAllocationCostStatus.BOSDataMember = "APAllocationCostStatus";
            this.fld_lkeAPAllocationCostStatus.BOSDataSource = "APAllocationCosts";
            this.fld_lkeAPAllocationCostStatus.BOSDescription = null;
            this.fld_lkeAPAllocationCostStatus.BOSError = null;
            this.fld_lkeAPAllocationCostStatus.BOSFieldGroup = null;
            this.fld_lkeAPAllocationCostStatus.BOSFieldParent = null;
            this.fld_lkeAPAllocationCostStatus.BOSFieldRelation = null;
            this.fld_lkeAPAllocationCostStatus.BOSPrivilege = null;
            this.fld_lkeAPAllocationCostStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPAllocationCostStatus.BOSSelectType = null;
            this.fld_lkeAPAllocationCostStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPAllocationCostStatus.CurrentDisplayText = null;
            this.fld_lkeAPAllocationCostStatus.Location = new System.Drawing.Point(201, 35);
            this.fld_lkeAPAllocationCostStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPAllocationCostStatus.Name = "fld_lkeAPAllocationCostStatus";
            this.fld_lkeAPAllocationCostStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPAllocationCostStatus.Properties.NullText = string.Empty;
            this.fld_lkeAPAllocationCostStatus.Properties.ReadOnly = true;
            this.fld_lkeAPAllocationCostStatus.Screen = null;
            this.fld_lkeAPAllocationCostStatus.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPAllocationCostStatus.TabIndex = 4;
            this.fld_lkeAPAllocationCostStatus.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = string.Empty;
            this.bosLabel7.BOSDataMember = string.Empty;
            this.bosLabel7.BOSDataSource = string.Empty;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = string.Empty;
            this.bosLabel7.BOSFieldRelation = string.Empty;
            this.bosLabel7.BOSPrivilege = string.Empty;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(380, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 2;
            this.bosLabel7.Tag = string.Empty;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // fld_dteAPAllocationCostDate
            // 
            this.fld_dteAPAllocationCostDate.BOSComment = string.Empty;
            this.fld_dteAPAllocationCostDate.BOSDataMember = "APAllocationCostDate";
            this.fld_dteAPAllocationCostDate.BOSDataSource = "APAllocationCosts";
            this.fld_dteAPAllocationCostDate.BOSDescription = null;
            this.fld_dteAPAllocationCostDate.BOSError = null;
            this.fld_dteAPAllocationCostDate.BOSFieldGroup = string.Empty;
            this.fld_dteAPAllocationCostDate.BOSFieldRelation = string.Empty;
            this.fld_dteAPAllocationCostDate.BOSPrivilege = string.Empty;
            this.fld_dteAPAllocationCostDate.BOSPropertyName = "EditValue";
            this.fld_dteAPAllocationCostDate.EditValue = null;
            this.fld_dteAPAllocationCostDate.Location = new System.Drawing.Point(492, 9);
            this.fld_dteAPAllocationCostDate.Name = "fld_dteAPAllocationCostDate";
            this.fld_dteAPAllocationCostDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPAllocationCostDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPAllocationCostDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPAllocationCostDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPAllocationCostDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPAllocationCostDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPAllocationCostDate.Screen = null;
            this.fld_dteAPAllocationCostDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPAllocationCostDate.TabIndex = 3;
            this.fld_dteAPAllocationCostDate.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(201, 61);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 6;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = string.Empty;
            this.bosLabel35.BOSDataSource = string.Empty;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = string.Empty;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(115, 64);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(48, 13);
            this.bosLabel35.TabIndex = 24;
            this.bosLabel35.Text = "Đối tượng";
            // 
            // fld_txtAPAllocationCostNo
            // 
            this.fld_txtAPAllocationCostNo.BOSComment = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSDataMember = "APAllocationCostNo";
            this.fld_txtAPAllocationCostNo.BOSDataSource = "APAllocationCosts";
            this.fld_txtAPAllocationCostNo.BOSDescription = null;
            this.fld_txtAPAllocationCostNo.BOSError = null;
            this.fld_txtAPAllocationCostNo.BOSFieldGroup = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSFieldRelation = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSPrivilege = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSPropertyName = "Text";
            this.fld_txtAPAllocationCostNo.EditValue = string.Empty;
            this.fld_txtAPAllocationCostNo.Location = new System.Drawing.Point(201, 9);
            this.fld_txtAPAllocationCostNo.Name = "fld_txtAPAllocationCostNo";
            this.fld_txtAPAllocationCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPAllocationCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPAllocationCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPAllocationCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPAllocationCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPAllocationCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPAllocationCostNo.Screen = null;
            this.fld_txtAPAllocationCostNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPAllocationCostNo.TabIndex = 2;
            this.fld_txtAPAllocationCostNo.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = string.Empty;
            this.bosLabel1.Location = new System.Drawing.Point(115, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Tag = string.Empty;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // DMALC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1110, 577);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMALC100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMALC100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostCriterion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPAllocationCostDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteReceiptFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gLumberOutSourcing)).EndInit();
            this.fld_gLumberOutSourcing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemInvoiceIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemShipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gImport)).EndInit();
            this.fld_gImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCostItemInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAllocationCostStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPAllocationCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtAPAllocationCostNo;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeAPAllocationCostStatus;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;

        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteAPAllocationCostDate;
        private BOSComponent.BOSPictureEdit fld_pteAPInvoiceInEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSMemoEdit fld_medAPAllocationCostDesc;
        private SplitContainer splitContainer1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private APAllocationCostItemsGridControl fld_dgcAPAllocationCostItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSGroupControl fld_gImport;
        private APAllocationCostItemInvoicesGridControl fld_dgcAPAllocationCostItemInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnFindReceipt;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteReceiptToDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteReceiptFromDate;
        private BOSComponent.BOSButton fld_btnRefresh;
        private BOSComponent.BOSLookupEdit fld_lkeAPAllocationCostCriterion;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseOrderID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeAPAllocationCostType;
        private BOSComponent.BOSGroupControl fld_gLumberOutSourcing;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSLabel bosLabel11;
        private APAllocationCostItemInvoiceInsGridControl fld_dgcAPAllocationCostItemInvoiceIns;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSLabel bosLabel12;
        private APAllocationCostItemShipmentsGridControl fld_dgcAPAllocationCostItemShipments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSButton fld_btnFindInvoiceIn;
        private BOSComponent.BOSButton fld_btnFindShipment;
        private BOSComponent.BOSButton fld_btnCalculate;
	


        //private BOSComponent.BOSLabel bosLabel18;



        //private BOSComponent.BOSLabel bosLabel18;
	}
}

