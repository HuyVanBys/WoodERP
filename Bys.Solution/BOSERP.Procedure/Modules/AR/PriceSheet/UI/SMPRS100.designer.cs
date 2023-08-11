using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PriceSheet.UI
{
    /// <summary>
    /// Summary description for SMPRS100
    /// </summary>
    partial class SMPRS100
    {
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel94;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARPriceSheetDate;
        private BOSComponent.BOSLabel fld_lblLabel114;
        private BOSComponent.BOSDateEdit fld_dteSearchToARPriceSheetDate;
        private BOSComponent.BOSTextBox fld_txtARPriceSheetNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMPRS100));
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARPriceSheetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARPriceSheetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARPriceSheetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARPriceSheets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReturnShippings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARCustomerType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARPriceSheetDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARPriceSheetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARPriceSheetDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARPriceSheetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(40, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel94
            // 
            this.fld_lblLabel94.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel94.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel94.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel94.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel94.BOSComment = "";
            this.fld_lblLabel94.BOSDataMember = "";
            this.fld_lblLabel94.BOSDataSource = "";
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = "";
            this.fld_lblLabel94.BOSFieldRelation = "";
            this.fld_lblLabel94.BOSPrivilege = "";
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(40, 64);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel94.TabIndex = 63;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Từ ngày";
            // 
            // fld_dteSearchFromARPriceSheetDate
            // 
            this.fld_dteSearchFromARPriceSheetDate.BOSComment = "";
            this.fld_dteSearchFromARPriceSheetDate.BOSDataMember = "ARPriceSheetDateFrom";
            this.fld_dteSearchFromARPriceSheetDate.BOSDataSource = "ARPriceSheetPlans";
            this.fld_dteSearchFromARPriceSheetDate.BOSDescription = null;
            this.fld_dteSearchFromARPriceSheetDate.BOSError = "";
            this.fld_dteSearchFromARPriceSheetDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARPriceSheetDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARPriceSheetDate.BOSPrivilege = "";
            this.fld_dteSearchFromARPriceSheetDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARPriceSheetDate.EditValue = null;
            this.fld_dteSearchFromARPriceSheetDate.Location = new System.Drawing.Point(126, 61);
            this.fld_dteSearchFromARPriceSheetDate.Name = "fld_dteSearchFromARPriceSheetDate";
            this.fld_dteSearchFromARPriceSheetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARPriceSheetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARPriceSheetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARPriceSheetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARPriceSheetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARPriceSheetDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARPriceSheetDate.Screen = null;
            this.fld_dteSearchFromARPriceSheetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARPriceSheetDate.TabIndex = 5;
            this.fld_dteSearchFromARPriceSheetDate.Tag = "SC";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = "";
            this.fld_lblLabel114.BOSDataMember = "";
            this.fld_lblLabel114.BOSDataSource = "";
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = "";
            this.fld_lblLabel114.BOSFieldRelation = "";
            this.fld_lblLabel114.BOSPrivilege = "";
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(313, 64);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel114.TabIndex = 65;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến ngày";
            // 
            // fld_dteSearchToARPriceSheetDate
            // 
            this.fld_dteSearchToARPriceSheetDate.BOSComment = "";
            this.fld_dteSearchToARPriceSheetDate.BOSDataMember = "ARPriceSheetDateTo";
            this.fld_dteSearchToARPriceSheetDate.BOSDataSource = "ARPriceSheets";
            this.fld_dteSearchToARPriceSheetDate.BOSDescription = null;
            this.fld_dteSearchToARPriceSheetDate.BOSError = "";
            this.fld_dteSearchToARPriceSheetDate.BOSFieldGroup = "";
            this.fld_dteSearchToARPriceSheetDate.BOSFieldRelation = null;
            this.fld_dteSearchToARPriceSheetDate.BOSPrivilege = "";
            this.fld_dteSearchToARPriceSheetDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARPriceSheetDate.EditValue = null;
            this.fld_dteSearchToARPriceSheetDate.Location = new System.Drawing.Point(381, 61);
            this.fld_dteSearchToARPriceSheetDate.Name = "fld_dteSearchToARPriceSheetDate";
            this.fld_dteSearchToARPriceSheetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARPriceSheetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARPriceSheetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARPriceSheetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARPriceSheetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARPriceSheetDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARPriceSheetDate.Screen = null;
            this.fld_dteSearchToARPriceSheetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARPriceSheetDate.TabIndex = 6;
            this.fld_dteSearchToARPriceSheetDate.Tag = "SC";
            // 
            // fld_txtARPriceSheetNo
            // 
            this.fld_txtARPriceSheetNo.BOSComment = "";
            this.fld_txtARPriceSheetNo.BOSDataMember = "ARPriceSheetNo";
            this.fld_txtARPriceSheetNo.BOSDataSource = "ARPriceSheets";
            this.fld_txtARPriceSheetNo.BOSDescription = null;
            this.fld_txtARPriceSheetNo.BOSError = "";
            this.fld_txtARPriceSheetNo.BOSFieldGroup = "";
            this.fld_txtARPriceSheetNo.BOSFieldRelation = "";
            this.fld_txtARPriceSheetNo.BOSPrivilege = "";
            this.fld_txtARPriceSheetNo.BOSPropertyName = "Text";
            this.fld_txtARPriceSheetNo.Location = new System.Drawing.Point(126, 9);
            this.fld_txtARPriceSheetNo.Name = "fld_txtARPriceSheetNo";
            this.fld_txtARPriceSheetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARPriceSheetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARPriceSheetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARPriceSheetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARPriceSheetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARPriceSheetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARPriceSheetNo.Screen = null;
            this.fld_txtARPriceSheetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARPriceSheetNo.TabIndex = 0;
            this.fld_txtARPriceSheetNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARPriceSheets";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(381, 9);
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
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(313, 12);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel3.TabIndex = 81;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Nhân viên";
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
            this.bosLabel2.Location = new System.Drawing.Point(313, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 85;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_dgcARPriceSheets
            // 
            this.fld_dgcARPriceSheets.AllowDrop = true;
            this.fld_dgcARPriceSheets.BOSComment = "";
            this.fld_dgcARPriceSheets.BOSDataMember = null;
            this.fld_dgcARPriceSheets.BOSDataSource = "ARPriceSheets";
            this.fld_dgcARPriceSheets.BOSDescription = null;
            this.fld_dgcARPriceSheets.BOSError = "";
            this.fld_dgcARPriceSheets.BOSFieldGroup = "";
            this.fld_dgcARPriceSheets.BOSFieldRelation = null;
            this.fld_dgcARPriceSheets.BOSGridType = null;
            this.fld_dgcARPriceSheets.BOSPrivilege = "";
            this.fld_dgcARPriceSheets.BOSPropertyName = null;
            this.fld_dgcARPriceSheets.CommodityType = "";
            this.fld_dgcARPriceSheets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARPriceSheets.Location = new System.Drawing.Point(40, 150);
            this.fld_dgcARPriceSheets.MainView = this.fld_dgvICReturnShippings;
            this.fld_dgcARPriceSheets.Name = "fld_dgcARPriceSheets";
            this.fld_dgcARPriceSheets.PrintReport = false;
            this.fld_dgcARPriceSheets.Screen = null;
            this.fld_dgcARPriceSheets.Size = new System.Drawing.Size(516, 382);
            this.fld_dgcARPriceSheets.TabIndex = 88;
            this.fld_dgcARPriceSheets.Tag = "SR";
            this.fld_dgcARPriceSheets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReturnShippings});
            // 
            // fld_dgvICReturnShippings
            // 
            this.fld_dgvICReturnShippings.GridControl = this.fld_dgcARPriceSheets;
            this.fld_dgvICReturnShippings.Name = "fld_dgvICReturnShippings";
            this.fld_dgvICReturnShippings.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARPriceSheets";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(381, 35);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 89;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lkeARCustomerType
            // 
            this.fld_lkeARCustomerType.BOSAllowAddNew = false;
            this.fld_lkeARCustomerType.BOSAllowDummy = true;
            this.fld_lkeARCustomerType.BOSComment = "";
            this.fld_lkeARCustomerType.BOSDataMember = "ARCustomerType";
            this.fld_lkeARCustomerType.BOSDataSource = "ARPriceSheets";
            this.fld_lkeARCustomerType.BOSDescription = null;
            this.fld_lkeARCustomerType.BOSError = null;
            this.fld_lkeARCustomerType.BOSFieldGroup = "";
            this.fld_lkeARCustomerType.BOSFieldParent = "";
            this.fld_lkeARCustomerType.BOSFieldRelation = "";
            this.fld_lkeARCustomerType.BOSPrivilege = "";
            this.fld_lkeARCustomerType.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerType.BOSSelectType = "";
            this.fld_lkeARCustomerType.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerType.CurrentDisplayText = null;
            this.fld_lkeARCustomerType.Location = new System.Drawing.Point(126, 35);
            this.fld_lkeARCustomerType.Name = "fld_lkeARCustomerType";
            this.fld_lkeARCustomerType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerType.Properties.ColumnName = null;
            this.fld_lkeARCustomerType.Properties.NullText = "";
            this.fld_lkeARCustomerType.Properties.PopupWidth = 40;
            this.fld_lkeARCustomerType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerType.Screen = null;
            this.fld_lkeARCustomerType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerType.TabIndex = 422;
            this.fld_lkeARCustomerType.Tag = "SC";
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
            this.bosLabel4.Location = new System.Drawing.Point(40, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(77, 13);
            this.bosLabel4.TabIndex = 423;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại khách hàng";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARPriceSheetItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = "";
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "EditValue";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(126, 113);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(405, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 435;
            this.fld_lkeFK_ICProductID.Tag = "SC";
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 116);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 434;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Sản phẩm";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(40, 90);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel1.TabIndex = 436;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = "";
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARPriceSheets";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(126, 87);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Name")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 437;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // SMPRS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(625, 588);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lkeFK_ICProductID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeARCustomerType);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcARPriceSheets);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtARPriceSheetNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_dteSearchFromARPriceSheetDate);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchToARPriceSheetDate);
            this.Controls.Add(this.fld_lblLabel3);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMPRS100.IconOptions.Icon")));
            this.Name = "SMPRS100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARPriceSheetDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARPriceSheetDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtARPriceSheetNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcARPriceSheets, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeARCustomerType, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARPriceSheetDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARPriceSheetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARPriceSheetDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARPriceSheetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPriceSheetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARPriceSheets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSSearchResultsGridControl fld_dgcARPriceSheets;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReturnShippings;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerType;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
    }
}
