using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ClearingDebt.UI
{
	/// <summary>
	/// Summary description for DMDC100
	/// </summary>
    partial class DMCD100
    {
		private BOSComponent.BOSTextBox fld_txtACClearingDebtNo;
		private BOSComponent.BOSDateEdit fld_dteACClearingDebtDate;
		private BOSComponent.BOSMemoEdit fld_medACClearingDebtDesc;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;


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
            this.fld_txtACClearingDebtNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACClearingDebtDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medACClearingDebtDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeObject2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tabCustomerPayments = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageCustomerPayment = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_dgcACClearingDebtInvoiceInItems = new BOSERP.Modules.ClearingDebt.ACClearingDebtInvoiceInItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnInvoiceIn = new BOSComponent.BOSButton(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dgcACClearingDebtInvoiceItems = new BOSERP.Modules.ClearingDebt.ACClearingDebtInvoiceItemsGridControl();
            this.fld_dgvARCustomerPaymentTimePayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnInvoice = new BOSComponent.BOSButton(this.components);
            this.fld_tabPagePosting = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_pteACClearingDebtEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACClearingDebtExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACClearingDebtAmountClearing = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACClearingDebtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACClearingDebtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACClearingDebtDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeObject2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).BeginInit();
            this.fld_tabCustomerPayments.SuspendLayout();
            this.fld_tabPageCustomerPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACClearingDebtInvoiceInItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACClearingDebtInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).BeginInit();
            this.fld_tabPagePosting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACClearingDebtEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtAmountClearing.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACClearingDebtNo
            // 
            this.fld_txtACClearingDebtNo.BOSComment = "";
            this.fld_txtACClearingDebtNo.BOSDataMember = "ACClearingDebtNo";
            this.fld_txtACClearingDebtNo.BOSDataSource = "ACClearingDebts";
            this.fld_txtACClearingDebtNo.BOSDescription = null;
            this.fld_txtACClearingDebtNo.BOSError = null;
            this.fld_txtACClearingDebtNo.BOSFieldGroup = "";
            this.fld_txtACClearingDebtNo.BOSFieldRelation = "";
            this.fld_txtACClearingDebtNo.BOSPrivilege = "";
            this.fld_txtACClearingDebtNo.BOSPropertyName = "Text";
            this.fld_txtACClearingDebtNo.EditValue = "";
            this.fld_txtACClearingDebtNo.Location = new System.Drawing.Point(219, 12);
            this.fld_txtACClearingDebtNo.Name = "fld_txtACClearingDebtNo";
            this.fld_txtACClearingDebtNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACClearingDebtNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACClearingDebtNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACClearingDebtNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACClearingDebtNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACClearingDebtNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACClearingDebtNo.Screen = null;
            this.fld_txtACClearingDebtNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACClearingDebtNo.TabIndex = 0;
            this.fld_txtACClearingDebtNo.Tag = "DC";
            // 
            // fld_dteACClearingDebtDate
            // 
            this.fld_dteACClearingDebtDate.BOSComment = "";
            this.fld_dteACClearingDebtDate.BOSDataMember = "ACClearingDebtDate";
            this.fld_dteACClearingDebtDate.BOSDataSource = "ACClearingDebts";
            this.fld_dteACClearingDebtDate.BOSDescription = null;
            this.fld_dteACClearingDebtDate.BOSError = null;
            this.fld_dteACClearingDebtDate.BOSFieldGroup = "";
            this.fld_dteACClearingDebtDate.BOSFieldRelation = "";
            this.fld_dteACClearingDebtDate.BOSPrivilege = "";
            this.fld_dteACClearingDebtDate.BOSPropertyName = "EditValue";
            this.fld_dteACClearingDebtDate.EditValue = null;
            this.fld_dteACClearingDebtDate.Location = new System.Drawing.Point(494, 12);
            this.fld_dteACClearingDebtDate.Name = "fld_dteACClearingDebtDate";
            this.fld_dteACClearingDebtDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACClearingDebtDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACClearingDebtDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACClearingDebtDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACClearingDebtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACClearingDebtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACClearingDebtDate.Screen = null;
            this.fld_dteACClearingDebtDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACClearingDebtDate.TabIndex = 1;
            this.fld_dteACClearingDebtDate.Tag = "DC";
            // 
            // fld_medACClearingDebtDesc
            // 
            this.fld_medACClearingDebtDesc.BOSComment = "";
            this.fld_medACClearingDebtDesc.BOSDataMember = "ACClearingDebtDesc";
            this.fld_medACClearingDebtDesc.BOSDataSource = "ACClearingDebts";
            this.fld_medACClearingDebtDesc.BOSDescription = null;
            this.fld_medACClearingDebtDesc.BOSError = null;
            this.fld_medACClearingDebtDesc.BOSFieldGroup = "";
            this.fld_medACClearingDebtDesc.BOSFieldRelation = "";
            this.fld_medACClearingDebtDesc.BOSPrivilege = "";
            this.fld_medACClearingDebtDesc.BOSPropertyName = "Text";
            this.fld_medACClearingDebtDesc.EditValue = "";
            this.fld_medACClearingDebtDesc.Location = new System.Drawing.Point(494, 64);
            this.fld_medACClearingDebtDesc.Name = "fld_medACClearingDebtDesc";
            this.fld_medACClearingDebtDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACClearingDebtDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACClearingDebtDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACClearingDebtDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACClearingDebtDesc.Screen = null;
            this.fld_medACClearingDebtDesc.Size = new System.Drawing.Size(445, 35);
            this.fld_medACClearingDebtDesc.TabIndex = 7;
            this.fld_medACClearingDebtDesc.Tag = "DC";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(405, 15);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 3;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(405, 67);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 7;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Diễn giải";
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
            this.bosPanel1.Controls.Add(this.fld_txtACClearingDebtAmountClearing);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeObject2);
            this.bosPanel1.Controls.Add(this.fld_tabCustomerPayments);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_pteACClearingDebtEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtACClearingDebtExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtACClearingDebtNo);
            this.bosPanel1.Controls.Add(this.fld_dteACClearingDebtDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_medACClearingDebtDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(978, 518);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeObject2
            // 
            this.fld_lkeObject2.BOSAllowAddNew = false;
            this.fld_lkeObject2.BOSAllowDummy = true;
            this.fld_lkeObject2.BOSComment = null;
            this.fld_lkeObject2.BOSDataMember = "ACObjectAccessKey2";
            this.fld_lkeObject2.BOSDataSource = "ACClearingDebts";
            this.fld_lkeObject2.BOSDescription = null;
            this.fld_lkeObject2.BOSError = null;
            this.fld_lkeObject2.BOSFieldGroup = null;
            this.fld_lkeObject2.BOSFieldParent = null;
            this.fld_lkeObject2.BOSFieldRelation = null;
            this.fld_lkeObject2.BOSPrivilege = null;
            this.fld_lkeObject2.BOSPropertyName = "EditValue";
            this.fld_lkeObject2.BOSSelectType = "";
            this.fld_lkeObject2.BOSSelectTypeValue = "";
            this.fld_lkeObject2.CurrentDisplayText = null;
            this.fld_lkeObject2.Location = new System.Drawing.Point(494, 38);
            this.fld_lkeObject2.Name = "fld_lkeObject2";
            this.fld_lkeObject2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeObject2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeObject2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeObject2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeObject2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeObject2.Properties.ColumnName = null;
            this.fld_lkeObject2.Properties.NullText = "";
            this.fld_lkeObject2.Properties.ReadOnly = false;
            this.fld_lkeObject2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeObject2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeObject2, true);
            this.fld_lkeObject2.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeObject2.TabIndex = 3;
            this.fld_lkeObject2.Tag = "DC";
            this.fld_lkeObject2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID2_CloseUp);
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
            this.fld_tabCustomerPayments.Size = new System.Drawing.Size(963, 375);
            this.fld_tabCustomerPayments.TabIndex = 8;
            this.fld_tabCustomerPayments.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageCustomerPayment,
            this.fld_tabPagePosting});
            // 
            // fld_tabPageCustomerPayment
            // 
            this.fld_tabPageCustomerPayment.Controls.Add(this.splitContainerControl1);
            this.fld_tabPageCustomerPayment.Name = "fld_tabPageCustomerPayment";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageCustomerPayment, true);
            this.fld_tabPageCustomerPayment.Size = new System.Drawing.Size(957, 347);
            this.fld_tabPageCustomerPayment.Text = "Hóa đơn thanh toán";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcACClearingDebtInvoiceInItems);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_btnInvoiceIn);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(957, 347);
            this.splitContainerControl1.SplitterPosition = 441;
            this.splitContainerControl1.TabIndex = 15;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_dgcACClearingDebtInvoiceInItems
            // 
            this.fld_dgcACClearingDebtInvoiceInItems.AllowDrop = true;
            this.fld_dgcACClearingDebtInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACClearingDebtInvoiceInItems.BOSComment = "";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSDataMember = "";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSDataSource = "ACClearingDebtInvoiceInItems";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSDescription = null;
            this.fld_dgcACClearingDebtInvoiceInItems.BOSError = null;
            this.fld_dgcACClearingDebtInvoiceInItems.BOSFieldGroup = "";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSFieldRelation = "";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSGridType = null;
            this.fld_dgcACClearingDebtInvoiceInItems.BOSPrivilege = "";
            this.fld_dgcACClearingDebtInvoiceInItems.BOSPropertyName = "";
            this.fld_dgcACClearingDebtInvoiceInItems.CommodityType = "";
            this.fld_dgcACClearingDebtInvoiceInItems.Location = new System.Drawing.Point(3, 38);
            this.fld_dgcACClearingDebtInvoiceInItems.MainView = this.gridView1;
            this.fld_dgcACClearingDebtInvoiceInItems.Name = "fld_dgcACClearingDebtInvoiceInItems";
            this.fld_dgcACClearingDebtInvoiceInItems.PrintReport = false;
            this.fld_dgcACClearingDebtInvoiceInItems.Screen = null;
            this.fld_dgcACClearingDebtInvoiceInItems.Size = new System.Drawing.Size(438, 309);
            this.fld_dgcACClearingDebtInvoiceInItems.TabIndex = 1;
            this.fld_dgcACClearingDebtInvoiceInItems.Tag = "DC";
            this.fld_dgcACClearingDebtInvoiceInItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACClearingDebtInvoiceInItems;
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
            this.fld_btnInvoiceIn.Location = new System.Drawing.Point(3, 3);
            this.fld_btnInvoiceIn.Name = "fld_btnInvoiceIn";
            this.fld_btnInvoiceIn.Screen = null;
            this.fld_btnInvoiceIn.Size = new System.Drawing.Size(122, 27);
            this.fld_btnInvoiceIn.TabIndex = 0;
            this.fld_btnInvoiceIn.Text = "Hóa đơn mua hàng";
            this.fld_btnInvoiceIn.Click += new System.EventHandler(this.fld_btnInvoiceIn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_dgcACClearingDebtInvoiceItems);
            this.panelControl2.Controls.Add(this.fld_btnInvoice);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(511, 347);
            this.panelControl2.TabIndex = 0;
            // 
            // fld_dgcACClearingDebtInvoiceItems
            // 
            this.fld_dgcACClearingDebtInvoiceItems.AllowDrop = true;
            this.fld_dgcACClearingDebtInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACClearingDebtInvoiceItems.BOSComment = "";
            this.fld_dgcACClearingDebtInvoiceItems.BOSDataMember = "";
            this.fld_dgcACClearingDebtInvoiceItems.BOSDataSource = "ACClearingDebtInvoiceItems";
            this.fld_dgcACClearingDebtInvoiceItems.BOSDescription = null;
            this.fld_dgcACClearingDebtInvoiceItems.BOSError = null;
            this.fld_dgcACClearingDebtInvoiceItems.BOSFieldGroup = "";
            this.fld_dgcACClearingDebtInvoiceItems.BOSFieldRelation = "";
            this.fld_dgcACClearingDebtInvoiceItems.BOSGridType = null;
            this.fld_dgcACClearingDebtInvoiceItems.BOSPrivilege = "";
            this.fld_dgcACClearingDebtInvoiceItems.BOSPropertyName = "";
            this.fld_dgcACClearingDebtInvoiceItems.CommodityType = "";
            this.fld_dgcACClearingDebtInvoiceItems.Location = new System.Drawing.Point(5, 38);
            this.fld_dgcACClearingDebtInvoiceItems.MainView = this.fld_dgvARCustomerPaymentTimePayments;
            this.fld_dgcACClearingDebtInvoiceItems.Name = "fld_dgcACClearingDebtInvoiceItems";
            this.fld_dgcACClearingDebtInvoiceItems.PrintReport = false;
            this.fld_dgcACClearingDebtInvoiceItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcACClearingDebtInvoiceItems, false);
            this.fld_dgcACClearingDebtInvoiceItems.Size = new System.Drawing.Size(506, 309);
            this.fld_dgcACClearingDebtInvoiceItems.TabIndex = 1;
            this.fld_dgcACClearingDebtInvoiceItems.Tag = "DC";
            this.fld_dgcACClearingDebtInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerPaymentTimePayments});
            // 
            // fld_dgvARCustomerPaymentTimePayments
            // 
            this.fld_dgvARCustomerPaymentTimePayments.GridControl = this.fld_dgcACClearingDebtInvoiceItems;
            this.fld_dgvARCustomerPaymentTimePayments.Name = "fld_dgvARCustomerPaymentTimePayments";
            this.fld_dgvARCustomerPaymentTimePayments.PaintStyleName = "Office2003";
            // 
            // fld_btnInvoice
            // 
            this.fld_btnInvoice.BOSComment = null;
            this.fld_btnInvoice.BOSDataMember = null;
            this.fld_btnInvoice.BOSDataSource = null;
            this.fld_btnInvoice.BOSDescription = null;
            this.fld_btnInvoice.BOSError = null;
            this.fld_btnInvoice.BOSFieldGroup = null;
            this.fld_btnInvoice.BOSFieldRelation = null;
            this.fld_btnInvoice.BOSPrivilege = null;
            this.fld_btnInvoice.BOSPropertyName = null;
            this.fld_btnInvoice.Location = new System.Drawing.Point(5, 5);
            this.fld_btnInvoice.Name = "fld_btnInvoice";
            this.fld_btnInvoice.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnInvoice, true);
            this.fld_btnInvoice.Size = new System.Drawing.Size(122, 27);
            this.fld_btnInvoice.TabIndex = 0;
            this.fld_btnInvoice.Text = "Hóa đơn bán hàng";
            this.fld_btnInvoice.Click += new System.EventHandler(this.fld_btnInvoice_Click);
            // 
            // fld_tabPagePosting
            // 
            this.fld_tabPagePosting.Controls.Add(this.fld_dgcDocumentEntrys);
            this.fld_tabPagePosting.Name = "fld_tabPagePosting";
            this.ScreenHelper.SetShowHelp(this.fld_tabPagePosting, true);
            this.fld_tabPagePosting.Size = new System.Drawing.Size(951, 340);
            this.fld_tabPagePosting.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntrys
            // 
            this.fld_dgcDocumentEntrys.AllowDrop = true;
            this.fld_dgcDocumentEntrys.BOSComment = "";
            this.fld_dgcDocumentEntrys.BOSDataMember = "";
            this.fld_dgcDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntrys.BOSDescription = null;
            this.fld_dgcDocumentEntrys.BOSError = null;
            this.fld_dgcDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcDocumentEntrys.BOSGridType = null;
            this.fld_dgcDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcDocumentEntrys.CommodityType = "";
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcDocumentEntrys, true);
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(951, 340);
            this.fld_dgcDocumentEntrys.TabIndex = 1;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            this.fld_dgcDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactionItems});
            // 
            // fld_dgvACBankTransactionItems
            // 
            this.fld_dgvACBankTransactionItems.GridControl = this.fld_dgcDocumentEntrys;
            this.fld_dgvACBankTransactionItems.Name = "fld_dgvACBankTransactionItems";
            this.fld_dgvACBankTransactionItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACClearingDebts";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(778, 12);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACClearingDebts";
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
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
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACClearingDebts";
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
            // fld_txtACClearingDebtExchangeRate
            // 
            this.fld_txtACClearingDebtExchangeRate.BOSComment = "";
            this.fld_txtACClearingDebtExchangeRate.BOSDataMember = "ACClearingDebtExchangeRate";
            this.fld_txtACClearingDebtExchangeRate.BOSDataSource = "ACClearingDebts";
            this.fld_txtACClearingDebtExchangeRate.BOSDescription = null;
            this.fld_txtACClearingDebtExchangeRate.BOSError = null;
            this.fld_txtACClearingDebtExchangeRate.BOSFieldGroup = "";
            this.fld_txtACClearingDebtExchangeRate.BOSFieldRelation = "";
            this.fld_txtACClearingDebtExchangeRate.BOSPrivilege = "";
            this.fld_txtACClearingDebtExchangeRate.BOSPropertyName = "Text";
            this.fld_txtACClearingDebtExchangeRate.EditValue = "";
            this.fld_txtACClearingDebtExchangeRate.Location = new System.Drawing.Point(778, 38);
            this.fld_txtACClearingDebtExchangeRate.Name = "fld_txtACClearingDebtExchangeRate";
            this.fld_txtACClearingDebtExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACClearingDebtExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACClearingDebtExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACClearingDebtExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACClearingDebtExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACClearingDebtExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACClearingDebtExchangeRate.Screen = null;
            this.fld_txtACClearingDebtExchangeRate.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACClearingDebtExchangeRate.TabIndex = 5;
            this.fld_txtACClearingDebtExchangeRate.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(687, 41);
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
            this.bosLabel2.Location = new System.Drawing.Point(687, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
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
            this.bosLabel4.Location = new System.Drawing.Point(405, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(57, 13);
            this.bosLabel4.TabIndex = 9;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Đối tượng 2";
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
            this.bosLabel1.Size = new System.Drawing.Size(57, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Đối tượng 1";
            // 
            // fld_txtACClearingDebtAmountClearing
            // 
            this.fld_txtACClearingDebtAmountClearing.BOSComment = "";
            this.fld_txtACClearingDebtAmountClearing.BOSDataMember = "ACClearingDebtAmountClearing";
            this.fld_txtACClearingDebtAmountClearing.BOSDataSource = "ACClearingDebts";
            this.fld_txtACClearingDebtAmountClearing.BOSDescription = null;
            this.fld_txtACClearingDebtAmountClearing.BOSError = null;
            this.fld_txtACClearingDebtAmountClearing.BOSFieldGroup = "";
            this.fld_txtACClearingDebtAmountClearing.BOSFieldRelation = "";
            this.fld_txtACClearingDebtAmountClearing.BOSPrivilege = "";
            this.fld_txtACClearingDebtAmountClearing.BOSPropertyName = "Text";
            this.fld_txtACClearingDebtAmountClearing.EditValue = "";
            this.fld_txtACClearingDebtAmountClearing.Location = new System.Drawing.Point(219, 64);
            this.fld_txtACClearingDebtAmountClearing.Name = "fld_txtACClearingDebtAmountClearing";
            this.fld_txtACClearingDebtAmountClearing.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACClearingDebtAmountClearing.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACClearingDebtAmountClearing.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACClearingDebtAmountClearing.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACClearingDebtAmountClearing.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACClearingDebtAmountClearing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACClearingDebtAmountClearing.Screen = null;
            this.fld_txtACClearingDebtAmountClearing.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACClearingDebtAmountClearing.TabIndex = 6;
            this.fld_txtACClearingDebtAmountClearing.Tag = "DC";
            this.fld_txtACClearingDebtAmountClearing.Validated += new System.EventHandler(this.fld_txtACClearingDebtAmountClearing_Validated);
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
            this.bosLabel5.Location = new System.Drawing.Point(128, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(71, 13);
            this.bosLabel5.TabIndex = 20;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Số tiền cấn trừ";
            // 
            // DMCD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(978, 518);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCD100";
            this.Text = "s";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACClearingDebtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACClearingDebtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACClearingDebtDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeObject2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).EndInit();
            this.fld_tabCustomerPayments.ResumeLayout(false);
            this.fld_tabPageCustomerPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACClearingDebtInvoiceInItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACClearingDebtInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).EndInit();
            this.fld_tabPagePosting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACClearingDebtEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACClearingDebtAmountClearing.Properties)).EndInit();
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
        private BOSComponent.BOSTextBox fld_txtACClearingDebtExchangeRate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTabControl fld_tabCustomerPayments;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageCustomerPayment;
        private BOSComponent.BOSButton fld_btnInvoice;
        private ACClearingDebtInvoiceItemsGridControl fld_dgcACClearingDebtInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerPaymentTimePayments;
        private ACClearingDebtInvoiceInItemsGridControl fld_dgcACClearingDebtInvoiceInItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnInvoiceIn;
        private DevExpress.XtraTab.XtraTabPage fld_tabPagePosting;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeObject2;
        private BOSComponent.BOSTextBox fld_txtACClearingDebtAmountClearing;
        private BOSComponent.BOSLabel bosLabel5;
    }
}
