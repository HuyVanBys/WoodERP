using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvoiceIn.UI
{
	/// <summary>
	/// Summary description for SMII100
	/// </summary>
	partial class SMII100
	{
		private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSSearchResultsGridControl fld_dgcAPInvoiceIn;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPInvoiceIn;
		private BOSComponent.BOSDateEdit fld_dteSearchFromAPInvoiceInDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPInvoiceInDate;


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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAPInvoiceIn = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPInvoiceIn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInSupplierNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.Location = new System.Drawing.Point(20, 48);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel11.TabIndex = 5;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã hóa đơn";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel12.Location = new System.Drawing.Point(19, 99);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel12.TabIndex = 6;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Đối tượng";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.Location = new System.Drawing.Point(20, 125);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 7;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.Location = new System.Drawing.Point(20, 177);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(81, 13);
            this.fld_lblLabel14.TabIndex = 8;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày hóa đơn từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.Location = new System.Drawing.Point(308, 177);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 11;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_txtAPInvoiceInNo
            // 
            this.fld_txtAPInvoiceInNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInNo.BOSDataMember = "APInvoiceInNo";
            this.fld_txtAPInvoiceInNo.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInNo.BOSDescription = null;
            this.fld_txtAPInvoiceInNo.BOSError = null;
            this.fld_txtAPInvoiceInNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInNo.Location = new System.Drawing.Point(135, 45);
            this.fld_txtAPInvoiceInNo.Name = "fld_txtAPInvoiceInNo";
            this.fld_txtAPInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInNo.Screen = null;
            this.fld_txtAPInvoiceInNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPInvoiceInNo.TabIndex = 0;
            this.fld_txtAPInvoiceInNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(135, 122);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dgcAPInvoiceIn
            // 
            this.fld_dgcAPInvoiceIn.AllowDrop = true;
            this.fld_dgcAPInvoiceIn.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.BOSDataSource = "APInvoiceIns";
            this.fld_dgcAPInvoiceIn.BOSDescription = null;
            this.fld_dgcAPInvoiceIn.BOSError = null;
            this.fld_dgcAPInvoiceIn.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcAPInvoiceIn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPInvoiceIn.Location = new System.Drawing.Point(20, 234);
            this.fld_dgcAPInvoiceIn.MainView = this.fld_dgvAPInvoiceIn;
            this.fld_dgcAPInvoiceIn.Name = "fld_dgcAPInvoiceIn";
            this.fld_dgcAPInvoiceIn.Screen = null;
            this.fld_dgcAPInvoiceIn.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPInvoiceIn.TabIndex = 14;
            this.fld_dgcAPInvoiceIn.Tag = "SR";
            this.fld_dgcAPInvoiceIn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPInvoiceIn});
            // 
            // fld_dgvAPInvoiceIn
            // 
            this.fld_dgvAPInvoiceIn.GridControl = this.fld_dgcAPInvoiceIn;
            this.fld_dgvAPInvoiceIn.Name = "fld_dgvAPInvoiceIn";
            this.fld_dgvAPInvoiceIn.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromAPInvoiceInDate
            // 
            this.fld_dteSearchFromAPInvoiceInDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataMember = "InvoiceInDateFrom";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchFromAPInvoiceInDate.Location = new System.Drawing.Point(135, 174);
            this.fld_dteSearchFromAPInvoiceInDate.Name = "fld_dteSearchFromAPInvoiceInDate";
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPInvoiceInDate.Screen = null;
            this.fld_dteSearchFromAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPInvoiceInDate.TabIndex = 5;
            this.fld_dteSearchFromAPInvoiceInDate.Tag = "SC";
            // 
            // fld_dteSearchToAPInvoiceInDate
            // 
            this.fld_dteSearchToAPInvoiceInDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToAPInvoiceInDate.BOSDataMember = "InvoiceInDateTo";
            this.fld_dteSearchToAPInvoiceInDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteSearchToAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToAPInvoiceInDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToAPInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchToAPInvoiceInDate.Location = new System.Drawing.Point(342, 174);
            this.fld_dteSearchToAPInvoiceInDate.Name = "fld_dteSearchToAPInvoiceInDate";
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPInvoiceInDate.Screen = null;
            this.fld_dteSearchToAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPInvoiceInDate.TabIndex = 6;
            this.fld_dteSearchToAPInvoiceInDate.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.Location = new System.Drawing.Point(19, 73);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(80, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã hóa đơn NCC";
            // 
            // fld_txtAPInvoiceInSupplierNo1
            // 
            this.fld_txtAPInvoiceInSupplierNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInSupplierNo1.BOSDataMember = "APInvoiceInSupplierNo";
            this.fld_txtAPInvoiceInSupplierNo1.BOSDataSource = "APInvoiceIns";
            this.fld_txtAPInvoiceInSupplierNo1.BOSDescription = null;
            this.fld_txtAPInvoiceInSupplierNo1.BOSError = null;
            this.fld_txtAPInvoiceInSupplierNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInSupplierNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInSupplierNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInSupplierNo1.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInSupplierNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPInvoiceInSupplierNo1.Location = new System.Drawing.Point(135, 70);
            this.fld_txtAPInvoiceInSupplierNo1.Name = "fld_txtAPInvoiceInSupplierNo1";
            this.fld_txtAPInvoiceInSupplierNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInSupplierNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInSupplierNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInSupplierNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInSupplierNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInSupplierNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInSupplierNo1.Screen = null;
            this.fld_txtAPInvoiceInSupplierNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPInvoiceInSupplierNo1.TabIndex = 1;
            this.fld_txtAPInvoiceInSupplierNo1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.Location = new System.Drawing.Point(20, 151);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 18;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(135, 148);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 4;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(135, 96);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 589;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // SMII100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_txtAPInvoiceInSupplierNo1);
            this.Controls.Add(this.fld_txtAPInvoiceInNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dgcAPInvoiceIn);
            this.Controls.Add(this.fld_dteSearchFromAPInvoiceInDate);
            this.Controls.Add(this.fld_dteSearchToAPInvoiceInDate);
            this.Name = "SMII100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToAPInvoiceInDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPInvoiceInDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPInvoiceIn, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtAPInvoiceInNo, 0);
            this.Controls.SetChildIndex(this.fld_txtAPInvoiceInSupplierNo1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInSupplierNo1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}
