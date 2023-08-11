using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for DMHRM101
	/// </summary>
	partial class DMHRM101
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
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRMachineTimeKeeperID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnApplyDelete = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRMachineTimeKeeperID3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRMachineTimeKeeperToID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperID3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).BeginInit();
            this.bosGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperToID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeID);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.BOSLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRMachineTimeKeeperID);
            this.bosGroupControl1.Location = new System.Drawing.Point(12, 12);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(351, 121);
            this.bosGroupControl1.TabIndex = 15;
            this.bosGroupControl1.Text = "Cập nhật thông tin nhân viên từ...";
            // 
            // fld_lkeHREmployeeID
            // 
            this.fld_lkeHREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeID.BOSComment = null;
            this.fld_lkeHREmployeeID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeID.BOSDescription = null;
            this.fld_lkeHREmployeeID.BOSError = null;
            this.fld_lkeHREmployeeID.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(143, 47);
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeCardNumber", "ID", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.InvoiceLocalizedResources.Contact2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeHREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeID, true);
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHREmployeeID.TabIndex = 0;
            this.fld_lkeHREmployeeID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(89, 50);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 85;
            this.bosLabel3.Text = "Nhân viên";
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
            this.BOSLabel4.Location = new System.Drawing.Point(47, 76);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(90, 13);
            this.BOSLabel4.TabIndex = 12;
            this.BOSLabel4.Text = "Từ máy chấm công";
            // 
            // fld_lkeHRMachineTimeKeeperID
            // 
            this.fld_lkeHRMachineTimeKeeperID.BOSAllowAddNew = false;
            this.fld_lkeHRMachineTimeKeeperID.BOSAllowDummy = false;
            this.fld_lkeHRMachineTimeKeeperID.BOSComment = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSDataMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperID.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_lkeHRMachineTimeKeeperID.BOSDescription = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSError = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSFieldGroup = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSFieldParent = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSFieldRelation = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSPrivilege = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSPropertyName = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSSelectType = null;
            this.fld_lkeHRMachineTimeKeeperID.BOSSelectTypeValue = null;
            this.fld_lkeHRMachineTimeKeeperID.CurrentDisplayText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperID.Location = new System.Drawing.Point(143, 73);
            this.fld_lkeHRMachineTimeKeeperID.MenuManager = this.screenToolbar;
            this.fld_lkeHRMachineTimeKeeperID.Name = "fld_lkeHRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMachineTimeKeeperID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperNo", "Mã máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperName", "Tên máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperIP", "Địa chỉ IP")});
            this.fld_lkeHRMachineTimeKeeperID.Properties.DisplayMember = "HRMachineTimeKeeperName";
            this.fld_lkeHRMachineTimeKeeperID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMachineTimeKeeperID.Properties.ValueMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperID.Screen = null;
            this.fld_lkeHRMachineTimeKeeperID.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHRMachineTimeKeeperID.TabIndex = 1;
            this.fld_lkeHRMachineTimeKeeperID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
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
            this.fld_btnApply.Location = new System.Drawing.Point(369, 62);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 11;
            this.fld_btnApply.Text = "Đồng bộ >>";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_btnApplyDelete);
            this.bosGroupControl3.Controls.Add(this.bosLabel6);
            this.bosGroupControl3.Controls.Add(this.fld_lkeHRMachineTimeKeeperID3);
            this.bosGroupControl3.Location = new System.Drawing.Point(12, 139);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(442, 69);
            this.bosGroupControl3.TabIndex = 88;
            this.bosGroupControl3.Text = "Xóa dữ liệu trên máy chấm công";
            // 
            // fld_btnApplyDelete
            // 
            this.fld_btnApplyDelete.BOSComment = null;
            this.fld_btnApplyDelete.BOSDataMember = null;
            this.fld_btnApplyDelete.BOSDataSource = null;
            this.fld_btnApplyDelete.BOSDescription = null;
            this.fld_btnApplyDelete.BOSError = null;
            this.fld_btnApplyDelete.BOSFieldGroup = null;
            this.fld_btnApplyDelete.BOSFieldRelation = null;
            this.fld_btnApplyDelete.BOSPrivilege = null;
            this.fld_btnApplyDelete.BOSPropertyName = null;
            this.fld_btnApplyDelete.Location = new System.Drawing.Point(357, 28);
            this.fld_btnApplyDelete.Name = "fld_btnApplyDelete";
            this.fld_btnApplyDelete.Screen = null;
            this.fld_btnApplyDelete.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApplyDelete.TabIndex = 11;
            this.fld_btnApplyDelete.Text = "Xóa";
            this.fld_btnApplyDelete.Click += new System.EventHandler(this.fld_btnApplyDelete_Click);
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(21, 28);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(116, 13);
            this.bosLabel6.TabIndex = 12;
            this.bosLabel6.Text = "Chọn máy  cần cập nhật";
            // 
            // fld_lkeHRMachineTimeKeeperID3
            // 
            this.fld_lkeHRMachineTimeKeeperID3.BOSAllowAddNew = false;
            this.fld_lkeHRMachineTimeKeeperID3.BOSAllowDummy = true;
            this.fld_lkeHRMachineTimeKeeperID3.BOSComment = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSDataMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperID3.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_lkeHRMachineTimeKeeperID3.BOSDescription = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSError = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSFieldGroup = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSFieldParent = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSFieldRelation = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSPrivilege = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSPropertyName = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSSelectType = null;
            this.fld_lkeHRMachineTimeKeeperID3.BOSSelectTypeValue = null;
            this.fld_lkeHRMachineTimeKeeperID3.CurrentDisplayText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperID3.Location = new System.Drawing.Point(143, 25);
            this.fld_lkeHRMachineTimeKeeperID3.MenuManager = this.screenToolbar;
            this.fld_lkeHRMachineTimeKeeperID3.Name = "fld_lkeHRMachineTimeKeeperID3";
            this.fld_lkeHRMachineTimeKeeperID3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMachineTimeKeeperID3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperNo", "Mã máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperName", "Tên máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperIP", "Địa chỉ IP")});
            this.fld_lkeHRMachineTimeKeeperID3.Properties.DisplayMember = "HRMachineTimeKeeperName";
            this.fld_lkeHRMachineTimeKeeperID3.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperID3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMachineTimeKeeperID3.Properties.ValueMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperID3.Screen = null;
            this.fld_lkeHRMachineTimeKeeperID3.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHRMachineTimeKeeperID3.TabIndex = 0;
            this.fld_lkeHRMachineTimeKeeperID3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // bosGroupControl4
            // 
            this.bosGroupControl4.BOSComment = null;
            this.bosGroupControl4.BOSDataMember = null;
            this.bosGroupControl4.BOSDataSource = null;
            this.bosGroupControl4.BOSDescription = null;
            this.bosGroupControl4.BOSError = null;
            this.bosGroupControl4.BOSFieldGroup = null;
            this.bosGroupControl4.BOSFieldRelation = null;
            this.bosGroupControl4.BOSPrivilege = null;
            this.bosGroupControl4.BOSPropertyName = null;
            this.bosGroupControl4.Controls.Add(this.bosLabel7);
            this.bosGroupControl4.Controls.Add(this.fld_lkeHRMachineTimeKeeperToID);
            this.bosGroupControl4.Location = new System.Drawing.Point(450, 12);
            this.bosGroupControl4.Name = "bosGroupControl4";
            this.bosGroupControl4.Screen = null;
            this.bosGroupControl4.Size = new System.Drawing.Size(351, 121);
            this.bosGroupControl4.TabIndex = 89;
            this.bosGroupControl4.Text = "Cập nhật thông tin nhân viên đến ...";
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
            this.bosLabel7.Location = new System.Drawing.Point(5, 60);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(97, 13);
            this.bosLabel7.TabIndex = 12;
            this.bosLabel7.Text = "Đến máy chấm công";
            // 
            // fld_lkeHRMachineTimeKeeperToID
            // 
            this.fld_lkeHRMachineTimeKeeperToID.BOSAllowAddNew = false;
            this.fld_lkeHRMachineTimeKeeperToID.BOSAllowDummy = false;
            this.fld_lkeHRMachineTimeKeeperToID.BOSComment = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSDataMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperToID.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_lkeHRMachineTimeKeeperToID.BOSDescription = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSError = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSFieldGroup = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSFieldParent = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSFieldRelation = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSPrivilege = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSPropertyName = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSSelectType = null;
            this.fld_lkeHRMachineTimeKeeperToID.BOSSelectTypeValue = null;
            this.fld_lkeHRMachineTimeKeeperToID.CurrentDisplayText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperToID.Location = new System.Drawing.Point(108, 57);
            this.fld_lkeHRMachineTimeKeeperToID.MenuManager = this.screenToolbar;
            this.fld_lkeHRMachineTimeKeeperToID.Name = "fld_lkeHRMachineTimeKeeperToID";
            this.fld_lkeHRMachineTimeKeeperToID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMachineTimeKeeperToID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperNo", "Mã máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperName", "Tên máy"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRMachineTimeKeeperIP", "Địa chỉ IP")});
            this.fld_lkeHRMachineTimeKeeperToID.Properties.DisplayMember = "HRMachineTimeKeeperName";
            this.fld_lkeHRMachineTimeKeeperToID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRMachineTimeKeeperToID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMachineTimeKeeperToID.Properties.ValueMember = "HRMachineTimeKeeperID";
            this.fld_lkeHRMachineTimeKeeperToID.Screen = null;
            this.fld_lkeHRMachineTimeKeeperToID.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHRMachineTimeKeeperToID.TabIndex = 0;
            this.fld_lkeHRMachineTimeKeeperToID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // DMHRM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosGroupControl4);
            this.Controls.Add(this.bosGroupControl3);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosGroupControl1);
            this.Name = "DMHRM101";
            this.Text = "Đồng bộ dữ liệu";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.bosGroupControl3, 0);
            this.Controls.SetChildIndex(this.bosGroupControl4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperID3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).EndInit();
            this.bosGroupControl4.ResumeLayout(false);
            this.bosGroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMachineTimeKeeperToID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRMachineTimeKeeperID;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private BOSComponent.BOSButton fld_btnApplyDelete;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeHRMachineTimeKeeperID3;
        private BOSComponent.BOSGroupControl bosGroupControl4;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeHRMachineTimeKeeperToID;
	}
}
