using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProduct.UI
{
	/// <summary>
	/// Summary description for SMBP100
	/// </summary>
	partial class SMBP100
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
            this.fld_dgcMMBatchProducts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMBatchProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMBatchProductStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToMMBatchProductDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromMMBatchProductDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMBatchProductNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMBatchProductDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMBatchProductDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMBatchProductDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMBatchProductDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMBatchProductNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMBatchProducts
            // 
            this.fld_dgcMMBatchProducts.AllowDrop = true;
            this.fld_dgcMMBatchProducts.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.BOSDataSource = "MMBatchProducts";
            this.fld_dgcMMBatchProducts.BOSDescription = null;
            this.fld_dgcMMBatchProducts.BOSError = null;
            this.fld_dgcMMBatchProducts.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMBatchProducts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMBatchProducts.Location = new System.Drawing.Point(48, 256);
            this.fld_dgcMMBatchProducts.MainView = this.fld_dgvMMBatchProducts;
            this.fld_dgcMMBatchProducts.Name = "fld_dgcMMBatchProducts";
            this.fld_dgcMMBatchProducts.Screen = null;
            this.fld_dgcMMBatchProducts.Size = new System.Drawing.Size(492, 200);
            this.fld_dgcMMBatchProducts.TabIndex = 20;
            this.fld_dgcMMBatchProducts.Tag = "SR";
            this.fld_dgcMMBatchProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMBatchProducts});
            // 
            // fld_dgvMMBatchProducts
            // 
            this.fld_dgvMMBatchProducts.GridControl = this.fld_dgcMMBatchProducts;
            this.fld_dgvMMBatchProducts.Name = "fld_dgvMMBatchProducts";
            this.fld_dgvMMBatchProducts.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(147, 129);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên KH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNoOfOldSys", "Mã HT cũ")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerNo";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 364;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
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
            this.bosLabel5.Location = new System.Drawing.Point(47, 132);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 365;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(147, 103);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã Sale order"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderPONo", "Số PO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderPODate", "Ngày PO")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 362;
            this.fld_lkeFK_ARSaleOrderID.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(47, 106);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(51, 13);
            this.bosLabel8.TabIndex = 363;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Sale Order";
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
            this.bosLabel4.Location = new System.Drawing.Point(47, 54);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 361;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(147, 51);
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
            this.fld_lkeFK_HREmployeeID.TabIndex = 353;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeMMBatchProductStatus
            // 
            this.fld_lkeMMBatchProductStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSDataMember = "MMBatchProductStatus";
            this.fld_lkeMMBatchProductStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductStatus.BOSError = null;
            this.fld_lkeMMBatchProductStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.Location = new System.Drawing.Point(147, 77);
            this.fld_lkeMMBatchProductStatus.Name = "fld_lkeMMBatchProductStatus";
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductStatus, true);
            this.fld_lkeMMBatchProductStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMBatchProductStatus.TabIndex = 354;
            this.fld_lkeMMBatchProductStatus.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(47, 80);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 360;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteSearchToMMBatchProductDate
            // 
            this.fld_dteSearchToMMBatchProductDate.BOSComment = null;
            this.fld_dteSearchToMMBatchProductDate.BOSDataMember = "BatchProductDateTo";
            this.fld_dteSearchToMMBatchProductDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteSearchToMMBatchProductDate.BOSDescription = null;
            this.fld_dteSearchToMMBatchProductDate.BOSError = null;
            this.fld_dteSearchToMMBatchProductDate.BOSFieldGroup = null;
            this.fld_dteSearchToMMBatchProductDate.BOSFieldRelation = null;
            this.fld_dteSearchToMMBatchProductDate.BOSPrivilege = null;
            this.fld_dteSearchToMMBatchProductDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMBatchProductDate.EditValue = null;
            this.fld_dteSearchToMMBatchProductDate.Location = new System.Drawing.Point(389, 155);
            this.fld_dteSearchToMMBatchProductDate.Name = "fld_dteSearchToMMBatchProductDate";
            this.fld_dteSearchToMMBatchProductDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMBatchProductDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMBatchProductDate.Screen = null;
            this.fld_dteSearchToMMBatchProductDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMBatchProductDate.TabIndex = 356;
            this.fld_dteSearchToMMBatchProductDate.Tag = "SC";
            // 
            // fld_dteSearchFromMMBatchProductDate
            // 
            this.fld_dteSearchFromMMBatchProductDate.BOSComment = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSDataMember = "BatchProductDateFrom";
            this.fld_dteSearchFromMMBatchProductDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteSearchFromMMBatchProductDate.BOSDescription = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSError = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSFieldGroup = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSFieldRelation = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSPrivilege = null;
            this.fld_dteSearchFromMMBatchProductDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMBatchProductDate.EditValue = null;
            this.fld_dteSearchFromMMBatchProductDate.Location = new System.Drawing.Point(147, 155);
            this.fld_dteSearchFromMMBatchProductDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromMMBatchProductDate.Name = "fld_dteSearchFromMMBatchProductDate";
            this.fld_dteSearchFromMMBatchProductDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMBatchProductDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMBatchProductDate.Screen = null;
            this.fld_dteSearchFromMMBatchProductDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMBatchProductDate.TabIndex = 355;
            this.fld_dteSearchFromMMBatchProductDate.Tag = "SC";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(47, 28);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(82, 13);
            this.fld_lblLabel.TabIndex = 357;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã lệnh sản xuất";
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
            this.bosLabel2.Location = new System.Drawing.Point(328, 158);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 358;
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
            this.bosLabel1.Location = new System.Drawing.Point(47, 158);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 359;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_txtMMBatchProductNo
            // 
            this.fld_txtMMBatchProductNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMBatchProductNo.BOSDataMember = "MMBatchProductNo";
            this.fld_txtMMBatchProductNo.BOSDataSource = "MMBatchProducts";
            this.fld_txtMMBatchProductNo.BOSDescription = null;
            this.fld_txtMMBatchProductNo.BOSError = null;
            this.fld_txtMMBatchProductNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMBatchProductNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMBatchProductNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMBatchProductNo.BOSPropertyName = "Text";
            this.fld_txtMMBatchProductNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMBatchProductNo.Location = new System.Drawing.Point(147, 25);
            this.fld_txtMMBatchProductNo.Name = "fld_txtMMBatchProductNo";
            this.fld_txtMMBatchProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMBatchProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMBatchProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMBatchProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMBatchProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMBatchProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMBatchProductNo.Screen = null;
            this.fld_txtMMBatchProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMBatchProductNo.TabIndex = 352;
            this.fld_txtMMBatchProductNo.Tag = "SC";
            // 
            // SMBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeMMBatchProductStatus);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteSearchToMMBatchProductDate);
            this.Controls.Add(this.fld_dteSearchFromMMBatchProductDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMBatchProductNo);
            this.Controls.Add(this.fld_dgcMMBatchProducts);
            this.Name = "SMBP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMBatchProducts, 0);
            this.Controls.SetChildIndex(this.fld_txtMMBatchProductNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMBatchProductDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToMMBatchProductDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMBatchProductStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMBatchProductDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMBatchProductDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMBatchProductDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMBatchProductDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMBatchProductNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMBatchProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMBatchProducts;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMBatchProductDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromMMBatchProductDate;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMBatchProductNo;
	}
}
