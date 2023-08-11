using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRProductPieceWage.UI
{
	/// <summary>
	/// Summary description for SMHRPPW100
	/// </summary>
	partial class SMHRPPW100
	{
		private BOSComponent.BOSTextBox fld_txtHRProductPieceWageNo;
		private BOSComponent.BOSTextBox fld_txtHRProductPieceWageName;
		private BOSComponent.BOSDateEdit fld_dteSearchFromHRProductPieceWageDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToHRProductPieceWageDate;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSSearchResultsGridControl fld_dgcHRProductPieceWage;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRProductPieceWage;


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
            this.fld_txtHRProductPieceWageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRProductPieceWageName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromHRProductPieceWageDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHRProductPieceWageDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRProductPieceWage = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRProductPieceWage = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRProductPieceWageDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRProductPieceWageDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRProductPieceWageDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRProductPieceWageDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRProductPieceWage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRProductPieceWage)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRProductPieceWageNo
            // 
            this.fld_txtHRProductPieceWageNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageNo.BOSDataMember = "HRProductPieceWageNo";
            this.fld_txtHRProductPieceWageNo.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageNo.BOSDescription = null;
            this.fld_txtHRProductPieceWageNo.BOSError = null;
            this.fld_txtHRProductPieceWageNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageNo.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageNo.Location = new System.Drawing.Point(157, 63);
            this.fld_txtHRProductPieceWageNo.Name = "fld_txtHRProductPieceWageNo";
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageNo.Screen = null;
            this.fld_txtHRProductPieceWageNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRProductPieceWageNo.TabIndex = 5;
            this.fld_txtHRProductPieceWageNo.Tag = "SC";
            // 
            // fld_txtHRProductPieceWageName
            // 
            this.fld_txtHRProductPieceWageName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageName.BOSDataMember = "HRProductPieceWageName";
            this.fld_txtHRProductPieceWageName.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageName.BOSDescription = null;
            this.fld_txtHRProductPieceWageName.BOSError = null;
            this.fld_txtHRProductPieceWageName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageName.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRProductPieceWageName.Location = new System.Drawing.Point(157, 87);
            this.fld_txtHRProductPieceWageName.Name = "fld_txtHRProductPieceWageName";
            this.fld_txtHRProductPieceWageName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageName.Screen = null;
            this.fld_txtHRProductPieceWageName.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRProductPieceWageName.TabIndex = 6;
            this.fld_txtHRProductPieceWageName.Tag = "SC";
            // 
            // fld_dteSearchFromHRProductPieceWageDate
            // 
            this.fld_dteSearchFromHRProductPieceWageDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSDataMember = "HRProductPieceWageDate";
            this.fld_dteSearchFromHRProductPieceWageDate.BOSDataSource = "HRProductPieceWages";
            this.fld_dteSearchFromHRProductPieceWageDate.BOSDescription = null;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSError = null;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRProductPieceWageDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHRProductPieceWageDate.EditValue = null;
            this.fld_dteSearchFromHRProductPieceWageDate.Location = new System.Drawing.Point(157, 111);
            this.fld_dteSearchFromHRProductPieceWageDate.Name = "fld_dteSearchFromHRProductPieceWageDate";
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHRProductPieceWageDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHRProductPieceWageDate.Screen = null;
            this.fld_dteSearchFromHRProductPieceWageDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHRProductPieceWageDate.TabIndex = 7;
            this.fld_dteSearchFromHRProductPieceWageDate.Tag = "SC";
            // 
            // fld_dteSearchToHRProductPieceWageDate
            // 
            this.fld_dteSearchToHRProductPieceWageDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRProductPieceWageDate.BOSDataMember = "HRProductPieceWageDate";
            this.fld_dteSearchToHRProductPieceWageDate.BOSDataSource = "HRProductPieceWages";
            this.fld_dteSearchToHRProductPieceWageDate.BOSDescription = null;
            this.fld_dteSearchToHRProductPieceWageDate.BOSError = null;
            this.fld_dteSearchToHRProductPieceWageDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRProductPieceWageDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRProductPieceWageDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRProductPieceWageDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHRProductPieceWageDate.EditValue = null;
            this.fld_dteSearchToHRProductPieceWageDate.Location = new System.Drawing.Point(157, 135);
            this.fld_dteSearchToHRProductPieceWageDate.Name = "fld_dteSearchToHRProductPieceWageDate";
            this.fld_dteSearchToHRProductPieceWageDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHRProductPieceWageDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHRProductPieceWageDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHRProductPieceWageDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHRProductPieceWageDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHRProductPieceWageDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHRProductPieceWageDate.Screen = null;
            this.fld_dteSearchToHRProductPieceWageDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHRProductPieceWageDate.TabIndex = 8;
            this.fld_dteSearchToHRProductPieceWageDate.Tag = "SC";
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
            // fld_dgcHRProductPieceWage
            // 
            this.fld_dgcHRProductPieceWage.AllowDrop = true;
            this.fld_dgcHRProductPieceWage.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.BOSDataSource = "HRProductPieceWages";
            this.fld_dgcHRProductPieceWage.BOSDescription = null;
            this.fld_dgcHRProductPieceWage.BOSError = null;
            this.fld_dgcHRProductPieceWage.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRProductPieceWage.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRProductPieceWage.Location = new System.Drawing.Point(10, 178);
            this.fld_dgcHRProductPieceWage.MainView = this.fld_dgvHRProductPieceWage;
            this.fld_dgcHRProductPieceWage.Name = "fld_dgcHRProductPieceWage";
            this.fld_dgcHRProductPieceWage.Screen = null;
            this.fld_dgcHRProductPieceWage.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRProductPieceWage.TabIndex = 13;
            this.fld_dgcHRProductPieceWage.Tag = "SR";
            this.fld_dgcHRProductPieceWage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRProductPieceWage});
            // 
            // fld_dgvHRProductPieceWage
            // 
            this.fld_dgvHRProductPieceWage.GridControl = this.fld_dgcHRProductPieceWage;
            this.fld_dgvHRProductPieceWage.Name = "fld_dgvHRProductPieceWage";
            this.fld_dgvHRProductPieceWage.PaintStyleName = "Office2003";
            // 
            // SMHRPPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtHRProductPieceWageNo);
            this.Controls.Add(this.fld_txtHRProductPieceWageName);
            this.Controls.Add(this.fld_dteSearchFromHRProductPieceWageDate);
            this.Controls.Add(this.fld_dteSearchToHRProductPieceWageDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcHRProductPieceWage);
            this.Name = "SMHRPPW100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHRProductPieceWage, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHRProductPieceWageDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHRProductPieceWageDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRProductPieceWageName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRProductPieceWageNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRProductPieceWageDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRProductPieceWageDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRProductPieceWageDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRProductPieceWageDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRProductPieceWage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRProductPieceWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
