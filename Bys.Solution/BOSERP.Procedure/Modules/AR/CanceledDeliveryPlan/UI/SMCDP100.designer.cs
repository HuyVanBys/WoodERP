using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CanceledDeliveryPlan.UI
{
    /// <summary>
    /// Summary description for SMCDP100
    /// </summary>
    partial class SMCDP100
    {
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel94;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARCanceledDeliveryPlanDate;
        private BOSComponent.BOSLabel fld_lblLabel114;
        private BOSComponent.BOSDateEdit fld_dteSearchToARCanceledDeliveryPlanDate;
        private BOSComponent.BOSTextBox fld_txtARCanceledDeliveryPlanNo;
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
            this.fld_dteSearchFromARCanceledDeliveryPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARCanceledDeliveryPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARCanceledDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCanceledDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcARCanceledDeliveryPlans = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReturnShippings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCanceledDeliveryPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
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
            this.fld_lblLabel94.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(40, 116);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel94.TabIndex = 63;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Từ ngày";
            // 
            // fld_dteSearchFromARCanceledDeliveryPlanDate
            // 
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSDataMember = "ARCanceledDeliveryPlanDateFrom";
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSDescription = null;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.EditValue = null;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Location = new System.Drawing.Point(126, 113);
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Name = "fld_dteSearchFromARCanceledDeliveryPlanDate";
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Screen = null;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.TabIndex = 5;
            this.fld_dteSearchFromARCanceledDeliveryPlanDate.Tag = "SC";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(298, 116);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel114.TabIndex = 65;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến";
            // 
            // fld_dteSearchToARCanceledDeliveryPlanDate
            // 
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSDataMember = "ARCanceledDeliveryPlanDateTo";
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSDescription = null;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSFieldRelation = null;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARCanceledDeliveryPlanDate.EditValue = null;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Location = new System.Drawing.Point(333, 113);
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Name = "fld_dteSearchToARCanceledDeliveryPlanDate";
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Screen = null;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARCanceledDeliveryPlanDate.TabIndex = 6;
            this.fld_dteSearchToARCanceledDeliveryPlanDate.Tag = "SC";
            // 
            // fld_txtARCanceledDeliveryPlanNo
            // 
            this.fld_txtARCanceledDeliveryPlanNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanNo.BOSDataMember = "ARCanceledDeliveryPlanNo";
            this.fld_txtARCanceledDeliveryPlanNo.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_txtARCanceledDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanNo.BOSPropertyName = "Text";
            this.fld_txtARCanceledDeliveryPlanNo.Location = new System.Drawing.Point(126, 9);
            this.fld_txtARCanceledDeliveryPlanNo.Name = "fld_txtARCanceledDeliveryPlanNo";
            this.fld_txtARCanceledDeliveryPlanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCanceledDeliveryPlanNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCanceledDeliveryPlanNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCanceledDeliveryPlanNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCanceledDeliveryPlanNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCanceledDeliveryPlanNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCanceledDeliveryPlanNo.Screen = null;
            this.fld_txtARCanceledDeliveryPlanNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCanceledDeliveryPlanNo.TabIndex = 0;
            this.fld_txtARCanceledDeliveryPlanNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(126, 61);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
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
            this.fld_lblLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
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
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.Location = new System.Drawing.Point(40, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 85;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 86;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtARCanceledDeliveryPlanName
            // 
            this.fld_txtARCanceledDeliveryPlanName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanName.BOSDataMember = "ARCanceledDeliveryPlanName";
            this.fld_txtARCanceledDeliveryPlanName.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_txtARCanceledDeliveryPlanName.BOSDescription = null;
            this.fld_txtARCanceledDeliveryPlanName.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARCanceledDeliveryPlanName.BOSPropertyName = "Text";
            this.fld_txtARCanceledDeliveryPlanName.Location = new System.Drawing.Point(126, 35);
            this.fld_txtARCanceledDeliveryPlanName.Name = "fld_txtARCanceledDeliveryPlanName";
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCanceledDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCanceledDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCanceledDeliveryPlanName.Screen = null;
            this.fld_txtARCanceledDeliveryPlanName.Size = new System.Drawing.Size(357, 20);
            this.fld_txtARCanceledDeliveryPlanName.TabIndex = 87;
            this.fld_txtARCanceledDeliveryPlanName.Tag = "SC";
            // 
            // fld_dgcARCanceledDeliveryPlans
            // 
            this.fld_dgcARCanceledDeliveryPlans.AllowDrop = true;
            this.fld_dgcARCanceledDeliveryPlans.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARCanceledDeliveryPlans.BOSDataMember = null;
            this.fld_dgcARCanceledDeliveryPlans.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_dgcARCanceledDeliveryPlans.BOSDescription = null;
            this.fld_dgcARCanceledDeliveryPlans.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARCanceledDeliveryPlans.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARCanceledDeliveryPlans.BOSFieldRelation = null;
            this.fld_dgcARCanceledDeliveryPlans.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARCanceledDeliveryPlans.BOSPropertyName = null;
            this.fld_dgcARCanceledDeliveryPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCanceledDeliveryPlans.Location = new System.Drawing.Point(40, 223);
            this.fld_dgcARCanceledDeliveryPlans.MainView = this.fld_dgvICReturnShippings;
            this.fld_dgcARCanceledDeliveryPlans.Name = "fld_dgcARCanceledDeliveryPlans";
            this.fld_dgcARCanceledDeliveryPlans.Screen = null;
            this.fld_dgcARCanceledDeliveryPlans.Size = new System.Drawing.Size(516, 309);
            this.fld_dgcARCanceledDeliveryPlans.TabIndex = 88;
            this.fld_dgcARCanceledDeliveryPlans.Tag = "SR";
            this.fld_dgcARCanceledDeliveryPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReturnShippings});
            // 
            // fld_dgvICReturnShippings
            // 
            this.fld_dgvICReturnShippings.GridControl = this.fld_dgcARCanceledDeliveryPlans;
            this.fld_dgvICReturnShippings.Name = "fld_dgvICReturnShippings";
            this.fld_dgvICReturnShippings.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(126, 87);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 89;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMCDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(591, 567);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcARCanceledDeliveryPlans);
            this.Controls.Add(this.fld_txtARCanceledDeliveryPlanName);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtARCanceledDeliveryPlanNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_dteSearchFromARCanceledDeliveryPlanDate);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchToARCanceledDeliveryPlanDate);
            this.Controls.Add(this.fld_lblLabel3);
            this.Name = "SMCDP100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARCanceledDeliveryPlanDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCanceledDeliveryPlanDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_txtARCanceledDeliveryPlanNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARCanceledDeliveryPlanName, 0);
            this.Controls.SetChildIndex(this.fld_dgcARCanceledDeliveryPlans, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCanceledDeliveryPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCanceledDeliveryPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCanceledDeliveryPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReturnShippings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCanceledDeliveryPlanName;
        private BOSSearchResultsGridControl fld_dgcARCanceledDeliveryPlans;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReturnShippings;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
    }
}
