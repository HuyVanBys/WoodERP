using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRAllowance.UI
{
	/// <summary>
	/// Summary description for DMHRAL100
	/// </summary>
	partial class DMHRAL100
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
            this.fld_lkeHRAllowanceType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAllowanceContdifference = new BOSComponent.BOSTextBox(this.components);
            this.bosCheckEdit2 = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeAllowances = new BOSERP.Modules.HRAllowance.HREmployeeAllowancesGridControl();
            this.fld_dgvHREmployeeAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_btnDelete = new BOSComponent.BOSButton(this.components);
            this.fld_txtHRAllowanceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAllowanceName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRAllowanceFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHRAllowanceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRAllowanceToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRAllowanceOption = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRAllowanceValue = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAllowanceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceContdifference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAllowanceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAllowanceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAllowanceOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceValue.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeHRAllowanceType);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRAllowanceContdifference);
            this.bosPanel1.Controls.Add(this.bosCheckEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosCheckEdit1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_txtHRAllowanceNo);
            this.bosPanel1.Controls.Add(this.fld_txtAllowanceName);
            this.bosPanel1.Controls.Add(this.fld_dteHRAllowanceFromDate);
            this.bosPanel1.Controls.Add(this.fld_medHRAllowanceDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRAllowanceToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRAllowanceOption);
            this.bosPanel1.Controls.Add(this.fld_txtHRAllowanceValue);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(892, 610);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeHRAllowanceType
            // 
            this.fld_lkeHRAllowanceType.BOSAllowAddNew = false;
            this.fld_lkeHRAllowanceType.BOSAllowDummy = false;
            this.fld_lkeHRAllowanceType.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSDataMember = "HRAllowanceType";
            this.fld_lkeHRAllowanceType.BOSDataSource = "HRAllowances";
            this.fld_lkeHRAllowanceType.BOSDescription = null;
            this.fld_lkeHRAllowanceType.BOSError = null;
            this.fld_lkeHRAllowanceType.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSPropertyName = "EditValue";
            this.fld_lkeHRAllowanceType.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.CurrentDisplayText = null;
            this.fld_lkeHRAllowanceType.Location = new System.Drawing.Point(111, 103);
            this.fld_lkeHRAllowanceType.Name = "fld_lkeHRAllowanceType";
            this.fld_lkeHRAllowanceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRAllowanceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRAllowanceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAllowanceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRAllowanceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAllowanceType.Properties.ColumnName = null;
            this.fld_lkeHRAllowanceType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Hình thức")});
            this.fld_lkeHRAllowanceType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeHRAllowanceType.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAllowanceType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeHRAllowanceType.Screen = null;
            this.fld_lkeHRAllowanceType.Size = new System.Drawing.Size(234, 20);
            this.fld_lkeHRAllowanceType.TabIndex = 5;
            this.fld_lkeHRAllowanceType.Tag = "DC";
            this.fld_lkeHRAllowanceType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRAllowanceType_QueryPopUp);
            this.fld_lkeHRAllowanceType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeHRAllowanceType_CloseUp);
            this.fld_lkeHRAllowanceType.Validated += new System.EventHandler(this.fld_lkeHRAllowanceType_Validated);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(13, 184);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(92, 13);
            this.bosLabel3.TabIndex = 74;
            this.bosLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Text = "Số công chênh lệch";
            // 
            // fld_txtHRAllowanceContdifference
            // 
            this.fld_txtHRAllowanceContdifference.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceContdifference.BOSDataMember = "HRAllowanceContdifference";
            this.fld_txtHRAllowanceContdifference.BOSDataSource = "HRAllowances";
            this.fld_txtHRAllowanceContdifference.BOSDescription = null;
            this.fld_txtHRAllowanceContdifference.BOSError = null;
            this.fld_txtHRAllowanceContdifference.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceContdifference.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceContdifference.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceContdifference.BOSPropertyName = "Text";
            this.fld_txtHRAllowanceContdifference.EditValue = "";
            this.fld_txtHRAllowanceContdifference.Location = new System.Drawing.Point(111, 181);
            this.fld_txtHRAllowanceContdifference.Name = "fld_txtHRAllowanceContdifference";
            this.fld_txtHRAllowanceContdifference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAllowanceContdifference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAllowanceContdifference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAllowanceContdifference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAllowanceContdifference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAllowanceContdifference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAllowanceContdifference.Screen = null;
            this.fld_txtHRAllowanceContdifference.Size = new System.Drawing.Size(234, 20);
            this.fld_txtHRAllowanceContdifference.TabIndex = 9;
            this.fld_txtHRAllowanceContdifference.Tag = "DC";
            // 
            // bosCheckEdit2
            // 
            this.bosCheckEdit2.BOSComment = null;
            this.bosCheckEdit2.BOSDataMember = "HRAllowancePlusHoliday";
            this.bosCheckEdit2.BOSDataSource = "HRAllowances";
            this.bosCheckEdit2.BOSDescription = null;
            this.bosCheckEdit2.BOSError = null;
            this.bosCheckEdit2.BOSFieldGroup = null;
            this.bosCheckEdit2.BOSFieldRelation = null;
            this.bosCheckEdit2.BOSPrivilege = null;
            this.bosCheckEdit2.BOSPropertyName = "EditValue";
            this.bosCheckEdit2.Location = new System.Drawing.Point(529, 181);
            this.bosCheckEdit2.Name = "bosCheckEdit2";
            this.bosCheckEdit2.Properties.Caption = "Cộng ngày nghĩ phép & ngày lễ";
            this.bosCheckEdit2.Screen = null;
            this.bosCheckEdit2.Size = new System.Drawing.Size(195, 19);
            this.bosCheckEdit2.TabIndex = 11;
            this.bosCheckEdit2.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Location = new System.Drawing.Point(13, 158);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 70;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Số tiền";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSDataMember = "HRAllowanceConfigValue";
            this.bosTextBox1.BOSDataSource = "HRAllowances";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(111, 155);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.DisplayFormat.FormatString = "n0";
            this.bosTextBox1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox1.Properties.EditFormat.FormatString = "n0";
            this.bosTextBox1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox1.Properties.Mask.EditMask = "n0";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(600, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.Validated += new System.EventHandler(this.bosTextBox1_Validated);
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = "HRAllowanceByWorkDay";
            this.bosCheckEdit1.BOSDataSource = "HRAllowances";
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = "EditValue";
            this.bosCheckEdit1.Location = new System.Drawing.Point(394, 181);
            this.bosCheckEdit1.MenuManager = this.screenToolbar;
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Theo ngày công";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(117, 19);
            this.bosCheckEdit1.TabIndex = 10;
            this.bosCheckEdit1.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(13, 7);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel2.TabIndex = 52;
            this.fld_lblLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Text = "Mã phụ cấp";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(395, 105);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(60, 13);
            this.bosLabel1.TabIndex = 54;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Loại phụ cấp";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.Location = new System.Drawing.Point(396, 7);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel3.TabIndex = 53;
            this.fld_lblLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.Text = "Tên phụ cấp";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Location = new System.Drawing.Point(13, 45);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 55;
            this.fld_lblLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 76);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 56;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(413, 79);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel6.TabIndex = 57;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Kỳ lương";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.Location = new System.Drawing.Point(13, 105);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel7.TabIndex = 58;
            this.fld_lblLabel7.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.Text = "Hình thức";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Location = new System.Drawing.Point(13, 132);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(34, 13);
            this.fld_lblLabel8.TabIndex = 59;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Chi tiết";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcHREmployeeAllowances);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnAdd);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDelete);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(4, 211);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(885, 396);
            this.fld_grcGroupControl.TabIndex = 12;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Danh sách nhân viên được phụ cấp";
            // 
            // fld_dgcHREmployeeAllowances
            // 
            this.fld_dgcHREmployeeAllowances.AllowDrop = true;
            this.fld_dgcHREmployeeAllowances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeAllowances.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.BOSDataSource = "HREmployeeAllowances";
            this.fld_dgcHREmployeeAllowances.BOSDescription = null;
            this.fld_dgcHREmployeeAllowances.BOSError = null;
            this.fld_dgcHREmployeeAllowances.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.BOSGridType = null;
            this.fld_dgcHREmployeeAllowances.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeAllowances.CommodityType = "";
            this.fld_dgcHREmployeeAllowances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeAllowances.Location = new System.Drawing.Point(5, 63);
            this.fld_dgcHREmployeeAllowances.MainView = this.fld_dgvHREmployeeAllowances;
            this.fld_dgcHREmployeeAllowances.Name = "fld_dgcHREmployeeAllowances";
            this.fld_dgcHREmployeeAllowances.PrintReport = false;
            this.fld_dgcHREmployeeAllowances.Screen = null;
            this.fld_dgcHREmployeeAllowances.Size = new System.Drawing.Size(875, 328);
            this.fld_dgcHREmployeeAllowances.TabIndex = 2;
            this.fld_dgcHREmployeeAllowances.Tag = "DC";
            this.fld_dgcHREmployeeAllowances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAllowances});
            // 
            // fld_dgvHREmployeeAllowances
            // 
            this.fld_dgvHREmployeeAllowances.GridControl = this.fld_dgcHREmployeeAllowances;
            this.fld_dgvHREmployeeAllowances.Name = "fld_dgvHREmployeeAllowances";
            this.fld_dgvHREmployeeAllowances.PaintStyleName = "Office2003";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAdd.Appearance.Options.UseForeColor = true;
            this.fld_btnAdd.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Location = new System.Drawing.Point(5, 25);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(106, 27);
            this.fld_btnAdd.TabIndex = 0;
            this.fld_btnAdd.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Text = "Thêm nhân viên";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_btnDelete
            // 
            this.fld_btnDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDelete.Appearance.Options.UseForeColor = true;
            this.fld_btnDelete.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSDescription = null;
            this.fld_btnDelete.BOSError = null;
            this.fld_btnDelete.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.Location = new System.Drawing.Point(117, 25);
            this.fld_btnDelete.Name = "fld_btnDelete";
            this.fld_btnDelete.Screen = null;
            this.fld_btnDelete.Size = new System.Drawing.Size(115, 27);
            this.fld_btnDelete.TabIndex = 1;
            this.fld_btnDelete.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnDelete.Text = "Xóa nhân viên";
            this.fld_btnDelete.Click += new System.EventHandler(this.fld_btnDelete_Click);
            // 
            // fld_txtHRAllowanceNo
            // 
            this.fld_txtHRAllowanceNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSDataMember = "HRAllowanceNo";
            this.fld_txtHRAllowanceNo.BOSDataSource = "HRAllowances";
            this.fld_txtHRAllowanceNo.BOSDescription = null;
            this.fld_txtHRAllowanceNo.BOSError = null;
            this.fld_txtHRAllowanceNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSPropertyName = "Text";
            this.fld_txtHRAllowanceNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.Location = new System.Drawing.Point(111, 4);
            this.fld_txtHRAllowanceNo.Name = "fld_txtHRAllowanceNo";
            this.fld_txtHRAllowanceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAllowanceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAllowanceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAllowanceNo.Screen = null;
            this.fld_txtHRAllowanceNo.Size = new System.Drawing.Size(234, 20);
            this.fld_txtHRAllowanceNo.TabIndex = 0;
            this.fld_txtHRAllowanceNo.Tag = "DC";
            // 
            // fld_txtAllowanceName
            // 
            this.fld_txtAllowanceName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSDataMember = "HRAllowanceName";
            this.fld_txtAllowanceName.BOSDataSource = "HRAllowances";
            this.fld_txtAllowanceName.BOSDescription = null;
            this.fld_txtAllowanceName.BOSError = null;
            this.fld_txtAllowanceName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSPropertyName = "Text";
            this.fld_txtAllowanceName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.Location = new System.Drawing.Point(468, 4);
            this.fld_txtAllowanceName.Name = "fld_txtAllowanceName";
            this.fld_txtAllowanceName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAllowanceName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAllowanceName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAllowanceName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAllowanceName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAllowanceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAllowanceName.Screen = null;
            this.fld_txtAllowanceName.Size = new System.Drawing.Size(243, 20);
            this.fld_txtAllowanceName.TabIndex = 1;
            this.fld_txtAllowanceName.Tag = "DC";
            // 
            // fld_dteHRAllowanceFromDate
            // 
            this.fld_dteHRAllowanceFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceFromDate.BOSDataMember = "HRAllowanceFromDate";
            this.fld_dteHRAllowanceFromDate.BOSDataSource = "HRAllowances";
            this.fld_dteHRAllowanceFromDate.BOSDescription = null;
            this.fld_dteHRAllowanceFromDate.BOSError = null;
            this.fld_dteHRAllowanceFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAllowanceFromDate.EditValue = null;
            this.fld_dteHRAllowanceFromDate.Location = new System.Drawing.Point(111, 76);
            this.fld_dteHRAllowanceFromDate.Name = "fld_dteHRAllowanceFromDate";
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAllowanceFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAllowanceFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAllowanceFromDate.Screen = null;
            this.fld_dteHRAllowanceFromDate.Size = new System.Drawing.Size(234, 20);
            this.fld_dteHRAllowanceFromDate.TabIndex = 3;
            this.fld_dteHRAllowanceFromDate.Tag = "DC";
            // 
            // fld_medHRAllowanceDesc
            // 
            this.fld_medHRAllowanceDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAllowanceDesc.BOSDataMember = "HRAllowanceDesc";
            this.fld_medHRAllowanceDesc.BOSDataSource = "HRAllowances";
            this.fld_medHRAllowanceDesc.BOSDescription = null;
            this.fld_medHRAllowanceDesc.BOSError = null;
            this.fld_medHRAllowanceDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAllowanceDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAllowanceDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAllowanceDesc.BOSPropertyName = "Text";
            this.fld_medHRAllowanceDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAllowanceDesc.Location = new System.Drawing.Point(111, 30);
            this.fld_medHRAllowanceDesc.Name = "fld_medHRAllowanceDesc";
            this.fld_medHRAllowanceDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRAllowanceDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRAllowanceDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRAllowanceDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRAllowanceDesc.Screen = null;
            this.fld_medHRAllowanceDesc.Size = new System.Drawing.Size(600, 40);
            this.fld_medHRAllowanceDesc.TabIndex = 2;
            this.fld_medHRAllowanceDesc.Tag = "DC";
            // 
            // fld_dteHRAllowanceToDate
            // 
            this.fld_dteHRAllowanceToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceToDate.BOSDataMember = "HRAllowanceToDate";
            this.fld_dteHRAllowanceToDate.BOSDataSource = "HRAllowances";
            this.fld_dteHRAllowanceToDate.BOSDescription = null;
            this.fld_dteHRAllowanceToDate.BOSError = null;
            this.fld_dteHRAllowanceToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAllowanceToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAllowanceToDate.EditValue = null;
            this.fld_dteHRAllowanceToDate.Location = new System.Drawing.Point(468, 76);
            this.fld_dteHRAllowanceToDate.Name = "fld_dteHRAllowanceToDate";
            this.fld_dteHRAllowanceToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAllowanceToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAllowanceToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAllowanceToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAllowanceToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAllowanceToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAllowanceToDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRAllowanceToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRAllowanceToDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRAllowanceToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRAllowanceToDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRAllowanceToDate.Screen = null;
            this.fld_dteHRAllowanceToDate.Size = new System.Drawing.Size(243, 20);
            this.fld_dteHRAllowanceToDate.TabIndex = 4;
            this.fld_dteHRAllowanceToDate.Tag = "DC";
            // 
            // fld_lkeHRAllowanceOption
            // 
            this.fld_lkeHRAllowanceOption.BOSAllowAddNew = false;
            this.fld_lkeHRAllowanceOption.BOSAllowDummy = false;
            this.fld_lkeHRAllowanceOption.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSDataMember = "HRAllowanceOption";
            this.fld_lkeHRAllowanceOption.BOSDataSource = "HRAllowances";
            this.fld_lkeHRAllowanceOption.BOSDescription = null;
            this.fld_lkeHRAllowanceOption.BOSError = null;
            this.fld_lkeHRAllowanceOption.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSPropertyName = "EditValue";
            this.fld_lkeHRAllowanceOption.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.CurrentDisplayText = null;
            this.fld_lkeHRAllowanceOption.Location = new System.Drawing.Point(468, 103);
            this.fld_lkeHRAllowanceOption.Name = "fld_lkeHRAllowanceOption";
            this.fld_lkeHRAllowanceOption.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRAllowanceOption.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRAllowanceOption.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAllowanceOption.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRAllowanceOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAllowanceOption.Properties.ColumnName = null;
            this.fld_lkeHRAllowanceOption.Properties.DisplayMember = "HRDisciplineOption";
            this.fld_lkeHRAllowanceOption.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAllowanceOption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAllowanceOption.Properties.ValueMember = "HRDisciplineOption";
            this.fld_lkeHRAllowanceOption.Screen = null;
            this.fld_lkeHRAllowanceOption.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeHRAllowanceOption.TabIndex = 6;
            this.fld_lkeHRAllowanceOption.Tag = "DC";
            // 
            // fld_txtHRAllowanceValue
            // 
            this.fld_txtHRAllowanceValue.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceValue.BOSDataMember = "HRAllowanceValue";
            this.fld_txtHRAllowanceValue.BOSDataSource = "HRAllowances";
            this.fld_txtHRAllowanceValue.BOSDescription = null;
            this.fld_txtHRAllowanceValue.BOSError = null;
            this.fld_txtHRAllowanceValue.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceValue.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceValue.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceValue.BOSPropertyName = "Text";
            this.fld_txtHRAllowanceValue.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceValue.Location = new System.Drawing.Point(111, 129);
            this.fld_txtHRAllowanceValue.Name = "fld_txtHRAllowanceValue";
            this.fld_txtHRAllowanceValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAllowanceValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAllowanceValue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAllowanceValue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAllowanceValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAllowanceValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAllowanceValue.Screen = null;
            this.fld_txtHRAllowanceValue.Size = new System.Drawing.Size(600, 20);
            this.fld_txtHRAllowanceValue.TabIndex = 7;
            this.fld_txtHRAllowanceValue.Tag = "DC";
            this.fld_txtHRAllowanceValue.Validated += new System.EventHandler(this.fld_txtHRAllowanceValue_Validated);
            // 
            // DMHRAL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(892, 610);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRAL100";
            this.Text = "Chi tiết phụ cấp";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAllowanceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceContdifference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAllowanceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAllowanceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAllowanceOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private HREmployeeAllowancesGridControl fld_dgcHREmployeeAllowances;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAllowances;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSButton fld_btnDelete;
        private BOSComponent.BOSTextBox fld_txtHRAllowanceNo;
        private BOSComponent.BOSTextBox fld_txtAllowanceName;
        private BOSComponent.BOSDateEdit fld_dteHRAllowanceFromDate;
        private BOSComponent.BOSMemoEdit fld_medHRAllowanceDesc;
        private BOSComponent.BOSDateEdit fld_dteHRAllowanceToDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRAllowanceOption;
        private BOSComponent.BOSTextBox fld_txtHRAllowanceValue;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtHRAllowanceContdifference;
        private BOSComponent.BOSCheckEdit bosCheckEdit2;
        private BOSComponent.BOSLookupEdit fld_lkeHRAllowanceType;
    }
}
