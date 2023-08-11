using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConversion.UI
{
	/// <summary>
	/// Summary description for SMPCV100
	/// </summary>
	partial class SMPCV100
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
            this.fld_dgcICProductConversions = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductConversionNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICFromStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductConversionDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductConversionNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICProductConversions
            // 
            this.fld_dgcICProductConversions.BOSComment = null;
            this.fld_dgcICProductConversions.BOSDataMember = null;
            this.fld_dgcICProductConversions.BOSDataSource = "ICProductConversions";
            this.fld_dgcICProductConversions.BOSDescription = null;
            this.fld_dgcICProductConversions.BOSError = null;
            this.fld_dgcICProductConversions.BOSFieldGroup = null;
            this.fld_dgcICProductConversions.BOSFieldRelation = null;
            this.fld_dgcICProductConversions.BOSGridType = null;
            this.fld_dgcICProductConversions.BOSPrivilege = null;
            this.fld_dgcICProductConversions.BOSPropertyName = null;
            this.fld_dgcICProductConversions.CommodityType = "";
            this.fld_dgcICProductConversions.Location = new System.Drawing.Point(12, 113);
            this.fld_dgcICProductConversions.MenuManager = this.screenToolbar;
            this.fld_dgcICProductConversions.Name = "fld_dgcICProductConversions";
            this.fld_dgcICProductConversions.PrintReport = false;
            this.fld_dgcICProductConversions.Screen = null;
            this.fld_dgcICProductConversions.Size = new System.Drawing.Size(857, 370);
            this.fld_dgcICProductConversions.TabIndex = 15;
            this.fld_dgcICProductConversions.Tag = "SR";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(26, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICProductConversionNo1
            // 
            this.fld_txtICProductConversionNo1.BOSComment = "";
            this.fld_txtICProductConversionNo1.BOSDataMember = "ICProductConversionNo";
            this.fld_txtICProductConversionNo1.BOSDataSource = "ICProductConversions";
            this.fld_txtICProductConversionNo1.BOSDescription = null;
            this.fld_txtICProductConversionNo1.BOSError = null;
            this.fld_txtICProductConversionNo1.BOSFieldGroup = "";
            this.fld_txtICProductConversionNo1.BOSFieldRelation = "";
            this.fld_txtICProductConversionNo1.BOSPrivilege = "";
            this.fld_txtICProductConversionNo1.BOSPropertyName = "Text";
            this.fld_txtICProductConversionNo1.EditValue = "";
            this.fld_txtICProductConversionNo1.Location = new System.Drawing.Point(107, 9);
            this.fld_txtICProductConversionNo1.Name = "fld_txtICProductConversionNo1";
            this.fld_txtICProductConversionNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductConversionNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductConversionNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductConversionNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductConversionNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductConversionNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductConversionNo1.Screen = null;
            this.fld_txtICProductConversionNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductConversionNo1.TabIndex = 0;
            this.fld_txtICProductConversionNo1.Tag = "SC";
            // 
            // fld_lkeFK_ICFromStockID1
            // 
            this.fld_lkeFK_ICFromStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID1.BOSComment = "";
            this.fld_lkeFK_ICFromStockID1.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID1.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_ICFromStockID1.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID1.BOSError = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICFromStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICFromStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICFromStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICFromStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICFromStockID1.Location = new System.Drawing.Point(107, 61);
            this.fld_lkeFK_ICFromStockID1.Name = "fld_lkeFK_ICFromStockID1";
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICFromStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICFromStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID1.Screen = null;
            this.fld_lkeFK_ICFromStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICFromStockID1.TabIndex = 4;
            this.fld_lkeFK_ICFromStockID1.Tag = "SC";
            // 
            // fld_lkeFK_ICToStockID1
            // 
            this.fld_lkeFK_ICToStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID1.BOSComment = "";
            this.fld_lkeFK_ICToStockID1.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID1.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_ICToStockID1.BOSDescription = null;
            this.fld_lkeFK_ICToStockID1.BOSError = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICToStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICToStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICToStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICToStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICToStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICToStockID1.Location = new System.Drawing.Point(345, 60);
            this.fld_lkeFK_ICToStockID1.Name = "fld_lkeFK_ICToStockID1";
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICToStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICToStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID1.Screen = null;
            this.fld_lkeFK_ICToStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICToStockID1.TabIndex = 5;
            this.fld_lkeFK_ICToStockID1.Tag = "SC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(274, 63);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 574;
            this.fld_lblLabel8.Tag = "SI";
            this.fld_lblLabel8.Text = "Đến kho";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(26, 64);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 573;
            this.fld_lblLabel7.Tag = "SI";
            this.fld_lblLabel7.Text = "Từ kho";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(274, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(65, 13);
            this.bosLabel2.TabIndex = 570;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ICProductConversionName";
            this.bosTextBox1.BOSDataSource = "ICProductConversions";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(345, 9);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 1;
            this.bosTextBox1.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(107, 35);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(26, 38);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 575;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Nhân viên";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(26, 92);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 577;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Từ ngày";
            // 
            // fld_dteICProductConversionDate
            // 
            this.fld_dteICProductConversionDate.BOSComment = null;
            this.fld_dteICProductConversionDate.BOSDataMember = "ICProductConversionFromDate";
            this.fld_dteICProductConversionDate.BOSDataSource = "ICProductConversions";
            this.fld_dteICProductConversionDate.BOSDescription = null;
            this.fld_dteICProductConversionDate.BOSError = null;
            this.fld_dteICProductConversionDate.BOSFieldGroup = null;
            this.fld_dteICProductConversionDate.BOSFieldRelation = null;
            this.fld_dteICProductConversionDate.BOSPrivilege = null;
            this.fld_dteICProductConversionDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductConversionDate.EditValue = null;
            this.fld_dteICProductConversionDate.Location = new System.Drawing.Point(107, 87);
            this.fld_dteICProductConversionDate.Name = "fld_dteICProductConversionDate";
            this.fld_dteICProductConversionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductConversionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductConversionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductConversionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductConversionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductConversionDate.Screen = null;
            this.fld_dteICProductConversionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICProductConversionDate.TabIndex = 6;
            this.fld_dteICProductConversionDate.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(274, 91);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 579;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Đến ngày";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ICProductConversionToDate";
            this.bosDateEdit1.BOSDataSource = "ICProductConversions";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(345, 85);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 7;
            this.bosDateEdit1.Tag = "SC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(274, 38);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 583;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICProductConversions";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(345, 35);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMPCV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(899, 516);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dteICProductConversionDate);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_ICFromStockID1);
            this.Controls.Add(this.fld_lkeFK_ICToStockID1);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_lblLabel7);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dgcICProductConversions);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICProductConversionNo1);
            this.Name = "SMPCV100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICProductConversionNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProductConversions, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICToStockID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICFromStockID1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteICProductConversionDate, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductConversions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductConversionNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductConversionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcICProductConversions;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductConversionNo1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID1;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteICProductConversionDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
    }
}
