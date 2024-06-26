using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleForecast.UI
{
	/// <summary>
	/// Summary description for SMSF100
	/// </summary>
	partial class SMSF100
	{
		private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
		private BOSSearchResultsGridControl fld_dgcARSaleForecast;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleForecastDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleForecastDate;
		private BOSComponent.BOSTextBox fld_txtARSaleForecastNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;


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
            this.fld_dgcARSaleForecast = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromARSaleForecastDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARSaleForecastDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARSaleForecastNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleForecastDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleForecastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleForecastDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleForecastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(20, 48);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 5;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(19, 74);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel12.TabIndex = 6;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Khách hàng";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(20, 126);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 7;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(20, 178);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 8;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(316, 178);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 11;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcARSaleForecast
            // 
            this.fld_dgcARSaleForecast.AllowDrop = true;
            this.fld_dgcARSaleForecast.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleForecast.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleForecast.BOSDataSource = "ARSaleForecasts";
            this.fld_dgcARSaleForecast.BOSDescription = null;
            this.fld_dgcARSaleForecast.BOSError = null;
            this.fld_dgcARSaleForecast.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleForecast.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleForecast.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleForecast.BOSPropertyName = null;
            this.fld_dgcARSaleForecast.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleForecast.Location = new System.Drawing.Point(19, 254);
            this.fld_dgcARSaleForecast.MainView = this.fld_dgvGridControl;
            this.fld_dgcARSaleForecast.Name = "fld_dgcARSaleForecast";
            this.fld_dgcARSaleForecast.Screen = null;
            this.fld_dgcARSaleForecast.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcARSaleForecast.TabIndex = 9;
            this.fld_dgcARSaleForecast.Tag = "SR";
            this.fld_dgcARSaleForecast.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARSaleForecast;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromARSaleForecastDate
            // 
            this.fld_dteSearchFromARSaleForecastDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARSaleForecastDate.BOSDataMember = "SaleForecastFromDate";
            this.fld_dteSearchFromARSaleForecastDate.BOSDataSource = "ARSaleForecasts";
            this.fld_dteSearchFromARSaleForecastDate.BOSDescription = null;
            this.fld_dteSearchFromARSaleForecastDate.BOSError = null;
            this.fld_dteSearchFromARSaleForecastDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARSaleForecastDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARSaleForecastDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARSaleForecastDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleForecastDate.EditValue = null;
            this.fld_dteSearchFromARSaleForecastDate.Location = new System.Drawing.Point(135, 175);
            this.fld_dteSearchFromARSaleForecastDate.Name = "fld_dteSearchFromARSaleForecastDate";
            this.fld_dteSearchFromARSaleForecastDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleForecastDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleForecastDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleForecastDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleForecastDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleForecastDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleForecastDate.Screen = null;
            this.fld_dteSearchFromARSaleForecastDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARSaleForecastDate.TabIndex = 5;
            this.fld_dteSearchFromARSaleForecastDate.Tag = "SC";
            // 
            // fld_dteSearchToARSaleForecastDate
            // 
            this.fld_dteSearchToARSaleForecastDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARSaleForecastDate.BOSDataMember = "SaleForecastToDate";
            this.fld_dteSearchToARSaleForecastDate.BOSDataSource = "ARSaleForecasts";
            this.fld_dteSearchToARSaleForecastDate.BOSDescription = null;
            this.fld_dteSearchToARSaleForecastDate.BOSError = null;
            this.fld_dteSearchToARSaleForecastDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARSaleForecastDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARSaleForecastDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARSaleForecastDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleForecastDate.EditValue = null;
            this.fld_dteSearchToARSaleForecastDate.Location = new System.Drawing.Point(350, 175);
            this.fld_dteSearchToARSaleForecastDate.Name = "fld_dteSearchToARSaleForecastDate";
            this.fld_dteSearchToARSaleForecastDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleForecastDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleForecastDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleForecastDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleForecastDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleForecastDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleForecastDate.Screen = null;
            this.fld_dteSearchToARSaleForecastDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARSaleForecastDate.TabIndex = 6;
            this.fld_dteSearchToARSaleForecastDate.Tag = "SC";
            // 
            // fld_txtARSaleForecastNo
            // 
            this.fld_txtARSaleForecastNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleForecastNo.BOSDataMember = "ARSaleForecastNo";
            this.fld_txtARSaleForecastNo.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastNo.BOSDescription = null;
            this.fld_txtARSaleForecastNo.BOSError = null;
            this.fld_txtARSaleForecastNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleForecastNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleForecastNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleForecastNo.BOSPropertyName = "EditValue";
            this.fld_txtARSaleForecastNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleForecastNo.Location = new System.Drawing.Point(135, 45);
            this.fld_txtARSaleForecastNo.Name = "fld_txtARSaleForecastNo";
            this.fld_txtARSaleForecastNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleForecastNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleForecastNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleForecastNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleForecastNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleForecastNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleForecastNo.Screen = null;
            this.fld_txtARSaleForecastNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleForecastNo.TabIndex = 0;
            this.fld_txtARSaleForecastNo.Tag = "SC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(135, 71);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 1;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(135, 123);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(20, 152);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Người bán";
            // 
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSellerID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeFK_ARSellerID.BOSDescription = null;
            this.fld_lkeFK_ARSellerID.BOSError = null;
            this.fld_lkeFK_ARSellerID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSellerID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.Location = new System.Drawing.Point(135, 149);
            this.fld_lkeFK_ARSellerID.Name = "fld_lkeFK_ARSellerID";
            this.fld_lkeFK_ARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_ARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARSellerID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARSellerID.Screen = null;
            this.fld_lkeFK_ARSellerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSellerID.TabIndex = 4;
            this.fld_lkeFK_ARSellerID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(20, 100);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 88;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARSaleForecasts";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(135, 97);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMSF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dgcARSaleForecast);
            this.Controls.Add(this.fld_dteSearchFromARSaleForecastDate);
            this.Controls.Add(this.fld_dteSearchToARSaleForecastDate);
            this.Controls.Add(this.fld_txtARSaleForecastNo);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Name = "SMSF100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSellerID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleForecastNo, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARSaleForecastDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARSaleForecastDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleForecast, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleForecastDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleForecastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleForecastDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleForecastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
