using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for DMHRM104
	/// </summary>
	partial class DMHRM104
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
            this.fld_dteSearchHistoryToDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApplyView = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteSearchHistoryFromDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcHRTimeKeeperHistoryDetails = new BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperHistoryDetailsGridControl();
            this.fld_lkeHREmployeeIDHistoryView = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentIDHistoryView = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeePayrollFormulaIDView = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeIDHistoryView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentIDHistoryView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.Location = new System.Drawing.Point(534, 38);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel20.TabIndex = 50;
            this.fld_lblLabel20.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.Text = "Đến ngày";
            // 
            // fld_dteSearchHistoryToDateView
            // 
            this.fld_dteSearchHistoryToDateView.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSDescription = null;
            this.fld_dteSearchHistoryToDateView.BOSError = null;
            this.fld_dteSearchHistoryToDateView.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryToDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchHistoryToDateView.EditValue = null;
            this.fld_dteSearchHistoryToDateView.Location = new System.Drawing.Point(587, 35);
            this.fld_dteSearchHistoryToDateView.Name = "fld_dteSearchHistoryToDateView";
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHistoryToDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHistoryToDateView.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteSearchHistoryToDateView.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHistoryToDateView.Screen = null;
            this.fld_dteSearchHistoryToDateView.Size = new System.Drawing.Size(133, 20);
            this.fld_dteSearchHistoryToDateView.TabIndex = 5;
            this.fld_dteSearchHistoryToDateView.Tag = "DC";
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
            this.fld_btnApplyView.Location = new System.Drawing.Point(760, 12);
            this.fld_btnApplyView.Name = "fld_btnApplyView";
            this.fld_btnApplyView.Screen = null;
            this.fld_btnApplyView.Size = new System.Drawing.Size(75, 39);
            this.fld_btnApplyView.TabIndex = 6;
            this.fld_btnApplyView.Text = "Xem";
            this.fld_btnApplyView.Click += new System.EventHandler(this.fld_btnApplyView_Click);
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
            this.bosPanel1.Controls.Add(this.fld_dteSearchHistoryFromDateView);
            this.bosPanel1.Controls.Add(this.fld_dgcHRTimeKeeperHistoryDetails);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeIDHistoryView);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentIDHistoryView);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomIDHistoryView);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel11);
            this.bosPanel1.Controls.Add(this.fld_btnApplyView);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaIDView);
            this.bosPanel1.Controls.Add(this.fld_dteSearchHistoryToDateView);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 57;
            // 
            // fld_dteSearchHistoryFromDateView
            // 
            this.fld_dteSearchHistoryFromDateView.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSDescription = null;
            this.fld_dteSearchHistoryFromDateView.BOSError = null;
            this.fld_dteSearchHistoryFromDateView.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchHistoryFromDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchHistoryFromDateView.EditValue = null;
            this.fld_dteSearchHistoryFromDateView.Location = new System.Drawing.Point(587, 9);
            this.fld_dteSearchHistoryFromDateView.Name = "fld_dteSearchHistoryFromDateView";
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHistoryFromDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHistoryFromDateView.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteSearchHistoryFromDateView.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fld_dteSearchHistoryFromDateView.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteSearchHistoryFromDateView.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHistoryFromDateView.Screen = null;
            this.fld_dteSearchHistoryFromDateView.Size = new System.Drawing.Size(133, 20);
            this.fld_dteSearchHistoryFromDateView.TabIndex = 108;
            this.fld_dteSearchHistoryFromDateView.Tag = "DC";
            // 
            // fld_dgcHRTimeKeeperHistoryDetails
            // 
            this.fld_dgcHRTimeKeeperHistoryDetails.AllowDrop = true;
            this.fld_dgcHRTimeKeeperHistoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSComment = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSDataMember = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSDataSource = "HRTimeKeeperHistoryDetails";
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSDescription = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSError = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSFieldGroup = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSFieldRelation = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSGridType = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSPrivilege = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.BOSPropertyName = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.Location = new System.Drawing.Point(3, 64);
            this.fld_dgcHRTimeKeeperHistoryDetails.MenuManager = this.screenToolbar;
            this.fld_dgcHRTimeKeeperHistoryDetails.Name = "fld_dgcHRTimeKeeperHistoryDetails";
            this.fld_dgcHRTimeKeeperHistoryDetails.PrintReport = false;
            this.fld_dgcHRTimeKeeperHistoryDetails.Screen = null;
            this.fld_dgcHRTimeKeeperHistoryDetails.Size = new System.Drawing.Size(856, 500);
            this.fld_dgcHRTimeKeeperHistoryDetails.TabIndex = 107;
            this.fld_dgcHRTimeKeeperHistoryDetails.Tag = "DC";
            // 
            // fld_lkeHREmployeeIDHistoryView
            // 
            this.fld_lkeHREmployeeIDHistoryView.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeIDHistoryView.BOSAllowDummy = true;
            this.fld_lkeHREmployeeIDHistoryView.BOSComment = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeIDHistoryView.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeIDHistoryView.BOSDescription = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSError = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSFieldGroup = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSFieldParent = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSFieldRelation = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSPrivilege = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeIDHistoryView.BOSSelectType = null;
            this.fld_lkeHREmployeeIDHistoryView.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeIDHistoryView.CurrentDisplayText = null;
            this.fld_lkeHREmployeeIDHistoryView.Location = new System.Drawing.Point(349, 35);
            this.fld_lkeHREmployeeIDHistoryView.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeIDHistoryView.Name = "fld_lkeHREmployeeIDHistoryView";
            this.fld_lkeHREmployeeIDHistoryView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeIDHistoryView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeHREmployeeIDHistoryView.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeIDHistoryView.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeIDHistoryView.Screen = null;
            this.fld_lkeHREmployeeIDHistoryView.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeHREmployeeIDHistoryView.TabIndex = 4;
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
            this.bosLabel3.Location = new System.Drawing.Point(295, 38);
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
            this.bosLabel2.Location = new System.Drawing.Point(292, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 104;
            this.bosLabel2.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentIDHistoryView
            // 
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSError = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Location = new System.Drawing.Point(349, 9);
            this.fld_lkeFK_HRDepartmentIDHistoryView.Name = "fld_lkeFK_HRDepartmentIDHistoryView";
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentIDHistoryView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentIDHistoryView, true);
            this.fld_lkeFK_HRDepartmentIDHistoryView.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_HRDepartmentIDHistoryView.TabIndex = 1;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentIDHistoryView.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentIDHistoryView_Validated);
            // 
            // fld_lkeFK_HRDepartmentRoomIDHistoryView
            // 
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Location = new System.Drawing.Point(110, 35);
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Name = "fld_lkeFK_HRDepartmentRoomIDHistoryView";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomIDHistoryView, true);
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
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
            this.bosLabel1.Location = new System.Drawing.Point(22, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(81, 13);
            this.bosLabel1.TabIndex = 103;
            this.bosLabel1.Text = "Nhóm chấm công";
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
            this.fld_lblLabel11.Location = new System.Drawing.Point(22, 38);
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
            this.BOSLabel4.Location = new System.Drawing.Point(534, 12);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel4.TabIndex = 53;
            this.BOSLabel4.Text = "Từ ngày";
            // 
            // fld_lkeFK_HREmployeePayrollFormulaIDView
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSPropertyName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Location = new System.Drawing.Point(110, 9);
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Name = "fld_lkeFK_HREmployeePayrollFormulaIDView";
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaNo", "Mã nhóm chấm công"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Tên nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.TabIndex = 0;
            this.fld_lkeFK_HREmployeePayrollFormulaIDView.Tag = global::Localization.CommonLocalizedResources.String2;
            // 
            // DMHRM104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRM104";
            this.Text = "Lịch sử sửa công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeIDHistoryView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentIDHistoryView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomIDHistoryView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaIDView.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSDateEdit fld_dteSearchHistoryToDateView;
        private BOSComponent.BOSButton fld_btnApplyView;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeIDHistoryView;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentIDHistoryView;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomIDHistoryView;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel BOSLabel4;
        private HRTimeKeeperHistoryDetailsGridControl fld_dgcHRTimeKeeperHistoryDetails;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaIDView;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchHistoryFromDateView;
	}
}
