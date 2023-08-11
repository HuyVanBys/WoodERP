using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Transfer.UI
{
	/// <summary>
	/// Summary description for DMTS100
	/// </summary>
	partial class DMTS100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteICTransferEmployeePicture;
        private BOSComponent.BOSLabel fld_Lablel2;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID1;
        private BOSComponent.BOSMemoEdit fld_medICTransferDesc;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMTS100));
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteICTransferEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICFromStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICTransferDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteICTransferDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICTransferNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICTransferStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tabTransferItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAutoSelectProductSerialNo = new BOSComponent.BOSButton(this.components);
            this.fld_btnImportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_pteICTransferItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICTransferItems = new BOSERP.Modules.Transfer.ICTransferItemsGridControl();
            this.fld_dgvICTransferItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveAccounting = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreateDocument = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_txtICTransferMatchCode02Combo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICTransferReference = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICTransferMatchCode01Combo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICTransferType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTransferDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferStatus.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).BeginInit();
            this.fld_tabTransferItems.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransferItems)).BeginInit();
            this.fld_tabDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferMatchCode02Combo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferMatchCode01Combo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICTransferItems";
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
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(74, 11);
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
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(848, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryCloseUp);
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = "";
            this.fld_Lablel.BOSDataMember = "";
            this.fld_Lablel.BOSDataSource = "";
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = "";
            this.fld_Lablel.BOSFieldRelation = "";
            this.fld_Lablel.BOSPrivilege = "";
            this.fld_Lablel.BOSPropertyName = null;
            this.fld_Lablel.Location = new System.Drawing.Point(10, 14);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 390;
            this.fld_Lablel.Tag = "";
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICTransfers";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 106);
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
            // fld_pteICTransferEmployeePicture
            // 
            this.fld_pteICTransferEmployeePicture.BOSComment = "";
            this.fld_pteICTransferEmployeePicture.BOSDataMember = "ICTransferEmployeePicture";
            this.fld_pteICTransferEmployeePicture.BOSDataSource = "ICTransfers";
            this.fld_pteICTransferEmployeePicture.BOSDescription = null;
            this.fld_pteICTransferEmployeePicture.BOSError = "";
            this.fld_pteICTransferEmployeePicture.BOSFieldGroup = "";
            this.fld_pteICTransferEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICTransferEmployeePicture.BOSPrivilege = "";
            this.fld_pteICTransferEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICTransferEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICTransferEmployeePicture.FileName = null;
            this.fld_pteICTransferEmployeePicture.FilePath = null;
            this.fld_pteICTransferEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICTransferEmployeePicture.Name = "fld_pteICTransferEmployeePicture";
            this.fld_pteICTransferEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICTransferEmployeePicture.Screen = null;
            this.fld_pteICTransferEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICTransferEmployeePicture.TabIndex = 0;
            this.fld_pteICTransferEmployeePicture.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
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
            this.fld_Lablel2.Location = new System.Drawing.Point(127, 92);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Tình trạng";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(127, 41);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 481;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Từ kho";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(411, 41);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 482;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Đến kho";
            // 
            // fld_lkeFK_ICFromStockID1
            // 
            this.fld_lkeFK_ICFromStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID1.BOSComment = "";
            this.fld_lkeFK_ICFromStockID1.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICFromStockID1.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID1.BOSError = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICFromStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICFromStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICFromStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICFromStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICFromStockID1.Location = new System.Drawing.Point(233, 38);
            this.fld_lkeFK_ICFromStockID1.Name = "fld_lkeFK_ICFromStockID1";
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICFromStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICFromStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID1.Screen = null;
            this.fld_lkeFK_ICFromStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID1.TabIndex = 5;
            this.fld_lkeFK_ICFromStockID1.Tag = "DC";
            this.fld_lkeFK_ICFromStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICFromStockID1_CloseUp);
            // 
            // fld_lkeFK_ICToStockID1
            // 
            this.fld_lkeFK_ICToStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID1.BOSComment = "";
            this.fld_lkeFK_ICToStockID1.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICToStockID1.BOSDescription = null;
            this.fld_lkeFK_ICToStockID1.BOSError = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICToStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICToStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICToStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICToStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICToStockID1.Location = new System.Drawing.Point(501, 38);
            this.fld_lkeFK_ICToStockID1.Name = "fld_lkeFK_ICToStockID1";
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICToStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICToStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID1.Screen = null;
            this.fld_lkeFK_ICToStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID1.TabIndex = 6;
            this.fld_lkeFK_ICToStockID1.Tag = "DC";
            this.fld_lkeFK_ICToStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICToStockID1_CloseUp);
            // 
            // fld_medICTransferDesc
            // 
            this.fld_medICTransferDesc.BOSComment = "";
            this.fld_medICTransferDesc.BOSDataMember = "ICTransferDesc";
            this.fld_medICTransferDesc.BOSDataSource = "ICTransfers";
            this.fld_medICTransferDesc.BOSDescription = null;
            this.fld_medICTransferDesc.BOSError = "";
            this.fld_medICTransferDesc.BOSFieldGroup = "";
            this.fld_medICTransferDesc.BOSFieldRelation = "";
            this.fld_medICTransferDesc.BOSPrivilege = "";
            this.fld_medICTransferDesc.BOSPropertyName = "Text";
            this.fld_medICTransferDesc.Location = new System.Drawing.Point(233, 115);
            this.fld_medICTransferDesc.Name = "fld_medICTransferDesc";
            this.fld_medICTransferDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICTransferDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICTransferDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICTransferDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICTransferDesc.Screen = null;
            this.fld_medICTransferDesc.Size = new System.Drawing.Size(418, 57);
            this.fld_medICTransferDesc.TabIndex = 13;
            this.fld_medICTransferDesc.Tag = "DC";
            // 
            // fld_dteICTransferDate
            // 
            this.fld_dteICTransferDate.BOSComment = null;
            this.fld_dteICTransferDate.BOSDataMember = "ICTransferDate";
            this.fld_dteICTransferDate.BOSDataSource = "ICTransfers";
            this.fld_dteICTransferDate.BOSDescription = null;
            this.fld_dteICTransferDate.BOSError = null;
            this.fld_dteICTransferDate.BOSFieldGroup = null;
            this.fld_dteICTransferDate.BOSFieldRelation = null;
            this.fld_dteICTransferDate.BOSPrivilege = null;
            this.fld_dteICTransferDate.BOSPropertyName = "EditValue";
            this.fld_dteICTransferDate.EditValue = null;
            this.fld_dteICTransferDate.Location = new System.Drawing.Point(501, 12);
            this.fld_dteICTransferDate.MenuManager = this.screenToolbar;
            this.fld_dteICTransferDate.Name = "fld_dteICTransferDate";
            this.fld_dteICTransferDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDate.Screen = null;
            this.fld_dteICTransferDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDate.TabIndex = 3;
            this.fld_dteICTransferDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(411, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 496;
            this.BOSLabel1.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(127, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 498;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtICTransferNo
            // 
            this.fld_txtICTransferNo.BOSComment = null;
            this.fld_txtICTransferNo.BOSDataMember = "ICTransferNo";
            this.fld_txtICTransferNo.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferNo.BOSDescription = null;
            this.fld_txtICTransferNo.BOSError = null;
            this.fld_txtICTransferNo.BOSFieldGroup = null;
            this.fld_txtICTransferNo.BOSFieldRelation = null;
            this.fld_txtICTransferNo.BOSPrivilege = null;
            this.fld_txtICTransferNo.BOSPropertyName = "EditValue";
            this.fld_txtICTransferNo.Location = new System.Drawing.Point(233, 12);
            this.fld_txtICTransferNo.MenuManager = this.screenToolbar;
            this.fld_txtICTransferNo.Name = "fld_txtICTransferNo";
            this.fld_txtICTransferNo.Screen = null;
            this.fld_txtICTransferNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferNo.TabIndex = 2;
            this.fld_txtICTransferNo.Tag = "DC";
            // 
            // fld_lkeICTransferStatus
            // 
            this.fld_lkeICTransferStatus.BOSAllowAddNew = false;
            this.fld_lkeICTransferStatus.BOSAllowDummy = false;
            this.fld_lkeICTransferStatus.BOSComment = "";
            this.fld_lkeICTransferStatus.BOSDataMember = "ICTransferStatus";
            this.fld_lkeICTransferStatus.BOSDataSource = "ICTransfers";
            this.fld_lkeICTransferStatus.BOSDescription = null;
            this.fld_lkeICTransferStatus.BOSError = "";
            this.fld_lkeICTransferStatus.BOSFieldGroup = "";
            this.fld_lkeICTransferStatus.BOSFieldParent = "";
            this.fld_lkeICTransferStatus.BOSFieldRelation = "";
            this.fld_lkeICTransferStatus.BOSPrivilege = "";
            this.fld_lkeICTransferStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferStatus.BOSSelectType = "";
            this.fld_lkeICTransferStatus.BOSSelectTypeValue = "";
            this.fld_lkeICTransferStatus.CurrentDisplayText = "";
            this.fld_lkeICTransferStatus.Location = new System.Drawing.Point(233, 89);
            this.fld_lkeICTransferStatus.Name = "fld_lkeICTransferStatus";
            this.fld_lkeICTransferStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICTransferStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICTransferStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICTransferStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICTransferStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferStatus.Properties.ColumnName = null;
            this.fld_lkeICTransferStatus.Properties.NullText = "";
            this.fld_lkeICTransferStatus.Properties.PopupWidth = 40;
            this.fld_lkeICTransferStatus.Properties.ReadOnly = true;
            this.fld_lkeICTransferStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICTransferStatus.Screen = null;
            this.fld_lkeICTransferStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICTransferStatus.TabIndex = 10;
            this.fld_lkeICTransferStatus.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APPurchaseOrderID);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_tabTransferItems);
            this.bosPanel1.Controls.Add(this.fld_btnShowInventoryStock);
            this.bosPanel1.Controls.Add(this.fld_medICTransferDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICTransferEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtICTransferMatchCode02Combo);
            this.bosPanel1.Controls.Add(this.fld_txtICTransferReference);
            this.bosPanel1.Controls.Add(this.fld_txtICTransferMatchCode01Combo);
            this.bosPanel1.Controls.Add(this.fld_txtICTransferNo);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICFromStockID1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICToStockID1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeICTransferType);
            this.bosPanel1.Controls.Add(this.fld_lkeICTransferStatus);
            this.bosPanel1.Controls.Add(this.fld_dteICTransferDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1060, 598);
            this.bosPanel1.TabIndex = 499;
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ICTransfers";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(758, 38);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACObjectAccessKey, true);
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 500;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            this.fld_lkeACObjectAccessKey.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICTransfers";
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
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(758, 89);
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
            this.fld_lkeFK_MMBatchProductID.TabIndex = 555;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(668, 92);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(38, 13);
            this.bosLabel10.TabIndex = 556;
            this.bosLabel10.Text = "Lệnh SX";
            // 
            // fld_lkeFK_APPurchaseOrderID
            // 
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSComment = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSDataMember = "FK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.BOSDataSource = "ICTransfers";
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
            this.fld_lkeFK_APPurchaseOrderID.Location = new System.Drawing.Point(758, 115);
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
            this.fld_lkeFK_APPurchaseOrderID.TabIndex = 553;
            this.fld_lkeFK_APPurchaseOrderID.Tag = "DC";
            this.fld_lkeFK_APPurchaseOrderID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_APPurchaseOrderID_QueryPopUp);
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
            this.bosLabel14.Location = new System.Drawing.Point(668, 118);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(70, 13);
            this.bosLabel14.TabIndex = 554;
            this.bosLabel14.Text = "Đơn mua hàng";
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
            this.bosLabel9.Location = new System.Drawing.Point(668, 42);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(55, 13);
            this.bosLabel9.TabIndex = 552;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Người nhận";
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
            this.bosLabel8.Location = new System.Drawing.Point(411, 92);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(77, 13);
            this.bosLabel8.TabIndex = 550;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Loại chuyển kho";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "ICTransferTransferType";
            this.bosLookupEdit1.BOSDataSource = "ICTransfers";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = "";
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = "";
            this.bosLookupEdit1.Enabled = false;
            this.bosLookupEdit1.Location = new System.Drawing.Point(501, 89);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 11;
            this.bosLookupEdit1.Tag = "DC";
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
            this.fld_tabTransferItems.Location = new System.Drawing.Point(3, 178);
            this.fld_tabTransferItems.Name = "fld_tabTransferItems";
            this.fld_tabTransferItems.Screen = null;
            this.fld_tabTransferItems.SelectedTabPage = this.fld_tabProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabTransferItems, true);
            this.fld_tabTransferItems.Size = new System.Drawing.Size(1054, 417);
            this.fld_tabTransferItems.TabIndex = 548;
            this.fld_tabTransferItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct,
            this.fld_tabDocumentEntrys});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_btnAutoSelectProductSerialNo);
            this.fld_tabProduct.Controls.Add(this.fld_btnImportTemplate);
            this.fld_tabProduct.Controls.Add(this.fld_pteICTransferItemProductPicture);
            this.fld_tabProduct.Controls.Add(this.fld_dgcICTransferItems);
            this.fld_tabProduct.Controls.Add(this.fld_Lablel);
            this.fld_tabProduct.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabProduct, true);
            this.fld_tabProduct.Size = new System.Drawing.Size(1052, 392);
            this.fld_tabProduct.Text = "Danh sách sản phẩm";
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
            this.fld_btnAutoSelectProductSerialNo.Location = new System.Drawing.Point(928, 170);
            this.fld_btnAutoSelectProductSerialNo.Name = "fld_btnAutoSelectProductSerialNo";
            this.fld_btnAutoSelectProductSerialNo.Screen = null;
            this.fld_btnAutoSelectProductSerialNo.Size = new System.Drawing.Size(121, 23);
            this.fld_btnAutoSelectProductSerialNo.TabIndex = 392;
            this.fld_btnAutoSelectProductSerialNo.Text = "Tự động gắn lô";
            this.fld_btnAutoSelectProductSerialNo.Click += new System.EventHandler(this.fld_btnAutoSelectProductSerialNo_Click);
            // 
            // fld_btnImportTemplate
            // 
            this.fld_btnImportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnImportTemplate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_btnImportTemplate.Appearance.Options.UseForeColor = true;
            this.fld_btnImportTemplate.BOSComment = null;
            this.fld_btnImportTemplate.BOSDataMember = null;
            this.fld_btnImportTemplate.BOSDataSource = null;
            this.fld_btnImportTemplate.BOSDescription = null;
            this.fld_btnImportTemplate.BOSError = null;
            this.fld_btnImportTemplate.BOSFieldGroup = null;
            this.fld_btnImportTemplate.BOSFieldRelation = null;
            this.fld_btnImportTemplate.BOSPrivilege = null;
            this.fld_btnImportTemplate.BOSPropertyName = null;
            this.fld_btnImportTemplate.Location = new System.Drawing.Point(928, 137);
            this.fld_btnImportTemplate.Name = "fld_btnImportTemplate";
            this.fld_btnImportTemplate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnImportTemplate, true);
            this.fld_btnImportTemplate.Size = new System.Drawing.Size(121, 27);
            this.fld_btnImportTemplate.TabIndex = 391;
            this.fld_btnImportTemplate.Text = "Import SP";
            this.fld_btnImportTemplate.Click += new System.EventHandler(this.fld_btnImportTemplate_Click);
            // 
            // fld_pteICTransferItemProductPicture
            // 
            this.fld_pteICTransferItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICTransferItemProductPicture.BOSComment = "";
            this.fld_pteICTransferItemProductPicture.BOSDataMember = "ICTransferItemProductPicture";
            this.fld_pteICTransferItemProductPicture.BOSDataSource = "ICTransferItems";
            this.fld_pteICTransferItemProductPicture.BOSDescription = null;
            this.fld_pteICTransferItemProductPicture.BOSError = "";
            this.fld_pteICTransferItemProductPicture.BOSFieldGroup = "";
            this.fld_pteICTransferItemProductPicture.BOSFieldRelation = null;
            this.fld_pteICTransferItemProductPicture.BOSPrivilege = "";
            this.fld_pteICTransferItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICTransferItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICTransferItemProductPicture.FileName = null;
            this.fld_pteICTransferItemProductPicture.FilePath = null;
            this.fld_pteICTransferItemProductPicture.Location = new System.Drawing.Point(928, 11);
            this.fld_pteICTransferItemProductPicture.Name = "fld_pteICTransferItemProductPicture";
            this.fld_pteICTransferItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICTransferItemProductPicture.Screen = null;
            this.fld_pteICTransferItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteICTransferItemProductPicture.TabIndex = 1;
            this.fld_pteICTransferItemProductPicture.Tag = "DC";
            // 
            // fld_dgcICTransferItems
            // 
            this.fld_dgcICTransferItems.AllowDrop = true;
            this.fld_dgcICTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferItems.BOSComment = "";
            this.fld_dgcICTransferItems.BOSDataMember = null;
            this.fld_dgcICTransferItems.BOSDataSource = "ICTransferItems";
            this.fld_dgcICTransferItems.BOSDescription = null;
            this.fld_dgcICTransferItems.BOSError = "";
            this.fld_dgcICTransferItems.BOSFieldGroup = "";
            this.fld_dgcICTransferItems.BOSFieldRelation = null;
            this.fld_dgcICTransferItems.BOSGridType = null;
            this.fld_dgcICTransferItems.BOSPrivilege = "";
            this.fld_dgcICTransferItems.BOSPropertyName = null;
            this.fld_dgcICTransferItems.CommodityType = "";
            this.fld_dgcICTransferItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransferItems.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcICTransferItems.MainView = this.fld_dgvICTransferItems;
            this.fld_dgcICTransferItems.Name = "fld_dgcICTransferItems";
            this.fld_dgcICTransferItems.PrintReport = false;
            this.fld_dgcICTransferItems.Screen = null;
            this.fld_dgcICTransferItems.Size = new System.Drawing.Size(915, 351);
            this.fld_dgcICTransferItems.TabIndex = 2;
            this.fld_dgcICTransferItems.Tag = "DC";
            this.fld_dgcICTransferItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICTransferItems});
            // 
            // fld_dgvICTransferItems
            // 
            this.fld_dgvICTransferItems.GridControl = this.fld_dgcICTransferItems;
            this.fld_dgvICTransferItems.Name = "fld_dgvICTransferItems";
            this.fld_dgvICTransferItems.PaintStyleName = "Office2003";
            // 
            // fld_tabDocumentEntrys
            // 
            this.fld_tabDocumentEntrys.Controls.Add(this.fld_btnSaveAccounting);
            this.fld_tabDocumentEntrys.Controls.Add(this.fld_btnCreateDocument);
            this.fld_tabDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabDocumentEntrys.Name = "fld_tabDocumentEntrys";
            this.ScreenHelper.SetShowHelp(this.fld_tabDocumentEntrys, true);
            this.fld_tabDocumentEntrys.Size = new System.Drawing.Size(1038, 385);
            this.fld_tabDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_btnSaveAccounting
            // 
            this.fld_btnSaveAccounting.BOSComment = null;
            this.fld_btnSaveAccounting.BOSDataMember = null;
            this.fld_btnSaveAccounting.BOSDataSource = null;
            this.fld_btnSaveAccounting.BOSDescription = null;
            this.fld_btnSaveAccounting.BOSError = null;
            this.fld_btnSaveAccounting.BOSFieldGroup = null;
            this.fld_btnSaveAccounting.BOSFieldRelation = null;
            this.fld_btnSaveAccounting.BOSPrivilege = null;
            this.fld_btnSaveAccounting.BOSPropertyName = null;
            this.fld_btnSaveAccounting.Location = new System.Drawing.Point(123, 2);
            this.fld_btnSaveAccounting.Name = "fld_btnSaveAccounting";
            this.fld_btnSaveAccounting.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveAccounting, true);
            this.fld_btnSaveAccounting.Size = new System.Drawing.Size(105, 27);
            this.fld_btnSaveAccounting.TabIndex = 549;
            this.fld_btnSaveAccounting.Text = "Lưu";
            this.fld_btnSaveAccounting.Click += new System.EventHandler(this.fld_btnSaveAccounting_Click);
            // 
            // fld_btnCreateDocument
            // 
            this.fld_btnCreateDocument.BOSComment = null;
            this.fld_btnCreateDocument.BOSDataMember = null;
            this.fld_btnCreateDocument.BOSDataSource = null;
            this.fld_btnCreateDocument.BOSDescription = null;
            this.fld_btnCreateDocument.BOSError = null;
            this.fld_btnCreateDocument.BOSFieldGroup = null;
            this.fld_btnCreateDocument.BOSFieldRelation = null;
            this.fld_btnCreateDocument.BOSPrivilege = null;
            this.fld_btnCreateDocument.BOSPropertyName = null;
            this.fld_btnCreateDocument.Location = new System.Drawing.Point(7, 3);
            this.fld_btnCreateDocument.Name = "fld_btnCreateDocument";
            this.fld_btnCreateDocument.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCreateDocument, true);
            this.fld_btnCreateDocument.Size = new System.Drawing.Size(110, 27);
            this.fld_btnCreateDocument.TabIndex = 548;
            this.fld_btnCreateDocument.Text = "Tạo hạch toán";
            this.fld_btnCreateDocument.Click += new System.EventHandler(this.fld_btnCreateDocument_Click);
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcACDocumentEntrys.MainView = this.gridView3;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1031, 347);
            this.fld_dgcACDocumentEntrys.TabIndex = 11;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcACDocumentEntrys;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
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
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(758, 147);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(150, 25);
            this.fld_btnShowInventoryStock.TabIndex = 14;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
            // 
            // fld_txtICTransferMatchCode02Combo
            // 
            this.fld_txtICTransferMatchCode02Combo.BOSComment = null;
            this.fld_txtICTransferMatchCode02Combo.BOSDataMember = "ICTransferMatchCode02Combo";
            this.fld_txtICTransferMatchCode02Combo.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferMatchCode02Combo.BOSDescription = null;
            this.fld_txtICTransferMatchCode02Combo.BOSError = null;
            this.fld_txtICTransferMatchCode02Combo.BOSFieldGroup = null;
            this.fld_txtICTransferMatchCode02Combo.BOSFieldRelation = null;
            this.fld_txtICTransferMatchCode02Combo.BOSPrivilege = null;
            this.fld_txtICTransferMatchCode02Combo.BOSPropertyName = "EditValue";
            this.fld_txtICTransferMatchCode02Combo.Location = new System.Drawing.Point(501, 64);
            this.fld_txtICTransferMatchCode02Combo.Name = "fld_txtICTransferMatchCode02Combo";
            this.fld_txtICTransferMatchCode02Combo.Screen = null;
            this.fld_txtICTransferMatchCode02Combo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferMatchCode02Combo.TabIndex = 9;
            this.fld_txtICTransferMatchCode02Combo.Tag = "DC";
            // 
            // fld_txtICTransferReference
            // 
            this.fld_txtICTransferReference.BOSComment = null;
            this.fld_txtICTransferReference.BOSDataMember = "ICTransferReference";
            this.fld_txtICTransferReference.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferReference.BOSDescription = null;
            this.fld_txtICTransferReference.BOSError = null;
            this.fld_txtICTransferReference.BOSFieldGroup = null;
            this.fld_txtICTransferReference.BOSFieldRelation = null;
            this.fld_txtICTransferReference.BOSPrivilege = null;
            this.fld_txtICTransferReference.BOSPropertyName = "EditValue";
            this.fld_txtICTransferReference.Location = new System.Drawing.Point(758, 64);
            this.fld_txtICTransferReference.Name = "fld_txtICTransferReference";
            this.fld_txtICTransferReference.Properties.ReadOnly = true;
            this.fld_txtICTransferReference.Screen = null;
            this.fld_txtICTransferReference.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferReference.TabIndex = 12;
            this.fld_txtICTransferReference.Tag = "DC";
            // 
            // fld_txtICTransferMatchCode01Combo
            // 
            this.fld_txtICTransferMatchCode01Combo.BOSComment = null;
            this.fld_txtICTransferMatchCode01Combo.BOSDataMember = "ICTransferMatchCode01Combo";
            this.fld_txtICTransferMatchCode01Combo.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferMatchCode01Combo.BOSDescription = null;
            this.fld_txtICTransferMatchCode01Combo.BOSError = null;
            this.fld_txtICTransferMatchCode01Combo.BOSFieldGroup = null;
            this.fld_txtICTransferMatchCode01Combo.BOSFieldRelation = null;
            this.fld_txtICTransferMatchCode01Combo.BOSPrivilege = null;
            this.fld_txtICTransferMatchCode01Combo.BOSPropertyName = "EditValue";
            this.fld_txtICTransferMatchCode01Combo.Location = new System.Drawing.Point(233, 64);
            this.fld_txtICTransferMatchCode01Combo.Name = "fld_txtICTransferMatchCode01Combo";
            this.fld_txtICTransferMatchCode01Combo.Screen = null;
            this.fld_txtICTransferMatchCode01Combo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferMatchCode01Combo.TabIndex = 8;
            this.fld_txtICTransferMatchCode01Combo.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(668, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 478;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại";
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
            this.bosLabel5.Location = new System.Drawing.Point(411, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(71, 13);
            this.bosLabel5.TabIndex = 478;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "PT vận chuyển";
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
            this.bosLabel4.Location = new System.Drawing.Point(127, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(87, 13);
            this.bosLabel4.TabIndex = 478;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Người vận chuyển";
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
            this.bosLabel6.Location = new System.Drawing.Point(667, 66);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 478;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Số tham chiếu";
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
            this.bosLabel7.Location = new System.Drawing.Point(127, 118);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(40, 13);
            this.bosLabel7.TabIndex = 478;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Diễn giải";
            // 
            // fld_lkeICTransferType
            // 
            this.fld_lkeICTransferType.BOSAllowAddNew = false;
            this.fld_lkeICTransferType.BOSAllowDummy = false;
            this.fld_lkeICTransferType.BOSComment = "";
            this.fld_lkeICTransferType.BOSDataMember = "ICTransferType";
            this.fld_lkeICTransferType.BOSDataSource = "ICTransfers";
            this.fld_lkeICTransferType.BOSDescription = null;
            this.fld_lkeICTransferType.BOSError = "";
            this.fld_lkeICTransferType.BOSFieldGroup = "";
            this.fld_lkeICTransferType.BOSFieldParent = "";
            this.fld_lkeICTransferType.BOSFieldRelation = "";
            this.fld_lkeICTransferType.BOSPrivilege = "";
            this.fld_lkeICTransferType.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferType.BOSSelectType = "";
            this.fld_lkeICTransferType.BOSSelectTypeValue = "";
            this.fld_lkeICTransferType.CurrentDisplayText = "";
            this.fld_lkeICTransferType.Location = new System.Drawing.Point(758, 13);
            this.fld_lkeICTransferType.Name = "fld_lkeICTransferType";
            this.fld_lkeICTransferType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICTransferType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICTransferType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICTransferType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICTransferType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferType.Properties.ColumnName = null;
            this.fld_lkeICTransferType.Properties.NullText = "";
            this.fld_lkeICTransferType.Properties.PopupWidth = 40;
            this.fld_lkeICTransferType.Properties.ReadOnly = true;
            this.fld_lkeICTransferType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICTransferType.Screen = null;
            this.fld_lkeICTransferType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICTransferType.TabIndex = 4;
            this.fld_lkeICTransferType.Tag = "DC";
            // 
            // DMTS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1060, 598);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMTS100.IconOptions.Icon")));
            this.Name = "DMTS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTransferDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferStatus.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).EndInit();
            this.fld_tabTransferItems.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            this.fld_tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransferItems)).EndInit();
            this.fld_tabDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferMatchCode02Combo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferMatchCode01Combo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteICTransferDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICTransferNo;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel fld_Lablel;
        private BOSComponent.BOSLookupEdit fld_lkeICTransferStatus;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICTransferType;
        private BOSComponent.BOSTextBox fld_txtICTransferMatchCode02Combo;
        private BOSComponent.BOSTextBox fld_txtICTransferMatchCode01Combo;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICTransferReference;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSTabControl fld_tabTransferItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabProduct;
        private DevExpress.XtraTab.XtraTabPage fld_tabDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSPictureEdit fld_pteICTransferItemProductPicture;
        private ICTransferItemsGridControl fld_dgcICTransferItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICTransferItems;
        private BOSComponent.BOSButton fld_btnCreateDocument;
        private BOSComponent.BOSButton fld_btnSaveAccounting;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseOrderID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel10;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSButton fld_btnImportTemplate;
        private BOSComponent.BOSButton fld_btnAutoSelectProductSerialNo;
    }
}
