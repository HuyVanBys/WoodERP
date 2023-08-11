using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SemiProductShipment.UI
{
	/// <summary>
	/// Summary description for DMSPSM100
	/// </summary>
	partial class DMSPSM100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSPSM100));
            this.Panel = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeReceverID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_LineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMMachineUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICImportAndExportReasonID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_btnShowReceiptList = new BOSComponent.BOSButton(this.components);
            this.fld_tabShiptmentItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICShipmentItems = new BOSERP.Modules.SemiProductShipment.ICShipmentItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMReceiveOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_ptePictureEdit = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceverID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMMachineUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).BeginInit();
            this.fld_tabShiptmentItems.SuspendLayout();
            this.fld_tabPageShipmentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMReceiveOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BOSComment = null;
            this.Panel.BOSDataMember = null;
            this.Panel.BOSDataSource = null;
            this.Panel.BOSDescription = null;
            this.Panel.BOSError = null;
            this.Panel.BOSFieldGroup = null;
            this.Panel.BOSFieldRelation = null;
            this.Panel.BOSPrivilege = null;
            this.Panel.BOSPropertyName = null;
            this.Panel.Controls.Add(this.bosTextBox8);
            this.Panel.Controls.Add(this.bosLabel20);
            this.Panel.Controls.Add(this.bosLabel2);
            this.Panel.Controls.Add(this.fld_lkeFK_APPurchaseOrderID);
            this.Panel.Controls.Add(this.fld_lkeFK_HREmployeeReceverID);
            this.Panel.Controls.Add(this.bosLabel14);
            this.Panel.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.Panel.Controls.Add(this.bosLabel10);
            this.Panel.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.Panel.Controls.Add(this.fld_lkeFK_LineID);
            this.Panel.Controls.Add(this.bosLabel16);
            this.Panel.Controls.Add(this.bosLabel17);
            this.Panel.Controls.Add(this.fld_lkeFK_MMMachineUnitID);
            this.Panel.Controls.Add(this.bosLabel18);
            this.Panel.Controls.Add(this.fld_lkeFK_ICImportAndExportReasonID);
            this.Panel.Controls.Add(this.bosLabel11);
            this.Panel.Controls.Add(this.fld_lkeICShipmentTypeCombo);
            this.Panel.Controls.Add(this.bosLabel6);
            this.Panel.Controls.Add(this.fld_btnShowInventoryStock);
            this.Panel.Controls.Add(this.fld_btnShowReceiptList);
            this.Panel.Controls.Add(this.fld_tabShiptmentItems);
            this.Panel.Controls.Add(this.fld_lkeICProductID);
            this.Panel.Controls.Add(this.bosLabel5);
            this.Panel.Controls.Add(this.fld_lkeFK_MMReceiveOperationID);
            this.Panel.Controls.Add(this.bosLabel7);
            this.Panel.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.Panel.Controls.Add(this.bosLabel4);
            this.Panel.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.Panel.Controls.Add(this.bosLabel1);
            this.Panel.Controls.Add(this.fld_medICShipmentDesc);
            this.Panel.Controls.Add(this.bosLabel3);
            this.Panel.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.Panel.Controls.Add(this.bosLabel9);
            this.Panel.Controls.Add(this.fld_dteICShipmentDate);
            this.Panel.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.Panel.Controls.Add(this.fld_lblLabel26);
            this.Panel.Controls.Add(this.fld_Lablel3);
            this.Panel.Controls.Add(this.fld_ptePictureEdit);
            this.Panel.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Panel.Controls.Add(this.fld_lblLabel25);
            this.Panel.Controls.Add(this.fld_lkeICShipmentStatus);
            this.Panel.Controls.Add(this.bosLabel8);
            this.Panel.Controls.Add(this.fld_txtICShipmentNo1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Screen = null;
            this.Panel.Size = new System.Drawing.Size(1213, 759);
            this.Panel.TabIndex = 0;
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
            this.bosLabel2.Location = new System.Drawing.Point(869, 87);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(55, 13);
            this.bosLabel2.TabIndex = 18;
            this.bosLabel2.Text = "Người nhận";
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
            this.fld_lkeFK_APPurchaseOrderID.Location = new System.Drawing.Point(700, 7);
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
            this.fld_lkeFK_APPurchaseOrderID.TabIndex = 2;
            this.fld_lkeFK_APPurchaseOrderID.Tag = "DC";
            this.fld_lkeFK_APPurchaseOrderID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_APPurchaseOrderID_QueryPopUp);
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
            this.fld_lkeFK_HREmployeeReceverID.Location = new System.Drawing.Point(987, 84);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên NV"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HREmployeeReceverID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeReceverID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeReceverID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeReceverID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeReceverID.Screen = null;
            this.fld_lkeFK_HREmployeeReceverID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeReceverID.TabIndex = 17;
            this.fld_lkeFK_HREmployeeReceverID.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(617, 10);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(70, 13);
            this.bosLabel14.TabIndex = 39;
            this.bosLabel14.Text = "Đơn mua hàng";
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HRDepartmentRoomGroupItems";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(700, 110);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 16;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp);
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
            this.bosLabel10.Location = new System.Drawing.Point(618, 112);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(28, 13);
            this.bosLabel10.TabIndex = 30;
            this.bosLabel10.Text = "Tổ NV";
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
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(700, 33);
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
            this.fld_lkeFK_MMWorkShopID.TabIndex = 6;
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
            this.fld_lkeFK_LineID.Location = new System.Drawing.Point(700, 59);
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
            this.fld_lkeFK_LineID.TabIndex = 10;
            this.fld_lkeFK_LineID.Tag = "DC";
            this.fld_lkeFK_LineID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_LineID_CloseUp);
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
            this.bosLabel16.Location = new System.Drawing.Point(618, 37);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(31, 13);
            this.bosLabel16.TabIndex = 7;
            this.bosLabel16.Text = "Xưởng";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(618, 63);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(37, 13);
            this.bosLabel17.TabIndex = 15;
            this.bosLabel17.Text = "Chuyền";
            // 
            // fld_lkeFK_MMMachineUnitID
            // 
            this.fld_lkeFK_MMMachineUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMMachineUnitID.BOSAllowDummy = true;
            this.fld_lkeFK_MMMachineUnitID.BOSComment = "";
            this.fld_lkeFK_MMMachineUnitID.BOSDataMember = "FK_MMMachineUnitID";
            this.fld_lkeFK_MMMachineUnitID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMMachineUnitID.BOSDescription = null;
            this.fld_lkeFK_MMMachineUnitID.BOSError = null;
            this.fld_lkeFK_MMMachineUnitID.BOSFieldGroup = "";
            this.fld_lkeFK_MMMachineUnitID.BOSFieldParent = "";
            this.fld_lkeFK_MMMachineUnitID.BOSFieldRelation = "";
            this.fld_lkeFK_MMMachineUnitID.BOSPrivilege = "";
            this.fld_lkeFK_MMMachineUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMMachineUnitID.BOSSelectType = "";
            this.fld_lkeFK_MMMachineUnitID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMMachineUnitID.CurrentDisplayText = "";
            this.fld_lkeFK_MMMachineUnitID.Location = new System.Drawing.Point(700, 84);
            this.fld_lkeFK_MMMachineUnitID.Name = "fld_lkeFK_MMMachineUnitID";
            this.fld_lkeFK_MMMachineUnitID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMMachineUnitID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMMachineUnitID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMMachineUnitID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMMachineUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMMachineUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_MMMachineUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineUnitNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineUnitName", "Tên")});
            this.fld_lkeFK_MMMachineUnitID.Properties.DisplayMember = "MMMachineUnitName";
            this.fld_lkeFK_MMMachineUnitID.Properties.NullText = "";
            this.fld_lkeFK_MMMachineUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMMachineUnitID.Properties.ValueMember = "MMMachineUnitID";
            this.fld_lkeFK_MMMachineUnitID.Screen = null;
            this.fld_lkeFK_MMMachineUnitID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMMachineUnitID.TabIndex = 14;
            this.fld_lkeFK_MMMachineUnitID.Tag = "DC";
            this.fld_lkeFK_MMMachineUnitID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMMachineUnitID_QueryPopUp);
            this.fld_lkeFK_MMMachineUnitID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMMachineUnitID_CloseUp);
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
            this.bosLabel18.Location = new System.Drawing.Point(618, 87);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(35, 13);
            this.bosLabel18.TabIndex = 22;
            this.bosLabel18.Text = "Tổ máy";
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
            this.fld_lkeFK_ICImportAndExportReasonID.Location = new System.Drawing.Point(987, 58);
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
            this.fld_lkeFK_ICImportAndExportReasonID.TabIndex = 11;
            this.fld_lkeFK_ICImportAndExportReasonID.Tag = "DC";
            this.fld_lkeFK_ICImportAndExportReasonID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICImportAndExportReasonID_CloseUp);
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
            this.bosLabel11.Location = new System.Drawing.Point(869, 61);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(78, 13);
            this.bosLabel11.TabIndex = 30;
            this.bosLabel11.Text = "Lý do nhập xuất";
            // 
            // fld_lkeICShipmentTypeCombo
            // 
            this.fld_lkeICShipmentTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeICShipmentTypeCombo.BOSAllowDummy = true;
            this.fld_lkeICShipmentTypeCombo.BOSComment = "";
            this.fld_lkeICShipmentTypeCombo.BOSDataMember = "ICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.BOSDataSource = "ICShipments";
            this.fld_lkeICShipmentTypeCombo.BOSDescription = null;
            this.fld_lkeICShipmentTypeCombo.BOSError = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldGroup = "";
            this.fld_lkeICShipmentTypeCombo.BOSFieldParent = "";
            this.fld_lkeICShipmentTypeCombo.BOSFieldRelation = "";
            this.fld_lkeICShipmentTypeCombo.BOSPrivilege = "";
            this.fld_lkeICShipmentTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentTypeCombo.BOSSelectType = "";
            this.fld_lkeICShipmentTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeICShipmentTypeCombo.CurrentDisplayText = null;
            this.fld_lkeICShipmentTypeCombo.Location = new System.Drawing.Point(987, 32);
            this.fld_lkeICShipmentTypeCombo.Name = "fld_lkeICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICShipmentTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentTypeCombo.Properties.ColumnName = null;
            this.fld_lkeICShipmentTypeCombo.Properties.NullText = "";
            this.fld_lkeICShipmentTypeCombo.Properties.PopupWidth = 40;
            this.fld_lkeICShipmentTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICShipmentTypeCombo.Screen = null;
            this.fld_lkeICShipmentTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICShipmentTypeCombo.TabIndex = 7;
            this.fld_lkeICShipmentTypeCombo.Tag = "DC";
            this.fld_lkeICShipmentTypeCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICShipmentTypeCombo_CloseUp);
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
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(869, 35);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(64, 13);
            this.bosLabel6.TabIndex = 13;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Loại xuất kho";
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
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(1014, 135);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(123, 27);
            this.fld_btnShowInventoryStock.TabIndex = 18;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Visible = false;
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // fld_btnShowReceiptList
            // 
            this.fld_btnShowReceiptList.BOSComment = null;
            this.fld_btnShowReceiptList.BOSDataMember = null;
            this.fld_btnShowReceiptList.BOSDataSource = null;
            this.fld_btnShowReceiptList.BOSDescription = null;
            this.fld_btnShowReceiptList.BOSError = null;
            this.fld_btnShowReceiptList.BOSFieldGroup = null;
            this.fld_btnShowReceiptList.BOSFieldRelation = null;
            this.fld_btnShowReceiptList.BOSPrivilege = null;
            this.fld_btnShowReceiptList.BOSPropertyName = null;
            this.fld_btnShowReceiptList.Location = new System.Drawing.Point(883, 135);
            this.fld_btnShowReceiptList.Name = "fld_btnShowReceiptList";
            this.fld_btnShowReceiptList.Screen = null;
            this.fld_btnShowReceiptList.Size = new System.Drawing.Size(114, 27);
            this.fld_btnShowReceiptList.TabIndex = 17;
            this.fld_btnShowReceiptList.Text = "Danh sách nhập kho";
            this.fld_btnShowReceiptList.Visible = false;
            this.fld_btnShowReceiptList.Click += new System.EventHandler(this.fld_btnShowReceiptList_Click);
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
            this.fld_tabShiptmentItems.Location = new System.Drawing.Point(3, 168);
            this.fld_tabShiptmentItems.Name = "fld_tabShiptmentItems";
            this.fld_tabShiptmentItems.Screen = null;
            this.fld_tabShiptmentItems.SelectedTabPage = this.fld_tabPageShipmentItems;
            this.fld_tabShiptmentItems.Size = new System.Drawing.Size(1207, 588);
            this.fld_tabShiptmentItems.TabIndex = 37;
            this.fld_tabShiptmentItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageShipmentItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageShipmentItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_pteICShipmentItemProductPicture);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcICShipmentItems);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(1205, 563);
            this.fld_tabPageShipmentItems.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentItems";
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1016, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 2;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.Visible = false;
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
            this.bosLabel13.Location = new System.Drawing.Point(6, 13);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 1;
            this.bosLabel13.Text = "Sản phẩm";
            this.bosLabel13.Visible = false;
            // 
            // fld_pteICShipmentItemProductPicture
            // 
            this.fld_pteICShipmentItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICShipmentItemProductPicture.BOSComment = "";
            this.fld_pteICShipmentItemProductPicture.BOSDataMember = "ICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.BOSDataSource = "ICShipmentItems";
            this.fld_pteICShipmentItemProductPicture.BOSDescription = null;
            this.fld_pteICShipmentItemProductPicture.BOSError = null;
            this.fld_pteICShipmentItemProductPicture.BOSFieldGroup = "";
            this.fld_pteICShipmentItemProductPicture.BOSFieldRelation = "";
            this.fld_pteICShipmentItemProductPicture.BOSPrivilege = "";
            this.fld_pteICShipmentItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICShipmentItemProductPicture.EditValue = "";
            this.fld_pteICShipmentItemProductPicture.FileName = null;
            this.fld_pteICShipmentItemProductPicture.FilePath = null;
            this.fld_pteICShipmentItemProductPicture.Location = new System.Drawing.Point(1081, 10);
            this.fld_pteICShipmentItemProductPicture.Name = "fld_pteICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentItemProductPicture.Screen = null;
            this.fld_pteICShipmentItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteICShipmentItemProductPicture.TabIndex = 0;
            this.fld_pteICShipmentItemProductPicture.Tag = "DC";
            // 
            // fld_dgcICShipmentItems
            // 
            this.fld_dgcICShipmentItems.AllowDrop = true;
            this.fld_dgcICShipmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentItems.BOSComment = "";
            this.fld_dgcICShipmentItems.BOSDataMember = "";
            this.fld_dgcICShipmentItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItems.BOSDescription = null;
            this.fld_dgcICShipmentItems.BOSError = null;
            this.fld_dgcICShipmentItems.BOSFieldGroup = "";
            this.fld_dgcICShipmentItems.BOSFieldRelation = "";
            this.fld_dgcICShipmentItems.BOSGridType = null;
            this.fld_dgcICShipmentItems.BOSPrivilege = "";
            this.fld_dgcICShipmentItems.BOSPropertyName = null;
            this.fld_dgcICShipmentItems.CommodityType = "";
            this.fld_dgcICShipmentItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentItems.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcICShipmentItems.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICShipmentItems.Name = "fld_dgcICShipmentItems";
            this.fld_dgcICShipmentItems.PrintReport = false;
            this.fld_dgcICShipmentItems.Screen = null;
            this.fld_dgcICShipmentItems.Size = new System.Drawing.Size(1069, 517);
            this.fld_dgcICShipmentItems.TabIndex = 3;
            this.fld_dgcICShipmentItems.Tag = "DC";
            this.fld_dgcICShipmentItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICShipmentItems;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1191, 576);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1191, 576);
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
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = false;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICShipments";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = "";
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(454, 58);
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID.Properties.NullText = "";
            this.fld_lkeICProductID.Properties.PopupWidth = 40;
            this.fld_lkeICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductID.TabIndex = 9;
            this.fld_lkeICProductID.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(354, 61);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(59, 13);
            this.bosLabel5.TabIndex = 19;
            this.bosLabel5.Text = "Thành phẩm";
            // 
            // fld_lkeFK_MMReceiveOperationID
            // 
            this.fld_lkeFK_MMReceiveOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMReceiveOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMReceiveOperationID.BOSComment = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSDataMember = "FK_MMReceiveOperationID";
            this.fld_lkeFK_MMReceiveOperationID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMReceiveOperationID.BOSDescription = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSError = "";
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMReceiveOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMReceiveOperationID.BOSSelectTypeValue = "True";
            this.fld_lkeFK_MMReceiveOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMReceiveOperationID.Location = new System.Drawing.Point(454, 110);
            this.fld_lkeFK_MMReceiveOperationID.Name = "fld_lkeFK_MMReceiveOperationID";
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMReceiveOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMReceiveOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMReceiveOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMReceiveOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMReceiveOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMReceiveOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMReceiveOperationID.Screen = null;
            this.fld_lkeFK_MMReceiveOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMReceiveOperationID.TabIndex = 15;
            this.fld_lkeFK_MMReceiveOperationID.Tag = "DC";
            this.fld_lkeFK_MMReceiveOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMReceiveOperationID_QueryPopUp);
            this.fld_lkeFK_MMReceiveOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMReceiveOperationID_CloseUp);
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
            this.bosLabel7.Location = new System.Drawing.Point(354, 113);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(79, 13);
            this.bosLabel7.TabIndex = 33;
            this.bosLabel7.Text = "Công đoạn nhận";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
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
            this.fld_lkeFK_MMOperationID.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "True";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(454, 84);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 13;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeFK_MMOperationID_QueryPopUp);
            this.fld_lkeFK_MMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMOperationID_CloseUp);
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
            this.bosLabel4.Location = new System.Drawing.Point(354, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(77, 13);
            this.bosLabel4.TabIndex = 26;
            this.bosLabel4.Text = "CĐ NK tiếp theo";
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
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(185, 58);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 8;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_MMBatchProductID_EditValueChanged);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(119, 59);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(17, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "LSX";
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
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(185, 84);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(150, 46);
            this.fld_medICShipmentDesc.TabIndex = 12;
            this.fld_medICShipmentDesc.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(119, 86);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 24;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(987, 7);
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
            this.fld_lkeFK_ACSegmentID.TabIndex = 3;
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
            this.bosLabel9.Location = new System.Drawing.Point(869, 10);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 5;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Khoản mục chi phí";
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
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(454, 7);
            this.fld_dteICShipmentDate.Name = "fld_dteICShipmentDate";
            this.fld_dteICShipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate.Properties.BeepOnError = false;
            this.fld_dteICShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate.Properties.DisplayFormat.FormatString = "G";
            this.fld_dteICShipmentDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICShipmentDate.Properties.EditFormat.FormatString = "G";
            this.fld_dteICShipmentDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICShipmentDate.Properties.MaskSettings.Set("mask", "G");
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(454, 32);
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(354, 10);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 3;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày chứng từ";
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
            this.fld_Lablel3.Location = new System.Drawing.Point(354, 35);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 11;
            this.fld_Lablel3.Text = "Kho";
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
            this.fld_ptePictureEdit.Location = new System.Drawing.Point(7, 6);
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(7, 106);
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 32;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(119, 35);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 28;
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
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(185, 33);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.ColumnName = null;
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 4;
            this.fld_lkeICShipmentStatus.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(119, 10);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(61, 13);
            this.bosLabel8.TabIndex = 1;
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
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(185, 7);
            this.fld_txtICShipmentNo1.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentNo1.TabIndex = 0;
            this.fld_txtICShipmentNo1.Tag = "DC";
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
            this.bosTextBox8.Location = new System.Drawing.Point(987, 109);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.ReadOnly = true;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox8.TabIndex = 850;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(869, 112);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(94, 13);
            this.bosLabel20.TabIndex = 849;
            this.bosLabel20.Text = "Mã đơn hàng nội bộ";
            // 
            // DMSPSM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1213, 759);
            this.Controls.Add(this.Panel);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSPSM100.IconOptions.Icon")));
            this.Name = "DMSPSM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceverID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMMachineUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).EndInit();
            this.fld_tabShiptmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMReceiveOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel Panel;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentStatus;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
        private BOSComponent.BOSPictureEdit fld_ptePictureEdit;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTabControl fld_tabShiptmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSERP.Modules.SemiProductShipment.ICShipmentItemsGridControl fld_dgcICShipmentItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSButton fld_btnShowReceiptList;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentTypeCombo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICImportAndExportReasonID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_LineID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMMachineUnitID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentItemProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMReceiveOperationID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseOrderID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeReceverID;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel20;
    }
}
