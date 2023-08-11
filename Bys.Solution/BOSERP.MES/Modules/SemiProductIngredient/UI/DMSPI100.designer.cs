using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SemiProductIngredient.UI
{
	/// <summary>
	/// Summary description for DMSPI100
	/// </summary>
	partial class DMSPI100
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
            this.Panel = new BOSComponent.BOSPanel(this.components);
            this.fld_btnShowReceiptList = new BOSComponent.BOSButton(this.components);
            this.fld_tabShiptmentItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcMMSemiProductIngredientItems = new BOSERP.Modules.SemiProductIngredient.MMSemiProductIngredientItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMSemiProductIngredientDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMSemiProductIngredientStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMSemiProductIngredientNo = new BOSComponent.BOSTextBox(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).BeginInit();
            this.fld_tabShiptmentItems.SuspendLayout();
            this.fld_tabPageShipmentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMSemiProductIngredientItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMSemiProductIngredientDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMSemiProductIngredientDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMSemiProductIngredientStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMSemiProductIngredientNo.Properties)).BeginInit();
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
            this.Panel.Controls.Add(this.fld_btnShowReceiptList);
            this.Panel.Controls.Add(this.fld_tabShiptmentItems);
            this.Panel.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.Panel.Controls.Add(this.bosLabel4);
            this.Panel.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.Panel.Controls.Add(this.bosLabel1);
            this.Panel.Controls.Add(this.fld_medICShipmentDesc);
            this.Panel.Controls.Add(this.bosLabel3);
            this.Panel.Controls.Add(this.fld_dteMMSemiProductIngredientDate);
            this.Panel.Controls.Add(this.fld_lblLabel26);
            this.Panel.Controls.Add(this.fld_lblLabel25);
            this.Panel.Controls.Add(this.fld_lkeMMSemiProductIngredientStatus);
            this.Panel.Controls.Add(this.bosLabel8);
            this.Panel.Controls.Add(this.fld_txtMMSemiProductIngredientNo);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Screen = null;
            this.Panel.Size = new System.Drawing.Size(971, 599);
            this.Panel.TabIndex = 7;
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
            this.fld_btnShowReceiptList.Location = new System.Drawing.Point(534, 66);
            this.fld_btnShowReceiptList.Name = "fld_btnShowReceiptList";
            this.fld_btnShowReceiptList.Screen = null;
            this.fld_btnShowReceiptList.Size = new System.Drawing.Size(114, 27);
            this.fld_btnShowReceiptList.TabIndex = 10;
            this.fld_btnShowReceiptList.Text = "Danh sách dở dang";
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
            this.fld_tabShiptmentItems.Location = new System.Drawing.Point(3, 146);
            this.fld_tabShiptmentItems.Name = "fld_tabShiptmentItems";
            this.fld_tabShiptmentItems.Screen = null;
            this.fld_tabShiptmentItems.SelectedTabPage = this.fld_tabPageShipmentItems;
            this.fld_tabShiptmentItems.Size = new System.Drawing.Size(965, 450);
            this.fld_tabShiptmentItems.TabIndex = 11;
            this.fld_tabShiptmentItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageShipmentItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageShipmentItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_pteICShipmentItemProductPicture);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcMMSemiProductIngredientItems);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(958, 421);
            this.fld_tabPageShipmentItems.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMSemiProductIngredientItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(59, 10);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(750, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 3;
            this.fld_lkeFK_ICProductID.Tag = "DC";
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
            // fld_pteICShipmentItemProductPicture
            // 
            this.fld_pteICShipmentItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICShipmentItemProductPicture.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_pteICShipmentItemProductPicture.BOSDataMember = "ICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.BOSDataSource = "ICShipmentItems";
            this.fld_pteICShipmentItemProductPicture.BOSDescription = null;
            this.fld_pteICShipmentItemProductPicture.BOSError = null;
            this.fld_pteICShipmentItemProductPicture.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_pteICShipmentItemProductPicture.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_pteICShipmentItemProductPicture.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_pteICShipmentItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentItemProductPicture.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_pteICShipmentItemProductPicture.Location = new System.Drawing.Point(813, 3);
            this.fld_pteICShipmentItemProductPicture.Name = "fld_pteICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICShipmentItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentItemProductPicture.Screen = null;
            this.fld_pteICShipmentItemProductPicture.Size = new System.Drawing.Size(142, 136);
            this.fld_pteICShipmentItemProductPicture.TabIndex = 2;
            this.fld_pteICShipmentItemProductPicture.Tag = "DC";
            // 
            // fld_dgcMMSemiProductIngredientItems
            // 
            this.fld_dgcMMSemiProductIngredientItems.AllowDrop = true;
            this.fld_dgcMMSemiProductIngredientItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMSemiProductIngredientItems.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMSemiProductIngredientItems.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMSemiProductIngredientItems.BOSDataSource = "MMSemiProductIngredientItems";
            this.fld_dgcMMSemiProductIngredientItems.BOSDescription = null;
            this.fld_dgcMMSemiProductIngredientItems.BOSError = null;
            this.fld_dgcMMSemiProductIngredientItems.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMSemiProductIngredientItems.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMSemiProductIngredientItems.BOSGridType = null;
            this.fld_dgcMMSemiProductIngredientItems.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMSemiProductIngredientItems.BOSPropertyName = null;
            this.fld_dgcMMSemiProductIngredientItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMSemiProductIngredientItems.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcMMSemiProductIngredientItems.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcMMSemiProductIngredientItems.Name = "fld_dgcMMSemiProductIngredientItems";
            this.fld_dgcMMSemiProductIngredientItems.PrintReport = false;
            this.fld_dgcMMSemiProductIngredientItems.Screen = null;
            this.fld_dgcMMSemiProductIngredientItems.Size = new System.Drawing.Size(803, 382);
            this.fld_dgcMMSemiProductIngredientItems.TabIndex = 1;
            this.fld_dgcMMSemiProductIngredientItems.Tag = "DC";
            this.fld_dgcMMSemiProductIngredientItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcMMSemiProductIngredientItems;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(958, 421);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(958, 421);
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
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMSemiProductIngredients";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(355, 37);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 7;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(263, 40);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 542;
            this.bosLabel4.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMSemiProductIngredients";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(87, 37);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 6;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(20, 40);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(17, 13);
            this.bosLabel1.TabIndex = 540;
            this.bosLabel1.Text = "LSX";
            // 
            // fld_medICShipmentDesc
            // 
            this.fld_medICShipmentDesc.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICShipmentDesc.BOSDataMember = "MMSemiProductIngredientDesc";
            this.fld_medICShipmentDesc.BOSDataSource = "MMSemiProductIngredients";
            this.fld_medICShipmentDesc.BOSDescription = null;
            this.fld_medICShipmentDesc.BOSError = null;
            this.fld_medICShipmentDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICShipmentDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICShipmentDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICShipmentDesc.BOSPropertyName = "EditValue";
            this.fld_medICShipmentDesc.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(87, 64);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(419, 60);
            this.fld_medICShipmentDesc.TabIndex = 9;
            this.fld_medICShipmentDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(20, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 538;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_dteMMSemiProductIngredientDate
            // 
            this.fld_dteMMSemiProductIngredientDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMSemiProductIngredientDate.BOSDataMember = "MMSemiProductIngredientDate";
            this.fld_dteMMSemiProductIngredientDate.BOSDataSource = "MMSemiProductIngredients";
            this.fld_dteMMSemiProductIngredientDate.BOSDescription = null;
            this.fld_dteMMSemiProductIngredientDate.BOSError = null;
            this.fld_dteMMSemiProductIngredientDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMSemiProductIngredientDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMSemiProductIngredientDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMSemiProductIngredientDate.BOSPropertyName = "EditValue";
            this.fld_dteMMSemiProductIngredientDate.EditValue = null;
            this.fld_dteMMSemiProductIngredientDate.Location = new System.Drawing.Point(355, 11);
            this.fld_dteMMSemiProductIngredientDate.Name = "fld_dteMMSemiProductIngredientDate";
            this.fld_dteMMSemiProductIngredientDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMSemiProductIngredientDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMSemiProductIngredientDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMSemiProductIngredientDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMSemiProductIngredientDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMSemiProductIngredientDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMSemiProductIngredientDate.Screen = null;
            this.fld_dteMMSemiProductIngredientDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMSemiProductIngredientDate.TabIndex = 1;
            this.fld_dteMMSemiProductIngredientDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(263, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 534;
            this.fld_lblLabel26.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(524, 14);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 526;
            this.fld_lblLabel25.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // fld_lkeMMSemiProductIngredientStatus
            // 
            this.fld_lkeMMSemiProductIngredientStatus.BOSAllowAddNew = false;
            this.fld_lkeMMSemiProductIngredientStatus.BOSAllowDummy = false;
            this.fld_lkeMMSemiProductIngredientStatus.BOSComment = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSDataMember = "MMSemiProductIngredientStatus";
            this.fld_lkeMMSemiProductIngredientStatus.BOSDataSource = "MMSemiProductIngredients";
            this.fld_lkeMMSemiProductIngredientStatus.BOSDescription = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSError = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSFieldGroup = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSFieldParent = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSFieldRelation = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSPrivilege = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMSemiProductIngredientStatus.BOSSelectType = null;
            this.fld_lkeMMSemiProductIngredientStatus.BOSSelectTypeValue = null;
            this.fld_lkeMMSemiProductIngredientStatus.CurrentDisplayText = null;
            this.fld_lkeMMSemiProductIngredientStatus.Location = new System.Drawing.Point(594, 14);
            this.fld_lkeMMSemiProductIngredientStatus.MenuManager = this.screenToolbar;
            this.fld_lkeMMSemiProductIngredientStatus.Name = "fld_lkeMMSemiProductIngredientStatus";
            this.fld_lkeMMSemiProductIngredientStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMSemiProductIngredientStatus.Properties.ReadOnly = true;
            this.fld_lkeMMSemiProductIngredientStatus.Screen = null;
            this.fld_lkeMMSemiProductIngredientStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMSemiProductIngredientStatus.TabIndex = 2;
            this.fld_lkeMMSemiProductIngredientStatus.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(20, 14);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(61, 13);
            this.bosLabel8.TabIndex = 527;
            this.bosLabel8.Text = "Mã chứng từ";
            // 
            // fld_txtMMSemiProductIngredientNo
            // 
            this.fld_txtMMSemiProductIngredientNo.BOSComment = null;
            this.fld_txtMMSemiProductIngredientNo.BOSDataMember = "MMSemiProductIngredientNo";
            this.fld_txtMMSemiProductIngredientNo.BOSDataSource = "MMSemiProductIngredients";
            this.fld_txtMMSemiProductIngredientNo.BOSDescription = null;
            this.fld_txtMMSemiProductIngredientNo.BOSError = null;
            this.fld_txtMMSemiProductIngredientNo.BOSFieldGroup = null;
            this.fld_txtMMSemiProductIngredientNo.BOSFieldRelation = null;
            this.fld_txtMMSemiProductIngredientNo.BOSPrivilege = null;
            this.fld_txtMMSemiProductIngredientNo.BOSPropertyName = "EditValue";
            this.fld_txtMMSemiProductIngredientNo.Location = new System.Drawing.Point(87, 11);
            this.fld_txtMMSemiProductIngredientNo.MenuManager = this.screenToolbar;
            this.fld_txtMMSemiProductIngredientNo.Name = "fld_txtMMSemiProductIngredientNo";
            this.fld_txtMMSemiProductIngredientNo.Screen = null;
            this.fld_txtMMSemiProductIngredientNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMSemiProductIngredientNo.TabIndex = 0;
            this.fld_txtMMSemiProductIngredientNo.Tag = "DC";
            // 
            // DMSPI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(971, 599);
            this.Controls.Add(this.Panel);
            this.Name = "DMSPI100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).EndInit();
            this.fld_tabShiptmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMSemiProductIngredientItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMSemiProductIngredientDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMSemiProductIngredientDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMSemiProductIngredientStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMSemiProductIngredientNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel Panel;
        private BOSComponent.BOSButton fld_btnShowReceiptList;
        private BOSComponent.BOSTabControl fld_tabShiptmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentItemProductPicture;
        private MMSemiProductIngredientItemsGridControl fld_dgcMMSemiProductIngredientItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteMMSemiProductIngredientDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeMMSemiProductIngredientStatus;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtMMSemiProductIngredientNo;
	}
}
