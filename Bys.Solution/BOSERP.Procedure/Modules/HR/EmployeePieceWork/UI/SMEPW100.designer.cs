using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeePieceWork.UI
{
	/// <summary>
    /// Summary description for SMEPW100
	/// </summary>
    partial class SMEPW100
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
            this.fld_dgcHREmployeePieceWorks = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dteHREmployeePieceWorkFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREmployeePieceWorkToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeePieceWorkAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWorkQuantity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWorkNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_ilkFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ilkFK_ICProductID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHREmployeePieceWorks
            // 
            this.fld_dgcHREmployeePieceWorks.AllowDrop = true;
            this.fld_dgcHREmployeePieceWorks.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dgcHREmployeePieceWorks.BOSDescription = null;
            this.fld_dgcHREmployeePieceWorks.BOSError = null;
            this.fld_dgcHREmployeePieceWorks.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePieceWorks.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePieceWorks.Location = new System.Drawing.Point(29, 182);
            this.fld_dgcHREmployeePieceWorks.Name = "fld_dgcHREmployeePieceWorks";
            this.fld_dgcHREmployeePieceWorks.Screen = null;
            this.fld_dgcHREmployeePieceWorks.Size = new System.Drawing.Size(561, 272);
            this.fld_dgcHREmployeePieceWorks.TabIndex = 366;
            this.fld_dgcHREmployeePieceWorks.Tag = "SR";
            // 
            // fld_dteHREmployeePieceWorkFromDate
            // 
            this.fld_dteHREmployeePieceWorkFromDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSDataMember = "HREmployeePieceWorkFromDate";
            this.fld_dteHREmployeePieceWorkFromDate.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dteHREmployeePieceWorkFromDate.BOSDescription = null;
            this.fld_dteHREmployeePieceWorkFromDate.BOSError = null;
            this.fld_dteHREmployeePieceWorkFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePieceWorkFromDate.EditValue = null;
            this.fld_dteHREmployeePieceWorkFromDate.Location = new System.Drawing.Point(108, 143);
            this.fld_dteHREmployeePieceWorkFromDate.Name = "fld_dteHREmployeePieceWorkFromDate";
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePieceWorkFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeePieceWorkFromDate, true);
            this.fld_dteHREmployeePieceWorkFromDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteHREmployeePieceWorkFromDate.TabIndex = 377;
            this.fld_dteHREmployeePieceWorkFromDate.Tag = "SC";
            // 
            // fld_dteHREmployeePieceWorkToDate
            // 
            this.fld_dteHREmployeePieceWorkToDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSDataMember = "HREmployeePieceWorkToDate";
            this.fld_dteHREmployeePieceWorkToDate.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dteHREmployeePieceWorkToDate.BOSDescription = null;
            this.fld_dteHREmployeePieceWorkToDate.BOSError = null;
            this.fld_dteHREmployeePieceWorkToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePieceWorkToDate.EditValue = null;
            this.fld_dteHREmployeePieceWorkToDate.Location = new System.Drawing.Point(370, 143);
            this.fld_dteHREmployeePieceWorkToDate.Name = "fld_dteHREmployeePieceWorkToDate";
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePieceWorkToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePieceWorkToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeePieceWorkToDate, true);
            this.fld_dteHREmployeePieceWorkToDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteHREmployeePieceWorkToDate.TabIndex = 378;
            this.fld_dteHREmployeePieceWorkToDate.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(29, 146);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 381;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Từ ngày";
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
            this.bosLabel2.Location = new System.Drawing.Point(304, 146);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 380;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
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
            this.bosLabel1.Location = new System.Drawing.Point(29, 42);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 376;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Sản phẩm";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "HREmployeePieceWorks";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(108, 91);
            this.fld_lkeFK_MMOperationID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã công đoạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 373;
            this.fld_lkeFK_MMOperationID.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
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
            this.bosLabel4.Location = new System.Drawing.Point(29, 94);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 375;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Công đoạn";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(29, 120);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(50, 13);
            this.bosLabel6.TabIndex = 370;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Mức lương";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(29, 68);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(42, 13);
            this.bosLabel5.TabIndex = 371;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Số lượng";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(29, 16);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel4.TabIndex = 372;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã CH lương";
            // 
            // fld_txtHREmployeePieceWorkAmount
            // 
            this.fld_txtHREmployeePieceWorkAmount.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSDataMember = "HREmployeePieceWorkAmount";
            this.fld_txtHREmployeePieceWorkAmount.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkAmount.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkAmount.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkAmount.Location = new System.Drawing.Point(108, 117);
            this.fld_txtHREmployeePieceWorkAmount.Name = "fld_txtHREmployeePieceWorkAmount";
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkAmount.Screen = null;
            this.fld_txtHREmployeePieceWorkAmount.Size = new System.Drawing.Size(160, 20);
            this.fld_txtHREmployeePieceWorkAmount.TabIndex = 367;
            this.fld_txtHREmployeePieceWorkAmount.Tag = "SC";
            // 
            // fld_txtHREmployeePieceWorkQuantity
            // 
            this.fld_txtHREmployeePieceWorkQuantity.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSDataMember = "HREmployeePieceWorkQuantity";
            this.fld_txtHREmployeePieceWorkQuantity.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkQuantity.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkQuantity.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkQuantity.Location = new System.Drawing.Point(108, 65);
            this.fld_txtHREmployeePieceWorkQuantity.Name = "fld_txtHREmployeePieceWorkQuantity";
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkQuantity.Screen = null;
            this.fld_txtHREmployeePieceWorkQuantity.Size = new System.Drawing.Size(160, 20);
            this.fld_txtHREmployeePieceWorkQuantity.TabIndex = 368;
            this.fld_txtHREmployeePieceWorkQuantity.Tag = "SC";
            // 
            // fld_txtHREmployeePieceWorkNo
            // 
            this.fld_txtHREmployeePieceWorkNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSDataMember = "HREmployeePieceWorkNo";
            this.fld_txtHREmployeePieceWorkNo.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkNo.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkNo.Location = new System.Drawing.Point(108, 13);
            this.fld_txtHREmployeePieceWorkNo.Name = "fld_txtHREmployeePieceWorkNo";
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeePieceWorkNo, true);
            this.fld_txtHREmployeePieceWorkNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtHREmployeePieceWorkNo.TabIndex = 369;
            this.fld_txtHREmployeePieceWorkNo.Tag = "SC";
            // 
            // fld_ilkFK_ICProductID
            // 
            this.fld_ilkFK_ICProductID.BOSAllowAddNew = false;
            this.fld_ilkFK_ICProductID.BOSAllowDummy = false;
            this.fld_ilkFK_ICProductID.BOSComment = null;
            this.fld_ilkFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_ilkFK_ICProductID.BOSDataSource = "HREmployeePieceWorks";
            this.fld_ilkFK_ICProductID.BOSDescription = null;
            this.fld_ilkFK_ICProductID.BOSError = null;
            this.fld_ilkFK_ICProductID.BOSFieldGroup = null;
            this.fld_ilkFK_ICProductID.BOSFieldParent = null;
            this.fld_ilkFK_ICProductID.BOSFieldRelation = null;
            this.fld_ilkFK_ICProductID.BOSPrivilege = null;
            this.fld_ilkFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_ilkFK_ICProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_ilkFK_ICProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_ilkFK_ICProductID.CurrentDisplayText = null;
            this.fld_ilkFK_ICProductID.Location = new System.Drawing.Point(108, 39);
            this.fld_ilkFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_ilkFK_ICProductID.Name = "fld_ilkFK_ICProductID";
            this.fld_ilkFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ilkFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_ilkFK_ICProductID.Properties.ValueMember = "FK_ICProductID";
            this.fld_ilkFK_ICProductID.Screen = null;
            this.fld_ilkFK_ICProductID.Size = new System.Drawing.Size(160, 20);
            this.fld_ilkFK_ICProductID.TabIndex = 382;
            this.fld_ilkFK_ICProductID.Tag = "SC";
            // 
            // SMEPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(622, 567);
            this.Controls.Add(this.fld_ilkFK_ICProductID);
            this.Controls.Add(this.fld_dteHREmployeePieceWorkFromDate);
            this.Controls.Add(this.fld_dteHREmployeePieceWorkToDate);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_txtHREmployeePieceWorkAmount);
            this.Controls.Add(this.fld_txtHREmployeePieceWorkQuantity);
            this.Controls.Add(this.fld_txtHREmployeePieceWorkNo);
            this.Controls.Add(this.fld_dgcHREmployeePieceWorks);
            this.Name = "SMEPW100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHREmployeePieceWorks, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeePieceWorkNo, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeePieceWorkQuantity, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeePieceWorkAmount, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMOperationID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteHREmployeePieceWorkToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteHREmployeePieceWorkFromDate, 0);
            this.Controls.SetChildIndex(this.fld_ilkFK_ICProductID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ilkFK_ICProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHREmployeePieceWorks;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePieceWorkFromDate;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePieceWorkToDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkAmount;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkQuantity;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkNo;
        private ItemLookupEdit fld_ilkFK_ICProductID;
	}
}
