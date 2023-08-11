using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TransferOutsourcing.UI
{
	/// <summary>
	/// Summary description for DMTO100
	/// </summary>
	partial class DMTO100
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_APPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_btnAddLumberProduct = new BOSComponent.BOSButton(this.components);
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICTransferItemsGridControl = new BOSERP.Modules.TransferOutsourcing.ICTransferItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICTransferItemMaterialsGridControl = new BOSERP.Modules.TransferOutsourcing.ICTransferItemMaterialsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddItemFromBatchProduct = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACDocumentEntryGridControl = new BOSERP.BaseDocumentEntryGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPictureEdit2 = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICFromStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit5 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit6 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit7 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tabTransferItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pteICTransferItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICTransferItems = new BOSERP.Modules.TransferOutsourcing.ICTransferItemsGridControl();
            this.fld_dgvICTransferItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveAccounting = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreateDocument = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferStatus.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItemMaterialsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
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
            this.fld_lkeFK_ICProductID.BOSComment = "  ";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICTransferItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = "  ";
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "  ";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "  ";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "  ";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "  ";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "  ";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "  ";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(74, 11);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", 50, "Barcode")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "  ";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(703, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = "  ";
            this.fld_Lablel.BOSDataMember = "  ";
            this.fld_Lablel.BOSDataSource = "  ";
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = "  ";
            this.fld_Lablel.BOSFieldRelation = "  ";
            this.fld_Lablel.BOSPrivilege = "  ";
            this.fld_Lablel.BOSPropertyName = null;
            this.fld_Lablel.Location = new System.Drawing.Point(7, 14);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 390;
            this.fld_Lablel.Tag = "  ";
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "  ";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "  ";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "  ";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "  ";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "  ";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "  ";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "  ";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "  ";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 106);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "  ";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_pteICTransferEmployeePicture
            // 
            this.fld_pteICTransferEmployeePicture.BOSComment = "  ";
            this.fld_pteICTransferEmployeePicture.BOSDataMember = "ICTransferEmployeePicture";
            this.fld_pteICTransferEmployeePicture.BOSDataSource = "ICTransfers";
            this.fld_pteICTransferEmployeePicture.BOSDescription = null;
            this.fld_pteICTransferEmployeePicture.BOSError = "  ";
            this.fld_pteICTransferEmployeePicture.BOSFieldGroup = "  ";
            this.fld_pteICTransferEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICTransferEmployeePicture.BOSPrivilege = "  ";
            this.fld_pteICTransferEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICTransferEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICTransferEmployeePicture.Name = "fld_pteICTransferEmployeePicture";
            this.fld_pteICTransferEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICTransferEmployeePicture.Screen = null;
            this.fld_pteICTransferEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICTransferEmployeePicture.TabIndex = 462;
            this.fld_pteICTransferEmployeePicture.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "  ";
            this.fld_Lablel2.BOSDataMember = "  ";
            this.fld_Lablel2.BOSDataSource = "  ";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "  ";
            this.fld_Lablel2.BOSFieldRelation = "  ";
            this.fld_Lablel2.BOSPrivilege = "  ";
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(127, 119);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Tag = string.Empty;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "  ";
            this.fld_lblLabel7.BOSDataMember = "  ";
            this.fld_lblLabel7.BOSDataSource = "  ";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "  ";
            this.fld_lblLabel7.BOSFieldRelation = "  ";
            this.fld_lblLabel7.BOSPrivilege = "  ";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(127, 41);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 481;
            this.fld_lblLabel7.Tag = "  ";
            this.fld_lblLabel7.Text = "Từ kho";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "  ";
            this.fld_lblLabel8.BOSDataMember = "  ";
            this.fld_lblLabel8.BOSDataSource = "  ";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "  ";
            this.fld_lblLabel8.BOSFieldRelation = "  ";
            this.fld_lblLabel8.BOSPrivilege = "  ";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(411, 41);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 482;
            this.fld_lblLabel8.Tag = "  ";
            this.fld_lblLabel8.Text = "Đến kho";
            // 
            // fld_lkeFK_ICFromStockID1
            // 
            this.fld_lkeFK_ICFromStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID1.BOSComment = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICFromStockID1.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID1.BOSError = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSFieldGroup = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSFieldParent = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSFieldRelation = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSPrivilege = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID1.BOSSelectType = "  ";
            this.fld_lkeFK_ICFromStockID1.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_ICFromStockID1.CurrentDisplayText = "  ";
            this.fld_lkeFK_ICFromStockID1.Location = new System.Drawing.Point(233, 38);
            this.fld_lkeFK_ICFromStockID1.Name = "fld_lkeFK_ICFromStockID1";
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID1.Properties.NullText = "  ";
            this.fld_lkeFK_ICFromStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID1.Screen = null;
            this.fld_lkeFK_ICFromStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID1.TabIndex = 3;
            this.fld_lkeFK_ICFromStockID1.Tag = "DC";
            this.fld_lkeFK_ICFromStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICFromStockID1_CloseUp);
            // 
            // fld_lkeFK_ICToStockID1
            // 
            this.fld_lkeFK_ICToStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID1.BOSComment = "  ";
            this.fld_lkeFK_ICToStockID1.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICToStockID1.BOSDescription = null;
            this.fld_lkeFK_ICToStockID1.BOSError = "  ";
            this.fld_lkeFK_ICToStockID1.BOSFieldGroup = "  ";
            this.fld_lkeFK_ICToStockID1.BOSFieldParent = "  ";
            this.fld_lkeFK_ICToStockID1.BOSFieldRelation = "  ";
            this.fld_lkeFK_ICToStockID1.BOSPrivilege = "  ";
            this.fld_lkeFK_ICToStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID1.BOSSelectType = "  ";
            this.fld_lkeFK_ICToStockID1.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_ICToStockID1.CurrentDisplayText = "  ";
            this.fld_lkeFK_ICToStockID1.Location = new System.Drawing.Point(501, 38);
            this.fld_lkeFK_ICToStockID1.Name = "fld_lkeFK_ICToStockID1";
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID1.Properties.NullText = "  ";
            this.fld_lkeFK_ICToStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID1.Screen = null;
            this.fld_lkeFK_ICToStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID1.TabIndex = 4;
            this.fld_lkeFK_ICToStockID1.Tag = "DC";
            this.fld_lkeFK_ICToStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICToStockID1_CloseUp);
            // 
            // fld_medICTransferDesc
            // 
            this.fld_medICTransferDesc.BOSComment = "  ";
            this.fld_medICTransferDesc.BOSDataMember = "ICTransferDesc";
            this.fld_medICTransferDesc.BOSDataSource = "ICTransfers";
            this.fld_medICTransferDesc.BOSDescription = null;
            this.fld_medICTransferDesc.BOSError = "  ";
            this.fld_medICTransferDesc.BOSFieldGroup = "  ";
            this.fld_medICTransferDesc.BOSFieldRelation = "  ";
            this.fld_medICTransferDesc.BOSPrivilege = "  ";
            this.fld_medICTransferDesc.BOSPropertyName = "Text";
            this.fld_medICTransferDesc.Location = new System.Drawing.Point(233, 142);
            this.fld_medICTransferDesc.Name = "fld_medICTransferDesc";
            this.fld_medICTransferDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICTransferDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICTransferDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICTransferDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICTransferDesc.Screen = null;
            this.fld_medICTransferDesc.Size = new System.Drawing.Size(418, 37);
            this.fld_medICTransferDesc.TabIndex = 9;
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
            this.fld_dteICTransferDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDate.Screen = null;
            this.fld_dteICTransferDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDate.TabIndex = 1;
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
            this.fld_txtICTransferNo.TabIndex = 0;
            this.fld_txtICTransferNo.Tag = "DC";
            // 
            // fld_lkeICTransferStatus
            // 
            this.fld_lkeICTransferStatus.BOSAllowAddNew = false;
            this.fld_lkeICTransferStatus.BOSAllowDummy = false;
            this.fld_lkeICTransferStatus.BOSComment = "  ";
            this.fld_lkeICTransferStatus.BOSDataMember = "ICTransferStatus";
            this.fld_lkeICTransferStatus.BOSDataSource = "ICTransfers";
            this.fld_lkeICTransferStatus.BOSDescription = null;
            this.fld_lkeICTransferStatus.BOSError = "  ";
            this.fld_lkeICTransferStatus.BOSFieldGroup = "  ";
            this.fld_lkeICTransferStatus.BOSFieldParent = "  ";
            this.fld_lkeICTransferStatus.BOSFieldRelation = "  ";
            this.fld_lkeICTransferStatus.BOSPrivilege = "  ";
            this.fld_lkeICTransferStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferStatus.BOSSelectType = "  ";
            this.fld_lkeICTransferStatus.BOSSelectTypeValue = "  ";
            this.fld_lkeICTransferStatus.CurrentDisplayText = "  ";
            this.fld_lkeICTransferStatus.Location = new System.Drawing.Point(233, 116);
            this.fld_lkeICTransferStatus.Name = "fld_lkeICTransferStatus";
            this.fld_lkeICTransferStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICTransferStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICTransferStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICTransferStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICTransferStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferStatus.Properties.NullText = "  ";
            this.fld_lkeICTransferStatus.Properties.PopupWidth = 40;
            this.fld_lkeICTransferStatus.Properties.ReadOnly = true;
            this.fld_lkeICTransferStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICTransferStatus.Screen = null;
            this.fld_lkeICTransferStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICTransferStatus.TabIndex = 8;
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
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_tabTransferItems);
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
            this.bosPanel1.Size = new System.Drawing.Size(944, 528);
            this.bosPanel1.TabIndex = 499;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeFK_APPurchaseOrderID);
            this.bosPanel2.Controls.Add(this.bosLabel21);
            this.bosPanel2.Controls.Add(this.bosLabel9);
            this.bosPanel2.Controls.Add(this.bosLookupEdit2);
            this.bosPanel2.Controls.Add(this.bosTabControl1);
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.bosPictureEdit2);
            this.bosPanel2.Controls.Add(this.bosTextBox1);
            this.bosPanel2.Controls.Add(this.bosTextBox2);
            this.bosPanel2.Controls.Add(this.bosTextBox3);
            this.bosPanel2.Controls.Add(this.bosTextBox4);
            this.bosPanel2.Controls.Add(this.bosLabel11);
            this.bosPanel2.Controls.Add(this.bosLabel12);
            this.bosPanel2.Controls.Add(this.bosLabel13);
            this.bosPanel2.Controls.Add(this.bosLabel14);
            this.bosPanel2.Controls.Add(this.bosLabel15);
            this.bosPanel2.Controls.Add(this.bosLabel16);
            this.bosPanel2.Controls.Add(this.bosLabel17);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ICFromStockID);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ICToStockID);
            this.bosPanel2.Controls.Add(this.bosLookupEdit5);
            this.bosPanel2.Controls.Add(this.bosLabel18);
            this.bosPanel2.Controls.Add(this.bosLookupEdit6);
            this.bosPanel2.Controls.Add(this.bosLookupEdit7);
            this.bosPanel2.Controls.Add(this.bosDateEdit1);
            this.bosPanel2.Controls.Add(this.bosLabel19);
            this.bosPanel2.Controls.Add(this.bosLabel20);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(944, 528);
            this.bosPanel2.TabIndex = 551;
            // 
            // fld_lkeFK_APPurchaseOrderID
            // 
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchaseOrderID.BOSComment = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSDataMember = "FK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_APPurchaseOrderID.BOSDescription = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSError = null;
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldGroup = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldParent = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSFieldRelation = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSPrivilege = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectType = "  ";
            this.fld_lkeFK_APPurchaseOrderID.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_APPurchaseOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_APPurchaseOrderID.Enabled = false;
            this.fld_lkeFK_APPurchaseOrderID.Location = new System.Drawing.Point(778, 38);
            this.fld_lkeFK_APPurchaseOrderID.Name = "fld_lkeFK_APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchaseOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchaseOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchaseOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseOrderNo", "Mã đơn mua hàng")});
            this.fld_lkeFK_APPurchaseOrderID.Properties.DisplayMember = "APPurchaseOrderNo";
            this.fld_lkeFK_APPurchaseOrderID.Properties.NullText = "  ";
            this.fld_lkeFK_APPurchaseOrderID.Properties.ReadOnly = true;
            this.fld_lkeFK_APPurchaseOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchaseOrderID.Properties.ValueMember = "APPurchaseOrderID";
            this.fld_lkeFK_APPurchaseOrderID.Screen = null;
            this.fld_lkeFK_APPurchaseOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APPurchaseOrderID.TabIndex = 553;
            this.fld_lkeFK_APPurchaseOrderID.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "  ";
            this.bosLabel21.BOSDataMember = "  ";
            this.bosLabel21.BOSDataSource = "  ";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "  ";
            this.bosLabel21.BOSFieldRelation = "  ";
            this.bosLabel21.BOSPrivilege = "  ";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(688, 41);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(70, 13);
            this.bosLabel21.TabIndex = 552;
            this.bosLabel21.Tag = "  ";
            this.bosLabel21.Text = "Đơn mua hàng";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "  ";
            this.bosLabel9.BOSDataMember = "  ";
            this.bosLabel9.BOSDataSource = "  ";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "  ";
            this.bosLabel9.BOSFieldRelation = "  ";
            this.bosLabel9.BOSPrivilege = "  ";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(411, 119);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(77, 13);
            this.bosLabel9.TabIndex = 550;
            this.bosLabel9.Tag = "  ";
            this.bosLabel9.Text = "Loại chuyển kho";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "  ";
            this.bosLookupEdit2.BOSDataMember = "ICTransferTransferType";
            this.bosLookupEdit2.BOSDataSource = "ICTransfers";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = "  ";
            this.bosLookupEdit2.BOSFieldGroup = "  ";
            this.bosLookupEdit2.BOSFieldParent = "  ";
            this.bosLookupEdit2.BOSFieldRelation = "  ";
            this.bosLookupEdit2.BOSPrivilege = "  ";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "  ";
            this.bosLookupEdit2.BOSSelectTypeValue = "  ";
            this.bosLookupEdit2.CurrentDisplayText = "  ";
            this.bosLookupEdit2.Location = new System.Drawing.Point(501, 116);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.NullText = "  ";
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.ReadOnly = true;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 549;
            this.bosLookupEdit2.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 197);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.bosTabControl1, true);
            this.bosTabControl1.Size = new System.Drawing.Size(938, 328);
            this.bosTabControl1.TabIndex = 548;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel48);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddLumberProduct);
            this.xtraTabPage1.Controls.Add(this.bosPictureEdit1);
            this.xtraTabPage1.Controls.Add(this.fld_dgcICTransferItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(931, 299);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(7, 40);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 61;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ICTransferItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = null;
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(64, 37);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(718, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 60;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_btnAddLumberProduct
            // 
            this.fld_btnAddLumberProduct.BOSComment = null;
            this.fld_btnAddLumberProduct.BOSDataMember = null;
            this.fld_btnAddLumberProduct.BOSDataSource = null;
            this.fld_btnAddLumberProduct.BOSDescription = null;
            this.fld_btnAddLumberProduct.BOSError = null;
            this.fld_btnAddLumberProduct.BOSFieldGroup = null;
            this.fld_btnAddLumberProduct.BOSFieldRelation = null;
            this.fld_btnAddLumberProduct.BOSPrivilege = null;
            this.fld_btnAddLumberProduct.BOSPropertyName = null;
            this.fld_btnAddLumberProduct.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddLumberProduct.Name = "fld_btnAddLumberProduct";
            this.fld_btnAddLumberProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddLumberProduct, true);
            this.fld_btnAddLumberProduct.Size = new System.Drawing.Size(150, 27);
            this.fld_btnAddLumberProduct.TabIndex = 59;
            this.fld_btnAddLumberProduct.Tag = "  ";
            this.fld_btnAddLumberProduct.Text = "Thêm nguyên liệu";
            this.fld_btnAddLumberProduct.Click += new System.EventHandler(this.fld_btnAddLumberProduct_Click);
            // 
            // bosPictureEdit1
            // 
            this.bosPictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPictureEdit1.BOSComment = "  ";
            this.bosPictureEdit1.BOSDataMember = "ICTransferItemProductPicture";
            this.bosPictureEdit1.BOSDataSource = "ICTransferItems";
            this.bosPictureEdit1.BOSDescription = null;
            this.bosPictureEdit1.BOSError = "  ";
            this.bosPictureEdit1.BOSFieldGroup = "  ";
            this.bosPictureEdit1.BOSFieldRelation = null;
            this.bosPictureEdit1.BOSPrivilege = "  ";
            this.bosPictureEdit1.BOSPropertyName = "EditValue";
            this.bosPictureEdit1.Location = new System.Drawing.Point(788, 37);
            this.bosPictureEdit1.Name = "bosPictureEdit1";
            this.bosPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit1.Screen = null;
            this.bosPictureEdit1.Size = new System.Drawing.Size(140, 140);
            this.bosPictureEdit1.TabIndex = 1;
            this.bosPictureEdit1.Tag = "DC";
            // 
            // fld_dgcICTransferItemsGridControl
            // 
            this.fld_dgcICTransferItemsGridControl.AllowDrop = true;
            this.fld_dgcICTransferItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferItemsGridControl.BOSComment = "  ";
            this.fld_dgcICTransferItemsGridControl.BOSDataMember = null;
            this.fld_dgcICTransferItemsGridControl.BOSDataSource = "ICTransferItems";
            this.fld_dgcICTransferItemsGridControl.BOSDescription = null;
            this.fld_dgcICTransferItemsGridControl.BOSError = "  ";
            this.fld_dgcICTransferItemsGridControl.BOSFieldGroup = "  ";
            this.fld_dgcICTransferItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcICTransferItemsGridControl.BOSGridType = null;
            this.fld_dgcICTransferItemsGridControl.BOSPrivilege = "  ";
            this.fld_dgcICTransferItemsGridControl.BOSPropertyName = null;
            this.fld_dgcICTransferItemsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransferItemsGridControl.Location = new System.Drawing.Point(7, 63);
            this.fld_dgcICTransferItemsGridControl.MainView = this.gridView1;
            this.fld_dgcICTransferItemsGridControl.Name = "fld_dgcICTransferItemsGridControl";
            this.fld_dgcICTransferItemsGridControl.PrintReport = false;
            this.fld_dgcICTransferItemsGridControl.Screen = null;
            this.fld_dgcICTransferItemsGridControl.Size = new System.Drawing.Size(775, 232);
            this.fld_dgcICTransferItemsGridControl.TabIndex = 2;
            this.fld_dgcICTransferItemsGridControl.Tag = "DC";
            this.fld_dgcICTransferItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICTransferItemsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICTransferItemMaterialsGridControl);
            this.xtraTabPage3.Controls.Add(this.fld_btnAddItemFromBatchProduct);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(931, 299);
            this.xtraTabPage3.Text = "Danh sách vật tư";
            // 
            // fld_dgcICTransferItemMaterialsGridControl
            // 
            this.fld_dgcICTransferItemMaterialsGridControl.AllowDrop = true;
            this.fld_dgcICTransferItemMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferItemMaterialsGridControl.BOSComment = "  ";
            this.fld_dgcICTransferItemMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcICTransferItemMaterialsGridControl.BOSDataSource = "ICTransferItems";
            this.fld_dgcICTransferItemMaterialsGridControl.BOSDescription = null;
            this.fld_dgcICTransferItemMaterialsGridControl.BOSError = "  ";
            this.fld_dgcICTransferItemMaterialsGridControl.BOSFieldGroup = "  ";
            this.fld_dgcICTransferItemMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcICTransferItemMaterialsGridControl.BOSGridType = null;
            this.fld_dgcICTransferItemMaterialsGridControl.BOSPrivilege = "  ";
            this.fld_dgcICTransferItemMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcICTransferItemMaterialsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransferItemMaterialsGridControl.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcICTransferItemMaterialsGridControl.MainView = this.gridView4;
            this.fld_dgcICTransferItemMaterialsGridControl.Name = "fld_dgcICTransferItemMaterialsGridControl";
            this.fld_dgcICTransferItemMaterialsGridControl.PrintReport = false;
            this.fld_dgcICTransferItemMaterialsGridControl.Screen = null;
            this.fld_dgcICTransferItemMaterialsGridControl.Size = new System.Drawing.Size(916, 258);
            this.fld_dgcICTransferItemMaterialsGridControl.TabIndex = 67;
            this.fld_dgcICTransferItemMaterialsGridControl.Tag = "DC";
            this.fld_dgcICTransferItemMaterialsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcICTransferItemMaterialsGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // fld_btnAddItemFromBatchProduct
            // 
            this.fld_btnAddItemFromBatchProduct.BOSComment = null;
            this.fld_btnAddItemFromBatchProduct.BOSDataMember = null;
            this.fld_btnAddItemFromBatchProduct.BOSDataSource = null;
            this.fld_btnAddItemFromBatchProduct.BOSDescription = null;
            this.fld_btnAddItemFromBatchProduct.BOSError = null;
            this.fld_btnAddItemFromBatchProduct.BOSFieldGroup = null;
            this.fld_btnAddItemFromBatchProduct.BOSFieldRelation = null;
            this.fld_btnAddItemFromBatchProduct.BOSPrivilege = null;
            this.fld_btnAddItemFromBatchProduct.BOSPropertyName = null;
            this.fld_btnAddItemFromBatchProduct.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddItemFromBatchProduct.Name = "fld_btnAddItemFromBatchProduct";
            this.fld_btnAddItemFromBatchProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddItemFromBatchProduct, true);
            this.fld_btnAddItemFromBatchProduct.Size = new System.Drawing.Size(152, 27);
            this.fld_btnAddItemFromBatchProduct.TabIndex = 63;
            this.fld_btnAddItemFromBatchProduct.Tag = string.Empty;
            this.fld_btnAddItemFromBatchProduct.Text = "Thêm từ Lệnh sản xuất";
            this.fld_btnAddItemFromBatchProduct.Click += new System.EventHandler(this.fld_btnAddItemFromBatchProduct_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosButton1);
            this.xtraTabPage2.Controls.Add(this.bosButton2);
            this.xtraTabPage2.Controls.Add(this.fld_dgcACDocumentEntryGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage2, true);
            this.xtraTabPage2.Size = new System.Drawing.Size(931, 299);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(123, 3);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(105, 27);
            this.bosButton1.TabIndex = 549;
            this.bosButton1.Text = "Lưu";
            this.bosButton1.Click += new System.EventHandler(this.fld_btnSaveAccounting_Click);
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(7, 3);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton2, true);
            this.bosButton2.Size = new System.Drawing.Size(110, 27);
            this.bosButton2.TabIndex = 548;
            this.bosButton2.Text = "Tạo hạch toán";
            this.bosButton2.Click += new System.EventHandler(this.fld_btnCreateDocument_Click);
            // 
            // fld_dgcACDocumentEntryGridControl
            // 
            this.fld_dgcACDocumentEntryGridControl.AllowDrop = true;
            this.fld_dgcACDocumentEntryGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDocumentEntryGridControl.BOSComment = "  ";
            this.fld_dgcACDocumentEntryGridControl.BOSDataMember = "  ";
            this.fld_dgcACDocumentEntryGridControl.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntryGridControl.BOSDescription = null;
            this.fld_dgcACDocumentEntryGridControl.BOSError = null;
            this.fld_dgcACDocumentEntryGridControl.BOSFieldGroup = "  ";
            this.fld_dgcACDocumentEntryGridControl.BOSFieldRelation = "  ";
            this.fld_dgcACDocumentEntryGridControl.BOSGridType = null;
            this.fld_dgcACDocumentEntryGridControl.BOSPrivilege = "  ";
            this.fld_dgcACDocumentEntryGridControl.BOSPropertyName = "  ";
            this.fld_dgcACDocumentEntryGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntryGridControl.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcACDocumentEntryGridControl.MainView = this.gridView2;
            this.fld_dgcACDocumentEntryGridControl.Name = "fld_dgcACDocumentEntryGridControl";
            this.fld_dgcACDocumentEntryGridControl.PrintReport = false;
            this.fld_dgcACDocumentEntryGridControl.Screen = null;
            this.fld_dgcACDocumentEntryGridControl.Size = new System.Drawing.Size(924, 261);
            this.fld_dgcACDocumentEntryGridControl.TabIndex = 11;
            this.fld_dgcACDocumentEntryGridControl.Tag = "DC";
            this.fld_dgcACDocumentEntryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACDocumentEntryGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "  ";
            this.bosMemoEdit1.BOSDataMember = "ICTransferDesc";
            this.bosMemoEdit1.BOSDataSource = "ICTransfers";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = "  ";
            this.bosMemoEdit1.BOSFieldGroup = "  ";
            this.bosMemoEdit1.BOSFieldRelation = "  ";
            this.bosMemoEdit1.BOSPrivilege = "  ";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.Location = new System.Drawing.Point(233, 142);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(418, 37);
            this.bosMemoEdit1.TabIndex = 9;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosPictureEdit2
            // 
            this.bosPictureEdit2.BOSComment = "  ";
            this.bosPictureEdit2.BOSDataMember = "ICTransferEmployeePicture";
            this.bosPictureEdit2.BOSDataSource = "ICTransfers";
            this.bosPictureEdit2.BOSDescription = null;
            this.bosPictureEdit2.BOSError = "  ";
            this.bosPictureEdit2.BOSFieldGroup = "  ";
            this.bosPictureEdit2.BOSFieldRelation = null;
            this.bosPictureEdit2.BOSPrivilege = "  ";
            this.bosPictureEdit2.BOSPropertyName = "EditValue";
            this.bosPictureEdit2.Location = new System.Drawing.Point(3, 4);
            this.bosPictureEdit2.Name = "bosPictureEdit2";
            this.bosPictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit2.Screen = null;
            this.bosPictureEdit2.Size = new System.Drawing.Size(100, 96);
            this.bosPictureEdit2.TabIndex = 462;
            this.bosPictureEdit2.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICTransferMatchCode02Combo";
            this.bosTextBox1.BOSDataSource = "ICTransfers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(233, 90);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(418, 20);
            this.bosTextBox1.TabIndex = 7;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ICTransferReference";
            this.bosTextBox2.BOSDataSource = "ICTransfers";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(778, 12);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 5;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ICTransferMatchCode01Combo";
            this.bosTextBox3.BOSDataSource = "ICTransfers";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(233, 64);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 6;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ICTransferNo";
            this.bosTextBox4.BOSDataSource = "ICTransfers";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(233, 12);
            this.bosTextBox4.MenuManager = this.screenToolbar;
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 0;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "  ";
            this.bosLabel11.BOSDataMember = "  ";
            this.bosLabel11.BOSDataSource = "  ";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "  ";
            this.bosLabel11.BOSFieldRelation = "  ";
            this.bosLabel11.BOSPrivilege = "  ";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(411, 67);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(19, 13);
            this.bosLabel11.TabIndex = 478;
            this.bosLabel11.Tag = "  ";
            this.bosLabel11.Text = "Loại";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "  ";
            this.bosLabel12.BOSDataMember = "  ";
            this.bosLabel12.BOSDataSource = "  ";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "  ";
            this.bosLabel12.BOSFieldRelation = "  ";
            this.bosLabel12.BOSPrivilege = "  ";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(127, 93);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(71, 13);
            this.bosLabel12.TabIndex = 478;
            this.bosLabel12.Tag = "  ";
            this.bosLabel12.Text = "PT vận chuyển";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "  ";
            this.bosLabel13.BOSDataMember = "  ";
            this.bosLabel13.BOSDataSource = "  ";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "  ";
            this.bosLabel13.BOSFieldRelation = "  ";
            this.bosLabel13.BOSPrivilege = "  ";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(127, 67);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(87, 13);
            this.bosLabel13.TabIndex = 478;
            this.bosLabel13.Tag = "  ";
            this.bosLabel13.Text = "Người vận chuyển";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "  ";
            this.bosLabel14.BOSDataMember = "  ";
            this.bosLabel14.BOSDataSource = "  ";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "  ";
            this.bosLabel14.BOSFieldRelation = "  ";
            this.bosLabel14.BOSPrivilege = "  ";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(688, 14);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(67, 13);
            this.bosLabel14.TabIndex = 478;
            this.bosLabel14.Tag = "  ";
            this.bosLabel14.Text = "Số tham chiếu";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "  ";
            this.bosLabel15.BOSDataMember = "  ";
            this.bosLabel15.BOSDataSource = "  ";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "  ";
            this.bosLabel15.BOSFieldRelation = "  ";
            this.bosLabel15.BOSPrivilege = "  ";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(127, 144);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(40, 13);
            this.bosLabel15.TabIndex = 478;
            this.bosLabel15.Tag = "  ";
            this.bosLabel15.Text = "Diễn giải";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "  ";
            this.bosLabel16.BOSDataMember = "  ";
            this.bosLabel16.BOSDataSource = "  ";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "  ";
            this.bosLabel16.BOSFieldRelation = "  ";
            this.bosLabel16.BOSPrivilege = "  ";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(127, 119);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(49, 13);
            this.bosLabel16.TabIndex = 478;
            this.bosLabel16.Tag = "  ";
            this.bosLabel16.Text = "Tình trạng";
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
            this.bosLabel17.Location = new System.Drawing.Point(127, 15);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(61, 13);
            this.bosLabel17.TabIndex = 498;
            this.bosLabel17.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_ICFromStockID
            // 
            this.fld_lkeFK_ICFromStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID.BOSComment = "  ";
            this.fld_lkeFK_ICFromStockID.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICFromStockID.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID.BOSError = "  ";
            this.fld_lkeFK_ICFromStockID.BOSFieldGroup = "  ";
            this.fld_lkeFK_ICFromStockID.BOSFieldParent = "  ";
            this.fld_lkeFK_ICFromStockID.BOSFieldRelation = "  ";
            this.fld_lkeFK_ICFromStockID.BOSPrivilege = "  ";
            this.fld_lkeFK_ICFromStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID.BOSSelectType = "  ";
            this.fld_lkeFK_ICFromStockID.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_ICFromStockID.CurrentDisplayText = "  ";
            this.fld_lkeFK_ICFromStockID.Location = new System.Drawing.Point(233, 38);
            this.fld_lkeFK_ICFromStockID.Name = "fld_lkeFK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID.Properties.NullText = "  ";
            this.fld_lkeFK_ICFromStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID.Screen = null;
            this.fld_lkeFK_ICFromStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID.TabIndex = 3;
            this.fld_lkeFK_ICFromStockID.Tag = "DC";
            this.fld_lkeFK_ICFromStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICFromStockID_CloseUp);
            // 
            // fld_lkeFK_ICToStockID
            // 
            this.fld_lkeFK_ICToStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID.BOSComment = "  ";
            this.fld_lkeFK_ICToStockID.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICToStockID.BOSDescription = null;
            this.fld_lkeFK_ICToStockID.BOSError = "  ";
            this.fld_lkeFK_ICToStockID.BOSFieldGroup = "  ";
            this.fld_lkeFK_ICToStockID.BOSFieldParent = "  ";
            this.fld_lkeFK_ICToStockID.BOSFieldRelation = "  ";
            this.fld_lkeFK_ICToStockID.BOSPrivilege = "  ";
            this.fld_lkeFK_ICToStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID.BOSSelectType = "  ";
            this.fld_lkeFK_ICToStockID.BOSSelectTypeValue = "  ";
            this.fld_lkeFK_ICToStockID.CurrentDisplayText = "  ";
            this.fld_lkeFK_ICToStockID.Location = new System.Drawing.Point(501, 38);
            this.fld_lkeFK_ICToStockID.Name = "fld_lkeFK_ICToStockID";
            this.fld_lkeFK_ICToStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID.Properties.NullText = "  ";
            this.fld_lkeFK_ICToStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID.Screen = null;
            this.fld_lkeFK_ICToStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID.TabIndex = 4;
            this.fld_lkeFK_ICToStockID.Tag = "DC";
            this.fld_lkeFK_ICToStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICToStockID_CloseUp);
            // 
            // bosLookupEdit5
            // 
            this.bosLookupEdit5.BOSAllowAddNew = false;
            this.bosLookupEdit5.BOSAllowDummy = false;
            this.bosLookupEdit5.BOSComment = "  ";
            this.bosLookupEdit5.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit5.BOSDataSource = "ICTransfers";
            this.bosLookupEdit5.BOSDescription = null;
            this.bosLookupEdit5.BOSError = "  ";
            this.bosLookupEdit5.BOSFieldGroup = "  ";
            this.bosLookupEdit5.BOSFieldParent = "  ";
            this.bosLookupEdit5.BOSFieldRelation = "  ";
            this.bosLookupEdit5.BOSPrivilege = "  ";
            this.bosLookupEdit5.BOSPropertyName = "EditValue";
            this.bosLookupEdit5.BOSSelectType = "  ";
            this.bosLookupEdit5.BOSSelectTypeValue = "  ";
            this.bosLookupEdit5.CurrentDisplayText = "  ";
            this.bosLookupEdit5.Location = new System.Drawing.Point(3, 106);
            this.bosLookupEdit5.Name = "bosLookupEdit5";
            this.bosLookupEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit5.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "  ", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.bosLookupEdit5.Properties.DisplayMember = "HREmployeeNo";
            this.bosLookupEdit5.Properties.NullText = "  ";
            this.bosLookupEdit5.Properties.PopupWidth = 40;
            this.bosLookupEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit5.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit5.Screen = null;
            this.bosLookupEdit5.Size = new System.Drawing.Size(100, 20);
            this.bosLookupEdit5.TabIndex = 0;
            this.bosLookupEdit5.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "  ";
            this.bosLabel18.BOSDataMember = "  ";
            this.bosLabel18.BOSDataSource = "  ";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "  ";
            this.bosLabel18.BOSFieldRelation = "  ";
            this.bosLabel18.BOSPrivilege = "  ";
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(411, 41);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(40, 13);
            this.bosLabel18.TabIndex = 482;
            this.bosLabel18.Tag = "  ";
            this.bosLabel18.Text = "Đến kho";
            // 
            // bosLookupEdit6
            // 
            this.bosLookupEdit6.BOSAllowAddNew = false;
            this.bosLookupEdit6.BOSAllowDummy = false;
            this.bosLookupEdit6.BOSComment = "  ";
            this.bosLookupEdit6.BOSDataMember = "ICTransferType";
            this.bosLookupEdit6.BOSDataSource = "ICTransfers";
            this.bosLookupEdit6.BOSDescription = null;
            this.bosLookupEdit6.BOSError = "  ";
            this.bosLookupEdit6.BOSFieldGroup = "  ";
            this.bosLookupEdit6.BOSFieldParent = "  ";
            this.bosLookupEdit6.BOSFieldRelation = "  ";
            this.bosLookupEdit6.BOSPrivilege = "  ";
            this.bosLookupEdit6.BOSPropertyName = "EditValue";
            this.bosLookupEdit6.BOSSelectType = "  ";
            this.bosLookupEdit6.BOSSelectTypeValue = "  ";
            this.bosLookupEdit6.CurrentDisplayText = "  ";
            this.bosLookupEdit6.Location = new System.Drawing.Point(501, 64);
            this.bosLookupEdit6.Name = "bosLookupEdit6";
            this.bosLookupEdit6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit6.Properties.NullText = "  ";
            this.bosLookupEdit6.Properties.PopupWidth = 40;
            this.bosLookupEdit6.Properties.ReadOnly = true;
            this.bosLookupEdit6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit6.Screen = null;
            this.bosLookupEdit6.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit6.TabIndex = 2;
            this.bosLookupEdit6.Tag = "DC";
            // 
            // bosLookupEdit7
            // 
            this.bosLookupEdit7.BOSAllowAddNew = false;
            this.bosLookupEdit7.BOSAllowDummy = false;
            this.bosLookupEdit7.BOSComment = "  ";
            this.bosLookupEdit7.BOSDataMember = "ICTransferStatus";
            this.bosLookupEdit7.BOSDataSource = "ICTransfers";
            this.bosLookupEdit7.BOSDescription = null;
            this.bosLookupEdit7.BOSError = "  ";
            this.bosLookupEdit7.BOSFieldGroup = "  ";
            this.bosLookupEdit7.BOSFieldParent = "  ";
            this.bosLookupEdit7.BOSFieldRelation = "  ";
            this.bosLookupEdit7.BOSPrivilege = "  ";
            this.bosLookupEdit7.BOSPropertyName = "EditValue";
            this.bosLookupEdit7.BOSSelectType = "  ";
            this.bosLookupEdit7.BOSSelectTypeValue = "  ";
            this.bosLookupEdit7.CurrentDisplayText = "  ";
            this.bosLookupEdit7.Location = new System.Drawing.Point(233, 116);
            this.bosLookupEdit7.Name = "bosLookupEdit7";
            this.bosLookupEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit7.Properties.NullText = "  ";
            this.bosLookupEdit7.Properties.PopupWidth = 40;
            this.bosLookupEdit7.Properties.ReadOnly = true;
            this.bosLookupEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit7.Screen = null;
            this.bosLookupEdit7.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit7.TabIndex = 8;
            this.bosLookupEdit7.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ICTransferDate";
            this.bosDateEdit1.BOSDataSource = "ICTransfers";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(501, 12);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 1;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "  ";
            this.bosLabel19.BOSDataMember = "  ";
            this.bosLabel19.BOSDataSource = "  ";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "  ";
            this.bosLabel19.BOSFieldRelation = "  ";
            this.bosLabel19.BOSPrivilege = "  ";
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(127, 41);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(33, 13);
            this.bosLabel19.TabIndex = 481;
            this.bosLabel19.Tag = "  ";
            this.bosLabel19.Text = "Từ kho";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(411, 15);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(72, 13);
            this.bosLabel20.TabIndex = 496;
            this.bosLabel20.Text = "Ngày chứng từ";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "  ";
            this.bosLabel8.BOSDataMember = "  ";
            this.bosLabel8.BOSDataSource = "  ";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "  ";
            this.bosLabel8.BOSFieldRelation = "  ";
            this.bosLabel8.BOSPrivilege = "  ";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(411, 119);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(77, 13);
            this.bosLabel8.TabIndex = 550;
            this.bosLabel8.Tag = "  ";
            this.bosLabel8.Text = "Loại chuyển kho";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "  ";
            this.bosLookupEdit1.BOSDataMember = "ICTransferTransferType";
            this.bosLookupEdit1.BOSDataSource = "ICTransfers";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = "  ";
            this.bosLookupEdit1.BOSFieldGroup = "  ";
            this.bosLookupEdit1.BOSFieldParent = "  ";
            this.bosLookupEdit1.BOSFieldRelation = "  ";
            this.bosLookupEdit1.BOSPrivilege = "  ";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "  ";
            this.bosLookupEdit1.BOSSelectTypeValue = "  ";
            this.bosLookupEdit1.CurrentDisplayText = "  ";
            this.bosLookupEdit1.Location = new System.Drawing.Point(501, 116);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = "  ";
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 549;
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
            this.fld_tabTransferItems.Location = new System.Drawing.Point(3, 207);
            this.fld_tabTransferItems.Name = "fld_tabTransferItems";
            this.fld_tabTransferItems.Screen = null;
            this.fld_tabTransferItems.SelectedTabPage = this.fld_tabProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabTransferItems, true);
            this.fld_tabTransferItems.Size = new System.Drawing.Size(938, 318);
            this.fld_tabTransferItems.TabIndex = 548;
            this.fld_tabTransferItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct,
            this.fld_tabDocumentEntrys});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_pteICTransferItemProductPicture);
            this.fld_tabProduct.Controls.Add(this.fld_dgcICTransferItems);
            this.fld_tabProduct.Controls.Add(this.fld_Lablel);
            this.fld_tabProduct.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabProduct, true);
            this.fld_tabProduct.Size = new System.Drawing.Size(931, 289);
            this.fld_tabProduct.Text = "Danh sách sản phẩm";
            // 
            // fld_pteICTransferItemProductPicture
            // 
            this.fld_pteICTransferItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICTransferItemProductPicture.BOSComment = "  ";
            this.fld_pteICTransferItemProductPicture.BOSDataMember = "ICTransferItemProductPicture";
            this.fld_pteICTransferItemProductPicture.BOSDataSource = "ICTransferItems";
            this.fld_pteICTransferItemProductPicture.BOSDescription = null;
            this.fld_pteICTransferItemProductPicture.BOSError = "  ";
            this.fld_pteICTransferItemProductPicture.BOSFieldGroup = "  ";
            this.fld_pteICTransferItemProductPicture.BOSFieldRelation = null;
            this.fld_pteICTransferItemProductPicture.BOSPrivilege = "  ";
            this.fld_pteICTransferItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICTransferItemProductPicture.Location = new System.Drawing.Point(783, 37);
            this.fld_pteICTransferItemProductPicture.Name = "fld_pteICTransferItemProductPicture";
            this.fld_pteICTransferItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICTransferItemProductPicture.Screen = null;
            this.fld_pteICTransferItemProductPicture.Size = new System.Drawing.Size(140, 140);
            this.fld_pteICTransferItemProductPicture.TabIndex = 1;
            this.fld_pteICTransferItemProductPicture.Tag = "DC";
            // 
            // fld_dgcICTransferItems
            // 
            this.fld_dgcICTransferItems.AllowDrop = true;
            this.fld_dgcICTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferItems.BOSComment = "  ";
            this.fld_dgcICTransferItems.BOSDataMember = null;
            this.fld_dgcICTransferItems.BOSDataSource = "ICTransferItems";
            this.fld_dgcICTransferItems.BOSDescription = null;
            this.fld_dgcICTransferItems.BOSError = "  ";
            this.fld_dgcICTransferItems.BOSFieldGroup = "  ";
            this.fld_dgcICTransferItems.BOSFieldRelation = null;
            this.fld_dgcICTransferItems.BOSGridType = null;
            this.fld_dgcICTransferItems.BOSPrivilege = "  ";
            this.fld_dgcICTransferItems.BOSPropertyName = null;
            this.fld_dgcICTransferItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransferItems.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcICTransferItems.MainView = this.fld_dgvICTransferItems;
            this.fld_dgcICTransferItems.Name = "fld_dgcICTransferItems";
            this.fld_dgcICTransferItems.PrintReport = false;
            this.fld_dgcICTransferItems.Screen = null;
            this.fld_dgcICTransferItems.Size = new System.Drawing.Size(770, 248);
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
            this.fld_tabDocumentEntrys.Size = new System.Drawing.Size(931, 289);
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
            this.fld_dgcACDocumentEntrys.BOSComment = "  ";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "  ";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "  ";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "  ";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "  ";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "  ";
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcACDocumentEntrys.MainView = this.gridView3;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(924, 251);
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
            this.fld_txtICTransferMatchCode02Combo.Location = new System.Drawing.Point(233, 90);
            this.fld_txtICTransferMatchCode02Combo.Name = "fld_txtICTransferMatchCode02Combo";
            this.fld_txtICTransferMatchCode02Combo.Screen = null;
            this.fld_txtICTransferMatchCode02Combo.Size = new System.Drawing.Size(418, 20);
            this.fld_txtICTransferMatchCode02Combo.TabIndex = 7;
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
            this.fld_txtICTransferReference.Location = new System.Drawing.Point(778, 12);
            this.fld_txtICTransferReference.Name = "fld_txtICTransferReference";
            this.fld_txtICTransferReference.Properties.ReadOnly = true;
            this.fld_txtICTransferReference.Screen = null;
            this.fld_txtICTransferReference.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferReference.TabIndex = 5;
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
            this.fld_txtICTransferMatchCode01Combo.TabIndex = 6;
            this.fld_txtICTransferMatchCode01Combo.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "  ";
            this.bosLabel3.BOSDataMember = "  ";
            this.bosLabel3.BOSDataSource = "  ";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "  ";
            this.bosLabel3.BOSFieldRelation = "  ";
            this.bosLabel3.BOSPrivilege = "  ";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(411, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 478;
            this.bosLabel3.Tag = "  ";
            this.bosLabel3.Text = "Loại";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "  ";
            this.bosLabel5.BOSDataMember = "  ";
            this.bosLabel5.BOSDataSource = "  ";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "  ";
            this.bosLabel5.BOSFieldRelation = "  ";
            this.bosLabel5.BOSPrivilege = "  ";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(127, 93);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(71, 13);
            this.bosLabel5.TabIndex = 478;
            this.bosLabel5.Tag = "  ";
            this.bosLabel5.Text = "PT vận chuyển";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "  ";
            this.bosLabel4.BOSDataMember = "  ";
            this.bosLabel4.BOSDataSource = "  ";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "  ";
            this.bosLabel4.BOSFieldRelation = "  ";
            this.bosLabel4.BOSPrivilege = "  ";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(127, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(87, 13);
            this.bosLabel4.TabIndex = 478;
            this.bosLabel4.Tag = "  ";
            this.bosLabel4.Text = "Người vận chuyển";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "  ";
            this.bosLabel6.BOSDataMember = "  ";
            this.bosLabel6.BOSDataSource = "  ";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "  ";
            this.bosLabel6.BOSFieldRelation = "  ";
            this.bosLabel6.BOSPrivilege = "  ";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(688, 14);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 478;
            this.bosLabel6.Tag = "  ";
            this.bosLabel6.Text = "Số tham chiếu";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "  ";
            this.bosLabel7.BOSDataMember = "  ";
            this.bosLabel7.BOSDataSource = "  ";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "  ";
            this.bosLabel7.BOSFieldRelation = "  ";
            this.bosLabel7.BOSPrivilege = "  ";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(127, 144);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(40, 13);
            this.bosLabel7.TabIndex = 478;
            this.bosLabel7.Tag = "  ";
            this.bosLabel7.Text = "Diễn giải";
            // 
            // fld_lkeICTransferType
            // 
            this.fld_lkeICTransferType.BOSAllowAddNew = false;
            this.fld_lkeICTransferType.BOSAllowDummy = false;
            this.fld_lkeICTransferType.BOSComment = "  ";
            this.fld_lkeICTransferType.BOSDataMember = "ICTransferType";
            this.fld_lkeICTransferType.BOSDataSource = "ICTransfers";
            this.fld_lkeICTransferType.BOSDescription = null;
            this.fld_lkeICTransferType.BOSError = "  ";
            this.fld_lkeICTransferType.BOSFieldGroup = "  ";
            this.fld_lkeICTransferType.BOSFieldParent = "  ";
            this.fld_lkeICTransferType.BOSFieldRelation = "  ";
            this.fld_lkeICTransferType.BOSPrivilege = "  ";
            this.fld_lkeICTransferType.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferType.BOSSelectType = "  ";
            this.fld_lkeICTransferType.BOSSelectTypeValue = "  ";
            this.fld_lkeICTransferType.CurrentDisplayText = "  ";
            this.fld_lkeICTransferType.Location = new System.Drawing.Point(501, 64);
            this.fld_lkeICTransferType.Name = "fld_lkeICTransferType";
            this.fld_lkeICTransferType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICTransferType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICTransferType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICTransferType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICTransferType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferType.Properties.NullText = "  ";
            this.fld_lkeICTransferType.Properties.PopupWidth = 40;
            this.fld_lkeICTransferType.Properties.ReadOnly = true;
            this.fld_lkeICTransferType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICTransferType.Screen = null;
            this.fld_lkeICTransferType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICTransferType.TabIndex = 2;
            this.fld_lkeICTransferType.Tag = "DC";
            // 
            // DMTO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(944, 528);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMTO100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTransferDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferStatus.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferItemMaterialsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
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
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ICTransferItemsGridControl fld_dgcICTransferItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton bosButton2;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSPictureEdit bosPictureEdit2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID;
        private BOSComponent.BOSLookupEdit bosLookupEdit5;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit bosLookupEdit6;
        private BOSComponent.BOSLookupEdit bosLookupEdit7;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private BOSComponent.BOSButton fld_btnAddLumberProduct;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseOrderID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSButton fld_btnAddItemFromBatchProduct;
        private ICTransferItemMaterialsGridControl fld_dgcICTransferItemMaterialsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
	}
}
