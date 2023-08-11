using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for DMHRM102
	/// </summary>
	partial class DMHRM102
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
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRTimeKeeperCompletes = new BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperCompletesGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeePayrollFormulaID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchCalculateFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchCalculateToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperCompletes)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(822, 12);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 8;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(822, 45);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 9;
            this.fld_btnSave.Text = "Lưu giờ công";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_dgcHRTimeKeeperCompletes
            // 
            this.fld_dgcHRTimeKeeperCompletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimeKeeperCompletes.BOSComment = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSDataMember = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSDataSource = "HRTimeKeeperCompletes";
            this.fld_dgcHRTimeKeeperCompletes.BOSDescription = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSError = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSFieldGroup = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSFieldRelation = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSGridType = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSPrivilege = null;
            this.fld_dgcHRTimeKeeperCompletes.BOSPropertyName = null;
            this.fld_dgcHRTimeKeeperCompletes.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRTimeKeeperCompletes.Location = new System.Drawing.Point(3, 94);
            this.fld_dgcHRTimeKeeperCompletes.MenuManager = this.screenToolbar;
            this.fld_dgcHRTimeKeeperCompletes.Name = "fld_dgcHRTimeKeeperCompletes";
            this.fld_dgcHRTimeKeeperCompletes.PrintReport = false;
            this.fld_dgcHRTimeKeeperCompletes.Screen = null;
            this.fld_dgcHRTimeKeeperCompletes.Size = new System.Drawing.Size(1052, 473);
            this.fld_dgcHRTimeKeeperCompletes.TabIndex = 10;
            this.fld_dgcHRTimeKeeperCompletes.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaID1);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeID2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel11);
            this.bosPanel1.Controls.Add(this.fld_dteSearchCalculateFromDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel22);
            this.bosPanel1.Controls.Add(this.fld_dteSearchCalculateToDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_dgcHRTimeKeeperCompletes);
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1058, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_HRDepartmentRoomGroupTeamItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Location = new System.Drawing.Point(638, 38);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupTeamItemName", "Thông tin nhóm")});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID, true);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.TabIndex = 5;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(374, 38);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupItemID, true);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_EditValueChanged);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(574, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(27, 13);
            this.bosLabel4.TabIndex = 109;
            this.bosLabel4.Text = "Nhóm";
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
            this.bosLabel5.Location = new System.Drawing.Point(286, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(12, 13);
            this.bosLabel5.TabIndex = 108;
            this.bosLabel5.Text = "Tổ";
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
            this.bosLabel1.Location = new System.Drawing.Point(286, 67);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(81, 13);
            this.bosLabel1.TabIndex = 105;
            this.bosLabel1.Text = "Nhóm chấm công";
            // 
            // fld_lkeFK_HREmployeePayrollFormulaID1
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSPropertyName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Location = new System.Drawing.Point(374, 64);
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Name = "fld_lkeFK_HREmployeePayrollFormulaID1";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaNo", "Mã nhóm chấm công"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Tên nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaID1.TabIndex = 7;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_lkeHREmployeeID2
            // 
            this.fld_lkeHREmployeeID2.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID2.BOSAllowDummy = true;
            this.fld_lkeHREmployeeID2.BOSComment = null;
            this.fld_lkeHREmployeeID2.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeID2.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeID2.BOSDescription = null;
            this.fld_lkeHREmployeeID2.BOSError = null;
            this.fld_lkeHREmployeeID2.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID2.BOSFieldParent = null;
            this.fld_lkeHREmployeeID2.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID2.BOSPrivilege = null;
            this.fld_lkeHREmployeeID2.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeID2.BOSSelectType = null;
            this.fld_lkeHREmployeeID2.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID2.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID2.Location = new System.Drawing.Point(78, 64);
            this.fld_lkeHREmployeeID2.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeID2.Name = "fld_lkeHREmployeeID2";
            this.fld_lkeHREmployeeID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID2.Properties.ColumnName = null;
            this.fld_lkeHREmployeeID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeCardNumber", "Mã chấm công")});
            this.fld_lkeHREmployeeID2.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID2.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID2.Screen = null;
            this.fld_lkeHREmployeeID2.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeHREmployeeID2.TabIndex = 6;
            this.fld_lkeHREmployeeID2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHREmployeeID2_QueryPopUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(14, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 99;
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
            this.bosLabel2.Location = new System.Drawing.Point(574, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 98;
            this.bosLabel2.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(638, 12);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 2;
            this.fld_lkeFK_HRDepartmentID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentID_EditValueChanged);
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(78, 38);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomID_EditValueChanged);
            this.fld_lkeFK_HRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID_QueryPopUp);
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
            this.fld_lblLabel11.Location = new System.Drawing.Point(14, 41);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel11.TabIndex = 97;
            this.fld_lblLabel11.Text = "Bộ phận";
            // 
            // fld_dteSearchCalculateFromDate
            // 
            this.fld_dteSearchCalculateFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSDescription = null;
            this.fld_dteSearchCalculateFromDate.BOSError = null;
            this.fld_dteSearchCalculateFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchCalculateFromDate.EditValue = null;
            this.fld_dteSearchCalculateFromDate.Location = new System.Drawing.Point(78, 12);
            this.fld_dteSearchCalculateFromDate.Name = "fld_dteSearchCalculateFromDate";
            this.fld_dteSearchCalculateFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchCalculateFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchCalculateFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchCalculateFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchCalculateFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchCalculateFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchCalculateFromDate.Screen = null;
            this.fld_dteSearchCalculateFromDate.Size = new System.Drawing.Size(168, 20);
            this.fld_dteSearchCalculateFromDate.TabIndex = 0;
            this.fld_dteSearchCalculateFromDate.Tag = "DC";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.Location = new System.Drawing.Point(286, 15);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 95;
            this.fld_lblLabel22.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_dteSearchCalculateToDate
            // 
            this.fld_dteSearchCalculateToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSDescription = null;
            this.fld_dteSearchCalculateToDate.BOSError = null;
            this.fld_dteSearchCalculateToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchCalculateToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchCalculateToDate.EditValue = null;
            this.fld_dteSearchCalculateToDate.Location = new System.Drawing.Point(374, 12);
            this.fld_dteSearchCalculateToDate.Name = "fld_dteSearchCalculateToDate";
            this.fld_dteSearchCalculateToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchCalculateToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchCalculateToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchCalculateToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchCalculateToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchCalculateToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchCalculateToDate.Screen = null;
            this.fld_dteSearchCalculateToDate.Size = new System.Drawing.Size(168, 20);
            this.fld_dteSearchCalculateToDate.TabIndex = 1;
            this.fld_dteSearchCalculateToDate.Tag = "DC";
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.Location = new System.Drawing.Point(14, 15);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 94;
            this.fld_lblLabel20.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // DMHRM102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRM102";
            this.Text = "Xác định giờ công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeeperCompletes)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchCalculateToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnSave;
        private HRTimeKeeperCompletesGridControl fld_dgcHRTimeKeeperCompletes;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSDateEdit fld_dteSearchCalculateFromDate;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSDateEdit fld_dteSearchCalculateToDate;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaID1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupTeamItemID;
	}
}
