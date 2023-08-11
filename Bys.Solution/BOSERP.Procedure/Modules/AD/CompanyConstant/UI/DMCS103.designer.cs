using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS103
	/// </summary>
	partial class DMCS103
    {
		private PaymentTypeGridControl fld_dgcPaymentType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvPaymentType;
        private BOSComponent.BOSLabel fld_lblLabel1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS103));
            this.fld_dgcPaymentType = new BOSERP.Modules.CompanyConstant.PaymentTypeGridControl();
            this.fld_dgvPaymentType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_grpGroupControl9 = new BOSComponent.BOSLine(this.components);
            this.fld_grpGroupControl6 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCont = new BOSERP.Modules.CompanyConstant.ContainerTypeGridControl();
            this.fld_dgvContType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcARDeliveryMethods = new BOSERP.Modules.CompanyConstant.ARDeliveryMethodsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_grpGroupControl12 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcTaxPercentType = new BOSERP.Modules.CompanyConstant.TaxPercentTypeGridControl();
            this.fld_dgvTaxPercentType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcARSaleOrderSaleTypeConfigs = new BOSERP.Modules.CompanyConstant.ARSaleOrderSaleTypeConfigsGridControl();
            this.bosLine8 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeCSSourceSellingPriceMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcListOfSalesChannelType = new BOSERP.Modules.CompanyConstant.ListOfSalesChannelTypeGridControl();
            this.fld_dgvCustomerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_grpGroupControl10 = new BOSComponent.BOSLine(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtDeliveryDueDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPaymentDueDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAssSellerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMainSellerCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInitialDeposit = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcGESaleCosts = new BOSERP.Modules.CompanyConstant.GESaleCostsGridControl();
            this.fld_grpGroupControl11 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtValidDays = new BOSComponent.BOSTextBox(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcARSaleContractGroups = new BOSERP.Modules.CompanyConstant.ARSaleContractGroupsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvPaymentType)).BeginInit();
            this.fld_grpGroupControl9.SuspendLayout();
            this.fld_grpGroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvContType)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryMethods)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.fld_grpGroupControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTaxPercentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTaxPercentType)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderSaleTypeConfigs)).BeginInit();
            this.bosLine8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCSSourceSellingPriceMethod.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcListOfSalesChannelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).BeginInit();
            this.fld_grpGroupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryDueDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentDueDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAssSellerCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMainSellerCommissionPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInitialDeposit.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGESaleCosts)).BeginInit();
            this.fld_grpGroupControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtValidDays.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleContractGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcPaymentType
            // 
            this.fld_dgcPaymentType.AllowDrop = true;
            this.fld_dgcPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPaymentType.BOSComment = "";
            this.fld_dgcPaymentType.BOSDataMember = null;
            this.fld_dgcPaymentType.BOSDataSource = "ADConfigValues";
            this.fld_dgcPaymentType.BOSDescription = null;
            this.fld_dgcPaymentType.BOSError = "";
            this.fld_dgcPaymentType.BOSFieldGroup = "";
            this.fld_dgcPaymentType.BOSFieldRelation = null;
            this.fld_dgcPaymentType.BOSGridType = null;
            this.fld_dgcPaymentType.BOSPrivilege = "";
            this.fld_dgcPaymentType.BOSPropertyName = null;
            this.fld_dgcPaymentType.CommodityType = "";
            this.fld_dgcPaymentType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPaymentType.Location = new System.Drawing.Point(6, 13);
            this.fld_dgcPaymentType.MainView = this.fld_dgvPaymentType;
            this.fld_dgcPaymentType.Name = "fld_dgcPaymentType";
            this.fld_dgcPaymentType.PrintReport = false;
            this.fld_dgcPaymentType.Screen = null;
            this.fld_dgcPaymentType.Size = new System.Drawing.Size(1129, 255);
            this.fld_dgcPaymentType.TabIndex = 4;
            this.fld_dgcPaymentType.Tag = "DC";
            this.fld_dgcPaymentType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvPaymentType});
            // 
            // fld_dgvPaymentType
            // 
            this.fld_dgvPaymentType.GridControl = this.fld_dgcPaymentType;
            this.fld_dgvPaymentType.Name = "fld_dgvPaymentType";
            this.fld_dgvPaymentType.PaintStyleName = "Office2003";
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
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(52, 274);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel1.TabIndex = 9;
            this.fld_lblLabel1.Tag = "";
            // 
            // fld_grpGroupControl9
            // 
            this.fld_grpGroupControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpGroupControl9.BOSComment = null;
            this.fld_grpGroupControl9.BOSDataMember = null;
            this.fld_grpGroupControl9.BOSDataSource = null;
            this.fld_grpGroupControl9.BOSDescription = null;
            this.fld_grpGroupControl9.BOSError = null;
            this.fld_grpGroupControl9.BOSFieldGroup = null;
            this.fld_grpGroupControl9.BOSFieldRelation = null;
            this.fld_grpGroupControl9.BOSPrivilege = null;
            this.fld_grpGroupControl9.BOSPropertyName = null;
            this.fld_grpGroupControl9.Controls.Add(this.fld_dgcPaymentType);
            this.fld_grpGroupControl9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl9.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl9.Name = "fld_grpGroupControl9";
            this.fld_grpGroupControl9.Screen = null;
            this.fld_grpGroupControl9.Size = new System.Drawing.Size(1141, 274);
            this.fld_grpGroupControl9.TabIndex = 22;
            this.fld_grpGroupControl9.TabStop = false;
            this.fld_grpGroupControl9.Text = "Phương thức thanh toán";
            // 
            // fld_grpGroupControl6
            // 
            this.fld_grpGroupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpGroupControl6.BOSComment = null;
            this.fld_grpGroupControl6.BOSDataMember = null;
            this.fld_grpGroupControl6.BOSDataSource = null;
            this.fld_grpGroupControl6.BOSDescription = null;
            this.fld_grpGroupControl6.BOSError = null;
            this.fld_grpGroupControl6.BOSFieldGroup = null;
            this.fld_grpGroupControl6.BOSFieldRelation = null;
            this.fld_grpGroupControl6.BOSPrivilege = null;
            this.fld_grpGroupControl6.BOSPropertyName = null;
            this.fld_grpGroupControl6.Controls.Add(this.fld_dgcCont);
            this.fld_grpGroupControl6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl6.Location = new System.Drawing.Point(3, 319);
            this.fld_grpGroupControl6.Name = "fld_grpGroupControl6";
            this.fld_grpGroupControl6.Screen = null;
            this.fld_grpGroupControl6.Size = new System.Drawing.Size(1131, 602);
            this.fld_grpGroupControl6.TabIndex = 26;
            this.fld_grpGroupControl6.TabStop = false;
            this.fld_grpGroupControl6.Text = "Cấu hình Cont";
            // 
            // fld_dgcCont
            // 
            this.fld_dgcCont.AllowDrop = true;
            this.fld_dgcCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCont.BOSComment = "";
            this.fld_dgcCont.BOSDataMember = null;
            this.fld_dgcCont.BOSDataSource = "ADConfigValues";
            this.fld_dgcCont.BOSDescription = null;
            this.fld_dgcCont.BOSError = "";
            this.fld_dgcCont.BOSFieldGroup = "";
            this.fld_dgcCont.BOSFieldRelation = null;
            this.fld_dgcCont.BOSGridType = null;
            this.fld_dgcCont.BOSPrivilege = "";
            this.fld_dgcCont.BOSPropertyName = null;
            this.fld_dgcCont.CommodityType = "";
            this.fld_dgcCont.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCont.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcCont.MainView = this.fld_dgvContType;
            this.fld_dgcCont.Name = "fld_dgcCont";
            this.fld_dgcCont.PrintReport = false;
            this.fld_dgcCont.Screen = null;
            this.fld_dgcCont.Size = new System.Drawing.Size(1124, 579);
            this.fld_dgcCont.TabIndex = 4;
            this.fld_dgcCont.Tag = "DC";
            this.fld_dgcCont.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvContType});
            // 
            // fld_dgvContType
            // 
            this.fld_dgvContType.GridControl = this.fld_dgcCont;
            this.fld_dgvContType.Name = "fld_dgvContType";
            this.fld_dgvContType.PaintStyleName = "Office2003";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.bosTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(1153, 956);
            this.panel1.TabIndex = 27;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1153, 956);
            this.bosTabControl1.TabIndex = 30;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPanel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1151, 931);
            this.xtraTabPage1.Text = "Thông tin chung";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl9);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1151, 931);
            this.bosPanel1.TabIndex = 336;
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_dgcARDeliveryMethods);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(6, 283);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(1138, 641);
            this.bosLine4.TabIndex = 29;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Phương thức giao hàng";
            // 
            // fld_dgcARDeliveryMethods
            // 
            this.fld_dgcARDeliveryMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryMethods.BOSComment = null;
            this.fld_dgcARDeliveryMethods.BOSDataMember = null;
            this.fld_dgcARDeliveryMethods.BOSDataSource = "ARDeliveryMethods";
            this.fld_dgcARDeliveryMethods.BOSDescription = null;
            this.fld_dgcARDeliveryMethods.BOSError = null;
            this.fld_dgcARDeliveryMethods.BOSFieldGroup = null;
            this.fld_dgcARDeliveryMethods.BOSFieldRelation = null;
            this.fld_dgcARDeliveryMethods.BOSGridType = null;
            this.fld_dgcARDeliveryMethods.BOSPrivilege = null;
            this.fld_dgcARDeliveryMethods.BOSPropertyName = null;
            this.fld_dgcARDeliveryMethods.CommodityType = "";
            this.fld_dgcARDeliveryMethods.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARDeliveryMethods.Name = "fld_dgcARDeliveryMethods";
            this.fld_dgcARDeliveryMethods.PrintReport = false;
            this.fld_dgcARDeliveryMethods.Screen = null;
            this.fld_dgcARDeliveryMethods.Size = new System.Drawing.Size(1132, 618);
            this.fld_dgcARDeliveryMethods.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_grpGroupControl12);
            this.xtraTabPage3.Controls.Add(this.fld_grpGroupControl6);
            this.xtraTabPage3.Controls.Add(this.fld_lblLabel1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1137, 924);
            this.xtraTabPage3.Text = "Mức thuế - Loại cont";
            // 
            // fld_grpGroupControl12
            // 
            this.fld_grpGroupControl12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpGroupControl12.BOSComment = null;
            this.fld_grpGroupControl12.BOSDataMember = null;
            this.fld_grpGroupControl12.BOSDataSource = null;
            this.fld_grpGroupControl12.BOSDescription = null;
            this.fld_grpGroupControl12.BOSError = null;
            this.fld_grpGroupControl12.BOSFieldGroup = null;
            this.fld_grpGroupControl12.BOSFieldRelation = null;
            this.fld_grpGroupControl12.BOSPrivilege = null;
            this.fld_grpGroupControl12.BOSPropertyName = null;
            this.fld_grpGroupControl12.Controls.Add(this.fld_dgcTaxPercentType);
            this.fld_grpGroupControl12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl12.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl12.Name = "fld_grpGroupControl12";
            this.fld_grpGroupControl12.Screen = null;
            this.fld_grpGroupControl12.Size = new System.Drawing.Size(1131, 310);
            this.fld_grpGroupControl12.TabIndex = 26;
            this.fld_grpGroupControl12.TabStop = false;
            this.fld_grpGroupControl12.Text = "Mức thuế";
            // 
            // fld_dgcTaxPercentType
            // 
            this.fld_dgcTaxPercentType.AllowDrop = true;
            this.fld_dgcTaxPercentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcTaxPercentType.BOSComment = "";
            this.fld_dgcTaxPercentType.BOSDataMember = null;
            this.fld_dgcTaxPercentType.BOSDataSource = "GEVATs";
            this.fld_dgcTaxPercentType.BOSDescription = null;
            this.fld_dgcTaxPercentType.BOSError = "";
            this.fld_dgcTaxPercentType.BOSFieldGroup = "";
            this.fld_dgcTaxPercentType.BOSFieldRelation = null;
            this.fld_dgcTaxPercentType.BOSGridType = null;
            this.fld_dgcTaxPercentType.BOSPrivilege = "";
            this.fld_dgcTaxPercentType.BOSPropertyName = null;
            this.fld_dgcTaxPercentType.CommodityType = "";
            this.fld_dgcTaxPercentType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcTaxPercentType.Location = new System.Drawing.Point(6, 17);
            this.fld_dgcTaxPercentType.MainView = this.fld_dgvTaxPercentType;
            this.fld_dgcTaxPercentType.Name = "fld_dgcTaxPercentType";
            this.fld_dgcTaxPercentType.PrintReport = false;
            this.fld_dgcTaxPercentType.Screen = null;
            this.fld_dgcTaxPercentType.Size = new System.Drawing.Size(1125, 287);
            this.fld_dgcTaxPercentType.TabIndex = 19;
            this.fld_dgcTaxPercentType.Tag = "DC";
            this.fld_dgcTaxPercentType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvTaxPercentType});
            // 
            // fld_dgvTaxPercentType
            // 
            this.fld_dgvTaxPercentType.GridControl = this.fld_dgcTaxPercentType;
            this.fld_dgvTaxPercentType.Name = "fld_dgvTaxPercentType";
            this.fld_dgvTaxPercentType.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosPanel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1151, 931);
            this.xtraTabPage2.Text = "Cấu hình khác";
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
            this.bosPanel2.Controls.Add(this.bosLine6);
            this.bosPanel2.Controls.Add(this.bosLine8);
            this.bosPanel2.Controls.Add(this.bosLine2);
            this.bosPanel2.Controls.Add(this.fld_grpGroupControl10);
            this.bosPanel2.Controls.Add(this.bosLine1);
            this.bosPanel2.Controls.Add(this.fld_grpGroupControl11);
            this.bosPanel2.Controls.Add(this.bosLine3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1151, 931);
            this.bosPanel2.TabIndex = 337;
            // 
            // bosLine6
            // 
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_dgcARSaleOrderSaleTypeConfigs);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(6, 678);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(788, 174);
            this.bosLine6.TabIndex = 33;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Hình thức bán hàng và loại tiền tệ";
            // 
            // fld_dgcARSaleOrderSaleTypeConfigs
            // 
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSComment = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSDataMember = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSDataSource = "ARSaleOrderSaleTypeConfigs";
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSDescription = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSError = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSGridType = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSPrivilege = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.BOSPropertyName = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.CommodityType = "";
            this.fld_dgcARSaleOrderSaleTypeConfigs.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcARSaleOrderSaleTypeConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderSaleTypeConfigs.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARSaleOrderSaleTypeConfigs.Name = "fld_dgcARSaleOrderSaleTypeConfigs";
            this.fld_dgcARSaleOrderSaleTypeConfigs.PrintReport = false;
            this.fld_dgcARSaleOrderSaleTypeConfigs.Screen = null;
            this.fld_dgcARSaleOrderSaleTypeConfigs.Size = new System.Drawing.Size(782, 154);
            this.fld_dgcARSaleOrderSaleTypeConfigs.TabIndex = 0;
            // 
            // bosLine8
            // 
            this.bosLine8.BOSComment = null;
            this.bosLine8.BOSDataMember = null;
            this.bosLine8.BOSDataSource = null;
            this.bosLine8.BOSDescription = null;
            this.bosLine8.BOSError = null;
            this.bosLine8.BOSFieldGroup = null;
            this.bosLine8.BOSFieldRelation = null;
            this.bosLine8.BOSPrivilege = null;
            this.bosLine8.BOSPropertyName = null;
            this.bosLine8.Controls.Add(this.fld_lkeCSSourceSellingPriceMethod);
            this.bosLine8.Controls.Add(this.bosLabel5);
            this.bosLine8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine8.Location = new System.Drawing.Point(392, 103);
            this.bosLine8.Name = "bosLine8";
            this.bosLine8.Screen = null;
            this.bosLine8.Size = new System.Drawing.Size(399, 48);
            this.bosLine8.TabIndex = 32;
            this.bosLine8.TabStop = false;
            this.bosLine8.Text = "Nguồn giá bán";
            // 
            // fld_lkeCSSourceSellingPriceMethod
            // 
            this.fld_lkeCSSourceSellingPriceMethod.BOSAllowAddNew = false;
            this.fld_lkeCSSourceSellingPriceMethod.BOSAllowDummy = false;
            this.fld_lkeCSSourceSellingPriceMethod.BOSComment = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSDataMember = "CSSourceSellingPriceMethod";
            this.fld_lkeCSSourceSellingPriceMethod.BOSDataSource = "CSCompanys";
            this.fld_lkeCSSourceSellingPriceMethod.BOSDescription = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSError = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSFieldGroup = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSFieldParent = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSFieldRelation = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSPrivilege = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSPropertyName = "EditValue";
            this.fld_lkeCSSourceSellingPriceMethod.BOSSelectType = null;
            this.fld_lkeCSSourceSellingPriceMethod.BOSSelectTypeValue = null;
            this.fld_lkeCSSourceSellingPriceMethod.CurrentDisplayText = null;
            this.fld_lkeCSSourceSellingPriceMethod.Location = new System.Drawing.Point(102, 19);
            this.fld_lkeCSSourceSellingPriceMethod.Name = "fld_lkeCSSourceSellingPriceMethod";
            this.fld_lkeCSSourceSellingPriceMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCSSourceSellingPriceMethod.Properties.ColumnName = null;
            this.fld_lkeCSSourceSellingPriceMethod.Screen = null;
            this.fld_lkeCSSourceSellingPriceMethod.Size = new System.Drawing.Size(179, 20);
            this.fld_lkeCSSourceSellingPriceMethod.TabIndex = 19;
            this.fld_lkeCSSourceSellingPriceMethod.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(6, 22);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(69, 13);
            this.bosLabel5.TabIndex = 16;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Nguồn giá bán";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosLine5);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 530);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(785, 142);
            this.bosLine2.TabIndex = 28;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Danh mục kênh bán hàng";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_dgcListOfSalesChannelType);
            this.bosLine5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine5.Location = new System.Drawing.Point(3, 17);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(779, 122);
            this.bosLine5.TabIndex = 29;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Tên kênh bán hàng";
            // 
            // fld_dgcListOfSalesChannelType
            // 
            this.fld_dgcListOfSalesChannelType.AllowDrop = true;
            this.fld_dgcListOfSalesChannelType.BOSComment = " ";
            this.fld_dgcListOfSalesChannelType.BOSDataMember = null;
            this.fld_dgcListOfSalesChannelType.BOSDataSource = "";
            this.fld_dgcListOfSalesChannelType.BOSDescription = null;
            this.fld_dgcListOfSalesChannelType.BOSError = " ";
            this.fld_dgcListOfSalesChannelType.BOSFieldGroup = " ";
            this.fld_dgcListOfSalesChannelType.BOSFieldRelation = null;
            this.fld_dgcListOfSalesChannelType.BOSGridType = null;
            this.fld_dgcListOfSalesChannelType.BOSPrivilege = " ";
            this.fld_dgcListOfSalesChannelType.BOSPropertyName = null;
            this.fld_dgcListOfSalesChannelType.CommodityType = "";
            this.fld_dgcListOfSalesChannelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcListOfSalesChannelType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcListOfSalesChannelType.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcListOfSalesChannelType.MainView = this.fld_dgvCustomerType;
            this.fld_dgcListOfSalesChannelType.Name = "fld_dgcListOfSalesChannelType";
            this.fld_dgcListOfSalesChannelType.PrintReport = false;
            this.fld_dgcListOfSalesChannelType.Screen = null;
            this.fld_dgcListOfSalesChannelType.Size = new System.Drawing.Size(773, 102);
            this.fld_dgcListOfSalesChannelType.TabIndex = 5;
            this.fld_dgcListOfSalesChannelType.Tag = "DC";
            this.fld_dgcListOfSalesChannelType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvCustomerType});
            // 
            // fld_dgvCustomerType
            // 
            this.fld_dgvCustomerType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.fld_dgvCustomerType.GridControl = this.fld_dgcListOfSalesChannelType;
            this.fld_dgvCustomerType.Name = "fld_dgvCustomerType";
            this.fld_dgvCustomerType.PaintStyleName = "Office2003";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // fld_grpGroupControl10
            // 
            this.fld_grpGroupControl10.BOSComment = null;
            this.fld_grpGroupControl10.BOSDataMember = null;
            this.fld_grpGroupControl10.BOSDataSource = null;
            this.fld_grpGroupControl10.BOSDescription = null;
            this.fld_grpGroupControl10.BOSError = null;
            this.fld_grpGroupControl10.BOSFieldGroup = null;
            this.fld_grpGroupControl10.BOSFieldRelation = null;
            this.fld_grpGroupControl10.BOSPrivilege = null;
            this.fld_grpGroupControl10.BOSPropertyName = null;
            this.fld_grpGroupControl10.Controls.Add(this.bosLabel4);
            this.fld_grpGroupControl10.Controls.Add(this.bosLabel3);
            this.fld_grpGroupControl10.Controls.Add(this.bosLabel2);
            this.fld_grpGroupControl10.Controls.Add(this.bosLabel1);
            this.fld_grpGroupControl10.Controls.Add(this.fld_txtDeliveryDueDays);
            this.fld_grpGroupControl10.Controls.Add(this.fld_lblLabel);
            this.fld_grpGroupControl10.Controls.Add(this.fld_lblLabel4);
            this.fld_grpGroupControl10.Controls.Add(this.fld_lblLabel3);
            this.fld_grpGroupControl10.Controls.Add(this.fld_lblLabel2);
            this.fld_grpGroupControl10.Controls.Add(this.fld_txtPaymentDueDays);
            this.fld_grpGroupControl10.Controls.Add(this.fld_txtAssSellerCommissionPercent);
            this.fld_grpGroupControl10.Controls.Add(this.fld_txtMainSellerCommissionPercent);
            this.fld_grpGroupControl10.Controls.Add(this.fld_txtInitialDeposit);
            this.fld_grpGroupControl10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl10.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl10.Name = "fld_grpGroupControl10";
            this.fld_grpGroupControl10.Screen = null;
            this.fld_grpGroupControl10.Size = new System.Drawing.Size(788, 94);
            this.fld_grpGroupControl10.TabIndex = 30;
            this.fld_grpGroupControl10.TabStop = false;
            this.fld_grpGroupControl10.Text = "Đặt hàng";
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
            this.bosLabel4.Location = new System.Drawing.Point(409, 49);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(131, 13);
            this.bosLabel4.TabIndex = 17;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "% hoa hồng người bán phụ";
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
            this.bosLabel3.Location = new System.Drawing.Point(409, 20);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(138, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "% hoa hồng người bán chính";
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(6, 71);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(97, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Nhắc giao trước hẹn";
            // 
            // bosLabel1
            // 
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(292, 71);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(24, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "ngày";
            // 
            // fld_txtDeliveryDueDays
            // 
            this.fld_txtDeliveryDueDays.BOSComment = "";
            this.fld_txtDeliveryDueDays.BOSDataMember = "TextBox";
            this.fld_txtDeliveryDueDays.BOSDataSource = "";
            this.fld_txtDeliveryDueDays.BOSDescription = null;
            this.fld_txtDeliveryDueDays.BOSError = "";
            this.fld_txtDeliveryDueDays.BOSFieldGroup = "";
            this.fld_txtDeliveryDueDays.BOSFieldRelation = "";
            this.fld_txtDeliveryDueDays.BOSPrivilege = "";
            this.fld_txtDeliveryDueDays.BOSPropertyName = "Text";
            this.fld_txtDeliveryDueDays.Location = new System.Drawing.Point(177, 68);
            this.fld_txtDeliveryDueDays.Name = "fld_txtDeliveryDueDays";
            this.fld_txtDeliveryDueDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryDueDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryDueDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryDueDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryDueDays.Properties.Mask.EditMask = "d";
            this.fld_txtDeliveryDueDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtDeliveryDueDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryDueDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryDueDays.Screen = null;
            this.fld_txtDeliveryDueDays.Size = new System.Drawing.Size(100, 20);
            this.fld_txtDeliveryDueDays.TabIndex = 3;
            this.fld_txtDeliveryDueDays.Tag = "DC";
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
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(6, 20);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel.TabIndex = 8;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "% trả trước";
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
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(295, 20);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(11, 13);
            this.fld_lblLabel4.TabIndex = 14;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "%";
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(292, 45);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel3.TabIndex = 13;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "ngày";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(6, 45);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(130, 13);
            this.fld_lblLabel2.TabIndex = 12;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Nhắc thanh toán trước hẹn";
            // 
            // fld_txtPaymentDueDays
            // 
            this.fld_txtPaymentDueDays.BOSComment = "";
            this.fld_txtPaymentDueDays.BOSDataMember = "TextBox";
            this.fld_txtPaymentDueDays.BOSDataSource = "";
            this.fld_txtPaymentDueDays.BOSDescription = null;
            this.fld_txtPaymentDueDays.BOSError = "";
            this.fld_txtPaymentDueDays.BOSFieldGroup = "";
            this.fld_txtPaymentDueDays.BOSFieldRelation = "";
            this.fld_txtPaymentDueDays.BOSPrivilege = "";
            this.fld_txtPaymentDueDays.BOSPropertyName = "Text";
            this.fld_txtPaymentDueDays.Location = new System.Drawing.Point(177, 42);
            this.fld_txtPaymentDueDays.Name = "fld_txtPaymentDueDays";
            this.fld_txtPaymentDueDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentDueDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentDueDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentDueDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentDueDays.Properties.Mask.EditMask = "d";
            this.fld_txtPaymentDueDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtPaymentDueDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentDueDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentDueDays.Screen = null;
            this.fld_txtPaymentDueDays.Size = new System.Drawing.Size(100, 20);
            this.fld_txtPaymentDueDays.TabIndex = 2;
            this.fld_txtPaymentDueDays.Tag = "DC";
            // 
            // fld_txtAssSellerCommissionPercent
            // 
            this.fld_txtAssSellerCommissionPercent.BOSComment = "";
            this.fld_txtAssSellerCommissionPercent.BOSDataMember = "TextBox";
            this.fld_txtAssSellerCommissionPercent.BOSDataSource = "";
            this.fld_txtAssSellerCommissionPercent.BOSDescription = null;
            this.fld_txtAssSellerCommissionPercent.BOSError = "";
            this.fld_txtAssSellerCommissionPercent.BOSFieldGroup = "";
            this.fld_txtAssSellerCommissionPercent.BOSFieldRelation = "";
            this.fld_txtAssSellerCommissionPercent.BOSPrivilege = "";
            this.fld_txtAssSellerCommissionPercent.BOSPropertyName = "Text";
            this.fld_txtAssSellerCommissionPercent.Location = new System.Drawing.Point(570, 46);
            this.fld_txtAssSellerCommissionPercent.Name = "fld_txtAssSellerCommissionPercent";
            this.fld_txtAssSellerCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAssSellerCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAssSellerCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAssSellerCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAssSellerCommissionPercent.Properties.Mask.EditMask = "n2";
            this.fld_txtAssSellerCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAssSellerCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAssSellerCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAssSellerCommissionPercent.Screen = null;
            this.fld_txtAssSellerCommissionPercent.Size = new System.Drawing.Size(100, 20);
            this.fld_txtAssSellerCommissionPercent.TabIndex = 5;
            this.fld_txtAssSellerCommissionPercent.Tag = "DC";
            // 
            // fld_txtMainSellerCommissionPercent
            // 
            this.fld_txtMainSellerCommissionPercent.BOSComment = "";
            this.fld_txtMainSellerCommissionPercent.BOSDataMember = "";
            this.fld_txtMainSellerCommissionPercent.BOSDataSource = "";
            this.fld_txtMainSellerCommissionPercent.BOSDescription = null;
            this.fld_txtMainSellerCommissionPercent.BOSError = "";
            this.fld_txtMainSellerCommissionPercent.BOSFieldGroup = "";
            this.fld_txtMainSellerCommissionPercent.BOSFieldRelation = "";
            this.fld_txtMainSellerCommissionPercent.BOSPrivilege = "";
            this.fld_txtMainSellerCommissionPercent.BOSPropertyName = "Text";
            this.fld_txtMainSellerCommissionPercent.Location = new System.Drawing.Point(570, 17);
            this.fld_txtMainSellerCommissionPercent.Name = "fld_txtMainSellerCommissionPercent";
            this.fld_txtMainSellerCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMainSellerCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMainSellerCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMainSellerCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMainSellerCommissionPercent.Properties.Mask.EditMask = "n2";
            this.fld_txtMainSellerCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMainSellerCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMainSellerCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMainSellerCommissionPercent.Screen = null;
            this.fld_txtMainSellerCommissionPercent.Size = new System.Drawing.Size(100, 20);
            this.fld_txtMainSellerCommissionPercent.TabIndex = 4;
            this.fld_txtMainSellerCommissionPercent.Tag = "DC";
            // 
            // fld_txtInitialDeposit
            // 
            this.fld_txtInitialDeposit.BOSComment = "";
            this.fld_txtInitialDeposit.BOSDataMember = "TextBox";
            this.fld_txtInitialDeposit.BOSDataSource = "";
            this.fld_txtInitialDeposit.BOSDescription = null;
            this.fld_txtInitialDeposit.BOSError = "";
            this.fld_txtInitialDeposit.BOSFieldGroup = "";
            this.fld_txtInitialDeposit.BOSFieldRelation = "";
            this.fld_txtInitialDeposit.BOSPrivilege = "";
            this.fld_txtInitialDeposit.BOSPropertyName = "Text";
            this.fld_txtInitialDeposit.Location = new System.Drawing.Point(177, 17);
            this.fld_txtInitialDeposit.Name = "fld_txtInitialDeposit";
            this.fld_txtInitialDeposit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInitialDeposit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInitialDeposit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInitialDeposit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInitialDeposit.Properties.Mask.EditMask = "n2";
            this.fld_txtInitialDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtInitialDeposit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInitialDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInitialDeposit.Screen = null;
            this.fld_txtInitialDeposit.Size = new System.Drawing.Size(100, 20);
            this.fld_txtInitialDeposit.TabIndex = 1;
            this.fld_txtInitialDeposit.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcGESaleCosts);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 354);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(788, 174);
            this.bosLine1.TabIndex = 27;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Chi phí bán hàng";
            // 
            // fld_dgcGESaleCosts
            // 
            this.fld_dgcGESaleCosts.BOSComment = null;
            this.fld_dgcGESaleCosts.BOSDataMember = null;
            this.fld_dgcGESaleCosts.BOSDataSource = "ICFeeConfigs";
            this.fld_dgcGESaleCosts.BOSDescription = null;
            this.fld_dgcGESaleCosts.BOSError = null;
            this.fld_dgcGESaleCosts.BOSFieldGroup = null;
            this.fld_dgcGESaleCosts.BOSFieldRelation = null;
            this.fld_dgcGESaleCosts.BOSGridType = null;
            this.fld_dgcGESaleCosts.BOSPrivilege = null;
            this.fld_dgcGESaleCosts.BOSPropertyName = null;
            this.fld_dgcGESaleCosts.CommodityType = "";
            this.fld_dgcGESaleCosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcGESaleCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGESaleCosts.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcGESaleCosts.Name = "fld_dgcGESaleCosts";
            this.fld_dgcGESaleCosts.PrintReport = false;
            this.fld_dgcGESaleCosts.Screen = null;
            this.fld_dgcGESaleCosts.Size = new System.Drawing.Size(782, 154);
            this.fld_dgcGESaleCosts.TabIndex = 0;
            // 
            // fld_grpGroupControl11
            // 
            this.fld_grpGroupControl11.BOSComment = null;
            this.fld_grpGroupControl11.BOSDataMember = null;
            this.fld_grpGroupControl11.BOSDataSource = null;
            this.fld_grpGroupControl11.BOSDescription = null;
            this.fld_grpGroupControl11.BOSError = null;
            this.fld_grpGroupControl11.BOSFieldGroup = null;
            this.fld_grpGroupControl11.BOSFieldRelation = null;
            this.fld_grpGroupControl11.BOSPrivilege = null;
            this.fld_grpGroupControl11.BOSPropertyName = null;
            this.fld_grpGroupControl11.Controls.Add(this.fld_lblLabel21);
            this.fld_grpGroupControl11.Controls.Add(this.fld_lblLabel22);
            this.fld_grpGroupControl11.Controls.Add(this.fld_txtValidDays);
            this.fld_grpGroupControl11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl11.Location = new System.Drawing.Point(3, 103);
            this.fld_grpGroupControl11.Name = "fld_grpGroupControl11";
            this.fld_grpGroupControl11.Screen = null;
            this.fld_grpGroupControl11.Size = new System.Drawing.Size(377, 48);
            this.fld_grpGroupControl11.TabIndex = 31;
            this.fld_grpGroupControl11.TabStop = false;
            this.fld_grpGroupControl11.Text = "Phiếu quà tặng";
            // 
            // fld_lblLabel21
            // 
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
            this.fld_lblLabel21.BOSPropertyName = null;
            this.fld_lblLabel21.Location = new System.Drawing.Point(6, 22);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(81, 13);
            this.fld_lblLabel21.TabIndex = 16;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Số ngày sử dụng";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = null;
            this.fld_lblLabel22.Location = new System.Drawing.Point(231, 22);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel22.TabIndex = 18;
            this.fld_lblLabel22.Tag = "";
            this.fld_lblLabel22.Text = "ngày";
            // 
            // fld_txtValidDays
            // 
            this.fld_txtValidDays.BOSComment = "";
            this.fld_txtValidDays.BOSDataMember = "TextBox";
            this.fld_txtValidDays.BOSDataSource = "";
            this.fld_txtValidDays.BOSDescription = null;
            this.fld_txtValidDays.BOSError = "";
            this.fld_txtValidDays.BOSFieldGroup = "";
            this.fld_txtValidDays.BOSFieldRelation = "";
            this.fld_txtValidDays.BOSPrivilege = "";
            this.fld_txtValidDays.BOSPropertyName = "Text";
            this.fld_txtValidDays.Location = new System.Drawing.Point(113, 19);
            this.fld_txtValidDays.Name = "fld_txtValidDays";
            this.fld_txtValidDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtValidDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtValidDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtValidDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtValidDays.Properties.Mask.EditMask = "d";
            this.fld_txtValidDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtValidDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtValidDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtValidDays.Screen = null;
            this.fld_txtValidDays.Size = new System.Drawing.Size(100, 20);
            this.fld_txtValidDays.TabIndex = 3;
            this.fld_txtValidDays.Tag = "DC";
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_dgcARSaleContractGroups);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(3, 157);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(788, 193);
            this.bosLine3.TabIndex = 29;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Nhóm hợp đồng bán";
            // 
            // fld_dgcARSaleContractGroups
            // 
            this.fld_dgcARSaleContractGroups.BOSComment = null;
            this.fld_dgcARSaleContractGroups.BOSDataMember = null;
            this.fld_dgcARSaleContractGroups.BOSDataSource = "ARSaleContractGroups";
            this.fld_dgcARSaleContractGroups.BOSDescription = null;
            this.fld_dgcARSaleContractGroups.BOSError = null;
            this.fld_dgcARSaleContractGroups.BOSFieldGroup = null;
            this.fld_dgcARSaleContractGroups.BOSFieldRelation = null;
            this.fld_dgcARSaleContractGroups.BOSGridType = null;
            this.fld_dgcARSaleContractGroups.BOSPrivilege = null;
            this.fld_dgcARSaleContractGroups.BOSPropertyName = null;
            this.fld_dgcARSaleContractGroups.CommodityType = "";
            this.fld_dgcARSaleContractGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleContractGroups.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARSaleContractGroups.Name = "fld_dgcARSaleContractGroups";
            this.fld_dgcARSaleContractGroups.PrintReport = false;
            this.fld_dgcARSaleContractGroups.Screen = null;
            this.fld_dgcARSaleContractGroups.Size = new System.Drawing.Size(782, 173);
            this.fld_dgcARSaleContractGroups.TabIndex = 0;
            // 
            // DMCS103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1153, 956);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS103.IconOptions.Icon")));
            this.Name = "DMCS103";
            this.Text = "Cấu hình bán hàng";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvPaymentType)).EndInit();
            this.fld_grpGroupControl9.ResumeLayout(false);
            this.fld_grpGroupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvContType)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryMethods)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.fld_grpGroupControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTaxPercentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTaxPercentType)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderSaleTypeConfigs)).EndInit();
            this.bosLine8.ResumeLayout(false);
            this.bosLine8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCSSourceSellingPriceMethod.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcListOfSalesChannelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).EndInit();
            this.fld_grpGroupControl10.ResumeLayout(false);
            this.fld_grpGroupControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryDueDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentDueDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAssSellerCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMainSellerCommissionPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInitialDeposit.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGESaleCosts)).EndInit();
            this.fld_grpGroupControl11.ResumeLayout(false);
            this.fld_grpGroupControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtValidDays.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleContractGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine fld_grpGroupControl9;
        private BOSComponent.BOSLine fld_grpGroupControl6;
        private ContainerTypeGridControl fld_dgcCont;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvContType;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine bosLine1;
        private GESaleCostsGridControl fld_dgcGESaleCosts;
        private BOSComponent.BOSLine bosLine3;
        private ARSaleContractGroupsGridControl fld_dgcARSaleContractGroups;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLine bosLine4;
        private ARDeliveryMethodsGridControl fld_dgcARDeliveryMethods;
        private BOSComponent.BOSLine fld_grpGroupControl10;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtDeliveryDueDays;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtPaymentDueDays;
        private BOSComponent.BOSTextBox fld_txtAssSellerCommissionPercent;
        private BOSComponent.BOSTextBox fld_txtMainSellerCommissionPercent;
        private BOSComponent.BOSTextBox fld_txtInitialDeposit;
        private BOSComponent.BOSLine fld_grpGroupControl11;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSTextBox fld_txtValidDays;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSLine fld_grpGroupControl12;
        private TaxPercentTypeGridControl fld_dgcTaxPercentType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvTaxPercentType;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLine bosLine5;
        private ListOfSalesChannelTypeGridControl fld_dgcListOfSalesChannelType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private BOSComponent.BOSLine bosLine8;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeCSSourceSellingPriceMethod;
        private BOSComponent.BOSLine bosLine6;
        private ARSaleOrderSaleTypeConfigsGridControl fld_dgcARSaleOrderSaleTypeConfigs;
    }
}
