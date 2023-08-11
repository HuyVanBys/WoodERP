using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentOrder.UI
{
	/// <summary>
	/// Summary description for DMBPO100
	/// </summary>
	partial class DMBPO100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBPO100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACBankTransactionItems = new BOSERP.Modules.PaymentOrder.PaymentOrderItemGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACListAccountBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACBankTransactionReceiverBankName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACBankTransactionReceiverIDDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACBankTransactionReceiverIDPlace = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverIDNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverContactAddress = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverBankCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverAccount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACLoanReceiptID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACBankTransactionSenderBankName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACBankTransactionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medACBankTransactionDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionSenderAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACBankTransactionDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteACBankTransactionEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtACBankTransactionExchangeRate123 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverContactAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverAccount.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACBankTransactionDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionExchangeRate123.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_pteACBankTransactionEmployeePicture);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1178, 601);
            this.bosPanel1.TabIndex = 0;
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 240);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1172, 349);
            this.bosTabControl1.TabIndex = 133;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcACBankTransactionItems);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1170, 324);
            this.xtraTabPage2.Text = "Thông tin chi tiết";
            // 
            // fld_dgcACBankTransactionItems
            // 
            this.fld_dgcACBankTransactionItems.AllowDrop = true;
            this.fld_dgcACBankTransactionItems.BOSComment = "";
            this.fld_dgcACBankTransactionItems.BOSDataMember = "";
            this.fld_dgcACBankTransactionItems.BOSDataSource = "ACBankTransactionItems";
            this.fld_dgcACBankTransactionItems.BOSDescription = null;
            this.fld_dgcACBankTransactionItems.BOSError = null;
            this.fld_dgcACBankTransactionItems.BOSFieldGroup = "";
            this.fld_dgcACBankTransactionItems.BOSFieldRelation = "";
            this.fld_dgcACBankTransactionItems.BOSGridType = null;
            this.fld_dgcACBankTransactionItems.BOSPrivilege = "";
            this.fld_dgcACBankTransactionItems.BOSPropertyName = "";
            this.fld_dgcACBankTransactionItems.CommodityType = "";
            this.fld_dgcACBankTransactionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACBankTransactionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBankTransactionItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACBankTransactionItems.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcACBankTransactionItems.Name = "fld_dgcACBankTransactionItems";
            this.fld_dgcACBankTransactionItems.PrintReport = false;
            this.fld_dgcACBankTransactionItems.Screen = null;
            this.fld_dgcACBankTransactionItems.Size = new System.Drawing.Size(1170, 324);
            this.fld_dgcACBankTransactionItems.TabIndex = 1;
            this.fld_dgcACBankTransactionItems.Tag = "DC";
            this.fld_dgcACBankTransactionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactionItems});
            // 
            // fld_dgvACBankTransactionItems
            // 
            this.fld_dgvACBankTransactionItems.GridControl = this.fld_dgcACBankTransactionItems;
            this.fld_dgvACBankTransactionItems.Name = "fld_dgvACBankTransactionItems";
            this.fld_dgvACBankTransactionItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1156, 317);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1156, 317);
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
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = "";
            this.bosLine1.BOSDataMember = "";
            this.bosLine1.BOSDataSource = "";
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = "";
            this.bosLine1.BOSFieldRelation = "";
            this.bosLine1.BOSPrivilege = "";
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_lkeFK_ACListAccountBankID);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverBankName);
            this.bosLine1.Controls.Add(this.bosLabel24);
            this.bosLine1.Controls.Add(this.fld_dteACBankTransactionReceiverIDDate);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverIDPlace);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverIDNumber);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverContactAddress);
            this.bosLine1.Controls.Add(this.bosLabel21);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverName);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverBankCode);
            this.bosLine1.Controls.Add(this.bosLabel12);
            this.bosLine1.Controls.Add(this.fld_txtACBankTransactionReceiverAccount);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Controls.Add(this.bosLabel11);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(640, 6);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(483, 228);
            this.bosLine1.TabIndex = 132;
            this.bosLine1.TabStop = false;
            this.bosLine1.Tag = "";
            this.bosLine1.Text = "Thông tin người nhận";
            // 
            // fld_lkeFK_ACListAccountBankID
            // 
            this.fld_lkeFK_ACListAccountBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACListAccountBankID.BOSAllowDummy = false;
            this.fld_lkeFK_ACListAccountBankID.BOSComment = "";
            this.fld_lkeFK_ACListAccountBankID.BOSDataMember = "FK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_ACListAccountBankID.BOSDescription = null;
            this.fld_lkeFK_ACListAccountBankID.BOSError = null;
            this.fld_lkeFK_ACListAccountBankID.BOSFieldGroup = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldParent = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldRelation = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPrivilege = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectType = "";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACListAccountBankID.CurrentDisplayText = null;
            this.fld_lkeFK_ACListAccountBankID.Location = new System.Drawing.Point(100, 20);
            this.fld_lkeFK_ACListAccountBankID.Name = "fld_lkeFK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACListAccountBankID.Properties.ColumnName = null;
            this.fld_lkeFK_ACListAccountBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankNo", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankName", "Tên ngân hàng")});
            this.fld_lkeFK_ACListAccountBankID.Properties.DisplayMember = "ACListAccountBankName";
            this.fld_lkeFK_ACListAccountBankID.Properties.NullText = "";
            this.fld_lkeFK_ACListAccountBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACListAccountBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACListAccountBankID.Properties.ValueMember = "ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Screen = null;
            this.fld_lkeFK_ACListAccountBankID.Size = new System.Drawing.Size(370, 20);
            this.fld_lkeFK_ACListAccountBankID.TabIndex = 0;
            this.fld_lkeFK_ACListAccountBankID.Tag = "DC";
            this.fld_lkeFK_ACListAccountBankID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACListAccountBankID_QueryPopUp);
            this.fld_lkeFK_ACListAccountBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACListAccountBankID_CloseUp);
            // 
            // fld_txtACBankTransactionReceiverBankName
            // 
            this.fld_txtACBankTransactionReceiverBankName.BOSComment = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSDataMember = "ACBankTransactionReceiverBankName";
            this.fld_txtACBankTransactionReceiverBankName.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverBankName.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSError = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverBankName.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverBankName.Location = new System.Drawing.Point(100, 46);
            this.fld_txtACBankTransactionReceiverBankName.Name = "fld_txtACBankTransactionReceiverBankName";
            this.fld_txtACBankTransactionReceiverBankName.Screen = null;
            this.fld_txtACBankTransactionReceiverBankName.Size = new System.Drawing.Size(206, 20);
            this.fld_txtACBankTransactionReceiverBankName.TabIndex = 2;
            this.fld_txtACBankTransactionReceiverBankName.Tag = "DC";
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
            this.bosLabel24.Location = new System.Drawing.Point(13, 23);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(52, 13);
            this.bosLabel24.TabIndex = 9;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Ngân hàng";
            // 
            // fld_dteACBankTransactionReceiverIDDate
            // 
            this.fld_dteACBankTransactionReceiverIDDate.BOSComment = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDataMember = "ACBankTransactionReceiverIDDate";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDataSource = "ACBankTransactions";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDescription = null;
            this.fld_dteACBankTransactionReceiverIDDate.BOSError = null;
            this.fld_dteACBankTransactionReceiverIDDate.BOSFieldGroup = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSFieldRelation = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSPrivilege = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSPropertyName = "EditValue";
            this.fld_dteACBankTransactionReceiverIDDate.EditValue = null;
            this.fld_dteACBankTransactionReceiverIDDate.Location = new System.Drawing.Point(100, 124);
            this.fld_dteACBankTransactionReceiverIDDate.Name = "fld_dteACBankTransactionReceiverIDDate";
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBankTransactionReceiverIDDate.Screen = null;
            this.fld_dteACBankTransactionReceiverIDDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteACBankTransactionReceiverIDDate.TabIndex = 6;
            this.fld_dteACBankTransactionReceiverIDDate.Tag = "DC";
            // 
            // fld_txtACBankTransactionReceiverIDPlace
            // 
            this.fld_txtACBankTransactionReceiverIDPlace.BOSComment = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDataMember = "ACBankTransactionReceiverIDPlace";
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSError = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverIDPlace.Location = new System.Drawing.Point(333, 124);
            this.fld_txtACBankTransactionReceiverIDPlace.Name = "fld_txtACBankTransactionReceiverIDPlace";
            this.fld_txtACBankTransactionReceiverIDPlace.Screen = null;
            this.fld_txtACBankTransactionReceiverIDPlace.Size = new System.Drawing.Size(137, 20);
            this.fld_txtACBankTransactionReceiverIDPlace.TabIndex = 8;
            this.fld_txtACBankTransactionReceiverIDPlace.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(13, 101);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tài khoản";
            // 
            // fld_txtACBankTransactionReceiverIDNumber
            // 
            this.fld_txtACBankTransactionReceiverIDNumber.BOSComment = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDataMember = "ACBankTransactionReceiverIDNumber";
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSError = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverIDNumber.Location = new System.Drawing.Point(333, 98);
            this.fld_txtACBankTransactionReceiverIDNumber.Name = "fld_txtACBankTransactionReceiverIDNumber";
            this.fld_txtACBankTransactionReceiverIDNumber.Screen = null;
            this.fld_txtACBankTransactionReceiverIDNumber.Size = new System.Drawing.Size(137, 20);
            this.fld_txtACBankTransactionReceiverIDNumber.TabIndex = 4;
            this.fld_txtACBankTransactionReceiverIDNumber.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_txtACBankTransactionReceiverContactAddress
            // 
            this.fld_txtACBankTransactionReceiverContactAddress.BOSComment = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSDataMember = "ACBankTransactionReceiverContactAddress";
            this.fld_txtACBankTransactionReceiverContactAddress.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverContactAddress.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSError = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverContactAddress.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverContactAddress.Location = new System.Drawing.Point(100, 150);
            this.fld_txtACBankTransactionReceiverContactAddress.Name = "fld_txtACBankTransactionReceiverContactAddress";
            this.fld_txtACBankTransactionReceiverContactAddress.Screen = null;
            this.fld_txtACBankTransactionReceiverContactAddress.Size = new System.Drawing.Size(370, 20);
            this.fld_txtACBankTransactionReceiverContactAddress.TabIndex = 7;
            this.fld_txtACBankTransactionReceiverContactAddress.Tag = "DC";
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
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(321, 49);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 8;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Mã NH";
            // 
            // fld_txtACBankTransactionReceiverName
            // 
            this.fld_txtACBankTransactionReceiverName.BOSComment = null;
            this.fld_txtACBankTransactionReceiverName.BOSDataMember = "ACBankTransactionReceiverName";
            this.fld_txtACBankTransactionReceiverName.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverName.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverName.BOSError = null;
            this.fld_txtACBankTransactionReceiverName.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverName.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverName.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverName.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverName.Location = new System.Drawing.Point(100, 72);
            this.fld_txtACBankTransactionReceiverName.Name = "fld_txtACBankTransactionReceiverName";
            this.fld_txtACBankTransactionReceiverName.Screen = null;
            this.fld_txtACBankTransactionReceiverName.Size = new System.Drawing.Size(370, 20);
            this.fld_txtACBankTransactionReceiverName.TabIndex = 5;
            this.fld_txtACBankTransactionReceiverName.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(13, 75);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(75, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Tên người nhận";
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
            this.bosLabel9.Location = new System.Drawing.Point(271, 101);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(44, 13);
            this.bosLabel9.TabIndex = 6;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Số CMND";
            // 
            // fld_txtACBankTransactionReceiverBankCode
            // 
            this.fld_txtACBankTransactionReceiverBankCode.BOSComment = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSDataMember = "ACBankTransactionReceiverBankCode";
            this.fld_txtACBankTransactionReceiverBankCode.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverBankCode.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSError = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverBankCode.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverBankCode.Location = new System.Drawing.Point(358, 46);
            this.fld_txtACBankTransactionReceiverBankCode.Name = "fld_txtACBankTransactionReceiverBankCode";
            this.fld_txtACBankTransactionReceiverBankCode.Screen = null;
            this.fld_txtACBankTransactionReceiverBankCode.Size = new System.Drawing.Size(112, 20);
            this.fld_txtACBankTransactionReceiverBankCode.TabIndex = 3;
            this.fld_txtACBankTransactionReceiverBankCode.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(13, 152);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(32, 13);
            this.bosLabel12.TabIndex = 6;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Địa chỉ";
            // 
            // fld_txtACBankTransactionReceiverAccount
            // 
            this.fld_txtACBankTransactionReceiverAccount.BOSComment = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSDataMember = "ACBankTransactionReceiverAccount";
            this.fld_txtACBankTransactionReceiverAccount.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverAccount.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSError = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverAccount.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverAccount.Location = new System.Drawing.Point(100, 98);
            this.fld_txtACBankTransactionReceiverAccount.Name = "fld_txtACBankTransactionReceiverAccount";
            this.fld_txtACBankTransactionReceiverAccount.Screen = null;
            this.fld_txtACBankTransactionReceiverAccount.Size = new System.Drawing.Size(160, 20);
            this.fld_txtACBankTransactionReceiverAccount.TabIndex = 1;
            this.fld_txtACBankTransactionReceiverAccount.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(13, 127);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(45, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Ngày cấp";
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
            this.bosLabel11.Location = new System.Drawing.Point(271, 127);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(35, 13);
            this.bosLabel11.TabIndex = 6;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Nơi cấp";
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
            this.bosLine3.Controls.Add(this.fld_txtACBankTransactionExchangeRate123);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACLoanReceiptID);
            this.bosLine3.Controls.Add(this.fld_txtACBankTransactionSenderBankName);
            this.bosLine3.Controls.Add(this.fld_txtACBankTransactionNo);
            this.bosLine3.Controls.Add(this.fld_lblLabel2);
            this.bosLine3.Controls.Add(this.bosLabel23);
            this.bosLine3.Controls.Add(this.bosLabel8);
            this.bosLine3.Controls.Add(this.fld_lblLabel5);
            this.bosLine3.Controls.Add(this.bosLabel22);
            this.bosLine3.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosLine3.Controls.Add(this.fld_lblLabel6);
            this.bosLine3.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosLine3.Controls.Add(this.fld_medACBankTransactionDesc);
            this.bosLine3.Controls.Add(this.bosLabel5);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosLine3.Controls.Add(this.bosLabel13);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine3.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine3.Controls.Add(this.fld_lblLabel4);
            this.bosLine3.Controls.Add(this.bosLabel2);
            this.bosLine3.Controls.Add(this.fld_txtACBankTransactionSenderAccount);
            this.bosLine3.Controls.Add(this.fld_dteACBankTransactionDate);
            this.bosLine3.Controls.Add(this.bosLabel6);
            this.bosLine3.Controls.Add(this.bosLabel4);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(109, 4);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(525, 230);
            this.bosLine3.TabIndex = 131;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin chung";
            // 
            // fld_lkeFK_ACLoanReceiptID
            // 
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowDummy = true;
            this.fld_lkeFK_ACLoanReceiptID.BOSComment = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataMember = "FK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_ACLoanReceiptID.BOSDescription = null;
            this.fld_lkeFK_ACLoanReceiptID.BOSError = null;
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldGroup = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldParent = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldRelation = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSPrivilege = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACLoanReceiptID.BOSSelectType = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACLoanReceiptID.CurrentDisplayText = null;
            this.fld_lkeFK_ACLoanReceiptID.Location = new System.Drawing.Point(369, 124);
            this.fld_lkeFK_ACLoanReceiptID.Name = "fld_lkeFK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanReceiptID.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanReceiptNo", "Mã khế ước")});
            this.fld_lkeFK_ACLoanReceiptID.Properties.DisplayMember = "ACLoanReceiptNo";
            this.fld_lkeFK_ACLoanReceiptID.Properties.NullText = "";
            this.fld_lkeFK_ACLoanReceiptID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACLoanReceiptID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanReceiptID.Properties.ValueMember = "ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Screen = null;
            this.fld_lkeFK_ACLoanReceiptID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_ACLoanReceiptID.TabIndex = 19;
            this.fld_lkeFK_ACLoanReceiptID.Tag = "DC";
            this.fld_lkeFK_ACLoanReceiptID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACLoanReceiptID_CloseUp);
            // 
            // fld_txtACBankTransactionSenderBankName
            // 
            this.fld_txtACBankTransactionSenderBankName.BOSComment = null;
            this.fld_txtACBankTransactionSenderBankName.BOSDataMember = "ACBankTransactionSenderBankName";
            this.fld_txtACBankTransactionSenderBankName.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionSenderBankName.BOSDescription = null;
            this.fld_txtACBankTransactionSenderBankName.BOSError = null;
            this.fld_txtACBankTransactionSenderBankName.BOSFieldGroup = null;
            this.fld_txtACBankTransactionSenderBankName.BOSFieldRelation = null;
            this.fld_txtACBankTransactionSenderBankName.BOSPrivilege = null;
            this.fld_txtACBankTransactionSenderBankName.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionSenderBankName.Location = new System.Drawing.Point(92, 150);
            this.fld_txtACBankTransactionSenderBankName.Name = "fld_txtACBankTransactionSenderBankName";
            this.fld_txtACBankTransactionSenderBankName.Screen = null;
            this.fld_txtACBankTransactionSenderBankName.Size = new System.Drawing.Size(419, 20);
            this.fld_txtACBankTransactionSenderBankName.TabIndex = 13;
            this.fld_txtACBankTransactionSenderBankName.Tag = "DC";
            // 
            // fld_txtACBankTransactionNo
            // 
            this.fld_txtACBankTransactionNo.BOSComment = "";
            this.fld_txtACBankTransactionNo.BOSDataMember = "ACBankTransactionNo";
            this.fld_txtACBankTransactionNo.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionNo.BOSDescription = null;
            this.fld_txtACBankTransactionNo.BOSError = null;
            this.fld_txtACBankTransactionNo.BOSFieldGroup = "";
            this.fld_txtACBankTransactionNo.BOSFieldRelation = "";
            this.fld_txtACBankTransactionNo.BOSPrivilege = "";
            this.fld_txtACBankTransactionNo.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionNo.EditValue = "";
            this.fld_txtACBankTransactionNo.Location = new System.Drawing.Point(92, 20);
            this.fld_txtACBankTransactionNo.Name = "fld_txtACBankTransactionNo";
            this.fld_txtACBankTransactionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACBankTransactionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACBankTransactionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACBankTransactionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACBankTransactionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACBankTransactionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACBankTransactionNo.Screen = null;
            this.fld_txtACBankTransactionNo.Size = new System.Drawing.Size(142, 20);
            this.fld_txtACBankTransactionNo.TabIndex = 1;
            this.fld_txtACBankTransactionNo.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(14, 23);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 0;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
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
            this.bosLabel23.BOSPropertyName = "";
            this.bosLabel23.Location = new System.Drawing.Point(270, 127);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(60, 13);
            this.bosLabel23.TabIndex = 130;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Khế ước vay";
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
            this.bosLabel8.Location = new System.Drawing.Point(14, 154);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 4;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tên ngân hàng";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(14, 49);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 0;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
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
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(14, 127);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(45, 13);
            this.bosLabel22.TabIndex = 128;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Mã dự án";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(92, 72);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankAccount", "Số tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 9;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(14, 180);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(92, 124);
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
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 18;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // fld_medACBankTransactionDesc
            // 
            this.fld_medACBankTransactionDesc.BOSComment = "";
            this.fld_medACBankTransactionDesc.BOSDataMember = "ACBankTransactionDesc";
            this.fld_medACBankTransactionDesc.BOSDataSource = "ACBankTransactions";
            this.fld_medACBankTransactionDesc.BOSDescription = null;
            this.fld_medACBankTransactionDesc.BOSError = null;
            this.fld_medACBankTransactionDesc.BOSFieldGroup = "";
            this.fld_medACBankTransactionDesc.BOSFieldRelation = "";
            this.fld_medACBankTransactionDesc.BOSPrivilege = "";
            this.fld_medACBankTransactionDesc.BOSPropertyName = "Text";
            this.fld_medACBankTransactionDesc.EditValue = "";
            this.fld_medACBankTransactionDesc.Location = new System.Drawing.Point(92, 176);
            this.fld_medACBankTransactionDesc.Name = "fld_medACBankTransactionDesc";
            this.fld_medACBankTransactionDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACBankTransactionDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACBankTransactionDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACBankTransactionDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACBankTransactionDesc.Screen = null;
            this.fld_medACBankTransactionDesc.Size = new System.Drawing.Size(419, 47);
            this.fld_medACBankTransactionDesc.TabIndex = 16;
            this.fld_medACBankTransactionDesc.Tag = "DC";
            this.fld_medACBankTransactionDesc.Validated += new System.EventHandler(this.fld_medACBankTransactionDesc_Validated);
            // 
            // bosLabel5
            // 
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
            this.bosLabel5.Location = new System.Drawing.Point(14, 75);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 4;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngân hàng";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(369, 46);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 14;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            this.fld_lkeFK_ACSegmentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACSegmentID_CloseUp);
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
            this.bosLabel13.Location = new System.Drawing.Point(270, 49);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(85, 13);
            this.bosLabel13.TabIndex = 48;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Khoản mục chi phí";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(92, 46);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 5;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(92, 98);
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
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 6;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(270, 23);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 2;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(14, 101);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_txtACBankTransactionSenderAccount
            // 
            this.fld_txtACBankTransactionSenderAccount.BOSComment = null;
            this.fld_txtACBankTransactionSenderAccount.BOSDataMember = "ACBankTransactionSenderAccount";
            this.fld_txtACBankTransactionSenderAccount.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionSenderAccount.BOSDescription = null;
            this.fld_txtACBankTransactionSenderAccount.BOSError = null;
            this.fld_txtACBankTransactionSenderAccount.BOSFieldGroup = null;
            this.fld_txtACBankTransactionSenderAccount.BOSFieldRelation = null;
            this.fld_txtACBankTransactionSenderAccount.BOSPrivilege = null;
            this.fld_txtACBankTransactionSenderAccount.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionSenderAccount.Location = new System.Drawing.Point(369, 72);
            this.fld_txtACBankTransactionSenderAccount.Name = "fld_txtACBankTransactionSenderAccount";
            this.fld_txtACBankTransactionSenderAccount.Screen = null;
            this.fld_txtACBankTransactionSenderAccount.Size = new System.Drawing.Size(142, 20);
            this.fld_txtACBankTransactionSenderAccount.TabIndex = 10;
            this.fld_txtACBankTransactionSenderAccount.Tag = "DC";
            // 
            // fld_dteACBankTransactionDate
            // 
            this.fld_dteACBankTransactionDate.BOSComment = "";
            this.fld_dteACBankTransactionDate.BOSDataMember = "ACBankTransactionDate";
            this.fld_dteACBankTransactionDate.BOSDataSource = "ACBankTransactions";
            this.fld_dteACBankTransactionDate.BOSDescription = null;
            this.fld_dteACBankTransactionDate.BOSError = null;
            this.fld_dteACBankTransactionDate.BOSFieldGroup = "";
            this.fld_dteACBankTransactionDate.BOSFieldRelation = "";
            this.fld_dteACBankTransactionDate.BOSPrivilege = "";
            this.fld_dteACBankTransactionDate.BOSPropertyName = "EditValue";
            this.fld_dteACBankTransactionDate.EditValue = null;
            this.fld_dteACBankTransactionDate.Location = new System.Drawing.Point(369, 20);
            this.fld_dteACBankTransactionDate.Name = "fld_dteACBankTransactionDate";
            this.fld_dteACBankTransactionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBankTransactionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBankTransactionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBankTransactionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBankTransactionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBankTransactionDate.Screen = null;
            this.fld_dteACBankTransactionDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteACBankTransactionDate.TabIndex = 2;
            this.fld_dteACBankTransactionDate.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(270, 75);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tài khoản";
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
            this.bosLabel4.Location = new System.Drawing.Point(270, 101);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(25, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỉ giá";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 104);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteACBankTransactionEmployeePicture
            // 
            this.fld_pteACBankTransactionEmployeePicture.BOSComment = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSDataMember = "ACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.BOSDataSource = "ACBankTransactions";
            this.fld_pteACBankTransactionEmployeePicture.BOSDescription = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSError = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPrivilege = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACBankTransactionEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACBankTransactionEmployeePicture.FileName = null;
            this.fld_pteACBankTransactionEmployeePicture.FilePath = null;
            this.fld_pteACBankTransactionEmployeePicture.Location = new System.Drawing.Point(3, 6);
            this.fld_pteACBankTransactionEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACBankTransactionEmployeePicture.Name = "fld_pteACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACBankTransactionEmployeePicture.Screen = null;
            this.fld_pteACBankTransactionEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACBankTransactionEmployeePicture.TabIndex = 0;
            this.fld_pteACBankTransactionEmployeePicture.Tag = "DC";
            // 
            // fld_txtACBankTransactionExchangeRate123
            // 
            this.fld_txtACBankTransactionExchangeRate123.BOSComment = "";
            this.fld_txtACBankTransactionExchangeRate123.BOSDataMember = "ACBankTransactionExchangeRate";
            this.fld_txtACBankTransactionExchangeRate123.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionExchangeRate123.BOSDescription = null;
            this.fld_txtACBankTransactionExchangeRate123.BOSError = null;
            this.fld_txtACBankTransactionExchangeRate123.BOSFieldGroup = "";
            this.fld_txtACBankTransactionExchangeRate123.BOSFieldRelation = "";
            this.fld_txtACBankTransactionExchangeRate123.BOSPrivilege = "";
            this.fld_txtACBankTransactionExchangeRate123.BOSPropertyName = "EditValue";
            this.fld_txtACBankTransactionExchangeRate123.EditValue = "";
            this.fld_txtACBankTransactionExchangeRate123.Location = new System.Drawing.Point(369, 98);
            this.fld_txtACBankTransactionExchangeRate123.Name = "fld_txtACBankTransactionExchangeRate123";
            this.fld_txtACBankTransactionExchangeRate123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACBankTransactionExchangeRate123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACBankTransactionExchangeRate123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACBankTransactionExchangeRate123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACBankTransactionExchangeRate123.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACBankTransactionExchangeRate123.Screen = null;
            this.fld_txtACBankTransactionExchangeRate123.Size = new System.Drawing.Size(142, 20);
            this.fld_txtACBankTransactionExchangeRate123.TabIndex = 15;
            this.fld_txtACBankTransactionExchangeRate123.Tag = "DC";
            this.fld_txtACBankTransactionExchangeRate123.Validated += new System.EventHandler(this.fld_txtACBankTransactionExchangeRate_Validated);
            // 
            // DMBPO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1178, 601);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBPO100.IconOptions.Icon")));
            this.Name = "DMBPO100";
            this.Text = "Thông tin chung";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverContactAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverAccount.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACBankTransactionDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionExchangeRate123.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionSenderAccount;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteACBankTransactionEmployeePicture;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionNo;
        private BOSComponent.BOSDateEdit fld_dteACBankTransactionDate;
        private BOSComponent.BOSMemoEdit fld_medACBankTransactionDesc;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverAccount;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverName;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionSenderBankName;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverIDPlace;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverIDNumber;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteACBankTransactionReceiverIDDate;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverContactAddress;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverBankCode;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanReceiptID;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACListAccountBankID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverBankName;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private PaymentOrderItemGridControl fld_dgcACBankTransactionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionExchangeRate123;
    }
}
