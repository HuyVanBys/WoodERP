using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
	/// <summary>
	/// Summary description for DMSPRC100
	/// </summary>
	partial class DMSPRC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSPRC100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDeliveryEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMMachineUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_LineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMBatchProductItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcReceiptItems = new BOSERP.Modules.SemiProductReceipt.ICReceiptItemsGridControl();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnShowReceiptList = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkChooseProspectCustomer = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lkeMMUpdatePositionItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDeliveryEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMMachineUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionItemID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lnkChooseProspectCustomer);
            this.bosPanel1.Controls.Add(this.fld_lkeMMUpdatePositionItemID);
            this.bosPanel1.Controls.Add(this.bosLabel);
            this.bosPanel1.Controls.Add(this.bosTextBox8);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDeliveryEmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMMachineUnitID);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_LineID);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_btnFind);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductItemID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptTypeCombo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Controls.Add(this.fld_btnShowReceiptList);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosPanel1.Controls.Add(this.BOSLabel2);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1376, 763);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = null;
            this.bosTextBox8.BOSDataMember = "ICReceiptSOName";
            this.bosTextBox8.BOSDataSource = "ICReceipts";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = null;
            this.bosTextBox8.BOSFieldRelation = null;
            this.bosTextBox8.BOSPrivilege = null;
            this.bosTextBox8.BOSPropertyName = "EditValue";
            this.bosTextBox8.Location = new System.Drawing.Point(1009, 113);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.ReadOnly = true;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(142, 20);
            this.bosTextBox8.TabIndex = 848;
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
            this.bosLabel20.Location = new System.Drawing.Point(908, 115);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(94, 13);
            this.bosLabel20.TabIndex = 847;
            this.bosLabel20.Text = "Mã đơn hàng nội bộ";
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
            this.bosLabel3.Location = new System.Drawing.Point(634, 116);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(51, 13);
            this.bosLabel3.TabIndex = 48;
            this.bosLabel3.Text = "Người giao";
            // 
            // fld_lkeFK_HRDeliveryEmployeeID
            // 
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSComment = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSDataMember = "FK_HRDeliveryEmployeeID";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSError = null;
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.Location = new System.Drawing.Point(737, 113);
            this.fld_lkeFK_HRDeliveryEmployeeID.Name = "fld_lkeFK_HRDeliveryEmployeeID";
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã NV"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên NV"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDeliveryEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRDeliveryEmployeeID.Screen = null;
            this.fld_lkeFK_HRDeliveryEmployeeID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_HRDeliveryEmployeeID.TabIndex = 47;
            this.fld_lkeFK_HRDeliveryEmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_MMMachineUnitID
            // 
            this.fld_lkeFK_MMMachineUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMMachineUnitID.BOSAllowDummy = true;
            this.fld_lkeFK_MMMachineUnitID.BOSComment = "";
            this.fld_lkeFK_MMMachineUnitID.BOSDataMember = "FK_MMMachineUnitID";
            this.fld_lkeFK_MMMachineUnitID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_MMMachineUnitID.Location = new System.Drawing.Point(1009, 62);
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
            this.fld_lkeFK_MMMachineUnitID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_MMMachineUnitID.TabIndex = 44;
            this.fld_lkeFK_MMMachineUnitID.Tag = "DC";
            this.fld_lkeFK_MMMachineUnitID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMMachineUnitID_QueryPopUp);
            this.fld_lkeFK_MMMachineUnitID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMMachineUnitID_CloseUp);
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
            this.bosLabel19.Location = new System.Drawing.Point(908, 65);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(35, 13);
            this.bosLabel19.TabIndex = 43;
            this.bosLabel19.Text = "Tổ máy";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(1009, 10);
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
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 9;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            this.fld_lkeFK_MMWorkShopID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMWorkShopID_QueryPopUp);
            this.fld_lkeFK_MMWorkShopID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMWorkShopID_CloseUp);
            // 
            // fld_lkeFK_LineID
            // 
            this.fld_lkeFK_LineID.BOSAllowAddNew = false;
            this.fld_lkeFK_LineID.BOSAllowDummy = true;
            this.fld_lkeFK_LineID.BOSComment = "";
            this.fld_lkeFK_LineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_LineID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_LineID.Location = new System.Drawing.Point(1009, 36);
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
            this.fld_lkeFK_LineID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_LineID.TabIndex = 17;
            this.fld_lkeFK_LineID.Tag = "DC";
            this.fld_lkeFK_LineID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_LineID_QueryPopUp);
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
            this.bosLabel16.Location = new System.Drawing.Point(908, 15);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(31, 13);
            this.bosLabel16.TabIndex = 8;
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
            this.bosLabel17.Location = new System.Drawing.Point(908, 41);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(37, 13);
            this.bosLabel17.TabIndex = 16;
            this.bosLabel17.Text = "Chuyền";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(1071, 139);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(157, 35);
            this.fld_btnFind.TabIndex = 39;
            this.fld_btnFind.Text = "Nhập theo kiện";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_MMBatchProductItemID
            // 
            this.fld_lkeFK_MMBatchProductItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductItemID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductItemID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSDataMember = "FK_MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMBatchProductItemID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSError = "";
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductItemID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductItemID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductItemID.Location = new System.Drawing.Point(480, 87);
            this.fld_lkeFK_MMBatchProductItemID.Name = "fld_lkeFK_MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductItemID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductSerial", "Mã lô"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductDesc", "Mô tả")});
            this.fld_lkeFK_MMBatchProductItemID.Properties.DisplayMember = "MMBatchProductItemProductNo";
            this.fld_lkeFK_MMBatchProductItemID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductItemID.Properties.ValueMember = "MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.Screen = null;
            this.fld_lkeFK_MMBatchProductItemID.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeFK_MMBatchProductItemID.TabIndex = 37;
            this.fld_lkeFK_MMBatchProductItemID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMBatchProductItemID_QueryPopUp);
            this.fld_lkeFK_MMBatchProductItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductItemID_CloseUp);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(1009, 88);
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
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 25;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp);
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
            this.bosLabel18.Location = new System.Drawing.Point(908, 90);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(28, 13);
            this.bosLabel18.TabIndex = 24;
            this.bosLabel18.Text = "Tổ NV";
            // 
            // fld_txtICReceiptPackNo
            // 
            this.fld_txtICReceiptPackNo.BOSComment = null;
            this.fld_txtICReceiptPackNo.BOSDataMember = "ICReceiptPackNo";
            this.fld_txtICReceiptPackNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptPackNo.BOSDescription = null;
            this.fld_txtICReceiptPackNo.BOSError = null;
            this.fld_txtICReceiptPackNo.BOSFieldGroup = null;
            this.fld_txtICReceiptPackNo.BOSFieldRelation = null;
            this.fld_txtICReceiptPackNo.BOSPrivilege = null;
            this.fld_txtICReceiptPackNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptPackNo.Location = new System.Drawing.Point(737, 87);
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptPackNo.Screen = null;
            this.fld_txtICReceiptPackNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICReceiptPackNo.TabIndex = 31;
            this.fld_txtICReceiptPackNo.Tag = "DC";
            this.fld_txtICReceiptPackNo.Validated += new System.EventHandler(this.fld_txtICReceiptPackNo_Validated);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel12.Location = new System.Drawing.Point(634, 91);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(52, 13);
            this.bosLabel12.TabIndex = 30;
            this.bosLabel12.Text = "Mã lô hàng";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(1202, 8);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 33;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.Visible = false;
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
            this.bosLabel11.Location = new System.Drawing.Point(1170, 10);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(26, 13);
            this.bosLabel11.TabIndex = 32;
            this.bosLabel11.Text = "TTMT";
            this.bosLabel11.Visible = false;
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(196, 61);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 27;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(113, 66);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(56, 13);
            this.bosLabel10.TabIndex = 26;
            this.bosLabel10.Text = "Khách hàng";
            // 
            // fld_lkeICReceiptTypeCombo
            // 
            this.fld_lkeICReceiptTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeICReceiptTypeCombo.BOSAllowDummy = false;
            this.fld_lkeICReceiptTypeCombo.BOSComment = null;
            this.fld_lkeICReceiptTypeCombo.BOSDataMember = "ICReceiptTypeCombo";
            this.fld_lkeICReceiptTypeCombo.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptTypeCombo.BOSDescription = null;
            this.fld_lkeICReceiptTypeCombo.BOSError = null;
            this.fld_lkeICReceiptTypeCombo.BOSFieldGroup = null;
            this.fld_lkeICReceiptTypeCombo.BOSFieldParent = null;
            this.fld_lkeICReceiptTypeCombo.BOSFieldRelation = null;
            this.fld_lkeICReceiptTypeCombo.BOSPrivilege = null;
            this.fld_lkeICReceiptTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptTypeCombo.BOSSelectType = null;
            this.fld_lkeICReceiptTypeCombo.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptTypeCombo.CurrentDisplayText = null;
            this.fld_lkeICReceiptTypeCombo.Location = new System.Drawing.Point(480, 35);
            this.fld_lkeICReceiptTypeCombo.Name = "fld_lkeICReceiptTypeCombo";
            this.fld_lkeICReceiptTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeICReceiptTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICReceiptTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICReceiptTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICReceiptTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptTypeCombo.Properties.ColumnName = null;
            this.fld_lkeICReceiptTypeCombo.Properties.NullText = "";
            this.fld_lkeICReceiptTypeCombo.Properties.ReadOnly = true;
            this.fld_lkeICReceiptTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICReceiptTypeCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICReceiptTypeCombo, true);
            this.fld_lkeICReceiptTypeCombo.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeICReceiptTypeCombo.TabIndex = 21;
            this.fld_lkeICReceiptTypeCombo.Tag = "DC";
            this.fld_lkeICReceiptTypeCombo.EditValueChanged += new System.EventHandler(this.fld_lkeICReceiptTypeCombo_EditValueChanged);
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
            this.bosLabel9.Location = new System.Drawing.Point(382, 40);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(66, 13);
            this.bosLabel9.TabIndex = 20;
            this.bosLabel9.Text = "Loại nhập kho";
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(4, 175);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(1369, 585);
            this.fld_tabReceiptItems.TabIndex = 42;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_dgcReceiptItems);
            this.fld_tabPageReceiptItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(1367, 560);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcReceiptItems
            // 
            this.fld_dgcReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptItems.BOSComment = null;
            this.fld_dgcReceiptItems.BOSDataMember = null;
            this.fld_dgcReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcReceiptItems.BOSDescription = null;
            this.fld_dgcReceiptItems.BOSError = null;
            this.fld_dgcReceiptItems.BOSFieldGroup = null;
            this.fld_dgcReceiptItems.BOSFieldRelation = null;
            this.fld_dgcReceiptItems.BOSGridType = null;
            this.fld_dgcReceiptItems.BOSPrivilege = null;
            this.fld_dgcReceiptItems.BOSPropertyName = null;
            this.fld_dgcReceiptItems.CommodityType = "";
            this.fld_dgcReceiptItems.Location = new System.Drawing.Point(7, 10);
            this.fld_dgcReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptItems.Name = "fld_dgcReceiptItems";
            this.fld_dgcReceiptItems.PrintReport = false;
            this.fld_dgcReceiptItems.Screen = null;
            this.fld_dgcReceiptItems.Size = new System.Drawing.Size(1356, 546);
            this.fld_dgcReceiptItems.TabIndex = 0;
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
            this.bosLabel13.Location = new System.Drawing.Point(10, 13);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 1;
            this.bosLabel13.Text = "Sản phẩm";
            this.bosLabel13.Visible = false;
            // 
            // fld_lkeFK_ICProductID1
            // 
            this.fld_lkeFK_ICProductID1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID1.BOSComment = null;
            this.fld_lkeFK_ICProductID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID1.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID1.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = null;
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID1.Location = new System.Drawing.Point(78, 10);
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID1.Properties.NullText = "";
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.fld_lkeFK_ICProductID1.Size = new System.Drawing.Size(1156, 20);
            this.fld_lkeFK_ICProductID1.TabIndex = 2;
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            this.fld_lkeFK_ICProductID1.Visible = false;
            this.fld_lkeFK_ICProductID1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID1_KeyUp);
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1353, 553);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1353, 553);
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
            this.fld_btnShowReceiptList.Location = new System.Drawing.Point(908, 139);
            this.fld_btnShowReceiptList.Name = "fld_btnShowReceiptList";
            this.fld_btnShowReceiptList.Screen = null;
            this.fld_btnShowReceiptList.Size = new System.Drawing.Size(157, 35);
            this.fld_btnShowReceiptList.TabIndex = 6;
            this.fld_btnShowReceiptList.Text = "Danh sách BTP";
            this.fld_btnShowReceiptList.Click += new System.EventHandler(this.fld_btnShowReceiptList_Click);
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
            this.bosLabel4.Location = new System.Drawing.Point(382, 91);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 36;
            this.bosLabel4.Text = "Thành phẩm";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = "";
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(480, 61);
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
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(138, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 29;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMOperationID_QueryPopUp);
            this.fld_lkeFK_MMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMOperationID_CloseUp);
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
            this.bosLabel7.Location = new System.Drawing.Point(382, 66);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 28;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(196, 86);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductSOName", "Mã đơn hàng nội bộ")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 35;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(113, 92);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(17, 13);
            this.bosLabel8.TabIndex = 34;
            this.bosLabel8.Text = "LSX";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICReceiptDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(196, 113);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(422, 55);
            this.fld_medICReceiptDesc.TabIndex = 41;
            this.fld_medICReceiptDesc.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(113, 124);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 40;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(737, 139);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 13;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(634, 143);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(85, 13);
            this.bosLabel6.TabIndex = 12;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Khoản mục chi phí";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(737, 61);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 23;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(196, 35);
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
            this.fld_lkeFK_ICStockID1.TabIndex = 19;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(382, 13);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 4;
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(634, 13);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 6;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(634, 39);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(29, 13);
            this.bosLabel15.TabIndex = 14;
            this.bosLabel15.Text = "Tỷ giá";
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
            this.bosLabel14.Location = new System.Drawing.Point(634, 65);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(53, 13);
            this.bosLabel14.TabIndex = 22;
            this.bosLabel14.Text = "Loại tiền tệ";
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
            this.fld_Lablel3.Location = new System.Drawing.Point(113, 40);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 18;
            this.fld_Lablel3.Text = "Kho";
            // 
            // fld_dteICReceiptDate
            // 
            this.fld_dteICReceiptDate.BOSComment = null;
            this.fld_dteICReceiptDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate.BOSDescription = null;
            this.fld_dteICReceiptDate.BOSError = null;
            this.fld_dteICReceiptDate.BOSFieldGroup = null;
            this.fld_dteICReceiptDate.BOSFieldRelation = null;
            this.fld_dteICReceiptDate.BOSPrivilege = null;
            this.fld_dteICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate.EditValue = null;
            this.fld_dteICReceiptDate.Location = new System.Drawing.Point(480, 9);
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Properties.DisplayFormat.FormatString = "G";
            this.fld_dteICReceiptDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICReceiptDate.Properties.EditFormat.FormatString = "G";
            this.fld_dteICReceiptDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICReceiptDate.Properties.MaskSettings.Set("mask", "G");
            this.fld_dteICReceiptDate.Screen = null;
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(138, 20);
            this.fld_dteICReceiptDate.TabIndex = 5;
            this.fld_dteICReceiptDate.Tag = "DC";
            this.fld_dteICReceiptDate.Validated += new System.EventHandler(this.fld_dteICReceiptDate_Validated);
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
            this.bosLabel1.Location = new System.Drawing.Point(113, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 2;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_lkeICReceiptStatus
            // 
            this.fld_lkeICReceiptStatus.BOSAllowAddNew = false;
            this.fld_lkeICReceiptStatus.BOSAllowDummy = false;
            this.fld_lkeICReceiptStatus.BOSComment = null;
            this.fld_lkeICReceiptStatus.BOSDataMember = "ICReceiptStatus";
            this.fld_lkeICReceiptStatus.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptStatus.BOSDescription = null;
            this.fld_lkeICReceiptStatus.BOSError = null;
            this.fld_lkeICReceiptStatus.BOSFieldGroup = null;
            this.fld_lkeICReceiptStatus.BOSFieldParent = null;
            this.fld_lkeICReceiptStatus.BOSFieldRelation = null;
            this.fld_lkeICReceiptStatus.BOSPrivilege = null;
            this.fld_lkeICReceiptStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptStatus.BOSSelectType = null;
            this.fld_lkeICReceiptStatus.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptStatus.CurrentDisplayText = null;
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(737, 9);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ColumnName = null;
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 7;
            this.fld_lkeICReceiptStatus.Tag = "DC";
            // 
            // fld_txtICReceiptExchangeRate
            // 
            this.fld_txtICReceiptExchangeRate.BOSComment = null;
            this.fld_txtICReceiptExchangeRate.BOSDataMember = "ICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptExchangeRate.BOSDescription = null;
            this.fld_txtICReceiptExchangeRate.BOSError = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldGroup = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldRelation = null;
            this.fld_txtICReceiptExchangeRate.BOSPrivilege = null;
            this.fld_txtICReceiptExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(737, 35);
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 15;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            this.fld_txtICReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtICReceiptExchangeRate_Validated);
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = null;
            this.fld_txtICReceiptNo.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = null;
            this.fld_txtICReceiptNo.BOSFieldRelation = null;
            this.fld_txtICReceiptNo.BOSPrivilege = null;
            this.fld_txtICReceiptNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(196, 9);
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo.TabIndex = 3;
            this.fld_txtICReceiptNo.Tag = "DC";
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICReceiptEmployeePicture.FileName = null;
            this.fld_pteICReceiptEmployeePicture.FilePath = null;
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(6, 10);
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 0;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(6, 109);
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
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lnkChooseProspectCustomer
            // 
            this.fld_lnkChooseProspectCustomer.EditValue = "Thêm mới vị trí";
            this.fld_lnkChooseProspectCustomer.Location = new System.Drawing.Point(1266, 64);
            this.fld_lnkChooseProspectCustomer.Name = "fld_lnkChooseProspectCustomer";
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkChooseProspectCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkChooseProspectCustomer.Size = new System.Drawing.Size(78, 18);
            this.fld_lnkChooseProspectCustomer.TabIndex = 851;
            this.fld_lnkChooseProspectCustomer.TabStop = false;
            this.fld_lnkChooseProspectCustomer.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkChooseProspectCustomer_OpenLink);
            // 
            // fld_lkeMMUpdatePositionItemID
            // 
            this.fld_lkeMMUpdatePositionItemID.BOSAllowAddNew = true;
            this.fld_lkeMMUpdatePositionItemID.BOSAllowDummy = true;
            this.fld_lkeMMUpdatePositionItemID.BOSComment = "";
            this.fld_lkeMMUpdatePositionItemID.BOSDataMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.BOSDataSource = "ICReceipts";
            this.fld_lkeMMUpdatePositionItemID.BOSDescription = null;
            this.fld_lkeMMUpdatePositionItemID.BOSError = null;
            this.fld_lkeMMUpdatePositionItemID.BOSFieldGroup = "";
            this.fld_lkeMMUpdatePositionItemID.BOSFieldParent = "";
            this.fld_lkeMMUpdatePositionItemID.BOSFieldRelation = "";
            this.fld_lkeMMUpdatePositionItemID.BOSPrivilege = "";
            this.fld_lkeMMUpdatePositionItemID.BOSPropertyName = "EditValue";
            this.fld_lkeMMUpdatePositionItemID.BOSSelectType = "";
            this.fld_lkeMMUpdatePositionItemID.BOSSelectTypeValue = "";
            this.fld_lkeMMUpdatePositionItemID.CurrentDisplayText = null;
            this.fld_lkeMMUpdatePositionItemID.Location = new System.Drawing.Point(1202, 36);
            this.fld_lkeMMUpdatePositionItemID.Name = "fld_lkeMMUpdatePositionItemID";
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMUpdatePositionItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMUpdatePositionItemID.Properties.ColumnName = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMUpdatePositionItemPositionName", "Vị trí")});
            this.fld_lkeMMUpdatePositionItemID.Properties.DisplayMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Properties.NullText = "";
            this.fld_lkeMMUpdatePositionItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMUpdatePositionItemID.Properties.ValueMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Screen = null;
            this.fld_lkeMMUpdatePositionItemID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeMMUpdatePositionItemID.TabIndex = 849;
            this.fld_lkeMMUpdatePositionItemID.Tag = "DC";
            this.fld_lkeMMUpdatePositionItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMUpdatePositionItemID_CloseUp);
            // 
            // bosLabel
            // 
            this.bosLabel.BOSComment = null;
            this.bosLabel.BOSDataMember = null;
            this.bosLabel.BOSDataSource = null;
            this.bosLabel.BOSDescription = null;
            this.bosLabel.BOSError = null;
            this.bosLabel.BOSFieldGroup = null;
            this.bosLabel.BOSFieldRelation = null;
            this.bosLabel.BOSPrivilege = null;
            this.bosLabel.BOSPropertyName = null;
            this.bosLabel.Location = new System.Drawing.Point(1170, 38);
            this.bosLabel.Name = "bosLabel";
            this.bosLabel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel, true);
            this.bosLabel.Size = new System.Drawing.Size(21, 13);
            this.bosLabel.TabIndex = 850;
            this.bosLabel.Text = "Vị trí";
            // 
            // DMSPRC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1376, 763);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSPRC100.IconOptions.Icon")));
            this.Name = "DMSPRC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDeliveryEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMMachineUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_LineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionItemID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSDateEdit fld_dteICReceiptDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
        private BOSComponent.BOSTextBox fld_txtICReceiptExchangeRate;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSButton fld_btnShowReceiptList;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private BOSERP.Modules.SemiProductReceipt.ICReceiptItemsGridControl fld_dgcReceiptItems;
        private BOSComponent.BOSLabel bosLabel13;
        private ItemLookupEdit fld_lkeFK_ICProductID1;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptTypeCombo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSTextBox fld_txtICReceiptPackNo;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductItemID;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_LineID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMMachineUnitID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDeliveryEmployeeID;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel20;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkChooseProspectCustomer;
        private BOSComponent.BOSLookupEdit fld_lkeMMUpdatePositionItemID;
        private BOSComponent.BOSLabel bosLabel;
    }
}
