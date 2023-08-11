using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConfigSalesTarget.UI
{
    /// <summary>
    /// Summary description for SMCST100
    /// </summary>
    partial class SMCST100
    {
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel94;
        private BOSComponent.BOSDateEdit fld_dteSearchFromHRConfigSalesTargetDate;
        private BOSComponent.BOSLabel fld_lblLabel114;
        private BOSComponent.BOSDateEdit fld_dteSearchToHRConfigSalesTargetDate;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesTargetNo;
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
            this.fld_dteSearchFromHRConfigSalesTargetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToHRConfigSalesTargetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRConfigSalesTargetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRConfigSalesTargetName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcHRConfigSalesTargets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReturnShippings = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRConfigSalesTargetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRConfigSalesTargetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRConfigSalesTargetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lblLabel94.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(40, 90);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel94.TabIndex = 63;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Từ ngày";
            // 
            // fld_dteSearchFromHRConfigSalesTargetDate
            // 
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSDataMember = "HRConfigSalesTargetDateFrom";
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSDataSource = "HRConfigSalesTargets";
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSDescription = null;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSFieldRelation = null;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromHRConfigSalesTargetDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHRConfigSalesTargetDate.EditValue = null;
            this.fld_dteSearchFromHRConfigSalesTargetDate.Location = new System.Drawing.Point(126, 87);
            this.fld_dteSearchFromHRConfigSalesTargetDate.Name = "fld_dteSearchFromHRConfigSalesTargetDate";
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHRConfigSalesTargetDate.Screen = null;
            this.fld_dteSearchFromHRConfigSalesTargetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromHRConfigSalesTargetDate.TabIndex = 5;
            this.fld_dteSearchFromHRConfigSalesTargetDate.Tag = "SC";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(298, 90);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel114.TabIndex = 65;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến";
            // 
            // fld_dteSearchToHRConfigSalesTargetDate
            // 
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSDataMember = "HRConfigSalesTargetDateTo";
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSDataSource = "HRConfigSalesTargets";
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSDescription = null;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSFieldRelation = null;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToHRConfigSalesTargetDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHRConfigSalesTargetDate.EditValue = null;
            this.fld_dteSearchToHRConfigSalesTargetDate.Location = new System.Drawing.Point(333, 87);
            this.fld_dteSearchToHRConfigSalesTargetDate.Name = "fld_dteSearchToHRConfigSalesTargetDate";
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHRConfigSalesTargetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHRConfigSalesTargetDate.Screen = null;
            this.fld_dteSearchToHRConfigSalesTargetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToHRConfigSalesTargetDate.TabIndex = 6;
            this.fld_dteSearchToHRConfigSalesTargetDate.Tag = "SC";
            // 
            // fld_txtHRConfigSalesTargetNo
            // 
            this.fld_txtHRConfigSalesTargetNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetNo.BOSDataMember = "HRConfigSalesTargetNo";
            this.fld_txtHRConfigSalesTargetNo.BOSDataSource = "HRConfigSalesTargets";
            this.fld_txtHRConfigSalesTargetNo.BOSDescription = null;
            this.fld_txtHRConfigSalesTargetNo.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetNo.BOSPropertyName = "Text";
            this.fld_txtHRConfigSalesTargetNo.Location = new System.Drawing.Point(126, 9);
            this.fld_txtHRConfigSalesTargetNo.Name = "fld_txtHRConfigSalesTargetNo";
            this.fld_txtHRConfigSalesTargetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRConfigSalesTargetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRConfigSalesTargetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRConfigSalesTargetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRConfigSalesTargetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRConfigSalesTargetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRConfigSalesTargetNo.Screen = null;
            this.fld_txtHRConfigSalesTargetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRConfigSalesTargetNo.TabIndex = 0;
            this.fld_txtHRConfigSalesTargetNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(126, 61);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lblLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(40, 64);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel3.TabIndex = 81;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Nhân viên";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 86;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtHRConfigSalesTargetName
            // 
            this.fld_txtHRConfigSalesTargetName.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetName.BOSDataMember = "HRConfigSalesTargetName";
            this.fld_txtHRConfigSalesTargetName.BOSDataSource = "HRConfigSalesTargets";
            this.fld_txtHRConfigSalesTargetName.BOSDescription = null;
            this.fld_txtHRConfigSalesTargetName.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetName.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetName.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetName.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRConfigSalesTargetName.BOSPropertyName = "Text";
            this.fld_txtHRConfigSalesTargetName.Location = new System.Drawing.Point(126, 35);
            this.fld_txtHRConfigSalesTargetName.Name = "fld_txtHRConfigSalesTargetName";
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRConfigSalesTargetName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRConfigSalesTargetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRConfigSalesTargetName.Screen = null;
            this.fld_txtHRConfigSalesTargetName.Size = new System.Drawing.Size(357, 20);
            this.fld_txtHRConfigSalesTargetName.TabIndex = 87;
            this.fld_txtHRConfigSalesTargetName.Tag = "SC";
            // 
            // fld_dgcHRConfigSalesTargets
            // 
            this.fld_dgcHRConfigSalesTargets.AllowDrop = true;
            this.fld_dgcHRConfigSalesTargets.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRConfigSalesTargets.BOSDataMember = null;
            this.fld_dgcHRConfigSalesTargets.BOSDataSource = "HRConfigSalesTargets";
            this.fld_dgcHRConfigSalesTargets.BOSDescription = null;
            this.fld_dgcHRConfigSalesTargets.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRConfigSalesTargets.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRConfigSalesTargets.BOSFieldRelation = null;
            this.fld_dgcHRConfigSalesTargets.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRConfigSalesTargets.BOSPropertyName = null;
            this.fld_dgcHRConfigSalesTargets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRConfigSalesTargets.Location = new System.Drawing.Point(40, 113);
            this.fld_dgcHRConfigSalesTargets.MainView = this.fld_dgvICReturnShippings;
            this.fld_dgcHRConfigSalesTargets.Name = "fld_dgcHRConfigSalesTargets";
            this.fld_dgcHRConfigSalesTargets.Screen = null;
            this.fld_dgcHRConfigSalesTargets.Size = new System.Drawing.Size(516, 419);
            this.fld_dgcHRConfigSalesTargets.TabIndex = 88;
            this.fld_dgcHRConfigSalesTargets.Tag = "SR";
            this.fld_dgcHRConfigSalesTargets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReturnShippings});
            // 
            // fld_dgvICReturnShippings
            // 
            this.fld_dgvICReturnShippings.GridControl = this.fld_dgcHRConfigSalesTargets;
            this.fld_dgvICReturnShippings.Name = "fld_dgvICReturnShippings";
            this.fld_dgvICReturnShippings.PaintStyleName = "Office2003";
            // 
            // SMCST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(591, 567);
            this.Controls.Add(this.fld_dgcHRConfigSalesTargets);
            this.Controls.Add(this.fld_txtHRConfigSalesTargetName);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHRConfigSalesTargetNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_dteSearchFromHRConfigSalesTargetDate);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchToHRConfigSalesTargetDate);
            this.Controls.Add(this.fld_lblLabel3);
            this.Name = "SMCST100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHRConfigSalesTargetDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHRConfigSalesTargetDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRConfigSalesTargetNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRConfigSalesTargetName, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRConfigSalesTargets, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRConfigSalesTargetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRConfigSalesTargetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRConfigSalesTargetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRConfigSalesTargetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesTargetName;
        private BOSSearchResultsGridControl fld_dgcHRConfigSalesTargets;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReturnShippings;
    }
}
