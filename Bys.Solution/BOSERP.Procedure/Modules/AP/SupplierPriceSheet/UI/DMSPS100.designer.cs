using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SupplierPriceSheet.UI
{
    /// <summary>
    /// Summary description for fld_pteICReturnShippingEmployeePicture
    /// </summary>
    partial class DMSPS100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteAPPriceSheetEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteAPPriceSheetDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtAPPriceSheetNo;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private APPriceSheetItemsGridControl fld_dgcAPPriceSheetItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeAPPriceSheetStatus;
        private BOSComponent.BOSDateEdit fld_dteAPPriceSheetEndDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medAPPriceSheetDesc;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel9;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSPS100));
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteAPPriceSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteAPPriceSheetDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPriceSheetNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeAPPriceSheetTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRApprovedEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPPriceSheetBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPPriceSheetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPriceSheetEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPriceSheetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnImportFromExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPPriceSheetItemsGridControl = new BOSERP.Modules.SupplierPriceSheet.APPriceSheetItemsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPriceSheetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPriceSheetNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPriceSheetTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRApprovedEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPriceSheetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPriceSheetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPriceSheetItemsGridControl)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = " ";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPriceSheets";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = " ";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = " ";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = " ";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = " ";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = " ";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = " ";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = " ";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 135);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, " ", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = " ";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteAPPriceSheetEmployeePicture
            // 
            this.fld_pteAPPriceSheetEmployeePicture.BOSComment = " ";
            this.fld_pteAPPriceSheetEmployeePicture.BOSDataMember = "APPriceSheetEmployeePicture";
            this.fld_pteAPPriceSheetEmployeePicture.BOSDataSource = "APPriceSheets";
            this.fld_pteAPPriceSheetEmployeePicture.BOSDescription = null;
            this.fld_pteAPPriceSheetEmployeePicture.BOSError = " ";
            this.fld_pteAPPriceSheetEmployeePicture.BOSFieldGroup = " ";
            this.fld_pteAPPriceSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPPriceSheetEmployeePicture.BOSPrivilege = " ";
            this.fld_pteAPPriceSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPPriceSheetEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPPriceSheetEmployeePicture.FileName = null;
            this.fld_pteAPPriceSheetEmployeePicture.FilePath = null;
            this.fld_pteAPPriceSheetEmployeePicture.Location = new System.Drawing.Point(5, 32);
            this.fld_pteAPPriceSheetEmployeePicture.Name = "fld_pteAPPriceSheetEmployeePicture";
            this.fld_pteAPPriceSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPPriceSheetEmployeePicture.Screen = null;
            this.fld_pteAPPriceSheetEmployeePicture.Size = new System.Drawing.Size(106, 97);
            this.fld_pteAPPriceSheetEmployeePicture.TabIndex = 0;
            this.fld_pteAPPriceSheetEmployeePicture.Tag = "DC";
            // 
            // fld_dteAPPriceSheetDate
            // 
            this.fld_dteAPPriceSheetDate.BOSComment = null;
            this.fld_dteAPPriceSheetDate.BOSDataMember = "APPriceSheetDate";
            this.fld_dteAPPriceSheetDate.BOSDataSource = "APPriceSheets";
            this.fld_dteAPPriceSheetDate.BOSDescription = null;
            this.fld_dteAPPriceSheetDate.BOSError = null;
            this.fld_dteAPPriceSheetDate.BOSFieldGroup = null;
            this.fld_dteAPPriceSheetDate.BOSFieldRelation = null;
            this.fld_dteAPPriceSheetDate.BOSPrivilege = null;
            this.fld_dteAPPriceSheetDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPriceSheetDate.EditValue = null;
            this.fld_dteAPPriceSheetDate.Location = new System.Drawing.Point(459, 29);
            this.fld_dteAPPriceSheetDate.MenuManager = this.screenToolbar;
            this.fld_dteAPPriceSheetDate.Name = "fld_dteAPPriceSheetDate";
            this.fld_dteAPPriceSheetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPriceSheetDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPriceSheetDate.Screen = null;
            this.fld_dteAPPriceSheetDate.Size = new System.Drawing.Size(135, 20);
            this.fld_dteAPPriceSheetDate.TabIndex = 1;
            this.fld_dteAPPriceSheetDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = " ";
            this.BOSLabel1.BOSDataMember = " ";
            this.BOSLabel1.BOSDataSource = " ";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = " ";
            this.BOSLabel1.BOSFieldRelation = " ";
            this.BOSLabel1.BOSPrivilege = " ";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(375, 32);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = " ";
            this.BOSLabel1.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = " ";
            this.bosLabel2.BOSDataMember = " ";
            this.bosLabel2.BOSDataSource = " ";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = " ";
            this.bosLabel2.BOSFieldRelation = " ";
            this.bosLabel2.BOSPrivilege = " ";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(135, 29);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = " ";
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtAPPriceSheetNo
            // 
            this.fld_txtAPPriceSheetNo.BOSComment = null;
            this.fld_txtAPPriceSheetNo.BOSDataMember = "APPriceSheetNo";
            this.fld_txtAPPriceSheetNo.BOSDataSource = "APPriceSheets";
            this.fld_txtAPPriceSheetNo.BOSDescription = null;
            this.fld_txtAPPriceSheetNo.BOSError = null;
            this.fld_txtAPPriceSheetNo.BOSFieldGroup = null;
            this.fld_txtAPPriceSheetNo.BOSFieldRelation = null;
            this.fld_txtAPPriceSheetNo.BOSPrivilege = null;
            this.fld_txtAPPriceSheetNo.BOSPropertyName = "EditValue";
            this.fld_txtAPPriceSheetNo.Location = new System.Drawing.Point(218, 29);
            this.fld_txtAPPriceSheetNo.MenuManager = this.screenToolbar;
            this.fld_txtAPPriceSheetNo.Name = "fld_txtAPPriceSheetNo";
            this.fld_txtAPPriceSheetNo.Screen = null;
            this.fld_txtAPPriceSheetNo.Size = new System.Drawing.Size(135, 20);
            this.fld_txtAPPriceSheetNo.TabIndex = 0;
            this.fld_txtAPPriceSheetNo.Tag = "DC";
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
            this.bosPanel1.Size = new System.Drawing.Size(1113, 687);
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeAPPriceSheetTypeCombo);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRApprovedEmployeeID);
            this.bosGroupControl1.Controls.Add(this.fld_dteAPPriceSheetBeginDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.fld_medAPPriceSheetDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPriceSheetNo);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.fld_pteAPPriceSheetEmployeePicture);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_dteAPPriceSheetDate);
            this.bosGroupControl1.Controls.Add(this.fld_dteAPPriceSheetEndDate);
            this.bosGroupControl1.Controls.Add(this.BOSLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_lkeAPPriceSheetStatus);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1106, 197);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeAPPriceSheetTypeCombo
            // 
            this.fld_lkeAPPriceSheetTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPriceSheetTypeCombo.BOSAllowDummy = false;
            this.fld_lkeAPPriceSheetTypeCombo.BOSComment = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSDataMember = "APPriceSheetType";
            this.fld_lkeAPPriceSheetTypeCombo.BOSDataSource = "APPriceSheets";
            this.fld_lkeAPPriceSheetTypeCombo.BOSDescription = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSError = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSFieldGroup = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSFieldParent = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSFieldRelation = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSPrivilege = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPriceSheetTypeCombo.BOSSelectType = null;
            this.fld_lkeAPPriceSheetTypeCombo.BOSSelectTypeValue = null;
            this.fld_lkeAPPriceSheetTypeCombo.CurrentDisplayText = null;
            this.fld_lkeAPPriceSheetTypeCombo.Location = new System.Drawing.Point(706, 107);
            this.fld_lkeAPPriceSheetTypeCombo.MenuManager = this.screenToolbar;
            this.fld_lkeAPPriceSheetTypeCombo.Name = "fld_lkeAPPriceSheetTypeCombo";
            this.fld_lkeAPPriceSheetTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPriceSheetTypeCombo.Properties.ColumnName = null;
            this.fld_lkeAPPriceSheetTypeCombo.Screen = null;
            this.fld_lkeAPPriceSheetTypeCombo.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeAPPriceSheetTypeCombo.TabIndex = 444;
            this.fld_lkeAPPriceSheetTypeCombo.Tag = "DC";
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
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(623, 110);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(63, 13);
            this.bosLabel10.TabIndex = 443;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Loại bảng giá";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPriceSheets";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(218, 107);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(376, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 441;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(135, 110);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel7.TabIndex = 440;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Đối tượng";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APPriceSheets";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(706, 55);
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
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 7;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_GECurrencyID_CloseUp);
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
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(623, 58);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(53, 13);
            this.bosLabel8.TabIndex = 439;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Loại tiền tệ";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = " ";
            this.bosLabel7.BOSDataMember = " ";
            this.bosLabel7.BOSDataSource = " ";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = " ";
            this.bosLabel7.BOSFieldRelation = " ";
            this.bosLabel7.BOSPrivilege = " ";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(623, 84);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(59, 13);
            this.bosLabel7.TabIndex = 438;
            this.bosLabel7.Tag = " ";
            this.bosLabel7.Text = "Người duyệt";
            // 
            // fld_lkeFK_HRApprovedEmployeeID
            // 
            this.fld_lkeFK_HRApprovedEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRApprovedEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRApprovedEmployeeID.BOSComment = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSDataMember = "FK_HRApprovedEmployeeID";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSDataSource = "APPriceSheets";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRApprovedEmployeeID.BOSError = "";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSFieldGroup = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSFieldParent = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSFieldRelation = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSPrivilege = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSSelectType = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.BOSSelectTypeValue = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.CurrentDisplayText = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.Location = new System.Drawing.Point(706, 81);
            this.fld_lkeFK_HRApprovedEmployeeID.Name = "fld_lkeFK_HRApprovedEmployeeID";
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, " ", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.NullText = " ";
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.ReadOnly = true;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRApprovedEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRApprovedEmployeeID.Screen = null;
            this.fld_lkeFK_HRApprovedEmployeeID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_HRApprovedEmployeeID.TabIndex = 4;
            this.fld_lkeFK_HRApprovedEmployeeID.Tag = "DC";
            // 
            // fld_dteAPPriceSheetBeginDate
            // 
            this.fld_dteAPPriceSheetBeginDate.BOSComment = null;
            this.fld_dteAPPriceSheetBeginDate.BOSDataMember = "APPriceSheetBeginDate";
            this.fld_dteAPPriceSheetBeginDate.BOSDataSource = "APPriceSheets";
            this.fld_dteAPPriceSheetBeginDate.BOSDescription = null;
            this.fld_dteAPPriceSheetBeginDate.BOSError = null;
            this.fld_dteAPPriceSheetBeginDate.BOSFieldGroup = null;
            this.fld_dteAPPriceSheetBeginDate.BOSFieldRelation = null;
            this.fld_dteAPPriceSheetBeginDate.BOSPrivilege = null;
            this.fld_dteAPPriceSheetBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPriceSheetBeginDate.EditValue = null;
            this.fld_dteAPPriceSheetBeginDate.Location = new System.Drawing.Point(218, 81);
            this.fld_dteAPPriceSheetBeginDate.MenuManager = this.screenToolbar;
            this.fld_dteAPPriceSheetBeginDate.Name = "fld_dteAPPriceSheetBeginDate";
            this.fld_dteAPPriceSheetBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPriceSheetBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPriceSheetBeginDate.Screen = null;
            this.fld_dteAPPriceSheetBeginDate.Size = new System.Drawing.Size(135, 20);
            this.fld_dteAPPriceSheetBeginDate.TabIndex = 5;
            this.fld_dteAPPriceSheetBeginDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = " ";
            this.bosLabel4.BOSDataMember = " ";
            this.bosLabel4.BOSDataSource = " ";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = " ";
            this.bosLabel4.BOSFieldRelation = " ";
            this.bosLabel4.BOSPrivilege = " ";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(135, 84);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 436;
            this.bosLabel4.Tag = " ";
            this.bosLabel4.Text = "Từ ngày";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "APPriceSheetName";
            this.bosTextBox1.BOSDataSource = "APPriceSheets";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(218, 55);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(376, 20);
            this.bosTextBox1.TabIndex = 3;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = " ";
            this.bosLabel9.BOSDataMember = " ";
            this.bosLabel9.BOSDataSource = " ";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = " ";
            this.bosLabel9.BOSFieldRelation = " ";
            this.bosLabel9.BOSPrivilege = " ";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(135, 58);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(65, 13);
            this.bosLabel9.TabIndex = 434;
            this.bosLabel9.Tag = " ";
            this.bosLabel9.Text = "Tên chứng từ";
            // 
            // fld_medAPPriceSheetDesc
            // 
            this.fld_medAPPriceSheetDesc.BOSComment = " ";
            this.fld_medAPPriceSheetDesc.BOSDataMember = "APPriceSheetDesc";
            this.fld_medAPPriceSheetDesc.BOSDataSource = "APPriceSheets";
            this.fld_medAPPriceSheetDesc.BOSDescription = null;
            this.fld_medAPPriceSheetDesc.BOSError = null;
            this.fld_medAPPriceSheetDesc.BOSFieldGroup = " ";
            this.fld_medAPPriceSheetDesc.BOSFieldRelation = " ";
            this.fld_medAPPriceSheetDesc.BOSPrivilege = " ";
            this.fld_medAPPriceSheetDesc.BOSPropertyName = "EditValue";
            this.fld_medAPPriceSheetDesc.EditValue = " ";
            this.fld_medAPPriceSheetDesc.Location = new System.Drawing.Point(218, 136);
            this.fld_medAPPriceSheetDesc.Name = "fld_medAPPriceSheetDesc";
            this.fld_medAPPriceSheetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPPriceSheetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPPriceSheetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPPriceSheetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPPriceSheetDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAPPriceSheetDesc, true);
            this.fld_medAPPriceSheetDesc.Size = new System.Drawing.Size(376, 45);
            this.fld_medAPPriceSheetDesc.TabIndex = 8;
            this.fld_medAPPriceSheetDesc.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = " ";
            this.bosLabel6.BOSDataMember = " ";
            this.bosLabel6.BOSDataSource = " ";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = " ";
            this.bosLabel6.BOSFieldRelation = " ";
            this.bosLabel6.BOSPrivilege = " ";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(135, 139);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(27, 13);
            this.bosLabel6.TabIndex = 428;
            this.bosLabel6.Tag = " ";
            this.bosLabel6.Text = "Mô tả";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = " ";
            this.bosLabel3.BOSDataMember = " ";
            this.bosLabel3.BOSDataSource = " ";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = " ";
            this.bosLabel3.BOSFieldRelation = " ";
            this.bosLabel3.BOSPrivilege = " ";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(623, 32);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = " ";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteAPPriceSheetEndDate
            // 
            this.fld_dteAPPriceSheetEndDate.BOSComment = null;
            this.fld_dteAPPriceSheetEndDate.BOSDataMember = "APPriceSheetEndDate";
            this.fld_dteAPPriceSheetEndDate.BOSDataSource = "APPriceSheets";
            this.fld_dteAPPriceSheetEndDate.BOSDescription = null;
            this.fld_dteAPPriceSheetEndDate.BOSError = null;
            this.fld_dteAPPriceSheetEndDate.BOSFieldGroup = null;
            this.fld_dteAPPriceSheetEndDate.BOSFieldRelation = null;
            this.fld_dteAPPriceSheetEndDate.BOSPrivilege = null;
            this.fld_dteAPPriceSheetEndDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPriceSheetEndDate.EditValue = null;
            this.fld_dteAPPriceSheetEndDate.Location = new System.Drawing.Point(459, 81);
            this.fld_dteAPPriceSheetEndDate.MenuManager = this.screenToolbar;
            this.fld_dteAPPriceSheetEndDate.Name = "fld_dteAPPriceSheetEndDate";
            this.fld_dteAPPriceSheetEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPriceSheetEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPriceSheetEndDate.Screen = null;
            this.fld_dteAPPriceSheetEndDate.Size = new System.Drawing.Size(135, 20);
            this.fld_dteAPPriceSheetEndDate.TabIndex = 6;
            this.fld_dteAPPriceSheetEndDate.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = " ";
            this.bosLabel5.BOSDataMember = " ";
            this.bosLabel5.BOSDataSource = " ";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = " ";
            this.bosLabel5.BOSFieldRelation = " ";
            this.bosLabel5.BOSPrivilege = " ";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(375, 84);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 423;
            this.bosLabel5.Tag = " ";
            this.bosLabel5.Text = "Đến ngày";
            // 
            // fld_lkeAPPriceSheetStatus
            // 
            this.fld_lkeAPPriceSheetStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPriceSheetStatus.BOSAllowDummy = false;
            this.fld_lkeAPPriceSheetStatus.BOSComment = null;
            this.fld_lkeAPPriceSheetStatus.BOSDataMember = "APPriceSheetStatus";
            this.fld_lkeAPPriceSheetStatus.BOSDataSource = "APPriceSheets";
            this.fld_lkeAPPriceSheetStatus.BOSDescription = null;
            this.fld_lkeAPPriceSheetStatus.BOSError = null;
            this.fld_lkeAPPriceSheetStatus.BOSFieldGroup = null;
            this.fld_lkeAPPriceSheetStatus.BOSFieldParent = null;
            this.fld_lkeAPPriceSheetStatus.BOSFieldRelation = null;
            this.fld_lkeAPPriceSheetStatus.BOSPrivilege = null;
            this.fld_lkeAPPriceSheetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPPriceSheetStatus.BOSSelectType = null;
            this.fld_lkeAPPriceSheetStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPPriceSheetStatus.CurrentDisplayText = null;
            this.fld_lkeAPPriceSheetStatus.Location = new System.Drawing.Point(706, 29);
            this.fld_lkeAPPriceSheetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPPriceSheetStatus.Name = "fld_lkeAPPriceSheetStatus";
            this.fld_lkeAPPriceSheetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPriceSheetStatus.Properties.ColumnName = null;
            this.fld_lkeAPPriceSheetStatus.Properties.ReadOnly = true;
            this.fld_lkeAPPriceSheetStatus.Screen = null;
            this.fld_lkeAPPriceSheetStatus.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeAPPriceSheetStatus.TabIndex = 2;
            this.fld_lkeAPPriceSheetStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 206);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1106, 478);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnImportFromExcel);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProduct);
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPPriceSheetItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1104, 453);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_btnImportFromExcel
            // 
            this.fld_btnImportFromExcel.BOSComment = null;
            this.fld_btnImportFromExcel.BOSDataMember = null;
            this.fld_btnImportFromExcel.BOSDataSource = null;
            this.fld_btnImportFromExcel.BOSDescription = null;
            this.fld_btnImportFromExcel.BOSError = null;
            this.fld_btnImportFromExcel.BOSFieldGroup = null;
            this.fld_btnImportFromExcel.BOSFieldRelation = null;
            this.fld_btnImportFromExcel.BOSPrivilege = null;
            this.fld_btnImportFromExcel.BOSPropertyName = null;
            this.fld_btnImportFromExcel.Location = new System.Drawing.Point(115, 4);
            this.fld_btnImportFromExcel.Name = "fld_btnImportFromExcel";
            this.fld_btnImportFromExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnImportFromExcel, true);
            this.fld_btnImportFromExcel.Size = new System.Drawing.Size(130, 27);
            this.fld_btnImportFromExcel.TabIndex = 1;
            this.fld_btnImportFromExcel.Text = "Load từ Excel";
            this.fld_btnImportFromExcel.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = " ";
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = " ";
            this.fld_btnAddProduct.BOSFieldRelation = " ";
            this.fld_btnAddProduct.BOSPrivilege = " ";
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(6, 3);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProduct.TabIndex = 0;
            this.fld_btnAddProduct.Tag = " ";
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // fld_dgcAPPriceSheetItemsGridControl
            // 
            this.fld_dgcAPPriceSheetItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPriceSheetItemsGridControl.BOSComment = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSDataMember = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSDataSource = "APPriceSheetItems";
            this.fld_dgcAPPriceSheetItemsGridControl.BOSDescription = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSError = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSGridType = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSPrivilege = null;
            this.fld_dgcAPPriceSheetItemsGridControl.BOSPropertyName = null;
            this.fld_dgcAPPriceSheetItemsGridControl.CommodityType = "";
            this.fld_dgcAPPriceSheetItemsGridControl.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcAPPriceSheetItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAPPriceSheetItemsGridControl.Name = "fld_dgcAPPriceSheetItemsGridControl";
            this.fld_dgcAPPriceSheetItemsGridControl.PrintReport = false;
            this.fld_dgcAPPriceSheetItemsGridControl.Screen = null;
            this.fld_dgcAPPriceSheetItemsGridControl.Size = new System.Drawing.Size(1098, 414);
            this.fld_dgcAPPriceSheetItemsGridControl.TabIndex = 0;
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
            this.fld_dgcACDocumentEntrys.BOSComment = " ";
            this.fld_dgcACDocumentEntrys.BOSDataMember = " ";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = " ";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = " ";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = " ";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = " ";
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
            // DMSPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1113, 687);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSPS100.IconOptions.Icon")));
            this.Name = "DMSPS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPriceSheetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPriceSheetNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPriceSheetTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRApprovedEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPriceSheetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPriceSheetEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPriceSheetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPriceSheetItemsGridControl)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private BOSComponent.BOSButton fld_btnImportFromExcel;
        private BOSComponent.BOSDateEdit fld_dteAPPriceSheetBeginDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRApprovedEmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel8;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeAPPriceSheetTypeCombo;
        private BOSComponent.BOSLabel bosLabel10;
    }
}
