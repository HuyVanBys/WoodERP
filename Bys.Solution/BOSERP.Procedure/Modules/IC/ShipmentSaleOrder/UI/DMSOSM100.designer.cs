using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ShipmentSaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSOSM100
	/// </summary>
	partial class DMSOSM100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSOSM100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentInternalSeal = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentDeliveryContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_tabShiptmentSaleOrderItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageShipmentItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAutoSelectProductSerialNo = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICShipmentItems = new BOSERP.Modules.ShipmentSaleOrder.ICShipmentItemsGridControl();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPackNo = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICShipmentPackages = new BOSERP.Modules.ShipmentSaleOrder.ICShipmentPackagesGridControl();
            this.fld_tabPageItemWorkItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICShipmentItemWorkItems = new BOSERP.Modules.ShipmentSaleOrder.ICShipmentItemWorkItemsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentReference = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICShipmentDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICShipmentName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentSOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICShipmentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtICShipmentNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvICShipmentProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentInternalSeal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentSaleOrderItems)).BeginInit();
            this.fld_tabShiptmentSaleOrderItems.SuspendLayout();
            this.fld_tabPageShipmentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            this.fld_tabPackNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackages)).BeginInit();
            this.fld_tabPageItemWorkItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItemWorkItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentSOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.bosTextBox9);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentInternalSeal);
            this.bosPanel1.Controls.Add(this.bosTextBox8);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosTextBox7);
            this.bosPanel1.Controls.Add(this.bosTextBox6);
            this.bosPanel1.Controls.Add(this.bosTextBox5);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.bosTextBox4);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentDeliveryContactName);
            this.bosPanel1.Controls.Add(this.bosLabel62);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentProductType);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_tabShiptmentSaleOrderItems);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderNo);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentReference);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDate);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentName);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentSOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentStatus);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentDesc);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentNo);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1448, 701);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(1182, 15);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(66, 13);
            this.bosLabel23.TabIndex = 848;
            this.bosLabel23.Text = "Số seal nội bộ";
            // 
            // fld_txtICShipmentInternalSeal
            // 
            this.fld_txtICShipmentInternalSeal.BOSComment = null;
            this.fld_txtICShipmentInternalSeal.BOSDataMember = "ICShipmentInternalSeal";
            this.fld_txtICShipmentInternalSeal.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentInternalSeal.BOSDescription = null;
            this.fld_txtICShipmentInternalSeal.BOSError = null;
            this.fld_txtICShipmentInternalSeal.BOSFieldGroup = null;
            this.fld_txtICShipmentInternalSeal.BOSFieldRelation = null;
            this.fld_txtICShipmentInternalSeal.BOSPrivilege = null;
            this.fld_txtICShipmentInternalSeal.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentInternalSeal.Location = new System.Drawing.Point(1258, 12);
            this.fld_txtICShipmentInternalSeal.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentInternalSeal.Name = "fld_txtICShipmentInternalSeal";
            this.fld_txtICShipmentInternalSeal.Screen = null;
            this.fld_txtICShipmentInternalSeal.Size = new System.Drawing.Size(141, 20);
            this.fld_txtICShipmentInternalSeal.TabIndex = 847;
            this.fld_txtICShipmentInternalSeal.Tag = "DC";
            this.fld_txtICShipmentInternalSeal.Validated += new System.EventHandler(this.fld_txtICShipmentInternalSeal_Validated);
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
            this.bosTextBox8.Location = new System.Drawing.Point(490, 116);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.ReadOnly = true;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox8.TabIndex = 846;
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
            this.bosLabel17.Location = new System.Drawing.Point(379, 119);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(94, 13);
            this.bosLabel17.TabIndex = 845;
            this.bosLabel17.Text = "Mã đơn hàng nội bộ";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(124, 119);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(72, 13);
            this.bosLabel16.TabIndex = 843;
            this.bosLabel16.Text = "Kênh bán hàng";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ICListOfSalesChannelType";
            this.bosLookupEdit1.BOSDataSource = "ICShipments";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Enabled = false;
            this.bosLookupEdit1.Location = new System.Drawing.Point(203, 116);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(141, 20);
            this.bosLookupEdit1.TabIndex = 842;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = null;
            this.bosTextBox7.BOSDataMember = "ICShipmentSaleContract";
            this.bosTextBox7.BOSDataSource = "ICShipments";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = null;
            this.bosTextBox7.BOSFieldRelation = null;
            this.bosTextBox7.BOSPrivilege = null;
            this.bosTextBox7.BOSPropertyName = "EditValue";
            this.bosTextBox7.Location = new System.Drawing.Point(203, 90);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox7.TabIndex = 841;
            this.bosTextBox7.Tag = "DC";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ICShipmentInvoiceRequest";
            this.bosTextBox6.BOSDataSource = "ICShipments";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(490, 89);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox6.TabIndex = 840;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ICShipmentProject";
            this.bosTextBox5.BOSDataSource = "ICShipments";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(759, 90);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox5.TabIndex = 839;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = "";
            this.bosDateEdit1.BOSDataMember = "ICShipmentETDDate";
            this.bosDateEdit1.BOSDataSource = "ICShipments";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = "";
            this.bosDateEdit1.BOSFieldRelation = "";
            this.bosDateEdit1.BOSPrivilege = "";
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(1008, 116);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(141, 20);
            this.bosDateEdit1.TabIndex = 20;
            this.bosDateEdit1.Tag = "DC";
            this.bosDateEdit1.Validated += new System.EventHandler(this.bosDateEdit1_Validated);
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(932, 119);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(19, 13);
            this.bosLabel22.TabIndex = 730;
            this.bosLabel22.Text = "ETD";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(932, 93);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(37, 13);
            this.bosLabel21.TabIndex = 728;
            this.bosLabel21.Text = "Tên tàu";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ICShipmentShipNumber";
            this.bosTextBox4.BOSDataSource = "ICShipments";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(1008, 90);
            this.bosTextBox4.MenuManager = this.screenToolbar;
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox4.TabIndex = 17;
            this.bosTextBox4.Tag = "DC";
            this.bosTextBox4.Validated += new System.EventHandler(this.bosTextBox4_Validated);
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
            this.bosLabel20.Location = new System.Drawing.Point(932, 67);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(53, 13);
            this.bosLabel20.TabIndex = 726;
            this.bosLabel20.Text = "Số đầu kéo";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ICShipmentTractorTrailerNumber";
            this.bosTextBox3.BOSDataSource = "ICShipments";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(1008, 64);
            this.bosTextBox3.MenuManager = this.screenToolbar;
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox3.TabIndex = 13;
            this.bosTextBox3.Tag = "DC";
            this.bosTextBox3.Validated += new System.EventHandler(this.bosTextBox3_Validated);
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(932, 41);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(35, 13);
            this.bosLabel19.TabIndex = 724;
            this.bosLabel19.Text = "Số Seal";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ICShipmentContainerSealNumber";
            this.bosTextBox2.BOSDataSource = "ICShipments";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(1008, 38);
            this.bosTextBox2.MenuManager = this.screenToolbar;
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox2.TabIndex = 9;
            this.bosTextBox2.Tag = "DC";
            this.bosTextBox2.Validated += new System.EventHandler(this.bosTextBox2_Validated);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(932, 15);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(60, 13);
            this.bosLabel18.TabIndex = 722;
            this.bosLabel18.Text = "Số container";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICShipmentContainerNumber";
            this.bosTextBox1.BOSDataSource = "ICShipments";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(1008, 12);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox1.TabIndex = 5;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.Validated += new System.EventHandler(this.bosTextBox1_Validated);
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel15.Location = new System.Drawing.Point(671, 119);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(82, 13);
            this.bosLabel15.TabIndex = 720;
            this.bosLabel15.Text = "Người nhận hàng";
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
            this.fld_txtICShipmentDeliveryContactName.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentDeliveryContactName.Location = new System.Drawing.Point(759, 116);
            this.fld_txtICShipmentDeliveryContactName.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentDeliveryContactName.Name = "fld_txtICShipmentDeliveryContactName";
            this.fld_txtICShipmentDeliveryContactName.Screen = null;
            this.fld_txtICShipmentDeliveryContactName.Size = new System.Drawing.Size(141, 20);
            this.fld_txtICShipmentDeliveryContactName.TabIndex = 21;
            this.fld_txtICShipmentDeliveryContactName.Tag = "DC";
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
            this.bosLabel62.Location = new System.Drawing.Point(932, 145);
            this.bosLabel62.Name = "bosLabel62";
            this.bosLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel62, true);
            this.bosLabel62.Size = new System.Drawing.Size(67, 13);
            this.bosLabel62.TabIndex = 718;
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
            this.fld_lkeICShipmentProductType.Location = new System.Drawing.Point(1008, 142);
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
            this.fld_lkeICShipmentProductType.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeICShipmentProductType.TabIndex = 22;
            this.fld_lkeICShipmentProductType.Tag = "DC";
            this.fld_lkeICShipmentProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeICShipmentProductType_CloseUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(379, 92);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(105, 13);
            this.bosLabel12.TabIndex = 716;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Yêu cầu xuất hóa đơn";
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
            this.bosLabel10.Location = new System.Drawing.Point(124, 92);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(60, 13);
            this.bosLabel10.TabIndex = 611;
            this.bosLabel10.Text = "Số hợp đồng";
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
            this.bosLabel8.Location = new System.Drawing.Point(671, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(45, 13);
            this.bosLabel8.TabIndex = 594;
            this.bosLabel8.Text = "Mã dự án";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(203, 64);
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
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACObjectID, true);
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 10;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_tabShiptmentSaleOrderItems
            // 
            this.fld_tabShiptmentSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabShiptmentSaleOrderItems.BOSComment = null;
            this.fld_tabShiptmentSaleOrderItems.BOSDataMember = null;
            this.fld_tabShiptmentSaleOrderItems.BOSDataSource = null;
            this.fld_tabShiptmentSaleOrderItems.BOSDescription = null;
            this.fld_tabShiptmentSaleOrderItems.BOSError = null;
            this.fld_tabShiptmentSaleOrderItems.BOSFieldGroup = null;
            this.fld_tabShiptmentSaleOrderItems.BOSFieldRelation = null;
            this.fld_tabShiptmentSaleOrderItems.BOSPrivilege = null;
            this.fld_tabShiptmentSaleOrderItems.BOSPropertyName = null;
            this.fld_tabShiptmentSaleOrderItems.Location = new System.Drawing.Point(0, 168);
            this.fld_tabShiptmentSaleOrderItems.Name = "fld_tabShiptmentSaleOrderItems";
            this.fld_tabShiptmentSaleOrderItems.Screen = null;
            this.fld_tabShiptmentSaleOrderItems.SelectedTabPage = this.fld_tabPageShipmentItems;
            this.fld_tabShiptmentSaleOrderItems.Size = new System.Drawing.Size(1445, 530);
            this.fld_tabShiptmentSaleOrderItems.TabIndex = 23;
            this.fld_tabShiptmentSaleOrderItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageShipmentItems,
            this.fld_tabPackNo,
            this.fld_tabPageItemWorkItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageShipmentItems
            // 
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_btnAutoSelectProductSerialNo);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_dgcICShipmentItems);
            this.fld_tabPageShipmentItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabPageShipmentItems.Controls.Add(this.bosLabel14);
            this.fld_tabPageShipmentItems.Name = "fld_tabPageShipmentItems";
            this.fld_tabPageShipmentItems.Size = new System.Drawing.Size(1443, 505);
            this.fld_tabPageShipmentItems.Text = "Danh sách sản phẩm";
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
            this.fld_btnAutoSelectProductSerialNo.Location = new System.Drawing.Point(1317, 5);
            this.fld_btnAutoSelectProductSerialNo.Name = "fld_btnAutoSelectProductSerialNo";
            this.fld_btnAutoSelectProductSerialNo.Screen = null;
            this.fld_btnAutoSelectProductSerialNo.Size = new System.Drawing.Size(117, 23);
            this.fld_btnAutoSelectProductSerialNo.TabIndex = 23;
            this.fld_btnAutoSelectProductSerialNo.Text = "Tự động gắn lô";
            this.fld_btnAutoSelectProductSerialNo.Click += new System.EventHandler(this.fld_btnAutoSelectProductSerialNo_Click);
            // 
            // fld_dgcICShipmentItems
            // 
            this.fld_dgcICShipmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentItems.BOSComment = null;
            this.fld_dgcICShipmentItems.BOSDataMember = null;
            this.fld_dgcICShipmentItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItems.BOSDescription = null;
            this.fld_dgcICShipmentItems.BOSError = null;
            this.fld_dgcICShipmentItems.BOSFieldGroup = null;
            this.fld_dgcICShipmentItems.BOSFieldRelation = null;
            this.fld_dgcICShipmentItems.BOSGridType = null;
            this.fld_dgcICShipmentItems.BOSPrivilege = null;
            this.fld_dgcICShipmentItems.BOSPropertyName = null;
            this.fld_dgcICShipmentItems.CommodityType = "";
            this.fld_dgcICShipmentItems.Location = new System.Drawing.Point(6, 32);
            this.fld_dgcICShipmentItems.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentItems.Name = "fld_dgcICShipmentItems";
            this.fld_dgcICShipmentItems.PrintReport = false;
            this.fld_dgcICShipmentItems.Screen = null;
            this.fld_dgcICShipmentItems.Size = new System.Drawing.Size(1428, 465);
            this.fld_dgcICShipmentItems.TabIndex = 1;
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
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 8);
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
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1248, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.Visible = false;
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(11, 11);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(47, 13);
            this.bosLabel14.TabIndex = 0;
            this.bosLabel14.Text = "Sản phẩm";
            this.bosLabel14.Visible = false;
            // 
            // fld_tabPackNo
            // 
            this.fld_tabPackNo.Controls.Add(this.fld_btnFind);
            this.fld_tabPackNo.Controls.Add(this.fld_dgcICShipmentPackages);
            this.fld_tabPackNo.Name = "fld_tabPackNo";
            this.fld_tabPackNo.Size = new System.Drawing.Size(1429, 498);
            this.fld_tabPackNo.Text = "Thông tin kiện";
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
            this.fld_btnFind.Location = new System.Drawing.Point(2, 3);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(117, 26);
            this.fld_btnFind.TabIndex = 22;
            this.fld_btnFind.Text = "Thêm kiện";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_dgcICShipmentPackages
            // 
            this.fld_dgcICShipmentPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentPackages.BOSComment = null;
            this.fld_dgcICShipmentPackages.BOSDataMember = null;
            this.fld_dgcICShipmentPackages.BOSDataSource = "ICShipmentPackages";
            this.fld_dgcICShipmentPackages.BOSDescription = null;
            this.fld_dgcICShipmentPackages.BOSError = null;
            this.fld_dgcICShipmentPackages.BOSFieldGroup = null;
            this.fld_dgcICShipmentPackages.BOSFieldRelation = null;
            this.fld_dgcICShipmentPackages.BOSGridType = null;
            this.fld_dgcICShipmentPackages.BOSPrivilege = null;
            this.fld_dgcICShipmentPackages.BOSPropertyName = null;
            this.fld_dgcICShipmentPackages.CommodityType = "";
            this.fld_dgcICShipmentPackages.Location = new System.Drawing.Point(0, 35);
            this.fld_dgcICShipmentPackages.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentPackages.Name = "fld_dgcICShipmentPackages";
            this.fld_dgcICShipmentPackages.PrintReport = false;
            this.fld_dgcICShipmentPackages.Screen = null;
            this.fld_dgcICShipmentPackages.Size = new System.Drawing.Size(1423, 456);
            this.fld_dgcICShipmentPackages.TabIndex = 5;
            // 
            // fld_tabPageItemWorkItems
            // 
            this.fld_tabPageItemWorkItems.Controls.Add(this.fld_dgcICShipmentItemWorkItems);
            this.fld_tabPageItemWorkItems.Name = "fld_tabPageItemWorkItems";
            this.fld_tabPageItemWorkItems.Size = new System.Drawing.Size(1429, 498);
            this.fld_tabPageItemWorkItems.Text = "Danh sách vật tư";
            // 
            // fld_dgcICShipmentItemWorkItems
            // 
            this.fld_dgcICShipmentItemWorkItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentItemWorkItems.BOSComment = null;
            this.fld_dgcICShipmentItemWorkItems.BOSDataMember = null;
            this.fld_dgcICShipmentItemWorkItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItemWorkItems.BOSDescription = null;
            this.fld_dgcICShipmentItemWorkItems.BOSError = null;
            this.fld_dgcICShipmentItemWorkItems.BOSFieldGroup = null;
            this.fld_dgcICShipmentItemWorkItems.BOSFieldRelation = null;
            this.fld_dgcICShipmentItemWorkItems.BOSGridType = null;
            this.fld_dgcICShipmentItemWorkItems.BOSPrivilege = null;
            this.fld_dgcICShipmentItemWorkItems.BOSPropertyName = null;
            this.fld_dgcICShipmentItemWorkItems.CommodityType = "";
            this.fld_dgcICShipmentItemWorkItems.Location = new System.Drawing.Point(8, 3);
            this.fld_dgcICShipmentItemWorkItems.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentItemWorkItems.Name = "fld_dgcICShipmentItemWorkItems";
            this.fld_dgcICShipmentItemWorkItems.PrintReport = false;
            this.fld_dgcICShipmentItemWorkItems.Screen = null;
            this.fld_dgcICShipmentItemWorkItems.Size = new System.Drawing.Size(1414, 492);
            this.fld_dgcICShipmentItemWorkItems.TabIndex = 4;
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1429, 498);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1429, 498);
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
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = true;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(759, 38);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICStockID, true);
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 12;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(671, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(38, 13);
            this.bosLabel6.TabIndex = 115;
            this.bosLabel6.Text = "Mã ĐBH";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(671, 41);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(18, 13);
            this.bosLabel13.TabIndex = 115;
            this.bosLabel13.Text = "Kho";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(671, 145);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 111;
            this.bosLabel11.Text = "Mã LSX";
            this.bosLabel11.Visible = false;
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(759, 142);
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
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMBatchProductID, true);
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 8;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.Visible = false;
            // 
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = null;
            this.fld_txtARSaleOrderNo.BOSDataMember = "ARSaleOrderNo";
            this.fld_txtARSaleOrderNo.BOSDataSource = "ICShipments";
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = null;
            this.fld_txtARSaleOrderNo.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(759, 64);
            this.fld_txtARSaleOrderNo.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(141, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 16;
            this.fld_txtARSaleOrderNo.Tag = "DC";
            // 
            // fld_txtICShipmentReference
            // 
            this.fld_txtICShipmentReference.BOSComment = null;
            this.fld_txtICShipmentReference.BOSDataMember = "ICShipmentReference";
            this.fld_txtICShipmentReference.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentReference.BOSDescription = null;
            this.fld_txtICShipmentReference.BOSError = null;
            this.fld_txtICShipmentReference.BOSFieldGroup = null;
            this.fld_txtICShipmentReference.BOSFieldRelation = null;
            this.fld_txtICShipmentReference.BOSPrivilege = null;
            this.fld_txtICShipmentReference.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentReference.Location = new System.Drawing.Point(490, 64);
            this.fld_txtICShipmentReference.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentReference.Name = "fld_txtICShipmentReference";
            this.fld_txtICShipmentReference.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICShipmentReference, false);
            this.fld_txtICShipmentReference.Size = new System.Drawing.Size(141, 20);
            this.fld_txtICShipmentReference.TabIndex = 11;
            this.fld_txtICShipmentReference.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(379, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(69, 13);
            this.bosLabel4.TabIndex = 22;
            this.bosLabel4.Text = "Mã tham chiếu";
            // 
            // fld_dteICShipmentDeliveryDate
            // 
            this.fld_dteICShipmentDeliveryDate.BOSComment = "";
            this.fld_dteICShipmentDeliveryDate.BOSDataMember = "ICShipmentDeliveryDate";
            this.fld_dteICShipmentDeliveryDate.BOSDataSource = "ICShipments";
            this.fld_dteICShipmentDeliveryDate.BOSDescription = null;
            this.fld_dteICShipmentDeliveryDate.BOSError = null;
            this.fld_dteICShipmentDeliveryDate.BOSFieldGroup = "";
            this.fld_dteICShipmentDeliveryDate.BOSFieldRelation = "";
            this.fld_dteICShipmentDeliveryDate.BOSPrivilege = "";
            this.fld_dteICShipmentDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDeliveryDate.EditValue = null;
            this.fld_dteICShipmentDeliveryDate.Location = new System.Drawing.Point(490, 38);
            this.fld_dteICShipmentDeliveryDate.Name = "fld_dteICShipmentDeliveryDate";
            this.fld_dteICShipmentDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDeliveryDate.Screen = null;
            this.fld_dteICShipmentDeliveryDate.Size = new System.Drawing.Size(141, 20);
            this.fld_dteICShipmentDeliveryDate.TabIndex = 7;
            this.fld_dteICShipmentDeliveryDate.Tag = "DC";
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
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(490, 12);
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
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(141, 20);
            this.fld_dteICShipmentDate.TabIndex = 3;
            this.fld_dteICShipmentDate.Tag = "DC";
            // 
            // fld_txtICShipmentName
            // 
            this.fld_txtICShipmentName.BOSComment = null;
            this.fld_txtICShipmentName.BOSDataMember = "ICShipmentName";
            this.fld_txtICShipmentName.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentName.BOSDescription = null;
            this.fld_txtICShipmentName.BOSError = null;
            this.fld_txtICShipmentName.BOSFieldGroup = null;
            this.fld_txtICShipmentName.BOSFieldRelation = null;
            this.fld_txtICShipmentName.BOSPrivilege = null;
            this.fld_txtICShipmentName.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentName.Location = new System.Drawing.Point(203, 38);
            this.fld_txtICShipmentName.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentName.Name = "fld_txtICShipmentName";
            this.fld_txtICShipmentName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICShipmentName, false);
            this.fld_txtICShipmentName.Size = new System.Drawing.Size(141, 20);
            this.fld_txtICShipmentName.TabIndex = 6;
            this.fld_txtICShipmentName.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(124, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(65, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Text = "Tên chứng từ";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(124, 67);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel10.TabIndex = 16;
            this.fld_lblLabel10.Text = "Đối tượng";
            // 
            // fld_pteICShipmentSOrderEmployeePicture
            // 
            this.fld_pteICShipmentSOrderEmployeePicture.BOSComment = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSDataMember = "ICShipmentSOrderEmployeePicture";
            this.fld_pteICShipmentSOrderEmployeePicture.BOSDataSource = "ICShipmentSOrders";
            this.fld_pteICShipmentSOrderEmployeePicture.BOSDescription = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSError = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSPrivilege = null;
            this.fld_pteICShipmentSOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentSOrderEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICShipmentSOrderEmployeePicture.FileName = null;
            this.fld_pteICShipmentSOrderEmployeePicture.FilePath = null;
            this.fld_pteICShipmentSOrderEmployeePicture.Location = new System.Drawing.Point(12, 10);
            this.fld_pteICShipmentSOrderEmployeePicture.Name = "fld_pteICShipmentSOrderEmployeePicture";
            this.fld_pteICShipmentSOrderEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICShipmentSOrderEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICShipmentSOrderEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICShipmentSOrderEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICShipmentSOrderEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentSOrderEmployeePicture.Screen = null;
            this.fld_pteICShipmentSOrderEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentSOrderEmployeePicture.TabIndex = 0;
            this.fld_pteICShipmentSOrderEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(12, 112);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(759, 12);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeICShipmentStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.ColumnName = null;
            this.fld_lkeICShipmentStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICShipmentProposalStatus", "Tình trạng")});
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICShipmentStatus, true);
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 4;
            this.fld_lkeICShipmentStatus.Tag = "DC";
            // 
            // fld_medICShipmentDesc
            // 
            this.fld_medICShipmentDesc.BOSComment = null;
            this.fld_medICShipmentDesc.BOSDataMember = "ICShipmentDesc";
            this.fld_medICShipmentDesc.BOSDataSource = "ICShipments";
            this.fld_medICShipmentDesc.BOSDescription = null;
            this.fld_medICShipmentDesc.BOSError = null;
            this.fld_medICShipmentDesc.BOSFieldGroup = null;
            this.fld_medICShipmentDesc.BOSFieldRelation = null;
            this.fld_medICShipmentDesc.BOSPrivilege = null;
            this.fld_medICShipmentDesc.BOSPropertyName = "EditValue";
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(203, 142);
            this.fld_medICShipmentDesc.MenuManager = this.screenToolbar;
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICShipmentDesc, false);
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(428, 20);
            this.fld_medICShipmentDesc.TabIndex = 18;
            this.fld_medICShipmentDesc.Tag = "DC";
            // 
            // fld_txtICShipmentNo
            // 
            this.fld_txtICShipmentNo.BOSComment = null;
            this.fld_txtICShipmentNo.BOSDataMember = "ICShipmentNo";
            this.fld_txtICShipmentNo.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentNo.BOSDescription = null;
            this.fld_txtICShipmentNo.BOSError = null;
            this.fld_txtICShipmentNo.BOSFieldGroup = null;
            this.fld_txtICShipmentNo.BOSFieldRelation = null;
            this.fld_txtICShipmentNo.BOSPrivilege = null;
            this.fld_txtICShipmentNo.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentNo.Location = new System.Drawing.Point(203, 12);
            this.fld_txtICShipmentNo.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentNo.Name = "fld_txtICShipmentNo";
            this.fld_txtICShipmentNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICShipmentNo, false);
            this.fld_txtICShipmentNo.Size = new System.Drawing.Size(141, 20);
            this.fld_txtICShipmentNo.TabIndex = 2;
            this.fld_txtICShipmentNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(124, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(124, 145);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel9.Location = new System.Drawing.Point(379, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(96, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Text = "Ngày xuất kế hoạch";
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
            this.bosLabel3.Location = new System.Drawing.Point(671, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(379, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // fld_dgvICShipmentProposalItems
            // 
            this.fld_dgvICShipmentProposalItems.Name = "fld_dgvICShipmentProposalItems";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(1182, 41);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(21, 13);
            this.bosLabel24.TabIndex = 850;
            this.bosLabel24.Text = "POD";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = null;
            this.bosTextBox9.BOSDataMember = "ICShipmentPOD";
            this.bosTextBox9.BOSDataSource = "ICShipments";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = null;
            this.bosTextBox9.BOSFieldRelation = null;
            this.bosTextBox9.BOSPrivilege = null;
            this.bosTextBox9.BOSPropertyName = "EditValue";
            this.bosTextBox9.Location = new System.Drawing.Point(1258, 38);
            this.bosTextBox9.MenuManager = this.screenToolbar;
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox9.TabIndex = 849;
            this.bosTextBox9.Tag = "DC";
            // 
            // DMSOSM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1448, 701);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSOSM100.IconOptions.Icon")));
            this.Name = "DMSOSM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentInternalSeal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabShiptmentSaleOrderItems)).EndInit();
            this.fld_tabShiptmentSaleOrderItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.ResumeLayout(false);
            this.fld_tabPageShipmentItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            this.fld_tabPackNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackages)).EndInit();
            this.fld_tabPageItemWorkItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItemWorkItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentSOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentStatus;
        private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private BOSComponent.BOSTextBox fld_txtICShipmentNo;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentProposalItemProductPicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentProposalItems;
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;

        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentSOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSTextBox fld_txtICShipmentName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteICShipmentDeliveryDate;
        private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
        private BOSComponent.BOSTextBox fld_txtICShipmentReference;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTabControl fld_tabShiptmentSaleOrderItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageShipmentItems;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel14;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private ICShipmentItemsGridControl fld_dgcICShipmentItems;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageItemWorkItems;
        private ICShipmentItemWorkItemsGridControl fld_dgcICShipmentItemWorkItems;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel12;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackNo;
        private ICShipmentPackagesGridControl fld_dgcICShipmentPackages;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel62;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentProductType;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtICShipmentDeliveryContactName;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSButton fld_btnAutoSelectProductSerialNo;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtICShipmentInternalSeal;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox bosTextBox9;
    }
}
