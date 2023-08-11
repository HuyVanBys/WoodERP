using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for DMHRM103
	/// </summary>
	partial class DMHRM103
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
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApplyView = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRTimeKeeperCompletesView = new BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperCompleteViewsGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeePayrollFormulaID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSaveTimeKeeperComplete = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMWorkShopID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeIDView = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentIDView = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomIDView = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRMachineTimeKeeperIDView = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperCompletesView)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorkShopID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeIDView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentIDView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomIDView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperIDView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.Location = new System.Drawing.Point(33, 12);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 50;
            this.fld_lblLabel20.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDateView
            // 
            this.fld_dteSearchFromDateView.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSDescription = null;
            this.fld_dteSearchFromDateView.BOSError = null;
            this.fld_dteSearchFromDateView.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromDateView.EditValue = null;
            this.fld_dteSearchFromDateView.Location = new System.Drawing.Point(87, 9);
            this.fld_dteSearchFromDateView.Name = "fld_dteSearchFromDateView";
            this.fld_dteSearchFromDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDateView.Screen = null;
            this.fld_dteSearchFromDateView.Size = new System.Drawing.Size(130, 20);
            this.fld_dteSearchFromDateView.TabIndex = 0;
            this.fld_dteSearchFromDateView.Tag = "DC";
            // 
            // fld_dteSearchToDateView
            // 
            this.fld_dteSearchToDateView.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSDescription = null;
            this.fld_dteSearchToDateView.BOSError = null;
            this.fld_dteSearchToDateView.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchToDateView.EditValue = null;
            this.fld_dteSearchToDateView.Location = new System.Drawing.Point(318, 9);
            this.fld_dteSearchToDateView.Name = "fld_dteSearchToDateView";
            this.fld_dteSearchToDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDateView.Screen = null;
            this.fld_dteSearchToDateView.Size = new System.Drawing.Size(133, 20);
            this.fld_dteSearchToDateView.TabIndex = 1;
            this.fld_dteSearchToDateView.Tag = "DC";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.Location = new System.Drawing.Point(230, 12);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 51;
            this.fld_lblLabel22.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_btnApplyView
            // 
            this.fld_btnApplyView.BOSComment = null;
            this.fld_btnApplyView.BOSDataMember = null;
            this.fld_btnApplyView.BOSDataSource = null;
            this.fld_btnApplyView.BOSDescription = null;
            this.fld_btnApplyView.BOSError = null;
            this.fld_btnApplyView.BOSFieldGroup = null;
            this.fld_btnApplyView.BOSFieldRelation = null;
            this.fld_btnApplyView.BOSPrivilege = null;
            this.fld_btnApplyView.BOSPropertyName = null;
            this.fld_btnApplyView.Location = new System.Drawing.Point(699, 5);
            this.fld_btnApplyView.Name = "fld_btnApplyView";
            this.fld_btnApplyView.Screen = null;
            this.fld_btnApplyView.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApplyView.TabIndex = 8;
            this.fld_btnApplyView.Text = "Xem";
            this.fld_btnApplyView.Click += new System.EventHandler(this.fld_btnApplyView_Click);
            // 
            // fld_dgcHRTimeKeeperCompletesView
            // 
            this.fld_dgcHRTimeKeeperCompletesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimeKeeperCompletesView.BOSComment = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSDataMember = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSDataSource = "HRTimeKeeperCompletes";
            this.fld_dgcHRTimeKeeperCompletesView.BOSDescription = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSError = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSFieldGroup = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSFieldRelation = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSGridType = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSPrivilege = null;
            this.fld_dgcHRTimeKeeperCompletesView.BOSPropertyName = null;
            this.fld_dgcHRTimeKeeperCompletesView.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRTimeKeeperCompletesView.Location = new System.Drawing.Point(3, 87);
            this.fld_dgcHRTimeKeeperCompletesView.MenuManager = this.screenToolbar;
            this.fld_dgcHRTimeKeeperCompletesView.Name = "fld_dgcHRTimeKeeperCompletesView";
            this.fld_dgcHRTimeKeeperCompletesView.PrintReport = false;
            this.fld_dgcHRTimeKeeperCompletesView.Screen = null;
            this.fld_dgcHRTimeKeeperCompletesView.Size = new System.Drawing.Size(1107, 480);
            this.fld_dgcHRTimeKeeperCompletesView.TabIndex = 10;
            this.fld_dgcHRTimeKeeperCompletesView.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemIDView);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaID2);
            this.bosPanel1.Controls.Add(this.fld_btnSaveTimeKeeperComplete);
            this.bosPanel1.Controls.Add(this.fld_lkeMMWorkShopID1);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeIDView);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentIDView);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomIDView);
            this.bosPanel1.Controls.Add(this.fld_lblLabel11);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDateView);
            this.bosPanel1.Controls.Add(this.fld_dgcHRTimeKeeperCompletesView);
            this.bosPanel1.Controls.Add(this.fld_btnApplyView);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel22);
            this.bosPanel1.Controls.Add(this.fld_lkeHRMachineTimeKeeperIDView);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDateView);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1110, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Location = new System.Drawing.Point(547, 35);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Name = "fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupTeamItemName", "Thông tin nhóm")});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView, true);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.TabIndex = 5;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemIDView
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Location = new System.Drawing.Point(318, 35);
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Name = "fld_lkeFK_HRDepartmentRoomGroupItemIDView";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupItemIDView, true);
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemIDView_EditValueChanged);
            this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(490, 38);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 114;
            this.bosLabel5.Text = "Nhóm";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(230, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(12, 13);
            this.bosLabel6.TabIndex = 113;
            this.bosLabel6.Text = "Tổ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(230, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(81, 13);
            this.bosLabel1.TabIndex = 110;
            this.bosLabel1.Text = "Nhóm chấm công";
            // 
            // fld_lkeFK_HREmployeePayrollFormulaID2
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSPropertyName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Location = new System.Drawing.Point(318, 61);
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Name = "fld_lkeFK_HREmployeePayrollFormulaID2";
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaNo", "Mã nhóm chấm công"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Tên nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaID2.TabIndex = 7;
            this.fld_lkeFK_HREmployeePayrollFormulaID2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_btnSaveTimeKeeperComplete
            // 
            this.fld_btnSaveTimeKeeperComplete.BOSComment = null;
            this.fld_btnSaveTimeKeeperComplete.BOSDataMember = null;
            this.fld_btnSaveTimeKeeperComplete.BOSDataSource = null;
            this.fld_btnSaveTimeKeeperComplete.BOSDescription = null;
            this.fld_btnSaveTimeKeeperComplete.BOSError = null;
            this.fld_btnSaveTimeKeeperComplete.BOSFieldGroup = null;
            this.fld_btnSaveTimeKeeperComplete.BOSFieldRelation = null;
            this.fld_btnSaveTimeKeeperComplete.BOSPrivilege = null;
            this.fld_btnSaveTimeKeeperComplete.BOSPropertyName = null;
            this.fld_btnSaveTimeKeeperComplete.Location = new System.Drawing.Point(699, 38);
            this.fld_btnSaveTimeKeeperComplete.Name = "fld_btnSaveTimeKeeperComplete";
            this.fld_btnSaveTimeKeeperComplete.Screen = null;
            this.fld_btnSaveTimeKeeperComplete.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSaveTimeKeeperComplete.TabIndex = 9;
            this.fld_btnSaveTimeKeeperComplete.Text = "Lưu";
            this.fld_btnSaveTimeKeeperComplete.Click += new System.EventHandler(this.fld_btnSaveTimeKeeperComplete_Click);
            // 
            // fld_lkeMMWorkShopID1
            // 
            this.fld_lkeMMWorkShopID1.BOSAllowAddNew = false;
            this.fld_lkeMMWorkShopID1.BOSAllowDummy = true;
            this.fld_lkeMMWorkShopID1.BOSComment = null;
            this.fld_lkeMMWorkShopID1.BOSDataMember = "MMWorkShopID";
            this.fld_lkeMMWorkShopID1.BOSDataSource = "MMWorkShops";
            this.fld_lkeMMWorkShopID1.BOSDescription = null;
            this.fld_lkeMMWorkShopID1.BOSError = null;
            this.fld_lkeMMWorkShopID1.BOSFieldGroup = null;
            this.fld_lkeMMWorkShopID1.BOSFieldParent = null;
            this.fld_lkeMMWorkShopID1.BOSFieldRelation = null;
            this.fld_lkeMMWorkShopID1.BOSPrivilege = null;
            this.fld_lkeMMWorkShopID1.BOSPropertyName = "EditValue";
            this.fld_lkeMMWorkShopID1.BOSSelectType = null;
            this.fld_lkeMMWorkShopID1.BOSSelectTypeValue = null;
            this.fld_lkeMMWorkShopID1.CurrentDisplayText = null;
            this.fld_lkeMMWorkShopID1.Location = new System.Drawing.Point(905, 35);
            this.fld_lkeMMWorkShopID1.Name = "fld_lkeMMWorkShopID1";
            this.fld_lkeMMWorkShopID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMWorkShopID1.Properties.ColumnName = null;
            this.fld_lkeMMWorkShopID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên xưởng")});
            this.fld_lkeMMWorkShopID1.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeMMWorkShopID1.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeMMWorkShopID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMWorkShopID1, true);
            this.fld_lkeMMWorkShopID1.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeMMWorkShopID1.TabIndex = 106;
            this.fld_lkeMMWorkShopID1.Tag = "DC";
            this.fld_lkeMMWorkShopID1.Visible = false;
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(825, 38);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 107;
            this.bosLabel17.Text = "Xưởng";
            this.bosLabel17.Visible = false;
            // 
            // fld_lkeHREmployeeIDView
            // 
            this.fld_lkeHREmployeeIDView.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeIDView.BOSAllowDummy = true;
            this.fld_lkeHREmployeeIDView.BOSComment = null;
            this.fld_lkeHREmployeeIDView.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeIDView.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeIDView.BOSDescription = null;
            this.fld_lkeHREmployeeIDView.BOSError = null;
            this.fld_lkeHREmployeeIDView.BOSFieldGroup = null;
            this.fld_lkeHREmployeeIDView.BOSFieldParent = null;
            this.fld_lkeHREmployeeIDView.BOSFieldRelation = null;
            this.fld_lkeHREmployeeIDView.BOSPrivilege = null;
            this.fld_lkeHREmployeeIDView.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeIDView.BOSSelectType = null;
            this.fld_lkeHREmployeeIDView.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeIDView.CurrentDisplayText = null;
            this.fld_lkeHREmployeeIDView.Location = new System.Drawing.Point(87, 61);
            this.fld_lkeHREmployeeIDView.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeIDView.Name = "fld_lkeHREmployeeIDView";
            this.fld_lkeHREmployeeIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeIDView.Properties.ColumnName = null;
            this.fld_lkeHREmployeeIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã Nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeHREmployeeIDView.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeIDView.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeIDView.Screen = null;
            this.fld_lkeHREmployeeIDView.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeHREmployeeIDView.TabIndex = 6;
            this.fld_lkeHREmployeeIDView.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHREmployeeIDView_QueryPopUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(33, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 105;
            this.bosLabel3.Text = "Nhân viên";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(490, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 104;
            this.bosLabel2.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentIDView
            // 
            this.fld_lkeFK_HRDepartmentIDView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentIDView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentIDView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentIDView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentIDView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSError = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentIDView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentIDView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentIDView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentIDView.Location = new System.Drawing.Point(547, 9);
            this.fld_lkeFK_HRDepartmentIDView.Name = "fld_lkeFK_HRDepartmentIDView";
            this.fld_lkeFK_HRDepartmentIDView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentIDView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentIDView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentIDView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentIDView.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentIDView.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentIDView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentIDView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentIDView.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentIDView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentIDView, true);
            this.fld_lkeFK_HRDepartmentIDView.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_HRDepartmentIDView.TabIndex = 2;
            this.fld_lkeFK_HRDepartmentIDView.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentIDView.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentIDView_EditValueChanged);
            // 
            // fld_lkeFK_HRDepartmentRoomIDView
            // 
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.Location = new System.Drawing.Point(84, 35);
            this.fld_lkeFK_HRDepartmentRoomIDView.Name = "fld_lkeFK_HRDepartmentRoomIDView";
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomIDView.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomIDView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomIDView, true);
            this.fld_lkeFK_HRDepartmentRoomIDView.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HRDepartmentRoomIDView.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentRoomIDView.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomIDView.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomIDView_EditValueChanged);
            this.fld_lkeFK_HRDepartmentRoomIDView.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomIDView_QueryPopUp);
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = null;
            this.fld_lblLabel11.BOSDataMember = null;
            this.fld_lblLabel11.BOSDataSource = null;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = null;
            this.fld_lblLabel11.BOSFieldRelation = null;
            this.fld_lblLabel11.BOSPrivilege = null;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(33, 38);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel11.TabIndex = 103;
            this.fld_lblLabel11.Text = "Bộ phận";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(825, 12);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(74, 13);
            this.BOSLabel4.TabIndex = 53;
            this.BOSLabel4.Text = "Máy chấm công";
            this.BOSLabel4.Visible = false;
            // 
            // fld_lkeHRMachineTimeKeeperIDView
            // 
            this.fld_lkeHRMachineTimeKeeperIDView.BOSAllowAddNew = false;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSAllowDummy = true;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSComment = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSDataMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperIDView.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_lkeHRMachineTimeKeeperIDView.BOSDescription = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSError = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSFieldGroup = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSFieldParent = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSFieldRelation = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSPrivilege = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSPropertyName = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSSelectType = null;
            this.fld_lkeHRMachineTimeKeeperIDView.BOSSelectTypeValue = null;
            this.fld_lkeHRMachineTimeKeeperIDView.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRMachineTimeKeeperIDView.Location = new System.Drawing.Point(905, 9);
            this.fld_lkeHRMachineTimeKeeperIDView.MenuManager = this.screenToolbar;
            this.fld_lkeHRMachineTimeKeeperIDView.Name = "fld_lkeHRMachineTimeKeeperIDView";
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.ColumnName = null;
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperNo", "Mã máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperName", "Tên máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperIP", "Địa chỉ IP")});
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.DisplayMember = "HRMachineTimeKeeperName";
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMachineTimeKeeperIDView.Properties.ValueMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperIDView.Screen = null;
            this.fld_lkeHRMachineTimeKeeperIDView.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeHRMachineTimeKeeperIDView.TabIndex = 2;
            this.fld_lkeHRMachineTimeKeeperIDView.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRMachineTimeKeeperIDView.Visible = false;
            // 
            // DMHRM103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1110, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRM103";
            this.Text = "Xem thông tin chấm công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperCompletesView)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemIDView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorkShopID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeIDView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentIDView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomIDView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperIDView.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDateView;
        private BOSComponent.BOSDateEdit fld_dteSearchToDateView;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSButton fld_btnApplyView;
        private IContainer components;
        private HRTimeKeeperCompleteViewsGridControl fld_dgcHRTimeKeeperCompletesView;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeIDView;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentIDView;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomIDView;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRMachineTimeKeeperIDView;
        private BOSComponent.BOSLookupEdit fld_lkeMMWorkShopID1;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSButton fld_btnSaveTimeKeeperComplete;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaID2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemIDView;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
	}
}
