using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvoiceIn.UI
{
	/// <summary>
	/// Summary description for DMII100
	/// </summary>
	partial class DMII100
    {
        private BOSComponent.BOSLabel fld_Lablel2;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSMemoEdit fld_medAPInvoiceInDesc;
		private BOSComponent.BOSLabel fld_Lablel1;
		private BOSComponent.BOSLabel fld_Lablel4;
		private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSTextBox fld_txtAPInvoiceInSubTotalCost;
		private BOSComponent.BOSTextBox fld_txtAPInvoiceInTotalCost;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInShippingFees;
		private BOSComponent.BOSTextBox fld_txtAPInvoiceInDiscountFix;
		private BOSComponent.BOSTextBox fld_txtAPInvoiceInDiscountPercent;
		private BOSComponent.BOSButton fld_btnEditShippingInfo;
        private BOSComponent.BOSLabel fld_lblLabel29;
		private BOSComponent.BOSLabel fld_lblDeliveryAddressLine2;
		private BOSComponent.BOSLabel fld_lblLabel37;
		private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel36;
		private BOSComponent.BOSLabel fld_lblInvoiceAddressLine2;
		private BOSComponent.BOSLabel fld_lblLabel30;
		private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSLabel bosLabel4;
		private BOSComponent.BOSLabel bosLabel1;
		private BOSComponent.BOSLabel bosLabel5;
		private BOSComponent.BOSTextBox fld_txtAPInvoiceInShippingExtraFees;
		private BOSComponent.BOSDateEdit fld_dteAPInvoiceInValidateDate;
        private BOSComponent.BOSLabel bosLabel7;
		private BOSComponent.BOSLine fld_Line2;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInNo1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMII100));
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPInvoiceInDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInShippingFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnEditShippingInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblDeliveryAddressLine2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblInvoiceAddressLine2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInShippingExtraFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteAPInvoiceInValidateDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_txtAPInvoiceInNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteAPInvoiceInEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPInvoiceInStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_txtAPInvoiceInProject = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GETerminalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInContractNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInChannel = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInSupplierTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPInvoiceInContractDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInBillOfLanding = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInPackingList = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInTotalQuantity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInRoundWoodQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInPackNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInLogListNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARInvoiceVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medAPInvoiceInComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabInvoiceInItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceInItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPInvoiceInItems = new BOSERP.Modules.InvoiceIn.APInvoiceInItemsGridControl();
            this.fld_dgvARInvoiceIns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_pteAPInvoiceInItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPInvoiceInDepositBalance = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPInvoiceInDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInShippingFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInShippingExtraFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInValidateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInValidateDate.Properties)).BeginInit();
            this.fld_Line2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTaxAmount.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInChannel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInContractDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInBillOfLanding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInPackingList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTotalQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInRoundWoodQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInLogListNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPInvoiceInComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).BeginInit();
            this.fld_tabInvoiceInItems.SuspendLayout();
            this.fld_tabPageInvoiceInItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInItemProductPicture.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDepositBalance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_Lablel2.BOSPropertyName = "";
            this.fld_Lablel2.Location = new System.Drawing.Point(631, 46);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 13;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(5, 99);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel7.TabIndex = 7;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Đối tượng";
            // 
            // fld_medAPInvoiceInDesc
            // 
            this.fld_medAPInvoiceInDesc.BOSComment = "";
            this.fld_medAPInvoiceInDesc.BOSDataMember = "APInvoiceInDesc";
            this.fld_medAPInvoiceInDesc.BOSDataSource = "APInvoiceIns";
            this.fld_medAPInvoiceInDesc.BOSDescription = null;
            this.fld_medAPInvoiceInDesc.BOSError = null;
            this.fld_medAPInvoiceInDesc.BOSFieldGroup = "";
            this.fld_medAPInvoiceInDesc.BOSFieldRelation = "";
            this.fld_medAPInvoiceInDesc.BOSPrivilege = "";
            this.fld_medAPInvoiceInDesc.BOSPropertyName = "Text";
            this.fld_medAPInvoiceInDesc.EditValue = "";
            this.fld_medAPInvoiceInDesc.Location = new System.Drawing.Point(305, 147);
            this.fld_medAPInvoiceInDesc.Name = "fld_medAPInvoiceInDesc";
            this.fld_medAPInvoiceInDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPInvoiceInDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPInvoiceInDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPInvoiceInDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPInvoiceInDesc.Screen = null;
            this.fld_medAPInvoiceInDesc.Size = new System.Drawing.Size(313, 46);
            this.fld_medAPInvoiceInDesc.TabIndex = 21;
            this.fld_medAPInvoiceInDesc.Tag = "DC";
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = "";
            this.fld_Lablel1.BOSDataMember = "";
            this.fld_Lablel1.BOSDataSource = "";
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = "";
            this.fld_Lablel1.BOSFieldRelation = "";
            this.fld_Lablel1.BOSPrivilege = "";
            this.fld_Lablel1.BOSPropertyName = "";
            this.fld_Lablel1.Location = new System.Drawing.Point(955, 530);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(50, 13);
            this.fld_Lablel1.TabIndex = 25;
            this.fld_Lablel1.Tag = "";
            this.fld_Lablel1.Text = "Tổng cộng";
            // 
            // fld_Lablel4
            // 
            this.fld_Lablel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Lablel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.Options.UseBackColor = true;
            this.fld_Lablel4.Appearance.Options.UseForeColor = true;
            this.fld_Lablel4.BOSComment = "";
            this.fld_Lablel4.BOSDataMember = "";
            this.fld_Lablel4.BOSDataSource = "";
            this.fld_Lablel4.BOSDescription = null;
            this.fld_Lablel4.BOSError = null;
            this.fld_Lablel4.BOSFieldGroup = "";
            this.fld_Lablel4.BOSFieldRelation = "";
            this.fld_Lablel4.BOSPrivilege = "";
            this.fld_Lablel4.BOSPropertyName = "";
            this.fld_Lablel4.Location = new System.Drawing.Point(955, 608);
            this.fld_Lablel4.Name = "fld_Lablel4";
            this.fld_Lablel4.Screen = null;
            this.fld_Lablel4.Size = new System.Drawing.Size(76, 13);
            this.fld_Lablel4.TabIndex = 32;
            this.fld_Lablel4.Tag = "";
            this.fld_Lablel4.Text = "Tăng/Giảm khác";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(955, 657);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(92, 17);
            this.fld_lblLabel16.TabIndex = 37;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "THÀNH TIỀN";
            // 
            // fld_txtAPInvoiceInSubTotalCost
            // 
            this.fld_txtAPInvoiceInSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInSubTotalCost.BOSComment = "";
            this.fld_txtAPInvoiceInSubTotalCost.BOSDataMember = "APInvoiceInSubTotalCost";
            this.fld_txtAPInvoiceInSubTotalCost.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInSubTotalCost.BOSDescription = null;
            this.fld_txtAPInvoiceInSubTotalCost.BOSError = null;
            this.fld_txtAPInvoiceInSubTotalCost.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInSubTotalCost.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInSubTotalCost.BOSPrivilege = "";
            this.fld_txtAPInvoiceInSubTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInSubTotalCost.EditValue = "";
            this.fld_txtAPInvoiceInSubTotalCost.Location = new System.Drawing.Point(1053, 527);
            this.fld_txtAPInvoiceInSubTotalCost.Name = "fld_txtAPInvoiceInSubTotalCost";
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPInvoiceInSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtAPInvoiceInSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInSubTotalCost.Screen = null;
            this.fld_txtAPInvoiceInSubTotalCost.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInSubTotalCost.TabIndex = 5;
            this.fld_txtAPInvoiceInSubTotalCost.Tag = "DC";
            // 
            // fld_txtAPInvoiceInTotalCost
            // 
            this.fld_txtAPInvoiceInTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInTotalCost.BOSComment = "";
            this.fld_txtAPInvoiceInTotalCost.BOSDataMember = "APInvoiceInTotalCost";
            this.fld_txtAPInvoiceInTotalCost.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInTotalCost.BOSDescription = null;
            this.fld_txtAPInvoiceInTotalCost.BOSError = null;
            this.fld_txtAPInvoiceInTotalCost.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInTotalCost.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInTotalCost.BOSPrivilege = "";
            this.fld_txtAPInvoiceInTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInTotalCost.EditValue = "";
            this.fld_txtAPInvoiceInTotalCost.Location = new System.Drawing.Point(1053, 656);
            this.fld_txtAPInvoiceInTotalCost.Name = "fld_txtAPInvoiceInTotalCost";
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPInvoiceInTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtAPInvoiceInTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPInvoiceInTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInTotalCost.Properties.ReadOnly = true;
            this.fld_txtAPInvoiceInTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInTotalCost.Screen = null;
            this.fld_txtAPInvoiceInTotalCost.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInTotalCost.TabIndex = 12;
            this.fld_txtAPInvoiceInTotalCost.Tag = "DC";
            // 
            // fld_txtAPInvoiceInShippingFees
            // 
            this.fld_txtAPInvoiceInShippingFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInShippingFees.BOSComment = "";
            this.fld_txtAPInvoiceInShippingFees.BOSDataMember = "APInvoiceInShippingFees";
            this.fld_txtAPInvoiceInShippingFees.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInShippingFees.BOSDescription = null;
            this.fld_txtAPInvoiceInShippingFees.BOSError = null;
            this.fld_txtAPInvoiceInShippingFees.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInShippingFees.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInShippingFees.BOSPrivilege = "";
            this.fld_txtAPInvoiceInShippingFees.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInShippingFees.EditValue = "";
            this.fld_txtAPInvoiceInShippingFees.Location = new System.Drawing.Point(1053, 579);
            this.fld_txtAPInvoiceInShippingFees.Name = "fld_txtAPInvoiceInShippingFees";
            this.fld_txtAPInvoiceInShippingFees.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInShippingFees.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInShippingFees.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInShippingFees.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInShippingFees.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInShippingFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInShippingFees.Screen = null;
            this.fld_txtAPInvoiceInShippingFees.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInShippingFees.TabIndex = 8;
            this.fld_txtAPInvoiceInShippingFees.Tag = "DC";
            this.fld_txtAPInvoiceInShippingFees.Validated += new System.EventHandler(this.fld_txtAPInvoiceInShippingFees_Validated);
            // 
            // fld_txtAPInvoiceInDiscountFix
            // 
            this.fld_txtAPInvoiceInDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInDiscountFix.BOSComment = "";
            this.fld_txtAPInvoiceInDiscountFix.BOSDataMember = "APInvoiceInDiscountFix";
            this.fld_txtAPInvoiceInDiscountFix.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInDiscountFix.BOSDescription = null;
            this.fld_txtAPInvoiceInDiscountFix.BOSError = null;
            this.fld_txtAPInvoiceInDiscountFix.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInDiscountFix.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInDiscountFix.BOSPrivilege = "";
            this.fld_txtAPInvoiceInDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInDiscountFix.EditValue = "";
            this.fld_txtAPInvoiceInDiscountFix.Location = new System.Drawing.Point(1115, 553);
            this.fld_txtAPInvoiceInDiscountFix.Name = "fld_txtAPInvoiceInDiscountFix";
            this.fld_txtAPInvoiceInDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInDiscountFix.Screen = null;
            this.fld_txtAPInvoiceInDiscountFix.Size = new System.Drawing.Size(115, 20);
            this.fld_txtAPInvoiceInDiscountFix.TabIndex = 7;
            this.fld_txtAPInvoiceInDiscountFix.Tag = "DC";
            this.fld_txtAPInvoiceInDiscountFix.Validated += new System.EventHandler(this.fld_txtAPInvoiceInDiscountFix_Validated);
            // 
            // fld_txtAPInvoiceInDiscountPercent
            // 
            this.fld_txtAPInvoiceInDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInDiscountPercent.BOSComment = "";
            this.fld_txtAPInvoiceInDiscountPercent.BOSDataMember = "APInvoiceInDiscountPerCent";
            this.fld_txtAPInvoiceInDiscountPercent.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInDiscountPercent.BOSDescription = null;
            this.fld_txtAPInvoiceInDiscountPercent.BOSError = null;
            this.fld_txtAPInvoiceInDiscountPercent.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInDiscountPercent.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInDiscountPercent.BOSPrivilege = "";
            this.fld_txtAPInvoiceInDiscountPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInDiscountPercent.EditValue = "";
            this.fld_txtAPInvoiceInDiscountPercent.Location = new System.Drawing.Point(1053, 553);
            this.fld_txtAPInvoiceInDiscountPercent.Name = "fld_txtAPInvoiceInDiscountPercent";
            this.fld_txtAPInvoiceInDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInDiscountPercent.Screen = null;
            this.fld_txtAPInvoiceInDiscountPercent.Size = new System.Drawing.Size(56, 20);
            this.fld_txtAPInvoiceInDiscountPercent.TabIndex = 6;
            this.fld_txtAPInvoiceInDiscountPercent.Tag = "DC";
            this.fld_txtAPInvoiceInDiscountPercent.Validated += new System.EventHandler(this.fld_txtAPInvoiceInDiscountPercent_Validated);
            // 
            // fld_btnEditShippingInfo
            // 
            this.fld_btnEditShippingInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEditShippingInfo.Appearance.Options.UseForeColor = true;
            this.fld_btnEditShippingInfo.BOSComment = "";
            this.fld_btnEditShippingInfo.BOSDataMember = "";
            this.fld_btnEditShippingInfo.BOSDataSource = "";
            this.fld_btnEditShippingInfo.BOSDescription = null;
            this.fld_btnEditShippingInfo.BOSError = null;
            this.fld_btnEditShippingInfo.BOSFieldGroup = "";
            this.fld_btnEditShippingInfo.BOSFieldRelation = "";
            this.fld_btnEditShippingInfo.BOSPrivilege = "";
            this.fld_btnEditShippingInfo.BOSPropertyName = "";
            this.fld_btnEditShippingInfo.Location = new System.Drawing.Point(293, 145);
            this.fld_btnEditShippingInfo.Name = "fld_btnEditShippingInfo";
            this.fld_btnEditShippingInfo.Screen = null;
            this.fld_btnEditShippingInfo.Size = new System.Drawing.Size(75, 20);
            this.fld_btnEditShippingInfo.TabIndex = 0;
            this.fld_btnEditShippingInfo.Tag = "";
            this.fld_btnEditShippingInfo.Text = "Sửa";
            this.fld_btnEditShippingInfo.Click += new System.EventHandler(this.fld_btnEditShippingInfo_Click);
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseFont = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "";
            this.fld_lblLabel29.BOSDataSource = "";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = "";
            this.fld_lblLabel29.Location = new System.Drawing.Point(18, 19);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel29.TabIndex = 29;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "Địa chỉ hóa đơn";
            // 
            // fld_lblDeliveryAddressLine2
            // 
            this.fld_lblDeliveryAddressLine2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblDeliveryAddressLine2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblDeliveryAddressLine2.Appearance.Options.UseBackColor = true;
            this.fld_lblDeliveryAddressLine2.Appearance.Options.UseForeColor = true;
            this.fld_lblDeliveryAddressLine2.BOSComment = "";
            this.fld_lblDeliveryAddressLine2.BOSDataMember = "APInvoiceInDeliveryAddressPostalCode";
            this.fld_lblDeliveryAddressLine2.BOSDataSource = "APInvoiceIns";
            this.fld_lblDeliveryAddressLine2.BOSDescription = null;
            this.fld_lblDeliveryAddressLine2.BOSError = null;
            this.fld_lblDeliveryAddressLine2.BOSFieldGroup = "";
            this.fld_lblDeliveryAddressLine2.BOSFieldRelation = "";
            this.fld_lblDeliveryAddressLine2.BOSPrivilege = "";
            this.fld_lblDeliveryAddressLine2.BOSPropertyName = "";
            this.fld_lblDeliveryAddressLine2.Location = new System.Drawing.Point(19, 133);
            this.fld_lblDeliveryAddressLine2.Name = "fld_lblDeliveryAddressLine2";
            this.fld_lblDeliveryAddressLine2.Screen = null;
            this.fld_lblDeliveryAddressLine2.Size = new System.Drawing.Size(12, 13);
            this.fld_lblDeliveryAddressLine2.TabIndex = 40;
            this.fld_lblDeliveryAddressLine2.Tag = "";
            this.fld_lblDeliveryAddressLine2.Text = "08";
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = "";
            this.fld_lblLabel37.BOSDataMember = "APInvoiceInDeliveryAddressLine3";
            this.fld_lblLabel37.BOSDataSource = "APInvoiceIns";
            this.fld_lblLabel37.BOSDescription = null;
            this.fld_lblLabel37.BOSError = null;
            this.fld_lblLabel37.BOSFieldGroup = "";
            this.fld_lblLabel37.BOSFieldRelation = "";
            this.fld_lblLabel37.BOSPrivilege = "";
            this.fld_lblLabel37.BOSPropertyName = "";
            this.fld_lblLabel37.Location = new System.Drawing.Point(19, 110);
            this.fld_lblLabel37.Name = "fld_lblLabel37";
            this.fld_lblLabel37.Screen = null;
            this.fld_lblLabel37.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel37.TabIndex = 39;
            this.fld_lblLabel37.Tag = "";
            this.fld_lblLabel37.Text = "1 Le Duan, Dist 1, HCM";
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
            this.fld_Line1.Location = new System.Drawing.Point(105, 90);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(269, 10);
            this.fld_Line1.TabIndex = 38;
            this.fld_Line1.TabStop = false;
            this.fld_Line1.Tag = "";
            // 
            // fld_lblLabel36
            // 
            this.fld_lblLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel36.Appearance.Options.UseFont = true;
            this.fld_lblLabel36.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel36.BOSComment = "";
            this.fld_lblLabel36.BOSDataMember = "";
            this.fld_lblLabel36.BOSDataSource = "";
            this.fld_lblLabel36.BOSDescription = null;
            this.fld_lblLabel36.BOSError = null;
            this.fld_lblLabel36.BOSFieldGroup = "";
            this.fld_lblLabel36.BOSFieldRelation = "";
            this.fld_lblLabel36.BOSPrivilege = "";
            this.fld_lblLabel36.BOSPropertyName = "";
            this.fld_lblLabel36.Location = new System.Drawing.Point(18, 87);
            this.fld_lblLabel36.Name = "fld_lblLabel36";
            this.fld_lblLabel36.Screen = null;
            this.fld_lblLabel36.Size = new System.Drawing.Size(100, 13);
            this.fld_lblLabel36.TabIndex = 37;
            this.fld_lblLabel36.Tag = "";
            this.fld_lblLabel36.Text = "Địa chỉ nhận hàng";
            // 
            // fld_lblInvoiceAddressLine2
            // 
            this.fld_lblInvoiceAddressLine2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblInvoiceAddressLine2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblInvoiceAddressLine2.Appearance.Options.UseBackColor = true;
            this.fld_lblInvoiceAddressLine2.Appearance.Options.UseForeColor = true;
            this.fld_lblInvoiceAddressLine2.BOSComment = "";
            this.fld_lblInvoiceAddressLine2.BOSDataMember = "APInvoiceInInvoiceAddressPostalCode";
            this.fld_lblInvoiceAddressLine2.BOSDataSource = "APInvoiceIns";
            this.fld_lblInvoiceAddressLine2.BOSDescription = null;
            this.fld_lblInvoiceAddressLine2.BOSError = null;
            this.fld_lblInvoiceAddressLine2.BOSFieldGroup = "";
            this.fld_lblInvoiceAddressLine2.BOSFieldRelation = "";
            this.fld_lblInvoiceAddressLine2.BOSPrivilege = "";
            this.fld_lblInvoiceAddressLine2.BOSPropertyName = "";
            this.fld_lblInvoiceAddressLine2.Location = new System.Drawing.Point(19, 63);
            this.fld_lblInvoiceAddressLine2.Name = "fld_lblInvoiceAddressLine2";
            this.fld_lblInvoiceAddressLine2.Screen = null;
            this.fld_lblInvoiceAddressLine2.Size = new System.Drawing.Size(12, 13);
            this.fld_lblInvoiceAddressLine2.TabIndex = 32;
            this.fld_lblInvoiceAddressLine2.Tag = "";
            this.fld_lblInvoiceAddressLine2.Text = "08";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = "";
            this.fld_lblLabel30.BOSDataMember = "APInvoiceInInvoiceAddressLine3";
            this.fld_lblLabel30.BOSDataSource = "APInvoiceIns";
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = "";
            this.fld_lblLabel30.BOSFieldRelation = "";
            this.fld_lblLabel30.BOSPrivilege = "";
            this.fld_lblLabel30.BOSPropertyName = "";
            this.fld_lblLabel30.Location = new System.Drawing.Point(18, 41);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.fld_lblLabel30.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel30.TabIndex = 31;
            this.fld_lblLabel30.Tag = "";
            this.fld_lblLabel30.Text = "1 Le Duan, Dist 1, HCM";
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = "";
            this.fld_Line.BOSDataMember = "";
            this.fld_Line.BOSDataSource = "";
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = "";
            this.fld_Line.BOSFieldRelation = "";
            this.fld_Line.BOSPrivilege = "";
            this.fld_Line.BOSPropertyName = "";
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Location = new System.Drawing.Point(100, 22);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.fld_Line.Size = new System.Drawing.Size(267, 10);
            this.fld_Line.TabIndex = 30;
            this.fld_Line.TabStop = false;
            this.fld_Line.Tag = "";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.Location = new System.Drawing.Point(955, 556);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(51, 13);
            this.bosLabel4.TabIndex = 27;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Chiết khấu";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(5, 20);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(955, 582);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(73, 13);
            this.bosLabel5.TabIndex = 30;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Phí vận chuyển";
            // 
            // fld_txtAPInvoiceInShippingExtraFees
            // 
            this.fld_txtAPInvoiceInShippingExtraFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInShippingExtraFees.BOSComment = "";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSDataMember = "APInvoiceInShippingExtraFees";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSDescription = null;
            this.fld_txtAPInvoiceInShippingExtraFees.BOSError = null;
            this.fld_txtAPInvoiceInShippingExtraFees.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSPrivilege = "";
            this.fld_txtAPInvoiceInShippingExtraFees.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInShippingExtraFees.EditValue = "";
            this.fld_txtAPInvoiceInShippingExtraFees.Location = new System.Drawing.Point(1053, 605);
            this.fld_txtAPInvoiceInShippingExtraFees.Name = "fld_txtAPInvoiceInShippingExtraFees";
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Mask.EditMask = "n";
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPInvoiceInShippingExtraFees.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInShippingExtraFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInShippingExtraFees.Screen = null;
            this.fld_txtAPInvoiceInShippingExtraFees.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInShippingExtraFees.TabIndex = 9;
            this.fld_txtAPInvoiceInShippingExtraFees.Tag = "DC";
            this.fld_txtAPInvoiceInShippingExtraFees.Validated += new System.EventHandler(this.fld_txtAPInvoiceInShippingExtraFees_Validated);
            // 
            // fld_dteAPInvoiceInValidateDate
            // 
            this.fld_dteAPInvoiceInValidateDate.BOSComment = "";
            this.fld_dteAPInvoiceInValidateDate.BOSDataMember = "APInvoiceInValidateDate";
            this.fld_dteAPInvoiceInValidateDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteAPInvoiceInValidateDate.BOSDescription = null;
            this.fld_dteAPInvoiceInValidateDate.BOSError = null;
            this.fld_dteAPInvoiceInValidateDate.BOSFieldGroup = "";
            this.fld_dteAPInvoiceInValidateDate.BOSFieldRelation = "";
            this.fld_dteAPInvoiceInValidateDate.BOSPrivilege = "";
            this.fld_dteAPInvoiceInValidateDate.BOSPropertyName = "EditValue";
            this.fld_dteAPInvoiceInValidateDate.EditValue = null;
            this.fld_dteAPInvoiceInValidateDate.Location = new System.Drawing.Point(305, 121);
            this.fld_dteAPInvoiceInValidateDate.Name = "fld_dteAPInvoiceInValidateDate";
            this.fld_dteAPInvoiceInValidateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPInvoiceInValidateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPInvoiceInValidateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPInvoiceInValidateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPInvoiceInValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPInvoiceInValidateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPInvoiceInValidateDate.Screen = null;
            this.fld_dteAPInvoiceInValidateDate.Size = new System.Drawing.Size(106, 20);
            this.fld_dteAPInvoiceInValidateDate.TabIndex = 17;
            this.fld_dteAPInvoiceInValidateDate.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel7.Location = new System.Drawing.Point(222, 124);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(81, 13);
            this.bosLabel7.TabIndex = 5;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Ngày thanh toán";
            // 
            // fld_Line2
            // 
            this.fld_Line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fld_Line2.Controls.Add(this.fld_lblLabel29);
            this.fld_Line2.Controls.Add(this.fld_Line);
            this.fld_Line2.Controls.Add(this.fld_lblLabel30);
            this.fld_Line2.Controls.Add(this.fld_lblInvoiceAddressLine2);
            this.fld_Line2.Controls.Add(this.fld_lblLabel36);
            this.fld_Line2.Controls.Add(this.fld_Line1);
            this.fld_Line2.Controls.Add(this.fld_lblLabel37);
            this.fld_Line2.Controls.Add(this.fld_btnEditShippingInfo);
            this.fld_Line2.Controls.Add(this.fld_lblDeliveryAddressLine2);
            this.fld_Line2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line2.Location = new System.Drawing.Point(299, 521);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(374, 173);
            this.fld_Line2.TabIndex = 4;
            this.fld_Line2.TabStop = false;
            this.fld_Line2.Tag = "";
            this.fld_Line2.Text = "Thông tin giao hàng";
            // 
            // fld_txtAPInvoiceInNo1
            // 
            this.fld_txtAPInvoiceInNo1.BOSComment = "";
            this.fld_txtAPInvoiceInNo1.BOSDataMember = "APInvoiceInNo";
            this.fld_txtAPInvoiceInNo1.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInNo1.BOSDescription = null;
            this.fld_txtAPInvoiceInNo1.BOSError = null;
            this.fld_txtAPInvoiceInNo1.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInNo1.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInNo1.BOSPrivilege = "";
            this.fld_txtAPInvoiceInNo1.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInNo1.EditValue = "";
            this.fld_txtAPInvoiceInNo1.Location = new System.Drawing.Point(92, 17);
            this.fld_txtAPInvoiceInNo1.Name = "fld_txtAPInvoiceInNo1";
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInNo1.Screen = null;
            this.fld_txtAPInvoiceInNo1.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInNo1.TabIndex = 0;
            this.fld_txtAPInvoiceInNo1.Tag = "DC";
            // 
            // fld_pteAPInvoiceInEmployeePicture
            // 
            this.fld_pteAPInvoiceInEmployeePicture.BOSComment = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataMember = "APInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataSource = "APInvoiceIns";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDescription = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSError = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldGroup = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldRelation = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSPrivilege = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPInvoiceInEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPInvoiceInEmployeePicture.EditValue = "";
            this.fld_pteAPInvoiceInEmployeePicture.FileName = null;
            this.fld_pteAPInvoiceInEmployeePicture.FilePath = null;
            this.fld_pteAPInvoiceInEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteAPInvoiceInEmployeePicture.Name = "fld_pteAPInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPInvoiceInEmployeePicture.Screen = null;
            this.fld_pteAPInvoiceInEmployeePicture.Size = new System.Drawing.Size(99, 90);
            this.fld_pteAPInvoiceInEmployeePicture.TabIndex = 0;
            this.fld_pteAPInvoiceInEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 98);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 21;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
            // 
            // fld_lkeAPInvoiceInStatus
            // 
            this.fld_lkeAPInvoiceInStatus.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInStatus.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInStatus.BOSComment = null;
            this.fld_lkeAPInvoiceInStatus.BOSDataMember = "APInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInvoiceInStatus.BOSDescription = null;
            this.fld_lkeAPInvoiceInStatus.BOSError = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldGroup = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldParent = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldRelation = null;
            this.fld_lkeAPInvoiceInStatus.BOSPrivilege = null;
            this.fld_lkeAPInvoiceInStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInStatus.BOSSelectType = null;
            this.fld_lkeAPInvoiceInStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPInvoiceInStatus.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInStatus.Location = new System.Drawing.Point(729, 44);
            this.fld_lkeAPInvoiceInStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPInvoiceInStatus.Name = "fld_lkeAPInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInStatus.Properties.ColumnName = null;
            this.fld_lkeAPInvoiceInStatus.Properties.NullText = "";
            this.fld_lkeAPInvoiceInStatus.Properties.ReadOnly = true;
            this.fld_lkeAPInvoiceInStatus.Screen = null;
            this.fld_lkeAPInvoiceInStatus.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeAPInvoiceInStatus.TabIndex = 7;
            this.fld_lkeAPInvoiceInStatus.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(955, 633);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(24, 13);
            this.bosLabel3.TabIndex = 34;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Thuế";
            // 
            // fld_txtAPInvoiceInTaxPercent
            // 
            this.fld_txtAPInvoiceInTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInTaxPercent.BOSComment = "";
            this.fld_txtAPInvoiceInTaxPercent.BOSDataMember = "APInvoiceInTaxPercent";
            this.fld_txtAPInvoiceInTaxPercent.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInTaxPercent.BOSDescription = null;
            this.fld_txtAPInvoiceInTaxPercent.BOSError = null;
            this.fld_txtAPInvoiceInTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInTaxPercent.BOSPrivilege = "";
            this.fld_txtAPInvoiceInTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInTaxPercent.EditValue = "";
            this.fld_txtAPInvoiceInTaxPercent.Location = new System.Drawing.Point(1053, 630);
            this.fld_txtAPInvoiceInTaxPercent.Name = "fld_txtAPInvoiceInTaxPercent";
            this.fld_txtAPInvoiceInTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInTaxPercent.Screen = null;
            this.fld_txtAPInvoiceInTaxPercent.Size = new System.Drawing.Size(56, 20);
            this.fld_txtAPInvoiceInTaxPercent.TabIndex = 10;
            this.fld_txtAPInvoiceInTaxPercent.Tag = "DC";
            this.fld_txtAPInvoiceInTaxPercent.Validated += new System.EventHandler(this.fld_txtAPInvoiceInTaxPercent_Validated);
            // 
            // fld_txtAPInvoiceInTaxAmount
            // 
            this.fld_txtAPInvoiceInTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInTaxAmount.BOSComment = "";
            this.fld_txtAPInvoiceInTaxAmount.BOSDataMember = "APInvoiceInTaxAmount";
            this.fld_txtAPInvoiceInTaxAmount.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInTaxAmount.BOSDescription = null;
            this.fld_txtAPInvoiceInTaxAmount.BOSError = null;
            this.fld_txtAPInvoiceInTaxAmount.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInTaxAmount.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInTaxAmount.BOSPrivilege = "";
            this.fld_txtAPInvoiceInTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInTaxAmount.EditValue = "";
            this.fld_txtAPInvoiceInTaxAmount.Location = new System.Drawing.Point(1115, 630);
            this.fld_txtAPInvoiceInTaxAmount.Name = "fld_txtAPInvoiceInTaxAmount";
            this.fld_txtAPInvoiceInTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInTaxAmount.Screen = null;
            this.fld_txtAPInvoiceInTaxAmount.Size = new System.Drawing.Size(115, 20);
            this.fld_txtAPInvoiceInTaxAmount.TabIndex = 11;
            this.fld_txtAPInvoiceInTaxAmount.Tag = "DC";
            this.fld_txtAPInvoiceInTaxAmount.Validated += new System.EventHandler(this.fld_txtAPInvoiceInTaxAmount_Validated);
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
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceInItems);
            this.bosPanel1.Controls.Add(this.fld_pteAPInvoiceInEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_Line2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInShippingExtraFees);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_Lablel1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_Lablel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lblLabel16);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInSubTotalCost);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInDiscountPercent);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInBalanceDue);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInDepositBalance);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInTotalCost);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInShippingFees);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInTaxAmount);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1238, 743);
            this.bosPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInProject);
            this.groupBox1.Controls.Add(this.fld_lkeFK_GETerminalID);
            this.groupBox1.Controls.Add(this.bosLabel32);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInContractNo);
            this.groupBox1.Controls.Add(this.bosLabel31);
            this.groupBox1.Controls.Add(this.bosLabel30);
            this.groupBox1.Controls.Add(this.fld_lkeAPInvoiceInChannel);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.groupBox1.Controls.Add(this.bosLabel29);
            this.groupBox1.Controls.Add(this.bosTextBox2);
            this.groupBox1.Controls.Add(this.bosLabel28);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInSupplierTaxNumber);
            this.groupBox1.Controls.Add(this.bosLabel27);
            this.groupBox1.Controls.Add(this.bosDateEdit2);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInNo1);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.bosLabel21);
            this.groupBox1.Controls.Add(this.fld_lbWoodType);
            this.groupBox1.Controls.Add(this.fld_dteAPInvoiceInContractDate);
            this.groupBox1.Controls.Add(this.fld_Lablel2);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.groupBox1.Controls.Add(this.bosLabel6);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInBillOfLanding);
            this.groupBox1.Controls.Add(this.fld_lblLabel7);
            this.groupBox1.Controls.Add(this.bosLabel20);
            this.groupBox1.Controls.Add(this.bosLabel8);
            this.groupBox1.Controls.Add(this.fld_lkeAPInvoiceInType);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.bosLabel17);
            this.groupBox1.Controls.Add(this.fld_dteAPInvoiceInValidateDate);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInPackingList);
            this.groupBox1.Controls.Add(this.bosLabel7);
            this.groupBox1.Controls.Add(this.bosLabel19);
            this.groupBox1.Controls.Add(this.fld_lkeAPInvoiceInStatus);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInTotalQuantity);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInExchangeRate);
            this.groupBox1.Controls.Add(this.bosLabel15);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInRoundWoodQty);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInPackNo);
            this.groupBox1.Controls.Add(this.bosLabel18);
            this.groupBox1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.groupBox1.Controls.Add(this.fld_lkeFK_GECountryID);
            this.groupBox1.Controls.Add(this.bosLabel23);
            this.groupBox1.Controls.Add(this.bosLabel10);
            this.groupBox1.Controls.Add(this.fld_txtAPInvoiceInLogListNo);
            this.groupBox1.Controls.Add(this.bosLabel14);
            this.groupBox1.Controls.Add(this.bosLabel16);
            this.groupBox1.Controls.Add(this.bosLabel11);
            this.groupBox1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.groupBox1.Controls.Add(this.fld_medAPInvoiceInDesc);
            this.groupBox1.Location = new System.Drawing.Point(324, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khác";
            // 
            // fld_txtAPInvoiceInProject
            // 
            this.fld_txtAPInvoiceInProject.BOSComment = "";
            this.fld_txtAPInvoiceInProject.BOSDataMember = "APInvoiceInProject";
            this.fld_txtAPInvoiceInProject.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInProject.BOSDescription = null;
            this.fld_txtAPInvoiceInProject.BOSError = null;
            this.fld_txtAPInvoiceInProject.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInProject.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInProject.BOSPrivilege = "";
            this.fld_txtAPInvoiceInProject.BOSPropertyName = "EditValue";
            this.fld_txtAPInvoiceInProject.EditValue = "";
            this.fld_txtAPInvoiceInProject.Location = new System.Drawing.Point(729, 148);
            this.fld_txtAPInvoiceInProject.Name = "fld_txtAPInvoiceInProject";
            this.fld_txtAPInvoiceInProject.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInProject.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInProject.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInProject.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInProject.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInProject.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPInvoiceInProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInProject.Screen = null;
            this.fld_txtAPInvoiceInProject.Size = new System.Drawing.Size(118, 20);
            this.fld_txtAPInvoiceInProject.TabIndex = 22;
            this.fld_txtAPInvoiceInProject.Tag = "DC";
            // 
            // fld_lkeFK_GETerminalID
            // 
            this.fld_lkeFK_GETerminalID.BOSAllowAddNew = false;
            this.fld_lkeFK_GETerminalID.BOSAllowDummy = true;
            this.fld_lkeFK_GETerminalID.BOSComment = "";
            this.fld_lkeFK_GETerminalID.BOSDataMember = "FK_GETerminalID";
            this.fld_lkeFK_GETerminalID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_GETerminalID.BOSDescription = null;
            this.fld_lkeFK_GETerminalID.BOSError = null;
            this.fld_lkeFK_GETerminalID.BOSFieldGroup = "";
            this.fld_lkeFK_GETerminalID.BOSFieldParent = "";
            this.fld_lkeFK_GETerminalID.BOSFieldRelation = "";
            this.fld_lkeFK_GETerminalID.BOSPrivilege = "";
            this.fld_lkeFK_GETerminalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GETerminalID.BOSSelectType = "";
            this.fld_lkeFK_GETerminalID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GETerminalID.CurrentDisplayText = "";
            this.fld_lkeFK_GETerminalID.Location = new System.Drawing.Point(729, 174);
            this.fld_lkeFK_GETerminalID.Name = "fld_lkeFK_GETerminalID";
            this.fld_lkeFK_GETerminalID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GETerminalID.Properties.ColumnName = null;
            this.fld_lkeFK_GETerminalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên")});
            this.fld_lkeFK_GETerminalID.Properties.DisplayMember = "GETerminalName";
            this.fld_lkeFK_GETerminalID.Properties.NullText = "";
            this.fld_lkeFK_GETerminalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GETerminalID.Properties.ValueMember = "GETerminalID";
            this.fld_lkeFK_GETerminalID.Screen = null;
            this.fld_lkeFK_GETerminalID.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeFK_GETerminalID.TabIndex = 24;
            this.fld_lkeFK_GETerminalID.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = "";
            this.bosLabel32.Location = new System.Drawing.Point(631, 176);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(25, 13);
            this.bosLabel32.TabIndex = 641;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Cảng";
            // 
            // fld_txtAPInvoiceInContractNo
            // 
            this.fld_txtAPInvoiceInContractNo.BOSComment = "";
            this.fld_txtAPInvoiceInContractNo.BOSDataMember = "APInvoiceInContractNo";
            this.fld_txtAPInvoiceInContractNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInContractNo.BOSDescription = null;
            this.fld_txtAPInvoiceInContractNo.BOSError = null;
            this.fld_txtAPInvoiceInContractNo.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInContractNo.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInContractNo.BOSPrivilege = "";
            this.fld_txtAPInvoiceInContractNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInContractNo.EditValue = "";
            this.fld_txtAPInvoiceInContractNo.Location = new System.Drawing.Point(305, 17);
            this.fld_txtAPInvoiceInContractNo.Name = "fld_txtAPInvoiceInContractNo";
            this.fld_txtAPInvoiceInContractNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInContractNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInContractNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInContractNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInContractNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInContractNo.Properties.ReadOnly = true;
            this.fld_txtAPInvoiceInContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInContractNo.Screen = null;
            this.fld_txtAPInvoiceInContractNo.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInContractNo.TabIndex = 1;
            this.fld_txtAPInvoiceInContractNo.Tag = "DC";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = "";
            this.bosLabel31.BOSDataMember = "";
            this.bosLabel31.BOSDataSource = "";
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = "";
            this.bosLabel31.BOSFieldRelation = "";
            this.bosLabel31.BOSPrivilege = "";
            this.bosLabel31.BOSPropertyName = "";
            this.bosLabel31.Location = new System.Drawing.Point(631, 151);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(45, 13);
            this.bosLabel31.TabIndex = 639;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "Mã dự án";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = "";
            this.bosLabel30.BOSDataMember = "";
            this.bosLabel30.BOSDataSource = "";
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = "";
            this.bosLabel30.BOSFieldRelation = "";
            this.bosLabel30.BOSPrivilege = "";
            this.bosLabel30.BOSPropertyName = "";
            this.bosLabel30.Location = new System.Drawing.Point(5, 73);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(34, 13);
            this.bosLabel30.TabIndex = 589;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Mua từ";
            // 
            // fld_lkeAPInvoiceInChannel
            // 
            this.fld_lkeAPInvoiceInChannel.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInChannel.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInChannel.BOSComment = "";
            this.fld_lkeAPInvoiceInChannel.BOSDataMember = "APInvoiceInChannel";
            this.fld_lkeAPInvoiceInChannel.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInvoiceInChannel.BOSDescription = null;
            this.fld_lkeAPInvoiceInChannel.BOSError = null;
            this.fld_lkeAPInvoiceInChannel.BOSFieldGroup = "";
            this.fld_lkeAPInvoiceInChannel.BOSFieldParent = "";
            this.fld_lkeAPInvoiceInChannel.BOSFieldRelation = "";
            this.fld_lkeAPInvoiceInChannel.BOSPrivilege = "";
            this.fld_lkeAPInvoiceInChannel.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInChannel.BOSSelectType = "";
            this.fld_lkeAPInvoiceInChannel.BOSSelectTypeValue = "";
            this.fld_lkeAPInvoiceInChannel.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInChannel.Location = new System.Drawing.Point(92, 69);
            this.fld_lkeAPInvoiceInChannel.Name = "fld_lkeAPInvoiceInChannel";
            this.fld_lkeAPInvoiceInChannel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInvoiceInChannel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInChannel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInChannel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInChannel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInChannel.Properties.ColumnName = null;
            this.fld_lkeAPInvoiceInChannel.Properties.NullText = "";
            this.fld_lkeAPInvoiceInChannel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInChannel.Screen = null;
            this.fld_lkeAPInvoiceInChannel.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeAPInvoiceInChannel.TabIndex = 8;
            this.fld_lkeAPInvoiceInChannel.Tag = "DC";
            this.fld_lkeAPInvoiceInChannel.Validated += new System.EventHandler(this.fld_lkeAPInvoiceInChannel_Validated);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APInvoiceIns";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(92, 95);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 12;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            this.fld_lkeFK_ACObjectID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_ACObjectID_EditValueChanging);
            // 
            // bosLabel29
            // 
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(631, 125);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(91, 13);
            this.bosLabel29.TabIndex = 587;
            this.bosLabel29.Text = "Số phiếu giao hàng";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "APInvoiceInPONo";
            this.bosTextBox2.BOSDataSource = "APInvoiceIns";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(729, 122);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox2.TabIndex = 19;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = "";
            this.bosLabel28.BOSDataMember = "";
            this.bosLabel28.BOSDataSource = "";
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = "";
            this.bosLabel28.BOSFieldRelation = "";
            this.bosLabel28.BOSPrivilege = "";
            this.bosLabel28.BOSPropertyName = "";
            this.bosLabel28.Location = new System.Drawing.Point(429, 124);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(77, 13);
            this.bosLabel28.TabIndex = 371;
            this.bosLabel28.Tag = "";
            this.bosLabel28.Text = "Mã số thuế NCC";
            // 
            // fld_txtAPInvoiceInSupplierTaxNumber
            // 
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSComment = "";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSDataMember = "APInvoiceInTaxNumber";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSDescription = null;
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSError = null;
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSPrivilege = "";
            this.fld_txtAPInvoiceInSupplierTaxNumber.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInSupplierTaxNumber.EditValue = "";
            this.fld_txtAPInvoiceInSupplierTaxNumber.Location = new System.Drawing.Point(512, 121);
            this.fld_txtAPInvoiceInSupplierTaxNumber.Name = "fld_txtAPInvoiceInSupplierTaxNumber";
            this.fld_txtAPInvoiceInSupplierTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInSupplierTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInSupplierTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInSupplierTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInSupplierTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInSupplierTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInSupplierTaxNumber.Screen = null;
            this.fld_txtAPInvoiceInSupplierTaxNumber.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInSupplierTaxNumber.TabIndex = 18;
            this.fld_txtAPInvoiceInSupplierTaxNumber.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(5, 46);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(72, 13);
            this.bosLabel27.TabIndex = 369;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Ngày chứng từ";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = "";
            this.bosDateEdit2.BOSDataMember = "APInvoiceInDate";
            this.bosDateEdit2.BOSDataSource = "APInvoiceIns";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = "";
            this.bosDateEdit2.BOSFieldRelation = "";
            this.bosDateEdit2.BOSPrivilege = "";
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(92, 43);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(106, 20);
            this.bosDateEdit2.TabIndex = 4;
            this.bosDateEdit2.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(222, 46);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(73, 13);
            this.bosLabel21.TabIndex = 89;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Ngày hợp đồng";
            // 
            // fld_lbWoodType
            // 
            this.fld_lbWoodType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.Options.UseBackColor = true;
            this.fld_lbWoodType.Appearance.Options.UseForeColor = true;
            this.fld_lbWoodType.BOSComment = null;
            this.fld_lbWoodType.BOSDataMember = null;
            this.fld_lbWoodType.BOSDataSource = null;
            this.fld_lbWoodType.BOSDescription = null;
            this.fld_lbWoodType.BOSError = null;
            this.fld_lbWoodType.BOSFieldGroup = null;
            this.fld_lbWoodType.BOSFieldRelation = null;
            this.fld_lbWoodType.BOSPrivilege = null;
            this.fld_lbWoodType.BOSPropertyName = null;
            this.fld_lbWoodType.Location = new System.Drawing.Point(631, 72);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 367;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_dteAPInvoiceInContractDate
            // 
            this.fld_dteAPInvoiceInContractDate.BOSComment = "";
            this.fld_dteAPInvoiceInContractDate.BOSDataMember = "APInvoiceInContractDate";
            this.fld_dteAPInvoiceInContractDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteAPInvoiceInContractDate.BOSDescription = null;
            this.fld_dteAPInvoiceInContractDate.BOSError = null;
            this.fld_dteAPInvoiceInContractDate.BOSFieldGroup = "";
            this.fld_dteAPInvoiceInContractDate.BOSFieldRelation = "";
            this.fld_dteAPInvoiceInContractDate.BOSPrivilege = "";
            this.fld_dteAPInvoiceInContractDate.BOSPropertyName = "EditValue";
            this.fld_dteAPInvoiceInContractDate.EditValue = null;
            this.fld_dteAPInvoiceInContractDate.Enabled = false;
            this.fld_dteAPInvoiceInContractDate.Location = new System.Drawing.Point(305, 43);
            this.fld_dteAPInvoiceInContractDate.Name = "fld_dteAPInvoiceInContractDate";
            this.fld_dteAPInvoiceInContractDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPInvoiceInContractDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPInvoiceInContractDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPInvoiceInContractDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPInvoiceInContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPInvoiceInContractDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPInvoiceInContractDate.Properties.ReadOnly = true;
            this.fld_dteAPInvoiceInContractDate.Screen = null;
            this.fld_dteAPInvoiceInContractDate.Size = new System.Drawing.Size(106, 20);
            this.fld_dteAPInvoiceInContractDate.TabIndex = 5;
            this.fld_dteAPInvoiceInContractDate.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "APInvoiceIns";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(729, 70);
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ReadOnly = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 11;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.Validated += new System.EventHandler(this.fld_lkeFK_ICProductAttributeTTMTID_Validated);
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
            this.bosLabel6.Location = new System.Drawing.Point(222, 150);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 13;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Diễn giải";
            // 
            // fld_txtAPInvoiceInBillOfLanding
            // 
            this.fld_txtAPInvoiceInBillOfLanding.BOSComment = "";
            this.fld_txtAPInvoiceInBillOfLanding.BOSDataMember = "APInvoiceInBillOfLanding";
            this.fld_txtAPInvoiceInBillOfLanding.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInBillOfLanding.BOSDescription = null;
            this.fld_txtAPInvoiceInBillOfLanding.BOSError = null;
            this.fld_txtAPInvoiceInBillOfLanding.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInBillOfLanding.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInBillOfLanding.BOSPrivilege = "";
            this.fld_txtAPInvoiceInBillOfLanding.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInBillOfLanding.EditValue = "";
            this.fld_txtAPInvoiceInBillOfLanding.Location = new System.Drawing.Point(512, 69);
            this.fld_txtAPInvoiceInBillOfLanding.Name = "fld_txtAPInvoiceInBillOfLanding";
            this.fld_txtAPInvoiceInBillOfLanding.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInBillOfLanding.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInBillOfLanding.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInBillOfLanding.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInBillOfLanding.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInBillOfLanding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInBillOfLanding.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPInvoiceInBillOfLanding, true);
            this.fld_txtAPInvoiceInBillOfLanding.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInBillOfLanding.TabIndex = 10;
            this.fld_txtAPInvoiceInBillOfLanding.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = "";
            this.bosLabel20.Location = new System.Drawing.Point(429, 72);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(30, 13);
            this.bosLabel20.TabIndex = 365;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Số B/L";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(222, 20);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(60, 13);
            this.bosLabel8.TabIndex = 9;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Số hợp đồng";
            // 
            // fld_lkeAPInvoiceInType
            // 
            this.fld_lkeAPInvoiceInType.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInType.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInType.BOSComment = "";
            this.fld_lkeAPInvoiceInType.BOSDataMember = "APInvoiceInType";
            this.fld_lkeAPInvoiceInType.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInvoiceInType.BOSDescription = null;
            this.fld_lkeAPInvoiceInType.BOSError = null;
            this.fld_lkeAPInvoiceInType.BOSFieldGroup = "";
            this.fld_lkeAPInvoiceInType.BOSFieldParent = "";
            this.fld_lkeAPInvoiceInType.BOSFieldRelation = "";
            this.fld_lkeAPInvoiceInType.BOSPrivilege = "";
            this.fld_lkeAPInvoiceInType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInType.BOSSelectType = "";
            this.fld_lkeAPInvoiceInType.BOSSelectTypeValue = "";
            this.fld_lkeAPInvoiceInType.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInType.Location = new System.Drawing.Point(305, 95);
            this.fld_lkeAPInvoiceInType.Name = "fld_lkeAPInvoiceInType";
            this.fld_lkeAPInvoiceInType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInType.Properties.ColumnName = null;
            this.fld_lkeAPInvoiceInType.Properties.NullText = "";
            this.fld_lkeAPInvoiceInType.Properties.PopupWidth = 40;
            this.fld_lkeAPInvoiceInType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPInvoiceInType, true);
            this.fld_lkeAPInvoiceInType.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeAPInvoiceInType.TabIndex = 13;
            this.fld_lkeAPInvoiceInType.Tag = "DC";
            this.fld_lkeAPInvoiceInType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPInvoiceInType_CloseUp);
            this.fld_lkeAPInvoiceInType.EditValueChanged += new System.EventHandler(this.fld_lkeAPInvoiceInType_EditValueChanged);
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
            this.bosLabel9.Location = new System.Drawing.Point(222, 72);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(52, 13);
            this.bosLabel9.TabIndex = 11;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Mã lô hàng";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
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
            this.bosLabel17.Location = new System.Drawing.Point(222, 98);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(69, 13);
            this.bosLabel17.TabIndex = 363;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Loại đơn hàng";
            // 
            // fld_txtAPInvoiceInPackingList
            // 
            this.fld_txtAPInvoiceInPackingList.BOSComment = "";
            this.fld_txtAPInvoiceInPackingList.BOSDataMember = "APInvoiceInPackingList";
            this.fld_txtAPInvoiceInPackingList.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInPackingList.BOSDescription = null;
            this.fld_txtAPInvoiceInPackingList.BOSError = null;
            this.fld_txtAPInvoiceInPackingList.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInPackingList.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInPackingList.BOSPrivilege = "";
            this.fld_txtAPInvoiceInPackingList.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInPackingList.EditValue = "";
            this.fld_txtAPInvoiceInPackingList.Location = new System.Drawing.Point(512, 43);
            this.fld_txtAPInvoiceInPackingList.Name = "fld_txtAPInvoiceInPackingList";
            this.fld_txtAPInvoiceInPackingList.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInPackingList.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInPackingList.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInPackingList.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInPackingList.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInPackingList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInPackingList.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPInvoiceInPackingList, true);
            this.fld_txtAPInvoiceInPackingList.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInPackingList.TabIndex = 6;
            this.fld_txtAPInvoiceInPackingList.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel19.Location = new System.Drawing.Point(429, 46);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(30, 13);
            this.bosLabel19.TabIndex = 360;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Số P/L";
            // 
            // fld_txtAPInvoiceInTotalQuantity
            // 
            this.fld_txtAPInvoiceInTotalQuantity.BOSComment = "";
            this.fld_txtAPInvoiceInTotalQuantity.BOSDataMember = "APInvoiceInTotalQuantity";
            this.fld_txtAPInvoiceInTotalQuantity.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInTotalQuantity.BOSDescription = null;
            this.fld_txtAPInvoiceInTotalQuantity.BOSError = null;
            this.fld_txtAPInvoiceInTotalQuantity.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInTotalQuantity.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInTotalQuantity.BOSPrivilege = "";
            this.fld_txtAPInvoiceInTotalQuantity.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInTotalQuantity.EditValue = "";
            this.fld_txtAPInvoiceInTotalQuantity.Location = new System.Drawing.Point(512, 17);
            this.fld_txtAPInvoiceInTotalQuantity.Name = "fld_txtAPInvoiceInTotalQuantity";
            this.fld_txtAPInvoiceInTotalQuantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInTotalQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInTotalQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInTotalQuantity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInTotalQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInTotalQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInTotalQuantity.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPInvoiceInTotalQuantity, true);
            this.fld_txtAPInvoiceInTotalQuantity.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInTotalQuantity.TabIndex = 2;
            this.fld_txtAPInvoiceInTotalQuantity.Tag = "DC";
            // 
            // fld_txtAPInvoiceInExchangeRate
            // 
            this.fld_txtAPInvoiceInExchangeRate.BOSComment = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSDataMember = "APInvoiceInExchangeRate";
            this.fld_txtAPInvoiceInExchangeRate.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInExchangeRate.BOSDescription = null;
            this.fld_txtAPInvoiceInExchangeRate.BOSError = null;
            this.fld_txtAPInvoiceInExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSPrivilege = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInExchangeRate.EditValue = "";
            this.fld_txtAPInvoiceInExchangeRate.Location = new System.Drawing.Point(92, 174);
            this.fld_txtAPInvoiceInExchangeRate.Name = "fld_txtAPInvoiceInExchangeRate";
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInExchangeRate.Screen = null;
            this.fld_txtAPInvoiceInExchangeRate.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInExchangeRate.TabIndex = 23;
            this.fld_txtAPInvoiceInExchangeRate.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(429, 20);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(75, 13);
            this.bosLabel15.TabIndex = 358;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Khối lượng (m3)";
            // 
            // fld_txtAPInvoiceInRoundWoodQty
            // 
            this.fld_txtAPInvoiceInRoundWoodQty.BOSComment = "";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSDataMember = "APInvoiceInRoundWoodQty";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSDescription = null;
            this.fld_txtAPInvoiceInRoundWoodQty.BOSError = null;
            this.fld_txtAPInvoiceInRoundWoodQty.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSPrivilege = "";
            this.fld_txtAPInvoiceInRoundWoodQty.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInRoundWoodQty.EditValue = "";
            this.fld_txtAPInvoiceInRoundWoodQty.Location = new System.Drawing.Point(729, 18);
            this.fld_txtAPInvoiceInRoundWoodQty.Name = "fld_txtAPInvoiceInRoundWoodQty";
            this.fld_txtAPInvoiceInRoundWoodQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInRoundWoodQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInRoundWoodQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInRoundWoodQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInRoundWoodQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInRoundWoodQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInRoundWoodQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPInvoiceInRoundWoodQty, true);
            this.fld_txtAPInvoiceInRoundWoodQty.Size = new System.Drawing.Size(118, 20);
            this.fld_txtAPInvoiceInRoundWoodQty.TabIndex = 3;
            this.fld_txtAPInvoiceInRoundWoodQty.Tag = "DC";
            // 
            // fld_txtAPInvoiceInPackNo
            // 
            this.fld_txtAPInvoiceInPackNo.BOSComment = "";
            this.fld_txtAPInvoiceInPackNo.BOSDataMember = "APInvoiceInPackNo";
            this.fld_txtAPInvoiceInPackNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInPackNo.BOSDescription = null;
            this.fld_txtAPInvoiceInPackNo.BOSError = null;
            this.fld_txtAPInvoiceInPackNo.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInPackNo.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInPackNo.BOSPrivilege = "";
            this.fld_txtAPInvoiceInPackNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInPackNo.EditValue = "";
            this.fld_txtAPInvoiceInPackNo.Location = new System.Drawing.Point(305, 69);
            this.fld_txtAPInvoiceInPackNo.Name = "fld_txtAPInvoiceInPackNo";
            this.fld_txtAPInvoiceInPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInPackNo.Screen = null;
            this.fld_txtAPInvoiceInPackNo.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInPackNo.TabIndex = 9;
            this.fld_txtAPInvoiceInPackNo.Tag = "DC";
            this.fld_txtAPInvoiceInPackNo.Validated += new System.EventHandler(this.fld_txtAPInvoiceInPackNo_Validated);
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
            this.bosLabel18.Location = new System.Drawing.Point(631, 20);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(38, 13);
            this.bosLabel18.TabIndex = 357;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Tổng SL";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(92, 147);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 20;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            this.fld_lkeFK_GECurrencyID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_GECurrencyID_Closed);
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = false;
            this.fld_lkeFK_GECountryID.BOSComment = null;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID.BOSFieldParent = null;
            this.fld_lkeFK_GECountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = "";
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(729, 96);
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Xuất xứ")});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = "";
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID, true);
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 15;
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.Validated += new System.EventHandler(this.fld_lkeFK_GECountryID_Validated);
            // 
            // bosLabel23
            // 
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(631, 98);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(38, 13);
            this.bosLabel23.TabIndex = 355;
            this.bosLabel23.Text = "Xuất xứ";
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
            this.bosLabel10.Location = new System.Drawing.Point(5, 150);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(53, 13);
            this.bosLabel10.TabIndex = 17;
            this.bosLabel10.Text = "Loại tiền tệ";
            // 
            // fld_txtAPInvoiceInLogListNo
            // 
            this.fld_txtAPInvoiceInLogListNo.BOSComment = "";
            this.fld_txtAPInvoiceInLogListNo.BOSDataMember = "APInvoiceInLogListNo";
            this.fld_txtAPInvoiceInLogListNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInLogListNo.BOSDescription = null;
            this.fld_txtAPInvoiceInLogListNo.BOSError = null;
            this.fld_txtAPInvoiceInLogListNo.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInLogListNo.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInLogListNo.BOSPrivilege = "";
            this.fld_txtAPInvoiceInLogListNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInLogListNo.EditValue = "";
            this.fld_txtAPInvoiceInLogListNo.Location = new System.Drawing.Point(512, 95);
            this.fld_txtAPInvoiceInLogListNo.Name = "fld_txtAPInvoiceInLogListNo";
            this.fld_txtAPInvoiceInLogListNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInLogListNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInLogListNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInLogListNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInLogListNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInLogListNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInLogListNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPInvoiceInLogListNo, true);
            this.fld_txtAPInvoiceInLogListNo.Size = new System.Drawing.Size(106, 20);
            this.fld_txtAPInvoiceInLogListNo.TabIndex = 14;
            this.fld_txtAPInvoiceInLogListNo.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(5, 124);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(48, 13);
            this.bosLabel14.TabIndex = 17;
            this.bosLabel14.Text = "Chi nhánh";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(429, 98);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(45, 13);
            this.bosLabel16.TabIndex = 46;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Số log list";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(5, 176);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(29, 13);
            this.bosLabel11.TabIndex = 19;
            this.bosLabel11.Text = "Tỷ giá";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(92, 121);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 16;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = "";
            this.bosLine3.BOSDataMember = "";
            this.bosLine3.BOSDataSource = "";
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = "";
            this.bosLine3.BOSFieldRelation = "";
            this.bosLine3.BOSPrivilege = "";
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosLine3.Controls.Add(this.bosLabel2);
            this.bosLine3.Controls.Add(this.fld_lblLabel26);
            this.bosLine3.Controls.Add(this.fld_dteARInvoiceDate);
            this.bosLine3.Controls.Add(this.bosLabel25);
            this.bosLine3.Controls.Add(this.bosLabel26);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATInvoiceNo);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATSymbol);
            this.bosLine3.Controls.Add(this.bosLabel22);
            this.bosLine3.Controls.Add(this.fld_lkeAPInputVATDocumentType);
            this.bosLine3.Controls.Add(this.bosLabel24);
            this.bosLine3.Controls.Add(this.fld_txtARInvoiceVATFormNo);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(108, 8);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(210, 205);
            this.bosLine3.TabIndex = 0;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin VAT";
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDescription = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSError = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectType = "ACEInvoiceTypeCombo";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectTypeValue = "Purchase";
            this.fld_lkeFK_ACEInvoiceTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(97, 142);
            this.fld_lkeFK_ACEInvoiceTypeID.Name = "fld_lkeFK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT")});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.DisplayMember = "ACEInvoiceTypeNo";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.NullText = "";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ValueMember = "ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Screen = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 5;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEInvoiceTypeID_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(6, 145);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(85, 13);
            this.bosLabel2.TabIndex = 93;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã hóa đơn GTGT";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(6, 120);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel26.TabIndex = 89;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Ngày hóa đơn";
            // 
            // fld_dteARInvoiceDate
            // 
            this.fld_dteARInvoiceDate.BOSComment = "";
            this.fld_dteARInvoiceDate.BOSDataMember = "APInvoiceInVATDate";
            this.fld_dteARInvoiceDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteARInvoiceDate.BOSDescription = null;
            this.fld_dteARInvoiceDate.BOSError = null;
            this.fld_dteARInvoiceDate.BOSFieldGroup = "";
            this.fld_dteARInvoiceDate.BOSFieldRelation = "";
            this.fld_dteARInvoiceDate.BOSPrivilege = "";
            this.fld_dteARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteARInvoiceDate.EditValue = null;
            this.fld_dteARInvoiceDate.Location = new System.Drawing.Point(97, 117);
            this.fld_dteARInvoiceDate.Name = "fld_dteARInvoiceDate";
            this.fld_dteARInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARInvoiceDate.Screen = null;
            this.fld_dteARInvoiceDate.Size = new System.Drawing.Size(106, 20);
            this.fld_dteARInvoiceDate.TabIndex = 4;
            this.fld_dteARInvoiceDate.Tag = "DC";
            this.fld_dteARInvoiceDate.Validated += new System.EventHandler(this.fld_dteARInvoiceDate_Validated);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(6, 66);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(35, 13);
            this.bosLabel25.TabIndex = 92;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Ký hiệu";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = "";
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = "";
            this.bosLabel26.BOSFieldRelation = "";
            this.bosLabel26.BOSPrivilege = "";
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(6, 94);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(54, 13);
            this.bosLabel26.TabIndex = 91;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Số hóa đơn";
            // 
            // fld_txtARInvoiceVATInvoiceNo
            // 
            this.fld_txtARInvoiceVATInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataMember = "APInvoiceInSupplierNo";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtARInvoiceVATInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATInvoiceNo.EditValue = "";
            this.fld_txtARInvoiceVATInvoiceNo.Location = new System.Drawing.Point(97, 91);
            this.fld_txtARInvoiceVATInvoiceNo.Name = "fld_txtARInvoiceVATInvoiceNo";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATInvoiceNo.Screen = null;
            this.fld_txtARInvoiceVATInvoiceNo.Size = new System.Drawing.Size(106, 20);
            this.fld_txtARInvoiceVATInvoiceNo.TabIndex = 3;
            this.fld_txtARInvoiceVATInvoiceNo.Tag = "DC";
            // 
            // fld_txtARInvoiceVATSymbol
            // 
            this.fld_txtARInvoiceVATSymbol.BOSComment = "";
            this.fld_txtARInvoiceVATSymbol.BOSDataMember = "APInvoiceInVATSymbol";
            this.fld_txtARInvoiceVATSymbol.BOSDataSource = "APInvoiceIns";
            this.fld_txtARInvoiceVATSymbol.BOSDescription = null;
            this.fld_txtARInvoiceVATSymbol.BOSError = null;
            this.fld_txtARInvoiceVATSymbol.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATSymbol.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATSymbol.BOSPrivilege = "";
            this.fld_txtARInvoiceVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATSymbol.EditValue = "";
            this.fld_txtARInvoiceVATSymbol.Location = new System.Drawing.Point(97, 65);
            this.fld_txtARInvoiceVATSymbol.Name = "fld_txtARInvoiceVATSymbol";
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATSymbol.Screen = null;
            this.fld_txtARInvoiceVATSymbol.Size = new System.Drawing.Size(106, 20);
            this.fld_txtARInvoiceVATSymbol.TabIndex = 2;
            this.fld_txtARInvoiceVATSymbol.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(6, 20);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(61, 13);
            this.bosLabel22.TabIndex = 79;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Loại hóa đơn";
            // 
            // fld_lkeAPInputVATDocumentType
            // 
            this.fld_lkeAPInputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeAPInputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeAPInputVATDocumentType.BOSComment = "";
            this.fld_lkeAPInputVATDocumentType.BOSDataMember = "APInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInputVATDocumentType.BOSDescription = null;
            this.fld_lkeAPInputVATDocumentType.BOSError = null;
            this.fld_lkeAPInputVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldParent = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeAPInputVATDocumentType.BOSPrivilege = "";
            this.fld_lkeAPInputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInputVATDocumentType.BOSSelectType = "";
            this.fld_lkeAPInputVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeAPInputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeAPInputVATDocumentType.Location = new System.Drawing.Point(97, 13);
            this.fld_lkeAPInputVATDocumentType.Name = "fld_lkeAPInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInputVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeAPInputVATDocumentType.Properties.NullText = "";
            this.fld_lkeAPInputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInputVATDocumentType.Screen = null;
            this.fld_lkeAPInputVATDocumentType.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeAPInputVATDocumentType.TabIndex = 0;
            this.fld_lkeAPInputVATDocumentType.Tag = "DC";
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
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(6, 42);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(34, 13);
            this.bosLabel24.TabIndex = 80;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Mẫu số";
            // 
            // fld_txtARInvoiceVATFormNo
            // 
            this.fld_txtARInvoiceVATFormNo.BOSComment = "";
            this.fld_txtARInvoiceVATFormNo.BOSDataMember = "APInvoiceInVATFormNo";
            this.fld_txtARInvoiceVATFormNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtARInvoiceVATFormNo.BOSDescription = null;
            this.fld_txtARInvoiceVATFormNo.BOSError = null;
            this.fld_txtARInvoiceVATFormNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceVATFormNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceVATFormNo.BOSPrivilege = "";
            this.fld_txtARInvoiceVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtARInvoiceVATFormNo.EditValue = "";
            this.fld_txtARInvoiceVATFormNo.Location = new System.Drawing.Point(97, 39);
            this.fld_txtARInvoiceVATFormNo.Name = "fld_txtARInvoiceVATFormNo";
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtARInvoiceVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceVATFormNo.Screen = null;
            this.fld_txtARInvoiceVATFormNo.Size = new System.Drawing.Size(106, 20);
            this.fld_txtARInvoiceVATFormNo.TabIndex = 1;
            this.fld_txtARInvoiceVATFormNo.Tag = "DC";
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
            this.bosLine1.Controls.Add(this.fld_medAPInvoiceInComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 521);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(290, 173);
            this.bosLine1.TabIndex = 3;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medAPInvoiceInComment
            // 
            this.fld_medAPInvoiceInComment.BOSComment = null;
            this.fld_medAPInvoiceInComment.BOSDataMember = "APInvoiceInComment";
            this.fld_medAPInvoiceInComment.BOSDataSource = "APInvoiceIns";
            this.fld_medAPInvoiceInComment.BOSDescription = null;
            this.fld_medAPInvoiceInComment.BOSError = null;
            this.fld_medAPInvoiceInComment.BOSFieldGroup = null;
            this.fld_medAPInvoiceInComment.BOSFieldRelation = null;
            this.fld_medAPInvoiceInComment.BOSPrivilege = null;
            this.fld_medAPInvoiceInComment.BOSPropertyName = "Text";
            this.fld_medAPInvoiceInComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medAPInvoiceInComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medAPInvoiceInComment.MenuManager = this.screenToolbar;
            this.fld_medAPInvoiceInComment.Name = "fld_medAPInvoiceInComment";
            this.fld_medAPInvoiceInComment.Screen = null;
            this.fld_medAPInvoiceInComment.Size = new System.Drawing.Size(284, 153);
            this.fld_medAPInvoiceInComment.TabIndex = 0;
            this.fld_medAPInvoiceInComment.Tag = "DC";
            // 
            // fld_tabInvoiceInItems
            // 
            this.fld_tabInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabInvoiceInItems.BOSComment = null;
            this.fld_tabInvoiceInItems.BOSDataMember = null;
            this.fld_tabInvoiceInItems.BOSDataSource = null;
            this.fld_tabInvoiceInItems.BOSDescription = null;
            this.fld_tabInvoiceInItems.BOSError = null;
            this.fld_tabInvoiceInItems.BOSFieldGroup = null;
            this.fld_tabInvoiceInItems.BOSFieldRelation = null;
            this.fld_tabInvoiceInItems.BOSPrivilege = null;
            this.fld_tabInvoiceInItems.BOSPropertyName = null;
            this.fld_tabInvoiceInItems.Location = new System.Drawing.Point(3, 219);
            this.fld_tabInvoiceInItems.Name = "fld_tabInvoiceInItems";
            this.fld_tabInvoiceInItems.Screen = null;
            this.fld_tabInvoiceInItems.SelectedTabPage = this.fld_tabPageInvoiceInItems;
            this.fld_tabInvoiceInItems.Size = new System.Drawing.Size(1227, 296);
            this.fld_tabInvoiceInItems.TabIndex = 2;
            this.fld_tabInvoiceInItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceInItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageInvoiceInItems
            // 
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_dgcAPInvoiceInItems);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_Lablel);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_pteAPInvoiceInItemProductPicture);
            this.fld_tabPageInvoiceInItems.Name = "fld_tabPageInvoiceInItems";
            this.fld_tabPageInvoiceInItems.Size = new System.Drawing.Size(1225, 271);
            this.fld_tabPageInvoiceInItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcAPInvoiceInItems
            // 
            this.fld_dgcAPInvoiceInItems.AllowDrop = true;
            this.fld_dgcAPInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPInvoiceInItems.BOSComment = "";
            this.fld_dgcAPInvoiceInItems.BOSDataMember = "";
            this.fld_dgcAPInvoiceInItems.BOSDataSource = "APInvoiceInItems";
            this.fld_dgcAPInvoiceInItems.BOSDescription = null;
            this.fld_dgcAPInvoiceInItems.BOSError = null;
            this.fld_dgcAPInvoiceInItems.BOSFieldGroup = "";
            this.fld_dgcAPInvoiceInItems.BOSFieldRelation = "";
            this.fld_dgcAPInvoiceInItems.BOSGridType = null;
            this.fld_dgcAPInvoiceInItems.BOSPrivilege = "";
            this.fld_dgcAPInvoiceInItems.BOSPropertyName = "";
            this.fld_dgcAPInvoiceInItems.CommodityType = "";
            this.fld_dgcAPInvoiceInItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPInvoiceInItems.Location = new System.Drawing.Point(8, 35);
            this.fld_dgcAPInvoiceInItems.MainView = this.fld_dgvARInvoiceIns;
            this.fld_dgcAPInvoiceInItems.Name = "fld_dgcAPInvoiceInItems";
            this.fld_dgcAPInvoiceInItems.PrintReport = false;
            this.fld_dgcAPInvoiceInItems.Screen = null;
            this.fld_dgcAPInvoiceInItems.Size = new System.Drawing.Size(1068, 233);
            this.fld_dgcAPInvoiceInItems.TabIndex = 3;
            this.fld_dgcAPInvoiceInItems.Tag = "DC";
            this.fld_dgcAPInvoiceInItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoiceIns});
            // 
            // fld_dgvARInvoiceIns
            // 
            this.fld_dgvARInvoiceIns.GridControl = this.fld_dgcAPInvoiceInItems;
            this.fld_dgvARInvoiceIns.Name = "fld_dgvARInvoiceIns";
            this.fld_dgvARInvoiceIns.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "APInvoiceInItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(60, 9);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(1016, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_Lablel.BOSPropertyName = "";
            this.fld_Lablel.Location = new System.Drawing.Point(7, 12);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 0;
            this.fld_Lablel.Tag = "";
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_pteAPInvoiceInItemProductPicture
            // 
            this.fld_pteAPInvoiceInItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPInvoiceInItemProductPicture.BOSComment = "";
            this.fld_pteAPInvoiceInItemProductPicture.BOSDataMember = "APInvoiceInItemProductPicture";
            this.fld_pteAPInvoiceInItemProductPicture.BOSDataSource = "APInvoiceIns";
            this.fld_pteAPInvoiceInItemProductPicture.BOSDescription = null;
            this.fld_pteAPInvoiceInItemProductPicture.BOSError = null;
            this.fld_pteAPInvoiceInItemProductPicture.BOSFieldGroup = "";
            this.fld_pteAPInvoiceInItemProductPicture.BOSFieldRelation = "";
            this.fld_pteAPInvoiceInItemProductPicture.BOSPrivilege = "";
            this.fld_pteAPInvoiceInItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPInvoiceInItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPInvoiceInItemProductPicture.EditValue = "";
            this.fld_pteAPInvoiceInItemProductPicture.FileName = null;
            this.fld_pteAPInvoiceInItemProductPicture.FilePath = null;
            this.fld_pteAPInvoiceInItemProductPicture.Location = new System.Drawing.Point(1082, 3);
            this.fld_pteAPInvoiceInItemProductPicture.Name = "fld_pteAPInvoiceInItemProductPicture";
            this.fld_pteAPInvoiceInItemProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPInvoiceInItemProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPInvoiceInItemProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPInvoiceInItemProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPInvoiceInItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPInvoiceInItemProductPicture.Screen = null;
            this.fld_pteAPInvoiceInItemProductPicture.Size = new System.Drawing.Size(140, 140);
            this.fld_pteAPInvoiceInItemProductPicture.TabIndex = 2;
            this.fld_pteAPInvoiceInItemProductPicture.Tag = "DC";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1211, 264);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1211, 264);
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
            // bosLabel13
            // 
            this.bosLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
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
            this.bosLabel13.Location = new System.Drawing.Point(955, 709);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(61, 17);
            this.bosLabel13.TabIndex = 41;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "CÒN LẠI";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
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
            this.bosLabel12.Location = new System.Drawing.Point(955, 683);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(54, 17);
            this.bosLabel12.TabIndex = 39;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "ĐÃ TRẢ";
            // 
            // fld_txtAPInvoiceInBalanceDue
            // 
            this.fld_txtAPInvoiceInBalanceDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInBalanceDue.BOSComment = "";
            this.fld_txtAPInvoiceInBalanceDue.BOSDataMember = "APInvoiceInBalanceDue";
            this.fld_txtAPInvoiceInBalanceDue.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInBalanceDue.BOSDescription = null;
            this.fld_txtAPInvoiceInBalanceDue.BOSError = null;
            this.fld_txtAPInvoiceInBalanceDue.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInBalanceDue.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInBalanceDue.BOSPrivilege = "";
            this.fld_txtAPInvoiceInBalanceDue.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInBalanceDue.EditValue = "";
            this.fld_txtAPInvoiceInBalanceDue.Location = new System.Drawing.Point(1053, 708);
            this.fld_txtAPInvoiceInBalanceDue.Name = "fld_txtAPInvoiceInBalanceDue";
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPInvoiceInBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInBalanceDue.Properties.Mask.EditMask = "n";
            this.fld_txtAPInvoiceInBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPInvoiceInBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInBalanceDue.Properties.ReadOnly = true;
            this.fld_txtAPInvoiceInBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInBalanceDue.Screen = null;
            this.fld_txtAPInvoiceInBalanceDue.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInBalanceDue.TabIndex = 14;
            this.fld_txtAPInvoiceInBalanceDue.Tag = "DC";
            // 
            // fld_txtAPInvoiceInDepositBalance
            // 
            this.fld_txtAPInvoiceInDepositBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPInvoiceInDepositBalance.BOSComment = "";
            this.fld_txtAPInvoiceInDepositBalance.BOSDataMember = "APInvoiceInDepositBalance";
            this.fld_txtAPInvoiceInDepositBalance.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInDepositBalance.BOSDescription = null;
            this.fld_txtAPInvoiceInDepositBalance.BOSError = null;
            this.fld_txtAPInvoiceInDepositBalance.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInDepositBalance.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInDepositBalance.BOSPrivilege = "";
            this.fld_txtAPInvoiceInDepositBalance.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInDepositBalance.EditValue = "";
            this.fld_txtAPInvoiceInDepositBalance.Location = new System.Drawing.Point(1053, 682);
            this.fld_txtAPInvoiceInDepositBalance.Name = "fld_txtAPInvoiceInDepositBalance";
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPInvoiceInDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInDepositBalance.Properties.Mask.EditMask = "n";
            this.fld_txtAPInvoiceInDepositBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPInvoiceInDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInDepositBalance.Screen = null;
            this.fld_txtAPInvoiceInDepositBalance.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPInvoiceInDepositBalance.TabIndex = 13;
            this.fld_txtAPInvoiceInDepositBalance.Tag = "DC";
            this.fld_txtAPInvoiceInDepositBalance.Validated += new System.EventHandler(this.fld_txtAPInvoiceInDepositBalance_Validated);
            // 
            // DMII100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1238, 743);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMII100.IconOptions.Icon")));
            this.Name = "DMII100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPInvoiceInDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInShippingFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInShippingExtraFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInValidateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInValidateDate.Properties)).EndInit();
            this.fld_Line2.ResumeLayout(false);
            this.fld_Line2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTaxAmount.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInChannel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInContractDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPInvoiceInContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInBillOfLanding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInPackingList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInTotalQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInRoundWoodQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInLogListNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceVATFormNo.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPInvoiceInComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).EndInit();
            this.fld_tabInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInItemProductPicture.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInDepositBalance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteAPInvoiceInEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInTaxPercent;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInTaxAmount;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInPackNo;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInBalanceDue;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInDepositBalance;
        private BOSComponent.BOSTabControl fld_tabInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceInItems;
        private BOSComponent.BOSLabel fld_Lablel;
        private BOSComponent.BOSPictureEdit fld_pteAPInvoiceInItemProductPicture;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medAPInvoiceInComment;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInLogListNo;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInRoundWoodQty;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInPackingList;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInTotalQuantity;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInBillOfLanding;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInType;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeAPInputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATFormNo;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSDateEdit fld_dteARInvoiceDate;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATInvoiceNo;
        private BOSComponent.BOSTextBox fld_txtARInvoiceVATSymbol;
        private GroupBox groupBox1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel2;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSDateEdit fld_dteAPInvoiceInContractDate;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInSupplierTaxNumber;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox bosTextBox2;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInChannel;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSERP.Modules.InvoiceIn.APInvoiceInItemsGridControl fld_dgcAPInvoiceInItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoiceIns;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInContractNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GETerminalID;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInProject;
    }
}
