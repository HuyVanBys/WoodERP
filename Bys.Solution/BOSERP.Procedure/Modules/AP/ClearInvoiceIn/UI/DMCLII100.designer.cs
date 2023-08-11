using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ClearInvoiceIn.UI
{
	/// <summary>
	/// Summary description for DMDC100
	/// </summary>
    partial class DMCLII100
    {
		private BOSComponent.BOSTextBox fld_txtAPClearInvoiceInNo;
        private BOSComponent.BOSDateEdit fld_dteAPClearInvoiceInDate;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCLII100));
            this.fld_txtAPClearInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteAPClearInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabCustomerPayments = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageCustomerPayment = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_dgcAPClearInvoiceInDocuments = new BOSERP.Modules.ClearInvoiceIn.APClearInvoiceInDocumentsGridControl();
            this.fld_dgvARCustomerPaymentTimePayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnDocument = new BOSComponent.BOSButton(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dgcAPClearInvoiceInInvoiceIns = new BOSERP.Modules.ClearInvoiceIn.APClearInvoiceInInvoiceInsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnInvoiceIn = new BOSComponent.BOSButton(this.components);
            this.fld_tabPageDocumentEntry = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeRunAllocation = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ACAccountPurchaseID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_pteACClearingDebtEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPClearInvoiceInExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPClearInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPClearInvoiceInDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPClearInvoiceInDate.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).BeginInit();
            this.fld_tabCustomerPayments.SuspendLayout();
            this.fld_tabPageCustomerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearInvoiceInDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearInvoiceInInvoiceIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabPageDocumentEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACClearingDebtEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPClearInvoiceInExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtAPClearInvoiceInNo
            // 
            this.fld_txtAPClearInvoiceInNo.BOSComment = "";
            this.fld_txtAPClearInvoiceInNo.BOSDataMember = "APClearInvoiceInNo";
            this.fld_txtAPClearInvoiceInNo.BOSDataSource = "APClearInvoiceIns";
            this.fld_txtAPClearInvoiceInNo.BOSDescription = null;
            this.fld_txtAPClearInvoiceInNo.BOSError = null;
            this.fld_txtAPClearInvoiceInNo.BOSFieldGroup = "";
            this.fld_txtAPClearInvoiceInNo.BOSFieldRelation = "";
            this.fld_txtAPClearInvoiceInNo.BOSPrivilege = "";
            this.fld_txtAPClearInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtAPClearInvoiceInNo.EditValue = "";
            this.fld_txtAPClearInvoiceInNo.Location = new System.Drawing.Point(219, 12);
            this.fld_txtAPClearInvoiceInNo.Name = "fld_txtAPClearInvoiceInNo";
            this.fld_txtAPClearInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPClearInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPClearInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPClearInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPClearInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPClearInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPClearInvoiceInNo.Screen = null;
            this.fld_txtAPClearInvoiceInNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPClearInvoiceInNo.TabIndex = 0;
            this.fld_txtAPClearInvoiceInNo.Tag = "DC";
            // 
            // fld_dteAPClearInvoiceInDate
            // 
            this.fld_dteAPClearInvoiceInDate.BOSComment = "";
            this.fld_dteAPClearInvoiceInDate.BOSDataMember = "APClearInvoiceInDate";
            this.fld_dteAPClearInvoiceInDate.BOSDataSource = "APClearInvoiceIns";
            this.fld_dteAPClearInvoiceInDate.BOSDescription = null;
            this.fld_dteAPClearInvoiceInDate.BOSError = null;
            this.fld_dteAPClearInvoiceInDate.BOSFieldGroup = "";
            this.fld_dteAPClearInvoiceInDate.BOSFieldRelation = "";
            this.fld_dteAPClearInvoiceInDate.BOSPrivilege = "";
            this.fld_dteAPClearInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteAPClearInvoiceInDate.EditValue = null;
            this.fld_dteAPClearInvoiceInDate.Location = new System.Drawing.Point(497, 12);
            this.fld_dteAPClearInvoiceInDate.Name = "fld_dteAPClearInvoiceInDate";
            this.fld_dteAPClearInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPClearInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPClearInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPClearInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPClearInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPClearInvoiceInDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPClearInvoiceInDate.Screen = null;
            this.fld_dteAPClearInvoiceInDate.Size = new System.Drawing.Size(173, 20);
            this.fld_dteAPClearInvoiceInDate.TabIndex = 4;
            this.fld_dteAPClearInvoiceInDate.Tag = "DC";
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
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(128, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 9;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(398, 15);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 3;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
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
            this.bosPanel1.Controls.Add(this.fld_tabCustomerPayments);
            this.bosPanel1.Controls.Add(this.fld_lkeRunAllocation);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAccountPurchaseID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_pteACClearingDebtEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtAPClearInvoiceInExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtAPClearInvoiceInNo);
            this.bosPanel1.Controls.Add(this.fld_dteAPClearInvoiceInDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(994, 518);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_tabCustomerPayments
            // 
            this.fld_tabCustomerPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabCustomerPayments.BOSComment = null;
            this.fld_tabCustomerPayments.BOSDataMember = null;
            this.fld_tabCustomerPayments.BOSDataSource = null;
            this.fld_tabCustomerPayments.BOSDescription = null;
            this.fld_tabCustomerPayments.BOSError = null;
            this.fld_tabCustomerPayments.BOSFieldGroup = null;
            this.fld_tabCustomerPayments.BOSFieldRelation = null;
            this.fld_tabCustomerPayments.BOSPrivilege = null;
            this.fld_tabCustomerPayments.BOSPropertyName = null;
            this.fld_tabCustomerPayments.Location = new System.Drawing.Point(3, 131);
            this.fld_tabCustomerPayments.Name = "fld_tabCustomerPayments";
            this.fld_tabCustomerPayments.Screen = null;
            this.fld_tabCustomerPayments.SelectedTabPage = this.fld_tabPageCustomerPayment;
            this.ScreenHelper.SetShowHelp(this.fld_tabCustomerPayments, true);
            this.fld_tabCustomerPayments.Size = new System.Drawing.Size(979, 375);
            this.fld_tabCustomerPayments.TabIndex = 14;
            this.fld_tabCustomerPayments.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageCustomerPayment,
            this.fld_tabPageDocumentEntry});
            // 
            // fld_tabPageCustomerPayment
            // 
            this.fld_tabPageCustomerPayment.Controls.Add(this.splitContainerControl1);
            this.fld_tabPageCustomerPayment.Name = "fld_tabPageCustomerPayment";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageCustomerPayment, true);
            this.fld_tabPageCustomerPayment.Size = new System.Drawing.Size(977, 350);
            this.fld_tabPageCustomerPayment.Text = "Phân bổ hóa đơn";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcAPClearInvoiceInDocuments);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_btnDocument);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(977, 350);
            this.splitContainerControl1.SplitterPosition = 441;
            this.splitContainerControl1.TabIndex = 15;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_dgcAPClearInvoiceInDocuments
            // 
            this.fld_dgcAPClearInvoiceInDocuments.AllowDrop = true;
            this.fld_dgcAPClearInvoiceInDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPClearInvoiceInDocuments.BOSComment = "";
            this.fld_dgcAPClearInvoiceInDocuments.BOSDataMember = "";
            this.fld_dgcAPClearInvoiceInDocuments.BOSDataSource = "APClearInvoiceInDocuments";
            this.fld_dgcAPClearInvoiceInDocuments.BOSDescription = null;
            this.fld_dgcAPClearInvoiceInDocuments.BOSError = null;
            this.fld_dgcAPClearInvoiceInDocuments.BOSFieldGroup = "";
            this.fld_dgcAPClearInvoiceInDocuments.BOSFieldRelation = "";
            this.fld_dgcAPClearInvoiceInDocuments.BOSGridType = null;
            this.fld_dgcAPClearInvoiceInDocuments.BOSPrivilege = "";
            this.fld_dgcAPClearInvoiceInDocuments.BOSPropertyName = "";
            this.fld_dgcAPClearInvoiceInDocuments.CommodityType = "";
            this.fld_dgcAPClearInvoiceInDocuments.Location = new System.Drawing.Point(3, 38);
            this.fld_dgcAPClearInvoiceInDocuments.MainView = this.fld_dgvARCustomerPaymentTimePayments;
            this.fld_dgcAPClearInvoiceInDocuments.Name = "fld_dgcAPClearInvoiceInDocuments";
            this.fld_dgcAPClearInvoiceInDocuments.PrintReport = false;
            this.fld_dgcAPClearInvoiceInDocuments.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcAPClearInvoiceInDocuments, false);
            this.fld_dgcAPClearInvoiceInDocuments.Size = new System.Drawing.Size(438, 312);
            this.fld_dgcAPClearInvoiceInDocuments.TabIndex = 1;
            this.fld_dgcAPClearInvoiceInDocuments.Tag = "DC";
            this.fld_dgcAPClearInvoiceInDocuments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerPaymentTimePayments});
            // 
            // fld_dgvARCustomerPaymentTimePayments
            // 
            this.fld_dgvARCustomerPaymentTimePayments.GridControl = this.fld_dgcAPClearInvoiceInDocuments;
            this.fld_dgvARCustomerPaymentTimePayments.Name = "fld_dgvARCustomerPaymentTimePayments";
            this.fld_dgvARCustomerPaymentTimePayments.PaintStyleName = "Office2003";
            // 
            // fld_btnDocument
            // 
            this.fld_btnDocument.BOSComment = null;
            this.fld_btnDocument.BOSDataMember = null;
            this.fld_btnDocument.BOSDataSource = null;
            this.fld_btnDocument.BOSDescription = null;
            this.fld_btnDocument.BOSError = null;
            this.fld_btnDocument.BOSFieldGroup = null;
            this.fld_btnDocument.BOSFieldRelation = null;
            this.fld_btnDocument.BOSPrivilege = null;
            this.fld_btnDocument.BOSPropertyName = null;
            this.fld_btnDocument.Location = new System.Drawing.Point(7, 5);
            this.fld_btnDocument.Name = "fld_btnDocument";
            this.fld_btnDocument.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnDocument, true);
            this.fld_btnDocument.Size = new System.Drawing.Size(122, 27);
            this.fld_btnDocument.TabIndex = 0;
            this.fld_btnDocument.Text = "Chứng từ phân bổ";
            this.fld_btnDocument.Click += new System.EventHandler(this.fld_btnInvoice_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_dgcAPClearInvoiceInInvoiceIns);
            this.panelControl2.Controls.Add(this.fld_btnInvoiceIn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(526, 350);
            this.panelControl2.TabIndex = 0;
            // 
            // fld_dgcAPClearInvoiceInInvoiceIns
            // 
            this.fld_dgcAPClearInvoiceInInvoiceIns.AllowDrop = true;
            this.fld_dgcAPClearInvoiceInInvoiceIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSComment = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSDataMember = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSDataSource = "APClearInvoiceInInvoiceIns";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSDescription = null;
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSError = null;
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSFieldGroup = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSFieldRelation = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSGridType = null;
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSPrivilege = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.BOSPropertyName = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.CommodityType = "";
            this.fld_dgcAPClearInvoiceInInvoiceIns.Location = new System.Drawing.Point(5, 38);
            this.fld_dgcAPClearInvoiceInInvoiceIns.MainView = this.gridView1;
            this.fld_dgcAPClearInvoiceInInvoiceIns.Name = "fld_dgcAPClearInvoiceInInvoiceIns";
            this.fld_dgcAPClearInvoiceInInvoiceIns.PrintReport = false;
            this.fld_dgcAPClearInvoiceInInvoiceIns.Screen = null;
            this.fld_dgcAPClearInvoiceInInvoiceIns.Size = new System.Drawing.Size(516, 312);
            this.fld_dgcAPClearInvoiceInInvoiceIns.TabIndex = 1;
            this.fld_dgcAPClearInvoiceInInvoiceIns.Tag = "DC";
            this.fld_dgcAPClearInvoiceInInvoiceIns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPClearInvoiceInInvoiceIns;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_btnInvoiceIn
            // 
            this.fld_btnInvoiceIn.BOSComment = null;
            this.fld_btnInvoiceIn.BOSDataMember = null;
            this.fld_btnInvoiceIn.BOSDataSource = null;
            this.fld_btnInvoiceIn.BOSDescription = null;
            this.fld_btnInvoiceIn.BOSError = null;
            this.fld_btnInvoiceIn.BOSFieldGroup = null;
            this.fld_btnInvoiceIn.BOSFieldRelation = null;
            this.fld_btnInvoiceIn.BOSPrivilege = null;
            this.fld_btnInvoiceIn.BOSPropertyName = null;
            this.fld_btnInvoiceIn.Location = new System.Drawing.Point(5, 5);
            this.fld_btnInvoiceIn.Name = "fld_btnInvoiceIn";
            this.fld_btnInvoiceIn.Screen = null;
            this.fld_btnInvoiceIn.Size = new System.Drawing.Size(122, 27);
            this.fld_btnInvoiceIn.TabIndex = 0;
            this.fld_btnInvoiceIn.Text = "Hóa đơn mua hàng";
            this.fld_btnInvoiceIn.Click += new System.EventHandler(this.fld_btnInvoiceIn_Click);
            // 
            // fld_tabPageDocumentEntry
            // 
            this.fld_tabPageDocumentEntry.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntry.Name = "fld_tabPageDocumentEntry";
            this.fld_tabPageDocumentEntry.Size = new System.Drawing.Size(977, 350);
            this.fld_tabPageDocumentEntry.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(977, 350);
            this.fld_dgcACDocumentEntrys.TabIndex = 2;
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
            // fld_lkeRunAllocation
            // 
            this.fld_lkeRunAllocation.BOSComment = null;
            this.fld_lkeRunAllocation.BOSDataMember = null;
            this.fld_lkeRunAllocation.BOSDataSource = null;
            this.fld_lkeRunAllocation.BOSDescription = null;
            this.fld_lkeRunAllocation.BOSError = null;
            this.fld_lkeRunAllocation.BOSFieldGroup = null;
            this.fld_lkeRunAllocation.BOSFieldRelation = null;
            this.fld_lkeRunAllocation.BOSPrivilege = null;
            this.fld_lkeRunAllocation.BOSPropertyName = null;
            this.fld_lkeRunAllocation.Location = new System.Drawing.Point(219, 90);
            this.fld_lkeRunAllocation.Name = "fld_lkeRunAllocation";
            this.fld_lkeRunAllocation.Screen = null;
            this.fld_lkeRunAllocation.Size = new System.Drawing.Size(122, 27);
            this.fld_lkeRunAllocation.TabIndex = 0;
            this.fld_lkeRunAllocation.Text = "Chạy phân bổ";
            this.fld_lkeRunAllocation.Click += new System.EventHandler(this.fld_lkeRunAllocation_Click);
            // 
            // fld_lkeFK_ACAccountPurchaseID
            // 
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAccountPurchaseID.BOSComment = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataMember = "FK_ACAccountPurchaseID";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataSource = "APClearInvoiceIns";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDescription = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSError = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountPurchaseID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountPurchaseID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountPurchaseID.Location = new System.Drawing.Point(497, 38);
            this.fld_lkeFK_ACAccountPurchaseID.Name = "fld_lkeFK_ACAccountPurchaseID";
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountPurchaseID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountPurchaseID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountPurchaseID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountPurchaseID.Screen = null;
            this.fld_lkeFK_ACAccountPurchaseID.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeFK_ACAccountPurchaseID.TabIndex = 2;
            this.fld_lkeFK_ACAccountPurchaseID.Tag = "DC";
            this.fld_lkeFK_ACAccountPurchaseID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APClearInvoiceIns";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(219, 64);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 2;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APClearInvoiceIns";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(219, 38);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            this.fld_lkeFK_ACObjectID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ACObjectID_EditValueChanged);
            // 
            // fld_pteACClearingDebtEmployeePicture
            // 
            this.fld_pteACClearingDebtEmployeePicture.BOSComment = "";
            this.fld_pteACClearingDebtEmployeePicture.BOSDataMember = "ACClearingDebtEmployeePicture";
            this.fld_pteACClearingDebtEmployeePicture.BOSDataSource = "ACClearingDebts";
            this.fld_pteACClearingDebtEmployeePicture.BOSDescription = null;
            this.fld_pteACClearingDebtEmployeePicture.BOSError = null;
            this.fld_pteACClearingDebtEmployeePicture.BOSFieldGroup = "";
            this.fld_pteACClearingDebtEmployeePicture.BOSFieldRelation = "";
            this.fld_pteACClearingDebtEmployeePicture.BOSPrivilege = "";
            this.fld_pteACClearingDebtEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACClearingDebtEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACClearingDebtEmployeePicture.EditValue = "";
            this.fld_pteACClearingDebtEmployeePicture.FileName = null;
            this.fld_pteACClearingDebtEmployeePicture.FilePath = null;
            this.fld_pteACClearingDebtEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteACClearingDebtEmployeePicture.Name = "fld_pteACClearingDebtEmployeePicture";
            this.fld_pteACClearingDebtEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteACClearingDebtEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteACClearingDebtEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteACClearingDebtEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteACClearingDebtEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACClearingDebtEmployeePicture.Screen = null;
            this.fld_pteACClearingDebtEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACClearingDebtEmployeePicture.TabIndex = 0;
            this.fld_pteACClearingDebtEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APClearInvoiceIns";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 105);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_txtAPClearInvoiceInExchangeRate
            // 
            this.fld_txtAPClearInvoiceInExchangeRate.BOSComment = "";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSDataMember = "APClearInvoiceInExchangeRate";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSDataSource = "APClearInvoiceIns";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSDescription = null;
            this.fld_txtAPClearInvoiceInExchangeRate.BOSError = null;
            this.fld_txtAPClearInvoiceInExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSPrivilege = "";
            this.fld_txtAPClearInvoiceInExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPClearInvoiceInExchangeRate.EditValue = "";
            this.fld_txtAPClearInvoiceInExchangeRate.Location = new System.Drawing.Point(497, 64);
            this.fld_txtAPClearInvoiceInExchangeRate.Name = "fld_txtAPClearInvoiceInExchangeRate";
            this.fld_txtAPClearInvoiceInExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPClearInvoiceInExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPClearInvoiceInExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPClearInvoiceInExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPClearInvoiceInExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPClearInvoiceInExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPClearInvoiceInExchangeRate.Screen = null;
            this.fld_txtAPClearInvoiceInExchangeRate.Size = new System.Drawing.Size(173, 20);
            this.fld_txtAPClearInvoiceInExchangeRate.TabIndex = 3;
            this.fld_txtAPClearInvoiceInExchangeRate.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(398, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(93, 13);
            this.bosLabel4.TabIndex = 9;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "TK công nợ phải trả";
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
            this.bosLabel3.Location = new System.Drawing.Point(398, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(29, 13);
            this.bosLabel3.TabIndex = 9;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tỷ giá";
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
            this.bosLabel2.Location = new System.Drawing.Point(128, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(128, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Đối tượng";
            // 
            // DMCLII100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(994, 518);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCLII100.IconOptions.Icon")));
            this.Name = "DMCLII100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPClearInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPClearInvoiceInDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPClearInvoiceInDate.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).EndInit();
            this.fld_tabCustomerPayments.ResumeLayout(false);
            this.fld_tabPageCustomerPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearInvoiceInDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearInvoiceInInvoiceIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabPageDocumentEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACClearingDebtEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPClearInvoiceInExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteACClearingDebtEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtAPClearInvoiceInExchangeRate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTabControl fld_tabCustomerPayments;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageCustomerPayment;
        private BOSComponent.BOSButton fld_btnDocument;
        private APClearInvoiceInDocumentsGridControl fld_dgcAPClearInvoiceInDocuments;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerPaymentTimePayments;
        private APClearInvoiceInInvoiceInsGridControl fld_dgcAPClearInvoiceInInvoiceIns;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnInvoiceIn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountPurchaseID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_lkeRunAllocation;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntry;
        private BOSERP.BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
    }
}
