using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CancelVoucher.UI
{
	/// <summary>
	/// Summary description for DMARCV100
	/// </summary>
	partial class DMARCV100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMARCV100));
            this.fld_txtARCancelVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARCancelVoucherEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARCancelVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARCancelVoucherItems = new BOSERP.Modules.CancelVoucher.ARCancelVoucherItemsGridControl();
            this.fld_dgvARCancelVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteARCancelVoucherItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARCancelVoucherComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtARCancelVoucherSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCancelVoucherDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCancelVoucherTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCancelVoucherTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeARCancelVoucherReason = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel85 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcCancelVoucherItemCostsGridControl = new BOSERP.Modules.CancelVoucher.ARCancelVoucherItemCostsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddCost = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderPaymentTimes = new BOSERP.Modules.CancelVoucher.ARSaleOrderPaymentTimesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeARCancelVoucherStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelVoucherEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCancelVoucherItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelVoucherItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCancelVoucherComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherExchangeRate.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCancelVoucherItemCostsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARCancelVoucherNo
            // 
            this.fld_txtARCancelVoucherNo.BOSComment = null;
            this.fld_txtARCancelVoucherNo.BOSDataMember = "ARCancelVoucherNo";
            this.fld_txtARCancelVoucherNo.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherNo.BOSDescription = null;
            this.fld_txtARCancelVoucherNo.BOSError = null;
            this.fld_txtARCancelVoucherNo.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherNo.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherNo.BOSPrivilege = null;
            this.fld_txtARCancelVoucherNo.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherNo.Location = new System.Drawing.Point(194, 12);
            this.fld_txtARCancelVoucherNo.MenuManager = this.screenToolbar;
            this.fld_txtARCancelVoucherNo.Name = "fld_txtARCancelVoucherNo";
            this.fld_txtARCancelVoucherNo.Screen = null;
            this.fld_txtARCancelVoucherNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARCancelVoucherNo.TabIndex = 2;
            this.fld_txtARCancelVoucherNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(128, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_pteARCancelVoucherEmployeePicture
            // 
            this.fld_pteARCancelVoucherEmployeePicture.BOSComment = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSDataMember = "ARCancelVoucherEmployeePicture";
            this.fld_pteARCancelVoucherEmployeePicture.BOSDataSource = "ARCancelVouchers";
            this.fld_pteARCancelVoucherEmployeePicture.BOSDescription = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSError = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSPrivilege = null;
            this.fld_pteARCancelVoucherEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARCancelVoucherEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCancelVoucherEmployeePicture.FileName = null;
            this.fld_pteARCancelVoucherEmployeePicture.FilePath = null;
            this.fld_pteARCancelVoucherEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARCancelVoucherEmployeePicture.Name = "fld_pteARCancelVoucherEmployeePicture";
            this.fld_pteARCancelVoucherEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARCancelVoucherEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARCancelVoucherEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARCancelVoucherEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARCancelVoucherEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCancelVoucherEmployeePicture.Screen = null;
            this.fld_pteARCancelVoucherEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARCancelVoucherEmployeePicture.TabIndex = 0;
            this.fld_pteARCancelVoucherEmployeePicture.Tag = "DC";
            // 
            // fld_dteARCancelVoucherDate
            // 
            this.fld_dteARCancelVoucherDate.BOSComment = null;
            this.fld_dteARCancelVoucherDate.BOSDataMember = "ARCancelVoucherDate";
            this.fld_dteARCancelVoucherDate.BOSDataSource = "ARCancelVouchers";
            this.fld_dteARCancelVoucherDate.BOSDescription = null;
            this.fld_dteARCancelVoucherDate.BOSError = null;
            this.fld_dteARCancelVoucherDate.BOSFieldGroup = null;
            this.fld_dteARCancelVoucherDate.BOSFieldRelation = null;
            this.fld_dteARCancelVoucherDate.BOSPrivilege = null;
            this.fld_dteARCancelVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteARCancelVoucherDate.EditValue = null;
            this.fld_dteARCancelVoucherDate.Location = new System.Drawing.Point(454, 12);
            this.fld_dteARCancelVoucherDate.Name = "fld_dteARCancelVoucherDate";
            this.fld_dteARCancelVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCancelVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCancelVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCancelVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCancelVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCancelVoucherDate.Screen = null;
            this.fld_dteARCancelVoucherDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARCancelVoucherDate.TabIndex = 6;
            this.fld_dteARCancelVoucherDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(376, 15);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_dgcARCancelVoucherItems
            // 
            this.fld_dgcARCancelVoucherItems.AllowDrop = true;
            this.fld_dgcARCancelVoucherItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARCancelVoucherItems.BOSComment = null;
            this.fld_dgcARCancelVoucherItems.BOSDataMember = null;
            this.fld_dgcARCancelVoucherItems.BOSDataSource = "ARCancelVoucherItems";
            this.fld_dgcARCancelVoucherItems.BOSDescription = null;
            this.fld_dgcARCancelVoucherItems.BOSError = null;
            this.fld_dgcARCancelVoucherItems.BOSFieldGroup = null;
            this.fld_dgcARCancelVoucherItems.BOSFieldRelation = null;
            this.fld_dgcARCancelVoucherItems.BOSGridType = null;
            this.fld_dgcARCancelVoucherItems.BOSPrivilege = null;
            this.fld_dgcARCancelVoucherItems.BOSPropertyName = null;
            this.fld_dgcARCancelVoucherItems.CommodityType = null;
            this.fld_dgcARCancelVoucherItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCancelVoucherItems.Location = new System.Drawing.Point(3, 7);
            this.fld_dgcARCancelVoucherItems.MainView = this.fld_dgvARCancelVoucher;
            this.fld_dgcARCancelVoucherItems.Name = "fld_dgcARCancelVoucherItems";
            this.fld_dgcARCancelVoucherItems.PrintReport = false;
            this.fld_dgcARCancelVoucherItems.Screen = null;
            this.fld_dgcARCancelVoucherItems.Size = new System.Drawing.Size(754, 320);
            this.fld_dgcARCancelVoucherItems.TabIndex = 12;
            this.fld_dgcARCancelVoucherItems.Tag = "DC";
            this.fld_dgcARCancelVoucherItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCancelVoucher});
            // 
            // fld_dgvARCancelVoucher
            // 
            this.fld_dgvARCancelVoucher.GridControl = this.fld_dgcARCancelVoucherItems;
            this.fld_dgvARCancelVoucher.Name = "fld_dgvARCancelVoucher";
            this.fld_dgvARCancelVoucher.PaintStyleName = "Office2003";
            // 
            // fld_pteARCancelVoucherItemProductPicture
            // 
            this.fld_pteARCancelVoucherItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARCancelVoucherItemProductPicture.BOSComment = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSDataMember = "ARCancelVoucherItemProductPicture";
            this.fld_pteARCancelVoucherItemProductPicture.BOSDataSource = "ARCancelVoucherItems";
            this.fld_pteARCancelVoucherItemProductPicture.BOSDescription = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSError = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSPrivilege = null;
            this.fld_pteARCancelVoucherItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARCancelVoucherItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCancelVoucherItemProductPicture.FileName = null;
            this.fld_pteARCancelVoucherItemProductPicture.FilePath = null;
            this.fld_pteARCancelVoucherItemProductPicture.Location = new System.Drawing.Point(763, 7);
            this.fld_pteARCancelVoucherItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARCancelVoucherItemProductPicture.Name = "fld_pteARCancelVoucherItemProductPicture";
            this.fld_pteARCancelVoucherItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCancelVoucherItemProductPicture.Screen = null;
            this.fld_pteARCancelVoucherItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteARCancelVoucherItemProductPicture.TabIndex = 60;
            this.fld_pteARCancelVoucherItemProductPicture.Tag = "DC";
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = null;
            this.fld_lblLabel44.BOSDataMember = null;
            this.fld_lblLabel44.BOSDataSource = null;
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = null;
            this.fld_lblLabel44.BOSFieldRelation = null;
            this.fld_lblLabel44.BOSPrivilege = null;
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(592, 521);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 101;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_medARCancelVoucherComment
            // 
            this.fld_medARCancelVoucherComment.BOSComment = null;
            this.fld_medARCancelVoucherComment.BOSDataMember = "ARCancelVoucherDesc";
            this.fld_medARCancelVoucherComment.BOSDataSource = "ARCancelVouchers";
            this.fld_medARCancelVoucherComment.BOSDescription = null;
            this.fld_medARCancelVoucherComment.BOSError = null;
            this.fld_medARCancelVoucherComment.BOSFieldGroup = null;
            this.fld_medARCancelVoucherComment.BOSFieldRelation = null;
            this.fld_medARCancelVoucherComment.BOSPrivilege = null;
            this.fld_medARCancelVoucherComment.BOSPropertyName = "EditValue";
            this.fld_medARCancelVoucherComment.Location = new System.Drawing.Point(194, 90);
            this.fld_medARCancelVoucherComment.Name = "fld_medARCancelVoucherComment";
            this.fld_medARCancelVoucherComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCancelVoucherComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCancelVoucherComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCancelVoucherComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCancelVoucherComment.Screen = null;
            this.fld_medARCancelVoucherComment.Size = new System.Drawing.Size(413, 60);
            this.fld_medARCancelVoucherComment.TabIndex = 0;
            this.fld_medARCancelVoucherComment.Tag = "DC";
            // 
            // fld_txtARCancelVoucherSubTotalAmount
            // 
            this.fld_txtARCancelVoucherSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherSubTotalAmount.BOSComment = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDataMember = "ARCancelVoucherSubTotalAmount";
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSError = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherSubTotalAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherSubTotalAmount.Location = new System.Drawing.Point(708, 518);
            this.fld_txtARCancelVoucherSubTotalAmount.Name = "fld_txtARCancelVoucherSubTotalAmount";
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCancelVoucherSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherSubTotalAmount.Screen = null;
            this.fld_txtARCancelVoucherSubTotalAmount.Size = new System.Drawing.Size(174, 20);
            this.fld_txtARCancelVoucherSubTotalAmount.TabIndex = 11;
            this.fld_txtARCancelVoucherSubTotalAmount.Tag = "DC";
            // 
            // fld_txtARCancelVoucherDiscountFix
            // 
            this.fld_txtARCancelVoucherDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherDiscountFix.BOSComment = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSDataMember = "ARCancelVoucherDiscountFix";
            this.fld_txtARCancelVoucherDiscountFix.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherDiscountFix.BOSDescription = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSError = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSPrivilege = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherDiscountFix.EditValue = "0.00";
            this.fld_txtARCancelVoucherDiscountFix.Location = new System.Drawing.Point(782, 545);
            this.fld_txtARCancelVoucherDiscountFix.Name = "fld_txtARCancelVoucherDiscountFix";
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherDiscountFix.Screen = null;
            this.fld_txtARCancelVoucherDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCancelVoucherDiscountFix.TabIndex = 13;
            this.fld_txtARCancelVoucherDiscountFix.Tag = "DC";
            this.fld_txtARCancelVoucherDiscountFix.Validated += new System.EventHandler(this.fld_txtARCancelVoucherDiscountFix_Validated);
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(592, 574);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel46.TabIndex = 103;
            this.fld_lblLabel46.Text = "Thuế";
            // 
            // fld_lblLabel45
            // 
            this.fld_lblLabel45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel45.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel45.BOSComment = null;
            this.fld_lblLabel45.BOSDataMember = null;
            this.fld_lblLabel45.BOSDataSource = null;
            this.fld_lblLabel45.BOSDescription = null;
            this.fld_lblLabel45.BOSError = null;
            this.fld_lblLabel45.BOSFieldGroup = null;
            this.fld_lblLabel45.BOSFieldRelation = null;
            this.fld_lblLabel45.BOSPrivilege = null;
            this.fld_lblLabel45.BOSPropertyName = null;
            this.fld_lblLabel45.Location = new System.Drawing.Point(592, 548);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel45.TabIndex = 102;
            this.fld_lblLabel45.Text = "Chiết khấu";
            // 
            // fld_txtARCancelVoucherDiscountPerCent
            // 
            this.fld_txtARCancelVoucherDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherDiscountPerCent.BOSComment = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDataMember = "ARCancelVoucherDiscountPerCent";
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDescription = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSError = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSPrivilege = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherDiscountPerCent.EditValue = "0.00";
            this.fld_txtARCancelVoucherDiscountPerCent.Location = new System.Drawing.Point(708, 545);
            this.fld_txtARCancelVoucherDiscountPerCent.Name = "fld_txtARCancelVoucherDiscountPerCent";
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherDiscountPerCent.Screen = null;
            this.fld_txtARCancelVoucherDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARCancelVoucherDiscountPerCent.TabIndex = 12;
            this.fld_txtARCancelVoucherDiscountPerCent.Tag = "DC";
            this.fld_txtARCancelVoucherDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARCancelVoucherDiscountPerCent_Validated);
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = null;
            this.fld_lblLabel47.BOSDataMember = null;
            this.fld_lblLabel47.BOSDataSource = null;
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = null;
            this.fld_lblLabel47.BOSFieldRelation = null;
            this.fld_lblLabel47.BOSPrivilege = null;
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(592, 602);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 104;
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtARCancelVoucherTotalAmount
            // 
            this.fld_txtARCancelVoucherTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTotalAmount.BOSComment = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSDataMember = "ARCancelVoucherTotalAmount";
            this.fld_txtARCancelVoucherTotalAmount.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherTotalAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSError = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTotalAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherTotalAmount.Location = new System.Drawing.Point(708, 599);
            this.fld_txtARCancelVoucherTotalAmount.Name = "fld_txtARCancelVoucherTotalAmount";
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCancelVoucherTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTotalAmount.Screen = null;
            this.fld_txtARCancelVoucherTotalAmount.Size = new System.Drawing.Size(174, 20);
            this.fld_txtARCancelVoucherTotalAmount.TabIndex = 16;
            this.fld_txtARCancelVoucherTotalAmount.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCancelVouchers";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
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
            // 
            // fld_txtARCancelVoucherTaxPercent
            // 
            this.fld_txtARCancelVoucherTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTaxPercent.BOSComment = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSDataMember = "ARCancelVoucherTaxPercent";
            this.fld_txtARCancelVoucherTaxPercent.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherTaxPercent.BOSDescription = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSError = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTaxPercent.EditValue = "0.00";
            this.fld_txtARCancelVoucherTaxPercent.Location = new System.Drawing.Point(708, 571);
            this.fld_txtARCancelVoucherTaxPercent.Name = "fld_txtARCancelVoucherTaxPercent";
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTaxPercent.Screen = null;
            this.fld_txtARCancelVoucherTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARCancelVoucherTaxPercent.TabIndex = 14;
            this.fld_txtARCancelVoucherTaxPercent.Tag = "DC";
            this.fld_txtARCancelVoucherTaxPercent.Validated += new System.EventHandler(this.fld_txtARCancelVoucherTaxPerCent_Validated);
            // 
            // fld_txtARCancelVoucherTaxAmount
            // 
            this.fld_txtARCancelVoucherTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTaxAmount.BOSComment = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSDataMember = "ARCancelVoucherTaxAmount";
            this.fld_txtARCancelVoucherTaxAmount.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherTaxAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSError = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTaxAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherTaxAmount.Location = new System.Drawing.Point(782, 571);
            this.fld_txtARCancelVoucherTaxAmount.Name = "fld_txtARCancelVoucherTaxAmount";
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTaxAmount.Screen = null;
            this.fld_txtARCancelVoucherTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCancelVoucherTaxAmount.TabIndex = 15;
            this.fld_txtARCancelVoucherTaxAmount.Tag = "DC";
            this.fld_txtARCancelVoucherTaxAmount.Validated += new System.EventHandler(this.fld_txtARCancelVoucherTaxAmount_Validated);
            // 
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = null;
            this.fld_txtARSaleOrderNo.BOSDataMember = "ARSaleOrderNo";
            this.fld_txtARSaleOrderNo.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = null;
            this.fld_txtARSaleOrderNo.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(454, 39);
            this.fld_txtARSaleOrderNo.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 7;
            this.fld_txtARSaleOrderNo.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(376, 42);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(62, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Mã đơn hàng";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCancelVouchers";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(194, 64);
            this.fld_lkeFK_GECurrencyID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
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
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(376, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(128, 66);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Loại tiền tệ";
            // 
            // fld_txtARCancelVoucherExchangeRate
            // 
            this.fld_txtARCancelVoucherExchangeRate.BOSComment = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSDataMember = "ARCancelVoucherExchangeRate";
            this.fld_txtARCancelVoucherExchangeRate.BOSDataSource = "ARCancelVouchers";
            this.fld_txtARCancelVoucherExchangeRate.BOSDescription = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSError = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSPrivilege = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherExchangeRate.Location = new System.Drawing.Point(454, 64);
            this.fld_txtARCancelVoucherExchangeRate.Name = "fld_txtARCancelVoucherExchangeRate";
            this.fld_txtARCancelVoucherExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARCancelVoucherExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherExchangeRate.Screen = null;
            this.fld_txtARCancelVoucherExchangeRate.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARCancelVoucherExchangeRate.TabIndex = 8;
            this.fld_txtARCancelVoucherExchangeRate.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_medARCancelVoucherComment);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosTextBox6);
            this.bosPanel1.Controls.Add(this.bosTextBox5);
            this.bosPanel1.Controls.Add(this.fld_lkeARCancelVoucherReason);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel38);
            this.bosPanel1.Controls.Add(this.bosLabel85);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeARCancelVoucherStatus);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_pteARCancelVoucherEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderNo);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel45);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleOrderDate);
            this.bosPanel1.Controls.Add(this.fld_dteARCancelVoucherDate);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherSubTotalAmount);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(903, 630);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARCancelVoucherSaleContract";
            this.bosTextBox6.BOSDataSource = "ARCancelVouchers";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(717, 38);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(153, 20);
            this.bosTextBox6.TabIndex = 842;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARCancelVoucherProject";
            this.bosTextBox5.BOSDataSource = "ARCancelVouchers";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(717, 12);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox5, true);
            this.bosTextBox5.Size = new System.Drawing.Size(153, 20);
            this.bosTextBox5.TabIndex = 841;
            this.bosTextBox5.Tag = "DC";
            // 
            // fld_lkeARCancelVoucherReason
            // 
            this.fld_lkeARCancelVoucherReason.BOSAllowAddNew = false;
            this.fld_lkeARCancelVoucherReason.BOSAllowDummy = false;
            this.fld_lkeARCancelVoucherReason.BOSComment = null;
            this.fld_lkeARCancelVoucherReason.BOSDataMember = "ARCancelVoucherReason";
            this.fld_lkeARCancelVoucherReason.BOSDataSource = "ARCancelVouchers";
            this.fld_lkeARCancelVoucherReason.BOSDescription = null;
            this.fld_lkeARCancelVoucherReason.BOSError = null;
            this.fld_lkeARCancelVoucherReason.BOSFieldGroup = null;
            this.fld_lkeARCancelVoucherReason.BOSFieldParent = null;
            this.fld_lkeARCancelVoucherReason.BOSFieldRelation = null;
            this.fld_lkeARCancelVoucherReason.BOSPrivilege = null;
            this.fld_lkeARCancelVoucherReason.BOSPropertyName = "EditValue";
            this.fld_lkeARCancelVoucherReason.BOSSelectType = null;
            this.fld_lkeARCancelVoucherReason.BOSSelectTypeValue = null;
            this.fld_lkeARCancelVoucherReason.CurrentDisplayText = null;
            this.fld_lkeARCancelVoucherReason.Location = new System.Drawing.Point(717, 64);
            this.fld_lkeARCancelVoucherReason.Name = "fld_lkeARCancelVoucherReason";
            this.fld_lkeARCancelVoucherReason.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeARCancelVoucherReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCancelVoucherReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCancelVoucherReason.Properties.ColumnName = null;
            this.fld_lkeARCancelVoucherReason.Properties.NullText = "";
            this.fld_lkeARCancelVoucherReason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCancelVoucherReason.Screen = null;
            this.fld_lkeARCancelVoucherReason.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARCancelVoucherReason.TabIndex = 12;
            this.fld_lkeARCancelVoucherReason.Tag = "DC";
            // 
            // bosLabel6
            // 
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
            this.bosLabel6.Location = new System.Drawing.Point(638, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 715;
            this.bosLabel6.Text = "Lý do hủy";
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.Options.UseBackColor = true;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = null;
            this.bosLabel38.BOSDataMember = null;
            this.bosLabel38.BOSDataSource = null;
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = null;
            this.bosLabel38.BOSFieldRelation = null;
            this.bosLabel38.BOSPrivilege = null;
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.Location = new System.Drawing.Point(638, 14);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(45, 13);
            this.bosLabel38.TabIndex = 711;
            this.bosLabel38.Text = "Mã dự án";
            // 
            // bosLabel85
            // 
            this.bosLabel85.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.Options.UseBackColor = true;
            this.bosLabel85.Appearance.Options.UseForeColor = true;
            this.bosLabel85.BOSComment = null;
            this.bosLabel85.BOSDataMember = null;
            this.bosLabel85.BOSDataSource = null;
            this.bosLabel85.BOSDescription = null;
            this.bosLabel85.BOSError = null;
            this.bosLabel85.BOSFieldGroup = null;
            this.bosLabel85.BOSFieldRelation = null;
            this.bosLabel85.BOSPrivilege = null;
            this.bosLabel85.BOSPropertyName = null;
            this.bosLabel85.Location = new System.Drawing.Point(638, 41);
            this.bosLabel85.Name = "bosLabel85";
            this.bosLabel85.Screen = null;
            this.bosLabel85.Size = new System.Drawing.Size(60, 13);
            this.bosLabel85.TabIndex = 709;
            this.bosLabel85.Text = "Số hợp đồng";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 156);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(889, 356);
            this.xtraTabControl1.TabIndex = 107;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARCancelVoucherItems);
            this.xtraTabPage1.Controls.Add(this.fld_pteARCancelVoucherItemProductPicture);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(887, 331);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcCancelVoucherItemCostsGridControl);
            this.xtraTabPage2.Controls.Add(this.fld_btnAddCost);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(972, 348);
            this.xtraTabPage2.Text = "Danh sách chi phí";
            // 
            // fld_dgcCancelVoucherItemCostsGridControl
            // 
            this.fld_dgcCancelVoucherItemCostsGridControl.AllowDrop = true;
            this.fld_dgcCancelVoucherItemCostsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSComment = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSDataMember = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSDataSource = "ARCancelVoucherItemCosts";
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSDescription = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSError = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSFieldGroup = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSFieldRelation = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSGridType = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSPrivilege = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.BOSPropertyName = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.CommodityType = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCancelVoucherItemCostsGridControl.Location = new System.Drawing.Point(4, 37);
            this.fld_dgcCancelVoucherItemCostsGridControl.MainView = this.gridView1;
            this.fld_dgcCancelVoucherItemCostsGridControl.Name = "fld_dgcCancelVoucherItemCostsGridControl";
            this.fld_dgcCancelVoucherItemCostsGridControl.PrintReport = false;
            this.fld_dgcCancelVoucherItemCostsGridControl.Screen = null;
            this.fld_dgcCancelVoucherItemCostsGridControl.Size = new System.Drawing.Size(965, 307);
            this.fld_dgcCancelVoucherItemCostsGridControl.TabIndex = 17;
            this.fld_dgcCancelVoucherItemCostsGridControl.Tag = "DC";
            this.fld_dgcCancelVoucherItemCostsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcCancelVoucherItemCostsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_btnAddCost
            // 
            this.fld_btnAddCost.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddCost.Appearance.Options.UseForeColor = true;
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
            this.fld_btnAddCost.Location = new System.Drawing.Point(4, 4);
            this.fld_btnAddCost.Name = "fld_btnAddCost";
            this.fld_btnAddCost.Screen = null;
            this.fld_btnAddCost.Size = new System.Drawing.Size(112, 27);
            this.fld_btnAddCost.TabIndex = 16;
            this.fld_btnAddCost.Text = "Thêm chi phí";
            this.fld_btnAddCost.Click += new System.EventHandler(this.fld_btnAddCost_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcARSaleOrderPaymentTimes);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(972, 348);
            this.xtraTabPage3.Text = "Danh sách đợt thanh toán";
            // 
            // fld_dgcARSaleOrderPaymentTimes
            // 
            this.fld_dgcARSaleOrderPaymentTimes.AllowDrop = true;
            this.fld_dgcARSaleOrderPaymentTimes.BOSComment = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSDataMember = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSDataSource = "ARSaleOrderPaymentTimes";
            this.fld_dgcARSaleOrderPaymentTimes.BOSDescription = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSError = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSGridType = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSPrivilege = null;
            this.fld_dgcARSaleOrderPaymentTimes.BOSPropertyName = null;
            this.fld_dgcARSaleOrderPaymentTimes.CommodityType = "";
            this.fld_dgcARSaleOrderPaymentTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderPaymentTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderPaymentTimes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARSaleOrderPaymentTimes.MainView = this.gridView2;
            this.fld_dgcARSaleOrderPaymentTimes.Name = "fld_dgcARSaleOrderPaymentTimes";
            this.fld_dgcARSaleOrderPaymentTimes.PrintReport = false;
            this.fld_dgcARSaleOrderPaymentTimes.Screen = null;
            this.fld_dgcARSaleOrderPaymentTimes.Size = new System.Drawing.Size(972, 348);
            this.fld_dgcARSaleOrderPaymentTimes.TabIndex = 27;
            this.fld_dgcARSaleOrderPaymentTimes.Tag = "DC";
            this.fld_dgcARSaleOrderPaymentTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcARSaleOrderPaymentTimes;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = null;
            this.fld_lblLabel5.BOSDataMember = null;
            this.fld_lblLabel5.BOSDataSource = null;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = null;
            this.fld_lblLabel5.BOSFieldRelation = null;
            this.fld_lblLabel5.BOSPrivilege = null;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(128, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 106;
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCancelVouchers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(194, 38);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeARCancelVoucherStatus
            // 
            this.fld_lkeARCancelVoucherStatus.BOSAllowAddNew = false;
            this.fld_lkeARCancelVoucherStatus.BOSAllowDummy = false;
            this.fld_lkeARCancelVoucherStatus.BOSComment = null;
            this.fld_lkeARCancelVoucherStatus.BOSDataMember = "ARCancelVoucherStatus";
            this.fld_lkeARCancelVoucherStatus.BOSDataSource = "ARCancelVouchers";
            this.fld_lkeARCancelVoucherStatus.BOSDescription = null;
            this.fld_lkeARCancelVoucherStatus.BOSError = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldGroup = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldParent = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldRelation = null;
            this.fld_lkeARCancelVoucherStatus.BOSPrivilege = null;
            this.fld_lkeARCancelVoucherStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARCancelVoucherStatus.BOSSelectType = null;
            this.fld_lkeARCancelVoucherStatus.BOSSelectTypeValue = null;
            this.fld_lkeARCancelVoucherStatus.CurrentDisplayText = null;
            this.fld_lkeARCancelVoucherStatus.Location = new System.Drawing.Point(717, 90);
            this.fld_lkeARCancelVoucherStatus.Name = "fld_lkeARCancelVoucherStatus";
            this.fld_lkeARCancelVoucherStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeARCancelVoucherStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCancelVoucherStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCancelVoucherStatus.Properties.ColumnName = null;
            this.fld_lkeARCancelVoucherStatus.Properties.NullText = "";
            this.fld_lkeARCancelVoucherStatus.Properties.ReadOnly = true;
            this.fld_lkeARCancelVoucherStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCancelVoucherStatus.Screen = null;
            this.fld_lkeARCancelVoucherStatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARCancelVoucherStatus.TabIndex = 5;
            this.fld_lkeARCancelVoucherStatus.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(638, 119);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(73, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Text = "Ngày đơn hàng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(638, 92);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Text = "Tình trạng";
            // 
            // fld_dteARSaleOrderDate
            // 
            this.fld_dteARSaleOrderDate.BOSComment = null;
            this.fld_dteARSaleOrderDate.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteARSaleOrderDate.BOSDataSource = "ARCancelVouchers";
            this.fld_dteARSaleOrderDate.BOSDescription = null;
            this.fld_dteARSaleOrderDate.BOSError = null;
            this.fld_dteARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDate.EditValue = null;
            this.fld_dteARSaleOrderDate.Location = new System.Drawing.Point(717, 116);
            this.fld_dteARSaleOrderDate.Name = "fld_dteARSaleOrderDate";
            this.fld_dteARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDate.Properties.ReadOnly = true;
            this.fld_dteARSaleOrderDate.Screen = null;
            this.fld_dteARSaleOrderDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARSaleOrderDate.TabIndex = 9;
            this.fld_dteARSaleOrderDate.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
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
            this.bosLabel8.Location = new System.Drawing.Point(128, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(35, 13);
            this.bosLabel8.TabIndex = 843;
            this.bosLabel8.Text = "Ghi chú";
            // 
            // DMARCV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(903, 630);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMARCV100.IconOptions.Icon")));
            this.Name = "DMARCV100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMARCV100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelVoucherEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCancelVoucherItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelVoucherItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCancelVoucherComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherExchangeRate.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCancelVoucherItemCostsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderPaymentTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtARCancelVoucherNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteARCancelVoucherEmployeePicture;
        private BOSComponent.BOSDateEdit fld_dteARCancelVoucherDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteARCancelVoucherItemProductPicture;
        private ARCancelVoucherItemsGridControl fld_dgcARCancelVoucherItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCancelVoucher;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSMemoEdit fld_medARCancelVoucherComment;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherSubTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherDiscountFix;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherDiscountPerCent;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTotalAmount;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTaxAmount;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeARCancelVoucherStatus;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnAddCost;
        private ARCancelVoucherItemCostsGridControl fld_dgcCancelVoucherItemCostsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel85;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSLookupEdit fld_lkeARCancelVoucherReason;
        private BOSComponent.BOSLabel bosLabel6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ARSaleOrderPaymentTimesGridControl fld_dgcARSaleOrderPaymentTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel8;
    }
}
