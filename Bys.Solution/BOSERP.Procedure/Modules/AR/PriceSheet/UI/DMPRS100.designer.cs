using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PriceSheet.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMPRS100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARPriceSheetEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARPriceSheetDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARPriceSheetNo;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARPriceSheetItemsGridControl fld_dgcARPriceSheetItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARPriceSheetStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteARPriceSheetStartDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medARPriceSheetDesc;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPRS100));
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARPriceSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARPriceSheetDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARPriceSheetNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerType123 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARPriceSheetApprovedStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARPriceSheetName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateEndDate = new BOSComponent.BOSButton(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARPriceSheetEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARPriceSheetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARPriceSheetStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARPriceSheetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pteARPriceSheetItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARPriceSheetItemsGridControl = new BOSERP.Modules.PriceSheet.ARPriceSheetItemsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_recARPriceSheetComment = new BOSComponent.BOSRichEditControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARPriceSheetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPriceSheetApprovedStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetName.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARPriceSheetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPriceSheetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARPriceSheetItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheetItemsGridControl)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.bosLine1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARPriceSheets";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 128);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteARPriceSheetEmployeePicture
            // 
            this.fld_pteARPriceSheetEmployeePicture.BOSComment = "";
            this.fld_pteARPriceSheetEmployeePicture.BOSDataMember = "ARPriceSheetEmployeePicture";
            this.fld_pteARPriceSheetEmployeePicture.BOSDataSource = "ARPriceSheets";
            this.fld_pteARPriceSheetEmployeePicture.BOSDescription = null;
            this.fld_pteARPriceSheetEmployeePicture.BOSError = "";
            this.fld_pteARPriceSheetEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARPriceSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARPriceSheetEmployeePicture.BOSPrivilege = "";
            this.fld_pteARPriceSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARPriceSheetEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARPriceSheetEmployeePicture.FileName = null;
            this.fld_pteARPriceSheetEmployeePicture.FilePath = null;
            this.fld_pteARPriceSheetEmployeePicture.Location = new System.Drawing.Point(5, 25);
            this.fld_pteARPriceSheetEmployeePicture.Name = "fld_pteARPriceSheetEmployeePicture";
            this.fld_pteARPriceSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARPriceSheetEmployeePicture.Screen = null;
            this.fld_pteARPriceSheetEmployeePicture.Size = new System.Drawing.Size(106, 97);
            this.fld_pteARPriceSheetEmployeePicture.TabIndex = 0;
            this.fld_pteARPriceSheetEmployeePicture.Tag = "DC";
            // 
            // fld_dteARPriceSheetDate
            // 
            this.fld_dteARPriceSheetDate.BOSComment = null;
            this.fld_dteARPriceSheetDate.BOSDataMember = "ARPriceSheetDate";
            this.fld_dteARPriceSheetDate.BOSDataSource = "ARPriceSheets";
            this.fld_dteARPriceSheetDate.BOSDescription = null;
            this.fld_dteARPriceSheetDate.BOSError = null;
            this.fld_dteARPriceSheetDate.BOSFieldGroup = null;
            this.fld_dteARPriceSheetDate.BOSFieldRelation = null;
            this.fld_dteARPriceSheetDate.BOSPrivilege = null;
            this.fld_dteARPriceSheetDate.BOSPropertyName = "EditValue";
            this.fld_dteARPriceSheetDate.EditValue = null;
            this.fld_dteARPriceSheetDate.Location = new System.Drawing.Point(505, 25);
            this.fld_dteARPriceSheetDate.MenuManager = this.screenToolbar;
            this.fld_dteARPriceSheetDate.Name = "fld_dteARPriceSheetDate";
            this.fld_dteARPriceSheetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARPriceSheetDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARPriceSheetDate.Screen = null;
            this.fld_dteARPriceSheetDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARPriceSheetDate.TabIndex = 3;
            this.fld_dteARPriceSheetDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(420, 28);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(133, 28);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARPriceSheetNo
            // 
            this.fld_txtARPriceSheetNo.BOSComment = null;
            this.fld_txtARPriceSheetNo.BOSDataMember = "ARPriceSheetNo";
            this.fld_txtARPriceSheetNo.BOSDataSource = "ARPriceSheets";
            this.fld_txtARPriceSheetNo.BOSDescription = null;
            this.fld_txtARPriceSheetNo.BOSError = null;
            this.fld_txtARPriceSheetNo.BOSFieldGroup = null;
            this.fld_txtARPriceSheetNo.BOSFieldRelation = null;
            this.fld_txtARPriceSheetNo.BOSPrivilege = null;
            this.fld_txtARPriceSheetNo.BOSPropertyName = "EditValue";
            this.fld_txtARPriceSheetNo.Location = new System.Drawing.Point(216, 25);
            this.fld_txtARPriceSheetNo.MenuManager = this.screenToolbar;
            this.fld_txtARPriceSheetNo.Name = "fld_txtARPriceSheetNo";
            this.fld_txtARPriceSheetNo.Screen = null;
            this.fld_txtARPriceSheetNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARPriceSheetNo.TabIndex = 2;
            this.fld_txtARPriceSheetNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1293, 757);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARCustomerType123);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARPriceSheetApprovedStatus);
            this.bosGroupControl1.Controls.Add(this.fld_txtARPriceSheetName);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.groupBox1);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_dteARPriceSheetEndDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_medARPriceSheetDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_txtARPriceSheetNo);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.fld_pteARPriceSheetEmployeePicture);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_dteARPriceSheetDate);
            this.bosGroupControl1.Controls.Add(this.fld_dteARPriceSheetStartDate);
            this.bosGroupControl1.Controls.Add(this.BOSLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARPriceSheetStatus);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1286, 173);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARPriceSheets";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(505, 77);
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
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 9;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(420, 80);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 840;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(133, 80);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(56, 13);
            this.bosLabel10.TabIndex = 838;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARPriceSheets";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(216, 77);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 8;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            this.fld_lkeFK_ARCustomerID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID_CloseUp);
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
            this.bosLabel18.Location = new System.Drawing.Point(390, 51);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(6, 13);
            this.bosLabel18.TabIndex = 836;
            this.bosLabel18.Text = "*";
            // 
            // fld_lkeARCustomerType123
            // 
            this.fld_lkeARCustomerType123.BOSAllowAddNew = false;
            this.fld_lkeARCustomerType123.BOSAllowDummy = false;
            this.fld_lkeARCustomerType123.BOSComment = "";
            this.fld_lkeARCustomerType123.BOSDataMember = "ARCustomerType";
            this.fld_lkeARCustomerType123.BOSDataSource = "ARPriceSheets";
            this.fld_lkeARCustomerType123.BOSDescription = null;
            this.fld_lkeARCustomerType123.BOSError = "";
            this.fld_lkeARCustomerType123.BOSFieldGroup = "";
            this.fld_lkeARCustomerType123.BOSFieldParent = "";
            this.fld_lkeARCustomerType123.BOSFieldRelation = "";
            this.fld_lkeARCustomerType123.BOSPrivilege = "";
            this.fld_lkeARCustomerType123.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerType123.BOSSelectType = "";
            this.fld_lkeARCustomerType123.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerType123.CurrentDisplayText = "";
            this.fld_lkeARCustomerType123.Location = new System.Drawing.Point(216, 51);
            this.fld_lkeARCustomerType123.Name = "fld_lkeARCustomerType123";
            this.fld_lkeARCustomerType123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerType123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerType123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerType123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerType123.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerType123.Properties.ColumnName = null;
            this.fld_lkeARCustomerType123.Properties.NullText = "";
            this.fld_lkeARCustomerType123.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerType123.Screen = null;
            this.fld_lkeARCustomerType123.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARCustomerType123.TabIndex = 5;
            this.fld_lkeARCustomerType123.Tag = "DC";
            // 
            // fld_lkeARPriceSheetApprovedStatus
            // 
            this.fld_lkeARPriceSheetApprovedStatus.BOSAllowAddNew = false;
            this.fld_lkeARPriceSheetApprovedStatus.BOSAllowDummy = false;
            this.fld_lkeARPriceSheetApprovedStatus.BOSComment = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSDataMember = "ARPriceSheetApprovedStatus";
            this.fld_lkeARPriceSheetApprovedStatus.BOSDataSource = "ARPriceSheets";
            this.fld_lkeARPriceSheetApprovedStatus.BOSDescription = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSError = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSFieldGroup = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSFieldParent = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSFieldRelation = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSPrivilege = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARPriceSheetApprovedStatus.BOSSelectType = null;
            this.fld_lkeARPriceSheetApprovedStatus.BOSSelectTypeValue = null;
            this.fld_lkeARPriceSheetApprovedStatus.CurrentDisplayText = null;
            this.fld_lkeARPriceSheetApprovedStatus.Location = new System.Drawing.Point(781, 77);
            this.fld_lkeARPriceSheetApprovedStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARPriceSheetApprovedStatus.Name = "fld_lkeARPriceSheetApprovedStatus";
            this.fld_lkeARPriceSheetApprovedStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPriceSheetApprovedStatus.Properties.ColumnName = null;
            this.fld_lkeARPriceSheetApprovedStatus.Properties.ReadOnly = true;
            this.fld_lkeARPriceSheetApprovedStatus.Screen = null;
            this.fld_lkeARPriceSheetApprovedStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARPriceSheetApprovedStatus.TabIndex = 10;
            this.fld_lkeARPriceSheetApprovedStatus.Tag = "DC";
            // 
            // fld_txtARPriceSheetName
            // 
            this.fld_txtARPriceSheetName.BOSComment = null;
            this.fld_txtARPriceSheetName.BOSDataMember = "ARPriceSheetName";
            this.fld_txtARPriceSheetName.BOSDataSource = "ARPriceSheets";
            this.fld_txtARPriceSheetName.BOSDescription = null;
            this.fld_txtARPriceSheetName.BOSError = null;
            this.fld_txtARPriceSheetName.BOSFieldGroup = null;
            this.fld_txtARPriceSheetName.BOSFieldRelation = null;
            this.fld_txtARPriceSheetName.BOSPrivilege = null;
            this.fld_txtARPriceSheetName.BOSPropertyName = "EditValue";
            this.fld_txtARPriceSheetName.Location = new System.Drawing.Point(216, 103);
            this.fld_txtARPriceSheetName.MenuManager = this.screenToolbar;
            this.fld_txtARPriceSheetName.Name = "fld_txtARPriceSheetName";
            this.fld_txtARPriceSheetName.Screen = null;
            this.fld_txtARPriceSheetName.Size = new System.Drawing.Size(460, 20);
            this.fld_txtARPriceSheetName.TabIndex = 11;
            this.fld_txtARPriceSheetName.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(133, 106);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(65, 13);
            this.bosLabel9.TabIndex = 435;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Tên chứng từ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_btnAddProduct);
            this.groupBox1.Controls.Add(this.fld_btnUpdateEndDate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(711, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 59);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = "";
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = "";
            this.fld_btnAddProduct.BOSFieldRelation = "";
            this.fld_btnAddProduct.BOSPrivilege = "";
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(6, 17);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(110, 35);
            this.fld_btnAddProduct.TabIndex = 0;
            this.fld_btnAddProduct.Tag = "";
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // fld_btnUpdateEndDate
            // 
            this.fld_btnUpdateEndDate.BOSComment = null;
            this.fld_btnUpdateEndDate.BOSDataMember = null;
            this.fld_btnUpdateEndDate.BOSDataSource = null;
            this.fld_btnUpdateEndDate.BOSDescription = null;
            this.fld_btnUpdateEndDate.BOSError = null;
            this.fld_btnUpdateEndDate.BOSFieldGroup = null;
            this.fld_btnUpdateEndDate.BOSFieldRelation = null;
            this.fld_btnUpdateEndDate.BOSPrivilege = null;
            this.fld_btnUpdateEndDate.BOSPropertyName = null;
            this.fld_btnUpdateEndDate.Location = new System.Drawing.Point(125, 17);
            this.fld_btnUpdateEndDate.Name = "fld_btnUpdateEndDate";
            this.fld_btnUpdateEndDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateEndDate, true);
            this.fld_btnUpdateEndDate.Size = new System.Drawing.Size(110, 35);
            this.fld_btnUpdateEndDate.TabIndex = 1;
            this.fld_btnUpdateEndDate.Text = "Cập nhật\r\nngày hết hiệu lực";
            this.fld_btnUpdateEndDate.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(711, 80);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(52, 13);
            this.bosLabel8.TabIndex = 432;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "TT hiệu lực";
            // 
            // fld_dteARPriceSheetEndDate
            // 
            this.fld_dteARPriceSheetEndDate.BOSComment = null;
            this.fld_dteARPriceSheetEndDate.BOSDataMember = "ARPriceSheetEndDate";
            this.fld_dteARPriceSheetEndDate.BOSDataSource = "ARPriceSheets";
            this.fld_dteARPriceSheetEndDate.BOSDescription = null;
            this.fld_dteARPriceSheetEndDate.BOSError = null;
            this.fld_dteARPriceSheetEndDate.BOSFieldGroup = null;
            this.fld_dteARPriceSheetEndDate.BOSFieldRelation = null;
            this.fld_dteARPriceSheetEndDate.BOSPrivilege = null;
            this.fld_dteARPriceSheetEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARPriceSheetEndDate.EditValue = null;
            this.fld_dteARPriceSheetEndDate.Location = new System.Drawing.Point(781, 51);
            this.fld_dteARPriceSheetEndDate.MenuManager = this.screenToolbar;
            this.fld_dteARPriceSheetEndDate.Name = "fld_dteARPriceSheetEndDate";
            this.fld_dteARPriceSheetEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARPriceSheetEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARPriceSheetEndDate.Screen = null;
            this.fld_dteARPriceSheetEndDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARPriceSheetEndDate.TabIndex = 7;
            this.fld_dteARPriceSheetEndDate.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel7.Location = new System.Drawing.Point(711, 54);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(47, 13);
            this.bosLabel7.TabIndex = 430;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Đến ngày";
            // 
            // fld_medARPriceSheetDesc
            // 
            this.fld_medARPriceSheetDesc.BOSComment = "";
            this.fld_medARPriceSheetDesc.BOSDataMember = "ARPriceSheetDesc";
            this.fld_medARPriceSheetDesc.BOSDataSource = "ARPriceSheets";
            this.fld_medARPriceSheetDesc.BOSDescription = null;
            this.fld_medARPriceSheetDesc.BOSError = null;
            this.fld_medARPriceSheetDesc.BOSFieldGroup = "";
            this.fld_medARPriceSheetDesc.BOSFieldRelation = "";
            this.fld_medARPriceSheetDesc.BOSPrivilege = "";
            this.fld_medARPriceSheetDesc.BOSPropertyName = "EditValue";
            this.fld_medARPriceSheetDesc.EditValue = "";
            this.fld_medARPriceSheetDesc.Location = new System.Drawing.Point(216, 129);
            this.fld_medARPriceSheetDesc.Name = "fld_medARPriceSheetDesc";
            this.fld_medARPriceSheetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARPriceSheetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARPriceSheetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARPriceSheetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARPriceSheetDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARPriceSheetDesc, true);
            this.fld_medARPriceSheetDesc.Size = new System.Drawing.Size(460, 33);
            this.fld_medARPriceSheetDesc.TabIndex = 12;
            this.fld_medARPriceSheetDesc.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(133, 131);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(27, 13);
            this.bosLabel6.TabIndex = 428;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mô tả";
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
            this.bosLabel3.Location = new System.Drawing.Point(711, 28);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteARPriceSheetStartDate
            // 
            this.fld_dteARPriceSheetStartDate.BOSComment = null;
            this.fld_dteARPriceSheetStartDate.BOSDataMember = "ARPriceSheetStartDate";
            this.fld_dteARPriceSheetStartDate.BOSDataSource = "ARPriceSheets";
            this.fld_dteARPriceSheetStartDate.BOSDescription = null;
            this.fld_dteARPriceSheetStartDate.BOSError = null;
            this.fld_dteARPriceSheetStartDate.BOSFieldGroup = null;
            this.fld_dteARPriceSheetStartDate.BOSFieldRelation = null;
            this.fld_dteARPriceSheetStartDate.BOSPrivilege = null;
            this.fld_dteARPriceSheetStartDate.BOSPropertyName = "EditValue";
            this.fld_dteARPriceSheetStartDate.EditValue = null;
            this.fld_dteARPriceSheetStartDate.Location = new System.Drawing.Point(505, 51);
            this.fld_dteARPriceSheetStartDate.MenuManager = this.screenToolbar;
            this.fld_dteARPriceSheetStartDate.Name = "fld_dteARPriceSheetStartDate";
            this.fld_dteARPriceSheetStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARPriceSheetStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARPriceSheetStartDate.Screen = null;
            this.fld_dteARPriceSheetStartDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARPriceSheetStartDate.TabIndex = 6;
            this.fld_dteARPriceSheetStartDate.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(420, 54);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(79, 13);
            this.bosLabel5.TabIndex = 423;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Hiệu lực từ ngày";
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
            this.bosLabel4.Location = new System.Drawing.Point(133, 54);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(77, 13);
            this.bosLabel4.TabIndex = 421;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại khách hàng";
            // 
            // fld_lkeARPriceSheetStatus
            // 
            this.fld_lkeARPriceSheetStatus.BOSAllowAddNew = false;
            this.fld_lkeARPriceSheetStatus.BOSAllowDummy = false;
            this.fld_lkeARPriceSheetStatus.BOSComment = null;
            this.fld_lkeARPriceSheetStatus.BOSDataMember = "ARPriceSheetStatus";
            this.fld_lkeARPriceSheetStatus.BOSDataSource = "ARPriceSheets";
            this.fld_lkeARPriceSheetStatus.BOSDescription = null;
            this.fld_lkeARPriceSheetStatus.BOSError = null;
            this.fld_lkeARPriceSheetStatus.BOSFieldGroup = null;
            this.fld_lkeARPriceSheetStatus.BOSFieldParent = null;
            this.fld_lkeARPriceSheetStatus.BOSFieldRelation = null;
            this.fld_lkeARPriceSheetStatus.BOSPrivilege = null;
            this.fld_lkeARPriceSheetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARPriceSheetStatus.BOSSelectType = null;
            this.fld_lkeARPriceSheetStatus.BOSSelectTypeValue = null;
            this.fld_lkeARPriceSheetStatus.CurrentDisplayText = null;
            this.fld_lkeARPriceSheetStatus.Location = new System.Drawing.Point(781, 25);
            this.fld_lkeARPriceSheetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARPriceSheetStatus.Name = "fld_lkeARPriceSheetStatus";
            this.fld_lkeARPriceSheetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPriceSheetStatus.Properties.ColumnName = null;
            this.fld_lkeARPriceSheetStatus.Properties.ReadOnly = true;
            this.fld_lkeARPriceSheetStatus.Screen = null;
            this.fld_lkeARPriceSheetStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARPriceSheetStatus.TabIndex = 4;
            this.fld_lkeARPriceSheetStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 182);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1286, 572);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosLine1);
            this.xtraTabPage1.Controls.Add(this.fld_pteARPriceSheetItemProductPicture);
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel48);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xtraTabPage1.Controls.Add(this.fld_dgcARPriceSheetItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1284, 547);
            this.xtraTabPage1.Text = "Bảng giá bán";
            // 
            // fld_pteARPriceSheetItemProductPicture
            // 
            this.fld_pteARPriceSheetItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARPriceSheetItemProductPicture.BOSComment = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSDataMember = "ARPriceSheetItemProductPicture";
            this.fld_pteARPriceSheetItemProductPicture.BOSDataSource = "ARPriceSheetItems";
            this.fld_pteARPriceSheetItemProductPicture.BOSDescription = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSError = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSPrivilege = null;
            this.fld_pteARPriceSheetItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARPriceSheetItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARPriceSheetItemProductPicture.FileName = null;
            this.fld_pteARPriceSheetItemProductPicture.FilePath = null;
            this.fld_pteARPriceSheetItemProductPicture.Location = new System.Drawing.Point(1150, 32);
            this.fld_pteARPriceSheetItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARPriceSheetItemProductPicture.Name = "fld_pteARPriceSheetItemProductPicture";
            this.fld_pteARPriceSheetItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARPriceSheetItemProductPicture.Screen = null;
            this.fld_pteARPriceSheetItemProductPicture.Size = new System.Drawing.Size(131, 130);
            this.fld_pteARPriceSheetItemProductPicture.TabIndex = 60;
            this.fld_pteARPriceSheetItemProductPicture.Tag = "DC";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = "";
            this.fld_lblLabel48.BOSDataMember = "";
            this.fld_lblLabel48.BOSDataSource = "";
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = "";
            this.fld_lblLabel48.BOSFieldRelation = "";
            this.fld_lblLabel48.BOSPrivilege = "";
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 9);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 59;
            this.fld_lblLabel48.Tag = "";
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARPriceSheetItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(66, 6);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1078, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 58;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARPriceSheetItemsGridControl
            // 
            this.fld_dgcARPriceSheetItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARPriceSheetItemsGridControl.BOSComment = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSDataMember = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSDataSource = "ARPriceSheetItems";
            this.fld_dgcARPriceSheetItemsGridControl.BOSDescription = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSError = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSGridType = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARPriceSheetItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARPriceSheetItemsGridControl.CommodityType = "";
            this.fld_dgcARPriceSheetItemsGridControl.Location = new System.Drawing.Point(6, 32);
            this.fld_dgcARPriceSheetItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARPriceSheetItemsGridControl.Name = "fld_dgcARPriceSheetItemsGridControl";
            this.fld_dgcARPriceSheetItemsGridControl.PrintReport = false;
            this.fld_dgcARPriceSheetItemsGridControl.Screen = null;
            this.fld_dgcARPriceSheetItemsGridControl.Size = new System.Drawing.Size(1138, 377);
            this.fld_dgcARPriceSheetItemsGridControl.TabIndex = 0;
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(642, 205);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(642, 205);
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
            this.bosLine1.Controls.Add(this.fld_recARPriceSheetComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(4, 415);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(767, 124);
            this.bosLine1.TabIndex = 61;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_recARPriceSheetComment
            // 
            this.fld_recARPriceSheetComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARPriceSheetComment.BOSComment = null;
            this.fld_recARPriceSheetComment.BOSDataMember = null;
            this.fld_recARPriceSheetComment.BOSDataSource = null;
            this.fld_recARPriceSheetComment.BOSDescription = null;
            this.fld_recARPriceSheetComment.BOSError = null;
            this.fld_recARPriceSheetComment.BOSFieldGroup = null;
            this.fld_recARPriceSheetComment.BOSFieldRelation = null;
            this.fld_recARPriceSheetComment.BOSPrivilege = null;
            this.fld_recARPriceSheetComment.BOSPropertyName = null;
            this.fld_recARPriceSheetComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_recARPriceSheetComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARPriceSheetComment.Location = new System.Drawing.Point(3, 17);
            this.fld_recARPriceSheetComment.MenuManager = this.screenToolbar;
            this.fld_recARPriceSheetComment.Name = "fld_recARPriceSheetComment";
            this.fld_recARPriceSheetComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARPriceSheetComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARPriceSheetComment.Screen = null;
            this.fld_recARPriceSheetComment.Size = new System.Drawing.Size(761, 104);
            this.fld_recARPriceSheetComment.TabIndex = 2;
            this.fld_recARPriceSheetComment.Tag = "DC";
            // 
            // DMPRS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1293, 757);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPRS100.IconOptions.Icon")));
            this.Name = "DMPRS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARPriceSheetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPriceSheetApprovedStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetName.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARPriceSheetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARPriceSheetStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPriceSheetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARPriceSheetItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheetItemsGridControl)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private BOSComponent.BOSButton fld_btnUpdateEndDate;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSDateEdit fld_dteARPriceSheetEndDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARPriceSheetName;
        private BOSComponent.BOSLabel bosLabel9;
        private GroupBox groupBox1;
        private BOSComponent.BOSLookupEdit fld_lkeARPriceSheetApprovedStatus;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerType123;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSPictureEdit fld_pteARPriceSheetItemProductPicture;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSRichEditControl fld_recARPriceSheetComment;
    }
}
