using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Shipment.UI
{
	/// <summary>
	/// Summary description for DMSH100
	/// </summary>
	partial class DMSH100
	{
		private BOSComponent.BOSPictureEdit fld_ptePictureEdit;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel25;
		private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private ICShipmentItemsGridControl fld_dgcICShipmentItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSH100));
            this.fld_ptePictureEdit = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_pteICShipmentItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICShipmentItems = new BOSERP.Modules.Shipment.ICShipmentItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeICShipmentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ACUnfinishedConstructionCostID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICImportAndExportReasonID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_tabShiptmentItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnImportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnAutoSelectProductSerialNo = new BOSComponent.BOSButton(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICShipmentDeliveryContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).BeginInit();
            this.fld_tabShiptmentItems.SuspendLayout();
            this.fld_tabPageShipmentItems.SuspendLayout();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(127, 63);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 14;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tình trạng";
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
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(587, 9);
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
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(187, 20);
            this.fld_dteICShipmentDate.TabIndex = 2;
            this.fld_dteICShipmentDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(476, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày chứng từ";
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
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 10);
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
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(698, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 1;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
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
            this.fld_pteICShipmentItemProductPicture.Location = new System.Drawing.Point(767, 37);
            this.fld_pteICShipmentItemProductPicture.Name = "fld_pteICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentItemProductPicture.Screen = null;
            this.fld_pteICShipmentItemProductPicture.Size = new System.Drawing.Size(117, 127);
            this.fld_pteICShipmentItemProductPicture.TabIndex = 60;
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
            this.fld_dgcICShipmentItems.Size = new System.Drawing.Size(755, 292);
            this.fld_dgcICShipmentItems.TabIndex = 0;
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
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(217, 164);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(557, 34);
            this.fld_medICShipmentDesc.TabIndex = 10;
            this.fld_medICShipmentDesc.Tag = "DC";
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
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(217, 60);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.ColumnName = null;
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(216, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 5;
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
            this.bosLabel8.Location = new System.Drawing.Point(127, 12);
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
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(217, 9);
            this.fld_txtICShipmentNo1.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(216, 20);
            this.fld_txtICShipmentNo1.TabIndex = 1;
            this.fld_txtICShipmentNo1.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACUnfinishedConstructionCostID1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel62);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentProductType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICImportAndExportReasonID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentDesc);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_tabShiptmentItems);
            this.bosPanel1.Controls.Add(this.fld_ptePictureEdit);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentDeliveryContactName);
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
            this.bosPanel1.Size = new System.Drawing.Size(897, 583);
            this.bosPanel1.TabIndex = 70;
            // 
            // fld_lkeFK_ACUnfinishedConstructionCostID1
            // 
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSAllowDummy = true;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSComment = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSDataMember = "FK_ACUnfinishedConstructionCostID";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSDescription = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSError = "";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSFieldGroup = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSFieldParent = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSFieldRelation = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSPrivilege = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSSelectType = "ACUnfinishedConstructionCostStatus";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.BOSSelectTypeValue = "New;Doing";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.CurrentDisplayText = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Location = new System.Drawing.Point(587, 138);
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Name = "fld_lkeFK_ACUnfinishedConstructionCostID1";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.ColumnName = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chi phí"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chi phí")});
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.DisplayMember = "ACUnfinishedConstructionCostName";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.NullText = "";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties.ValueMember = "ACUnfinishedConstructionCostID";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Screen = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.TabIndex = 682;
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.Tag = "DC";
            this.fld_lkeFK_ACUnfinishedConstructionCostID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACUnfinishedConstructionCostID1_CloseUp);
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
            this.bosLabel6.Location = new System.Drawing.Point(476, 141);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(103, 13);
            this.bosLabel6.TabIndex = 683;
            this.bosLabel6.Text = "CPXD cơ bản dở dang";
            // 
            // bosLabel62
            // 
            this.bosLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.Options.UseBackColor = true;
            this.bosLabel62.Appearance.Options.UseForeColor = true;
            this.bosLabel62.BOSComment = null;
            this.bosLabel62.BOSDataMember = null;
            this.bosLabel62.BOSDataSource = null;
            this.bosLabel62.BOSDescription = null;
            this.bosLabel62.BOSError = null;
            this.bosLabel62.BOSFieldGroup = null;
            this.bosLabel62.BOSFieldRelation = null;
            this.bosLabel62.BOSPrivilege = null;
            this.bosLabel62.BOSPropertyName = null;
            this.bosLabel62.Location = new System.Drawing.Point(127, 141);
            this.bosLabel62.Name = "bosLabel62";
            this.bosLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel62, true);
            this.bosLabel62.Size = new System.Drawing.Size(67, 13);
            this.bosLabel62.TabIndex = 681;
            this.bosLabel62.Text = "Loại hàng hóa";
            // 
            // fld_lkeICShipmentProductType
            // 
            this.fld_lkeICShipmentProductType.BOSAllowAddNew = false;
            this.fld_lkeICShipmentProductType.BOSAllowDummy = false;
            this.fld_lkeICShipmentProductType.BOSComment = null;
            this.fld_lkeICShipmentProductType.BOSDataMember = "ICShipmentProductType";
            this.fld_lkeICShipmentProductType.BOSDataSource = "ICShipments";
            this.fld_lkeICShipmentProductType.BOSDescription = null;
            this.fld_lkeICShipmentProductType.BOSError = null;
            this.fld_lkeICShipmentProductType.BOSFieldGroup = null;
            this.fld_lkeICShipmentProductType.BOSFieldParent = null;
            this.fld_lkeICShipmentProductType.BOSFieldRelation = null;
            this.fld_lkeICShipmentProductType.BOSPrivilege = null;
            this.fld_lkeICShipmentProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentProductType.BOSSelectType = "";
            this.fld_lkeICShipmentProductType.BOSSelectTypeValue = "";
            this.fld_lkeICShipmentProductType.CurrentDisplayText = null;
            this.fld_lkeICShipmentProductType.Location = new System.Drawing.Point(217, 138);
            this.fld_lkeICShipmentProductType.Name = "fld_lkeICShipmentProductType";
            this.fld_lkeICShipmentProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICShipmentProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICShipmentProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICShipmentProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentProductType.Properties.ColumnName = null;
            this.fld_lkeICShipmentProductType.Properties.NullText = "";
            this.fld_lkeICShipmentProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICShipmentProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICShipmentProductType, true);
            this.fld_lkeICShipmentProductType.Size = new System.Drawing.Size(216, 20);
            this.fld_lkeICShipmentProductType.TabIndex = 680;
            this.fld_lkeICShipmentProductType.Tag = "DC";
            this.fld_lkeICShipmentProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeICShipmentProductType_CloseUp);
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
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
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(587, 112);
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
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 530;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.Validated += new System.EventHandler(this.fld_lkeFK_MMBatchProductID_Validated);
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
            this.bosLabel5.Location = new System.Drawing.Point(476, 115);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(68, 13);
            this.bosLabel5.TabIndex = 531;
            this.bosLabel5.Text = "Lệnh sản xuất";
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
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(217, 112);
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
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(216, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 9;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(127, 115);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(45, 13);
            this.bosLabel12.TabIndex = 529;
            this.bosLabel12.Text = "Mã dự án";
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
            this.fld_lkeFK_ICImportAndExportReasonID.Location = new System.Drawing.Point(587, 86);
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
            this.fld_lkeFK_ICImportAndExportReasonID.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_ICImportAndExportReasonID.TabIndex = 8;
            this.fld_lkeFK_ICImportAndExportReasonID.Tag = "DC";
            this.fld_lkeFK_ICImportAndExportReasonID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICImportAndExportReasonID_CloseUp);
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
            this.bosLabel4.Location = new System.Drawing.Point(476, 89);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(78, 13);
            this.bosLabel4.TabIndex = 527;
            this.bosLabel4.Text = "Lý do nhập xuất";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(587, 34);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 4;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            this.fld_lkeFK_ACSegmentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ACSegmentID_CloseUp);
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
            this.bosLabel9.Location = new System.Drawing.Point(476, 37);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 526;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Khoản mục chi phí";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(217, 34);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(216, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
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
            this.fld_tabShiptmentItems.Location = new System.Drawing.Point(0, 224);
            this.fld_tabShiptmentItems.Name = "fld_tabShiptmentItems";
            this.fld_tabShiptmentItems.Screen = null;
            this.fld_tabShiptmentItems.SelectedTabPage = this.fld_tabPageShipmentItems;
            this.fld_tabShiptmentItems.Size = new System.Drawing.Size(894, 356);
            this.fld_tabShiptmentItems.TabIndex = 11;
            this.fld_tabShiptmentItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageShipmentItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_btnImportTemplate);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_btnExportTemplate);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_btnAutoSelectProductSerialNo);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageShipmentItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_pteICShipmentItemProductPicture);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcICShipmentItems);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(892, 331);
            this.fld_tabPageShipmentItems.Text = "Danh sách sản phẩm";
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
            this.fld_btnImportTemplate.Location = new System.Drawing.Point(767, 203);
            this.fld_btnImportTemplate.Name = "fld_btnImportTemplate";
            this.fld_btnImportTemplate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnImportTemplate, true);
            this.fld_btnImportTemplate.Size = new System.Drawing.Size(117, 27);
            this.fld_btnImportTemplate.TabIndex = 63;
            this.fld_btnImportTemplate.Text = "Import SP";
            this.fld_btnImportTemplate.Click += new System.EventHandler(this.fld_btnImportTemplate_Click);
            // 
            // fld_btnExportTemplate
            // 
            this.fld_btnExportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportTemplate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_btnExportTemplate.Appearance.Options.UseForeColor = true;
            this.fld_btnExportTemplate.BOSComment = null;
            this.fld_btnExportTemplate.BOSDataMember = null;
            this.fld_btnExportTemplate.BOSDataSource = null;
            this.fld_btnExportTemplate.BOSDescription = null;
            this.fld_btnExportTemplate.BOSError = null;
            this.fld_btnExportTemplate.BOSFieldGroup = null;
            this.fld_btnExportTemplate.BOSFieldRelation = null;
            this.fld_btnExportTemplate.BOSPrivilege = null;
            this.fld_btnExportTemplate.BOSPropertyName = null;
            this.fld_btnExportTemplate.Location = new System.Drawing.Point(767, 170);
            this.fld_btnExportTemplate.Name = "fld_btnExportTemplate";
            this.fld_btnExportTemplate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportTemplate, true);
            this.fld_btnExportTemplate.Size = new System.Drawing.Size(117, 27);
            this.fld_btnExportTemplate.TabIndex = 62;
            this.fld_btnExportTemplate.Text = "Export Template";
            this.fld_btnExportTemplate.Click += new System.EventHandler(this.fld_btnExportTemplate_Click);
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
            this.fld_btnAutoSelectProductSerialNo.Location = new System.Drawing.Point(767, 8);
            this.fld_btnAutoSelectProductSerialNo.Name = "fld_btnAutoSelectProductSerialNo";
            this.fld_btnAutoSelectProductSerialNo.Screen = null;
            this.fld_btnAutoSelectProductSerialNo.Size = new System.Drawing.Size(117, 23);
            this.fld_btnAutoSelectProductSerialNo.TabIndex = 61;
            this.fld_btnAutoSelectProductSerialNo.Text = "Tự động gắn lô";
            this.fld_btnAutoSelectProductSerialNo.Click += new System.EventHandler(this.fld_btnAutoSelectProductSerialNo_Click);
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
            this.bosLabel13.TabIndex = 0;
            this.bosLabel13.Text = "Sản phẩm";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(878, 324);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(878, 324);
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
            // fld_txtICShipmentDeliveryContactName
            // 
            this.fld_txtICShipmentDeliveryContactName.BOSComment = null;
            this.fld_txtICShipmentDeliveryContactName.BOSDataMember = "ICShipmentDeliveryContactName";
            this.fld_txtICShipmentDeliveryContactName.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentDeliveryContactName.BOSDescription = null;
            this.fld_txtICShipmentDeliveryContactName.BOSError = null;
            this.fld_txtICShipmentDeliveryContactName.BOSFieldGroup = null;
            this.fld_txtICShipmentDeliveryContactName.BOSFieldRelation = null;
            this.fld_txtICShipmentDeliveryContactName.BOSPrivilege = null;
            this.fld_txtICShipmentDeliveryContactName.BOSPropertyName = "Text";
            this.fld_txtICShipmentDeliveryContactName.Location = new System.Drawing.Point(217, 86);
            this.fld_txtICShipmentDeliveryContactName.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentDeliveryContactName.Name = "fld_txtICShipmentDeliveryContactName";
            this.fld_txtICShipmentDeliveryContactName.Screen = null;
            this.fld_txtICShipmentDeliveryContactName.Size = new System.Drawing.Size(216, 20);
            this.fld_txtICShipmentDeliveryContactName.TabIndex = 7;
            this.fld_txtICShipmentDeliveryContactName.Tag = "DC";
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
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(587, 60);
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
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 6;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(127, 89);
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
            this.bosLabel3.Location = new System.Drawing.Point(127, 166);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
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
            this.bosLabel2.Location = new System.Drawing.Point(127, 37);
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
            this.fld_Lablel3.Location = new System.Drawing.Point(476, 63);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 522;
            this.fld_Lablel3.Text = "Kho";
            // 
            // DMSH100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSH100.IconOptions.Icon")));
            this.Name = "DMSH100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACUnfinishedConstructionCostID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).EndInit();
            this.fld_tabShiptmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.PerformLayout();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentItemProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentStatus;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICShipmentDeliveryContactName;
        private BOSComponent.BOSTabControl fld_tabShiptmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private BOSComponent.BOSLabel bosLabel13;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICImportAndExportReasonID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel62;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentProductType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACUnfinishedConstructionCostID1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnAutoSelectProductSerialNo;
        private BOSComponent.BOSButton fld_btnImportTemplate;
        private BOSComponent.BOSButton fld_btnExportTemplate;
    }
}
