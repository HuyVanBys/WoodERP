using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReceptionEquipment.UI
{
    /// <summary>
    /// Summary description for SME100
    /// </summary>
    partial class SMRE100
    {
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel94;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARReceptionDate;
        private BOSComponent.BOSLabel fld_lblLabel114;
        private BOSComponent.BOSDateEdit fld_dteSearchToARReceptionDate;
        private BOSSearchResultsGridControl fld_dgcARReceptions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReturnShippings;
        private BOSComponent.BOSTextBox fld_txtARReceptionNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
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
            this.fld_dteSearchFromARReceptionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARReceptionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcARReceptions = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReturnShippings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtARReceptionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARReceptionName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceptionDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceptionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceptionDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceptionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionName.Properties)).BeginInit();
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
            // fld_dteSearchFromARReceptionDate
            // 
            this.fld_dteSearchFromARReceptionDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARReceptionDate.BOSDataMember = "ARReceptionDateFrom";
            this.fld_dteSearchFromARReceptionDate.BOSDataSource = "ARReceptions";
            this.fld_dteSearchFromARReceptionDate.BOSDescription = null;
            this.fld_dteSearchFromARReceptionDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARReceptionDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARReceptionDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARReceptionDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARReceptionDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARReceptionDate.EditValue = null;
            this.fld_dteSearchFromARReceptionDate.Location = new System.Drawing.Point(140, 113);
            this.fld_dteSearchFromARReceptionDate.Name = "fld_dteSearchFromARReceptionDate";
            this.fld_dteSearchFromARReceptionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARReceptionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARReceptionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARReceptionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARReceptionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARReceptionDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARReceptionDate.Screen = null;
            this.fld_dteSearchFromARReceptionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARReceptionDate.TabIndex = 5;
            this.fld_dteSearchFromARReceptionDate.Tag = "SC";
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
            // fld_dteSearchToARReceptionDate
            // 
            this.fld_dteSearchToARReceptionDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARReceptionDate.BOSDataMember = "ARReceptionDateTo";
            this.fld_dteSearchToARReceptionDate.BOSDataSource = "ICReturnShippings";
            this.fld_dteSearchToARReceptionDate.BOSDescription = null;
            this.fld_dteSearchToARReceptionDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARReceptionDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARReceptionDate.BOSFieldRelation = null;
            this.fld_dteSearchToARReceptionDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARReceptionDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARReceptionDate.EditValue = null;
            this.fld_dteSearchToARReceptionDate.Location = new System.Drawing.Point(347, 113);
            this.fld_dteSearchToARReceptionDate.Name = "fld_dteSearchToARReceptionDate";
            this.fld_dteSearchToARReceptionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARReceptionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARReceptionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARReceptionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARReceptionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARReceptionDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARReceptionDate.Screen = null;
            this.fld_dteSearchToARReceptionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARReceptionDate.TabIndex = 6;
            this.fld_dteSearchToARReceptionDate.Tag = "SC";
            // 
            // fld_dgcARReceptions
            // 
            this.fld_dgcARReceptions.AllowDrop = true;
            this.fld_dgcARReceptions.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARReceptions.BOSDataMember = null;
            this.fld_dgcARReceptions.BOSDataSource = "ARReceptions";
            this.fld_dgcARReceptions.BOSDescription = null;
            this.fld_dgcARReceptions.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARReceptions.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARReceptions.BOSFieldRelation = null;
            this.fld_dgcARReceptions.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARReceptions.BOSPropertyName = null;
            this.fld_dgcARReceptions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARReceptions.Location = new System.Drawing.Point(25, 175);
            this.fld_dgcARReceptions.MainView = this.fld_dgvICReturnShippings;
            this.fld_dgcARReceptions.Name = "fld_dgcARReceptions";
            this.fld_dgcARReceptions.Screen = null;
            this.fld_dgcARReceptions.Size = new System.Drawing.Size(516, 309);
            this.fld_dgcARReceptions.TabIndex = 79;
            this.fld_dgcARReceptions.Tag = "SR";
            this.fld_dgcARReceptions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReturnShippings});
            // 
            // fld_dgvICReturnShippings
            // 
            this.fld_dgvICReturnShippings.GridControl = this.fld_dgcARReceptions;
            this.fld_dgvICReturnShippings.Name = "fld_dgvICReturnShippings";
            this.fld_dgvICReturnShippings.PaintStyleName = "Office2003";
            // 
            // fld_txtARReceptionNo
            // 
            this.fld_txtARReceptionNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionNo.BOSDataMember = "ARReceptionNo";
            this.fld_txtARReceptionNo.BOSDataSource = "ARReceptions";
            this.fld_txtARReceptionNo.BOSDescription = null;
            this.fld_txtARReceptionNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionNo.BOSPropertyName = "Text";
            this.fld_txtARReceptionNo.Location = new System.Drawing.Point(140, 9);
            this.fld_txtARReceptionNo.Name = "fld_txtARReceptionNo";
            this.fld_txtARReceptionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceptionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceptionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceptionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceptionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceptionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceptionNo.Screen = null;
            this.fld_txtARReceptionNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARReceptionNo.TabIndex = 0;
            this.fld_txtARReceptionNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARReceptions";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(140, 61);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
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
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARReceptions";
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
            // fld_txtARReceptionName
            // 
            this.fld_txtARReceptionName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionName.BOSDataMember = "ARReceptionName";
            this.fld_txtARReceptionName.BOSDataSource = "ARReceptions";
            this.fld_txtARReceptionName.BOSDescription = null;
            this.fld_txtARReceptionName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARReceptionName.BOSPropertyName = "Text";
            this.fld_txtARReceptionName.Location = new System.Drawing.Point(140, 35);
            this.fld_txtARReceptionName.Name = "fld_txtARReceptionName";
            this.fld_txtARReceptionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceptionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceptionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceptionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceptionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceptionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceptionName.Screen = null;
            this.fld_txtARReceptionName.Size = new System.Drawing.Size(357, 20);
            this.fld_txtARReceptionName.TabIndex = 87;
            this.fld_txtARReceptionName.Tag = "SC";
            // 
            // SMRE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(591, 567);
            this.Controls.Add(this.fld_txtARReceptionName);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcARReceptions);
            this.Controls.Add(this.fld_txtARReceptionNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_dteSearchFromARReceptionDate);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchToARReceptionDate);
            this.Controls.Add(this.fld_lblLabel3);
            this.Name = "SMRE100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARReceptionDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARReceptionDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_txtARReceptionNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcARReceptions, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARReceptionName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceptionDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceptionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceptionDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceptionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARReceptionName;
    }
}
