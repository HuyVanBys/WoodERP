using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchShipmentRoundWood.UI
{
	/// <summary>
	/// Summary description for DMBSR100
	/// </summary>
	partial class DMBSR100
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
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_txtICShipmentContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_tabShiptmentItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICShipmentItem1s = new BOSERP.Modules.BatchShipmentRoundWood.ICShipmentItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_ptePictureEdit = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtICShipmentDeliveryContactName = new BOSComponent.BOSTextBox(this.components);
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
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).BeginInit();
            this.fld_tabShiptmentItems.SuspendLayout();
            this.fld_tabPageShipmentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItem1s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_btnShowInventoryStock);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentContainerNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
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
            this.bosPanel1.Size = new System.Drawing.Size(936, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ICShipmentAcceptanceType";
            this.bosLookupEdit1.BOSDataSource = "ICShipments";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(777, 113);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 549;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit1_CloseUp_1);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(676, 116);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(33, 13);
            this.bosLabel10.TabIndex = 550;
            this.bosLabel10.Text = "Xuất đi";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Location = new System.Drawing.Point(676, 90);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 548;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Số PO.No";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICShipmentPONo";
            this.bosTextBox1.BOSDataSource = "ICShipments";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(777, 87);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 12;
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
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(777, 139);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(150, 20);
            this.fld_btnShowInventoryStock.TabIndex = 14;
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
            this.fld_txtICShipmentContainerNo.Location = new System.Drawing.Point(217, 60);
            this.fld_txtICShipmentContainerNo.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentContainerNo.Name = "fld_txtICShipmentContainerNo";
            this.fld_txtICShipmentContainerNo.Screen = null;
            this.fld_txtICShipmentContainerNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentContainerNo.TabIndex = 7;
            this.fld_txtICShipmentContainerNo.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(127, 63);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(63, 13);
            this.bosLabel11.TabIndex = 538;
            this.bosLabel11.Text = "Container No";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(495, 61);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 8;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ICProductAttributeTTMTID_EditValueChanged);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(394, 64);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(26, 13);
            this.bosLabel7.TabIndex = 534;
            this.bosLabel7.Text = "TTMT";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "MMOperationGroup";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "Material";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(495, 86);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Name")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 11;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_MMOperationID_EditValueChanged);
            this.fld_lkeFK_MMOperationID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_MMOperationID_Closed);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(394, 89);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 530;
            this.bosLabel5.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(217, 86);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 10;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_MMBatchProductID_EditValueChanged);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(127, 89);
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
            this.fld_lkeFK_ACSegmentID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(777, 61);
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACSegmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 9;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.Location = new System.Drawing.Point(676, 64);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 526;
            this.bosLabel9.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel9.Text = "Khoản mục chi phí";
            // 
            // fld_medICShipmentDesc
            // 
            this.fld_medICShipmentDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medICShipmentDesc.BOSDataMember = "ICShipmentDesc";
            this.fld_medICShipmentDesc.BOSDataSource = "ICShipments";
            this.fld_medICShipmentDesc.BOSDescription = null;
            this.fld_medICShipmentDesc.BOSError = null;
            this.fld_medICShipmentDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medICShipmentDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medICShipmentDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medICShipmentDesc.BOSPropertyName = "EditValue";
            this.fld_medICShipmentDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(217, 112);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(428, 39);
            this.fld_medICShipmentDesc.TabIndex = 13;
            this.fld_medICShipmentDesc.Tag = "DC";
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
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 4;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
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
            this.fld_tabShiptmentItems.Location = new System.Drawing.Point(0, 157);
            this.fld_tabShiptmentItems.Name = "fld_tabShiptmentItems";
            this.fld_tabShiptmentItems.Screen = null;
            this.fld_tabShiptmentItems.SelectedTabPage = this.fld_tabPageShipmentItems;
            this.fld_tabShiptmentItems.Size = new System.Drawing.Size(927, 407);
            this.fld_tabShiptmentItems.TabIndex = 16;
            this.fld_tabShiptmentItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageShipmentItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageShipmentItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_pteICShipmentItemProductPicture);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcICShipmentItem1s);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(920, 378);
            this.fld_tabPageShipmentItems.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 10);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(708, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
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
            this.fld_pteICShipmentItemProductPicture.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteICShipmentItemProductPicture.BOSDataMember = "ICShipmentItemProductPicture";
            this.fld_pteICShipmentItemProductPicture.BOSDataSource = "ICShipmentItems";
            this.fld_pteICShipmentItemProductPicture.BOSDescription = null;
            this.fld_pteICShipmentItemProductPicture.BOSError = null;
            this.fld_pteICShipmentItemProductPicture.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteICShipmentItemProductPicture.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteICShipmentItemProductPicture.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteICShipmentItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentItemProductPicture.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteICShipmentItemProductPicture.Location = new System.Drawing.Point(775, 3);
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
            // fld_dgcICShipmentItem1s
            // 
            this.fld_dgcICShipmentItem1s.AllowDrop = true;
            this.fld_dgcICShipmentItem1s.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentItem1s.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICShipmentItem1s.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICShipmentItem1s.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItem1s.BOSDescription = null;
            this.fld_dgcICShipmentItem1s.BOSError = null;
            this.fld_dgcICShipmentItem1s.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICShipmentItem1s.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICShipmentItem1s.BOSGridType = null;
            this.fld_dgcICShipmentItem1s.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICShipmentItem1s.BOSPropertyName = null;
            this.fld_dgcICShipmentItem1s.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentItem1s.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcICShipmentItem1s.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICShipmentItem1s.Name = "fld_dgcICShipmentItem1s";
            this.fld_dgcICShipmentItem1s.PrintReport = false;
            this.fld_dgcICShipmentItem1s.Screen = null;
            this.fld_dgcICShipmentItem1s.Size = new System.Drawing.Size(765, 339);
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
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(920, 378);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(920, 378);
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
            this.fld_ptePictureEdit.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_ptePictureEdit.BOSDataMember = "ICShipmentEmployeePicture";
            this.fld_ptePictureEdit.BOSDataSource = "ICShipments";
            this.fld_ptePictureEdit.BOSDescription = null;
            this.fld_ptePictureEdit.BOSError = null;
            this.fld_ptePictureEdit.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_ptePictureEdit.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_ptePictureEdit.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_ptePictureEdit.BOSPropertyName = "EditValue";
            this.fld_ptePictureEdit.EditValue = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_txtICShipmentDeliveryContactName.Location = new System.Drawing.Point(495, 35);
            this.fld_txtICShipmentDeliveryContactName.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentDeliveryContactName.Name = "fld_txtICShipmentDeliveryContactName";
            this.fld_txtICShipmentDeliveryContactName.Screen = null;
            this.fld_txtICShipmentDeliveryContactName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentDeliveryContactName.TabIndex = 5;
            this.fld_txtICShipmentDeliveryContactName.Tag = "DC";
            // 
            // fld_dteICShipmentDate
            // 
            this.fld_dteICShipmentDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteICShipmentDate.BOSDataMember = "ICShipmentDate";
            this.fld_dteICShipmentDate.BOSDataSource = "ICShipments";
            this.fld_dteICShipmentDate.BOSDescription = null;
            this.fld_dteICShipmentDate.BOSError = null;
            this.fld_dteICShipmentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteICShipmentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteICShipmentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteICShipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDate.EditValue = null;
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(495, 9);
            this.fld_dteICShipmentDate.Name = "fld_dteICShipmentDate";
            this.fld_dteICShipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate.Screen = null;
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICShipmentDate.TabIndex = 2;
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
            this.fld_lkeFK_ICStockID1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(777, 34);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 6;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(394, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.bosLabel1.Location = new System.Drawing.Point(394, 37);
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
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(127, 115);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(676, 12);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 14;
            this.fld_lblLabel25.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(777, 9);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 3;
            this.fld_lkeICShipmentStatus.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_Lablel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(676, 37);
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
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentNo1.TabIndex = 1;
            this.fld_txtICShipmentNo1.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(2, 103);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // DMBSR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(936, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBSR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentItems)).EndInit();
            this.fld_tabShiptmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItem1s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSTabControl fld_tabShiptmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentItemProductPicture;
        private BOSERP.Modules.BatchShipmentRoundWood.ICShipmentItemsGridControl fld_dgcICShipmentItem1s;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSPictureEdit fld_ptePictureEdit;
        private BOSComponent.BOSTextBox fld_txtICShipmentDeliveryContactName;
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
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICShipmentContainerNo;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel10;
	}
}
