using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    /// <summary>
    /// Summary description for guiSelectTransfer.
    /// </summary>
    public class guiTransferReceipt : BOSERPScreen
    {
        public guiTransferReceipt()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private IContainer components;
        private Label label1;
        private SimpleButton fld_btnSearch;
        private Label label5;
        private Label label6;
        private Label label2;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSTextBox fld_txtICTransferNo;
        private BOSComponent.BOSDateEdit fld_dteICTransferDateFrom;
        private ICTransfersGridControl fld_dgcShipmentTransfers;
        private SimpleButton fld_btnCancel;
        private SimpleButton fld_btnOK;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID1;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSDateEdit fld_dteICTransferDateTo;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiTransferReceipt));
            this.label1 = new System.Windows.Forms.Label();
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICTransferNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICTransferDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICTransferDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcShipmentTransfers = new BOSERP.Modules.Transfer.ICTransfersGridControl();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lkeFK_ICFromStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentTransfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.Location = new System.Drawing.Point(777, 27);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(101, 27);
            this.fld_btnSearch.TabIndex = 6;
            this.fld_btnSearch.Text = "Tim kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_txtSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = false;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = "";
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(98, 11);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = "";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 0;
            // 
            // fld_txtICTransferNo
            // 
            this.fld_txtICTransferNo.BOSComment = null;
            this.fld_txtICTransferNo.BOSDataMember = "";
            this.fld_txtICTransferNo.BOSDataSource = "";
            this.fld_txtICTransferNo.BOSDescription = null;
            this.fld_txtICTransferNo.BOSError = null;
            this.fld_txtICTransferNo.BOSFieldGroup = null;
            this.fld_txtICTransferNo.BOSFieldRelation = null;
            this.fld_txtICTransferNo.BOSPrivilege = null;
            this.fld_txtICTransferNo.BOSPropertyName = "";
            this.fld_txtICTransferNo.Location = new System.Drawing.Point(98, 37);
            this.fld_txtICTransferNo.MenuManager = this.screenToolbar;
            this.fld_txtICTransferNo.Name = "fld_txtICTransferNo";
            this.fld_txtICTransferNo.Screen = null;
            this.fld_txtICTransferNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferNo.TabIndex = 3;
            // 
            // fld_dteICTransferDateFrom
            // 
            this.fld_dteICTransferDateFrom.BOSComment = null;
            this.fld_dteICTransferDateFrom.BOSDataMember = "";
            this.fld_dteICTransferDateFrom.BOSDataSource = "";
            this.fld_dteICTransferDateFrom.BOSDescription = null;
            this.fld_dteICTransferDateFrom.BOSError = null;
            this.fld_dteICTransferDateFrom.BOSFieldGroup = null;
            this.fld_dteICTransferDateFrom.BOSFieldRelation = null;
            this.fld_dteICTransferDateFrom.BOSPrivilege = null;
            this.fld_dteICTransferDateFrom.BOSPropertyName = "";
            this.fld_dteICTransferDateFrom.EditValue = null;
            this.fld_dteICTransferDateFrom.Location = new System.Drawing.Point(573, 11);
            this.fld_dteICTransferDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteICTransferDateFrom.Name = "fld_dteICTransferDateFrom";
            this.fld_dteICTransferDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDateFrom.Screen = null;
            this.fld_dteICTransferDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDateFrom.TabIndex = 2;
            // 
            // fld_dteICTransferDateTo
            // 
            this.fld_dteICTransferDateTo.BOSComment = null;
            this.fld_dteICTransferDateTo.BOSDataMember = "";
            this.fld_dteICTransferDateTo.BOSDataSource = "";
            this.fld_dteICTransferDateTo.BOSDescription = null;
            this.fld_dteICTransferDateTo.BOSError = null;
            this.fld_dteICTransferDateTo.BOSFieldGroup = null;
            this.fld_dteICTransferDateTo.BOSFieldRelation = null;
            this.fld_dteICTransferDateTo.BOSPrivilege = null;
            this.fld_dteICTransferDateTo.BOSPropertyName = "";
            this.fld_dteICTransferDateTo.EditValue = null;
            this.fld_dteICTransferDateTo.Location = new System.Drawing.Point(573, 37);
            this.fld_dteICTransferDateTo.Name = "fld_dteICTransferDateTo";
            this.fld_dteICTransferDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDateTo.Screen = null;
            this.fld_dteICTransferDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDateTo.TabIndex = 5;
            // 
            // fld_dgcShipmentTransfers
            // 
            this.fld_dgcShipmentTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcShipmentTransfers.BOSComment = null;
            this.fld_dgcShipmentTransfers.BOSDataMember = null;
            this.fld_dgcShipmentTransfers.BOSDataSource = "ICTransfers";
            this.fld_dgcShipmentTransfers.BOSDescription = null;
            this.fld_dgcShipmentTransfers.BOSError = null;
            this.fld_dgcShipmentTransfers.BOSFieldGroup = null;
            this.fld_dgcShipmentTransfers.BOSFieldRelation = null;
            this.fld_dgcShipmentTransfers.BOSGridType = null;
            this.fld_dgcShipmentTransfers.BOSPrivilege = null;
            this.fld_dgcShipmentTransfers.BOSPropertyName = null;
            this.fld_dgcShipmentTransfers.CommodityType = "";
            this.fld_dgcShipmentTransfers.Location = new System.Drawing.Point(8, 63);
            this.fld_dgcShipmentTransfers.MenuManager = this.screenToolbar;
            this.fld_dgcShipmentTransfers.Name = "fld_dgcShipmentTransfers";
            this.fld_dgcShipmentTransfers.PrintReport = false;
            this.fld_dgcShipmentTransfers.Screen = null;
            this.fld_dgcShipmentTransfers.Size = new System.Drawing.Size(892, 475);
            this.fld_dgcShipmentTransfers.TabIndex = 31;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(802, 544);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(98, 27);
            this.fld_btnCancel.TabIndex = 33;
            this.fld_btnCancel.Text = "Hủy";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(698, 544);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(98, 27);
            this.fld_btnOK.TabIndex = 32;
            this.fld_btnOK.Text = "Chọn ";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_lkeFK_ICFromStockID1
            // 
            this.fld_lkeFK_ICFromStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID1.BOSComment = "";
            this.fld_lkeFK_ICFromStockID1.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICFromStockID1.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID1.BOSError = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICFromStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICFromStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICFromStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICFromStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICFromStockID1.Location = new System.Drawing.Point(323, 11);
            this.fld_lkeFK_ICFromStockID1.Name = "fld_lkeFK_ICFromStockID1";
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICFromStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICFromStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID1.Screen = null;
            this.fld_lkeFK_ICFromStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID1.TabIndex = 1;
            this.fld_lkeFK_ICFromStockID1.Tag = "DC";
            // 
            // fld_lkeFK_ICToStockID1
            // 
            this.fld_lkeFK_ICToStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID1.BOSComment = "";
            this.fld_lkeFK_ICToStockID1.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID1.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICToStockID1.BOSDescription = null;
            this.fld_lkeFK_ICToStockID1.BOSError = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICToStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICToStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICToStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICToStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICToStockID1.Location = new System.Drawing.Point(323, 37);
            this.fld_lkeFK_ICToStockID1.Name = "fld_lkeFK_ICToStockID1";
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICToStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICToStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID1.Screen = null;
            this.fld_lkeFK_ICToStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID1.TabIndex = 4;
            this.fld_lkeFK_ICToStockID1.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(271, 41);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 486;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Đến kho";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(271, 15);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 485;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Từ kho";
            // 
            // guiTransferReceipt
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(910, 582);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeFK_ICFromStockID1);
            this.Controls.Add(this.fld_lkeFK_ICToStockID1);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_lblLabel7);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_dgcShipmentTransfers);
            this.Controls.Add(this.fld_dteICTransferDateTo);
            this.Controls.Add(this.fld_dteICTransferDateFrom);
            this.Controls.Add(this.fld_txtICTransferNo);
            this.Controls.Add(this.fld_lkeBRBranchID);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiTransferReceipt.IconOptions.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Name = "guiTransferReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Text = "Tìm kiếm phiếu xuất";
            this.Load += new System.EventHandler(this.guiSelectTransfer_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.fld_lkeBRBranchID, 0);
            this.Controls.SetChildIndex(this.fld_txtICTransferNo, 0);
            this.Controls.SetChildIndex(this.fld_dteICTransferDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteICTransferDateTo, 0);
            this.Controls.SetChildIndex(this.fld_dgcShipmentTransfers, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICToStockID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICFromStockID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentTransfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void guiSelectTransfer_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            if (BOSApp.CurrentCompanyInfo != null)
            {
                fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            }

            fld_dteICTransferDateFrom.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteICTransferDateTo.DateTime = BOSUtil.GetYearEndDate();
            fld_dteICTransferDateFrom.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteICTransferDateTo.DateTime = BOSUtil.GetYearEndDate();

            TransferEntities entity = (TransferEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentTransferList.InitBOSListGridControl(fld_dgcShipmentTransfers);
            entity.ShipmentTransferList.SetDefaultListAndRefreshGridControl();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (!((TransferModule)Module).GenerateReceiptTransfer())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_dgcTransfers_DoubleClick(object sender, EventArgs e)
        {
            if (!((TransferModule)Module).GenerateReceiptTransfer())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_txtSearch_Click(object sender, EventArgs e)
        {
            int branchID = fld_lkeBRBranchID.EditValue == null ? 0 : Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string transferNo = fld_txtICTransferNo.Text;
            DateTime fromDate = fld_dteICTransferDateFrom.DateTime;
            DateTime toDate = fld_dteICTransferDateTo.DateTime;
            int fromStock = fld_lkeFK_ICFromStockID1.EditValue == null ? 0 : Convert.ToInt32(fld_lkeFK_ICFromStockID1.EditValue);
            int toStock = fld_lkeFK_ICToStockID1.EditValue == null ? 0 : Convert.ToInt32(fld_lkeFK_ICToStockID1.EditValue);
            ((TransferModule)Module).ShowBranchTransfers(branchID, transferNo, fromDate, toDate, fromStock, toStock);
        }
    }
}

