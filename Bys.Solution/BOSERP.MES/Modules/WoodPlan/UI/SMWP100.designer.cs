using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WoodPlan.UI
{
	/// <summary>
	/// Summary description for SMWP100
	/// </summary>
	partial class SMWP100
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
            this.fld_lkeMMWoodPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMWoodPlanDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMWoodPlanDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWoodPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMWoodPlans = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMBatchItemPlans = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWoodPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWoodPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchItemPlans)).BeginInit();
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
            this.bosLabel6.Location = new System.Drawing.Point(14, 67);
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
            this.fld_lblLabel10.Location = new System.Drawing.Point(14, 41);
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
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMWoodPlans";
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
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(82, 64);
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
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMWoodPlans";
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
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(82, 38);
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
            this.fld_dgcFK_MMBatchProductID.BOSDataSource = "MMWoodPlans";
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
            this.fld_dgcFK_MMBatchProductID.Location = new System.Drawing.Point(348, 38);
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
            this.bosLabel5.Location = new System.Drawing.Point(280, 41);
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
            this.bosLabel4.Location = new System.Drawing.Point(280, 67);
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
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMWoodPlans";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(348, 64);
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
            // fld_lkeMMWoodPlanStatus
            // 
            this.fld_lkeMMWoodPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeMMWoodPlanStatus.BOSAllowDummy = false;
            this.fld_lkeMMWoodPlanStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSDataMember = "MMWoodPlanStatus";
            this.fld_lkeMMWoodPlanStatus.BOSDataSource = "MMWoodPlans";
            this.fld_lkeMMWoodPlanStatus.BOSDescription = null;
            this.fld_lkeMMWoodPlanStatus.BOSError = null;
            this.fld_lkeMMWoodPlanStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMWoodPlanStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.Location = new System.Drawing.Point(348, 12);
            this.fld_lkeMMWoodPlanStatus.Name = "fld_lkeMMWoodPlanStatus";
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMWoodPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMWoodPlanStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMWoodPlanStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMWoodPlanStatus, true);
            this.fld_lkeMMWoodPlanStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMWoodPlanStatus.TabIndex = 359;
            this.fld_lkeMMWoodPlanStatus.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(280, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 369;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteMMWoodPlanDateTo
            // 
            this.fld_dteMMWoodPlanDateTo.BOSComment = null;
            this.fld_dteMMWoodPlanDateTo.BOSDataMember = "MMWoodPlanDateTo";
            this.fld_dteMMWoodPlanDateTo.BOSDataSource = "MMWoodPlans";
            this.fld_dteMMWoodPlanDateTo.BOSDescription = null;
            this.fld_dteMMWoodPlanDateTo.BOSError = null;
            this.fld_dteMMWoodPlanDateTo.BOSFieldGroup = null;
            this.fld_dteMMWoodPlanDateTo.BOSFieldRelation = null;
            this.fld_dteMMWoodPlanDateTo.BOSPrivilege = null;
            this.fld_dteMMWoodPlanDateTo.BOSPropertyName = "EditValue";
            this.fld_dteMMWoodPlanDateTo.EditValue = null;
            this.fld_dteMMWoodPlanDateTo.Location = new System.Drawing.Point(348, 90);
            this.fld_dteMMWoodPlanDateTo.Name = "fld_dteMMWoodPlanDateTo";
            this.fld_dteMMWoodPlanDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMWoodPlanDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMWoodPlanDateTo.Screen = null;
            this.fld_dteMMWoodPlanDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMWoodPlanDateTo.TabIndex = 364;
            this.fld_dteMMWoodPlanDateTo.Tag = "SC";
            // 
            // fld_dteMMWoodPlanDateFrom
            // 
            this.fld_dteMMWoodPlanDateFrom.BOSComment = null;
            this.fld_dteMMWoodPlanDateFrom.BOSDataMember = "MMWoodPlanDateFrom";
            this.fld_dteMMWoodPlanDateFrom.BOSDataSource = "MMWoodPlans";
            this.fld_dteMMWoodPlanDateFrom.BOSDescription = null;
            this.fld_dteMMWoodPlanDateFrom.BOSError = null;
            this.fld_dteMMWoodPlanDateFrom.BOSFieldGroup = null;
            this.fld_dteMMWoodPlanDateFrom.BOSFieldRelation = null;
            this.fld_dteMMWoodPlanDateFrom.BOSPrivilege = null;
            this.fld_dteMMWoodPlanDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteMMWoodPlanDateFrom.EditValue = null;
            this.fld_dteMMWoodPlanDateFrom.Location = new System.Drawing.Point(82, 90);
            this.fld_dteMMWoodPlanDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteMMWoodPlanDateFrom.Name = "fld_dteMMWoodPlanDateFrom";
            this.fld_dteMMWoodPlanDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMWoodPlanDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMWoodPlanDateFrom.Screen = null;
            this.fld_dteMMWoodPlanDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMWoodPlanDateFrom.TabIndex = 363;
            this.fld_dteMMWoodPlanDateFrom.Tag = "SC";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(14, 15);
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
            this.bosLabel2.Location = new System.Drawing.Point(280, 93);
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
            this.bosLabel1.Location = new System.Drawing.Point(14, 93);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 368;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_txtMMWoodPlanNo
            // 
            this.fld_txtMMWoodPlanNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMWoodPlanNo.BOSDataMember = "MMWoodPlanNo";
            this.fld_txtMMWoodPlanNo.BOSDataSource = "MMWoodPlans";
            this.fld_txtMMWoodPlanNo.BOSDescription = null;
            this.fld_txtMMWoodPlanNo.BOSError = null;
            this.fld_txtMMWoodPlanNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMWoodPlanNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMWoodPlanNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMWoodPlanNo.BOSPropertyName = "Text";
            this.fld_txtMMWoodPlanNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMWoodPlanNo.Location = new System.Drawing.Point(82, 12);
            this.fld_txtMMWoodPlanNo.Name = "fld_txtMMWoodPlanNo";
            this.fld_txtMMWoodPlanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWoodPlanNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWoodPlanNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWoodPlanNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWoodPlanNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWoodPlanNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWoodPlanNo.Screen = null;
            this.fld_txtMMWoodPlanNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMWoodPlanNo.TabIndex = 357;
            this.fld_txtMMWoodPlanNo.Tag = "SC";
            // 
            // fld_dgcMMWoodPlans
            // 
            this.fld_dgcMMWoodPlans.AllowDrop = true;
            this.fld_dgcMMWoodPlans.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.BOSDataSource = "MMWoodPlans";
            this.fld_dgcMMWoodPlans.BOSDescription = null;
            this.fld_dgcMMWoodPlans.BOSError = null;
            this.fld_dgcMMWoodPlans.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMWoodPlans.Location = new System.Drawing.Point(82, 211);
            this.fld_dgcMMWoodPlans.MainView = this.fld_dgvMMBatchItemPlans;
            this.fld_dgcMMWoodPlans.Name = "fld_dgcMMWoodPlans";
            this.fld_dgcMMWoodPlans.Screen = null;
            this.fld_dgcMMWoodPlans.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMWoodPlans.TabIndex = 365;
            this.fld_dgcMMWoodPlans.Tag = "SR";
            this.fld_dgcMMWoodPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMBatchItemPlans});
            // 
            // fld_dgvMMBatchItemPlans
            // 
            this.fld_dgvMMBatchItemPlans.GridControl = this.fld_dgcMMWoodPlans;
            this.fld_dgvMMBatchItemPlans.Name = "fld_dgvMMBatchItemPlans";
            this.fld_dgvMMBatchItemPlans.PaintStyleName = "Office2003";
            // 
            // SMWP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(510, 567);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_dgcFK_MMBatchProductID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeMMWoodPlanStatus);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteMMWoodPlanDateTo);
            this.Controls.Add(this.fld_dteMMWoodPlanDateFrom);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMWoodPlanNo);
            this.Controls.Add(this.fld_dgcMMWoodPlans);
            this.Name = "SMWP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMWoodPlans, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWoodPlanNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteMMWoodPlanDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteMMWoodPlanDateTo, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMWoodPlanStatus, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWoodPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWoodPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchItemPlans)).EndInit();
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
        private BOSComponent.BOSLookupEdit fld_lkeMMWoodPlanStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteMMWoodPlanDateTo;
        private BOSComponent.BOSDateEdit fld_dteMMWoodPlanDateFrom;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMWoodPlanNo;
        private BOSSearchResultsGridControl fld_dgcMMWoodPlans;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMBatchItemPlans;
        private IContainer components;
	}
}
