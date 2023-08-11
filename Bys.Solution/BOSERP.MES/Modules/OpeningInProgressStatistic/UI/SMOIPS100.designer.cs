using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OpeningInProgressStatistic.UI
{
	/// <summary>
	/// Summary description for SMOIPS100
	/// </summary>
	partial class SMOIPS100
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
            this.fld_dgcMMInProgressStatistic = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMInProgressStatisticNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMInProgressStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMInProgressStatisticNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMInProgressStatistic
            // 
            this.fld_dgcMMInProgressStatistic.BOSComment = null;
            this.fld_dgcMMInProgressStatistic.BOSDataMember = null;
            this.fld_dgcMMInProgressStatistic.BOSDataSource = "MMInProgressStatistics";
            this.fld_dgcMMInProgressStatistic.BOSDescription = null;
            this.fld_dgcMMInProgressStatistic.BOSError = null;
            this.fld_dgcMMInProgressStatistic.BOSFieldGroup = null;
            this.fld_dgcMMInProgressStatistic.BOSFieldRelation = null;
            this.fld_dgcMMInProgressStatistic.BOSPrivilege = null;
            this.fld_dgcMMInProgressStatistic.BOSPropertyName = null;
            this.fld_dgcMMInProgressStatistic.Location = new System.Drawing.Point(24, 139);
            this.fld_dgcMMInProgressStatistic.MenuManager = this.screenToolbar;
            this.fld_dgcMMInProgressStatistic.Name = "fld_dgcMMInProgressStatistic";
            this.fld_dgcMMInProgressStatistic.Screen = null;
            this.fld_dgcMMInProgressStatistic.Size = new System.Drawing.Size(432, 366);
            this.fld_dgcMMInProgressStatistic.TabIndex = 15;
            this.fld_dgcMMInProgressStatistic.Tag = "SR";
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
            this.bosLabel1.Location = new System.Drawing.Point(24, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtMMInProgressStatisticNo1
            // 
            this.fld_txtMMInProgressStatisticNo1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMInProgressStatisticNo1.BOSDataMember = "MMInProgressStatisticNo";
            this.fld_txtMMInProgressStatisticNo1.BOSDataSource = "MMInProgressStatistics";
            this.fld_txtMMInProgressStatisticNo1.BOSDescription = null;
            this.fld_txtMMInProgressStatisticNo1.BOSError = null;
            this.fld_txtMMInProgressStatisticNo1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMInProgressStatisticNo1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMInProgressStatisticNo1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMInProgressStatisticNo1.BOSPropertyName = "Text";
            this.fld_txtMMInProgressStatisticNo1.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMInProgressStatisticNo1.Location = new System.Drawing.Point(138, 9);
            this.fld_txtMMInProgressStatisticNo1.Name = "fld_txtMMInProgressStatisticNo1";
            this.fld_txtMMInProgressStatisticNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMInProgressStatisticNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMInProgressStatisticNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMInProgressStatisticNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMInProgressStatisticNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMInProgressStatisticNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMInProgressStatisticNo1.Screen = null;
            this.fld_txtMMInProgressStatisticNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMInProgressStatisticNo1.TabIndex = 11;
            this.fld_txtMMInProgressStatisticNo1.Tag = "SC";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(138, 35);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 555;
            this.fld_lkeFK_MMBatchProductID.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(24, 38);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(68, 13);
            this.bosLabel8.TabIndex = 556;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Lệnh sản xuất";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMInProgressStatistics";
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
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(138, 61);
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
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 596;
            this.fld_lkeFK_ARSaleOrderID.Tag = "SC";
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
            this.bosLabel4.Location = new System.Drawing.Point(24, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(68, 13);
            this.bosLabel4.TabIndex = 597;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đơn bán hàng";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(138, 87);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 598;
            this.fld_lkeFK_HRDepartmentID.Tag = "SC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(24, 90);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(43, 13);
            this.bosLabel21.TabIndex = 599;
            this.bosLabel21.Tag = "SI";
            this.bosLabel21.Text = "Xí nghiệp";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(138, 113);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Phân xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMWorkShopID, true);
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 600;
            this.fld_lkeFK_MMWorkShopID.Tag = "SC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(24, 116);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(58, 13);
            this.bosLabel7.TabIndex = 601;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Phân xưởng";
            // 
            // SMOIPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(471, 517);
            this.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.Controls.Add(this.bosLabel21);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_dgcMMInProgressStatistic);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMInProgressStatisticNo1);
            this.Name = "SMOIPS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMInProgressStatisticNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMInProgressStatistic, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMBatchProductID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.bosLabel21, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMWorkShopID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMInProgressStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMInProgressStatisticNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMInProgressStatistic;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMInProgressStatisticNo1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel7;
	}
}
