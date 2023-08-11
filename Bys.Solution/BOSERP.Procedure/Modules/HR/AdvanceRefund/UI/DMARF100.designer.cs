using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRefund.UI
{
	/// <summary>
	/// Summary description for DMARF100
	/// </summary>
	partial class DMARF100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMARF100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeEmployeeNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddAdvanceRequest = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRAdvanceRefundItemRequests = new BOSERP.Modules.AdvanceRefund.HRAdvanceRefundItemRequestsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRAdvanceRefundItemInvoices = new BOSERP.Modules.AdvanceRefund.HRAdvanceRefundItemInvoicesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddInvoice = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRAdvanceRefundItemInvoices2 = new BOSERP.Modules.AdvanceRefund.HRAdvanceRefundItemInvoicesGridControl2();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.AdvanceRefund.DocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeHRAdvanceRefundPaymentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAdvanceRefundTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRAdvanceRefundDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRAdvanceRefundStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRAdvanceRefundDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtHRAdvanceRefundExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAdvanceRefundNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeEmployeeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRefundDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeEmployeeNo);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeHRAdvanceRefundPaymentType);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtHRAdvanceRefundTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel34);
            this.bosPanel1.Controls.Add(this.fld_dteHRAdvanceRefundDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRAdvanceRefundStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medHRAdvanceRefundDesc);
            this.bosPanel1.Controls.Add(this.fld_txtHRAdvanceRefundExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtHRAdvanceRefundNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(900, 602);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "HRAdvanceRefunds";
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
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(657, 64);
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
            this.fld_lkeFK_PMProjectID.TabIndex = 8;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            this.fld_lkeFK_PMProjectID.Visible = false;
            this.fld_lkeFK_PMProjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_PMProjectID_CloseUp);
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
            this.bosLabel7.Location = new System.Drawing.Point(558, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 635;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Mã dự án";
            this.bosLabel7.Visible = false;
            // 
            // fld_lkeEmployeeNo
            // 
            this.fld_lkeEmployeeNo.BOSAllowAddNew = false;
            this.fld_lkeEmployeeNo.BOSAllowDummy = false;
            this.fld_lkeEmployeeNo.BOSComment = null;
            this.fld_lkeEmployeeNo.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeEmployeeNo.BOSDataSource = "HRAdvanceRefunds";
            this.fld_lkeEmployeeNo.BOSDescription = null;
            this.fld_lkeEmployeeNo.BOSError = null;
            this.fld_lkeEmployeeNo.BOSFieldGroup = null;
            this.fld_lkeEmployeeNo.BOSFieldParent = null;
            this.fld_lkeEmployeeNo.BOSFieldRelation = null;
            this.fld_lkeEmployeeNo.BOSPrivilege = null;
            this.fld_lkeEmployeeNo.BOSPropertyName = "EditValue";
            this.fld_lkeEmployeeNo.BOSSelectType = null;
            this.fld_lkeEmployeeNo.BOSSelectTypeValue = null;
            this.fld_lkeEmployeeNo.CurrentDisplayText = null;
            this.fld_lkeEmployeeNo.Location = new System.Drawing.Point(101, 38);
            this.fld_lkeEmployeeNo.Name = "fld_lkeEmployeeNo";
            this.fld_lkeEmployeeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeEmployeeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeEmployeeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeEmployeeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeEmployeeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeEmployeeNo.Properties.ColumnName = null;
            this.fld_lkeEmployeeNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeEmployeeNo.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeEmployeeNo.Properties.NullText = "";
            this.fld_lkeEmployeeNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeEmployeeNo.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeEmployeeNo.Screen = null;
            this.fld_lkeEmployeeNo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeEmployeeNo.TabIndex = 3;
            this.fld_lkeEmployeeNo.Tag = "DC";
            this.fld_lkeEmployeeNo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeEmployee_CloseUp);
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 138);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(894, 464);
            this.bosTabControl1.TabIndex = 11;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnAddAdvanceRequest);
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRAdvanceRefundItemRequests);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(892, 439);
            this.xtraTabPage1.Text = "Danh sách tạm ứng";
            // 
            // fld_btnAddAdvanceRequest
            // 
            this.fld_btnAddAdvanceRequest.BOSComment = null;
            this.fld_btnAddAdvanceRequest.BOSDataMember = null;
            this.fld_btnAddAdvanceRequest.BOSDataSource = null;
            this.fld_btnAddAdvanceRequest.BOSDescription = null;
            this.fld_btnAddAdvanceRequest.BOSError = null;
            this.fld_btnAddAdvanceRequest.BOSFieldGroup = null;
            this.fld_btnAddAdvanceRequest.BOSFieldRelation = null;
            this.fld_btnAddAdvanceRequest.BOSPrivilege = null;
            this.fld_btnAddAdvanceRequest.BOSPropertyName = null;
            this.fld_btnAddAdvanceRequest.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddAdvanceRequest.Location = new System.Drawing.Point(3, 3);
            this.fld_btnAddAdvanceRequest.Name = "fld_btnAddAdvanceRequest";
            this.fld_btnAddAdvanceRequest.Screen = null;
            this.fld_btnAddAdvanceRequest.Size = new System.Drawing.Size(131, 27);
            this.fld_btnAddAdvanceRequest.TabIndex = 636;
            this.fld_btnAddAdvanceRequest.Text = "Chọn tạm ứng";
            this.fld_btnAddAdvanceRequest.Click += new System.EventHandler(this.fld_btnAddAdvanceRequest_Click);
            // 
            // fld_dgcHRAdvanceRefundItemRequests
            // 
            this.fld_dgcHRAdvanceRefundItemRequests.AllowDrop = true;
            this.fld_dgcHRAdvanceRefundItemRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRAdvanceRefundItemRequests.BOSComment = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSDataMember = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSDataSource = "HRAdvanceRefundItemRequests";
            this.fld_dgcHRAdvanceRefundItemRequests.BOSDescription = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSError = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSFieldGroup = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSFieldRelation = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSGridType = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSPrivilege = null;
            this.fld_dgcHRAdvanceRefundItemRequests.BOSPropertyName = null;
            this.fld_dgcHRAdvanceRefundItemRequests.CommodityType = "";
            this.fld_dgcHRAdvanceRefundItemRequests.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAdvanceRefundItemRequests.Location = new System.Drawing.Point(2, 36);
            this.fld_dgcHRAdvanceRefundItemRequests.MainView = this.gridView1;
            this.fld_dgcHRAdvanceRefundItemRequests.Name = "fld_dgcHRAdvanceRefundItemRequests";
            this.fld_dgcHRAdvanceRefundItemRequests.PrintReport = false;
            this.fld_dgcHRAdvanceRefundItemRequests.Screen = null;
            this.fld_dgcHRAdvanceRefundItemRequests.Size = new System.Drawing.Size(887, 400);
            this.fld_dgcHRAdvanceRefundItemRequests.TabIndex = 2;
            this.fld_dgcHRAdvanceRefundItemRequests.Tag = "DC";
            this.fld_dgcHRAdvanceRefundItemRequests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHRAdvanceRefundItemRequests;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcHRAdvanceRefundItemInvoices);
            this.xtraTabPage3.Controls.Add(this.fld_btnAddInvoice);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(892, 439);
            this.xtraTabPage3.Text = "Danh sách hóa đơn đã nhập";
            // 
            // fld_dgcHRAdvanceRefundItemInvoices
            // 
            this.fld_dgcHRAdvanceRefundItemInvoices.AllowDrop = true;
            this.fld_dgcHRAdvanceRefundItemInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSComment = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSDataMember = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSDataSource = "HRAdvanceRefundItemInvoices";
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSDescription = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSError = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSFieldGroup = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSFieldRelation = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSGridType = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSPrivilege = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.BOSPropertyName = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.CommodityType = "";
            this.fld_dgcHRAdvanceRefundItemInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAdvanceRefundItemInvoices.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcHRAdvanceRefundItemInvoices.MainView = this.gridView2;
            this.fld_dgcHRAdvanceRefundItemInvoices.Name = "fld_dgcHRAdvanceRefundItemInvoices";
            this.fld_dgcHRAdvanceRefundItemInvoices.PrintReport = false;
            this.fld_dgcHRAdvanceRefundItemInvoices.Screen = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.Size = new System.Drawing.Size(886, 400);
            this.fld_dgcHRAdvanceRefundItemInvoices.TabIndex = 2;
            this.fld_dgcHRAdvanceRefundItemInvoices.Tag = "DC";
            this.fld_dgcHRAdvanceRefundItemInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHRAdvanceRefundItemInvoices;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_btnAddInvoice
            // 
            this.fld_btnAddInvoice.BOSComment = null;
            this.fld_btnAddInvoice.BOSDataMember = null;
            this.fld_btnAddInvoice.BOSDataSource = null;
            this.fld_btnAddInvoice.BOSDescription = null;
            this.fld_btnAddInvoice.BOSError = null;
            this.fld_btnAddInvoice.BOSFieldGroup = null;
            this.fld_btnAddInvoice.BOSFieldRelation = null;
            this.fld_btnAddInvoice.BOSPrivilege = null;
            this.fld_btnAddInvoice.BOSPropertyName = null;
            this.fld_btnAddInvoice.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddInvoice.Location = new System.Drawing.Point(3, 3);
            this.fld_btnAddInvoice.Name = "fld_btnAddInvoice";
            this.fld_btnAddInvoice.Screen = null;
            this.fld_btnAddInvoice.Size = new System.Drawing.Size(131, 27);
            this.fld_btnAddInvoice.TabIndex = 1;
            this.fld_btnAddInvoice.Text = "Chọn hóa đơn";
            this.fld_btnAddInvoice.Click += new System.EventHandler(this.fld_btnAddInvoice_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcHRAdvanceRefundItemInvoices2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(892, 439);
            this.xtraTabPage4.Text = "Danh sách hóa đơn chưa nhập";
            // 
            // fld_dgcHRAdvanceRefundItemInvoices2
            // 
            this.fld_dgcHRAdvanceRefundItemInvoices2.AllowDrop = true;
            this.fld_dgcHRAdvanceRefundItemInvoices2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSComment = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSDataMember = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSDataSource = "HRAdvanceRefundItemInvoices";
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSDescription = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSError = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSFieldGroup = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSFieldRelation = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSGridType = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSPrivilege = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.BOSPropertyName = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.CommodityType = "";
            this.fld_dgcHRAdvanceRefundItemInvoices2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAdvanceRefundItemInvoices2.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHRAdvanceRefundItemInvoices2.MainView = this.gridView3;
            this.fld_dgcHRAdvanceRefundItemInvoices2.Name = "fld_dgcHRAdvanceRefundItemInvoices2";
            this.fld_dgcHRAdvanceRefundItemInvoices2.PrintReport = false;
            this.fld_dgcHRAdvanceRefundItemInvoices2.Screen = null;
            this.fld_dgcHRAdvanceRefundItemInvoices2.Size = new System.Drawing.Size(886, 433);
            this.fld_dgcHRAdvanceRefundItemInvoices2.TabIndex = 3;
            this.fld_dgcHRAdvanceRefundItemInvoices2.Tag = "DC";
            this.fld_dgcHRAdvanceRefundItemInvoices2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcHRAdvanceRefundItemInvoices2;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(892, 439);
            this.xtraTabPage2.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(892, 439);
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
            // fld_lkeHRAdvanceRefundPaymentType
            // 
            this.fld_lkeHRAdvanceRefundPaymentType.BOSAllowAddNew = false;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSAllowDummy = false;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSComment = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSDataMember = "HRAdvanceRefundPaymentType";
            this.fld_lkeHRAdvanceRefundPaymentType.BOSDataSource = "HRAdvanceRefunds";
            this.fld_lkeHRAdvanceRefundPaymentType.BOSDescription = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSError = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSFieldGroup = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSFieldParent = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSFieldRelation = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSPrivilege = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdvanceRefundPaymentType.BOSSelectType = null;
            this.fld_lkeHRAdvanceRefundPaymentType.BOSSelectTypeValue = null;
            this.fld_lkeHRAdvanceRefundPaymentType.CurrentDisplayText = null;
            this.fld_lkeHRAdvanceRefundPaymentType.Location = new System.Drawing.Point(370, 64);
            this.fld_lkeHRAdvanceRefundPaymentType.MenuManager = this.screenToolbar;
            this.fld_lkeHRAdvanceRefundPaymentType.Name = "fld_lkeHRAdvanceRefundPaymentType";
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.ColumnName = null;
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.NullText = "";
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.ReadOnly = true;
            this.fld_lkeHRAdvanceRefundPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdvanceRefundPaymentType.Screen = null;
            this.fld_lkeHRAdvanceRefundPaymentType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRAdvanceRefundPaymentType.TabIndex = 7;
            this.fld_lkeHRAdvanceRefundPaymentType.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(281, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(75, 13);
            this.bosLabel5.TabIndex = 630;
            this.bosLabel5.Text = "Loại thanh toán";
            // 
            // fld_txtHRAdvanceRefundTotalAmount
            // 
            this.fld_txtHRAdvanceRefundTotalAmount.BOSComment = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSDataMember = "HRAdvanceRefundTotalAmount";
            this.fld_txtHRAdvanceRefundTotalAmount.BOSDataSource = "HRAdvanceRefunds";
            this.fld_txtHRAdvanceRefundTotalAmount.BOSDescription = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSError = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSFieldGroup = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSFieldRelation = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSPrivilege = null;
            this.fld_txtHRAdvanceRefundTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtHRAdvanceRefundTotalAmount.Location = new System.Drawing.Point(101, 64);
            this.fld_txtHRAdvanceRefundTotalAmount.Name = "fld_txtHRAdvanceRefundTotalAmount";
            this.fld_txtHRAdvanceRefundTotalAmount.Properties.ReadOnly = true;
            this.fld_txtHRAdvanceRefundTotalAmount.Screen = null;
            this.fld_txtHRAdvanceRefundTotalAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRefundTotalAmount.TabIndex = 6;
            this.fld_txtHRAdvanceRefundTotalAmount.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(17, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 628;
            this.bosLabel4.Text = "Tổng tiền";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = "";
            this.bosLabel34.BOSDataSource = "";
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = "";
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(17, 41);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(48, 13);
            this.bosLabel34.TabIndex = 626;
            this.bosLabel34.Text = "Nhân viên";
            // 
            // fld_dteHRAdvanceRefundDate
            // 
            this.fld_dteHRAdvanceRefundDate.BOSComment = null;
            this.fld_dteHRAdvanceRefundDate.BOSDataMember = "HRAdvanceRefundDate";
            this.fld_dteHRAdvanceRefundDate.BOSDataSource = "HRAdvanceRefunds";
            this.fld_dteHRAdvanceRefundDate.BOSDescription = null;
            this.fld_dteHRAdvanceRefundDate.BOSError = null;
            this.fld_dteHRAdvanceRefundDate.BOSFieldGroup = null;
            this.fld_dteHRAdvanceRefundDate.BOSFieldRelation = null;
            this.fld_dteHRAdvanceRefundDate.BOSPrivilege = null;
            this.fld_dteHRAdvanceRefundDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAdvanceRefundDate.EditValue = null;
            this.fld_dteHRAdvanceRefundDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteHRAdvanceRefundDate.Name = "fld_dteHRAdvanceRefundDate";
            this.fld_dteHRAdvanceRefundDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdvanceRefundDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdvanceRefundDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdvanceRefundDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdvanceRefundDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdvanceRefundDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdvanceRefundDate.Screen = null;
            this.fld_dteHRAdvanceRefundDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRAdvanceRefundDate.TabIndex = 1;
            this.fld_dteHRAdvanceRefundDate.Tag = "DC";
            this.fld_dteHRAdvanceRefundDate.Validated += new System.EventHandler(this.fld_dteHRAdvanceRefundDate_Validated);
            // 
            // fld_lkeHRAdvanceRefundStatus
            // 
            this.fld_lkeHRAdvanceRefundStatus.BOSAllowAddNew = false;
            this.fld_lkeHRAdvanceRefundStatus.BOSAllowDummy = false;
            this.fld_lkeHRAdvanceRefundStatus.BOSComment = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSDataMember = "HRAdvanceRefundStatus";
            this.fld_lkeHRAdvanceRefundStatus.BOSDataSource = "HRAdvanceRefunds";
            this.fld_lkeHRAdvanceRefundStatus.BOSDescription = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSError = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSFieldGroup = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSFieldParent = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSFieldRelation = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSPrivilege = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdvanceRefundStatus.BOSSelectType = null;
            this.fld_lkeHRAdvanceRefundStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRAdvanceRefundStatus.CurrentDisplayText = null;
            this.fld_lkeHRAdvanceRefundStatus.Location = new System.Drawing.Point(657, 12);
            this.fld_lkeHRAdvanceRefundStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRAdvanceRefundStatus.Name = "fld_lkeHRAdvanceRefundStatus";
            this.fld_lkeHRAdvanceRefundStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRAdvanceRefundStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdvanceRefundStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdvanceRefundStatus.Properties.ColumnName = null;
            this.fld_lkeHRAdvanceRefundStatus.Properties.NullText = "";
            this.fld_lkeHRAdvanceRefundStatus.Properties.ReadOnly = true;
            this.fld_lkeHRAdvanceRefundStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdvanceRefundStatus.Screen = null;
            this.fld_lkeHRAdvanceRefundStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRAdvanceRefundStatus.TabIndex = 2;
            this.fld_lkeHRAdvanceRefundStatus.Tag = "DC";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(558, 15);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 80;
            this.fld_lblLabel25.Text = "Tình trạng";
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
            this.bosLabel3.Location = new System.Drawing.Point(17, 93);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_medHRAdvanceRefundDesc
            // 
            this.fld_medHRAdvanceRefundDesc.BOSComment = "";
            this.fld_medHRAdvanceRefundDesc.BOSDataMember = "HRAdvanceRefundDesc";
            this.fld_medHRAdvanceRefundDesc.BOSDataSource = "HRAdvanceRefunds";
            this.fld_medHRAdvanceRefundDesc.BOSDescription = null;
            this.fld_medHRAdvanceRefundDesc.BOSError = null;
            this.fld_medHRAdvanceRefundDesc.BOSFieldGroup = "";
            this.fld_medHRAdvanceRefundDesc.BOSFieldRelation = "";
            this.fld_medHRAdvanceRefundDesc.BOSPrivilege = "";
            this.fld_medHRAdvanceRefundDesc.BOSPropertyName = "EditValue";
            this.fld_medHRAdvanceRefundDesc.EditValue = "";
            this.fld_medHRAdvanceRefundDesc.Location = new System.Drawing.Point(101, 90);
            this.fld_medHRAdvanceRefundDesc.Name = "fld_medHRAdvanceRefundDesc";
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRAdvanceRefundDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRAdvanceRefundDesc, true);
            this.fld_medHRAdvanceRefundDesc.Size = new System.Drawing.Size(706, 42);
            this.fld_medHRAdvanceRefundDesc.TabIndex = 9;
            this.fld_medHRAdvanceRefundDesc.Tag = "DC";
            this.fld_medHRAdvanceRefundDesc.TextChanged += new System.EventHandler(this.fld_medHRAdvanceRefundDesc_TextChanged);
            // 
            // fld_txtHRAdvanceRefundExchangeRate
            // 
            this.fld_txtHRAdvanceRefundExchangeRate.BOSComment = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSDataMember = "HRAdvanceRefundExchangeRate";
            this.fld_txtHRAdvanceRefundExchangeRate.BOSDataSource = "HRAdvanceRefunds";
            this.fld_txtHRAdvanceRefundExchangeRate.BOSDescription = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSError = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSFieldGroup = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSFieldRelation = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSPrivilege = null;
            this.fld_txtHRAdvanceRefundExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtHRAdvanceRefundExchangeRate.Location = new System.Drawing.Point(657, 38);
            this.fld_txtHRAdvanceRefundExchangeRate.Name = "fld_txtHRAdvanceRefundExchangeRate";
            this.fld_txtHRAdvanceRefundExchangeRate.Screen = null;
            this.fld_txtHRAdvanceRefundExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRefundExchangeRate.TabIndex = 5;
            this.fld_txtHRAdvanceRefundExchangeRate.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
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
            this.bosLabel12.Location = new System.Drawing.Point(558, 41);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 75;
            this.bosLabel12.Text = "Tỷ giá";
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
            this.bosLabel11.Location = new System.Drawing.Point(281, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 76;
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "HRAdvanceRefunds";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(370, 38);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.bosLabel2.Location = new System.Drawing.Point(281, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Ngày chứng từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(17, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtHRAdvanceRefundNo
            // 
            this.fld_txtHRAdvanceRefundNo.BOSComment = "";
            this.fld_txtHRAdvanceRefundNo.BOSDataMember = "HRAdvanceRefundNo";
            this.fld_txtHRAdvanceRefundNo.BOSDataSource = "HRAdvanceRefunds";
            this.fld_txtHRAdvanceRefundNo.BOSDescription = null;
            this.fld_txtHRAdvanceRefundNo.BOSError = null;
            this.fld_txtHRAdvanceRefundNo.BOSFieldGroup = "";
            this.fld_txtHRAdvanceRefundNo.BOSFieldRelation = "";
            this.fld_txtHRAdvanceRefundNo.BOSPrivilege = "";
            this.fld_txtHRAdvanceRefundNo.BOSPropertyName = "Text";
            this.fld_txtHRAdvanceRefundNo.EditValue = "";
            this.fld_txtHRAdvanceRefundNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtHRAdvanceRefundNo.Name = "fld_txtHRAdvanceRefundNo";
            this.fld_txtHRAdvanceRefundNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdvanceRefundNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdvanceRefundNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdvanceRefundNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdvanceRefundNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdvanceRefundNo.Properties.ReadOnly = true;
            this.fld_txtHRAdvanceRefundNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdvanceRefundNo.Screen = null;
            this.fld_txtHRAdvanceRefundNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRefundNo.TabIndex = 0;
            this.fld_txtHRAdvanceRefundNo.Tag = "DC";
            // 
            // DMARF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(900, 602);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMARF100.IconOptions.Icon")));
            this.Name = "DMARF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeEmployeeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRefundDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRefundNo;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRefundExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medHRAdvanceRefundDesc;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdvanceRefundStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSDateEdit fld_dteHRAdvanceRefundDate;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdvanceRefundPaymentType;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRefundTotalAmount;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLookupEdit fld_lkeEmployeeNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSButton fld_btnAddInvoice;
        private HRAdvanceRefundItemInvoicesGridControl fld_dgcHRAdvanceRefundItemInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddAdvanceRequest;
        private HRAdvanceRefundItemRequestsGridControl fld_dgcHRAdvanceRefundItemRequests;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HRAdvanceRefundItemInvoicesGridControl2 fld_dgcHRAdvanceRefundItemInvoices2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}
