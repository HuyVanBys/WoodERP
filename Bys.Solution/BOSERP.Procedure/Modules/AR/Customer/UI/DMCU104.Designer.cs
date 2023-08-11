using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU104
    /// </summary>
    partial class DMCU104
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARRemindStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARRemindType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dtpARRemindDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARRemindDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARRemindName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARRemindNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARRemindsGridControl = new BOSERP.Modules.Customer.ARRemindGridControl();
            this.fld_btnAddRemind = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteRemind = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditRemind = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRemindStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRemindType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpARRemindDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpARRemindDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARRemindDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRemindName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRemindNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRemindsGridControl)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_btnAddRemind);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteRemind);
            this.bosPanel1.Controls.Add(this.fld_btnEditRemind);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 599);
            this.bosPanel1.TabIndex = 6;
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARRemindStatus);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARRemindType);
            this.bosGroupControl1.Controls.Add(this.fld_dtpARRemindDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_medARRemindDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtARRemindName);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtARRemindNo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel35);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel38);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel48);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel49);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(857, 213);
            this.bosGroupControl1.TabIndex = 16;
            this.bosGroupControl1.Text = "Thông tin nhắc nhở";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARReminds";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(405, 181);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(167, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 6;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(301, 184);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(96, 13);
            this.bosLabel4.TabIndex = 359;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Nhân viên thực hiện";
            // 
            // fld_lkeARRemindStatus
            // 
            this.fld_lkeARRemindStatus.BOSAllowAddNew = false;
            this.fld_lkeARRemindStatus.BOSAllowDummy = true;
            this.fld_lkeARRemindStatus.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSDataMember = "ARRemindStatus";
            this.fld_lkeARRemindStatus.BOSDataSource = "ARReminds";
            this.fld_lkeARRemindStatus.BOSDescription = null;
            this.fld_lkeARRemindStatus.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARRemindStatus.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.Location = new System.Drawing.Point(106, 181);
            this.fld_lkeARRemindStatus.Name = "fld_lkeARRemindStatus";
            this.fld_lkeARRemindStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARRemindStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARRemindStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARRemindStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARRemindStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARRemindStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindStatus.Properties.ReadOnly = true;
            this.fld_lkeARRemindStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARRemindStatus.Screen = null;
            this.fld_lkeARRemindStatus.Size = new System.Drawing.Size(178, 20);
            this.fld_lkeARRemindStatus.TabIndex = 5;
            this.fld_lkeARRemindStatus.Tag = "DC";
            // 
            // fld_lkeARRemindType
            // 
            this.fld_lkeARRemindType.BOSAllowAddNew = false;
            this.fld_lkeARRemindType.BOSAllowDummy = true;
            this.fld_lkeARRemindType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSDataMember = "ARRemindType";
            this.fld_lkeARRemindType.BOSDataSource = "ARReminds";
            this.fld_lkeARRemindType.BOSDescription = null;
            this.fld_lkeARRemindType.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSPropertyName = "EditValue";
            this.fld_lkeARRemindType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.Location = new System.Drawing.Point(405, 155);
            this.fld_lkeARRemindType.Name = "fld_lkeARRemindType";
            this.fld_lkeARRemindType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARRemindType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARRemindType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARRemindType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARRemindType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARRemindType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARRemindType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARRemindType.Screen = null;
            this.fld_lkeARRemindType.Size = new System.Drawing.Size(167, 20);
            this.fld_lkeARRemindType.TabIndex = 4;
            this.fld_lkeARRemindType.Tag = "DC";
            // 
            // fld_dtpARRemindDate
            // 
            this.fld_dtpARRemindDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dtpARRemindDate.BOSDataMember = "ARRemindDate";
            this.fld_dtpARRemindDate.BOSDataSource = "ARReminds";
            this.fld_dtpARRemindDate.BOSDescription = null;
            this.fld_dtpARRemindDate.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dtpARRemindDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dtpARRemindDate.BOSFieldRelation = null;
            this.fld_dtpARRemindDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dtpARRemindDate.BOSPropertyName = "EditValue";
            this.fld_dtpARRemindDate.EditValue = null;
            this.fld_dtpARRemindDate.Location = new System.Drawing.Point(106, 155);
            this.fld_dtpARRemindDate.Name = "fld_dtpARRemindDate";
            this.fld_dtpARRemindDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtpARRemindDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dtpARRemindDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtpARRemindDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtpARRemindDate.Properties.Appearance.Options.UseFont = true;
            this.fld_dtpARRemindDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtpARRemindDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtpARRemindDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtpARRemindDate.Screen = null;
            this.fld_dtpARRemindDate.Size = new System.Drawing.Size(178, 20);
            this.fld_dtpARRemindDate.TabIndex = 3;
            this.fld_dtpARRemindDate.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 158);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(73, 13);
            this.bosLabel3.TabIndex = 358;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Ngày nhắc nhở";
            // 
            // fld_medARRemindDesc
            // 
            this.fld_medARRemindDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARRemindDesc.BOSDataMember = "ARRemindDesc";
            this.fld_medARRemindDesc.BOSDataSource = "ARReminds";
            this.fld_medARRemindDesc.BOSDescription = null;
            this.fld_medARRemindDesc.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARRemindDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARRemindDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARRemindDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARRemindDesc.BOSPropertyName = "Text";
            this.fld_medARRemindDesc.Location = new System.Drawing.Point(106, 76);
            this.fld_medARRemindDesc.Name = "fld_medARRemindDesc";
            this.fld_medARRemindDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARRemindDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARRemindDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARRemindDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARRemindDesc.Screen = null;
            this.fld_medARRemindDesc.Size = new System.Drawing.Size(466, 73);
            this.fld_medARRemindDesc.TabIndex = 2;
            this.fld_medARRemindDesc.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 184);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 356;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Trạng thái";
            // 
            // fld_txtARRemindName
            // 
            this.fld_txtARRemindName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindName.BOSDataMember = "ARRemindName";
            this.fld_txtARRemindName.BOSDataSource = "ARReminds";
            this.fld_txtARRemindName.BOSDescription = null;
            this.fld_txtARRemindName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindName.BOSPropertyName = "Text";
            this.fld_txtARRemindName.Location = new System.Drawing.Point(106, 51);
            this.fld_txtARRemindName.Name = "fld_txtARRemindName";
            this.fld_txtARRemindName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARRemindName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARRemindName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARRemindName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARRemindName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARRemindName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARRemindName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARRemindName, true);
            this.fld_txtARRemindName.Size = new System.Drawing.Size(466, 20);
            this.fld_txtARRemindName.TabIndex = 1;
            this.fld_txtARRemindName.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(13, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(43, 13);
            this.bosLabel2.TabIndex = 53;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Nội dung";
            // 
            // fld_txtARRemindNo
            // 
            this.fld_txtARRemindNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindNo.BOSDataMember = "ARRemindNo";
            this.fld_txtARRemindNo.BOSDataSource = "ARReminds";
            this.fld_txtARRemindNo.BOSDescription = null;
            this.fld_txtARRemindNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARRemindNo.BOSPropertyName = "Text";
            this.fld_txtARRemindNo.Location = new System.Drawing.Point(106, 25);
            this.fld_txtARRemindNo.Name = "fld_txtARRemindNo";
            this.fld_txtARRemindNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARRemindNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARRemindNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARRemindNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARRemindNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARRemindNo.Properties.ReadOnly = true;
            this.fld_txtARRemindNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARRemindNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARRemindNo, true);
            this.fld_txtARRemindNo.Size = new System.Drawing.Size(178, 20);
            this.fld_txtARRemindNo.TabIndex = 0;
            this.fld_txtARRemindNo.Tag = "DC";
            // 
            // fld_lblLabel35
            // 
            this.fld_lblLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel35.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel35.Appearance.Options.UseFont = true;
            this.fld_lblLabel35.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel35.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.BOSPropertyName = null;
            this.fld_lblLabel35.Location = new System.Drawing.Point(13, 28);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel35, true);
            this.fld_lblLabel35.Size = new System.Drawing.Size(15, 13);
            this.fld_lblLabel35.TabIndex = 40;
            this.fld_lblLabel35.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel35.Text = "Mã";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(301, 158);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel38.TabIndex = 41;
            this.fld_lblLabel38.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel38.Text = "Loại nhắc nhở";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseFont = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 54);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel48, true);
            this.fld_lblLabel48.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel48.TabIndex = 43;
            this.fld_lblLabel48.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel48.Text = "Tên nhắc nhở";
            // 
            // fld_lblLabel49
            // 
            this.fld_lblLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel49.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel49.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel49.Appearance.Options.UseFont = true;
            this.fld_lblLabel49.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel49.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel49.BOSPropertyName = null;
            this.fld_lblLabel49.Location = new System.Drawing.Point(13, 106);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel49, true);
            this.fld_lblLabel49.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel49.TabIndex = 44;
            this.fld_lblLabel49.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcARRemindsGridControl);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 255);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(857, 342);
            this.bosGroupControl2.TabIndex = 3;
            this.bosGroupControl2.Text = "Danh sách nhắc nhở";
            // 
            // fld_dgcARRemindsGridControl
            // 
            this.fld_dgcARRemindsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRemindsGridControl.BOSComment = null;
            this.fld_dgcARRemindsGridControl.BOSDataMember = null;
            this.fld_dgcARRemindsGridControl.BOSDataSource = "ARReminds";
            this.fld_dgcARRemindsGridControl.BOSDescription = null;
            this.fld_dgcARRemindsGridControl.BOSError = null;
            this.fld_dgcARRemindsGridControl.BOSFieldGroup = null;
            this.fld_dgcARRemindsGridControl.BOSFieldRelation = null;
            this.fld_dgcARRemindsGridControl.BOSGridType = null;
            this.fld_dgcARRemindsGridControl.BOSPrivilege = null;
            this.fld_dgcARRemindsGridControl.BOSPropertyName = null;
            this.fld_dgcARRemindsGridControl.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcARRemindsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARRemindsGridControl.Name = "fld_dgcARRemindsGridControl";
            this.fld_dgcARRemindsGridControl.PrintReport = false;
            this.fld_dgcARRemindsGridControl.Screen = null;
            this.fld_dgcARRemindsGridControl.Size = new System.Drawing.Size(847, 312);
            this.fld_dgcARRemindsGridControl.TabIndex = 0;
            // 
            // fld_btnAddRemind
            // 
            this.fld_btnAddRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddRemind.BOSComment = null;
            this.fld_btnAddRemind.BOSDataMember = null;
            this.fld_btnAddRemind.BOSDataSource = null;
            this.fld_btnAddRemind.BOSDescription = null;
            this.fld_btnAddRemind.BOSError = null;
            this.fld_btnAddRemind.BOSFieldGroup = null;
            this.fld_btnAddRemind.BOSFieldRelation = null;
            this.fld_btnAddRemind.BOSPrivilege = null;
            this.fld_btnAddRemind.BOSPropertyName = null;
            this.fld_btnAddRemind.Location = new System.Drawing.Point(613, 222);
            this.fld_btnAddRemind.Name = "fld_btnAddRemind";
            this.fld_btnAddRemind.Screen = null;
            this.fld_btnAddRemind.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddRemind.TabIndex = 0;
            this.fld_btnAddRemind.Text = "Thêm";
            this.fld_btnAddRemind.Click += new System.EventHandler(this.fld_btnAddRemind_Click);
            // 
            // fld_btnDeleteRemind
            // 
            this.fld_btnDeleteRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDeleteRemind.BOSComment = null;
            this.fld_btnDeleteRemind.BOSDataMember = null;
            this.fld_btnDeleteRemind.BOSDataSource = null;
            this.fld_btnDeleteRemind.BOSDescription = null;
            this.fld_btnDeleteRemind.BOSError = null;
            this.fld_btnDeleteRemind.BOSFieldGroup = null;
            this.fld_btnDeleteRemind.BOSFieldRelation = null;
            this.fld_btnDeleteRemind.BOSPrivilege = null;
            this.fld_btnDeleteRemind.BOSPropertyName = null;
            this.fld_btnDeleteRemind.Location = new System.Drawing.Point(775, 222);
            this.fld_btnDeleteRemind.Name = "fld_btnDeleteRemind";
            this.fld_btnDeleteRemind.Screen = null;
            this.fld_btnDeleteRemind.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteRemind.TabIndex = 2;
            this.fld_btnDeleteRemind.Text = "Xóa";
            this.fld_btnDeleteRemind.Click += new System.EventHandler(this.fld_btnDeleteRemind_Click);
            // 
            // fld_btnEditRemind
            // 
            this.fld_btnEditRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEditRemind.BOSComment = null;
            this.fld_btnEditRemind.BOSDataMember = null;
            this.fld_btnEditRemind.BOSDataSource = null;
            this.fld_btnEditRemind.BOSDescription = null;
            this.fld_btnEditRemind.BOSError = null;
            this.fld_btnEditRemind.BOSFieldGroup = null;
            this.fld_btnEditRemind.BOSFieldRelation = null;
            this.fld_btnEditRemind.BOSPrivilege = null;
            this.fld_btnEditRemind.BOSPropertyName = null;
            this.fld_btnEditRemind.Location = new System.Drawing.Point(694, 222);
            this.fld_btnEditRemind.Name = "fld_btnEditRemind";
            this.fld_btnEditRemind.Screen = null;
            this.fld_btnEditRemind.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEditRemind.TabIndex = 1;
            this.fld_btnEditRemind.Text = "Sửa";
            this.fld_btnEditRemind.Click += new System.EventHandler(this.fld_btnEditRemind_Click);
            // 
            // DMCU104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCU104";
            this.Text = "Danh sách Reminder";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRemindStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRemindType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpARRemindDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpARRemindDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARRemindDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRemindName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRemindNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRemindsGridControl)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton fld_btnAddRemind;
        private BOSComponent.BOSButton fld_btnDeleteRemind;
        private BOSComponent.BOSButton fld_btnEditRemind;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtARRemindName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARRemindNo;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medARRemindDesc;
        private BOSComponent.BOSDateEdit fld_dtpARRemindDate;
        private BOSComponent.BOSLookupEdit fld_lkeARRemindType;
        private BOSComponent.BOSLookupEdit fld_lkeARRemindStatus;
        private ARRemindGridControl fld_dgcARRemindsGridControl;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
    }
}
