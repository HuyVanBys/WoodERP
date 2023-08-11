using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeeTransmit.UI
{
	/// <summary>
    /// Summary description for SMHET100
	/// </summary>
    partial class SMHET100
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
            this.fld_dgcHREmployeeTransmits = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTransmitNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromHREmployeeTransmitDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHREmployeeTransmitDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTransmits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeTransmitDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeTransmitDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeTransmitDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeTransmitDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHREmployeeTransmits
            // 
            this.fld_dgcHREmployeeTransmits.BOSComment = null;
            this.fld_dgcHREmployeeTransmits.BOSDataMember = null;
            this.fld_dgcHREmployeeTransmits.BOSDataSource = "HREmployeeTransmits";
            this.fld_dgcHREmployeeTransmits.BOSDescription = null;
            this.fld_dgcHREmployeeTransmits.BOSError = null;
            this.fld_dgcHREmployeeTransmits.BOSFieldGroup = null;
            this.fld_dgcHREmployeeTransmits.BOSFieldRelation = null;
            this.fld_dgcHREmployeeTransmits.BOSPrivilege = null;
            this.fld_dgcHREmployeeTransmits.BOSPropertyName = null;
            this.fld_dgcHREmployeeTransmits.Location = new System.Drawing.Point(38, 185);
            this.fld_dgcHREmployeeTransmits.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeTransmits.Name = "fld_dgcHREmployeeTransmits";
            this.fld_dgcHREmployeeTransmits.Screen = null;
            this.fld_dgcHREmployeeTransmits.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHREmployeeTransmits.TabIndex = 101;
            this.fld_dgcHREmployeeTransmits.Tag = "SR";
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
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(38, 29);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 99;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtHREmployeeTransmitNo
            // 
            this.fld_txtHREmployeeTransmitNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeeTransmitNo.BOSDataMember = "HREmployeeTransmitNo";
            this.fld_txtHREmployeeTransmitNo.BOSDataSource = "HREmployeeTransmits";
            this.fld_txtHREmployeeTransmitNo.BOSDescription = null;
            this.fld_txtHREmployeeTransmitNo.BOSError = null;
            this.fld_txtHREmployeeTransmitNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeeTransmitNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeeTransmitNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeeTransmitNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTransmitNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeeTransmitNo.Location = new System.Drawing.Point(123, 26);
            this.fld_txtHREmployeeTransmitNo.Name = "fld_txtHREmployeeTransmitNo";
            this.fld_txtHREmployeeTransmitNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTransmitNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTransmitNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTransmitNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTransmitNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTransmitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTransmitNo.Screen = null;
            this.fld_txtHREmployeeTransmitNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTransmitNo.TabIndex = 97;
            this.fld_txtHREmployeeTransmitNo.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(38, 55);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 103;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HREmployeeTransmits";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(123, 52);
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
            this.fld_lkeFK_BRBranchID.TabIndex = 102;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_dteSearchFromHREmployeeTransmitDate
            // 
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSDataMember = "HREmployeeTransmitDate";
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSDataSource = "HREmployeeTransmits";
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSDescription = null;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSError = null;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeeTransmitDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHREmployeeTransmitDate.EditValue = null;
            this.fld_dteSearchFromHREmployeeTransmitDate.Location = new System.Drawing.Point(123, 78);
            this.fld_dteSearchFromHREmployeeTransmitDate.Name = "fld_dteSearchFromHREmployeeTransmitDate";
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHREmployeeTransmitDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHREmployeeTransmitDate.Screen = null;
            this.fld_dteSearchFromHREmployeeTransmitDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteSearchFromHREmployeeTransmitDate.TabIndex = 106;
            this.fld_dteSearchFromHREmployeeTransmitDate.Tag = "SC";
            // 
            // fld_dteSearchToHREmployeeTransmitDate
            // 
            this.fld_dteSearchToHREmployeeTransmitDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSDataMember = "HREmployeeTransmitDate";
            this.fld_dteSearchToHREmployeeTransmitDate.BOSDataSource = "HREmployeeTransmits";
            this.fld_dteSearchToHREmployeeTransmitDate.BOSDescription = null;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSError = null;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeeTransmitDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHREmployeeTransmitDate.EditValue = null;
            this.fld_dteSearchToHREmployeeTransmitDate.Location = new System.Drawing.Point(123, 102);
            this.fld_dteSearchToHREmployeeTransmitDate.Name = "fld_dteSearchToHREmployeeTransmitDate";
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHREmployeeTransmitDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHREmployeeTransmitDate.Screen = null;
            this.fld_dteSearchToHREmployeeTransmitDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteSearchToHREmployeeTransmitDate.TabIndex = 107;
            this.fld_dteSearchToHREmployeeTransmitDate.Tag = "SC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(38, 81);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 108;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(38, 105);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 109;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // SMHET100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dteSearchFromHREmployeeTransmitDate);
            this.Controls.Add(this.fld_dteSearchToHREmployeeTransmitDate);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHREmployeeTransmits);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHREmployeeTransmitNo);
            this.Name = "SMHET100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHREmployeeTransmitNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployeeTransmits, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHREmployeeTransmitDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHREmployeeTransmitDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTransmits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeTransmitDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeTransmitDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeTransmitDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeTransmitDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHREmployeeTransmits;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTransmitNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSDateEdit fld_dteSearchFromHREmployeeTransmitDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToHREmployeeTransmitDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
	}
}
