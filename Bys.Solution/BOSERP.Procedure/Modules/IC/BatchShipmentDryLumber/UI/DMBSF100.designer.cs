using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchShipmentDryLumber.UI
{
	/// <summary>
	/// Summary description for DMBSF100
	/// </summary>
	partial class DMBSF100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBSF100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_MMAllocationPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeReceverID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_LineID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICShipmentTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICImportAndExportReasonID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_txtICShipmentContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabShiptmentItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabTotalItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAutoSelectProductSerialNo = new BOSComponent.BOSButton(this.components);
            this.bosPictureEdit2 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcShipmentItemVMsGridControl = new BOSERP.Modules.BatchShipmentDryLumber.ICShipmentItemVMsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICShipmentItem1s = new BOSERP.Modules.BatchShipmentDryLumber.BatchShipmentDryLumbersGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_ptePictureEdit = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMAllocationPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceverID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).BeginInit();
            this.fld_tabShiptmentItems.SuspendLayout();
            this.fld_tabTotalItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItemVMsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fld_tabPageShipmentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItem1s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTextBox8);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMAllocationPlanID);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeReceverID);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_LineID);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentTypeCombo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APPurchaseOrderID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICImportAndExportReasonID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_btnShowInventoryStock);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentContainerNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentDesc);
            this.bosPanel1.Controls.Add(this.fld_tabShiptmentItems);
            this.bosPanel1.Controls.Add(this.fld_ptePictureEdit);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentStatus);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentNo1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1286, 792);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_MMAllocationPlanID
            // 
            this.fld_lkeFK_MMAllocationPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMAllocationPlanID.BOSAllowDummy = false;
            this.fld_lkeFK_MMAllocationPlanID.BOSComment = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSDataMember = "FK_MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMAllocationPlanID.BOSDescription = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSError = "";
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldGroup = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldParent = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSFieldRelation = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSPrivilege = null;
            this.fld_lkeFK_MMAllocationPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMAllocationPlanID.BOSSelectType = "";
            this.fld_lkeFK_MMAllocationPlanID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMAllocationPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_MMAllocationPlanID.Location = new System.Drawing.Point(1039, 87);
            this.fld_lkeFK_MMAllocationPlanID.Name = "fld_lkeFK_MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMAllocationPlanID.Properties.ColumnName = null;
            this.fld_lkeFK_MMAllocationPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMAllocationPlanNo", "Mã KHSD")});
            this.fld_lkeFK_MMAllocationPlanID.Properties.DisplayMember = "MMAllocationPlanNo";
            this.fld_lkeFK_MMAllocationPlanID.Properties.NullText = "";
            this.fld_lkeFK_MMAllocationPlanID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMAllocationPlanID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMAllocationPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMAllocationPlanID.Properties.ValueMember = "MMAllocationPlanID";
            this.fld_lkeFK_MMAllocationPlanID.Screen = null;
            this.fld_lkeFK_MMAllocationPlanID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMAllocationPlanID.TabIndex = 602;
            this.fld_lkeFK_MMAllocationPlanID.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(934, 91);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(44, 13);
            this.bosLabel15.TabIndex = 603;
            this.bosLabel15.Text = "KHSDNPL";
            // 
            // fld_lkeFK_HREmployeeReceverID
            // 
            this.fld_lkeFK_HREmployeeReceverID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeReceverID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeReceverID.BOSComment = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSDataMember = "FK_HREmployeeReceverID";
            this.fld_lkeFK_HREmployeeReceverID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeReceverID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeReceverID.BOSError = null;
            this.fld_lkeFK_HREmployeeReceverID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeReceverID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeReceverID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeReceverID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeReceverID.Location = new System.Drawing.Point(486, 35);
            this.fld_lkeFK_HREmployeeReceverID.Name = "fld_lkeFK_HREmployeeReceverID";
            this.fld_lkeFK_HREmployeeReceverID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeReceverID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeReceverID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeReceverID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeReceverID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeReceverID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeReceverID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã NV"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên NV")});
            this.fld_lkeFK_HREmployeeReceverID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeReceverID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeReceverID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeReceverID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeReceverID.Screen = null;
            this.fld_lkeFK_HREmployeeReceverID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeReceverID.TabIndex = 601;
            this.fld_lkeFK_HREmployeeReceverID.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(934, 38);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(31, 13);
            this.bosLabel10.TabIndex = 599;
            this.bosLabel10.Text = "Xưởng";
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(934, 65);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(37, 13);
            this.bosLabel22.TabIndex = 600;
            this.bosLabel22.Text = "Chuyền";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(1039, 35);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopDesc", "Mô tả")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMWorkShopID, true);
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 597;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            this.fld_lkeFK_MMWorkShopID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMWorkShopID_CloseUp);
            // 
            // fld_lkeFK_LineID
            // 
            this.fld_lkeFK_LineID.BOSAllowAddNew = false;
            this.fld_lkeFK_LineID.BOSAllowDummy = true;
            this.fld_lkeFK_LineID.BOSComment = "";
            this.fld_lkeFK_LineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_LineID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_LineID.BOSDescription = null;
            this.fld_lkeFK_LineID.BOSError = null;
            this.fld_lkeFK_LineID.BOSFieldGroup = "";
            this.fld_lkeFK_LineID.BOSFieldParent = "";
            this.fld_lkeFK_LineID.BOSFieldRelation = "";
            this.fld_lkeFK_LineID.BOSPrivilege = "";
            this.fld_lkeFK_LineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_LineID.BOSSelectType = "";
            this.fld_lkeFK_LineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_LineID.CurrentDisplayText = "";
            this.fld_lkeFK_LineID.Location = new System.Drawing.Point(1039, 62);
            this.fld_lkeFK_LineID.Name = "fld_lkeFK_LineID";
            this.fld_lkeFK_LineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_LineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_LineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_LineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_LineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_LineID.Properties.ColumnName = null;
            this.fld_lkeFK_LineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineDesc", "Mô tả")});
            this.fld_lkeFK_LineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_LineID.Properties.NullText = "";
            this.fld_lkeFK_LineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_LineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_LineID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_LineID, true);
            this.fld_lkeFK_LineID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_LineID.TabIndex = 598;
            this.fld_lkeFK_LineID.Tag = "DC";
            this.fld_lkeFK_LineID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_LineID_CloseUp);
            // 
            // fld_lkeICShipmentTypeCombo
            // 
            this.fld_lkeICShipmentTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeICShipmentTypeCombo.BOSAllowDummy = false;
            this.fld_lkeICShipmentTypeCombo.BOSComment = null;
            this.fld_lkeICShipmentTypeCombo.BOSDataMember = "ICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.BOSDataSource = "ICShipments";
            this.fld_lkeICShipmentTypeCombo.BOSDescription = null;
            this.fld_lkeICShipmentTypeCombo.BOSError = "";
            this.fld_lkeICShipmentTypeCombo.BOSFieldGroup = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldParent = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldRelation = null;
            this.fld_lkeICShipmentTypeCombo.BOSPrivilege = null;
            this.fld_lkeICShipmentTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentTypeCombo.BOSSelectType = "";
            this.fld_lkeICShipmentTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeICShipmentTypeCombo.CurrentDisplayText = null;
            this.fld_lkeICShipmentTypeCombo.Location = new System.Drawing.Point(208, 112);
            this.fld_lkeICShipmentTypeCombo.Name = "fld_lkeICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICShipmentTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentTypeCombo.Properties.ColumnName = null;
            this.fld_lkeICShipmentTypeCombo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu")});
            this.fld_lkeICShipmentTypeCombo.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICShipmentTypeCombo.Properties.NullText = "";
            this.fld_lkeICShipmentTypeCombo.Properties.PopupWidth = 40;
            this.fld_lkeICShipmentTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICShipmentTypeCombo.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICShipmentTypeCombo.Screen = null;
            this.fld_lkeICShipmentTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICShipmentTypeCombo.TabIndex = 595;
            this.fld_lkeICShipmentTypeCombo.Tag = "DC";
            this.fld_lkeICShipmentTypeCombo.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeICShipmentTypeCombo_QueryPopUp);
            this.fld_lkeICShipmentTypeCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICShipmentTypeCombo_CloseUp);
            this.fld_lkeICShipmentTypeCombo.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeICShipmentTypeCombo_Closed);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(123, 115);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(77, 13);
            this.bosLabel7.TabIndex = 596;
            this.bosLabel7.Text = "Loại nguyên liệu";
            // 
            // fld_lkeFK_APPurchaseOrderID
            // 
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSComment = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSDataMember = "FK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_APPurchaseOrderID.BOSDescription = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSError = "";
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldParent = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSPrivilege = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectType = "";
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APPurchaseOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_APPurchaseOrderID.Location = new System.Drawing.Point(208, 61);
            this.fld_lkeFK_APPurchaseOrderID.Name = "fld_lkeFK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchaseOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchaseOrderID.Properties.ColumnName = null;
            this.fld_lkeFK_APPurchaseOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseOrderNo", "Mã đơn hàng")});
            this.fld_lkeFK_APPurchaseOrderID.Properties.DisplayMember = "APPurchaseOrderNo";
            this.fld_lkeFK_APPurchaseOrderID.Properties.NullText = "";
            this.fld_lkeFK_APPurchaseOrderID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APPurchaseOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchaseOrderID.Properties.ValueMember = "APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Screen = null;
            this.fld_lkeFK_APPurchaseOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APPurchaseOrderID.TabIndex = 9;
            this.fld_lkeFK_APPurchaseOrderID.Tag = "DC";
            this.fld_lkeFK_APPurchaseOrderID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_APPurchaseOrderID_QueryPopUp);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(123, 65);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(70, 13);
            this.bosLabel6.TabIndex = 594;
            this.bosLabel6.Text = "Đơn mua hàng";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(208, 87);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 12;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(123, 90);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(45, 13);
            this.bosLabel14.TabIndex = 592;
            this.bosLabel14.Text = "Mã dự án";
            // 
            // fld_lkeFK_ICImportAndExportReasonID
            // 
            this.fld_lkeFK_ICImportAndExportReasonID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSAllowDummy = false;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSComment = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDataMember = "FK_ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDescription = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSError = "";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldGroup = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldParent = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldRelation = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSPrivilege = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSSelectType = "ICImportAndExportReasonType";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSSelectTypeValue = "Export";
            this.fld_lkeFK_ICImportAndExportReasonID.CurrentDisplayText = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Location = new System.Drawing.Point(761, 138);
            this.fld_lkeFK_ICImportAndExportReasonID.Name = "fld_lkeFK_ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.ColumnName = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICImportAndExportReasonName", "Lí do nhập/xuất kho điều chỉnh")});
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.DisplayMember = "ICImportAndExportReasonName";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.NullText = "";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.ValueMember = "ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.Screen = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICImportAndExportReasonID.TabIndex = 16;
            this.fld_lkeFK_ICImportAndExportReasonID.Tag = "DC";
            this.fld_lkeFK_ICImportAndExportReasonID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICImportAndExportReasonID_CloseUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(660, 141);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(78, 13);
            this.bosLabel12.TabIndex = 589;
            this.bosLabel12.Text = "Lý do nhập xuất";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICShipments";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(208, 35);
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
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp_1);
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(486, 87);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 10;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(397, 90);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(51, 13);
            this.bosLabel18.TabIndex = 587;
            this.bosLabel18.Text = "Phòng ban";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(397, 116);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(39, 13);
            this.bosLabel16.TabIndex = 586;
            this.bosLabel16.Text = "Bộ phận";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(486, 113);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 13;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRDepartmentRoomID_CloseUp);
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(660, 115);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(46, 13);
            this.bosLabel19.TabIndex = 583;
            this.bosLabel19.Text = "Số PO.No";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ICShipmentPONo";
            this.bosTextBox1.BOSDataSource = "ICShipments";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(761, 112);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 14;
            this.bosTextBox1.Tag = "DC";
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
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(761, 164);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(150, 27);
            this.fld_btnShowInventoryStock.TabIndex = 17;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Visible = false;
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // fld_txtICShipmentContainerNo
            // 
            this.fld_txtICShipmentContainerNo.BOSComment = null;
            this.fld_txtICShipmentContainerNo.BOSDataMember = "ICShipmentContainerNo";
            this.fld_txtICShipmentContainerNo.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentContainerNo.BOSDescription = null;
            this.fld_txtICShipmentContainerNo.BOSError = null;
            this.fld_txtICShipmentContainerNo.BOSFieldGroup = null;
            this.fld_txtICShipmentContainerNo.BOSFieldRelation = null;
            this.fld_txtICShipmentContainerNo.BOSPrivilege = null;
            this.fld_txtICShipmentContainerNo.BOSPropertyName = "Text";
            this.fld_txtICShipmentContainerNo.Location = new System.Drawing.Point(761, 86);
            this.fld_txtICShipmentContainerNo.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentContainerNo.Name = "fld_txtICShipmentContainerNo";
            this.fld_txtICShipmentContainerNo.Screen = null;
            this.fld_txtICShipmentContainerNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentContainerNo.TabIndex = 11;
            this.fld_txtICShipmentContainerNo.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(660, 89);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(63, 13);
            this.bosLabel11.TabIndex = 538;
            this.bosLabel11.Text = "Container No";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = "";
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(486, 61);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 7;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMOperationID_CloseUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(397, 64);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 530;
            this.bosLabel5.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = "";
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(1039, 9);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 6;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            this.fld_lkeFK_MMBatchProductID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_MMBatchProductID_EditValueChanged);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(934, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(17, 13);
            this.bosLabel4.TabIndex = 528;
            this.bosLabel4.Text = "LSX";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = "";
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = "";
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = "";
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(761, 61);
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = "";
            this.fld_lkeFK_ACSegmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 8;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(660, 64);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 526;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Khoản mục chi phí";
            // 
            // fld_medICShipmentDesc
            // 
            this.fld_medICShipmentDesc.BOSComment = "";
            this.fld_medICShipmentDesc.BOSDataMember = "ICShipmentDesc";
            this.fld_medICShipmentDesc.BOSDataSource = "ICShipments";
            this.fld_medICShipmentDesc.BOSDescription = null;
            this.fld_medICShipmentDesc.BOSError = null;
            this.fld_medICShipmentDesc.BOSFieldGroup = "";
            this.fld_medICShipmentDesc.BOSFieldRelation = "";
            this.fld_medICShipmentDesc.BOSPrivilege = "";
            this.fld_medICShipmentDesc.BOSPropertyName = "EditValue";
            this.fld_medICShipmentDesc.EditValue = "";
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(208, 138);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(428, 53);
            this.fld_medICShipmentDesc.TabIndex = 15;
            this.fld_medICShipmentDesc.Tag = "DC";
            // 
            // fld_tabShiptmentItems
            // 
            this.fld_tabShiptmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabShiptmentItems.BOSComment = null;
            this.fld_tabShiptmentItems.BOSDataMember = null;
            this.fld_tabShiptmentItems.BOSDataSource = null;
            this.fld_tabShiptmentItems.BOSDescription = null;
            this.fld_tabShiptmentItems.BOSError = null;
            this.fld_tabShiptmentItems.BOSFieldGroup = null;
            this.fld_tabShiptmentItems.BOSFieldRelation = null;
            this.fld_tabShiptmentItems.BOSPrivilege = null;
            this.fld_tabShiptmentItems.BOSPropertyName = null;
            this.fld_tabShiptmentItems.Location = new System.Drawing.Point(0, 216);
            this.fld_tabShiptmentItems.Name = "fld_tabShiptmentItems";
            this.fld_tabShiptmentItems.Screen = null;
            this.fld_tabShiptmentItems.SelectedTabPage = this.fld_tabTotalItems;
            this.fld_tabShiptmentItems.Size = new System.Drawing.Size(1283, 573);
            this.fld_tabShiptmentItems.TabIndex = 20;
            this.fld_tabShiptmentItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabTotalItems,
            this.fld_tabPageShipmentItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabTotalItems
            // 
            this.fld_tabTotalItems.Controls.Add(this.fld_btnAutoSelectProductSerialNo);
            this.fld_tabTotalItems.Controls.Add(this.bosPictureEdit2);
            this.fld_tabTotalItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabTotalItems.Controls.Add(this.bosLabel13);
            this.fld_tabTotalItems.Controls.Add(this.fld_dgcShipmentItemVMsGridControl);
            this.fld_tabTotalItems.Name = "fld_tabTotalItems";
            this.fld_tabTotalItems.Size = new System.Drawing.Size(1281, 548);
            this.fld_tabTotalItems.Text = "Danh sách tổng vật tư";
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
            this.fld_btnAutoSelectProductSerialNo.Location = new System.Drawing.Point(1154, 10);
            this.fld_btnAutoSelectProductSerialNo.Name = "fld_btnAutoSelectProductSerialNo";
            this.fld_btnAutoSelectProductSerialNo.Screen = null;
            this.fld_btnAutoSelectProductSerialNo.Size = new System.Drawing.Size(120, 23);
            this.fld_btnAutoSelectProductSerialNo.TabIndex = 25;
            this.fld_btnAutoSelectProductSerialNo.Text = "Tự động gắn lô";
            this.fld_btnAutoSelectProductSerialNo.Click += new System.EventHandler(this.fld_btnAutoSelectProductSerialNo_Click);
            // 
            // bosPictureEdit2
            // 
            this.bosPictureEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPictureEdit2.BOSComment = "";
            this.bosPictureEdit2.BOSDataMember = "ICShipmentItemProductPicture";
            this.bosPictureEdit2.BOSDataSource = "ICShipmentItemVMs";
            this.bosPictureEdit2.BOSDescription = null;
            this.bosPictureEdit2.BOSError = null;
            this.bosPictureEdit2.BOSFieldGroup = "";
            this.bosPictureEdit2.BOSFieldRelation = "";
            this.bosPictureEdit2.BOSPrivilege = "";
            this.bosPictureEdit2.BOSPropertyName = "EditValue";
            this.bosPictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit2.EditValue = "";
            this.bosPictureEdit2.FileName = null;
            this.bosPictureEdit2.FilePath = null;
            this.bosPictureEdit2.Location = new System.Drawing.Point(1154, 39);
            this.bosPictureEdit2.Name = "bosPictureEdit2";
            this.bosPictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosPictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosPictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosPictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit2.Screen = null;
            this.bosPictureEdit2.Size = new System.Drawing.Size(120, 120);
            this.bosPictureEdit2.TabIndex = 9;
            this.bosPictureEdit2.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentItemVMs";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 11);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1083, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 7;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel13.Location = new System.Drawing.Point(12, 15);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 8;
            this.bosLabel13.Text = "Sản phẩm";
            // 
            // fld_dgcShipmentItemVMsGridControl
            // 
            this.fld_dgcShipmentItemVMsGridControl.AllowDrop = true;
            this.fld_dgcShipmentItemVMsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcShipmentItemVMsGridControl.BOSComment = "";
            this.fld_dgcShipmentItemVMsGridControl.BOSDataMember = "";
            this.fld_dgcShipmentItemVMsGridControl.BOSDataSource = "ICShipmentItemVMs";
            this.fld_dgcShipmentItemVMsGridControl.BOSDescription = null;
            this.fld_dgcShipmentItemVMsGridControl.BOSError = null;
            this.fld_dgcShipmentItemVMsGridControl.BOSFieldGroup = "";
            this.fld_dgcShipmentItemVMsGridControl.BOSFieldRelation = "";
            this.fld_dgcShipmentItemVMsGridControl.BOSGridType = null;
            this.fld_dgcShipmentItemVMsGridControl.BOSPrivilege = "";
            this.fld_dgcShipmentItemVMsGridControl.BOSPropertyName = null;
            this.fld_dgcShipmentItemVMsGridControl.CommodityType = "";
            this.fld_dgcShipmentItemVMsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcShipmentItemVMsGridControl.Location = new System.Drawing.Point(8, 37);
            this.fld_dgcShipmentItemVMsGridControl.MainView = this.gridView2;
            this.fld_dgcShipmentItemVMsGridControl.Name = "fld_dgcShipmentItemVMsGridControl";
            this.fld_dgcShipmentItemVMsGridControl.PrintReport = false;
            this.fld_dgcShipmentItemVMsGridControl.Screen = null;
            this.fld_dgcShipmentItemVMsGridControl.Size = new System.Drawing.Size(1138, 502);
            this.fld_dgcShipmentItemVMsGridControl.TabIndex = 6;
            this.fld_dgcShipmentItemVMsGridControl.Tag = "DC";
            this.fld_dgcShipmentItemVMsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcShipmentItemVMsGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcICShipmentItem1s);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(1267, 541);
            this.fld_tabPageShipmentItems.Text = "Danh sách vật tư";
            // 
            // fld_dgcICShipmentItem1s
            // 
            this.fld_dgcICShipmentItem1s.AllowDrop = true;
            this.fld_dgcICShipmentItem1s.BOSComment = "";
            this.fld_dgcICShipmentItem1s.BOSDataMember = "";
            this.fld_dgcICShipmentItem1s.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItem1s.BOSDescription = null;
            this.fld_dgcICShipmentItem1s.BOSError = null;
            this.fld_dgcICShipmentItem1s.BOSFieldGroup = "";
            this.fld_dgcICShipmentItem1s.BOSFieldRelation = "";
            this.fld_dgcICShipmentItem1s.BOSGridType = null;
            this.fld_dgcICShipmentItem1s.BOSPrivilege = "";
            this.fld_dgcICShipmentItem1s.BOSPropertyName = null;
            this.fld_dgcICShipmentItem1s.CommodityType = "";
            this.fld_dgcICShipmentItem1s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICShipmentItem1s.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ScreenHelper.SetHelpNavigator(this.fld_dgcICShipmentItem1s, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.fld_dgcICShipmentItem1s.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICShipmentItem1s.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICShipmentItem1s.Name = "fld_dgcICShipmentItem1s";
            this.fld_dgcICShipmentItem1s.PrintReport = false;
            this.fld_dgcICShipmentItem1s.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICShipmentItem1s, true);
            this.fld_dgcICShipmentItem1s.Size = new System.Drawing.Size(1267, 541);
            this.fld_dgcICShipmentItem1s.TabIndex = 1;
            this.fld_dgcICShipmentItem1s.Tag = "DC";
            this.fld_dgcICShipmentItem1s.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICShipmentItem1s;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1267, 541);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1267, 541);
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
            // fld_ptePictureEdit
            // 
            this.fld_ptePictureEdit.BOSComment = "";
            this.fld_ptePictureEdit.BOSDataMember = "ICShipmentEmployeePicture";
            this.fld_ptePictureEdit.BOSDataSource = "ICShipments";
            this.fld_ptePictureEdit.BOSDescription = null;
            this.fld_ptePictureEdit.BOSError = null;
            this.fld_ptePictureEdit.BOSFieldGroup = "";
            this.fld_ptePictureEdit.BOSFieldRelation = "";
            this.fld_ptePictureEdit.BOSPrivilege = "";
            this.fld_ptePictureEdit.BOSPropertyName = "EditValue";
            this.fld_ptePictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_ptePictureEdit.EditValue = "";
            this.fld_ptePictureEdit.FileName = null;
            this.fld_ptePictureEdit.FilePath = null;
            this.fld_ptePictureEdit.Location = new System.Drawing.Point(3, 4);
            this.fld_ptePictureEdit.Name = "fld_ptePictureEdit";
            this.fld_ptePictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ptePictureEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ptePictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ptePictureEdit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ptePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_ptePictureEdit.Screen = null;
            this.fld_ptePictureEdit.Size = new System.Drawing.Size(100, 96);
            this.fld_ptePictureEdit.TabIndex = 0;
            this.fld_ptePictureEdit.Tag = "DC";
            // 
            // fld_dteICShipmentDate
            // 
            this.fld_dteICShipmentDate.BOSComment = "";
            this.fld_dteICShipmentDate.BOSDataMember = "ICShipmentDate";
            this.fld_dteICShipmentDate.BOSDataSource = "ICShipments";
            this.fld_dteICShipmentDate.BOSDescription = null;
            this.fld_dteICShipmentDate.BOSError = null;
            this.fld_dteICShipmentDate.BOSFieldGroup = "";
            this.fld_dteICShipmentDate.BOSFieldRelation = "";
            this.fld_dteICShipmentDate.BOSPrivilege = "";
            this.fld_dteICShipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDate.EditValue = null;
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(486, 9);
            this.fld_dteICShipmentDate.Name = "fld_dteICShipmentDate";
            this.fld_dteICShipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate.Screen = null;
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICShipmentDate.TabIndex = 1;
            this.fld_dteICShipmentDate.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ICShipments";
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(761, 34);
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
            this.fld_lkeFK_ICStockID1.TabIndex = 5;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(397, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày chứng từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(397, 37);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(82, 13);
            this.bosLabel1.TabIndex = 524;
            this.bosLabel1.Text = "Người nhận hàng";
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
            this.bosLabel3.Location = new System.Drawing.Point(123, 145);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(660, 12);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 14;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // fld_lkeICShipmentStatus
            // 
            this.fld_lkeICShipmentStatus.BOSAllowAddNew = false;
            this.fld_lkeICShipmentStatus.BOSAllowDummy = false;
            this.fld_lkeICShipmentStatus.BOSComment = null;
            this.fld_lkeICShipmentStatus.BOSDataMember = "ICShipmentStatus";
            this.fld_lkeICShipmentStatus.BOSDataSource = "ICShipments";
            this.fld_lkeICShipmentStatus.BOSDescription = null;
            this.fld_lkeICShipmentStatus.BOSError = null;
            this.fld_lkeICShipmentStatus.BOSFieldGroup = null;
            this.fld_lkeICShipmentStatus.BOSFieldParent = null;
            this.fld_lkeICShipmentStatus.BOSFieldRelation = null;
            this.fld_lkeICShipmentStatus.BOSPrivilege = null;
            this.fld_lkeICShipmentStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentStatus.BOSSelectType = null;
            this.fld_lkeICShipmentStatus.BOSSelectTypeValue = null;
            this.fld_lkeICShipmentStatus.CurrentDisplayText = null;
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(761, 9);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.ColumnName = null;
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 2;
            this.fld_lkeICShipmentStatus.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(123, 37);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 522;
            this.bosLabel2.Text = "Đối tượng";
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
            this.fld_Lablel3.Location = new System.Drawing.Point(660, 37);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 522;
            this.fld_Lablel3.Text = "Kho";
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
            this.bosLabel8.Location = new System.Drawing.Point(123, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(61, 13);
            this.bosLabel8.TabIndex = 68;
            this.bosLabel8.Text = "Mã chứng từ";
            // 
            // fld_txtICShipmentNo1
            // 
            this.fld_txtICShipmentNo1.BOSComment = null;
            this.fld_txtICShipmentNo1.BOSDataMember = "ICShipmentNo";
            this.fld_txtICShipmentNo1.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentNo1.BOSDescription = null;
            this.fld_txtICShipmentNo1.BOSError = null;
            this.fld_txtICShipmentNo1.BOSFieldGroup = null;
            this.fld_txtICShipmentNo1.BOSFieldRelation = null;
            this.fld_txtICShipmentNo1.BOSPrivilege = null;
            this.fld_txtICShipmentNo1.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(208, 9);
            this.fld_txtICShipmentNo1.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentNo1.TabIndex = 0;
            this.fld_txtICShipmentNo1.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(2, 103);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = null;
            this.bosTextBox8.BOSDataMember = "ICShipmentSOName";
            this.bosTextBox8.BOSDataSource = "ICShipments";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = null;
            this.bosTextBox8.BOSFieldRelation = null;
            this.bosTextBox8.BOSPrivilege = null;
            this.bosTextBox8.BOSPropertyName = "EditValue";
            this.bosTextBox8.Location = new System.Drawing.Point(1039, 113);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.ReadOnly = true;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(151, 20);
            this.bosTextBox8.TabIndex = 852;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(934, 116);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(94, 13);
            this.bosLabel17.TabIndex = 851;
            this.bosLabel17.Text = "Mã đơn hàng nội bộ";
            // 
            // DMBSF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1286, 792);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBSF100.IconOptions.Icon")));
            this.Name = "DMBSF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMAllocationPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceverID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).EndInit();
            this.fld_tabShiptmentItems.ResumeLayout(false);
            this.fld_tabTotalItems.ResumeLayout(false);
            this.fld_tabTotalItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItemVMsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItem1s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtICShipmentContainerNo;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private BOSComponent.BOSTabControl fld_tabShiptmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private BOSERP.Modules.BatchShipmentDryLumber.BatchShipmentDryLumbersGridControl fld_dgcICShipmentItem1s;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSPictureEdit fld_ptePictureEdit;
        private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private IContainer components;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICImportAndExportReasonID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel14;
        private DevExpress.XtraTab.XtraTabPage fld_tabTotalItems;
        private BOSComponent.BOSPictureEdit bosPictureEdit2;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel13;
        private BatchShipmentDryLumber.ICShipmentItemVMsGridControl fld_dgcShipmentItemVMsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseOrderID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentTypeCombo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_LineID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeReceverID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMAllocationPlanID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSButton fld_btnAutoSelectProductSerialNo;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel17;
    }
}
