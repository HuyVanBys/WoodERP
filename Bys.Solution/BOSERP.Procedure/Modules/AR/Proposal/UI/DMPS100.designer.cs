using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Proposal.UI
{
	/// <summary>
	/// Summary description for DMPS100
	/// </summary>
	partial class DMPS100
	{
        private BOSComponent.BOSPictureEdit fld_ptePictureEdit;
		private BOSComponent.BOSLabel fld_lblLabel13;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSLabel fld_lblLabel17;
		private BOSComponent.BOSLabel fld_lblLabel18;
		private BOSComponent.BOSLabel fld_lblLabel19;
		private BOSComponent.BOSDateEdit fld_dteARProposalDeliveryDate2;
        private BOSComponent.BOSDateEdit fld_dteARProposalValidateDate2;
        private BOSComponent.BOSLabel fld_lblLabel23;
		private BOSComponent.BOSLabel fld_lblLabel25;
		private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel27;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARProposalDiscountPerCent;
		private BOSComponent.BOSTextBox fld_txtARProposalDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARProposalTotalAmount;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPS100));
            this.fld_ptePictureEdit = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARProposalDeliveryDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARProposalValidateDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARProposalDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkChooseProspectCustomer = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_recARProposalDesc = new BOSComponent.BOSRichEditControl(this.components);
            this.fld_lkeARProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalProject = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalDiscountPerCentForItem = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAACreatedDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbPaymentTerm = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARProposalSaleType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalSOCommissionAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProposalCustomerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_bosTabControl = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pteARProposalItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARProposalItemsGridControl = new BOSERP.Modules.Proposal.ARProposalItemsGridControl();
            this.fld_dgvARProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnShowProductCollection = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARProposalPaymentTimes = new BOSERP.Modules.Proposal.ARProposalPaymentTimesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDSCP = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddCost = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARProposalItemCostGridControl = new BOSERP.Modules.Proposal.ARProposalItemCostsGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARProposalItemWorksGridControl = new BOSERP.Modules.Proposal.ARProposalItemWorksGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARProposalItemWorkMaterialsGridControl = new BOSERP.Modules.Proposal.ARProposalItemWorkMaterialsGridControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductAsset = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARProposalItemWorkAssetsGridControl = new BOSERP.Modules.Proposal.ARProposalItemWorkAssetsGridControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARProposalItemWorkTasksGridControl = new BOSERP.Modules.Proposal.ARProposalItemWorkTasksGridControl();
            this.fld_btnAddTask = new BOSComponent.BOSButton(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProposalPortOFDischarge = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeARProposalPortOFLoading = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARShippingType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalDeliveryDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalDeliveryDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalValidateDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalValidateDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalAmount.Properties)).BeginInit();
            this.BOSLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.BOSLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountPerCentForItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalSaleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalSOCommissionAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalCustomerCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bosTabControl)).BeginInit();
            this.fld_bosTabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProposalItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposalItems)).BeginInit();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabPageDSCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemCostGridControl)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorksGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkMaterialsGridControl)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkAssetsGridControl)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkTasksGridControl)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalPortOFDischarge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalPortOFLoading.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_ptePictureEdit
            // 
            this.fld_ptePictureEdit.BOSComment = "";
            this.fld_ptePictureEdit.BOSDataMember = "ARProposalEmployeePicture";
            this.fld_ptePictureEdit.BOSDataSource = "ARProposals";
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
            this.fld_ptePictureEdit.Location = new System.Drawing.Point(8, 8);
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
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(8, 19);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel16.TabIndex = 12;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Tên khách hàng";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(8, 70);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel17.TabIndex = 13;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "Hạn mức tín dụng";
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(8, 88);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(13, 13);
            this.fld_lblLabel18.TabIndex = 14;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Nợ";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel19.BOSPropertyName = null;
            this.fld_lblLabel19.Location = new System.Drawing.Point(8, 108);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(74, 13);
            this.fld_lblLabel19.TabIndex = 15;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Tín dụng còn lại";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(417, 92);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel13.TabIndex = 8;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Ngày bắt đầu";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(417, 118);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel14.TabIndex = 9;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Ngày hết hạn";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "";
            this.fld_lblLabel15.BOSDataSource = "";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = null;
            this.fld_lblLabel15.Location = new System.Drawing.Point(417, 144);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel15.TabIndex = 10;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tình trạng";
            // 
            // fld_dteARProposalDeliveryDate2
            // 
            this.fld_dteARProposalDeliveryDate2.BOSComment = "";
            this.fld_dteARProposalDeliveryDate2.BOSDataMember = "ARProposalDeliveryDate";
            this.fld_dteARProposalDeliveryDate2.BOSDataSource = "ARProposals";
            this.fld_dteARProposalDeliveryDate2.BOSDescription = null;
            this.fld_dteARProposalDeliveryDate2.BOSError = null;
            this.fld_dteARProposalDeliveryDate2.BOSFieldGroup = "";
            this.fld_dteARProposalDeliveryDate2.BOSFieldRelation = "";
            this.fld_dteARProposalDeliveryDate2.BOSPrivilege = "";
            this.fld_dteARProposalDeliveryDate2.BOSPropertyName = "EditValue";
            this.fld_dteARProposalDeliveryDate2.EditValue = null;
            this.fld_dteARProposalDeliveryDate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dteARProposalDeliveryDate2.Location = new System.Drawing.Point(519, 89);
            this.fld_dteARProposalDeliveryDate2.Name = "fld_dteARProposalDeliveryDate2";
            this.fld_dteARProposalDeliveryDate2.Properties.AllowFocused = false;
            this.fld_dteARProposalDeliveryDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARProposalDeliveryDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARProposalDeliveryDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARProposalDeliveryDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARProposalDeliveryDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProposalDeliveryDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProposalDeliveryDate2.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.fld_dteARProposalDeliveryDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteARProposalDeliveryDate2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.fld_dteARProposalDeliveryDate2.Screen = null;
            this.fld_dteARProposalDeliveryDate2.Size = new System.Drawing.Size(135, 20);
            this.fld_dteARProposalDeliveryDate2.TabIndex = 5;
            this.fld_dteARProposalDeliveryDate2.Tag = "DC";
            // 
            // fld_dteARProposalValidateDate2
            // 
            this.fld_dteARProposalValidateDate2.BOSComment = "";
            this.fld_dteARProposalValidateDate2.BOSDataMember = "ARProposalValidateDate";
            this.fld_dteARProposalValidateDate2.BOSDataSource = "ARProposals";
            this.fld_dteARProposalValidateDate2.BOSDescription = null;
            this.fld_dteARProposalValidateDate2.BOSError = null;
            this.fld_dteARProposalValidateDate2.BOSFieldGroup = "";
            this.fld_dteARProposalValidateDate2.BOSFieldRelation = "";
            this.fld_dteARProposalValidateDate2.BOSPrivilege = "";
            this.fld_dteARProposalValidateDate2.BOSPropertyName = "EditValue";
            this.fld_dteARProposalValidateDate2.EditValue = null;
            this.fld_dteARProposalValidateDate2.Location = new System.Drawing.Point(519, 115);
            this.fld_dteARProposalValidateDate2.Name = "fld_dteARProposalValidateDate2";
            this.fld_dteARProposalValidateDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARProposalValidateDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARProposalValidateDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARProposalValidateDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARProposalValidateDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProposalValidateDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProposalValidateDate2.Screen = null;
            this.fld_dteARProposalValidateDate2.Size = new System.Drawing.Size(135, 20);
            this.fld_dteARProposalValidateDate2.TabIndex = 6;
            this.fld_dteARProposalValidateDate2.Tag = "DC";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = null;
            this.fld_lblLabel23.Location = new System.Drawing.Point(1338, 752);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel23.TabIndex = 31;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Mức giá";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(1325, 778);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel25.TabIndex = 33;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tổng cộng";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(1324, 830);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel26.TabIndex = 34;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Chiết khấu";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseFont = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(1283, 880);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(92, 17);
            this.fld_lblLabel27.TabIndex = 35;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "THÀNH TIỀN";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(8, 110);
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
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = "";
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARProposals";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = null;
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(1388, 749);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.NullText = "";
            this.fld_lkeFK_ARPriceLevelID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 21;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_txtARProposalDiscountPerCent
            // 
            this.fld_txtARProposalDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalDiscountPerCent.BOSComment = "";
            this.fld_txtARProposalDiscountPerCent.BOSDataMember = "ARProposalDiscountPerCent";
            this.fld_txtARProposalDiscountPerCent.BOSDataSource = "ARProposals";
            this.fld_txtARProposalDiscountPerCent.BOSDescription = null;
            this.fld_txtARProposalDiscountPerCent.BOSError = null;
            this.fld_txtARProposalDiscountPerCent.BOSFieldGroup = "Accept";
            this.fld_txtARProposalDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARProposalDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARProposalDiscountPerCent.BOSPropertyName = "Text";
            this.fld_txtARProposalDiscountPerCent.EditValue = "0.00";
            this.fld_txtARProposalDiscountPerCent.Location = new System.Drawing.Point(1388, 827);
            this.fld_txtARProposalDiscountPerCent.Name = "fld_txtARProposalDiscountPerCent";
            this.fld_txtARProposalDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalDiscountPerCent.Screen = null;
            this.fld_txtARProposalDiscountPerCent.Size = new System.Drawing.Size(65, 20);
            this.fld_txtARProposalDiscountPerCent.TabIndex = 25;
            this.fld_txtARProposalDiscountPerCent.Tag = "DC";
            this.fld_txtARProposalDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARProposalDiscountPerCent_Validated);
            // 
            // fld_txtARProposalDiscountFix
            // 
            this.fld_txtARProposalDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalDiscountFix.BOSComment = "";
            this.fld_txtARProposalDiscountFix.BOSDataMember = "ARProposalDiscountFix";
            this.fld_txtARProposalDiscountFix.BOSDataSource = "ARProposals";
            this.fld_txtARProposalDiscountFix.BOSDescription = null;
            this.fld_txtARProposalDiscountFix.BOSError = null;
            this.fld_txtARProposalDiscountFix.BOSFieldGroup = "Accept";
            this.fld_txtARProposalDiscountFix.BOSFieldRelation = "";
            this.fld_txtARProposalDiscountFix.BOSPrivilege = "";
            this.fld_txtARProposalDiscountFix.BOSPropertyName = "Text";
            this.fld_txtARProposalDiscountFix.EditValue = "0.00";
            this.fld_txtARProposalDiscountFix.Location = new System.Drawing.Point(1459, 827);
            this.fld_txtARProposalDiscountFix.Name = "fld_txtARProposalDiscountFix";
            this.fld_txtARProposalDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalDiscountFix.Screen = null;
            this.fld_txtARProposalDiscountFix.Size = new System.Drawing.Size(112, 20);
            this.fld_txtARProposalDiscountFix.TabIndex = 26;
            this.fld_txtARProposalDiscountFix.Tag = "DC";
            this.fld_txtARProposalDiscountFix.Modified += new System.EventHandler(this.fld_txtARProposalDiscountFix_Modified);
            this.fld_txtARProposalDiscountFix.Validated += new System.EventHandler(this.fld_txtARProposalDiscountFix_Validated);
            // 
            // fld_txtARProposalTotalAmount
            // 
            this.fld_txtARProposalTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalTotalAmount.BOSComment = "";
            this.fld_txtARProposalTotalAmount.BOSDataMember = "ARProposalTotalAmount";
            this.fld_txtARProposalTotalAmount.BOSDataSource = "ARProposals";
            this.fld_txtARProposalTotalAmount.BOSDescription = null;
            this.fld_txtARProposalTotalAmount.BOSError = null;
            this.fld_txtARProposalTotalAmount.BOSFieldGroup = "";
            this.fld_txtARProposalTotalAmount.BOSFieldRelation = "";
            this.fld_txtARProposalTotalAmount.BOSPrivilege = "";
            this.fld_txtARProposalTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARProposalTotalAmount.Location = new System.Drawing.Point(1388, 879);
            this.fld_txtARProposalTotalAmount.Name = "fld_txtARProposalTotalAmount";
            this.fld_txtARProposalTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARProposalTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARProposalTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARProposalTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARProposalTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalTotalAmount.Screen = null;
            this.fld_txtARProposalTotalAmount.Size = new System.Drawing.Size(183, 20);
            this.fld_txtARProposalTotalAmount.TabIndex = 29;
            this.fld_txtARProposalTotalAmount.Tag = "DC";
            // 
            // BOSLine1
            // 
            this.BOSLine1.BOSComment = null;
            this.BOSLine1.BOSDataMember = null;
            this.BOSLine1.BOSDataSource = null;
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = null;
            this.BOSLine1.BOSFieldRelation = null;
            this.BOSLine1.BOSPrivilege = null;
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Controls.Add(this.bosTextBox2);
            this.BOSLine1.Controls.Add(this.fld_lnkChooseProspectCustomer);
            this.BOSLine1.Controls.Add(this.bosLabel8);
            this.BOSLine1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.BOSLine1.Controls.Add(this.BOSLabel3);
            this.BOSLine1.Controls.Add(this.BOSLabel2);
            this.BOSLine1.Controls.Add(this.BOSLabel1);
            this.BOSLine1.Controls.Add(this.fld_lblLabel19);
            this.BOSLine1.Controls.Add(this.fld_lblLabel16);
            this.BOSLine1.Controls.Add(this.fld_lblLabel18);
            this.BOSLine1.Controls.Add(this.fld_lblLabel17);
            this.BOSLine1.Location = new System.Drawing.Point(124, 8);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(279, 127);
            this.BOSLine1.TabIndex = 2;
            this.BOSLine1.TabStop = false;
            this.BOSLine1.Text = "Thông tin khách hàng";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARProposalProspectCustomer";
            this.bosTextBox2.BOSDataSource = "ARProposals";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(111, 42);
            this.bosTextBox2.MenuManager = this.screenToolbar;
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(151, 20);
            this.bosTextBox2.TabIndex = 1;
            this.bosTextBox2.Tag = "DC";
            // 
            // fld_lnkChooseProspectCustomer
            // 
            this.fld_lnkChooseProspectCustomer.EditValue = "Chọn KH tiềm năng";
            this.fld_lnkChooseProspectCustomer.Location = new System.Drawing.Point(8, 43);
            this.fld_lnkChooseProspectCustomer.Name = "fld_lnkChooseProspectCustomer";
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkChooseProspectCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkChooseProspectCustomer.Size = new System.Drawing.Size(97, 18);
            this.fld_lnkChooseProspectCustomer.TabIndex = 563;
            this.fld_lnkChooseProspectCustomer.TabStop = false;
            this.fld_lnkChooseProspectCustomer.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkChooseProspectCustomer_OpenLink);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(265, 14);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(6, 13);
            this.bosLabel8.TabIndex = 59;
            this.bosLabel8.Text = "*";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARProposals";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(111, 16);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 0;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = "ACObjectAvailableCredit";
            this.BOSLabel3.BOSDataSource = "ACObjects";
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(142, 108);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel3.TabIndex = 4;
            this.BOSLabel3.Text = "0";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = "ACObjectCreditOwing";
            this.BOSLabel2.BOSDataSource = "ACObjects";
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(142, 89);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel2.TabIndex = 3;
            this.BOSLabel2.Text = "0";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = "ACObjectCreditLimit";
            this.BOSLabel1.BOSDataSource = "ACObjects";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = "";
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(142, 70);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel1.TabIndex = 2;
            this.BOSLabel1.Text = "0";
            // 
            // BOSLine2
            // 
            this.BOSLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLine2.BOSComment = null;
            this.BOSLine2.BOSDataMember = null;
            this.BOSLine2.BOSDataSource = null;
            this.BOSLine2.BOSDescription = null;
            this.BOSLine2.BOSError = null;
            this.BOSLine2.BOSFieldGroup = null;
            this.BOSLine2.BOSFieldRelation = null;
            this.BOSLine2.BOSPrivilege = null;
            this.BOSLine2.BOSPropertyName = null;
            this.BOSLine2.Controls.Add(this.fld_recARProposalDesc);
            this.BOSLine2.Location = new System.Drawing.Point(8, 744);
            this.BOSLine2.Name = "BOSLine2";
            this.BOSLine2.Screen = null;
            this.BOSLine2.Size = new System.Drawing.Size(1188, 283);
            this.BOSLine2.TabIndex = 20;
            this.BOSLine2.TabStop = false;
            this.BOSLine2.Text = "Ghi chú";
            // 
            // fld_recARProposalDesc
            // 
            this.fld_recARProposalDesc.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARProposalDesc.BOSComment = null;
            this.fld_recARProposalDesc.BOSDataMember = null;
            this.fld_recARProposalDesc.BOSDataSource = null;
            this.fld_recARProposalDesc.BOSDescription = null;
            this.fld_recARProposalDesc.BOSError = null;
            this.fld_recARProposalDesc.BOSFieldGroup = null;
            this.fld_recARProposalDesc.BOSFieldRelation = null;
            this.fld_recARProposalDesc.BOSPrivilege = null;
            this.fld_recARProposalDesc.BOSPropertyName = null;
            this.fld_recARProposalDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_recARProposalDesc.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARProposalDesc.Location = new System.Drawing.Point(3, 17);
            this.fld_recARProposalDesc.MenuManager = this.screenToolbar;
            this.fld_recARProposalDesc.Name = "fld_recARProposalDesc";
            this.fld_recARProposalDesc.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARProposalDesc.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARProposalDesc.Screen = null;
            this.fld_recARProposalDesc.Size = new System.Drawing.Size(1182, 263);
            this.fld_recARProposalDesc.TabIndex = 1;
            this.fld_recARProposalDesc.Tag = "DC";
            // 
            // fld_lkeARProposalStatus
            // 
            this.fld_lkeARProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeARProposalStatus.BOSAllowDummy = false;
            this.fld_lkeARProposalStatus.BOSComment = null;
            this.fld_lkeARProposalStatus.BOSDataMember = "ARProposalStatus";
            this.fld_lkeARProposalStatus.BOSDataSource = "ARProposals";
            this.fld_lkeARProposalStatus.BOSDescription = null;
            this.fld_lkeARProposalStatus.BOSError = null;
            this.fld_lkeARProposalStatus.BOSFieldGroup = null;
            this.fld_lkeARProposalStatus.BOSFieldParent = null;
            this.fld_lkeARProposalStatus.BOSFieldRelation = null;
            this.fld_lkeARProposalStatus.BOSPrivilege = null;
            this.fld_lkeARProposalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARProposalStatus.BOSSelectType = null;
            this.fld_lkeARProposalStatus.BOSSelectTypeValue = null;
            this.fld_lkeARProposalStatus.CurrentDisplayText = null;
            this.fld_lkeARProposalStatus.Location = new System.Drawing.Point(519, 141);
            this.fld_lkeARProposalStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARProposalStatus.Name = "fld_lkeARProposalStatus";
            this.fld_lkeARProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProposalStatus.Properties.ColumnName = null;
            this.fld_lkeARProposalStatus.Properties.NullText = "";
            this.fld_lkeARProposalStatus.Properties.ReadOnly = true;
            this.fld_lkeARProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProposalStatus.Screen = null;
            this.fld_lkeARProposalStatus.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeARProposalStatus.TabIndex = 7;
            this.fld_lkeARProposalStatus.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(417, 14);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(28, 13);
            this.bosLabel5.TabIndex = 58;
            this.bosLabel5.Text = "Mã số";
            // 
            // fld_txtARProposalNo1
            // 
            this.fld_txtARProposalNo1.BOSComment = null;
            this.fld_txtARProposalNo1.BOSDataMember = "ARProposalNo";
            this.fld_txtARProposalNo1.BOSDataSource = "ARProposals";
            this.fld_txtARProposalNo1.BOSDescription = null;
            this.fld_txtARProposalNo1.BOSError = null;
            this.fld_txtARProposalNo1.BOSFieldGroup = null;
            this.fld_txtARProposalNo1.BOSFieldRelation = null;
            this.fld_txtARProposalNo1.BOSPrivilege = null;
            this.fld_txtARProposalNo1.BOSPropertyName = "EditValue";
            this.fld_txtARProposalNo1.Location = new System.Drawing.Point(519, 12);
            this.fld_txtARProposalNo1.MenuManager = this.screenToolbar;
            this.fld_txtARProposalNo1.Name = "fld_txtARProposalNo1";
            this.fld_txtARProposalNo1.Screen = null;
            this.fld_txtARProposalNo1.Size = new System.Drawing.Size(135, 20);
            this.fld_txtARProposalNo1.TabIndex = 2;
            this.fld_txtARProposalNo1.Tag = "DC";
            // 
            // fld_txtARProposalProject
            // 
            this.fld_txtARProposalProject.BOSComment = null;
            this.fld_txtARProposalProject.BOSDataMember = "ARProposalProject";
            this.fld_txtARProposalProject.BOSDataSource = "ARProposals";
            this.fld_txtARProposalProject.BOSDescription = null;
            this.fld_txtARProposalProject.BOSError = null;
            this.fld_txtARProposalProject.BOSFieldGroup = null;
            this.fld_txtARProposalProject.BOSFieldRelation = null;
            this.fld_txtARProposalProject.BOSPrivilege = null;
            this.fld_txtARProposalProject.BOSPropertyName = "EditValue";
            this.fld_txtARProposalProject.Location = new System.Drawing.Point(1065, 141);
            this.fld_txtARProposalProject.Name = "fld_txtARProposalProject";
            this.fld_txtARProposalProject.Screen = null;
            this.fld_txtARProposalProject.Size = new System.Drawing.Size(135, 20);
            this.fld_txtARProposalProject.TabIndex = 18;
            this.fld_txtARProposalProject.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(942, 144);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(45, 13);
            this.bosLabel17.TabIndex = 840;
            this.bosLabel17.Text = "Mã dự án";
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
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(675, 144);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(79, 13);
            this.bosLabel16.TabIndex = 671;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Cách lấy đơn giá";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "ARProposalSourceSellingPriceMethod";
            this.bosLookupEdit2.BOSDataSource = "ARProposals";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(777, 141);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(135, 20);
            this.bosLookupEdit2.TabIndex = 13;
            this.bosLookupEdit2.Tag = "DC";
            this.bosLookupEdit2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit2_CloseUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.bosLabel12.Location = new System.Drawing.Point(914, 37);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(6, 13);
            this.bosLabel12.TabIndex = 669;
            this.bosLabel12.Text = "*";
            // 
            // bosLabel94
            // 
            this.bosLabel94.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel94.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel94.Appearance.Options.UseBackColor = true;
            this.bosLabel94.Appearance.Options.UseForeColor = true;
            this.bosLabel94.BOSComment = null;
            this.bosLabel94.BOSDataMember = null;
            this.bosLabel94.BOSDataSource = null;
            this.bosLabel94.BOSDescription = null;
            this.bosLabel94.BOSError = null;
            this.bosLabel94.BOSFieldGroup = null;
            this.bosLabel94.BOSFieldRelation = null;
            this.bosLabel94.BOSPrivilege = null;
            this.bosLabel94.BOSPropertyName = null;
            this.bosLabel94.Location = new System.Drawing.Point(942, 40);
            this.bosLabel94.Name = "bosLabel94";
            this.bosLabel94.Screen = null;
            this.bosLabel94.Size = new System.Drawing.Size(77, 13);
            this.bosLabel94.TabIndex = 668;
            this.bosLabel94.Text = "Phương thức TT";
            // 
            // fld_lkeFK_GECurrencyID2
            // 
            this.fld_lkeFK_GECurrencyID2.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID2.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID2.BOSComment = "";
            this.fld_lkeFK_GECurrencyID2.BOSDataMember = "FK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.BOSDataSource = "ARProposals";
            this.fld_lkeFK_GECurrencyID2.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID2.BOSError = null;
            this.fld_lkeFK_GECurrencyID2.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID2.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID2.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID2.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID2.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID2.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID2.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID2.Location = new System.Drawing.Point(1065, 89);
            this.fld_lkeFK_GECurrencyID2.Name = "fld_lkeFK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID2.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID2.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID2.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID2.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID2.Screen = null;
            this.fld_lkeFK_GECurrencyID2.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_GECurrencyID2.TabIndex = 16;
            this.fld_lkeFK_GECurrencyID2.Tag = "DC";
            this.fld_lkeFK_GECurrencyID2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit1_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARProposals";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(777, 89);
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
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 11;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel10.Location = new System.Drawing.Point(942, 118);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(38, 13);
            this.bosLabel10.TabIndex = 609;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Tỷ giá 2";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel14.Location = new System.Drawing.Point(675, 118);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(29, 13);
            this.bosLabel14.TabIndex = 609;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tỷ giá";
            // 
            // bosLabel4
            // 
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
            this.bosLabel4.Location = new System.Drawing.Point(942, 92);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(62, 13);
            this.bosLabel4.TabIndex = 609;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại tiền tệ 2";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel11.Location = new System.Drawing.Point(675, 92);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 609;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ARProposals";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = "";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(519, 37);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankCode", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 3;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARProposalExchangeRate2";
            this.bosTextBox5.BOSDataSource = "ARProposals";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(1065, 115);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.EditMask = "n";
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(135, 20);
            this.bosTextBox5.TabIndex = 17;
            this.bosTextBox5.Tag = "DC";
            this.bosTextBox5.Validated += new System.EventHandler(this.bosTextBox5_Validated);
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARProposalExchangeRate";
            this.bosTextBox4.BOSDataSource = "ARProposals";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(777, 115);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(135, 20);
            this.bosTextBox4.TabIndex = 12;
            this.bosTextBox4.Tag = "DC";
            this.bosTextBox4.Validated += new System.EventHandler(this.bosTextBox4_Validated);
            // 
            // fld_txtARProposalDiscountPerCentForItem
            // 
            this.fld_txtARProposalDiscountPerCentForItem.BOSComment = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSDataMember = "ARProposalDiscountPerCentForItem";
            this.fld_txtARProposalDiscountPerCentForItem.BOSDataSource = "ARProposals";
            this.fld_txtARProposalDiscountPerCentForItem.BOSDescription = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSError = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSFieldGroup = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSFieldRelation = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSPrivilege = null;
            this.fld_txtARProposalDiscountPerCentForItem.BOSPropertyName = "EditValue";
            this.fld_txtARProposalDiscountPerCentForItem.Location = new System.Drawing.Point(777, 63);
            this.fld_txtARProposalDiscountPerCentForItem.Name = "fld_txtARProposalDiscountPerCentForItem";
            this.fld_txtARProposalDiscountPerCentForItem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalDiscountPerCentForItem.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalDiscountPerCentForItem.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalDiscountPerCentForItem.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalDiscountPerCentForItem.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalDiscountPerCentForItem.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARProposalDiscountPerCentForItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalDiscountPerCentForItem.Screen = null;
            this.fld_txtARProposalDiscountPerCentForItem.Size = new System.Drawing.Size(135, 20);
            this.fld_txtARProposalDiscountPerCentForItem.TabIndex = 10;
            this.fld_txtARProposalDiscountPerCentForItem.Tag = "DC";
            this.fld_txtARProposalDiscountPerCentForItem.Validated += new System.EventHandler(this.Fld_txtARProposalDiscountPerCentForItem_Validated);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(675, 66);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(24, 13);
            this.bosLabel20.TabIndex = 601;
            this.bosLabel20.Text = "%CK";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(1203, 63);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(6, 13);
            this.bosLabel15.TabIndex = 584;
            this.bosLabel15.Text = "*";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.bosLabel13.Location = new System.Drawing.Point(1203, 11);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(6, 13);
            this.bosLabel13.TabIndex = 584;
            this.bosLabel13.Text = "*";
            // 
            // fld_dteAACreatedDate
            // 
            this.fld_dteAACreatedDate.BOSComment = null;
            this.fld_dteAACreatedDate.BOSDataMember = "AACreatedDate";
            this.fld_dteAACreatedDate.BOSDataSource = "ARProposals";
            this.fld_dteAACreatedDate.BOSDescription = null;
            this.fld_dteAACreatedDate.BOSError = null;
            this.fld_dteAACreatedDate.BOSFieldGroup = null;
            this.fld_dteAACreatedDate.BOSFieldRelation = null;
            this.fld_dteAACreatedDate.BOSPrivilege = null;
            this.fld_dteAACreatedDate.BOSPropertyName = "EditValue";
            this.fld_dteAACreatedDate.EditValue = new System.DateTime(2018, 9, 26, 10, 48, 0, 0);
            this.fld_dteAACreatedDate.Enabled = false;
            this.fld_dteAACreatedDate.Location = new System.Drawing.Point(519, 63);
            this.fld_dteAACreatedDate.Name = "fld_dteAACreatedDate";
            this.fld_dteAACreatedDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteAACreatedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAACreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAACreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.MaskSettings.Set("mask", "g");
            this.fld_dteAACreatedDate.Properties.ReadOnly = true;
            this.fld_dteAACreatedDate.Screen = null;
            this.fld_dteAACreatedDate.Size = new System.Drawing.Size(135, 20);
            this.fld_dteAACreatedDate.TabIndex = 4;
            this.fld_dteAACreatedDate.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.Options.UseBackColor = true;
            this.bosLabel41.Appearance.Options.UseForeColor = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(417, 66);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(44, 13);
            this.bosLabel41.TabIndex = 583;
            this.bosLabel41.Text = "Ngày tạo";
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = true;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "ARProposals";
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
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(1065, 63);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", "Điều khoản thanh toán", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = "";
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 15;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            this.fld_lkeFK_GEPaymentTermID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEPaymentTermID_CloseUp);
            // 
            // fld_lbPaymentTerm
            // 
            this.fld_lbPaymentTerm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTerm.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTerm.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTerm.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTerm.BOSComment = "";
            this.fld_lbPaymentTerm.BOSDataMember = "";
            this.fld_lbPaymentTerm.BOSDataSource = "";
            this.fld_lbPaymentTerm.BOSDescription = null;
            this.fld_lbPaymentTerm.BOSError = null;
            this.fld_lbPaymentTerm.BOSFieldGroup = "";
            this.fld_lbPaymentTerm.BOSFieldRelation = "";
            this.fld_lbPaymentTerm.BOSPrivilege = "";
            this.fld_lbPaymentTerm.BOSPropertyName = null;
            this.fld_lbPaymentTerm.Location = new System.Drawing.Point(942, 66);
            this.fld_lbPaymentTerm.Name = "fld_lbPaymentTerm";
            this.fld_lbPaymentTerm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbPaymentTerm, true);
            this.fld_lbPaymentTerm.Size = new System.Drawing.Size(110, 13);
            this.fld_lbPaymentTerm.TabIndex = 562;
            this.fld_lbPaymentTerm.Tag = "";
            this.fld_lbPaymentTerm.Text = "Điều khoản thanh toán";
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
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(675, 40);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(94, 13);
            this.bosLabel19.TabIndex = 560;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Hình thức bán hàng";
            // 
            // fld_lkeARProposalSaleType
            // 
            this.fld_lkeARProposalSaleType.BOSAllowAddNew = false;
            this.fld_lkeARProposalSaleType.BOSAllowDummy = false;
            this.fld_lkeARProposalSaleType.BOSComment = "";
            this.fld_lkeARProposalSaleType.BOSDataMember = "ARProposalSaleType";
            this.fld_lkeARProposalSaleType.BOSDataSource = "ARProposals";
            this.fld_lkeARProposalSaleType.BOSDescription = null;
            this.fld_lkeARProposalSaleType.BOSError = null;
            this.fld_lkeARProposalSaleType.BOSFieldGroup = null;
            this.fld_lkeARProposalSaleType.BOSFieldParent = null;
            this.fld_lkeARProposalSaleType.BOSFieldRelation = null;
            this.fld_lkeARProposalSaleType.BOSPrivilege = null;
            this.fld_lkeARProposalSaleType.BOSPropertyName = "EditValue";
            this.fld_lkeARProposalSaleType.BOSSelectType = "";
            this.fld_lkeARProposalSaleType.BOSSelectTypeValue = "";
            this.fld_lkeARProposalSaleType.CurrentDisplayText = null;
            this.fld_lkeARProposalSaleType.Location = new System.Drawing.Point(777, 37);
            this.fld_lkeARProposalSaleType.Name = "fld_lkeARProposalSaleType";
            this.fld_lkeARProposalSaleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProposalSaleType.Properties.ColumnName = null;
            this.fld_lkeARProposalSaleType.Properties.NullText = "";
            this.fld_lkeARProposalSaleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProposalSaleType.Screen = null;
            this.fld_lkeARProposalSaleType.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeARProposalSaleType.TabIndex = 9;
            this.fld_lkeARProposalSaleType.Tag = "DC";
            this.fld_lkeARProposalSaleType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARProposalSaleType_CloseUp);
            this.fld_lkeARProposalSaleType.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.Fld_lkeARProposalSaleType_Closed);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(1351, 856);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(24, 13);
            this.bosLabel9.TabIndex = 558;
            this.bosLabel9.Text = "Thuế";
            // 
            // fld_txtARProposalTaxPercent
            // 
            this.fld_txtARProposalTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalTaxPercent.BOSComment = null;
            this.fld_txtARProposalTaxPercent.BOSDataMember = "ARProposalTaxPercent";
            this.fld_txtARProposalTaxPercent.BOSDataSource = "ARProposals";
            this.fld_txtARProposalTaxPercent.BOSDescription = null;
            this.fld_txtARProposalTaxPercent.BOSError = null;
            this.fld_txtARProposalTaxPercent.BOSFieldGroup = null;
            this.fld_txtARProposalTaxPercent.BOSFieldRelation = null;
            this.fld_txtARProposalTaxPercent.BOSPrivilege = null;
            this.fld_txtARProposalTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARProposalTaxPercent.EditValue = "0.00";
            this.fld_txtARProposalTaxPercent.Location = new System.Drawing.Point(1388, 853);
            this.fld_txtARProposalTaxPercent.Name = "fld_txtARProposalTaxPercent";
            this.fld_txtARProposalTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalTaxPercent.Screen = null;
            this.fld_txtARProposalTaxPercent.Size = new System.Drawing.Size(65, 20);
            this.fld_txtARProposalTaxPercent.TabIndex = 27;
            this.fld_txtARProposalTaxPercent.Tag = "DC";
            this.fld_txtARProposalTaxPercent.Validated += new System.EventHandler(this.fld_txtARProposalTaxPercent_Validated);
            // 
            // fld_txtARProposalTaxAmount
            // 
            this.fld_txtARProposalTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalTaxAmount.BOSComment = null;
            this.fld_txtARProposalTaxAmount.BOSDataMember = "ARProposalTaxAmount";
            this.fld_txtARProposalTaxAmount.BOSDataSource = "ARProposals";
            this.fld_txtARProposalTaxAmount.BOSDescription = null;
            this.fld_txtARProposalTaxAmount.BOSError = null;
            this.fld_txtARProposalTaxAmount.BOSFieldGroup = null;
            this.fld_txtARProposalTaxAmount.BOSFieldRelation = null;
            this.fld_txtARProposalTaxAmount.BOSPrivilege = null;
            this.fld_txtARProposalTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARProposalTaxAmount.EditValue = "0.00";
            this.fld_txtARProposalTaxAmount.Location = new System.Drawing.Point(1459, 853);
            this.fld_txtARProposalTaxAmount.Name = "fld_txtARProposalTaxAmount";
            this.fld_txtARProposalTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalTaxAmount.Screen = null;
            this.fld_txtARProposalTaxAmount.Size = new System.Drawing.Size(112, 20);
            this.fld_txtARProposalTaxAmount.TabIndex = 28;
            this.fld_txtARProposalTaxAmount.Tag = "DC";
            this.fld_txtARProposalTaxAmount.Modified += new System.EventHandler(this.fld_txtARProposalTaxAmount_Modified);
            this.fld_txtARProposalTaxAmount.Validated += new System.EventHandler(this.fld_txtARProposalTaxAmount_Validated);
            // 
            // bosLabel35
            // 
            this.bosLabel35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(1342, 908);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(33, 13);
            this.bosLabel35.TabIndex = 555;
            this.bosLabel35.Text = "Chi phí";
            this.bosLabel35.Visible = false;
            // 
            // fld_txtARProposalTotalCost
            // 
            this.fld_txtARProposalTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalTotalCost.BOSComment = null;
            this.fld_txtARProposalTotalCost.BOSDataMember = "ARProposalTotalCost";
            this.fld_txtARProposalTotalCost.BOSDataSource = "ARProposals";
            this.fld_txtARProposalTotalCost.BOSDescription = null;
            this.fld_txtARProposalTotalCost.BOSError = null;
            this.fld_txtARProposalTotalCost.BOSFieldGroup = null;
            this.fld_txtARProposalTotalCost.BOSFieldRelation = null;
            this.fld_txtARProposalTotalCost.BOSPrivilege = null;
            this.fld_txtARProposalTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtARProposalTotalCost.EditValue = "0.00";
            this.fld_txtARProposalTotalCost.Location = new System.Drawing.Point(1388, 905);
            this.fld_txtARProposalTotalCost.Name = "fld_txtARProposalTotalCost";
            this.fld_txtARProposalTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARProposalTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalTotalCost.Properties.ReadOnly = true;
            this.fld_txtARProposalTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalTotalCost.Screen = null;
            this.fld_txtARProposalTotalCost.Size = new System.Drawing.Size(183, 20);
            this.fld_txtARProposalTotalCost.TabIndex = 30;
            this.fld_txtARProposalTotalCost.Tag = "DC";
            this.fld_txtARProposalTotalCost.Visible = false;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARProposalName";
            this.bosTextBox1.BOSDataSource = "ARProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(777, 11);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(423, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(675, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(56, 13);
            this.bosLabel7.TabIndex = 61;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Tên báo giá";
            // 
            // fld_txtARProposalSubTotalAmount
            // 
            this.fld_txtARProposalSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalSubTotalAmount.BOSComment = "";
            this.fld_txtARProposalSubTotalAmount.BOSDataMember = "ARProposalSubTotalAmount";
            this.fld_txtARProposalSubTotalAmount.BOSDataSource = "ARProposals";
            this.fld_txtARProposalSubTotalAmount.BOSDescription = null;
            this.fld_txtARProposalSubTotalAmount.BOSError = null;
            this.fld_txtARProposalSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARProposalSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARProposalSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARProposalSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARProposalSubTotalAmount.Location = new System.Drawing.Point(1388, 775);
            this.fld_txtARProposalSubTotalAmount.Name = "fld_txtARProposalSubTotalAmount";
            this.fld_txtARProposalSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARProposalSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARProposalSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalSubTotalAmount.Screen = null;
            this.fld_txtARProposalSubTotalAmount.Size = new System.Drawing.Size(183, 20);
            this.fld_txtARProposalSubTotalAmount.TabIndex = 22;
            this.fld_txtARProposalSubTotalAmount.Tag = "DC";
            // 
            // fld_txtARProposalSOCommissionAmount
            // 
            this.fld_txtARProposalSOCommissionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalSOCommissionAmount.BOSComment = null;
            this.fld_txtARProposalSOCommissionAmount.BOSDataMember = "ARProposalSOCommissionAmount";
            this.fld_txtARProposalSOCommissionAmount.BOSDataSource = "ARProposals";
            this.fld_txtARProposalSOCommissionAmount.BOSDescription = null;
            this.fld_txtARProposalSOCommissionAmount.BOSError = null;
            this.fld_txtARProposalSOCommissionAmount.BOSFieldGroup = null;
            this.fld_txtARProposalSOCommissionAmount.BOSFieldRelation = null;
            this.fld_txtARProposalSOCommissionAmount.BOSPrivilege = null;
            this.fld_txtARProposalSOCommissionAmount.BOSPropertyName = "EditValue";
            this.fld_txtARProposalSOCommissionAmount.EditValue = "0.00";
            this.fld_txtARProposalSOCommissionAmount.Location = new System.Drawing.Point(1459, 801);
            this.fld_txtARProposalSOCommissionAmount.Name = "fld_txtARProposalSOCommissionAmount";
            this.fld_txtARProposalSOCommissionAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalSOCommissionAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalSOCommissionAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalSOCommissionAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalSOCommissionAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalSOCommissionAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalSOCommissionAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalSOCommissionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalSOCommissionAmount.Screen = null;
            this.fld_txtARProposalSOCommissionAmount.Size = new System.Drawing.Size(112, 20);
            this.fld_txtARProposalSOCommissionAmount.TabIndex = 24;
            this.fld_txtARProposalSOCommissionAmount.Tag = "DC";
            this.fld_txtARProposalSOCommissionAmount.Validated += new System.EventHandler(this.fld_txtARProposalSOCommissionAmount_Validated);
            // 
            // fld_txtARProposalCustomerCommissionPercent
            // 
            this.fld_txtARProposalCustomerCommissionPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARProposalCustomerCommissionPercent.BOSComment = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSDataMember = "ARProposalSOCommissionPercent";
            this.fld_txtARProposalCustomerCommissionPercent.BOSDataSource = "ARProposals";
            this.fld_txtARProposalCustomerCommissionPercent.BOSDescription = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSError = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSFieldGroup = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSFieldRelation = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSPrivilege = null;
            this.fld_txtARProposalCustomerCommissionPercent.BOSPropertyName = "EditValue";
            this.fld_txtARProposalCustomerCommissionPercent.EditValue = "0.00";
            this.fld_txtARProposalCustomerCommissionPercent.Location = new System.Drawing.Point(1388, 801);
            this.fld_txtARProposalCustomerCommissionPercent.Name = "fld_txtARProposalCustomerCommissionPercent";
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARProposalCustomerCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalCustomerCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalCustomerCommissionPercent.Screen = null;
            this.fld_txtARProposalCustomerCommissionPercent.Size = new System.Drawing.Size(65, 20);
            this.fld_txtARProposalCustomerCommissionPercent.TabIndex = 23;
            this.fld_txtARProposalCustomerCommissionPercent.Tag = "DC";
            this.fld_txtARProposalCustomerCommissionPercent.Validated += new System.EventHandler(this.fld_txtARProposalCustomerCommissionPercent_Validated);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(1329, 804);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 60;
            this.bosLabel6.Text = "Hoa hồng";
            // 
            // fld_bosTabControl
            // 
            this.fld_bosTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_bosTabControl.BOSComment = null;
            this.fld_bosTabControl.BOSDataMember = null;
            this.fld_bosTabControl.BOSDataSource = "ARProposalItemWorks";
            this.fld_bosTabControl.BOSDescription = null;
            this.fld_bosTabControl.BOSError = null;
            this.fld_bosTabControl.BOSFieldGroup = null;
            this.fld_bosTabControl.BOSFieldRelation = null;
            this.fld_bosTabControl.BOSPrivilege = null;
            this.fld_bosTabControl.BOSPropertyName = null;
            this.fld_bosTabControl.Location = new System.Drawing.Point(8, 213);
            this.fld_bosTabControl.Name = "fld_bosTabControl";
            this.fld_bosTabControl.Screen = null;
            this.fld_bosTabControl.SelectedTabPage = this.xtraTabPage1;
            this.fld_bosTabControl.Size = new System.Drawing.Size(1571, 526);
            this.fld_bosTabControl.TabIndex = 19;
            this.fld_bosTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage7,
            this.fld_tabPageDSCP,
            this.xtraTabPage4,
            this.xtraTabPage2,
            this.xtraTabPage5,
            this.xtraTabPage6});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_pteARProposalItemProductPicture);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.xtraTabPage1.Controls.Add(this.fld_dgcARProposalItemsGridControl);
            this.xtraTabPage1.Controls.Add(this.fld_btnShowProductCollection);
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel48);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1569, 501);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_pteARProposalItemProductPicture
            // 
            this.fld_pteARProposalItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARProposalItemProductPicture.BOSComment = null;
            this.fld_pteARProposalItemProductPicture.BOSDataMember = "ARProposalItemProductPicture";
            this.fld_pteARProposalItemProductPicture.BOSDataSource = "ARProposalItems";
            this.fld_pteARProposalItemProductPicture.BOSDescription = null;
            this.fld_pteARProposalItemProductPicture.BOSError = null;
            this.fld_pteARProposalItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARProposalItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARProposalItemProductPicture.BOSPrivilege = null;
            this.fld_pteARProposalItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARProposalItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARProposalItemProductPicture.FileName = null;
            this.fld_pteARProposalItemProductPicture.FilePath = null;
            this.fld_pteARProposalItemProductPicture.Location = new System.Drawing.Point(1430, 42);
            this.fld_pteARProposalItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARProposalItemProductPicture.Name = "fld_pteARProposalItemProductPicture";
            this.fld_pteARProposalItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARProposalItemProductPicture.Screen = null;
            this.fld_pteARProposalItemProductPicture.Size = new System.Drawing.Size(131, 130);
            this.fld_pteARProposalItemProductPicture.TabIndex = 2;
            this.fld_pteARProposalItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARProposalItems";
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
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(59, 13);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductActiveCheckText", "Hoạt động"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(1365, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductAttributeID_QueryPopUp);
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARProposalItemsGridControl
            // 
            this.fld_dgcARProposalItemsGridControl.AllowDrop = true;
            this.fld_dgcARProposalItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemsGridControl.BOSComment = "";
            this.fld_dgcARProposalItemsGridControl.BOSDataMember = "";
            this.fld_dgcARProposalItemsGridControl.BOSDataSource = "ARProposalItems";
            this.fld_dgcARProposalItemsGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemsGridControl.BOSError = null;
            this.fld_dgcARProposalItemsGridControl.BOSFieldGroup = "";
            this.fld_dgcARProposalItemsGridControl.BOSFieldRelation = "";
            this.fld_dgcARProposalItemsGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemsGridControl.BOSPrivilege = "";
            this.fld_dgcARProposalItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemsGridControl.CommodityType = "";
            this.fld_dgcARProposalItemsGridControl.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcARProposalItemsGridControl.Location = new System.Drawing.Point(4, 39);
            this.fld_dgcARProposalItemsGridControl.MainView = this.fld_dgvARProposalItems;
            this.fld_dgcARProposalItemsGridControl.Name = "fld_dgcARProposalItemsGridControl";
            this.fld_dgcARProposalItemsGridControl.PrintReport = false;
            this.fld_dgcARProposalItemsGridControl.Screen = null;
            this.fld_dgcARProposalItemsGridControl.Size = new System.Drawing.Size(1420, 459);
            this.fld_dgcARProposalItemsGridControl.TabIndex = 2;
            this.fld_dgcARProposalItemsGridControl.Tag = "DC";
            this.fld_dgcARProposalItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARProposalItems});
            // 
            // fld_dgvARProposalItems
            // 
            this.fld_dgvARProposalItems.GridControl = this.fld_dgcARProposalItemsGridControl;
            this.fld_dgvARProposalItems.Name = "fld_dgvARProposalItems";
            this.fld_dgvARProposalItems.PaintStyleName = "Office2003";
            // 
            // fld_btnShowProductCollection
            // 
            this.fld_btnShowProductCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnShowProductCollection.BOSComment = null;
            this.fld_btnShowProductCollection.BOSDataMember = null;
            this.fld_btnShowProductCollection.BOSDataSource = null;
            this.fld_btnShowProductCollection.BOSDescription = null;
            this.fld_btnShowProductCollection.BOSError = null;
            this.fld_btnShowProductCollection.BOSFieldGroup = null;
            this.fld_btnShowProductCollection.BOSFieldRelation = null;
            this.fld_btnShowProductCollection.BOSPrivilege = null;
            this.fld_btnShowProductCollection.BOSPropertyName = null;
            this.fld_btnShowProductCollection.Location = new System.Drawing.Point(1430, 9);
            this.fld_btnShowProductCollection.Name = "fld_btnShowProductCollection";
            this.fld_btnShowProductCollection.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowProductCollection, true);
            this.fld_btnShowProductCollection.Size = new System.Drawing.Size(131, 27);
            this.fld_btnShowProductCollection.TabIndex = 1;
            this.fld_btnShowProductCollection.Text = "Chọn từ Bộ sưu tập";
            this.fld_btnShowProductCollection.Visible = false;
            this.fld_btnShowProductCollection.Click += new System.EventHandler(this.fld_btnShowProductCollection_Click);
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
            this.fld_lblLabel48.Location = new System.Drawing.Point(6, 16);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 1;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.fld_dgcARProposalPaymentTimes);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(1555, 494);
            this.xtraTabPage7.Text = "Danh sách đợt thanh toán";
            // 
            // fld_dgcARProposalPaymentTimes
            // 
            this.fld_dgcARProposalPaymentTimes.AllowDrop = true;
            this.fld_dgcARProposalPaymentTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalPaymentTimes.BOSComment = null;
            this.fld_dgcARProposalPaymentTimes.BOSDataMember = null;
            this.fld_dgcARProposalPaymentTimes.BOSDataSource = "ARProposalPaymentTimes";
            this.fld_dgcARProposalPaymentTimes.BOSDescription = null;
            this.fld_dgcARProposalPaymentTimes.BOSError = null;
            this.fld_dgcARProposalPaymentTimes.BOSFieldGroup = null;
            this.fld_dgcARProposalPaymentTimes.BOSFieldRelation = null;
            this.fld_dgcARProposalPaymentTimes.BOSGridType = null;
            this.fld_dgcARProposalPaymentTimes.BOSPrivilege = null;
            this.fld_dgcARProposalPaymentTimes.BOSPropertyName = null;
            this.fld_dgcARProposalPaymentTimes.CommodityType = "";
            this.fld_dgcARProposalPaymentTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARProposalPaymentTimes.Location = new System.Drawing.Point(0, 3);
            this.fld_dgcARProposalPaymentTimes.MainView = this.gridView1;
            this.fld_dgcARProposalPaymentTimes.Name = "fld_dgcARProposalPaymentTimes";
            this.fld_dgcARProposalPaymentTimes.PrintReport = false;
            this.fld_dgcARProposalPaymentTimes.Screen = null;
            this.fld_dgcARProposalPaymentTimes.Size = new System.Drawing.Size(1555, 491);
            this.fld_dgcARProposalPaymentTimes.TabIndex = 27;
            this.fld_dgcARProposalPaymentTimes.Tag = "DC";
            this.fld_dgcARProposalPaymentTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARProposalPaymentTimes;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabPageDSCP
            // 
            this.fld_tabPageDSCP.Controls.Add(this.fld_btnAddCost);
            this.fld_tabPageDSCP.Controls.Add(this.fld_dgcARProposalItemCostGridControl);
            this.fld_tabPageDSCP.Name = "fld_tabPageDSCP";
            this.fld_tabPageDSCP.Size = new System.Drawing.Size(1555, 494);
            this.fld_tabPageDSCP.Text = "Danh sách chi phí";
            // 
            // fld_btnAddCost
            // 
            this.fld_btnAddCost.BOSComment = null;
            this.fld_btnAddCost.BOSDataMember = null;
            this.fld_btnAddCost.BOSDataSource = null;
            this.fld_btnAddCost.BOSDescription = null;
            this.fld_btnAddCost.BOSError = null;
            this.fld_btnAddCost.BOSFieldGroup = null;
            this.fld_btnAddCost.BOSFieldRelation = null;
            this.fld_btnAddCost.BOSPrivilege = null;
            this.fld_btnAddCost.BOSPropertyName = null;
            this.fld_btnAddCost.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddCost.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddCost.Name = "fld_btnAddCost";
            this.fld_btnAddCost.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddCost, true);
            this.fld_btnAddCost.Size = new System.Drawing.Size(122, 27);
            this.fld_btnAddCost.TabIndex = 61;
            this.fld_btnAddCost.Text = "Thêm chi phí";
            this.fld_btnAddCost.Click += new System.EventHandler(this.fld_btnAddCost_Click);
            // 
            // fld_dgcARProposalItemCostGridControl
            // 
            this.fld_dgcARProposalItemCostGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemCostGridControl.BOSComment = null;
            this.fld_dgcARProposalItemCostGridControl.BOSDataMember = null;
            this.fld_dgcARProposalItemCostGridControl.BOSDataSource = "ARProposalItemWorks";
            this.fld_dgcARProposalItemCostGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemCostGridControl.BOSError = null;
            this.fld_dgcARProposalItemCostGridControl.BOSFieldGroup = null;
            this.fld_dgcARProposalItemCostGridControl.BOSFieldRelation = null;
            this.fld_dgcARProposalItemCostGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemCostGridControl.BOSPrivilege = null;
            this.fld_dgcARProposalItemCostGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemCostGridControl.CommodityType = "";
            this.fld_dgcARProposalItemCostGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARProposalItemCostGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARProposalItemCostGridControl.Name = "fld_dgcARProposalItemCostGridControl";
            this.fld_dgcARProposalItemCostGridControl.PrintReport = false;
            this.fld_dgcARProposalItemCostGridControl.Screen = null;
            this.fld_dgcARProposalItemCostGridControl.Size = new System.Drawing.Size(1548, 455);
            this.fld_dgcARProposalItemCostGridControl.TabIndex = 2;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.bosButton1);
            this.xtraTabPage4.Controls.Add(this.fld_dgcARProposalItemWorksGridControl);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.PageVisible = false;
            this.xtraTabPage4.Size = new System.Drawing.Size(1555, 494);
            this.xtraTabPage4.Text = "Danh sách công việc";
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
            this.bosButton1.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.bosButton1.Location = new System.Drawing.Point(4, 3);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(122, 27);
            this.bosButton1.TabIndex = 60;
            this.bosButton1.Text = "Thêm công việc";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dgcARProposalItemWorksGridControl
            // 
            this.fld_dgcARProposalItemWorksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemWorksGridControl.BOSComment = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSDataMember = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSDataSource = "ARProposalItemWorks";
            this.fld_dgcARProposalItemWorksGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSError = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSFieldGroup = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSFieldRelation = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSPrivilege = null;
            this.fld_dgcARProposalItemWorksGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemWorksGridControl.CommodityType = "";
            this.fld_dgcARProposalItemWorksGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARProposalItemWorksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARProposalItemWorksGridControl.Name = "fld_dgcARProposalItemWorksGridControl";
            this.fld_dgcARProposalItemWorksGridControl.PrintReport = false;
            this.fld_dgcARProposalItemWorksGridControl.Screen = null;
            this.fld_dgcARProposalItemWorksGridControl.Size = new System.Drawing.Size(1548, 455);
            this.fld_dgcARProposalItemWorksGridControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnAddProductMaterial);
            this.xtraTabPage2.Controls.Add(this.fld_dgcARProposalItemWorkMaterialsGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(1555, 494);
            this.xtraTabPage2.Text = "Danh sách vật tư";
            // 
            // fld_btnAddProductMaterial
            // 
            this.fld_btnAddProductMaterial.BOSComment = null;
            this.fld_btnAddProductMaterial.BOSDataMember = null;
            this.fld_btnAddProductMaterial.BOSDataSource = null;
            this.fld_btnAddProductMaterial.BOSDescription = null;
            this.fld_btnAddProductMaterial.BOSError = null;
            this.fld_btnAddProductMaterial.BOSFieldGroup = null;
            this.fld_btnAddProductMaterial.BOSFieldRelation = null;
            this.fld_btnAddProductMaterial.BOSPrivilege = null;
            this.fld_btnAddProductMaterial.BOSPropertyName = null;
            this.fld_btnAddProductMaterial.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddProductMaterial.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddProductMaterial.Name = "fld_btnAddProductMaterial";
            this.fld_btnAddProductMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddProductMaterial, true);
            this.fld_btnAddProductMaterial.Size = new System.Drawing.Size(108, 27);
            this.fld_btnAddProductMaterial.TabIndex = 60;
            this.fld_btnAddProductMaterial.Text = "Thêm vật tư";
            this.fld_btnAddProductMaterial.Click += new System.EventHandler(this.fld_btnAddProductMaterial_Click);
            // 
            // fld_dgcARProposalItemWorkMaterialsGridControl
            // 
            this.fld_dgcARProposalItemWorkMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSComment = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSDataSource = "ARProposalItemWorks";
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSError = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.CommodityType = "";
            this.fld_dgcARProposalItemWorkMaterialsGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARProposalItemWorkMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.Name = "fld_dgcARProposalItemWorkMaterialsGridControl";
            this.fld_dgcARProposalItemWorkMaterialsGridControl.PrintReport = false;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.Screen = null;
            this.fld_dgcARProposalItemWorkMaterialsGridControl.Size = new System.Drawing.Size(1548, 455);
            this.fld_dgcARProposalItemWorkMaterialsGridControl.TabIndex = 1;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_btnAddProductAsset);
            this.xtraTabPage5.Controls.Add(this.fld_dgcARProposalItemWorkAssetsGridControl);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.PageVisible = false;
            this.xtraTabPage5.Size = new System.Drawing.Size(1555, 494);
            this.xtraTabPage5.Text = "Danh sách MMTB";
            // 
            // fld_btnAddProductAsset
            // 
            this.fld_btnAddProductAsset.BOSComment = null;
            this.fld_btnAddProductAsset.BOSDataMember = null;
            this.fld_btnAddProductAsset.BOSDataSource = null;
            this.fld_btnAddProductAsset.BOSDescription = null;
            this.fld_btnAddProductAsset.BOSError = null;
            this.fld_btnAddProductAsset.BOSFieldGroup = null;
            this.fld_btnAddProductAsset.BOSFieldRelation = null;
            this.fld_btnAddProductAsset.BOSPrivilege = null;
            this.fld_btnAddProductAsset.BOSPropertyName = null;
            this.fld_btnAddProductAsset.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddProductAsset.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddProductAsset.Name = "fld_btnAddProductAsset";
            this.fld_btnAddProductAsset.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddProductAsset, true);
            this.fld_btnAddProductAsset.Size = new System.Drawing.Size(154, 27);
            this.fld_btnAddProductAsset.TabIndex = 61;
            this.fld_btnAddProductAsset.Text = "Thêm máy móc thiết bị";
            this.fld_btnAddProductAsset.Click += new System.EventHandler(this.fld_btnAddProductAsset_Click);
            // 
            // fld_dgcARProposalItemWorkAssetsGridControl
            // 
            this.fld_dgcARProposalItemWorkAssetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSComment = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSDataMember = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSDataSource = "ARProposalItemWorks";
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSError = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.CommodityType = "";
            this.fld_dgcARProposalItemWorkAssetsGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARProposalItemWorkAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARProposalItemWorkAssetsGridControl.Name = "fld_dgcARProposalItemWorkAssetsGridControl";
            this.fld_dgcARProposalItemWorkAssetsGridControl.PrintReport = false;
            this.fld_dgcARProposalItemWorkAssetsGridControl.Screen = null;
            this.fld_dgcARProposalItemWorkAssetsGridControl.Size = new System.Drawing.Size(1541, 455);
            this.fld_dgcARProposalItemWorkAssetsGridControl.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.fld_dgcARProposalItemWorkTasksGridControl);
            this.xtraTabPage6.Controls.Add(this.fld_btnAddTask);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.PageVisible = false;
            this.xtraTabPage6.Size = new System.Drawing.Size(1555, 494);
            this.xtraTabPage6.Text = "Danh sách Task";
            // 
            // fld_dgcARProposalItemWorkTasksGridControl
            // 
            this.fld_dgcARProposalItemWorkTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSComment = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSDataMember = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSDataSource = "ARProposalItemWorkTasks";
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSDescription = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSError = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSGridType = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSPrivilege = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.CommodityType = "";
            this.fld_dgcARProposalItemWorkTasksGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARProposalItemWorkTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARProposalItemWorkTasksGridControl.Name = "fld_dgcARProposalItemWorkTasksGridControl";
            this.fld_dgcARProposalItemWorkTasksGridControl.PrintReport = false;
            this.fld_dgcARProposalItemWorkTasksGridControl.Screen = null;
            this.fld_dgcARProposalItemWorkTasksGridControl.Size = new System.Drawing.Size(1541, 455);
            this.fld_dgcARProposalItemWorkTasksGridControl.TabIndex = 62;
            // 
            // fld_btnAddTask
            // 
            this.fld_btnAddTask.BOSComment = null;
            this.fld_btnAddTask.BOSDataMember = null;
            this.fld_btnAddTask.BOSDataSource = null;
            this.fld_btnAddTask.BOSDescription = null;
            this.fld_btnAddTask.BOSError = null;
            this.fld_btnAddTask.BOSFieldGroup = null;
            this.fld_btnAddTask.BOSFieldRelation = null;
            this.fld_btnAddTask.BOSPrivilege = null;
            this.fld_btnAddTask.BOSPropertyName = null;
            this.fld_btnAddTask.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddTask.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddTask.Name = "fld_btnAddTask";
            this.fld_btnAddTask.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddTask, true);
            this.fld_btnAddTask.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddTask.TabIndex = 61;
            this.fld_btnAddTask.Text = "Thêm Task";
            this.fld_btnAddTask.Click += new System.EventHandler(this.fld_btnAddTask_Click);
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
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(417, 40);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(52, 13);
            this.bosLabel18.TabIndex = 8;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Ngân hàng";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoScroll = true;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.bosPanel2.Controls.Add(this.bosLabel22);
            this.bosPanel2.Controls.Add(this.bosLabel36);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalPortOFDischarge);
            this.bosPanel2.Controls.Add(this.fld_lkeARProposalPortOFLoading);
            this.bosPanel2.Controls.Add(this.bosLabel23);
            this.bosPanel2.Controls.Add(this.bosLabel21);
            this.bosPanel2.Controls.Add(this.fld_lkeARShippingType);
            this.bosPanel2.Controls.Add(this.bosLabel9);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalProject);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalTaxPercent);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalTaxAmount);
            this.bosPanel2.Controls.Add(this.fld_dteAACreatedDate);
            this.bosPanel2.Controls.Add(this.bosLabel35);
            this.bosPanel2.Controls.Add(this.bosLabel17);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalTotalCost);
            this.bosPanel2.Controls.Add(this.fld_lkeARProposalStatus);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalSubTotalAmount);
            this.bosPanel2.Controls.Add(this.bosLabel16);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalSOCommissionAmount);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalNo1);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalCustomerCommissionPercent);
            this.bosPanel2.Controls.Add(this.bosLookupEdit2);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lblLabel14);
            this.bosPanel2.Controls.Add(this.BOSLine2);
            this.bosPanel2.Controls.Add(this.bosLabel12);
            this.bosPanel2.Controls.Add(this.fld_lblLabel23);
            this.bosPanel2.Controls.Add(this.fld_bosTabControl);
            this.bosPanel2.Controls.Add(this.fld_lblLabel25);
            this.bosPanel2.Controls.Add(this.fld_lblLabel15);
            this.bosPanel2.Controls.Add(this.fld_lblLabel26);
            this.bosPanel2.Controls.Add(this.bosLabel94);
            this.bosPanel2.Controls.Add(this.fld_lblLabel27);
            this.bosPanel2.Controls.Add(this.bosLabel18);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalDiscountPerCent);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalDiscountFix);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_GECurrencyID2);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalTotalAmount);
            this.bosPanel2.Controls.Add(this.fld_lblLabel13);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel2.Controls.Add(this.BOSLine1);
            this.bosPanel2.Controls.Add(this.bosLabel10);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.bosLabel14);
            this.bosPanel2.Controls.Add(this.fld_dteARProposalValidateDate2);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.fld_dteARProposalDeliveryDate2);
            this.bosPanel2.Controls.Add(this.bosLabel11);
            this.bosPanel2.Controls.Add(this.fld_ptePictureEdit);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.bosTextBox5);
            this.bosPanel2.Controls.Add(this.bosTextBox1);
            this.bosPanel2.Controls.Add(this.bosTextBox4);
            this.bosPanel2.Controls.Add(this.fld_lkeARProposalSaleType);
            this.bosPanel2.Controls.Add(this.fld_txtARProposalDiscountPerCentForItem);
            this.bosPanel2.Controls.Add(this.bosLabel19);
            this.bosPanel2.Controls.Add(this.bosLabel20);
            this.bosPanel2.Controls.Add(this.fld_lbPaymentTerm);
            this.bosPanel2.Controls.Add(this.bosLabel15);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.bosPanel2.Controls.Add(this.bosLabel13);
            this.bosPanel2.Controls.Add(this.bosLabel41);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1589, 1039);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeARPaymentMethodCombo
            // 
            this.fld_lkeARPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeARPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeARPaymentMethodCombo.BOSComment = null;
            this.fld_lkeARPaymentMethodCombo.BOSDataMember = "ARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ARProposals";
            this.fld_lkeARPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeARPaymentMethodCombo.BOSError = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldGroup = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldParent = null;
            this.fld_lkeARPaymentMethodCombo.BOSFieldRelation = null;
            this.fld_lkeARPaymentMethodCombo.BOSPrivilege = null;
            this.fld_lkeARPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARPaymentMethodCombo.BOSSelectType = null;
            this.fld_lkeARPaymentMethodCombo.BOSSelectTypeValue = null;
            this.fld_lkeARPaymentMethodCombo.CurrentDisplayText = null;
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(1065, 37);
            this.fld_lkeARPaymentMethodCombo.Name = "fld_lkeARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeARPaymentMethodCombo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeARPaymentMethodCombo.Properties.DisplayMember = "ADConfigKeyValue";
            this.fld_lkeARPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeARPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARPaymentMethodCombo.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeARPaymentMethodCombo.Screen = null;
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 851;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(1203, 38);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(6, 13);
            this.bosLabel22.TabIndex = 847;
            this.bosLabel22.Text = "*";
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = "";
            this.bosLabel36.BOSDataMember = "";
            this.bosLabel36.BOSDataSource = "";
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = "";
            this.bosLabel36.BOSFieldRelation = "";
            this.bosLabel36.BOSPrivilege = "";
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(942, 170);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel36, true);
            this.bosLabel36.Size = new System.Drawing.Size(77, 13);
            this.bosLabel36.TabIndex = 846;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Cảng Nhập POD";
            // 
            // fld_txtARProposalPortOFDischarge
            // 
            this.fld_txtARProposalPortOFDischarge.BOSComment = "";
            this.fld_txtARProposalPortOFDischarge.BOSDataMember = "ARProposalPortOFDischarge";
            this.fld_txtARProposalPortOFDischarge.BOSDataSource = "ARProposals";
            this.fld_txtARProposalPortOFDischarge.BOSDescription = null;
            this.fld_txtARProposalPortOFDischarge.BOSError = null;
            this.fld_txtARProposalPortOFDischarge.BOSFieldGroup = "";
            this.fld_txtARProposalPortOFDischarge.BOSFieldRelation = "";
            this.fld_txtARProposalPortOFDischarge.BOSPrivilege = "";
            this.fld_txtARProposalPortOFDischarge.BOSPropertyName = "EditValue";
            this.fld_txtARProposalPortOFDischarge.EditValue = "";
            this.fld_txtARProposalPortOFDischarge.Location = new System.Drawing.Point(1065, 167);
            this.fld_txtARProposalPortOFDischarge.Name = "fld_txtARProposalPortOFDischarge";
            this.fld_txtARProposalPortOFDischarge.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalPortOFDischarge.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalPortOFDischarge.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalPortOFDischarge.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalPortOFDischarge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalPortOFDischarge.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARProposalPortOFDischarge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalPortOFDischarge.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARProposalPortOFDischarge, true);
            this.fld_txtARProposalPortOFDischarge.Size = new System.Drawing.Size(135, 20);
            this.fld_txtARProposalPortOFDischarge.TabIndex = 845;
            this.fld_txtARProposalPortOFDischarge.Tag = "DC";
            // 
            // fld_lkeARProposalPortOFLoading
            // 
            this.fld_lkeARProposalPortOFLoading.BOSAllowAddNew = false;
            this.fld_lkeARProposalPortOFLoading.BOSAllowDummy = true;
            this.fld_lkeARProposalPortOFLoading.BOSComment = null;
            this.fld_lkeARProposalPortOFLoading.BOSDataMember = "FK_GETerminalID";
            this.fld_lkeARProposalPortOFLoading.BOSDataSource = "ARProposals";
            this.fld_lkeARProposalPortOFLoading.BOSDescription = null;
            this.fld_lkeARProposalPortOFLoading.BOSError = null;
            this.fld_lkeARProposalPortOFLoading.BOSFieldGroup = null;
            this.fld_lkeARProposalPortOFLoading.BOSFieldParent = null;
            this.fld_lkeARProposalPortOFLoading.BOSFieldRelation = null;
            this.fld_lkeARProposalPortOFLoading.BOSPrivilege = null;
            this.fld_lkeARProposalPortOFLoading.BOSPropertyName = "EditValue";
            this.fld_lkeARProposalPortOFLoading.BOSSelectType = "";
            this.fld_lkeARProposalPortOFLoading.BOSSelectTypeValue = "";
            this.fld_lkeARProposalPortOFLoading.CurrentDisplayText = null;
            this.fld_lkeARProposalPortOFLoading.Location = new System.Drawing.Point(777, 167);
            this.fld_lkeARProposalPortOFLoading.Name = "fld_lkeARProposalPortOFLoading";
            this.fld_lkeARProposalPortOFLoading.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARProposalPortOFLoading.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARProposalPortOFLoading.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProposalPortOFLoading.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARProposalPortOFLoading.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProposalPortOFLoading.Properties.ColumnName = null;
            this.fld_lkeARProposalPortOFLoading.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã cảng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên cảng")});
            this.fld_lkeARProposalPortOFLoading.Properties.DisplayMember = "GETerminalName";
            this.fld_lkeARProposalPortOFLoading.Properties.NullText = "";
            this.fld_lkeARProposalPortOFLoading.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProposalPortOFLoading.Properties.ValueMember = "GETerminalID";
            this.fld_lkeARProposalPortOFLoading.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARProposalPortOFLoading, true);
            this.fld_lkeARProposalPortOFLoading.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeARProposalPortOFLoading.TabIndex = 844;
            this.fld_lkeARProposalPortOFLoading.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(675, 170);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(72, 13);
            this.bosLabel23.TabIndex = 843;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Cảng xuất POL";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(417, 170);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(96, 13);
            this.bosLabel21.TabIndex = 842;
            this.bosLabel21.Text = "Hình thức giao hàng";
            // 
            // fld_lkeARShippingType
            // 
            this.fld_lkeARShippingType.BOSAllowAddNew = false;
            this.fld_lkeARShippingType.BOSAllowDummy = false;
            this.fld_lkeARShippingType.BOSComment = null;
            this.fld_lkeARShippingType.BOSDataMember = "ARShippingType";
            this.fld_lkeARShippingType.BOSDataSource = "ARProposals";
            this.fld_lkeARShippingType.BOSDescription = null;
            this.fld_lkeARShippingType.BOSError = null;
            this.fld_lkeARShippingType.BOSFieldGroup = null;
            this.fld_lkeARShippingType.BOSFieldParent = null;
            this.fld_lkeARShippingType.BOSFieldRelation = null;
            this.fld_lkeARShippingType.BOSPrivilege = null;
            this.fld_lkeARShippingType.BOSPropertyName = "EditValue";
            this.fld_lkeARShippingType.BOSSelectType = null;
            this.fld_lkeARShippingType.BOSSelectTypeValue = null;
            this.fld_lkeARShippingType.CurrentDisplayText = null;
            this.fld_lkeARShippingType.Location = new System.Drawing.Point(519, 167);
            this.fld_lkeARShippingType.Name = "fld_lkeARShippingType";
            this.fld_lkeARShippingType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARShippingType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARShippingType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARShippingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARShippingType.Properties.ColumnName = null;
            this.fld_lkeARShippingType.Properties.NullText = "";
            this.fld_lkeARShippingType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARShippingType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARShippingType, true);
            this.fld_lkeARShippingType.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeARShippingType.TabIndex = 841;
            this.fld_lkeARShippingType.Tag = "DC";
            // 
            // DMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1589, 1039);
            this.Controls.Add(this.bosPanel2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPS100.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DMPS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalDeliveryDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalDeliveryDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalValidateDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProposalValidateDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalAmount.Properties)).EndInit();
            this.BOSLine1.ResumeLayout(false);
            this.BOSLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.BOSLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalDiscountPerCentForItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalSaleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalSOCommissionAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalCustomerCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bosTabControl)).EndInit();
            this.fld_bosTabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProposalItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposalItems)).EndInit();
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabPageDSCP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemCostGridControl)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorksGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkMaterialsGridControl)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkAssetsGridControl)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalItemWorkTasksGridControl)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalPortOFDischarge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProposalPortOFLoading.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARShippingType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSLine BOSLine2;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeARProposalStatus;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARProposalNo1;
        private BOSComponent.BOSTabControl fld_bosTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSPictureEdit fld_pteARProposalItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private ARProposalItemsGridControl fld_dgcARProposalItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARProposalItems;
        private BOSComponent.BOSButton fld_btnShowProductCollection;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSERP.Modules.Proposal.ARProposalItemWorksGridControl fld_dgcARProposalItemWorksGridControl;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtARProposalCustomerCommissionPercent;
        private BOSComponent.BOSTextBox fld_txtARProposalSOCommissionAmount;
        private BOSComponent.BOSTextBox fld_txtARProposalSubTotalAmount;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLabel bosLabel7;
        private ARProposalItemWorkMaterialsGridControl fld_dgcARProposalItemWorkMaterialsGridControl;
        private BOSComponent.BOSTextBox bosTextBox1;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDSCP;
        private ARProposalItemCostsGridControl fld_dgcARProposalItemCostGridControl;
        private BOSComponent.BOSTextBox fld_txtARProposalTotalCost;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSButton fld_btnAddProductMaterial;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private ARProposalItemWorkAssetsGridControl fld_dgcARProposalItemWorkAssetsGridControl;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARProposalTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARProposalTaxAmount;
        private BOSComponent.BOSButton bosButton1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private BOSComponent.BOSButton fld_btnAddProductAsset;
        private BOSComponent.BOSButton fld_btnAddTask;
        //private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private ARProposalItemWorkTasksGridControl fld_dgcARProposalItemWorkTasksGridControl;
        private BOSComponent.BOSButton fld_btnAddCost;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel fld_lbPaymentTerm;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private BOSERP.Modules.Proposal.ARProposalPaymentTimesGridControl fld_dgcARProposalPaymentTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkChooseProspectCustomer;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSDateEdit fld_dteAACreatedDate;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeARProposalSaleType;
        private BOSComponent.BOSTextBox fld_txtARProposalDiscountPerCentForItem;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel94;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSTextBox fld_txtARProposalProject;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSRichEditControl fld_recARProposalDesc;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeARShippingType;
        private BOSComponent.BOSLookupEdit fld_lkeARProposalPortOFLoading;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSTextBox fld_txtARProposalPortOFDischarge;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;
    }
}
