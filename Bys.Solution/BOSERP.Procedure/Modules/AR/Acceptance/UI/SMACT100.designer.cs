using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Acceptance.UI
{
    /// <summary>
    /// Summary description for SMACT100
    /// </summary>
    partial class SMACT100
    {
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel94;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARAcceptanceDate;
        private BOSComponent.BOSLabel fld_lblLabel114;
        private BOSComponent.BOSDateEdit fld_dteSearchToARAcceptanceDate;
        private BOSSearchResultsGridControl fld_dgcARAcceptances;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReturnShippings;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceNo;
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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARAcceptanceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARAcceptanceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcARAcceptances = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReturnShippings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtARAcceptanceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARAcceptanceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARAcceptanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARAcceptanceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARAcceptanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAcceptances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel94.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(40, 116);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel94.TabIndex = 63;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Ngày chứng từ từ";
            // 
            // fld_dteSearchFromARAcceptanceDate
            // 
            this.fld_dteSearchFromARAcceptanceDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARAcceptanceDate.BOSDataMember = "ARAcceptanceDateFrom";
            this.fld_dteSearchFromARAcceptanceDate.BOSDataSource = "ARAcceptances";
            this.fld_dteSearchFromARAcceptanceDate.BOSDescription = null;
            this.fld_dteSearchFromARAcceptanceDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARAcceptanceDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARAcceptanceDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARAcceptanceDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARAcceptanceDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARAcceptanceDate.EditValue = null;
            this.fld_dteSearchFromARAcceptanceDate.Location = new System.Drawing.Point(140, 113);
            this.fld_dteSearchFromARAcceptanceDate.Name = "fld_dteSearchFromARAcceptanceDate";
            this.fld_dteSearchFromARAcceptanceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARAcceptanceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARAcceptanceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARAcceptanceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARAcceptanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARAcceptanceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARAcceptanceDate.Screen = null;
            this.fld_dteSearchFromARAcceptanceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARAcceptanceDate.TabIndex = 5;
            this.fld_dteSearchFromARAcceptanceDate.Tag = "SC";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(312, 116);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel114.TabIndex = 65;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến";
            // 
            // fld_dteSearchToARAcceptanceDate
            // 
            this.fld_dteSearchToARAcceptanceDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARAcceptanceDate.BOSDataMember = "ARAcceptanceDateTo";
            this.fld_dteSearchToARAcceptanceDate.BOSDataSource = "ARAcceptances";
            this.fld_dteSearchToARAcceptanceDate.BOSDescription = null;
            this.fld_dteSearchToARAcceptanceDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARAcceptanceDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARAcceptanceDate.BOSFieldRelation = null;
            this.fld_dteSearchToARAcceptanceDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARAcceptanceDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARAcceptanceDate.EditValue = null;
            this.fld_dteSearchToARAcceptanceDate.Location = new System.Drawing.Point(347, 113);
            this.fld_dteSearchToARAcceptanceDate.Name = "fld_dteSearchToARAcceptanceDate";
            this.fld_dteSearchToARAcceptanceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARAcceptanceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARAcceptanceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARAcceptanceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARAcceptanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARAcceptanceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARAcceptanceDate.Screen = null;
            this.fld_dteSearchToARAcceptanceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARAcceptanceDate.TabIndex = 6;
            this.fld_dteSearchToARAcceptanceDate.Tag = "SC";
            // 
            // fld_dgcARAcceptances
            // 
            this.fld_dgcARAcceptances.AllowDrop = true;
            this.fld_dgcARAcceptances.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARAcceptances.BOSDataMember = null;
            this.fld_dgcARAcceptances.BOSDataSource = "ARAcceptances";
            this.fld_dgcARAcceptances.BOSDescription = null;
            this.fld_dgcARAcceptances.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARAcceptances.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARAcceptances.BOSFieldRelation = null;
            this.fld_dgcARAcceptances.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARAcceptances.BOSPropertyName = null;
            this.fld_dgcARAcceptances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARAcceptances.Location = new System.Drawing.Point(25, 175);
            this.fld_dgcARAcceptances.MainView = this.fld_dgvICReturnShippings;
            this.fld_dgcARAcceptances.Name = "fld_dgcARAcceptances";
            this.fld_dgcARAcceptances.Screen = null;
            this.fld_dgcARAcceptances.Size = new System.Drawing.Size(516, 309);
            this.fld_dgcARAcceptances.TabIndex = 79;
            this.fld_dgcARAcceptances.Tag = "SR";
            this.fld_dgcARAcceptances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReturnShippings});
            // 
            // fld_dgvICReturnShippings
            // 
            this.fld_dgvICReturnShippings.GridControl = this.fld_dgcARAcceptances;
            this.fld_dgvICReturnShippings.Name = "fld_dgvICReturnShippings";
            this.fld_dgvICReturnShippings.PaintStyleName = "Office2003";
            // 
            // fld_txtARAcceptanceNo
            // 
            this.fld_txtARAcceptanceNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceNo.BOSDataMember = "ARAcceptanceNo";
            this.fld_txtARAcceptanceNo.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceNo.BOSDescription = null;
            this.fld_txtARAcceptanceNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceNo.BOSPropertyName = "Text";
            this.fld_txtARAcceptanceNo.Location = new System.Drawing.Point(140, 9);
            this.fld_txtARAcceptanceNo.Name = "fld_txtARAcceptanceNo";
            this.fld_txtARAcceptanceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceNo.Screen = null;
            this.fld_txtARAcceptanceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARAcceptanceNo.TabIndex = 0;
            this.fld_txtARAcceptanceNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(140, 61);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(40, 64);
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
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(40, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 85;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(140, 87);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 86;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtARAcceptanceName
            // 
            this.fld_txtARAcceptanceName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceName.BOSDataMember = "ARAcceptanceName";
            this.fld_txtARAcceptanceName.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceName.BOSDescription = null;
            this.fld_txtARAcceptanceName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARAcceptanceName.BOSPropertyName = "Text";
            this.fld_txtARAcceptanceName.Location = new System.Drawing.Point(140, 35);
            this.fld_txtARAcceptanceName.Name = "fld_txtARAcceptanceName";
            this.fld_txtARAcceptanceName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceName.Screen = null;
            this.fld_txtARAcceptanceName.Size = new System.Drawing.Size(357, 20);
            this.fld_txtARAcceptanceName.TabIndex = 87;
            this.fld_txtARAcceptanceName.Tag = "SC";
            // 
            // SMACT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(591, 567);
            this.Controls.Add(this.fld_txtARAcceptanceName);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcARAcceptances);
            this.Controls.Add(this.fld_txtARAcceptanceNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_dteSearchFromARAcceptanceDate);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchToARAcceptanceDate);
            this.Controls.Add(this.fld_lblLabel3);
            this.Name = "SMACT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARAcceptanceDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARAcceptanceDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtARAcceptanceNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcARAcceptances, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARAcceptanceName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARAcceptanceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARAcceptanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARAcceptanceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARAcceptanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAcceptances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceName;
    }
}
