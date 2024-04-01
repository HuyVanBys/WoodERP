using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseOrder.UI
{
	/// <summary>
	/// Summary description for DMPO100
	/// </summary>
	partial class DMPO100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPO100));
            this.fld_medAPPurchaseOrderComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnShippingInfo = new BOSComponent.BOSButton(this.components);
            this.fld_txtAPPurchaseOrderShippingFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderShippingExtraFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseOrderDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARPurchaseOrderSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseOrderProject = new BOSComponent.BOSTextBox(this.components);
            this.fld_linkViewApproval = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLookupEdit6 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchasingStaffID = new BOSComponent.BOSLookupEdit(this.components);
            this.accObjectLookupEdit1 = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPPurchaseOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseOrderTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteAPPurchaseOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeAPPurchaseOrderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseOrderExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderContractNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPurchaseOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPurchaseOrderContractDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteAPPurchaseOrderPackingDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteAPPurchaseOrderDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPurchaseOrdeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_tclModuleObjects = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdateInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_btnShowProposalItems = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPPurchaseOrderItems = new BOSERP.Modules.PurchaseOrder.APPurchaseOrderItemsGridControl();
            this.fld_dgvAPPurchaseOrderItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteAPPurchaseOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_tabOutsourcingProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddMoreMaterial = new BOSComponent.BOSButton(this.components);
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl = new BOSERP.Modules.PurchaseOrder.APPurchaseOrderItemOutSourcingsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddSemiProduct = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPPurchaseOrderPaymentTimes = new BOSERP.Modules.PurchaseOrder.APPurchaseOrderPaymentTimesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveDelivery = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPPurchaseOrderItemDeliverys = new BOSERP.Modules.PurchaseOrder.APPurchaseOrderItemDeliverysGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgvAPPurchaseOrderPaymentTimes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPurchaseOrderComment.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderShippingFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderShippingExtraFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPurchaseOrderSubTotalCost.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchasingStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPurchaseOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPurchaseOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderContractDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderPackingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderPackingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrdeDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrdeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclModuleObjects)).BeginInit();
            this.fld_tclModuleObjects.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPurchaseOrderItemProductPicture.Properties)).BeginInit();
            this.fld_tabOutsourcingProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItemDeliverys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_medAPPurchaseOrderComment
            // 
            this.fld_medAPPurchaseOrderComment.BOSComment = "";
            this.fld_medAPPurchaseOrderComment.BOSDataMember = "APPurchaseOrderComment";
            this.fld_medAPPurchaseOrderComment.BOSDataSource = "APPurchaseOrders";
            this.fld_medAPPurchaseOrderComment.BOSDescription = null;
            this.fld_medAPPurchaseOrderComment.BOSError = null;
            this.fld_medAPPurchaseOrderComment.BOSFieldGroup = "";
            this.fld_medAPPurchaseOrderComment.BOSFieldRelation = "";
            this.fld_medAPPurchaseOrderComment.BOSPrivilege = "";
            this.fld_medAPPurchaseOrderComment.BOSPropertyName = "Text";
            this.fld_medAPPurchaseOrderComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medAPPurchaseOrderComment.EditValue = "";
            this.fld_medAPPurchaseOrderComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medAPPurchaseOrderComment.Name = "fld_medAPPurchaseOrderComment";
            this.fld_medAPPurchaseOrderComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPPurchaseOrderComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPPurchaseOrderComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPPurchaseOrderComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPPurchaseOrderComment.Screen = null;
            this.fld_medAPPurchaseOrderComment.Size = new System.Drawing.Size(316, 150);
            this.fld_medAPPurchaseOrderComment.TabIndex = 0;
            this.fld_medAPPurchaseOrderComment.Tag = "DC";
            // 
            // fld_Line3
            // 
            this.fld_Line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_Line3.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.BOSComment = "";
            this.fld_Line3.BOSDataMember = "";
            this.fld_Line3.BOSDataSource = "";
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = "";
            this.fld_Line3.BOSFieldRelation = "";
            this.fld_Line3.BOSPrivilege = "";
            this.fld_Line3.BOSPropertyName = "";
            this.fld_Line3.Controls.Add(this.fld_lblLabel14);
            this.fld_Line3.Controls.Add(this.fld_lblLabel12);
            this.fld_Line3.Controls.Add(this.fld_lblLabel9);
            this.fld_Line3.Controls.Add(this.fld_Line2);
            this.fld_Line3.Controls.Add(this.fld_Line1);
            this.fld_Line3.Controls.Add(this.fld_lblLabel13);
            this.fld_Line3.Controls.Add(this.fld_lblLabel11);
            this.fld_Line3.Controls.Add(this.fld_lblLabel10);
            this.fld_Line3.Controls.Add(this.fld_btnShippingInfo);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(331, 863);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(372, 170);
            this.fld_Line3.TabIndex = 24;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Tag = "";
            this.fld_Line3.Text = "Thông tin giao hàng";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "APPurchaseOrderDeliveryAddressPostalCode";
            this.fld_lblLabel14.BOSDataSource = "APPurchaseOrders";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = "";
            this.fld_lblLabel14.Location = new System.Drawing.Point(6, 132);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel14.TabIndex = 33;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "08";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "APPurchaseOrderInvoiceAddressPostalCode";
            this.fld_lblLabel12.BOSDataSource = "APPurchaseOrders";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(6, 62);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(12, 13);
            this.fld_lblLabel12.TabIndex = 31;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "08";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseFont = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            this.fld_lblLabel9.Location = new System.Drawing.Point(6, 20);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel9.TabIndex = 28;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Ðịa chỉ hóa đơn";
            // 
            // fld_Line2
            // 
            this.fld_Line2.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line2.BOSComment = "";
            this.fld_Line2.BOSDataMember = "";
            this.fld_Line2.BOSDataSource = "";
            this.fld_Line2.BOSDescription = null;
            this.fld_Line2.BOSError = null;
            this.fld_Line2.BOSFieldGroup = "";
            this.fld_Line2.BOSFieldRelation = "";
            this.fld_Line2.BOSPrivilege = "";
            this.fld_Line2.BOSPropertyName = "";
            this.fld_Line2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line2.Location = new System.Drawing.Point(108, 99);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(250, 3);
            this.fld_Line2.TabIndex = 36;
            this.fld_Line2.TabStop = false;
            this.fld_Line2.Tag = "";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line1.BOSComment = "";
            this.fld_Line1.BOSDataMember = "";
            this.fld_Line1.BOSDataSource = "";
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = "";
            this.fld_Line1.BOSFieldRelation = "";
            this.fld_Line1.BOSPrivilege = "";
            this.fld_Line1.BOSPropertyName = "";
            this.fld_Line1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line1.Location = new System.Drawing.Point(108, 30);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(250, 3);
            this.fld_Line1.TabIndex = 35;
            this.fld_Line1.TabStop = false;
            this.fld_Line1.Tag = "";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "APPurchaseOrderDeliveryAddressLine3";
            this.fld_lblLabel13.BOSDataSource = "APPurchaseOrders";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = "";
            this.fld_lblLabel13.Location = new System.Drawing.Point(7, 112);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(77, 13);
            this.fld_lblLabel13.TabIndex = 32;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Tại kho Lâm Việt";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "APPurchaseOrderInvoiceAddressLine3";
            this.fld_lblLabel11.BOSDataSource = "APPurchaseOrders";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(6, 42);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(137, 13);
            this.fld_lblLabel11.TabIndex = 30;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "35 Nguyen Hue, Dist 1, HCM";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseFont = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = "";
            this.fld_lblLabel10.Location = new System.Drawing.Point(6, 89);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(100, 13);
            this.fld_lblLabel10.TabIndex = 29;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Ðịa chỉ nhận hàng";
            // 
            // fld_btnShippingInfo
            // 
            this.fld_btnShippingInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShippingInfo.Appearance.Options.UseForeColor = true;
            this.fld_btnShippingInfo.BOSComment = "";
            this.fld_btnShippingInfo.BOSDataMember = "";
            this.fld_btnShippingInfo.BOSDataSource = "";
            this.fld_btnShippingInfo.BOSDescription = null;
            this.fld_btnShippingInfo.BOSError = null;
            this.fld_btnShippingInfo.BOSFieldGroup = "";
            this.fld_btnShippingInfo.BOSFieldRelation = "";
            this.fld_btnShippingInfo.BOSPrivilege = "";
            this.fld_btnShippingInfo.BOSPropertyName = "";
            this.fld_btnShippingInfo.Location = new System.Drawing.Point(291, 144);
            this.fld_btnShippingInfo.Name = "fld_btnShippingInfo";
            this.fld_btnShippingInfo.Screen = null;
            this.fld_btnShippingInfo.Size = new System.Drawing.Size(75, 20);
            this.fld_btnShippingInfo.TabIndex = 0;
            this.fld_btnShippingInfo.Tag = "";
            this.fld_btnShippingInfo.Text = "Sửa";
            this.fld_btnShippingInfo.Click += new System.EventHandler(this.fld_btnShippingInfo_Click);
            // 
            // fld_txtAPPurchaseOrderShippingFees
            // 
            this.fld_txtAPPurchaseOrderShippingFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderShippingFees.BOSComment = "";
            this.fld_txtAPPurchaseOrderShippingFees.BOSDataMember = "APPurchaseOrderShippingFees";
            this.fld_txtAPPurchaseOrderShippingFees.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderShippingFees.BOSDescription = null;
            this.fld_txtAPPurchaseOrderShippingFees.BOSError = null;
            this.fld_txtAPPurchaseOrderShippingFees.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderShippingFees.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderShippingFees.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderShippingFees.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderShippingFees.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderShippingFees.Location = new System.Drawing.Point(1368, 912);
            this.fld_txtAPPurchaseOrderShippingFees.Name = "fld_txtAPPurchaseOrderShippingFees";
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderShippingFees.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderShippingFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderShippingFees.Screen = null;
            this.fld_txtAPPurchaseOrderShippingFees.Size = new System.Drawing.Size(178, 20);
            this.fld_txtAPPurchaseOrderShippingFees.TabIndex = 35;
            this.fld_txtAPPurchaseOrderShippingFees.Tag = "DC";
            this.fld_txtAPPurchaseOrderShippingFees.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderShippingFees_Validated);
            // 
            // fld_txtAPPurchaseOrderShippingExtraFees
            // 
            this.fld_txtAPPurchaseOrderShippingExtraFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSComment = "";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSDataMember = "APPurchaseOrderShippingExtraFees";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSDescription = null;
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSError = null;
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderShippingExtraFees.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderShippingExtraFees.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderShippingExtraFees.Location = new System.Drawing.Point(1368, 937);
            this.fld_txtAPPurchaseOrderShippingExtraFees.Name = "fld_txtAPPurchaseOrderShippingExtraFees";
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderShippingExtraFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Screen = null;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Size = new System.Drawing.Size(178, 20);
            this.fld_txtAPPurchaseOrderShippingExtraFees.TabIndex = 36;
            this.fld_txtAPPurchaseOrderShippingExtraFees.Tag = "DC";
            this.fld_txtAPPurchaseOrderShippingExtraFees.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderShippingExtraFees_Validated);
            // 
            // fld_txtAPPurchaseOrderDiscountPerCent
            // 
            this.fld_txtAPPurchaseOrderDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSComment = "";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSDataMember = "APPurchaseOrderDiscountPerCent";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSDescription = null;
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSError = null;
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderDiscountPerCent.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderDiscountPerCent.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderDiscountPerCent.Location = new System.Drawing.Point(1368, 886);
            this.fld_txtAPPurchaseOrderDiscountPerCent.Name = "fld_txtAPPurchaseOrderDiscountPerCent";
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Screen = null;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtAPPurchaseOrderDiscountPerCent.TabIndex = 33;
            this.fld_txtAPPurchaseOrderDiscountPerCent.Tag = "DC";
            this.fld_txtAPPurchaseOrderDiscountPerCent.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderDiscountPerCent_Validated);
            // 
            // fld_txtAPPurchaseOrderTaxPercent
            // 
            this.fld_txtAPPurchaseOrderTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderTaxPercent.BOSComment = "";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSDataMember = "APPurchaseOrderTaxPercent";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSDescription = null;
            this.fld_txtAPPurchaseOrderTaxPercent.BOSError = null;
            this.fld_txtAPPurchaseOrderTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderTaxPercent.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderTaxPercent.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderTaxPercent.Location = new System.Drawing.Point(1368, 962);
            this.fld_txtAPPurchaseOrderTaxPercent.Name = "fld_txtAPPurchaseOrderTaxPercent";
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderTaxPercent.Screen = null;
            this.fld_txtAPPurchaseOrderTaxPercent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtAPPurchaseOrderTaxPercent.TabIndex = 37;
            this.fld_txtAPPurchaseOrderTaxPercent.Tag = "DC";
            this.fld_txtAPPurchaseOrderTaxPercent.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderTaxPercent_Validated);
            // 
            // fld_txtAPPurchaseOrderTotalCost
            // 
            this.fld_txtAPPurchaseOrderTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderTotalCost.BOSComment = "";
            this.fld_txtAPPurchaseOrderTotalCost.BOSDataMember = "APPurchaseOrderTotalCost";
            this.fld_txtAPPurchaseOrderTotalCost.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderTotalCost.BOSDescription = null;
            this.fld_txtAPPurchaseOrderTotalCost.BOSError = null;
            this.fld_txtAPPurchaseOrderTotalCost.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderTotalCost.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderTotalCost.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderTotalCost.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderTotalCost.Location = new System.Drawing.Point(1368, 988);
            this.fld_txtAPPurchaseOrderTotalCost.Name = "fld_txtAPPurchaseOrderTotalCost";
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderTotalCost.Properties.ReadOnly = true;
            this.fld_txtAPPurchaseOrderTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderTotalCost.Screen = null;
            this.fld_txtAPPurchaseOrderTotalCost.Size = new System.Drawing.Size(178, 20);
            this.fld_txtAPPurchaseOrderTotalCost.TabIndex = 39;
            this.fld_txtAPPurchaseOrderTotalCost.Tag = "DC";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = "";
            this.fld_lblLabel16.BOSDataMember = "";
            this.fld_lblLabel16.BOSDataSource = "";
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = "";
            this.fld_lblLabel16.BOSFieldRelation = "";
            this.fld_lblLabel16.BOSPrivilege = "";
            this.fld_lblLabel16.BOSPropertyName = "";
            this.fld_lblLabel16.Location = new System.Drawing.Point(1259, 863);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel16.TabIndex = 43;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Tổng cộng";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = "";
            this.fld_lblLabel19.Location = new System.Drawing.Point(1259, 888);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel19.TabIndex = 45;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Chiết khấu";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(1259, 965);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(24, 13);
            this.bosLabel1.TabIndex = 45;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Thuế";
            // 
            // fld_txtAPPurchaseOrderDiscountFix
            // 
            this.fld_txtAPPurchaseOrderDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderDiscountFix.BOSComment = "";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSDataMember = "APPurchaseOrderDiscountFix";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSDescription = null;
            this.fld_txtAPPurchaseOrderDiscountFix.BOSError = null;
            this.fld_txtAPPurchaseOrderDiscountFix.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderDiscountFix.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderDiscountFix.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderDiscountFix.Location = new System.Drawing.Point(1442, 886);
            this.fld_txtAPPurchaseOrderDiscountFix.Name = "fld_txtAPPurchaseOrderDiscountFix";
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderDiscountFix.Screen = null;
            this.fld_txtAPPurchaseOrderDiscountFix.Size = new System.Drawing.Size(104, 20);
            this.fld_txtAPPurchaseOrderDiscountFix.TabIndex = 34;
            this.fld_txtAPPurchaseOrderDiscountFix.Tag = "DC";
            this.fld_txtAPPurchaseOrderDiscountFix.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderDiscountFix_Validated);
            // 
            // fld_txtAPPurchaseOrderTaxAmount
            // 
            this.fld_txtAPPurchaseOrderTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseOrderTaxAmount.BOSComment = "";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSDataMember = "APPurchaseOrderTaxAmount";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSDescription = null;
            this.fld_txtAPPurchaseOrderTaxAmount.BOSError = null;
            this.fld_txtAPPurchaseOrderTaxAmount.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderTaxAmount.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderTaxAmount.EditValue = "0.00";
            this.fld_txtAPPurchaseOrderTaxAmount.Location = new System.Drawing.Point(1442, 962);
            this.fld_txtAPPurchaseOrderTaxAmount.Name = "fld_txtAPPurchaseOrderTaxAmount";
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderTaxAmount.Properties.ReadOnly = true;
            this.fld_txtAPPurchaseOrderTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderTaxAmount.Screen = null;
            this.fld_txtAPPurchaseOrderTaxAmount.Size = new System.Drawing.Size(104, 20);
            this.fld_txtAPPurchaseOrderTaxAmount.TabIndex = 38;
            this.fld_txtAPPurchaseOrderTaxAmount.Tag = "DC";
            this.fld_txtAPPurchaseOrderTaxAmount.Validated += new System.EventHandler(this.fld_txtAPPurchaseOrderTaxAmount_Validated);
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = "";
            this.fld_lblLabel20.BOSDataMember = "";
            this.fld_lblLabel20.BOSDataSource = "";
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = "";
            this.fld_lblLabel20.BOSFieldRelation = "";
            this.fld_lblLabel20.BOSPrivilege = "";
            this.fld_lblLabel20.BOSPropertyName = "";
            this.fld_lblLabel20.Location = new System.Drawing.Point(1259, 915);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel20.TabIndex = 47;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Phí vận chuyển";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment = "";
            this.fld_lblLabel21.BOSDataMember = "";
            this.fld_lblLabel21.BOSDataSource = "";
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup = "";
            this.fld_lblLabel21.BOSFieldRelation = "";
            this.fld_lblLabel21.BOSPrivilege = "";
            this.fld_lblLabel21.BOSPropertyName = "";
            this.fld_lblLabel21.Location = new System.Drawing.Point(1259, 939);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel21.TabIndex = 48;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Phí khác";
            // 
            // fld_txtARPurchaseOrderSubTotalCost
            // 
            this.fld_txtARPurchaseOrderSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARPurchaseOrderSubTotalCost.BOSComment = "";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDataMember = "APPurchaseOrderSubTotalCost";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDataSource = "APPurchaseOrders";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDescription = null;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSError = null;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSFieldGroup = "";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSFieldRelation = "";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSPrivilege = "";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSPropertyName = "Text";
            this.fld_txtARPurchaseOrderSubTotalCost.EditValue = "0.00";
            this.fld_txtARPurchaseOrderSubTotalCost.Location = new System.Drawing.Point(1368, 860);
            this.fld_txtARPurchaseOrderSubTotalCost.Name = "fld_txtARPurchaseOrderSubTotalCost";
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtARPurchaseOrderSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARPurchaseOrderSubTotalCost.Screen = null;
            this.fld_txtARPurchaseOrderSubTotalCost.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARPurchaseOrderSubTotalCost.TabIndex = 32;
            this.fld_txtARPurchaseOrderSubTotalCost.Tag = "DC";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseFont = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = "";
            this.fld_lblLabel22.Location = new System.Drawing.Point(1259, 990);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel22.TabIndex = 49;
            this.fld_lblLabel22.Tag = "";
            this.fld_lblLabel22.Text = "THÀNH TIỀN";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderProject);
            this.bosPanel1.Controls.Add(this.fld_linkViewApproval);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLookupEdit6);
            this.bosPanel1.Controls.Add(this.fld_dteFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLookupEdit4);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APPurchasingStaffID);
            this.bosPanel1.Controls.Add(this.accObjectLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_medAPPurchaseOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLookupEdit3);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLookupEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPurchaseOrderTypeCombo);
            this.bosPanel1.Controls.Add(this.fld_pteAPPurchaseOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPurchaseOrderStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderContractNo);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderNo);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPurchaseOrderReceiptTypeCombo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPaymentMethodCombo);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteAPPurchaseOrderContractDate);
            this.bosPanel1.Controls.Add(this.fld_dteAPPurchaseOrderPackingDate);
            this.bosPanel1.Controls.Add(this.fld_dteAPPurchaseOrderDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteAPPurchaseOrdeDate);
            this.bosPanel1.Controls.Add(this.fld_tclModuleObjects);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel22);
            this.bosPanel1.Controls.Add(this.fld_txtARPurchaseOrderSubTotalCost);
            this.bosPanel1.Controls.Add(this.fld_lblLabel21);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderDiscountFix);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel19);
            this.bosPanel1.Controls.Add(this.fld_lblLabel16);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderTotalCost);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderShippingExtraFees);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderShippingFees);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1556, 1043);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel22.Location = new System.Drawing.Point(890, 195);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(94, 13);
            this.bosLabel22.TabIndex = 658;
            this.bosLabel22.Text = "Mã đơn hàng nội bộ";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "MMBatchProductSOName";
            this.bosTextBox2.BOSDataSource = "APPurchaseOrders";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Enabled = false;
            this.bosTextBox2.Location = new System.Drawing.Point(995, 192);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 657;
            this.bosTextBox2.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = "";
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockSlotID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = "";
            this.fld_lkeFK_ICStockID.BOSFieldParent = "";
            this.fld_lkeFK_ICStockID.BOSFieldRelation = "";
            this.fld_lkeFK_ICStockID.BOSPrivilege = "";
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = "";
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(722, 192);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Kho")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 655;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(635, 195);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(18, 13);
            this.bosLabel21.TabIndex = 656;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Kho";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(875, 13);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(6, 13);
            this.bosLabel14.TabIndex = 654;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "*";
            // 
            // fld_txtAPPurchaseOrderProject
            // 
            this.fld_txtAPPurchaseOrderProject.BOSComment = "";
            this.fld_txtAPPurchaseOrderProject.BOSDataMember = "APPurchaseOrderProject";
            this.fld_txtAPPurchaseOrderProject.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderProject.BOSDescription = null;
            this.fld_txtAPPurchaseOrderProject.BOSError = null;
            this.fld_txtAPPurchaseOrderProject.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderProject.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderProject.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderProject.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderProject.EditValue = "";
            this.fld_txtAPPurchaseOrderProject.Location = new System.Drawing.Point(722, 88);
            this.fld_txtAPPurchaseOrderProject.Name = "fld_txtAPPurchaseOrderProject";
            this.fld_txtAPPurchaseOrderProject.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPPurchaseOrderProject.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderProject.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderProject.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderProject.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderProject.Screen = null;
            this.fld_txtAPPurchaseOrderProject.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseOrderProject.TabIndex = 16;
            this.fld_txtAPPurchaseOrderProject.Tag = "DC";
            // 
            // fld_linkViewApproval
            // 
            this.fld_linkViewApproval.Location = new System.Drawing.Point(722, 218);
            this.fld_linkViewApproval.Name = "fld_linkViewApproval";
            this.fld_linkViewApproval.Size = new System.Drawing.Size(118, 13);
            this.fld_linkViewApproval.TabIndex = 27;
            this.fld_linkViewApproval.Text = "Xem thông tin phê duyệt";
            this.fld_linkViewApproval.Click += new System.EventHandler(this.fld_linkViewApproval_Click);
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = "";
            this.bosButton1.BOSDataMember = "";
            this.bosButton1.BOSDataSource = "";
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = "";
            this.bosButton1.BOSFieldRelation = "";
            this.bosButton1.BOSPrivilege = "";
            this.bosButton1.BOSPropertyName = "";
            this.bosButton1.Location = new System.Drawing.Point(977, 218);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(150, 20);
            this.bosButton1.TabIndex = 28;
            this.bosButton1.Tag = "";
            this.bosButton1.Text = "Áp dụng giá cũ (từ NKMH)";
            this.bosButton1.Click += new System.EventHandler(this.Fld_btnApplyOldPrice_Click);
            // 
            // bosLookupEdit6
            // 
            this.bosLookupEdit6.BOSAllowAddNew = false;
            this.bosLookupEdit6.BOSAllowDummy = true;
            this.bosLookupEdit6.BOSComment = "";
            this.bosLookupEdit6.BOSDataMember = "FK_GECountryID";
            this.bosLookupEdit6.BOSDataSource = "APPurchaseOrders";
            this.bosLookupEdit6.BOSDescription = null;
            this.bosLookupEdit6.BOSError = null;
            this.bosLookupEdit6.BOSFieldGroup = "";
            this.bosLookupEdit6.BOSFieldParent = "";
            this.bosLookupEdit6.BOSFieldRelation = "";
            this.bosLookupEdit6.BOSPrivilege = "";
            this.bosLookupEdit6.BOSPropertyName = "EditValue";
            this.bosLookupEdit6.BOSSelectType = "";
            this.bosLookupEdit6.BOSSelectTypeValue = "";
            this.bosLookupEdit6.CurrentDisplayText = "";
            this.bosLookupEdit6.Location = new System.Drawing.Point(722, 166);
            this.bosLookupEdit6.Name = "bosLookupEdit6";
            this.bosLookupEdit6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit6.Properties.ColumnName = null;
            this.bosLookupEdit6.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Tên")});
            this.bosLookupEdit6.Properties.DisplayMember = "GECountryName";
            this.bosLookupEdit6.Properties.NullText = "";
            this.bosLookupEdit6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit6.Properties.ValueMember = "GECountryID";
            this.bosLookupEdit6.Screen = null;
            this.bosLookupEdit6.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit6.TabIndex = 25;
            this.bosLookupEdit6.Tag = "DC";
            this.bosLookupEdit6.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit6_CloseUp);
            // 
            // fld_dteFK_ICProductAttributeTTMTID
            // 
            this.fld_dteFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_dteFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_dteFK_ICProductAttributeTTMTID.BOSComment = "";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSDataSource = "APPurchaseOrders";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_dteFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_dteFK_ICProductAttributeTTMTID.BOSFieldGroup = "";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSFieldParent = "";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSFieldRelation = "";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSPrivilege = "";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_dteFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_dteFK_ICProductAttributeTTMTID.CurrentDisplayText = "";
            this.fld_dteFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(995, 114);
            this.fld_dteFK_ICProductAttributeTTMTID.Name = "fld_dteFK_ICProductAttributeTTMTID";
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên")});
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dteFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_dteFK_ICProductAttributeTTMTID.Screen = null;
            this.fld_dteFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFK_ICProductAttributeTTMTID.TabIndex = 21;
            this.fld_dteFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_dteFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_dteFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = false;
            this.bosLookupEdit4.BOSComment = "";
            this.bosLookupEdit4.BOSDataMember = "FK_GETerminalID";
            this.bosLookupEdit4.BOSDataSource = "APPurchaseOrders";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = "";
            this.bosLookupEdit4.BOSFieldParent = "";
            this.bosLookupEdit4.BOSFieldRelation = "";
            this.bosLookupEdit4.BOSPrivilege = "";
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = "";
            this.bosLookupEdit4.BOSSelectTypeValue = "";
            this.bosLookupEdit4.CurrentDisplayText = "";
            this.bosLookupEdit4.Location = new System.Drawing.Point(995, 88);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên")});
            this.bosLookupEdit4.Properties.DisplayMember = "GETerminalName";
            this.bosLookupEdit4.Properties.NullText = "";
            this.bosLookupEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit4.Properties.ValueMember = "GETerminalID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit4.TabIndex = 17;
            this.bosLookupEdit4.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(635, 169);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(38, 13);
            this.bosLabel13.TabIndex = 653;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Xuất xứ";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(890, 117);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(26, 13);
            this.bosLabel12.TabIndex = 653;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "TTMT";
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
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(890, 92);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(25, 13);
            this.bosLabel7.TabIndex = 653;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Cảng";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = "";
            this.bosLabel24.Location = new System.Drawing.Point(634, 90);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(45, 13);
            this.bosLabel24.TabIndex = 651;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Mã dự án";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(361, 40);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(6, 13);
            this.bosLabel19.TabIndex = 648;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "*";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(634, 40);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(78, 13);
            this.bosLabel23.TabIndex = 647;
            this.bosLabel23.Text = "Người mua hàng";
            // 
            // fld_lkeFK_APPurchasingStaffID
            // 
            this.fld_lkeFK_APPurchasingStaffID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchasingStaffID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchasingStaffID.BOSComment = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSDataMember = "FK_APPurchasingStaffID";
            this.fld_lkeFK_APPurchasingStaffID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_APPurchasingStaffID.BOSDescription = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSError = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldGroup = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldParent = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldRelation = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSPrivilege = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchasingStaffID.BOSSelectType = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APPurchasingStaffID.CurrentDisplayText = null;
            this.fld_lkeFK_APPurchasingStaffID.Location = new System.Drawing.Point(722, 36);
            this.fld_lkeFK_APPurchasingStaffID.Name = "fld_lkeFK_APPurchasingStaffID";
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchasingStaffID.Properties.ColumnName = null;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_APPurchasingStaffID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_APPurchasingStaffID.Properties.NullText = "";
            this.fld_lkeFK_APPurchasingStaffID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchasingStaffID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_APPurchasingStaffID.Screen = null;
            this.fld_lkeFK_APPurchasingStaffID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APPurchasingStaffID.TabIndex = 8;
            this.fld_lkeFK_APPurchasingStaffID.Tag = "DC";
            this.fld_lkeFK_APPurchasingStaffID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APPurchasingStaffID_CloseUp);
            // 
            // accObjectLookupEdit1
            // 
            this.accObjectLookupEdit1.BOSAllowAddNew = false;
            this.accObjectLookupEdit1.BOSAllowDummy = true;
            this.accObjectLookupEdit1.BOSComment = "";
            this.accObjectLookupEdit1.BOSDataMember = "ACAssObjectAccessKey";
            this.accObjectLookupEdit1.BOSDataSource = "APPurchaseOrders";
            this.accObjectLookupEdit1.BOSDescription = null;
            this.accObjectLookupEdit1.BOSError = null;
            this.accObjectLookupEdit1.BOSFieldGroup = "";
            this.accObjectLookupEdit1.BOSFieldParent = "";
            this.accObjectLookupEdit1.BOSFieldRelation = "";
            this.accObjectLookupEdit1.BOSModuleType = "SaleOrder";
            this.accObjectLookupEdit1.BOSPrivilege = "";
            this.accObjectLookupEdit1.BOSPropertyName = "EditValue";
            this.accObjectLookupEdit1.BOSSelectType = "";
            this.accObjectLookupEdit1.BOSSelectTypeValue = "";
            this.accObjectLookupEdit1.CurrentDisplayText = null;
            this.accObjectLookupEdit1.LastedUpdate = new System.DateTime(((long)(0)));
            this.accObjectLookupEdit1.Location = new System.Drawing.Point(995, 36);
            this.accObjectLookupEdit1.Name = "accObjectLookupEdit1";
            this.accObjectLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accObjectLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.accObjectLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accObjectLookupEdit1.Properties.ColumnName = null;
            this.accObjectLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.accObjectLookupEdit1.Properties.DisplayMember = "ACObjectName";
            this.accObjectLookupEdit1.Properties.NullText = "";
            this.accObjectLookupEdit1.Properties.PopupWidth = 40;
            this.accObjectLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accObjectLookupEdit1.Properties.ValueMember = "ACObjectID";
            this.accObjectLookupEdit1.Screen = null;
            this.accObjectLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.accObjectLookupEdit1.TabIndex = 9;
            this.accObjectLookupEdit1.Tag = "DC";
            this.accObjectLookupEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.accObjectLookupEdit1_CloseUp);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(890, 40);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(56, 13);
            this.bosLabel18.TabIndex = 646;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Khách hàng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPurchaseOrders";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(208, 36);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 6;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = false;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_GEPaymentTermID.BOSDescription = null;
            this.fld_lkeFK_GEPaymentTermID.BOSError = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldGroup = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldParent = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldRelation = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPrivilege = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectType = null;
            this.fld_lkeFK_GEPaymentTermID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEPaymentTermID.CurrentDisplayText = null;
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(208, 114);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", "Ðiều khoản thanh toán", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = "";
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 18;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            this.fld_lkeFK_GEPaymentTermID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEPaymentTermID_CloseUp);
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
            this.bosLabel20.Location = new System.Drawing.Point(123, 118);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(69, 13);
            this.bosLabel20.TabIndex = 645;
            this.bosLabel20.Text = "Ðiều khoản TT";
            // 
            // fld_medAPPurchaseOrderDesc
            // 
            this.fld_medAPPurchaseOrderDesc.BOSComment = "";
            this.fld_medAPPurchaseOrderDesc.BOSDataMember = "APPurchaseOrderDesc";
            this.fld_medAPPurchaseOrderDesc.BOSDataSource = "APPurchaseOrders";
            this.fld_medAPPurchaseOrderDesc.BOSDescription = null;
            this.fld_medAPPurchaseOrderDesc.BOSError = null;
            this.fld_medAPPurchaseOrderDesc.BOSFieldGroup = "";
            this.fld_medAPPurchaseOrderDesc.BOSFieldRelation = "";
            this.fld_medAPPurchaseOrderDesc.BOSPrivilege = "";
            this.fld_medAPPurchaseOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medAPPurchaseOrderDesc.EditValue = "";
            this.fld_medAPPurchaseOrderDesc.Location = new System.Drawing.Point(208, 140);
            this.fld_medAPPurchaseOrderDesc.Name = "fld_medAPPurchaseOrderDesc";
            this.fld_medAPPurchaseOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPPurchaseOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPPurchaseOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPPurchaseOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPPurchaseOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAPPurchaseOrderDesc, true);
            this.fld_medAPPurchaseOrderDesc.Size = new System.Drawing.Size(405, 72);
            this.fld_medAPPurchaseOrderDesc.TabIndex = 22;
            this.fld_medAPPurchaseOrderDesc.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(123, 147);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(40, 13);
            this.bosLabel17.TabIndex = 644;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Diễn giải";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "APPurchaseOrderProposedEmployeeID";
            this.bosLookupEdit3.BOSDataSource = "APPurchaseOrders";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(722, 62);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.bosLookupEdit3.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit3, true);
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 12;
            this.bosLookupEdit3.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(634, 66);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(55, 13);
            this.bosLabel15.TabIndex = 643;
            this.bosLabel15.Text = "Người nhận";
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
            this.bosLabel16.Location = new System.Drawing.Point(634, 14);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(39, 13);
            this.bosLabel16.TabIndex = 642;
            this.bosLabel16.Text = "Bộ phận";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(722, 10);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(890, 14);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 641;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Mã LSX";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "FK_MMBatchProductID";
            this.bosLookupEdit2.BOSDataSource = "APPurchaseOrders";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(995, 10);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.bosLookupEdit2.Properties.DisplayMember = "MMBatchProductNo";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "MMBatchProductID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 5;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(378, 66);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(34, 13);
            this.bosLabel10.TabIndex = 640;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Mua từ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "APPurchaseOrderChannel";
            this.bosLookupEdit1.BOSDataSource = "APPurchaseOrders";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(463, 62);
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
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 11;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.bosLookupEdit1_Closed);
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(378, 92);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 639;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mua theo";
            // 
            // fld_lkeAPPurchaseOrderTypeCombo
            // 
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSComment = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDataMember = "APPurchaseOrderType";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSError = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldGroup = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldParent = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldRelation = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSPrivilege = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSSelectType = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.CurrentDisplayText = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.Location = new System.Drawing.Point(463, 88);
            this.fld_lkeAPPurchaseOrderTypeCombo.Name = "fld_lkeAPPurchaseOrderTypeCombo";
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.NullText = "";
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderTypeCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPurchaseOrderTypeCombo, true);
            this.fld_lkeAPPurchaseOrderTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseOrderTypeCombo.TabIndex = 15;
            this.fld_lkeAPPurchaseOrderTypeCombo.Tag = "DC";
            // 
            // fld_pteAPPurchaseOrderEmployeePicture
            // 
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSComment = "";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSDataMember = "APPurchaseOrderEmployeePicture";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSDataSource = "APPurchaseOrders";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSDescription = null;
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSError = null;
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSFieldGroup = "";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSFieldRelation = "";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSPrivilege = "";
            this.fld_pteAPPurchaseOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPPurchaseOrderEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPPurchaseOrderEmployeePicture.EditValue = "";
            this.fld_pteAPPurchaseOrderEmployeePicture.FileName = null;
            this.fld_pteAPPurchaseOrderEmployeePicture.FilePath = null;
            this.fld_pteAPPurchaseOrderEmployeePicture.Location = new System.Drawing.Point(9, 10);
            this.fld_pteAPPurchaseOrderEmployeePicture.Name = "fld_pteAPPurchaseOrderEmployeePicture";
            this.fld_pteAPPurchaseOrderEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPPurchaseOrderEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPPurchaseOrderEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPPurchaseOrderEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPPurchaseOrderEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPPurchaseOrderEmployeePicture.Screen = null;
            this.fld_pteAPPurchaseOrderEmployeePicture.Size = new System.Drawing.Size(100, 100);
            this.fld_pteAPPurchaseOrderEmployeePicture.TabIndex = 0;
            this.fld_pteAPPurchaseOrderEmployeePicture.Tag = "DC";
            // 
            // fld_lkeAPPurchaseOrderStatus
            // 
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseOrderStatus.BOSComment = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSDataMember = "APPurchaseOrderStatus";
            this.fld_lkeAPPurchaseOrderStatus.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderStatus.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSError = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldGroup = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldParent = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldRelation = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSPrivilege = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectType = "";
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectTypeValue = "";
            this.fld_lkeAPPurchaseOrderStatus.CurrentDisplayText = null;
            this.fld_lkeAPPurchaseOrderStatus.Location = new System.Drawing.Point(463, 114);
            this.fld_lkeAPPurchaseOrderStatus.Name = "fld_lkeAPPurchaseOrderStatus";
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderStatus.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseOrderStatus.Properties.NullText = "";
            this.fld_lkeAPPurchaseOrderStatus.Properties.ReadOnly = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderStatus.Screen = null;
            this.fld_lkeAPPurchaseOrderStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseOrderStatus.TabIndex = 19;
            this.fld_lkeAPPurchaseOrderStatus.Tag = "DC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(123, 14);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 607;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtAPPurchaseOrderExchangeRate
            // 
            this.fld_txtAPPurchaseOrderExchangeRate.BOSComment = "";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSDataMember = "APPurchaseOrderExchangeRate";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSDescription = null;
            this.fld_txtAPPurchaseOrderExchangeRate.BOSError = null;
            this.fld_txtAPPurchaseOrderExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderExchangeRate.EditValue = "";
            this.fld_txtAPPurchaseOrderExchangeRate.Location = new System.Drawing.Point(722, 140);
            this.fld_txtAPPurchaseOrderExchangeRate.Name = "fld_txtAPPurchaseOrderExchangeRate";
            this.fld_txtAPPurchaseOrderExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPPurchaseOrderExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderExchangeRate.Screen = null;
            this.fld_txtAPPurchaseOrderExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseOrderExchangeRate.TabIndex = 23;
            this.fld_txtAPPurchaseOrderExchangeRate.Tag = "DC";
            // 
            // fld_txtAPPurchaseOrderContractNo
            // 
            this.fld_txtAPPurchaseOrderContractNo.BOSComment = "";
            this.fld_txtAPPurchaseOrderContractNo.BOSDataMember = "APPurchaseOrderContractNo";
            this.fld_txtAPPurchaseOrderContractNo.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderContractNo.BOSDescription = null;
            this.fld_txtAPPurchaseOrderContractNo.BOSError = null;
            this.fld_txtAPPurchaseOrderContractNo.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderContractNo.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderContractNo.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderContractNo.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderContractNo.EditValue = "";
            this.fld_txtAPPurchaseOrderContractNo.Location = new System.Drawing.Point(995, 62);
            this.fld_txtAPPurchaseOrderContractNo.Name = "fld_txtAPPurchaseOrderContractNo";
            this.fld_txtAPPurchaseOrderContractNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPPurchaseOrderContractNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderContractNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderContractNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderContractNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderContractNo.Screen = null;
            this.fld_txtAPPurchaseOrderContractNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseOrderContractNo.TabIndex = 13;
            this.fld_txtAPPurchaseOrderContractNo.Tag = "DC";
            // 
            // fld_txtAPPurchaseOrderNo
            // 
            this.fld_txtAPPurchaseOrderNo.BOSComment = "";
            this.fld_txtAPPurchaseOrderNo.BOSDataMember = "APPurchaseOrderNo";
            this.fld_txtAPPurchaseOrderNo.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderNo.BOSDescription = null;
            this.fld_txtAPPurchaseOrderNo.BOSError = null;
            this.fld_txtAPPurchaseOrderNo.BOSFieldGroup = "";
            this.fld_txtAPPurchaseOrderNo.BOSFieldRelation = "";
            this.fld_txtAPPurchaseOrderNo.BOSPrivilege = "";
            this.fld_txtAPPurchaseOrderNo.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderNo.EditValue = "";
            this.fld_txtAPPurchaseOrderNo.Location = new System.Drawing.Point(208, 10);
            this.fld_txtAPPurchaseOrderNo.Name = "fld_txtAPPurchaseOrderNo";
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderNo.Screen = null;
            this.fld_txtAPPurchaseOrderNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseOrderNo.TabIndex = 2;
            this.fld_txtAPPurchaseOrderNo.Tag = "DC";
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(123, 66);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(67, 13);
            this.bosLabel3.TabIndex = 638;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại đơn hàng";
            // 
            // fld_lkeAPPurchaseOrderReceiptTypeCombo
            // 
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSComment = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSDataMember = "APPurchaseOrderReceiptTypeCombo";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSError = null;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSFieldGroup = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSFieldParent = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSFieldRelation = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSPrivilege = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSSelectType = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.CurrentDisplayText = null;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Location = new System.Drawing.Point(208, 62);
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Name = "fld_lkeAPPurchaseOrderReceiptTypeCombo";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.NullText = "";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Screen = null;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.TabIndex = 10;
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Tag = "DC";
            this.fld_lkeAPPurchaseOrderReceiptTypeCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPPurchaseOrderReceiptTypeCombo_CloseUp);
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(123, 40);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 610;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Nhà cung cấp";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(722, 114);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 20;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeAPPaymentMethodCombo
            // 
            this.fld_lkeAPPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentMethodCombo.BOSAllowDummy = false;
            this.fld_lkeAPPaymentMethodCombo.BOSComment = "";
            this.fld_lkeAPPaymentMethodCombo.BOSDataMember = "APPaymentMethodCombo";
            this.fld_lkeAPPaymentMethodCombo.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeAPPaymentMethodCombo.BOSError = null;
            this.fld_lkeAPPaymentMethodCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentMethodCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentMethodCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentMethodCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentMethodCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentMethodCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentMethodCombo.CurrentDisplayText = null;
            this.fld_lkeAPPaymentMethodCombo.Location = new System.Drawing.Point(208, 88);
            this.fld_lkeAPPaymentMethodCombo.Name = "fld_lkeAPPaymentMethodCombo";
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentMethodCombo.Screen = null;
            this.fld_lkeAPPaymentMethodCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentMethodCombo.TabIndex = 14;
            this.fld_lkeAPPaymentMethodCombo.Tag = "DC";
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
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(890, 66);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(60, 13);
            this.bosLabel8.TabIndex = 620;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Số hợp đồng";
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
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(634, 144);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 618;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tỷ giá";
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
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(634, 118);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(53, 13);
            this.bosLabel5.TabIndex = 617;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(123, 92);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(77, 13);
            this.fld_lblLabel3.TabIndex = 616;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Phương thức TT";
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
            this.bosLabel9.BOSPropertyName = "";
            this.bosLabel9.Location = new System.Drawing.Point(890, 144);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(73, 13);
            this.bosLabel9.TabIndex = 632;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Ngày hợp đồng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(890, 168);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(79, 13);
            this.bosLabel2.TabIndex = 631;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Ngày đóng hàng";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(378, 40);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel6.TabIndex = 630;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Ngày giao";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(378, 118);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel4.TabIndex = 623;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Tình trạng";
            // 
            // fld_dteAPPurchaseOrderContractDate
            // 
            this.fld_dteAPPurchaseOrderContractDate.BOSComment = "";
            this.fld_dteAPPurchaseOrderContractDate.BOSDataMember = "APPurchaseOrderContractDate";
            this.fld_dteAPPurchaseOrderContractDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteAPPurchaseOrderContractDate.BOSDescription = null;
            this.fld_dteAPPurchaseOrderContractDate.BOSError = null;
            this.fld_dteAPPurchaseOrderContractDate.BOSFieldGroup = "";
            this.fld_dteAPPurchaseOrderContractDate.BOSFieldRelation = "";
            this.fld_dteAPPurchaseOrderContractDate.BOSPrivilege = "";
            this.fld_dteAPPurchaseOrderContractDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseOrderContractDate.EditValue = null;
            this.fld_dteAPPurchaseOrderContractDate.Location = new System.Drawing.Point(995, 140);
            this.fld_dteAPPurchaseOrderContractDate.Name = "fld_dteAPPurchaseOrderContractDate";
            this.fld_dteAPPurchaseOrderContractDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseOrderContractDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseOrderContractDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseOrderContractDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseOrderContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseOrderContractDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseOrderContractDate.Screen = null;
            this.fld_dteAPPurchaseOrderContractDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseOrderContractDate.TabIndex = 24;
            this.fld_dteAPPurchaseOrderContractDate.Tag = "DC";
            this.fld_dteAPPurchaseOrderContractDate.Validated += new System.EventHandler(this.bosDateEdit2_Validated);
            // 
            // fld_dteAPPurchaseOrderPackingDate
            // 
            this.fld_dteAPPurchaseOrderPackingDate.BOSComment = "";
            this.fld_dteAPPurchaseOrderPackingDate.BOSDataMember = "APPurchaseOrderPackingDate";
            this.fld_dteAPPurchaseOrderPackingDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteAPPurchaseOrderPackingDate.BOSDescription = null;
            this.fld_dteAPPurchaseOrderPackingDate.BOSError = null;
            this.fld_dteAPPurchaseOrderPackingDate.BOSFieldGroup = "";
            this.fld_dteAPPurchaseOrderPackingDate.BOSFieldRelation = "";
            this.fld_dteAPPurchaseOrderPackingDate.BOSPrivilege = "";
            this.fld_dteAPPurchaseOrderPackingDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseOrderPackingDate.EditValue = null;
            this.fld_dteAPPurchaseOrderPackingDate.Location = new System.Drawing.Point(995, 166);
            this.fld_dteAPPurchaseOrderPackingDate.Name = "fld_dteAPPurchaseOrderPackingDate";
            this.fld_dteAPPurchaseOrderPackingDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseOrderPackingDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseOrderPackingDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseOrderPackingDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseOrderPackingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseOrderPackingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseOrderPackingDate.Screen = null;
            this.fld_dteAPPurchaseOrderPackingDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseOrderPackingDate.TabIndex = 26;
            this.fld_dteAPPurchaseOrderPackingDate.Tag = "DC";
            // 
            // fld_dteAPPurchaseOrderDeliveryDate
            // 
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSComment = "";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSDataMember = "APPurchaseOrderDeliveryDate";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSDescription = null;
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSError = null;
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSFieldGroup = "";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSFieldRelation = "";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSPrivilege = "";
            this.fld_dteAPPurchaseOrderDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseOrderDeliveryDate.EditValue = null;
            this.fld_dteAPPurchaseOrderDeliveryDate.Location = new System.Drawing.Point(463, 36);
            this.fld_dteAPPurchaseOrderDeliveryDate.Name = "fld_dteAPPurchaseOrderDeliveryDate";
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseOrderDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseOrderDeliveryDate.Screen = null;
            this.fld_dteAPPurchaseOrderDeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseOrderDeliveryDate.TabIndex = 7;
            this.fld_dteAPPurchaseOrderDeliveryDate.Tag = "DC";
            this.fld_dteAPPurchaseOrderDeliveryDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dteAPPurchaseOrderDeliveryDate_CloseUp);
            this.fld_dteAPPurchaseOrderDeliveryDate.Validated += new System.EventHandler(this.fld_dteAPPurchaseOrderDeliveryDate_Validated);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(378, 14);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 628;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày chứng từ";
            // 
            // fld_dteAPPurchaseOrdeDate
            // 
            this.fld_dteAPPurchaseOrdeDate.BOSComment = "";
            this.fld_dteAPPurchaseOrdeDate.BOSDataMember = "APPurchaseOrderDate";
            this.fld_dteAPPurchaseOrdeDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteAPPurchaseOrdeDate.BOSDescription = null;
            this.fld_dteAPPurchaseOrdeDate.BOSError = null;
            this.fld_dteAPPurchaseOrdeDate.BOSFieldGroup = "";
            this.fld_dteAPPurchaseOrdeDate.BOSFieldRelation = "";
            this.fld_dteAPPurchaseOrdeDate.BOSPrivilege = "";
            this.fld_dteAPPurchaseOrdeDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseOrdeDate.EditValue = null;
            this.fld_dteAPPurchaseOrdeDate.Location = new System.Drawing.Point(463, 10);
            this.fld_dteAPPurchaseOrdeDate.Name = "fld_dteAPPurchaseOrdeDate";
            this.fld_dteAPPurchaseOrdeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseOrdeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseOrdeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseOrdeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseOrdeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseOrdeDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseOrdeDate.Screen = null;
            this.fld_dteAPPurchaseOrdeDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseOrdeDate.TabIndex = 3;
            this.fld_dteAPPurchaseOrdeDate.Tag = "DC";
            this.fld_dteAPPurchaseOrdeDate.Validated += new System.EventHandler(this.fld_dteAPPurchaseOrdeDate_Validated);
            // 
            // fld_tclModuleObjects
            // 
            this.fld_tclModuleObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tclModuleObjects.BOSComment = null;
            this.fld_tclModuleObjects.BOSDataMember = null;
            this.fld_tclModuleObjects.BOSDataSource = null;
            this.fld_tclModuleObjects.BOSDescription = null;
            this.fld_tclModuleObjects.BOSError = null;
            this.fld_tclModuleObjects.BOSFieldGroup = null;
            this.fld_tclModuleObjects.BOSFieldRelation = null;
            this.fld_tclModuleObjects.BOSPrivilege = null;
            this.fld_tclModuleObjects.BOSPropertyName = null;
            this.fld_tclModuleObjects.Location = new System.Drawing.Point(6, 244);
            this.fld_tclModuleObjects.Name = "fld_tclModuleObjects";
            this.fld_tclModuleObjects.Screen = null;
            this.fld_tclModuleObjects.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.fld_tclModuleObjects, true);
            this.fld_tclModuleObjects.Size = new System.Drawing.Size(1543, 610);
            this.fld_tclModuleObjects.TabIndex = 603;
            this.fld_tclModuleObjects.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.fld_tabOutsourcingProduct,
            this.xtraTabPage3,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnUpdateInventoryStock);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.xtraTabPage1.Controls.Add(this.fld_btnShowProposalItems);
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel8);
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPPurchaseOrderItems);
            this.xtraTabPage1.Controls.Add(this.fld_pteAPPurchaseOrderItemProductPicture);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(1541, 585);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_btnUpdateInventoryStock
            // 
            this.fld_btnUpdateInventoryStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdateInventoryStock.BOSComment = null;
            this.fld_btnUpdateInventoryStock.BOSDataMember = null;
            this.fld_btnUpdateInventoryStock.BOSDataSource = null;
            this.fld_btnUpdateInventoryStock.BOSDescription = null;
            this.fld_btnUpdateInventoryStock.BOSError = null;
            this.fld_btnUpdateInventoryStock.BOSFieldGroup = null;
            this.fld_btnUpdateInventoryStock.BOSFieldRelation = null;
            this.fld_btnUpdateInventoryStock.BOSPrivilege = null;
            this.fld_btnUpdateInventoryStock.BOSPropertyName = null;
            this.fld_btnUpdateInventoryStock.Location = new System.Drawing.Point(1417, 6);
            this.fld_btnUpdateInventoryStock.Name = "fld_btnUpdateInventoryStock";
            this.fld_btnUpdateInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateInventoryStock, true);
            this.fld_btnUpdateInventoryStock.Size = new System.Drawing.Size(121, 22);
            this.fld_btnUpdateInventoryStock.TabIndex = 55;
            this.fld_btnUpdateInventoryStock.Text = "Xem tồn kho";
            this.fld_btnUpdateInventoryStock.Click += new System.EventHandler(this.fld_btnUpdateInventoryStock_Click);
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "APPurchaseOrderItems";
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
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(66, 6);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(1345, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_btnShowProposalItems
            // 
            this.fld_btnShowProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnShowProposalItems.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowProposalItems.Appearance.Options.UseForeColor = true;
            this.fld_btnShowProposalItems.BOSComment = "";
            this.fld_btnShowProposalItems.BOSDataMember = "";
            this.fld_btnShowProposalItems.BOSDataSource = "";
            this.fld_btnShowProposalItems.BOSDescription = null;
            this.fld_btnShowProposalItems.BOSError = null;
            this.fld_btnShowProposalItems.BOSFieldGroup = "";
            this.fld_btnShowProposalItems.BOSFieldRelation = "";
            this.fld_btnShowProposalItems.BOSPrivilege = "";
            this.fld_btnShowProposalItems.BOSPropertyName = "";
            this.fld_btnShowProposalItems.Location = new System.Drawing.Point(1417, 160);
            this.fld_btnShowProposalItems.Name = "fld_btnShowProposalItems";
            this.fld_btnShowProposalItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowProposalItems, true);
            this.fld_btnShowProposalItems.Size = new System.Drawing.Size(121, 20);
            this.fld_btnShowProposalItems.TabIndex = 2;
            this.fld_btnShowProposalItems.Tag = "";
            this.fld_btnShowProposalItems.Text = "Thêm từ đề nghị";
            this.fld_btnShowProposalItems.Visible = false;
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(11, 10);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel8.TabIndex = 54;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Sản phẩm";
            // 
            // fld_dgcAPPurchaseOrderItems
            // 
            this.fld_dgcAPPurchaseOrderItems.AllowDrop = true;
            this.fld_dgcAPPurchaseOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPurchaseOrderItems.BOSComment = "";
            this.fld_dgcAPPurchaseOrderItems.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrderItems.BOSDataSource = "APPurchaseOrderItems";
            this.fld_dgcAPPurchaseOrderItems.BOSDescription = null;
            this.fld_dgcAPPurchaseOrderItems.BOSError = null;
            this.fld_dgcAPPurchaseOrderItems.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrderItems.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrderItems.BOSGridType = null;
            this.fld_dgcAPPurchaseOrderItems.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrderItems.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrderItems.CommodityType = "";
            this.fld_dgcAPPurchaseOrderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrderItems.Location = new System.Drawing.Point(4, 32);
            this.fld_dgcAPPurchaseOrderItems.MainView = this.fld_dgvAPPurchaseOrderItems;
            this.fld_dgcAPPurchaseOrderItems.Name = "fld_dgcAPPurchaseOrderItems";
            this.fld_dgcAPPurchaseOrderItems.PrintReport = false;
            this.fld_dgcAPPurchaseOrderItems.Screen = null;
            this.fld_dgcAPPurchaseOrderItems.Size = new System.Drawing.Size(1407, 548);
            this.fld_dgcAPPurchaseOrderItems.TabIndex = 1;
            this.fld_dgcAPPurchaseOrderItems.Tag = "DC";
            this.fld_dgcAPPurchaseOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrderItems});
            // 
            // fld_dgvAPPurchaseOrderItems
            // 
            this.fld_dgvAPPurchaseOrderItems.GridControl = this.fld_dgcAPPurchaseOrderItems;
            this.fld_dgvAPPurchaseOrderItems.Name = "fld_dgvAPPurchaseOrderItems";
            this.fld_dgvAPPurchaseOrderItems.PaintStyleName = "Office2003";
            // 
            // fld_pteAPPurchaseOrderItemProductPicture
            // 
            this.fld_pteAPPurchaseOrderItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSComment = "";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSDataMember = "APPurchaseOrderItemProductPicture";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSDataSource = "APPurchaseOrderItems";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSDescription = null;
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSError = null;
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSFieldGroup = "";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSFieldRelation = "";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSPrivilege = "";
            this.fld_pteAPPurchaseOrderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPPurchaseOrderItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPPurchaseOrderItemProductPicture.EditValue = "";
            this.fld_pteAPPurchaseOrderItemProductPicture.FileName = null;
            this.fld_pteAPPurchaseOrderItemProductPicture.FilePath = null;
            this.fld_pteAPPurchaseOrderItemProductPicture.Location = new System.Drawing.Point(1417, 34);
            this.fld_pteAPPurchaseOrderItemProductPicture.Name = "fld_pteAPPurchaseOrderItemProductPicture";
            this.fld_pteAPPurchaseOrderItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPPurchaseOrderItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPPurchaseOrderItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPPurchaseOrderItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPPurchaseOrderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPPurchaseOrderItemProductPicture.Screen = null;
            this.fld_pteAPPurchaseOrderItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteAPPurchaseOrderItemProductPicture.TabIndex = 3;
            this.fld_pteAPPurchaseOrderItemProductPicture.Tag = "DC";
            // 
            // fld_tabOutsourcingProduct
            // 
            this.fld_tabOutsourcingProduct.Controls.Add(this.fld_btnAddMoreMaterial);
            this.fld_tabOutsourcingProduct.Controls.Add(this.bosPictureEdit1);
            this.fld_tabOutsourcingProduct.Controls.Add(this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl);
            this.fld_tabOutsourcingProduct.Controls.Add(this.fld_btnAddMaterial);
            this.fld_tabOutsourcingProduct.Controls.Add(this.fld_btnAddSemiProduct);
            this.fld_tabOutsourcingProduct.Name = "fld_tabOutsourcingProduct";
            this.fld_tabOutsourcingProduct.PageVisible = false;
            this.fld_tabOutsourcingProduct.Size = new System.Drawing.Size(1527, 578);
            this.fld_tabOutsourcingProduct.Text = "Danh sách nguyên liệu gia công";
            // 
            // fld_btnAddMoreMaterial
            // 
            this.fld_btnAddMoreMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddMoreMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnAddMoreMaterial.BOSComment = "";
            this.fld_btnAddMoreMaterial.BOSDataMember = "";
            this.fld_btnAddMoreMaterial.BOSDataSource = "";
            this.fld_btnAddMoreMaterial.BOSDescription = null;
            this.fld_btnAddMoreMaterial.BOSError = null;
            this.fld_btnAddMoreMaterial.BOSFieldGroup = "";
            this.fld_btnAddMoreMaterial.BOSFieldRelation = "";
            this.fld_btnAddMoreMaterial.BOSPrivilege = "";
            this.fld_btnAddMoreMaterial.BOSPropertyName = "";
            this.fld_btnAddMoreMaterial.Location = new System.Drawing.Point(225, 5);
            this.fld_btnAddMoreMaterial.Name = "fld_btnAddMoreMaterial";
            this.fld_btnAddMoreMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddMoreMaterial, true);
            this.fld_btnAddMoreMaterial.Size = new System.Drawing.Size(132, 25);
            this.fld_btnAddMoreMaterial.TabIndex = 8;
            this.fld_btnAddMoreMaterial.Tag = "";
            this.fld_btnAddMoreMaterial.Text = "Thêm vật tư ngoài LSX";
            this.fld_btnAddMoreMaterial.Click += new System.EventHandler(this.fld_btnAddMoreMaterial_Click);
            // 
            // bosPictureEdit1
            // 
            this.bosPictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPictureEdit1.BOSComment = "";
            this.bosPictureEdit1.BOSDataMember = "APPurchaseOrderItemProductPicture";
            this.bosPictureEdit1.BOSDataSource = "APPurchaseOrderItems";
            this.bosPictureEdit1.BOSDescription = null;
            this.bosPictureEdit1.BOSError = null;
            this.bosPictureEdit1.BOSFieldGroup = "";
            this.bosPictureEdit1.BOSFieldRelation = "";
            this.bosPictureEdit1.BOSPrivilege = "";
            this.bosPictureEdit1.BOSPropertyName = "EditValue";
            this.bosPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit1.EditValue = "";
            this.bosPictureEdit1.FileName = null;
            this.bosPictureEdit1.FilePath = null;
            this.bosPictureEdit1.Location = new System.Drawing.Point(1402, 36);
            this.bosPictureEdit1.Name = "bosPictureEdit1";
            this.bosPictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosPictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosPictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit1.Screen = null;
            this.bosPictureEdit1.Size = new System.Drawing.Size(120, 120);
            this.bosPictureEdit1.TabIndex = 6;
            this.bosPictureEdit1.Tag = "DC";
            // 
            // fld_dgcAPPurchaseOrderItemOutSourcingsGridControl
            // 
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.AllowDrop = true;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSComment = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSDataSource = "APPurchaseOrderItemOutSourcings";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSDescription = null;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSError = null;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSGridType = null;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.CommodityType = "";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.MainView = this.gridView2;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Name = "fld_dgcAPPurchaseOrderItemOutSourcingsGridControl";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.PrintReport = false;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Screen = null;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Size = new System.Drawing.Size(1391, 536);
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.TabIndex = 5;
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.Tag = "DC";
            this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_btnAddMaterial
            // 
            this.fld_btnAddMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnAddMaterial.BOSComment = "";
            this.fld_btnAddMaterial.BOSDataMember = "";
            this.fld_btnAddMaterial.BOSDataSource = "";
            this.fld_btnAddMaterial.BOSDescription = null;
            this.fld_btnAddMaterial.BOSError = null;
            this.fld_btnAddMaterial.BOSFieldGroup = "";
            this.fld_btnAddMaterial.BOSFieldRelation = "";
            this.fld_btnAddMaterial.BOSPrivilege = "";
            this.fld_btnAddMaterial.BOSPropertyName = "";
            this.fld_btnAddMaterial.Location = new System.Drawing.Point(115, 5);
            this.fld_btnAddMaterial.Name = "fld_btnAddMaterial";
            this.fld_btnAddMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddMaterial, true);
            this.fld_btnAddMaterial.Size = new System.Drawing.Size(104, 25);
            this.fld_btnAddMaterial.TabIndex = 4;
            this.fld_btnAddMaterial.Tag = "";
            this.fld_btnAddMaterial.Text = "Thêm nguyên liệu";
            this.fld_btnAddMaterial.Click += new System.EventHandler(this.fld_btnAddMaterial_Click);
            // 
            // fld_btnAddSemiProduct
            // 
            this.fld_btnAddSemiProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddSemiProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddSemiProduct.BOSComment = "";
            this.fld_btnAddSemiProduct.BOSDataMember = "";
            this.fld_btnAddSemiProduct.BOSDataSource = "";
            this.fld_btnAddSemiProduct.BOSDescription = null;
            this.fld_btnAddSemiProduct.BOSError = null;
            this.fld_btnAddSemiProduct.BOSFieldGroup = "";
            this.fld_btnAddSemiProduct.BOSFieldRelation = "";
            this.fld_btnAddSemiProduct.BOSPrivilege = "";
            this.fld_btnAddSemiProduct.BOSPropertyName = "";
            this.fld_btnAddSemiProduct.Location = new System.Drawing.Point(5, 5);
            this.fld_btnAddSemiProduct.Name = "fld_btnAddSemiProduct";
            this.fld_btnAddSemiProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddSemiProduct, true);
            this.fld_btnAddSemiProduct.Size = new System.Drawing.Size(104, 25);
            this.fld_btnAddSemiProduct.TabIndex = 3;
            this.fld_btnAddSemiProduct.Tag = "";
            this.fld_btnAddSemiProduct.Text = "Thêm BTP";
            this.fld_btnAddSemiProduct.Click += new System.EventHandler(this.fld_btnAddSemiProduct_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcAPPurchaseOrderPaymentTimes);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(1527, 578);
            this.xtraTabPage3.Text = "Danh sách đợt thanh toán";
            // 
            // fld_dgcAPPurchaseOrderPaymentTimes
            // 
            this.fld_dgcAPPurchaseOrderPaymentTimes.AllowDrop = true;
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSComment = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSDataSource = "APPurchaseOrderPaymentTimes";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSDescription = "APPurchaseOrderPaymentTimes";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSError = null;
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSGridType = null;
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.CommodityType = "";
            this.fld_dgcAPPurchaseOrderPaymentTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPPurchaseOrderPaymentTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrderPaymentTimes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPPurchaseOrderPaymentTimes.MainView = this.gridView1;
            this.fld_dgcAPPurchaseOrderPaymentTimes.Name = "fld_dgcAPPurchaseOrderPaymentTimes";
            this.fld_dgcAPPurchaseOrderPaymentTimes.PrintReport = false;
            this.fld_dgcAPPurchaseOrderPaymentTimes.Screen = null;
            this.fld_dgcAPPurchaseOrderPaymentTimes.Size = new System.Drawing.Size(1527, 578);
            this.fld_dgcAPPurchaseOrderPaymentTimes.TabIndex = 11;
            this.fld_dgcAPPurchaseOrderPaymentTimes.Tag = "DC";
            this.fld_dgcAPPurchaseOrderPaymentTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPPurchaseOrderPaymentTimes;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnSaveDelivery);
            this.xtraTabPage2.Controls.Add(this.fld_dgcAPPurchaseOrderItemDeliverys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1527, 578);
            this.xtraTabPage2.Text = "Nhập đợt hàng về";
            // 
            // fld_btnSaveDelivery
            // 
            this.fld_btnSaveDelivery.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnSaveDelivery.Appearance.Options.UseForeColor = true;
            this.fld_btnSaveDelivery.BOSComment = "";
            this.fld_btnSaveDelivery.BOSDataMember = "";
            this.fld_btnSaveDelivery.BOSDataSource = "";
            this.fld_btnSaveDelivery.BOSDescription = null;
            this.fld_btnSaveDelivery.BOSError = null;
            this.fld_btnSaveDelivery.BOSFieldGroup = "";
            this.fld_btnSaveDelivery.BOSFieldRelation = "";
            this.fld_btnSaveDelivery.BOSPrivilege = "";
            this.fld_btnSaveDelivery.BOSPropertyName = "";
            this.fld_btnSaveDelivery.Location = new System.Drawing.Point(5, 6);
            this.fld_btnSaveDelivery.Name = "fld_btnSaveDelivery";
            this.fld_btnSaveDelivery.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveDelivery, true);
            this.fld_btnSaveDelivery.Size = new System.Drawing.Size(104, 25);
            this.fld_btnSaveDelivery.TabIndex = 13;
            this.fld_btnSaveDelivery.Tag = "";
            this.fld_btnSaveDelivery.Text = "Lưu";
            this.fld_btnSaveDelivery.Click += new System.EventHandler(this.fld_btnSaveDelivery_Click);
            // 
            // fld_dgcAPPurchaseOrderItemDeliverys
            // 
            this.fld_dgcAPPurchaseOrderItemDeliverys.AllowDrop = true;
            this.fld_dgcAPPurchaseOrderItemDeliverys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSComment = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSDataSource = "APPurchaseOrderItemDeliverys";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSDescription = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSError = null;
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSGridType = null;
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.CommodityType = "";
            this.fld_dgcAPPurchaseOrderItemDeliverys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrderItemDeliverys.Location = new System.Drawing.Point(5, 37);
            this.fld_dgcAPPurchaseOrderItemDeliverys.MainView = this.gridView3;
            this.fld_dgcAPPurchaseOrderItemDeliverys.Name = "fld_dgcAPPurchaseOrderItemDeliverys";
            this.fld_dgcAPPurchaseOrderItemDeliverys.PrintReport = false;
            this.fld_dgcAPPurchaseOrderItemDeliverys.Screen = null;
            this.fld_dgcAPPurchaseOrderItemDeliverys.Size = new System.Drawing.Size(1519, 538);
            this.fld_dgcAPPurchaseOrderItemDeliverys.TabIndex = 12;
            this.fld_dgcAPPurchaseOrderItemDeliverys.Tag = "DC";
            this.fld_dgcAPPurchaseOrderItemDeliverys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcAPPurchaseOrderItemDeliverys;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medAPPurchaseOrderComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 863);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(322, 170);
            this.bosLine1.TabIndex = 32;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_dgvAPPurchaseOrderPaymentTimes
            // 
            this.fld_dgvAPPurchaseOrderPaymentTimes.Name = "fld_dgvAPPurchaseOrderPaymentTimes";
            this.fld_dgvAPPurchaseOrderPaymentTimes.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APPurchaseOrders";
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(9, 116);
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 659;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
            // 
            // DMPO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1556, 1043);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPO100.IconOptions.Icon")));
            this.Name = "DMPO100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPurchaseOrderComment.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            this.fld_Line3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderShippingFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderShippingExtraFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPurchaseOrderSubTotalCost.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchasingStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPurchaseOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPurchaseOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderReceiptTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderContractDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderPackingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderPackingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrdeDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrdeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclModuleObjects)).EndInit();
            this.fld_tclModuleObjects.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPurchaseOrderItemProductPicture.Properties)).EndInit();
            this.fld_tabOutsourcingProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItemOutSourcingsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrderItemDeliverys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSMemoEdit fld_medAPPurchaseOrderComment;
        private BOSComponent.BOSLine fld_Line3;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLine fld_Line2;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSButton fld_btnShippingInfo;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderShippingFees;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderShippingExtraFees;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderTaxPercent;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderTotalCost;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderDiscountFix;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderTaxAmount;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSTextBox fld_txtARPurchaseOrderSubTotalCost;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderPaymentTimes;
        private BOSComponent.BOSTabControl fld_tclModuleObjects;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSComponent.BOSButton fld_btnShowProposalItems;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private APPurchaseOrderItemsGridControl fld_dgcAPPurchaseOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderItems;
        private BOSComponent.BOSPictureEdit fld_pteAPPurchaseOrderItemProductPicture;
        private DevExpress.XtraTab.XtraTabPage fld_tabOutsourcingProduct;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private APPurchaseOrderItemOutSourcingsGridControl fld_dgcAPPurchaseOrderItemOutSourcingsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddMaterial;
        private BOSComponent.BOSButton fld_btnAddSemiProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private APPurchaseOrderPaymentTimesGridControl fld_dgcAPPurchaseOrderPaymentTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchasingStaffID;
        private AccObjectLookupEdit accObjectLookupEdit1;
        private BOSComponent.BOSLabel bosLabel18;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSMemoEdit fld_medAPPurchaseOrderDesc;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderTypeCombo;
        private BOSComponent.BOSPictureEdit fld_pteAPPurchaseOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderStatus;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderExchangeRate;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderReceiptTypeCombo;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentMethodCombo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseOrderContractDate;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseOrderPackingDate;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseOrderDeliveryDate;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseOrdeDate;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSButton fld_btnAddMoreMaterial;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnSaveDelivery;
        private APPurchaseOrderItemDeliverysGridControl fld_dgcAPPurchaseOrderItemDeliverys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLookupEdit fld_dteFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit bosLookupEdit6;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderContractNo;
        private DevExpress.XtraEditors.HyperlinkLabelControl fld_linkViewApproval;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderProject;
        private BOSComponent.BOSButton fld_btnUpdateInventoryStock;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
    }
}
