using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRLabouringConfig.UI
{
	/// <summary>
	/// Summary description for SMHRLC100
	/// </summary>
	partial class SMHRLC100
    {
		private BOSSearchResultsGridControl fld_dgcHRLabouringConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRLabouringConfig;


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
            this.fld_dgcHRLabouringConfig = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRLabouringConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToHRLabouringConfigDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromHRLabouringConfigDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRLabouringConfigNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHRLabouringConfigDateType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLabouringConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLabouringConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRLabouringConfigDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRLabouringConfigDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRLabouringConfigDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRLabouringConfigDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLabouringConfigNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRLabouringConfig
            // 
            this.fld_dgcHRLabouringConfig.AllowDrop = true;
            this.fld_dgcHRLabouringConfig.BOSComment = "";
            this.fld_dgcHRLabouringConfig.BOSDataMember = "";
            this.fld_dgcHRLabouringConfig.BOSDataSource = "HRLabouringConfigs";
            this.fld_dgcHRLabouringConfig.BOSDescription = null;
            this.fld_dgcHRLabouringConfig.BOSError = null;
            this.fld_dgcHRLabouringConfig.BOSFieldGroup = "";
            this.fld_dgcHRLabouringConfig.BOSFieldRelation = "";
            this.fld_dgcHRLabouringConfig.BOSPrivilege = "";
            this.fld_dgcHRLabouringConfig.BOSPropertyName = "";
            this.fld_dgcHRLabouringConfig.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRLabouringConfig.Location = new System.Drawing.Point(10, 178);
            this.fld_dgcHRLabouringConfig.MainView = this.fld_dgvHRLabouringConfig;
            this.fld_dgcHRLabouringConfig.Name = "fld_dgcHRLabouringConfig";
            this.fld_dgcHRLabouringConfig.Screen = null;
            this.fld_dgcHRLabouringConfig.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRLabouringConfig.TabIndex = 13;
            this.fld_dgcHRLabouringConfig.Tag = "SR";
            this.fld_dgcHRLabouringConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRLabouringConfig});
            // 
            // fld_dgvHRLabouringConfig
            // 
            this.fld_dgvHRLabouringConfig.GridControl = this.fld_dgcHRLabouringConfig;
            this.fld_dgvHRLabouringConfig.Name = "fld_dgvHRLabouringConfig";
            this.fld_dgvHRLabouringConfig.PaintStyleName = "Office2003";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(54, 140);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(54, 114);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 11;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.Location = new System.Drawing.Point(54, 62);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel.TabIndex = 9;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã danh sách";
            // 
            // fld_dteSearchToHRLabouringConfigDate
            // 
            this.fld_dteSearchToHRLabouringConfigDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRLabouringConfigDate.BOSDataMember = "HRLabouringConfigDate";
            this.fld_dteSearchToHRLabouringConfigDate.BOSDataSource = "HRLabouringConfigs";
            this.fld_dteSearchToHRLabouringConfigDate.BOSDescription = null;
            this.fld_dteSearchToHRLabouringConfigDate.BOSError = null;
            this.fld_dteSearchToHRLabouringConfigDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRLabouringConfigDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRLabouringConfigDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRLabouringConfigDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHRLabouringConfigDate.EditValue = null;
            this.fld_dteSearchToHRLabouringConfigDate.Location = new System.Drawing.Point(157, 137);
            this.fld_dteSearchToHRLabouringConfigDate.Name = "fld_dteSearchToHRLabouringConfigDate";
            this.fld_dteSearchToHRLabouringConfigDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHRLabouringConfigDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHRLabouringConfigDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHRLabouringConfigDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHRLabouringConfigDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHRLabouringConfigDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHRLabouringConfigDate.Screen = null;
            this.fld_dteSearchToHRLabouringConfigDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHRLabouringConfigDate.TabIndex = 8;
            this.fld_dteSearchToHRLabouringConfigDate.Tag = "SC";
            // 
            // fld_dteSearchFromHRLabouringConfigDate
            // 
            this.fld_dteSearchFromHRLabouringConfigDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSDataMember = "HRLabouringConfigDate";
            this.fld_dteSearchFromHRLabouringConfigDate.BOSDataSource = "HRLabouringConfigs";
            this.fld_dteSearchFromHRLabouringConfigDate.BOSDescription = null;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSError = null;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRLabouringConfigDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHRLabouringConfigDate.EditValue = null;
            this.fld_dteSearchFromHRLabouringConfigDate.Location = new System.Drawing.Point(157, 111);
            this.fld_dteSearchFromHRLabouringConfigDate.Name = "fld_dteSearchFromHRLabouringConfigDate";
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHRLabouringConfigDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHRLabouringConfigDate.Screen = null;
            this.fld_dteSearchFromHRLabouringConfigDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHRLabouringConfigDate.TabIndex = 7;
            this.fld_dteSearchFromHRLabouringConfigDate.Tag = "SC";
            // 
            // fld_txtHRLabouringConfigNo
            // 
            this.fld_txtHRLabouringConfigNo.BOSComment = "";
            this.fld_txtHRLabouringConfigNo.BOSDataMember = "HRLabouringConfigNo";
            this.fld_txtHRLabouringConfigNo.BOSDataSource = "HRLabouringConfigs";
            this.fld_txtHRLabouringConfigNo.BOSDescription = null;
            this.fld_txtHRLabouringConfigNo.BOSError = null;
            this.fld_txtHRLabouringConfigNo.BOSFieldGroup = "";
            this.fld_txtHRLabouringConfigNo.BOSFieldRelation = "";
            this.fld_txtHRLabouringConfigNo.BOSPrivilege = "";
            this.fld_txtHRLabouringConfigNo.BOSPropertyName = "Text";
            this.fld_txtHRLabouringConfigNo.EditValue = "";
            this.fld_txtHRLabouringConfigNo.Location = new System.Drawing.Point(157, 59);
            this.fld_txtHRLabouringConfigNo.Name = "fld_txtHRLabouringConfigNo";
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLabouringConfigNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLabouringConfigNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLabouringConfigNo.Screen = null;
            this.fld_txtHRLabouringConfigNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRLabouringConfigNo.TabIndex = 5;
            this.fld_txtHRLabouringConfigNo.Tag = "SC";
            // 
            // fld_lkeHRLabouringConfigDateType
            // 
            this.fld_lkeHRLabouringConfigDateType.BOSAllowAddNew = false;
            this.fld_lkeHRLabouringConfigDateType.BOSAllowDummy = false;
            this.fld_lkeHRLabouringConfigDateType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSDataMember = "HRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.BOSDataSource = "HRLabouringConfigs";
            this.fld_lkeHRLabouringConfigDateType.BOSDescription = null;
            this.fld_lkeHRLabouringConfigDateType.BOSError = null;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSPropertyName = "EditValue";
            this.fld_lkeHRLabouringConfigDateType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.CurrentDisplayText = null;
            this.fld_lkeHRLabouringConfigDateType.Location = new System.Drawing.Point(157, 85);
            this.fld_lkeHRLabouringConfigDateType.Name = "fld_lkeHRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRLabouringConfigDateType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRLabouringConfigDateType.Properties.PopupWidth = 40;
            this.fld_lkeHRLabouringConfigDateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRLabouringConfigDateType.Screen = null;
            this.fld_lkeHRLabouringConfigDateType.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeHRLabouringConfigDateType.TabIndex = 565;
            this.fld_lkeHRLabouringConfigDateType.Tag = "SC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(54, 88);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(20, 13);
            this.bosLabel13.TabIndex = 566;
            this.bosLabel13.Tag = "SI";
            this.bosLabel13.Text = "Loại";
            // 
            // SMHRLC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeHRLabouringConfigDateType);
            this.Controls.Add(this.bosLabel13);
            this.Controls.Add(this.fld_txtHRLabouringConfigNo);
            this.Controls.Add(this.fld_dteSearchFromHRLabouringConfigDate);
            this.Controls.Add(this.fld_dteSearchToHRLabouringConfigDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcHRLabouringConfig);
            this.Name = "SMHRLC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHRLabouringConfig, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHRLabouringConfigDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHRLabouringConfigDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRLabouringConfigNo, 0);
            this.Controls.SetChildIndex(this.bosLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRLabouringConfigDateType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLabouringConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLabouringConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRLabouringConfigDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRLabouringConfigDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRLabouringConfigDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRLabouringConfigDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLabouringConfigNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSDateEdit fld_dteSearchToHRLabouringConfigDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromHRLabouringConfigDate;
        private BOSComponent.BOSTextBox fld_txtHRLabouringConfigNo;
        private BOSComponent.BOSLookupEdit fld_lkeHRLabouringConfigDateType;
        private BOSComponent.BOSLabel bosLabel13;
	}
}
