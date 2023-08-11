using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ChangeBOMInformation.UI
{
	/// <summary>
	/// Summary description for SMCBI100
	/// </summary>
	partial class SMCBI100
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
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMChangeBOMInformationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMChangeBOMInformationDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMChangeBOMInformationDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMChangeBOMInformationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMChangeBOMInformations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMChangeBOMInformations = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMChangeBOMInformationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMChangeBOMInformationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMChangeBOMInformations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMChangeBOMInformations)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(24, 69);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 372;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Đơn hàng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(24, 41);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, true);
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 373;
            this.fld_lblLabel10.Tag = "SI";
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = null;
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(92, 66);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDesc", "Ghi chú")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 361;
            this.fld_lkeFK_ARSaleOrderID.Tag = "SC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(92, 38);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên KH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "ĐT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerTaxNumber", "MST"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerWebsite", "Website")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARCustomerID, true);
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 362;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // fld_dgcFK_MMBatchProductID
            // 
            this.fld_dgcFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_dgcFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_dgcFK_MMBatchProductID.BOSComment = null;
            this.fld_dgcFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_dgcFK_MMBatchProductID.BOSDescription = null;
            this.fld_dgcFK_MMBatchProductID.BOSError = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_dgcFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_dgcFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_dgcFK_MMBatchProductID.BOSSelectType = null;
            this.fld_dgcFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_dgcFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_dgcFK_MMBatchProductID.Location = new System.Drawing.Point(378, 38);
            this.fld_dgcFK_MMBatchProductID.Name = "fld_dgcFK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dgcFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductName", "Tên")});
            this.fld_dgcFK_MMBatchProductID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_dgcFK_MMBatchProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dgcFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Screen = null;
            this.fld_dgcFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_dgcFK_MMBatchProductID.TabIndex = 360;
            this.fld_dgcFK_MMBatchProductID.Tag = "SC";
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
            this.bosLabel5.Location = new System.Drawing.Point(310, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(34, 13);
            this.bosLabel5.TabIndex = 371;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Mã LSX";
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
            this.bosLabel4.Location = new System.Drawing.Point(310, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 370;
            this.bosLabel4.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(378, 64);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 358;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeMMChangeBOMInformationStatus
            // 
            this.fld_lkeMMChangeBOMInformationStatus.BOSAllowAddNew = false;
            this.fld_lkeMMChangeBOMInformationStatus.BOSAllowDummy = false;
            this.fld_lkeMMChangeBOMInformationStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSDataMember = "MMChangeBOMInformationStatus";
            this.fld_lkeMMChangeBOMInformationStatus.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeMMChangeBOMInformationStatus.BOSDescription = null;
            this.fld_lkeMMChangeBOMInformationStatus.BOSError = null;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMChangeBOMInformationStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.Location = new System.Drawing.Point(378, 12);
            this.fld_lkeMMChangeBOMInformationStatus.Name = "fld_lkeMMChangeBOMInformationStatus";
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMChangeBOMInformationStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMChangeBOMInformationStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMChangeBOMInformationStatus, true);
            this.fld_lkeMMChangeBOMInformationStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMChangeBOMInformationStatus.TabIndex = 359;
            this.fld_lkeMMChangeBOMInformationStatus.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(310, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 369;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteMMChangeBOMInformationDateTo
            // 
            this.fld_dteMMChangeBOMInformationDateTo.BOSComment = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSDataMember = "MMChangeBOMInformationDateTo";
            this.fld_dteMMChangeBOMInformationDateTo.BOSDataSource = "MMChangeBOMInformations";
            this.fld_dteMMChangeBOMInformationDateTo.BOSDescription = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSError = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSFieldGroup = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSFieldRelation = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSPrivilege = null;
            this.fld_dteMMChangeBOMInformationDateTo.BOSPropertyName = "EditValue";
            this.fld_dteMMChangeBOMInformationDateTo.EditValue = null;
            this.fld_dteMMChangeBOMInformationDateTo.Location = new System.Drawing.Point(378, 92);
            this.fld_dteMMChangeBOMInformationDateTo.Name = "fld_dteMMChangeBOMInformationDateTo";
            this.fld_dteMMChangeBOMInformationDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMChangeBOMInformationDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMChangeBOMInformationDateTo.Screen = null;
            this.fld_dteMMChangeBOMInformationDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMChangeBOMInformationDateTo.TabIndex = 364;
            this.fld_dteMMChangeBOMInformationDateTo.Tag = "SC";
            // 
            // fld_dteMMChangeBOMInformationDateFrom
            // 
            this.fld_dteMMChangeBOMInformationDateFrom.BOSComment = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSDataMember = "MMChangeBOMInformationDateFrom";
            this.fld_dteMMChangeBOMInformationDateFrom.BOSDataSource = "MMChangeBOMInformations";
            this.fld_dteMMChangeBOMInformationDateFrom.BOSDescription = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSError = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSFieldGroup = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSFieldRelation = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSPrivilege = null;
            this.fld_dteMMChangeBOMInformationDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteMMChangeBOMInformationDateFrom.EditValue = null;
            this.fld_dteMMChangeBOMInformationDateFrom.Location = new System.Drawing.Point(92, 92);
            this.fld_dteMMChangeBOMInformationDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteMMChangeBOMInformationDateFrom.Name = "fld_dteMMChangeBOMInformationDateFrom";
            this.fld_dteMMChangeBOMInformationDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMChangeBOMInformationDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMChangeBOMInformationDateFrom.Screen = null;
            this.fld_dteMMChangeBOMInformationDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMChangeBOMInformationDateFrom.TabIndex = 363;
            this.fld_dteMMChangeBOMInformationDateFrom.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(24, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 366;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(310, 95);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 367;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(24, 95);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 368;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_txtMMChangeBOMInformationNo
            // 
            this.fld_txtMMChangeBOMInformationNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMChangeBOMInformationNo.BOSDataMember = "MMChangeBOMInformationNo";
            this.fld_txtMMChangeBOMInformationNo.BOSDataSource = "MMChangeBOMInformations";
            this.fld_txtMMChangeBOMInformationNo.BOSDescription = null;
            this.fld_txtMMChangeBOMInformationNo.BOSError = null;
            this.fld_txtMMChangeBOMInformationNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMChangeBOMInformationNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMChangeBOMInformationNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMChangeBOMInformationNo.BOSPropertyName = "Text";
            this.fld_txtMMChangeBOMInformationNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMChangeBOMInformationNo.Location = new System.Drawing.Point(92, 12);
            this.fld_txtMMChangeBOMInformationNo.Name = "fld_txtMMChangeBOMInformationNo";
            this.fld_txtMMChangeBOMInformationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMChangeBOMInformationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMChangeBOMInformationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMChangeBOMInformationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMChangeBOMInformationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMChangeBOMInformationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMChangeBOMInformationNo.Screen = null;
            this.fld_txtMMChangeBOMInformationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMChangeBOMInformationNo.TabIndex = 357;
            this.fld_txtMMChangeBOMInformationNo.Tag = "SC";
            // 
            // fld_dgcMMChangeBOMInformations
            // 
            this.fld_dgcMMChangeBOMInformations.AllowDrop = true;
            this.fld_dgcMMChangeBOMInformations.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.BOSDataSource = "MMChangeBOMInformations";
            this.fld_dgcMMChangeBOMInformations.BOSDescription = null;
            this.fld_dgcMMChangeBOMInformations.BOSError = null;
            this.fld_dgcMMChangeBOMInformations.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMChangeBOMInformations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMChangeBOMInformations.Location = new System.Drawing.Point(92, 211);
            this.fld_dgcMMChangeBOMInformations.MainView = this.fld_dgvMMChangeBOMInformations;
            this.fld_dgcMMChangeBOMInformations.Name = "fld_dgcMMChangeBOMInformations";
            this.fld_dgcMMChangeBOMInformations.Screen = null;
            this.fld_dgcMMChangeBOMInformations.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMChangeBOMInformations.TabIndex = 365;
            this.fld_dgcMMChangeBOMInformations.Tag = "SR";
            this.fld_dgcMMChangeBOMInformations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMChangeBOMInformations});
            // 
            // fld_dgvMMChangeBOMInformations
            // 
            this.fld_dgvMMChangeBOMInformations.GridControl = this.fld_dgcMMChangeBOMInformations;
            this.fld_dgvMMChangeBOMInformations.Name = "fld_dgvMMChangeBOMInformations";
            this.fld_dgvMMChangeBOMInformations.PaintStyleName = "Office2003";
            // 
            // SMCBI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(550, 567);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_dgcFK_MMBatchProductID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeMMChangeBOMInformationStatus);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteMMChangeBOMInformationDateTo);
            this.Controls.Add(this.fld_dteMMChangeBOMInformationDateFrom);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMChangeBOMInformationNo);
            this.Controls.Add(this.fld_dgcMMChangeBOMInformations);
            this.Name = "SMCBI100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMChangeBOMInformations, 0);
            this.Controls.SetChildIndex(this.fld_txtMMChangeBOMInformationNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteMMChangeBOMInformationDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteMMChangeBOMInformationDateTo, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMChangeBOMInformationStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dgcFK_MMBatchProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMChangeBOMInformationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMChangeBOMInformationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMChangeBOMInformations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMChangeBOMInformations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_dgcFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMChangeBOMInformationStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteMMChangeBOMInformationDateTo;
        private BOSComponent.BOSDateEdit fld_dteMMChangeBOMInformationDateFrom;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMChangeBOMInformationNo;
        private BOSSearchResultsGridControl fld_dgcMMChangeBOMInformations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMChangeBOMInformations;
        private IContainer components;
	}
}
