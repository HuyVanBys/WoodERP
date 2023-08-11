using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRDiscipline.UI
{
	/// <summary>
	/// Summary description for DMHRDL100
	/// </summary>
	partial class DMHRDL100
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
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRDisciplineToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeRequest = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDisciplineNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRDisciplineName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medHRDisciplineDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRDisciplineFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRDisciplineOption = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRDisciplineType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRDisciplineNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRDisciplineValue = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeDisciplines = new BOSERP.Modules.HRDiscipline.HREmployeeDisciplinesGridControl();
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_btnDelete = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDisciplineDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDisciplineOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDisciplineType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteHRDisciplineToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeRequest);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRDisciplineNo1);
            this.bosPanel1.Controls.Add(this.fld_txtHRDisciplineName1);
            this.bosPanel1.Controls.Add(this.bosMemoEdit1);
            this.bosPanel1.Controls.Add(this.fld_medHRDisciplineDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRDisciplineFromDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDisciplineOption);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDisciplineType);
            this.bosPanel1.Controls.Add(this.fld_txtHRDisciplineNumber);
            this.bosPanel1.Controls.Add(this.fld_txtHRDisciplineValue);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(868, 574);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Location = new System.Drawing.Point(375, 84);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(42, 13);
            this.bosLabel4.TabIndex = 56;
            this.bosLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Text = "Kỳ lương";
            // 
            // fld_dteHRDisciplineToDate
            // 
            this.fld_dteHRDisciplineToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineToDate.BOSDataMember = "HRDisciplineToDate";
            this.fld_dteHRDisciplineToDate.BOSDataSource = "HRDisciplines";
            this.fld_dteHRDisciplineToDate.BOSDescription = null;
            this.fld_dteHRDisciplineToDate.BOSError = null;
            this.fld_dteHRDisciplineToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRDisciplineToDate.EditValue = null;
            this.fld_dteHRDisciplineToDate.Location = new System.Drawing.Point(428, 81);
            this.fld_dteHRDisciplineToDate.Name = "fld_dteHRDisciplineToDate";
            this.fld_dteHRDisciplineToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRDisciplineToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRDisciplineToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRDisciplineToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRDisciplineToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRDisciplineToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRDisciplineToDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRDisciplineToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRDisciplineToDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRDisciplineToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRDisciplineToDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRDisciplineToDate.Screen = null;
            this.fld_dteHRDisciplineToDate.Size = new System.Drawing.Size(243, 20);
            this.fld_dteHRDisciplineToDate.TabIndex = 4;
            this.fld_dteHRDisciplineToDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeRequest
            // 
            this.fld_lkeFK_HREmployeeRequest.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeRequest.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeRequest.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSDataMember = "FK_HREmployeeRequest";
            this.fld_lkeFK_HREmployeeRequest.BOSDataSource = "HRDisciplines";
            this.fld_lkeFK_HREmployeeRequest.BOSDescription = null;
            this.fld_lkeFK_HREmployeeRequest.BOSError = null;
            this.fld_lkeFK_HREmployeeRequest.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeRequest.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.CurrentDisplayText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.Location = new System.Drawing.Point(90, 107);
            this.fld_lkeFK_HREmployeeRequest.Name = "fld_lkeFK_HREmployeeRequest";
            this.fld_lkeFK_HREmployeeRequest.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeRequest.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeRequest.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeRequest.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeRequest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeRequest.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeRequest.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeRequest.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeRequest.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HREmployeeRequest.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeRequest.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeRequest.Screen = null;
            this.fld_lkeFK_HREmployeeRequest.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeFK_HREmployeeRequest.TabIndex = 5;
            this.fld_lkeFK_HREmployeeRequest.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel2.TabIndex = 36;
            this.fld_lblLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Text = "Mã kỷ luật";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 136);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(54, 13);
            this.bosLabel1.TabIndex = 37;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Loại kỷ luật";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(346, 12);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel3.TabIndex = 38;
            this.fld_lblLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.Text = "Nhóm biên bản";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 200);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(42, 13);
            this.bosLabel3.TabIndex = 40;
            this.bosLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Text = "Giải trình";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 39;
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(12, 84);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 41;
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 110);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel6.TabIndex = 42;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Người yêu cầu";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(371, 110);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel7.TabIndex = 43;
            this.fld_lblLabel7.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.Text = "Hình thức";
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
            this.bosLabel2.Location = new System.Drawing.Point(361, 136);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(56, 13);
            this.bosLabel2.TabIndex = 45;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Số biên bản";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 162);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(34, 13);
            this.fld_lblLabel8.TabIndex = 44;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Chi tiết";
            // 
            // fld_txtHRDisciplineNo1
            // 
            this.fld_txtHRDisciplineNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo1.BOSDataMember = "HRDisciplineNo";
            this.fld_txtHRDisciplineNo1.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineNo1.BOSDescription = null;
            this.fld_txtHRDisciplineNo1.BOSError = null;
            this.fld_txtHRDisciplineNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo1.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineNo1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo1.Location = new System.Drawing.Point(90, 9);
            this.fld_txtHRDisciplineNo1.Name = "fld_txtHRDisciplineNo1";
            this.fld_txtHRDisciplineNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineNo1.Screen = null;
            this.fld_txtHRDisciplineNo1.Size = new System.Drawing.Size(215, 20);
            this.fld_txtHRDisciplineNo1.TabIndex = 0;
            this.fld_txtHRDisciplineNo1.Tag = "DC";
            // 
            // fld_txtHRDisciplineName1
            // 
            this.fld_txtHRDisciplineName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName1.BOSDataMember = "HRDisciplineName";
            this.fld_txtHRDisciplineName1.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineName1.BOSDescription = null;
            this.fld_txtHRDisciplineName1.BOSError = null;
            this.fld_txtHRDisciplineName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName1.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineName1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName1.Location = new System.Drawing.Point(428, 9);
            this.fld_txtHRDisciplineName1.Name = "fld_txtHRDisciplineName1";
            this.fld_txtHRDisciplineName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineName1.Screen = null;
            this.fld_txtHRDisciplineName1.Size = new System.Drawing.Size(243, 20);
            this.fld_txtHRDisciplineName1.TabIndex = 1;
            this.fld_txtHRDisciplineName1.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSDataMember = "HRDisciplineExplain";
            this.bosMemoEdit1.BOSDataSource = "HRDisciplines";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.Location = new System.Drawing.Point(90, 185);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(581, 78);
            this.bosMemoEdit1.TabIndex = 10;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_medHRDisciplineDesc
            // 
            this.fld_medHRDisciplineDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRDisciplineDesc.BOSDataMember = "HRDisciplineDesc";
            this.fld_medHRDisciplineDesc.BOSDataSource = "HRDisciplines";
            this.fld_medHRDisciplineDesc.BOSDescription = null;
            this.fld_medHRDisciplineDesc.BOSError = null;
            this.fld_medHRDisciplineDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRDisciplineDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRDisciplineDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRDisciplineDesc.BOSPropertyName = "Text";
            this.fld_medHRDisciplineDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRDisciplineDesc.Location = new System.Drawing.Point(90, 35);
            this.fld_medHRDisciplineDesc.Name = "fld_medHRDisciplineDesc";
            this.fld_medHRDisciplineDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRDisciplineDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRDisciplineDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRDisciplineDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRDisciplineDesc.Screen = null;
            this.fld_medHRDisciplineDesc.Size = new System.Drawing.Size(581, 40);
            this.fld_medHRDisciplineDesc.TabIndex = 2;
            this.fld_medHRDisciplineDesc.Tag = "DC";
            // 
            // fld_dteHRDisciplineFromDate
            // 
            this.fld_dteHRDisciplineFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineFromDate.BOSDataMember = "HRDisciplineFromDate";
            this.fld_dteHRDisciplineFromDate.BOSDataSource = "HRDisciplines";
            this.fld_dteHRDisciplineFromDate.BOSDescription = null;
            this.fld_dteHRDisciplineFromDate.BOSError = null;
            this.fld_dteHRDisciplineFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRDisciplineFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRDisciplineFromDate.EditValue = null;
            this.fld_dteHRDisciplineFromDate.Location = new System.Drawing.Point(90, 81);
            this.fld_dteHRDisciplineFromDate.Name = "fld_dteHRDisciplineFromDate";
            this.fld_dteHRDisciplineFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRDisciplineFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRDisciplineFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRDisciplineFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRDisciplineFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRDisciplineFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRDisciplineFromDate.Screen = null;
            this.fld_dteHRDisciplineFromDate.Size = new System.Drawing.Size(215, 20);
            this.fld_dteHRDisciplineFromDate.TabIndex = 3;
            this.fld_dteHRDisciplineFromDate.Tag = "DC";
            // 
            // fld_lkeHRDisciplineOption
            // 
            this.fld_lkeHRDisciplineOption.BOSAllowAddNew = false;
            this.fld_lkeHRDisciplineOption.BOSAllowDummy = false;
            this.fld_lkeHRDisciplineOption.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSDataMember = "HRDisciplineOption";
            this.fld_lkeHRDisciplineOption.BOSDataSource = "HRDisciplines";
            this.fld_lkeHRDisciplineOption.BOSDescription = null;
            this.fld_lkeHRDisciplineOption.BOSError = null;
            this.fld_lkeHRDisciplineOption.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSPropertyName = "EditValue";
            this.fld_lkeHRDisciplineOption.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.CurrentDisplayText = null;
            this.fld_lkeHRDisciplineOption.Location = new System.Drawing.Point(90, 133);
            this.fld_lkeHRDisciplineOption.Name = "fld_lkeHRDisciplineOption";
            this.fld_lkeHRDisciplineOption.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDisciplineOption.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDisciplineOption.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDisciplineOption.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDisciplineOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDisciplineOption.Properties.ColumnName = null;
            this.fld_lkeHRDisciplineOption.Properties.DisplayMember = "HRDisciplineOption";
            this.fld_lkeHRDisciplineOption.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineOption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDisciplineOption.Properties.ValueMember = "HRDisciplineOption";
            this.fld_lkeHRDisciplineOption.Screen = null;
            this.fld_lkeHRDisciplineOption.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeHRDisciplineOption.TabIndex = 7;
            this.fld_lkeHRDisciplineOption.Tag = "DC";
            // 
            // fld_lkeHRDisciplineType
            // 
            this.fld_lkeHRDisciplineType.BOSAllowAddNew = false;
            this.fld_lkeHRDisciplineType.BOSAllowDummy = false;
            this.fld_lkeHRDisciplineType.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSDataMember = "HRDisciplineType";
            this.fld_lkeHRDisciplineType.BOSDataSource = "HRDisciplines";
            this.fld_lkeHRDisciplineType.BOSDescription = null;
            this.fld_lkeHRDisciplineType.BOSError = null;
            this.fld_lkeHRDisciplineType.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSPropertyName = "EditValue";
            this.fld_lkeHRDisciplineType.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.CurrentDisplayText = null;
            this.fld_lkeHRDisciplineType.Location = new System.Drawing.Point(428, 107);
            this.fld_lkeHRDisciplineType.Name = "fld_lkeHRDisciplineType";
            this.fld_lkeHRDisciplineType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDisciplineType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDisciplineType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDisciplineType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDisciplineType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDisciplineType.Properties.ColumnName = null;
            this.fld_lkeHRDisciplineType.Properties.DisplayMember = "HRDisciplineType";
            this.fld_lkeHRDisciplineType.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRDisciplineType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDisciplineType.Properties.ValueMember = "HRDisciplineType";
            this.fld_lkeHRDisciplineType.Screen = null;
            this.fld_lkeHRDisciplineType.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeHRDisciplineType.TabIndex = 6;
            this.fld_lkeHRDisciplineType.Tag = "DC";
            // 
            // fld_txtHRDisciplineNumber
            // 
            this.fld_txtHRDisciplineNumber.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNumber.BOSDataMember = "HRDisciplineNumber";
            this.fld_txtHRDisciplineNumber.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineNumber.BOSDescription = null;
            this.fld_txtHRDisciplineNumber.BOSError = null;
            this.fld_txtHRDisciplineNumber.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNumber.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNumber.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNumber.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineNumber.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNumber.Location = new System.Drawing.Point(428, 133);
            this.fld_txtHRDisciplineNumber.Name = "fld_txtHRDisciplineNumber";
            this.fld_txtHRDisciplineNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineNumber.Screen = null;
            this.fld_txtHRDisciplineNumber.Size = new System.Drawing.Size(243, 20);
            this.fld_txtHRDisciplineNumber.TabIndex = 8;
            this.fld_txtHRDisciplineNumber.Tag = "DC";
            this.fld_txtHRDisciplineNumber.Validated += new System.EventHandler(this.fld_txtHRDisciplineNumber_Validated);
            // 
            // fld_txtHRDisciplineValue
            // 
            this.fld_txtHRDisciplineValue.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineValue.BOSDataMember = "HRDisciplineValue";
            this.fld_txtHRDisciplineValue.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineValue.BOSDescription = null;
            this.fld_txtHRDisciplineValue.BOSError = null;
            this.fld_txtHRDisciplineValue.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineValue.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineValue.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineValue.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineValue.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineValue.Location = new System.Drawing.Point(90, 159);
            this.fld_txtHRDisciplineValue.Name = "fld_txtHRDisciplineValue";
            this.fld_txtHRDisciplineValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineValue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineValue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineValue.Screen = null;
            this.fld_txtHRDisciplineValue.Size = new System.Drawing.Size(215, 20);
            this.fld_txtHRDisciplineValue.TabIndex = 9;
            this.fld_txtHRDisciplineValue.Tag = "DC";
            this.fld_txtHRDisciplineValue.Validated += new System.EventHandler(this.fld_txtHRDisciplineValue_Validated_1);
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcHREmployeeDisciplines);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnAdd);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDelete);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 269);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(868, 305);
            this.fld_grcGroupControl.TabIndex = 11;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Danh sách nhân viên bị kỷ luật";
            // 
            // fld_dgcHREmployeeDisciplines
            // 
            this.fld_dgcHREmployeeDisciplines.AllowDrop = true;
            this.fld_dgcHREmployeeDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeDisciplines.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.BOSDataSource = "HREmployeeDisciplines";
            this.fld_dgcHREmployeeDisciplines.BOSDescription = null;
            this.fld_dgcHREmployeeDisciplines.BOSError = null;
            this.fld_dgcHREmployeeDisciplines.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.BOSGridType = null;
            this.fld_dgcHREmployeeDisciplines.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeDisciplines.CommodityType = "";
            this.fld_dgcHREmployeeDisciplines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeDisciplines.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcHREmployeeDisciplines.MainView = this.fld_dgvGridControl;
            this.fld_dgcHREmployeeDisciplines.Name = "fld_dgcHREmployeeDisciplines";
            this.fld_dgcHREmployeeDisciplines.PrintReport = false;
            this.fld_dgcHREmployeeDisciplines.Screen = null;
            this.fld_dgcHREmployeeDisciplines.Size = new System.Drawing.Size(868, 247);
            this.fld_dgcHREmployeeDisciplines.TabIndex = 2;
            this.fld_dgcHREmployeeDisciplines.Tag = "DC";
            this.fld_dgcHREmployeeDisciplines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHREmployeeDisciplines;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
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
            // DMHRDL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRDL100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDisciplineDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDisciplineFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDisciplineOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDisciplineType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private HREmployeeDisciplinesGridControl fld_dgcHREmployeeDisciplines;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSButton fld_btnDelete;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeRequest;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtHRDisciplineNo1;
        private BOSComponent.BOSTextBox fld_txtHRDisciplineName1;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSMemoEdit fld_medHRDisciplineDesc;
        private BOSComponent.BOSDateEdit fld_dteHRDisciplineFromDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRDisciplineOption;
        private BOSComponent.BOSLookupEdit fld_lkeHRDisciplineType;
        private BOSComponent.BOSTextBox fld_txtHRDisciplineNumber;
        private BOSComponent.BOSTextBox fld_txtHRDisciplineValue;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteHRDisciplineToDate;
	}
}
