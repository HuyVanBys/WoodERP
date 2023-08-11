using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReturnSupplier.UI
{
	/// <summary>
	/// Summary description for SMRS100
	/// </summary>
	partial class SMRS100
	{
		private BOSComponent.BOSTextBox fld_txtAPReturnSupplierNo1;
		private BOSComponent.BOSTextBox fld_txtAPReturnSupplierName1;
		private BOSComponent.BOSDateEdit fld_dteSearchFromAPReturnSupplierDate1;
		private BOSComponent.BOSDateEdit fld_dteSearchToAPReturnSupplierDate2;
		private BOSSearchResultsGridControl fld_dgcAPReturnSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPReturnSupplier;
		private BOSComponent.BOSLabel fld_lblLabel18;
		private BOSComponent.BOSLabel fld_lblLabel19;
		private BOSComponent.BOSLabel fld_lblLabel22;
		private BOSComponent.BOSLabel fld_lblLabel23;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
		private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel10;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMRS100));
            this.fld_txtAPReturnSupplierNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPReturnSupplierName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromAPReturnSupplierDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPReturnSupplierDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcAPReturnSupplier = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPReturnSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPReturnSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPReturnSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtAPReturnSupplierNo1
            // 
            this.fld_txtAPReturnSupplierNo1.BOSComment = "";
            this.fld_txtAPReturnSupplierNo1.BOSDataMember = "APReturnSupplierNo";
            this.fld_txtAPReturnSupplierNo1.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierNo1.BOSDescription = null;
            this.fld_txtAPReturnSupplierNo1.BOSError = "";
            this.fld_txtAPReturnSupplierNo1.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierNo1.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierNo1.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierNo1.BOSPropertyName = "Text";
            this.fld_txtAPReturnSupplierNo1.Location = new System.Drawing.Point(114, 9);
            this.fld_txtAPReturnSupplierNo1.Name = "fld_txtAPReturnSupplierNo1";
            this.fld_txtAPReturnSupplierNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierNo1.Screen = null;
            this.fld_txtAPReturnSupplierNo1.Size = new System.Drawing.Size(120, 20);
            this.fld_txtAPReturnSupplierNo1.TabIndex = 0;
            this.fld_txtAPReturnSupplierNo1.Tag = "SC";
            // 
            // fld_txtAPReturnSupplierName1
            // 
            this.fld_txtAPReturnSupplierName1.BOSComment = "";
            this.fld_txtAPReturnSupplierName1.BOSDataMember = "APReturnSupplierName";
            this.fld_txtAPReturnSupplierName1.BOSDataSource = "APReturnSuppliers";
            this.fld_txtAPReturnSupplierName1.BOSDescription = null;
            this.fld_txtAPReturnSupplierName1.BOSError = "";
            this.fld_txtAPReturnSupplierName1.BOSFieldGroup = "";
            this.fld_txtAPReturnSupplierName1.BOSFieldRelation = "";
            this.fld_txtAPReturnSupplierName1.BOSPrivilege = "";
            this.fld_txtAPReturnSupplierName1.BOSPropertyName = "Text";
            this.fld_txtAPReturnSupplierName1.Location = new System.Drawing.Point(114, 45);
            this.fld_txtAPReturnSupplierName1.Name = "fld_txtAPReturnSupplierName1";
            this.fld_txtAPReturnSupplierName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPReturnSupplierName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPReturnSupplierName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPReturnSupplierName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPReturnSupplierName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPReturnSupplierName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPReturnSupplierName1.Screen = null;
            this.fld_txtAPReturnSupplierName1.Size = new System.Drawing.Size(120, 20);
            this.fld_txtAPReturnSupplierName1.TabIndex = 1;
            this.fld_txtAPReturnSupplierName1.Tag = "SC";
            // 
            // fld_dteSearchFromAPReturnSupplierDate1
            // 
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSComment = "";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSDataMember = "ReturnSupplierFromDate";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSDataSource = "APReturnSuppliers";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSDescription = null;
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSError = "";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSFieldGroup = "";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSFieldRelation = null;
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSPrivilege = "";
            this.fld_dteSearchFromAPReturnSupplierDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPReturnSupplierDate1.EditValue = null;
            this.fld_dteSearchFromAPReturnSupplierDate1.Location = new System.Drawing.Point(114, 190);
            this.fld_dteSearchFromAPReturnSupplierDate1.Name = "fld_dteSearchFromAPReturnSupplierDate1";
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPReturnSupplierDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPReturnSupplierDate1.Screen = null;
            this.fld_dteSearchFromAPReturnSupplierDate1.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchFromAPReturnSupplierDate1.TabIndex = 2;
            this.fld_dteSearchFromAPReturnSupplierDate1.Tag = "SC";
            // 
            // fld_dteSearchToAPReturnSupplierDate2
            // 
            this.fld_dteSearchToAPReturnSupplierDate2.BOSComment = "";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSDataMember = "ReturnSupplierToDate";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSDataSource = "APReturnSuppliers";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSDescription = null;
            this.fld_dteSearchToAPReturnSupplierDate2.BOSError = "";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSFieldGroup = "";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSFieldRelation = null;
            this.fld_dteSearchToAPReturnSupplierDate2.BOSPrivilege = "";
            this.fld_dteSearchToAPReturnSupplierDate2.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPReturnSupplierDate2.EditValue = null;
            this.fld_dteSearchToAPReturnSupplierDate2.Location = new System.Drawing.Point(306, 190);
            this.fld_dteSearchToAPReturnSupplierDate2.Name = "fld_dteSearchToAPReturnSupplierDate2";
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPReturnSupplierDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPReturnSupplierDate2.Screen = null;
            this.fld_dteSearchToAPReturnSupplierDate2.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchToAPReturnSupplierDate2.TabIndex = 3;
            this.fld_dteSearchToAPReturnSupplierDate2.Tag = "SC";
            // 
            // fld_dgcAPReturnSupplier
            // 
            this.fld_dgcAPReturnSupplier.AllowDrop = true;
            this.fld_dgcAPReturnSupplier.BOSComment = "";
            this.fld_dgcAPReturnSupplier.BOSDataMember = null;
            this.fld_dgcAPReturnSupplier.BOSDataSource = "APReturnSuppliers";
            this.fld_dgcAPReturnSupplier.BOSDescription = null;
            this.fld_dgcAPReturnSupplier.BOSError = "";
            this.fld_dgcAPReturnSupplier.BOSFieldGroup = "";
            this.fld_dgcAPReturnSupplier.BOSFieldRelation = null;
            this.fld_dgcAPReturnSupplier.BOSGridType = null;
            this.fld_dgcAPReturnSupplier.BOSPrivilege = "";
            this.fld_dgcAPReturnSupplier.BOSPropertyName = null;
            this.fld_dgcAPReturnSupplier.CommodityType = "";
            this.fld_dgcAPReturnSupplier.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPReturnSupplier.Location = new System.Drawing.Point(40, 236);
            this.fld_dgcAPReturnSupplier.MainView = this.fld_dgvAPReturnSupplier;
            this.fld_dgcAPReturnSupplier.Name = "fld_dgcAPReturnSupplier";
            this.fld_dgcAPReturnSupplier.PrintReport = false;
            this.fld_dgcAPReturnSupplier.Screen = null;
            this.fld_dgcAPReturnSupplier.Size = new System.Drawing.Size(411, 194);
            this.fld_dgcAPReturnSupplier.TabIndex = 11;
            this.fld_dgcAPReturnSupplier.Tag = "SR";
            this.fld_dgcAPReturnSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPReturnSupplier});
            // 
            // fld_dgvAPReturnSupplier
            // 
            this.fld_dgvAPReturnSupplier.GridControl = this.fld_dgcAPReturnSupplier;
            this.fld_dgvAPReturnSupplier.Name = "fld_dgvAPReturnSupplier";
            this.fld_dgvAPReturnSupplier.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(40, 12);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(28, 13);
            this.fld_lblLabel18.TabIndex = 17;
            this.fld_lblLabel18.Tag = "SI";
            this.fld_lblLabel18.Text = "Mã số";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = null;
            this.fld_lblLabel19.Location = new System.Drawing.Point(40, 48);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(18, 13);
            this.fld_lblLabel19.TabIndex = 18;
            this.fld_lblLabel19.Tag = "SI";
            this.fld_lblLabel19.Text = "Tên";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = null;
            this.fld_lblLabel22.Location = new System.Drawing.Point(40, 193);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel22.TabIndex = 21;
            this.fld_lblLabel22.Tag = "SI";
            this.fld_lblLabel22.Text = "Từ ngày";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = null;
            this.fld_lblLabel23.Location = new System.Drawing.Point(277, 193);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel23.TabIndex = 22;
            this.fld_lblLabel23.Tag = "SI";
            this.fld_lblLabel23.Text = "Đến";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(114, 117);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeFName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = "";
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = "";
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = "";
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(114, 81);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierNo";
            this.fld_lkeFK_APSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 4;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(40, 120);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel4.TabIndex = 30;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Nhân viên";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(40, 84);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel10.TabIndex = 31;
            this.fld_lblLabel10.Tag = "SI";
            this.fld_lblLabel10.Text = "Nhà cung cấp";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(40, 157);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 90;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APReturnSuppliers";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(114, 154);
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
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 89;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMRS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(518, 479);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_txtAPReturnSupplierNo1);
            this.Controls.Add(this.fld_txtAPReturnSupplierName1);
            this.Controls.Add(this.fld_dteSearchFromAPReturnSupplierDate1);
            this.Controls.Add(this.fld_dteSearchToAPReturnSupplierDate2);
            this.Controls.Add(this.fld_dgcAPReturnSupplier);
            this.Controls.Add(this.fld_lblLabel18);
            this.Controls.Add(this.fld_lblLabel19);
            this.Controls.Add(this.fld_lblLabel22);
            this.Controls.Add(this.fld_lblLabel23);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lblLabel10);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMRS100.IconOptions.Icon")));
            this.Name = "SMRS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel10, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel23, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel22, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel19, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel18, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPReturnSupplier, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPReturnSupplierDate2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPReturnSupplierDate1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierName1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPReturnSupplierNo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPReturnSupplierName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPReturnSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPReturnSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
    }
}
