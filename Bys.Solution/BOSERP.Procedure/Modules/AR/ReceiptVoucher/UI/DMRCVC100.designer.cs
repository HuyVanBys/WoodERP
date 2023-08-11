using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReceiptVoucher.UI
{
	/// <summary>
	/// Summary description for DMRCVC100
	/// </summary>
	partial class DMRCVC100
    {
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtARReceiptVoucherNo1;
        private BOSComponent.BOSDateEdit fld_dteARReceiptVoucherDate;
        private BOSComponent.BOSMemoEdit fld_medARReceiptVoucherDesc;
		private ARReceiptVoucherItemsGridControl fld_dgcARReceiptVoucherItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARReceiptVoucherItems;


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
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARReceiptVoucherNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteARReceiptVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medARReceiptVoucherDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgcARReceiptVoucherItems = new BOSERP.Modules.ReceiptVoucher.ARReceiptVoucherItemsGridControl();
            this.fld_dgvARReceiptVoucherItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARReceiptVoucherStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtARReceiptVoucherSenderName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARReceiptVoucherExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARReceiptVoucherEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceiptVoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceiptVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARReceiptVoucherDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceiptVoucherItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARReceiptVoucherItems)).BeginInit();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceiptVoucherStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherSenderName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARReceiptVoucherEmployeePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(13, 23);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 7;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(252, 23);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 49);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 10;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(13, 127);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 11;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_txtARReceiptVoucherNo1
            // 
            this.fld_txtARReceiptVoucherNo1.BOSComment = "";
            this.fld_txtARReceiptVoucherNo1.BOSDataMember = "ARReceiptVoucherNo";
            this.fld_txtARReceiptVoucherNo1.BOSDataSource = "ARReceiptVouchers";
            this.fld_txtARReceiptVoucherNo1.BOSDescription = null;
            this.fld_txtARReceiptVoucherNo1.BOSError = null;
            this.fld_txtARReceiptVoucherNo1.BOSFieldGroup = "";
            this.fld_txtARReceiptVoucherNo1.BOSFieldRelation = "";
            this.fld_txtARReceiptVoucherNo1.BOSPrivilege = "";
            this.fld_txtARReceiptVoucherNo1.BOSPropertyName = "Text";
            this.fld_txtARReceiptVoucherNo1.EditValue = "";
            this.fld_txtARReceiptVoucherNo1.Location = new System.Drawing.Point(84, 20);
            this.fld_txtARReceiptVoucherNo1.Name = "fld_txtARReceiptVoucherNo1";
            this.fld_txtARReceiptVoucherNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceiptVoucherNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceiptVoucherNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceiptVoucherNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceiptVoucherNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceiptVoucherNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceiptVoucherNo1.Screen = null;
            this.fld_txtARReceiptVoucherNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARReceiptVoucherNo1.TabIndex = 0;
            this.fld_txtARReceiptVoucherNo1.Tag = "DC";
            // 
            // fld_dteARReceiptVoucherDate
            // 
            this.fld_dteARReceiptVoucherDate.BOSComment = "";
            this.fld_dteARReceiptVoucherDate.BOSDataMember = "ARReceiptVoucherDate";
            this.fld_dteARReceiptVoucherDate.BOSDataSource = "ARReceiptVouchers";
            this.fld_dteARReceiptVoucherDate.BOSDescription = null;
            this.fld_dteARReceiptVoucherDate.BOSError = null;
            this.fld_dteARReceiptVoucherDate.BOSFieldGroup = "";
            this.fld_dteARReceiptVoucherDate.BOSFieldRelation = "";
            this.fld_dteARReceiptVoucherDate.BOSPrivilege = "";
            this.fld_dteARReceiptVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteARReceiptVoucherDate.EditValue = null;
            this.fld_dteARReceiptVoucherDate.Location = new System.Drawing.Point(332, 20);
            this.fld_dteARReceiptVoucherDate.Name = "fld_dteARReceiptVoucherDate";
            this.fld_dteARReceiptVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARReceiptVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARReceiptVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARReceiptVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARReceiptVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARReceiptVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARReceiptVoucherDate.Screen = null;
            this.fld_dteARReceiptVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARReceiptVoucherDate.TabIndex = 1;
            this.fld_dteARReceiptVoucherDate.Tag = "DC";
            // 
            // fld_medARReceiptVoucherDesc
            // 
            this.fld_medARReceiptVoucherDesc.BOSComment = "";
            this.fld_medARReceiptVoucherDesc.BOSDataMember = "ARReceiptVoucherDesc";
            this.fld_medARReceiptVoucherDesc.BOSDataSource = "ARReceiptVouchers";
            this.fld_medARReceiptVoucherDesc.BOSDescription = null;
            this.fld_medARReceiptVoucherDesc.BOSError = null;
            this.fld_medARReceiptVoucherDesc.BOSFieldGroup = "";
            this.fld_medARReceiptVoucherDesc.BOSFieldRelation = "";
            this.fld_medARReceiptVoucherDesc.BOSPrivilege = "";
            this.fld_medARReceiptVoucherDesc.BOSPropertyName = "Text";
            this.fld_medARReceiptVoucherDesc.EditValue = "";
            this.fld_medARReceiptVoucherDesc.Location = new System.Drawing.Point(84, 124);
            this.fld_medARReceiptVoucherDesc.Name = "fld_medARReceiptVoucherDesc";
            this.fld_medARReceiptVoucherDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARReceiptVoucherDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARReceiptVoucherDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARReceiptVoucherDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARReceiptVoucherDesc.Screen = null;
            this.fld_medARReceiptVoucherDesc.Size = new System.Drawing.Size(662, 38);
            this.fld_medARReceiptVoucherDesc.TabIndex = 11;
            this.fld_medARReceiptVoucherDesc.Tag = "DC";
            this.fld_medARReceiptVoucherDesc.Validated += new System.EventHandler(this.fld_medARReceiptVoucherDesc_Validated);
            // 
            // fld_dgcARReceiptVoucherItems
            // 
            this.fld_dgcARReceiptVoucherItems.AllowDrop = true;
            this.fld_dgcARReceiptVoucherItems.BOSComment = "";
            this.fld_dgcARReceiptVoucherItems.BOSDataMember = "";
            this.fld_dgcARReceiptVoucherItems.BOSDataSource = "ARReceiptVoucherItems";
            this.fld_dgcARReceiptVoucherItems.BOSDescription = null;
            this.fld_dgcARReceiptVoucherItems.BOSError = null;
            this.fld_dgcARReceiptVoucherItems.BOSFieldGroup = "";
            this.fld_dgcARReceiptVoucherItems.BOSFieldRelation = "";
            this.fld_dgcARReceiptVoucherItems.BOSGridType = null;
            this.fld_dgcARReceiptVoucherItems.BOSPrivilege = "";
            this.fld_dgcARReceiptVoucherItems.BOSPropertyName = "";
            this.fld_dgcARReceiptVoucherItems.CommodityType = "";
            this.fld_dgcARReceiptVoucherItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARReceiptVoucherItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARReceiptVoucherItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARReceiptVoucherItems.MainView = this.fld_dgvARReceiptVoucherItems;
            this.fld_dgcARReceiptVoucherItems.Name = "fld_dgcARReceiptVoucherItems";
            this.fld_dgcARReceiptVoucherItems.PrintReport = false;
            this.fld_dgcARReceiptVoucherItems.Screen = null;
            this.fld_dgcARReceiptVoucherItems.Size = new System.Drawing.Size(1130, 339);
            this.fld_dgcARReceiptVoucherItems.TabIndex = 0;
            this.fld_dgcARReceiptVoucherItems.Tag = "DC";
            this.fld_dgcARReceiptVoucherItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARReceiptVoucherItems});
            // 
            // fld_dgvARReceiptVoucherItems
            // 
            this.fld_dgvARReceiptVoucherItems.GridControl = this.fld_dgcARReceiptVoucherItems;
            this.fld_dgvARReceiptVoucherItems.Name = "fld_dgvARReceiptVoucherItems";
            this.fld_dgvARReceiptVoucherItems.PaintStyleName = "Office2003";
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosTabControl1);
            this.bosPanel3.Controls.Add(this.groupBox1);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel3.Controls.Add(this.fld_pteARReceiptVoucherEmployeePicture);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(1148, 576);
            this.bosPanel3.TabIndex = 0;
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
            this.bosTabControl1.Location = new System.Drawing.Point(0, 185);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1136, 367);
            this.bosTabControl1.TabIndex = 135;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARReceiptVoucherItems);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1130, 339);
            this.xtraTabPage2.Text = "Danh sách mục thu";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1130, 349);
            this.xtraTabPage3.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1130, 349);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bosLabel5);
            this.groupBox1.Controls.Add(this.bosLabel18);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ARSaleContractID);
            this.groupBox1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.groupBox1.Controls.Add(this.bosLabel13);
            this.groupBox1.Controls.Add(this.bosLabel12);
            this.groupBox1.Controls.Add(this.fld_lkeARReceiptVoucherStatus);
            this.groupBox1.Controls.Add(this.bosLabel11);
            this.groupBox1.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.groupBox1.Controls.Add(this.bosLabel10);
            this.groupBox1.Controls.Add(this.fld_lblLabel2);
            this.groupBox1.Controls.Add(this.fld_lblLabel6);
            this.groupBox1.Controls.Add(this.fld_lblLabel5);
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.groupBox1.Controls.Add(this.fld_dteARReceiptVoucherDate);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.fld_medARReceiptVoucherDesc);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.groupBox1.Controls.Add(this.fld_txtARReceiptVoucherNo1);
            this.groupBox1.Controls.Add(this.fld_txtARReceiptVoucherSenderName);
            this.groupBox1.Controls.Add(this.fld_lblLabel3);
            this.groupBox1.Controls.Add(this.fld_txtARReceiptVoucherExchangeRate);
            this.groupBox1.Controls.Add(this.bosLabel4);
            this.groupBox1.Location = new System.Drawing.Point(109, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thôn tin chung";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.bosLabel5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel5.Location = new System.Drawing.Point(237, 98);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(6, 13);
            this.bosLabel5.TabIndex = 758;
            this.bosLabel5.Text = "*";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel18.Location = new System.Drawing.Point(237, 46);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(6, 13);
            this.bosLabel18.TabIndex = 757;
            this.bosLabel18.Text = "*";
            // 
            // fld_lkeFK_ARSaleContractID
            // 
            this.fld_lkeFK_ARSaleContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleContractID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleContractID.BOSComment = "";
            this.fld_lkeFK_ARSaleContractID.BOSDataMember = "FK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.BOSDataSource = "ARReceiptVouchers";
            this.fld_lkeFK_ARSaleContractID.BOSDescription = null;
            this.fld_lkeFK_ARSaleContractID.BOSError = null;
            this.fld_lkeFK_ARSaleContractID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldParent = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleContractID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleContractID.BOSSelectType = "";
            this.fld_lkeFK_ARSaleContractID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARSaleContractID.CurrentDisplayText = "";
            this.fld_lkeFK_ARSaleContractID.Location = new System.Drawing.Point(332, 98);
            this.fld_lkeFK_ARSaleContractID.Name = "fld_lkeFK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleContractID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractName", "Tên hợp đồng")});
            this.fld_lkeFK_ARSaleContractID.Properties.DisplayMember = "ARSaleContractNo";
            this.fld_lkeFK_ARSaleContractID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleContractID.Properties.ValueMember = "ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Screen = null;
            this.fld_lkeFK_ARSaleContractID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleContractID.TabIndex = 427;
            this.fld_lkeFK_ARSaleContractID.Tag = "DC";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(332, 46);
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
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 4;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel13.Location = new System.Drawing.Point(252, 49);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(45, 13);
            this.bosLabel13.TabIndex = 426;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Mã dự án";
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
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(252, 101);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(60, 13);
            this.bosLabel12.TabIndex = 424;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Số hợp đồng";
            // 
            // fld_lkeARReceiptVoucherStatus
            // 
            this.fld_lkeARReceiptVoucherStatus.BOSAllowAddNew = false;
            this.fld_lkeARReceiptVoucherStatus.BOSAllowDummy = false;
            this.fld_lkeARReceiptVoucherStatus.BOSComment = null;
            this.fld_lkeARReceiptVoucherStatus.BOSDataMember = "ARReceiptVoucherStatus";
            this.fld_lkeARReceiptVoucherStatus.BOSDataSource = "ARReceiptVouchers";
            this.fld_lkeARReceiptVoucherStatus.BOSDescription = null;
            this.fld_lkeARReceiptVoucherStatus.BOSError = null;
            this.fld_lkeARReceiptVoucherStatus.BOSFieldGroup = null;
            this.fld_lkeARReceiptVoucherStatus.BOSFieldParent = null;
            this.fld_lkeARReceiptVoucherStatus.BOSFieldRelation = null;
            this.fld_lkeARReceiptVoucherStatus.BOSPrivilege = null;
            this.fld_lkeARReceiptVoucherStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARReceiptVoucherStatus.BOSSelectType = null;
            this.fld_lkeARReceiptVoucherStatus.BOSSelectTypeValue = null;
            this.fld_lkeARReceiptVoucherStatus.CurrentDisplayText = null;
            this.fld_lkeARReceiptVoucherStatus.Location = new System.Drawing.Point(596, 20);
            this.fld_lkeARReceiptVoucherStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARReceiptVoucherStatus.Name = "fld_lkeARReceiptVoucherStatus";
            this.fld_lkeARReceiptVoucherStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARReceiptVoucherStatus.Properties.ColumnName = null;
            this.fld_lkeARReceiptVoucherStatus.Properties.ReadOnly = true;
            this.fld_lkeARReceiptVoucherStatus.Screen = null;
            this.fld_lkeARReceiptVoucherStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARReceiptVoucherStatus.TabIndex = 2;
            this.fld_lkeARReceiptVoucherStatus.Tag = "DC";
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
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(499, 23);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(49, 13);
            this.bosLabel11.TabIndex = 421;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Tình trạng";
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = "";
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "ARReceiptVouchers";
            this.fld_lkeFK_CSCashFundID.BOSDescription = null;
            this.fld_lkeFK_CSCashFundID.BOSError = null;
            this.fld_lkeFK_CSCashFundID.BOSFieldGroup = "";
            this.fld_lkeFK_CSCashFundID.BOSFieldParent = "";
            this.fld_lkeFK_CSCashFundID.BOSFieldRelation = "";
            this.fld_lkeFK_CSCashFundID.BOSPrivilege = "";
            this.fld_lkeFK_CSCashFundID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCashFundID.BOSSelectType = "";
            this.fld_lkeFK_CSCashFundID.BOSSelectTypeValue = "";
            this.fld_lkeFK_CSCashFundID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCashFundID.Location = new System.Drawing.Point(84, 98);
            this.fld_lkeFK_CSCashFundID.Name = "fld_lkeFK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCashFundID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCashFundID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundName", "Tên quỹ tiền mặt")});
            this.fld_lkeFK_CSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_CSCashFundID.Properties.NullText = "";
            this.fld_lkeFK_CSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCashFundID, true);
            this.fld_lkeFK_CSCashFundID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCashFundID.TabIndex = 9;
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
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
            this.bosLabel10.Location = new System.Drawing.Point(13, 101);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(62, 13);
            this.bosLabel10.TabIndex = 97;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Quỹ tiền mặt";
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(499, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(70, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Người nộp tiền";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(596, 72);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 8;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(499, 75);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(85, 13);
            this.bosLabel1.TabIndex = 40;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Khoản mục chi phí";
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(13, 75);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 35;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(84, 72);
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
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 6;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(84, 46);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_txtARReceiptVoucherSenderName
            // 
            this.fld_txtARReceiptVoucherSenderName.BOSComment = "";
            this.fld_txtARReceiptVoucherSenderName.BOSDataMember = "ARReceiptVoucherSenderName";
            this.fld_txtARReceiptVoucherSenderName.BOSDataSource = "ARReceiptVouchers";
            this.fld_txtARReceiptVoucherSenderName.BOSDescription = null;
            this.fld_txtARReceiptVoucherSenderName.BOSError = null;
            this.fld_txtARReceiptVoucherSenderName.BOSFieldGroup = "";
            this.fld_txtARReceiptVoucherSenderName.BOSFieldRelation = "";
            this.fld_txtARReceiptVoucherSenderName.BOSPrivilege = "";
            this.fld_txtARReceiptVoucherSenderName.BOSPropertyName = "Text";
            this.fld_txtARReceiptVoucherSenderName.EditValue = "";
            this.fld_txtARReceiptVoucherSenderName.Location = new System.Drawing.Point(596, 46);
            this.fld_txtARReceiptVoucherSenderName.Name = "fld_txtARReceiptVoucherSenderName";
            this.fld_txtARReceiptVoucherSenderName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceiptVoucherSenderName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceiptVoucherSenderName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceiptVoucherSenderName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceiptVoucherSenderName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceiptVoucherSenderName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceiptVoucherSenderName.Screen = null;
            this.fld_txtARReceiptVoucherSenderName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARReceiptVoucherSenderName.TabIndex = 5;
            this.fld_txtARReceiptVoucherSenderName.Tag = "DC";
            // 
            // fld_txtARReceiptVoucherExchangeRate
            // 
            this.fld_txtARReceiptVoucherExchangeRate.BOSComment = "";
            this.fld_txtARReceiptVoucherExchangeRate.BOSDataMember = "ARReceiptVoucherExchangeRate";
            this.fld_txtARReceiptVoucherExchangeRate.BOSDataSource = "ARReceiptVouchers";
            this.fld_txtARReceiptVoucherExchangeRate.BOSDescription = null;
            this.fld_txtARReceiptVoucherExchangeRate.BOSError = null;
            this.fld_txtARReceiptVoucherExchangeRate.BOSFieldGroup = "";
            this.fld_txtARReceiptVoucherExchangeRate.BOSFieldRelation = "";
            this.fld_txtARReceiptVoucherExchangeRate.BOSPrivilege = "";
            this.fld_txtARReceiptVoucherExchangeRate.BOSPropertyName = "Text";
            this.fld_txtARReceiptVoucherExchangeRate.EditValue = "";
            this.fld_txtARReceiptVoucherExchangeRate.Location = new System.Drawing.Point(332, 72);
            this.fld_txtARReceiptVoucherExchangeRate.Name = "fld_txtARReceiptVoucherExchangeRate";
            this.fld_txtARReceiptVoucherExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceiptVoucherExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceiptVoucherExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceiptVoucherExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceiptVoucherExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceiptVoucherExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceiptVoucherExchangeRate.Screen = null;
            this.fld_txtARReceiptVoucherExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARReceiptVoucherExchangeRate.TabIndex = 7;
            this.fld_txtARReceiptVoucherExchangeRate.Tag = "DC";
            this.fld_txtARReceiptVoucherExchangeRate.Validated += new System.EventHandler(this.fld_txtARReceiptVoucherExchangeRate_Validated);
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
            this.bosLabel4.Location = new System.Drawing.Point(252, 75);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 38;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteARReceiptVoucherEmployeePicture
            // 
            this.fld_pteARReceiptVoucherEmployeePicture.BOSComment = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSDataMember = "ARReceiptVoucherEmployeePicture";
            this.fld_pteARReceiptVoucherEmployeePicture.BOSDataSource = "ARReceiptVouchers";
            this.fld_pteARReceiptVoucherEmployeePicture.BOSDescription = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSError = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSPrivilege = null;
            this.fld_pteARReceiptVoucherEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARReceiptVoucherEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARReceiptVoucherEmployeePicture.FileName = null;
            this.fld_pteARReceiptVoucherEmployeePicture.FilePath = null;
            this.fld_pteARReceiptVoucherEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteARReceiptVoucherEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteARReceiptVoucherEmployeePicture.Name = "fld_pteARReceiptVoucherEmployeePicture";
            this.fld_pteARReceiptVoucherEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARReceiptVoucherEmployeePicture.Screen = null;
            this.fld_pteARReceiptVoucherEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARReceiptVoucherEmployeePicture.TabIndex = 0;
            this.fld_pteARReceiptVoucherEmployeePicture.Tag = "DC";
            // 
            // DMRCVC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1148, 576);
            this.Controls.Add(this.bosPanel3);
            this.Name = "DMRCVC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceiptVoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceiptVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARReceiptVoucherDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceiptVoucherItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARReceiptVoucherItems)).EndInit();
            this.bosPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceiptVoucherStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherSenderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARReceiptVoucherEmployeePicture.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSTextBox fld_txtARReceiptVoucherExchangeRate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARReceiptVoucherEmployeePicture;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSTextBox fld_txtARReceiptVoucherSenderName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel1;
        private GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private BOSComponent.BOSLookupEdit fld_lkeARReceiptVoucherStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleContractID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
    }
}
