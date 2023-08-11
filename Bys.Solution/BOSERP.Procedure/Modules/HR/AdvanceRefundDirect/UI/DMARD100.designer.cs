using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRefundDirect.UI
{
	/// <summary>
	/// Summary description for DMARD100
	/// </summary>
	partial class DMARD100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMARD100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeEmployeeNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRAdvanceRefundItemInvoices = new BOSERP.Modules.AdvanceRefundDirect.HRAdvanceRefundItemInvoicesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.fld_dteHRAdvanceRefundDueDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeEmployeeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRefundDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDueDate.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_dteHRAdvanceRefundDueDate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeEmployeeNo);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
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
            this.bosPanel1.Size = new System.Drawing.Size(1101, 595);
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
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(101, 90);
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
            this.fld_lkeFK_PMProjectID.TabIndex = 9;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(17, 93);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 639;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Mã dự án";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(17, 67);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 628;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "HRAdvanceRefunds";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(101, 64);
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
            this.fld_lkeFK_ACObjectID.TabIndex = 7;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
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
            this.fld_lkeEmployeeNo.TabIndex = 4;
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 126);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1095, 469);
            this.bosTabControl1.TabIndex = 10;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRAdvanceRefundItemInvoices);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1093, 444);
            this.xtraTabPage1.Text = "Danh sách hóa đơn";
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
            this.fld_dgcHRAdvanceRefundItemInvoices.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHRAdvanceRefundItemInvoices.MainView = this.gridView2;
            this.fld_dgcHRAdvanceRefundItemInvoices.Name = "fld_dgcHRAdvanceRefundItemInvoices";
            this.fld_dgcHRAdvanceRefundItemInvoices.PrintReport = false;
            this.fld_dgcHRAdvanceRefundItemInvoices.Screen = null;
            this.fld_dgcHRAdvanceRefundItemInvoices.Size = new System.Drawing.Size(1086, 438);
            this.fld_dgcHRAdvanceRefundItemInvoices.TabIndex = 0;
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
            this.bosLabel3.Location = new System.Drawing.Point(281, 67);
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
            this.fld_medHRAdvanceRefundDesc.Location = new System.Drawing.Point(370, 64);
            this.fld_medHRAdvanceRefundDesc.Name = "fld_medHRAdvanceRefundDesc";
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRAdvanceRefundDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRAdvanceRefundDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRAdvanceRefundDesc, true);
            this.fld_medHRAdvanceRefundDesc.Size = new System.Drawing.Size(437, 42);
            this.fld_medHRAdvanceRefundDesc.TabIndex = 8;
            this.fld_medHRAdvanceRefundDesc.Tag = "DC";
            this.fld_medHRAdvanceRefundDesc.Validated += new System.EventHandler(this.fld_medHRAdvanceRefundDesc_Validated);
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
            this.fld_txtHRAdvanceRefundExchangeRate.TabIndex = 6;
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
            this.fld_lkeFK_GECurrencyID.TabIndex = 5;
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
            // fld_dteHRAdvanceRefundDueDate
            // 
            this.fld_dteHRAdvanceRefundDueDate.BOSComment = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSDataMember = "HRAdvanceRefundDueDate";
            this.fld_dteHRAdvanceRefundDueDate.BOSDataSource = "HRAdvanceRefunds";
            this.fld_dteHRAdvanceRefundDueDate.BOSDescription = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSError = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSFieldGroup = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSFieldRelation = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSPrivilege = null;
            this.fld_dteHRAdvanceRefundDueDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAdvanceRefundDueDate.EditValue = null;
            this.fld_dteHRAdvanceRefundDueDate.Location = new System.Drawing.Point(939, 12);
            this.fld_dteHRAdvanceRefundDueDate.Name = "fld_dteHRAdvanceRefundDueDate";
            this.fld_dteHRAdvanceRefundDueDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdvanceRefundDueDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdvanceRefundDueDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdvanceRefundDueDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdvanceRefundDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdvanceRefundDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdvanceRefundDueDate.Screen = null;
            this.fld_dteHRAdvanceRefundDueDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRAdvanceRefundDueDate.TabIndex = 3;
            this.fld_dteHRAdvanceRefundDueDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(850, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(75, 13);
            this.bosLabel4.TabIndex = 641;
            this.bosLabel4.Text = "Hạn thanh toán";
            // 
            // DMARD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1101, 595);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMARD100.IconOptions.Icon")));
            this.Name = "DMARD100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeEmployeeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefundItemInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRefundStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRefundDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRefundNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRefundDueDate.Properties)).EndInit();
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
        private BOSComponent.BOSTabControl bosTabControl1;
        private BOSComponent.BOSLookupEdit fld_lkeEmployeeNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private HRAdvanceRefundItemInvoicesGridControl fld_dgcHRAdvanceRefundItemInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteHRAdvanceRefundDueDate;
        private BOSComponent.BOSLabel bosLabel4;
    }
}
