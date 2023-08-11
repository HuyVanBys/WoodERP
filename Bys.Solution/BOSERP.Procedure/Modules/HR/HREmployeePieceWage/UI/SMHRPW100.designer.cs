using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREmployeePieceWage.UI
{
	/// <summary>
	/// Summary description for SMHRPW100
	/// </summary>
	partial class SMHRPW100
	{
		private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageNo;
		private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageName;
		private BOSComponent.BOSDateEdit fld_dteSearchFromHREmployeePieceWageDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToHREmployeePieceWageDate;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSSearchResultsGridControl fld_dgcHREmployeePieceWage;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePieceWage;


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
            this.fld_txtHREmployeePieceWageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromHREmployeePieceWageDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHREmployeePieceWageDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHREmployeePieceWage = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREmployeePieceWage = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeePieceWageDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeePieceWageDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeePieceWageDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeePieceWageDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePieceWage)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHREmployeePieceWageNo
            // 
            this.fld_txtHREmployeePieceWageNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo.BOSDataMember = "HREmployeePieceWageNo";
            this.fld_txtHREmployeePieceWageNo.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageNo.BOSDescription = null;
            this.fld_txtHREmployeePieceWageNo.BOSError = null;
            this.fld_txtHREmployeePieceWageNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo.Location = new System.Drawing.Point(157, 63);
            this.fld_txtHREmployeePieceWageNo.Name = "fld_txtHREmployeePieceWageNo";
            this.fld_txtHREmployeePieceWageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageNo.Screen = null;
            this.fld_txtHREmployeePieceWageNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeePieceWageNo.TabIndex = 5;
            this.fld_txtHREmployeePieceWageNo.Tag = "SC";
            // 
            // fld_txtHREmployeePieceWageName
            // 
            this.fld_txtHREmployeePieceWageName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName.BOSDataMember = "HREmployeePieceWageName";
            this.fld_txtHREmployeePieceWageName.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageName.BOSDescription = null;
            this.fld_txtHREmployeePieceWageName.BOSError = null;
            this.fld_txtHREmployeePieceWageName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName.Location = new System.Drawing.Point(157, 87);
            this.fld_txtHREmployeePieceWageName.Name = "fld_txtHREmployeePieceWageName";
            this.fld_txtHREmployeePieceWageName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageName.Screen = null;
            this.fld_txtHREmployeePieceWageName.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeePieceWageName.TabIndex = 6;
            this.fld_txtHREmployeePieceWageName.Tag = "SC";
            // 
            // fld_dteSearchFromHREmployeePieceWageDate
            // 
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSDataMember = "HREmployeePieceWageDate";
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSDataSource = "HREmployeePieceWages";
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSDescription = null;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSError = null;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHREmployeePieceWageDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHREmployeePieceWageDate.EditValue = null;
            this.fld_dteSearchFromHREmployeePieceWageDate.Location = new System.Drawing.Point(157, 111);
            this.fld_dteSearchFromHREmployeePieceWageDate.Name = "fld_dteSearchFromHREmployeePieceWageDate";
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHREmployeePieceWageDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHREmployeePieceWageDate.Screen = null;
            this.fld_dteSearchFromHREmployeePieceWageDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHREmployeePieceWageDate.TabIndex = 7;
            this.fld_dteSearchFromHREmployeePieceWageDate.Tag = "SC";
            // 
            // fld_dteSearchToHREmployeePieceWageDate
            // 
            this.fld_dteSearchToHREmployeePieceWageDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSDataMember = "HREmployeePieceWageDate";
            this.fld_dteSearchToHREmployeePieceWageDate.BOSDataSource = "HREmployeePieceWages";
            this.fld_dteSearchToHREmployeePieceWageDate.BOSDescription = null;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSError = null;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHREmployeePieceWageDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHREmployeePieceWageDate.EditValue = null;
            this.fld_dteSearchToHREmployeePieceWageDate.Location = new System.Drawing.Point(157, 135);
            this.fld_dteSearchToHREmployeePieceWageDate.Name = "fld_dteSearchToHREmployeePieceWageDate";
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHREmployeePieceWageDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHREmployeePieceWageDate.Screen = null;
            this.fld_dteSearchToHREmployeePieceWageDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHREmployeePieceWageDate.TabIndex = 8;
            this.fld_dteSearchToHREmployeePieceWageDate.Tag = "SC";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(54, 66);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel.TabIndex = 9;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã danh sách";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.Location = new System.Drawing.Point(54, 90);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel1.TabIndex = 10;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên danh sách";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(54, 138);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // fld_dgcHREmployeePieceWage
            // 
            this.fld_dgcHREmployeePieceWage.AllowDrop = true;
            this.fld_dgcHREmployeePieceWage.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.BOSDataSource = "HREmployeePieceWages";
            this.fld_dgcHREmployeePieceWage.BOSDescription = null;
            this.fld_dgcHREmployeePieceWage.BOSError = null;
            this.fld_dgcHREmployeePieceWage.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWage.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePieceWage.Location = new System.Drawing.Point(10, 178);
            this.fld_dgcHREmployeePieceWage.MainView = this.fld_dgvHREmployeePieceWage;
            this.fld_dgcHREmployeePieceWage.Name = "fld_dgcHREmployeePieceWage";
            this.fld_dgcHREmployeePieceWage.Screen = null;
            this.fld_dgcHREmployeePieceWage.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHREmployeePieceWage.TabIndex = 13;
            this.fld_dgcHREmployeePieceWage.Tag = "SR";
            this.fld_dgcHREmployeePieceWage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeePieceWage});
            // 
            // fld_dgvHREmployeePieceWage
            // 
            this.fld_dgvHREmployeePieceWage.GridControl = this.fld_dgcHREmployeePieceWage;
            this.fld_dgvHREmployeePieceWage.Name = "fld_dgvHREmployeePieceWage";
            this.fld_dgvHREmployeePieceWage.PaintStyleName = "Office2003";
            // 
            // SMHRPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtHREmployeePieceWageNo);
            this.Controls.Add(this.fld_txtHREmployeePieceWageName);
            this.Controls.Add(this.fld_dteSearchFromHREmployeePieceWageDate);
            this.Controls.Add(this.fld_dteSearchToHREmployeePieceWageDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcHREmployeePieceWage);
            this.Name = "SMHRPW100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHREmployeePieceWage, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHREmployeePieceWageDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHREmployeePieceWageDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeePieceWageName, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeePieceWageNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeePieceWageDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeePieceWageDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeePieceWageDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeePieceWageDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePieceWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
