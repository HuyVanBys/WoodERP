using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Barcode.UI
{
	/// <summary>
	/// Summary description for SMBC100
	/// </summary>
	partial class SMBC100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel111;
		private BOSComponent.BOSDateEdit fld_dteSearchToICBarcodeDate;
		private BOSComponent.BOSTextBox fld_txtICBarcodeNo1;
		private BOSSearchResultsGridControl fld_dgcICBarcode;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICBarcode;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICBarcodeDate;


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
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToICBarcodeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICBarcodeNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcICBarcode = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICBarcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromICBarcodeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICBarcodeReference = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICBarcodeDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICBarcodeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICBarcodeDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICBarcodeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeReference.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(38, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(38, 90);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel111
            // 
            this.fld_lblLabel111.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel111.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel111.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel111.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel111.BOSComment = "";
            this.fld_lblLabel111.BOSDataMember = "";
            this.fld_lblLabel111.BOSDataSource = "";
            this.fld_lblLabel111.BOSDescription = null;
            this.fld_lblLabel111.BOSError = null;
            this.fld_lblLabel111.BOSFieldGroup = "";
            this.fld_lblLabel111.BOSFieldRelation = "";
            this.fld_lblLabel111.BOSPrivilege = "";
            this.fld_lblLabel111.BOSPropertyName = null;
            this.fld_lblLabel111.Location = new System.Drawing.Point(284, 90);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel111.TabIndex = 29;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến ngày";
            // 
            // fld_dteSearchToICBarcodeDate
            // 
            this.fld_dteSearchToICBarcodeDate.BOSComment = "";
            this.fld_dteSearchToICBarcodeDate.BOSDataMember = "BarcodeDateTo";
            this.fld_dteSearchToICBarcodeDate.BOSDataSource = "ICBarcodes";
            this.fld_dteSearchToICBarcodeDate.BOSDescription = null;
            this.fld_dteSearchToICBarcodeDate.BOSError = "";
            this.fld_dteSearchToICBarcodeDate.BOSFieldGroup = "";
            this.fld_dteSearchToICBarcodeDate.BOSFieldRelation = null;
            this.fld_dteSearchToICBarcodeDate.BOSPrivilege = "";
            this.fld_dteSearchToICBarcodeDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICBarcodeDate.EditValue = null;
            this.fld_dteSearchToICBarcodeDate.Location = new System.Drawing.Point(351, 87);
            this.fld_dteSearchToICBarcodeDate.Name = "fld_dteSearchToICBarcodeDate";
            this.fld_dteSearchToICBarcodeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICBarcodeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICBarcodeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICBarcodeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICBarcodeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICBarcodeDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICBarcodeDate.Screen = null;
            this.fld_dteSearchToICBarcodeDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchToICBarcodeDate.TabIndex = 8;
            this.fld_dteSearchToICBarcodeDate.Tag = "SC";
            // 
            // fld_txtICBarcodeNo1
            // 
            this.fld_txtICBarcodeNo1.BOSComment = "";
            this.fld_txtICBarcodeNo1.BOSDataMember = "ICBarcodeNo";
            this.fld_txtICBarcodeNo1.BOSDataSource = "ICBarcodes";
            this.fld_txtICBarcodeNo1.BOSDescription = null;
            this.fld_txtICBarcodeNo1.BOSError = "";
            this.fld_txtICBarcodeNo1.BOSFieldGroup = "";
            this.fld_txtICBarcodeNo1.BOSFieldRelation = "";
            this.fld_txtICBarcodeNo1.BOSPrivilege = "";
            this.fld_txtICBarcodeNo1.BOSPropertyName = "Text";
            this.fld_txtICBarcodeNo1.Location = new System.Drawing.Point(120, 9);
            this.fld_txtICBarcodeNo1.Name = "fld_txtICBarcodeNo1";
            this.fld_txtICBarcodeNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICBarcodeNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICBarcodeNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICBarcodeNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICBarcodeNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICBarcodeNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICBarcodeNo1.Screen = null;
            this.fld_txtICBarcodeNo1.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICBarcodeNo1.TabIndex = 0;
            this.fld_txtICBarcodeNo1.Tag = "SC";
            // 
            // fld_dgcICBarcode
            // 
            this.fld_dgcICBarcode.AllowDrop = true;
            this.fld_dgcICBarcode.BOSComment = "";
            this.fld_dgcICBarcode.BOSDataMember = null;
            this.fld_dgcICBarcode.BOSDataSource = "ICBarcodes";
            this.fld_dgcICBarcode.BOSDescription = null;
            this.fld_dgcICBarcode.BOSError = "";
            this.fld_dgcICBarcode.BOSFieldGroup = "";
            this.fld_dgcICBarcode.BOSFieldRelation = null;
            this.fld_dgcICBarcode.BOSGridType = null;
            this.fld_dgcICBarcode.BOSPrivilege = "";
            this.fld_dgcICBarcode.BOSPropertyName = null;
            this.fld_dgcICBarcode.CommodityType = "";
            this.fld_dgcICBarcode.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICBarcode.Location = new System.Drawing.Point(38, 113);
            this.fld_dgcICBarcode.MainView = this.fld_dgvICBarcode;
            this.fld_dgcICBarcode.Name = "fld_dgcICBarcode";
            this.fld_dgcICBarcode.PrintReport = false;
            this.fld_dgcICBarcode.Screen = null;
            this.fld_dgcICBarcode.Size = new System.Drawing.Size(576, 459);
            this.fld_dgcICBarcode.TabIndex = 8;
            this.fld_dgcICBarcode.Tag = "SR";
            this.fld_dgcICBarcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICBarcode});
            // 
            // fld_dgvICBarcode
            // 
            this.fld_dgvICBarcode.GridControl = this.fld_dgcICBarcode;
            this.fld_dgvICBarcode.Name = "fld_dgvICBarcode";
            this.fld_dgvICBarcode.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromICBarcodeDate
            // 
            this.fld_dteSearchFromICBarcodeDate.BOSComment = "";
            this.fld_dteSearchFromICBarcodeDate.BOSDataMember = "BarcodeDateFrom";
            this.fld_dteSearchFromICBarcodeDate.BOSDataSource = "ICBarcodes";
            this.fld_dteSearchFromICBarcodeDate.BOSDescription = null;
            this.fld_dteSearchFromICBarcodeDate.BOSError = "";
            this.fld_dteSearchFromICBarcodeDate.BOSFieldGroup = "";
            this.fld_dteSearchFromICBarcodeDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICBarcodeDate.BOSPrivilege = "";
            this.fld_dteSearchFromICBarcodeDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICBarcodeDate.EditValue = null;
            this.fld_dteSearchFromICBarcodeDate.Location = new System.Drawing.Point(120, 87);
            this.fld_dteSearchFromICBarcodeDate.Name = "fld_dteSearchFromICBarcodeDate";
            this.fld_dteSearchFromICBarcodeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICBarcodeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICBarcodeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICBarcodeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICBarcodeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICBarcodeDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICBarcodeDate.Screen = null;
            this.fld_dteSearchFromICBarcodeDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchFromICBarcodeDate.TabIndex = 7;
            this.fld_dteSearchFromICBarcodeDate.Tag = "SC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(38, 63);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel6.TabIndex = 4;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICBarcodes";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(120, 61);
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(38, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(69, 13);
            this.bosLabel2.TabIndex = 95;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Mã tham chiếu";
            // 
            // fld_txtICBarcodeReference
            // 
            this.fld_txtICBarcodeReference.BOSComment = "";
            this.fld_txtICBarcodeReference.BOSDataMember = "ICBarcodeReference";
            this.fld_txtICBarcodeReference.BOSDataSource = "ICBarcodes";
            this.fld_txtICBarcodeReference.BOSDescription = null;
            this.fld_txtICBarcodeReference.BOSError = "";
            this.fld_txtICBarcodeReference.BOSFieldGroup = "";
            this.fld_txtICBarcodeReference.BOSFieldRelation = "";
            this.fld_txtICBarcodeReference.BOSPrivilege = "";
            this.fld_txtICBarcodeReference.BOSPropertyName = "Text";
            this.fld_txtICBarcodeReference.Location = new System.Drawing.Point(120, 35);
            this.fld_txtICBarcodeReference.Name = "fld_txtICBarcodeReference";
            this.fld_txtICBarcodeReference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICBarcodeReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICBarcodeReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICBarcodeReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICBarcodeReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICBarcodeReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICBarcodeReference.Screen = null;
            this.fld_txtICBarcodeReference.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICBarcodeReference.TabIndex = 1;
            this.fld_txtICBarcodeReference.Tag = "SC";
            // 
            // SMBC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(707, 581);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_txtICBarcodeReference);
            this.Controls.Add(this.fld_txtICBarcodeNo1);
            this.Controls.Add(this.fld_dgcICBarcode);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchToICBarcodeDate);
            this.Controls.Add(this.fld_dteSearchFromICBarcodeDate);
            this.Controls.Add(this.bosLabel2);
            this.Name = "SMBC100";
            this.Text = "Tim kiếm";
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICBarcodeDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICBarcodeDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.fld_dgcICBarcode, 0);
            this.Controls.SetChildIndex(this.fld_txtICBarcodeNo1, 0);
            this.Controls.SetChildIndex(this.fld_txtICBarcodeReference, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICBarcodeDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICBarcodeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICBarcodeDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICBarcodeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeReference.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICBarcodeReference;
	}
}
