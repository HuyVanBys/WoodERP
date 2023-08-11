using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for guiQuickImportTimeSheet
	/// </summary>
	partial class guiQuickImportTimeSheet
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ceHREmployeeHaveOutOfWorkIns = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtTimeFromDate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtTimeToDate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnViewQuickImport = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHREmployeeID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fld_dgcHREmployees = new BOSERP.Modules.ManagerTimeKeeper.HREmployeesGridControl();
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRTimeKeepers2 = new BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperGridControl2();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveOutOfWorkIns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTimeFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTimeToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeepers2)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(948, 623);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_ceHREmployeeHaveOutOfWorkIns);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtTimeFromDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtTimeToDate);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel20);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteSearchToDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel22);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnViewQuickImport);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeHREmployeeID2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl1.Controls.Add(this.splitContainer1);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 3);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(945, 617);
            this.fld_grcGroupControl1.TabIndex = 0;
            this.fld_grcGroupControl1.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.Text = "Kết nối máy chấm công";
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
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(77, 25);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 130;
            this.fld_lkeFK_HRDepartmentID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // fld_ceHREmployeeHaveOutOfWorkIns
            // 
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSComment = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDataMember = "HREmployeeHaveOutOfWorkIns";
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDataSource = "HREmployees";
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDescription = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSError = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSFieldGroup = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSFieldRelation = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSPrivilege = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSPropertyName = "EditValue";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Location = new System.Drawing.Point(75, 77);
            this.fld_ceHREmployeeHaveOutOfWorkIns.MenuManager = this.screenToolbar;
            this.fld_ceHREmployeeHaveOutOfWorkIns.Name = "fld_ceHREmployeeHaveOutOfWorkIns";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Properties.Caption = "Hiển thị nhân viên thiếu công";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ceHREmployeeHaveOutOfWorkIns, true);
            this.fld_ceHREmployeeHaveOutOfWorkIns.Size = new System.Drawing.Size(173, 19);
            this.fld_ceHREmployeeHaveOutOfWorkIns.TabIndex = 129;
            this.fld_ceHREmployeeHaveOutOfWorkIns.Tag = "DC";
            this.fld_ceHREmployeeHaveOutOfWorkIns.EditValueChanged += new System.EventHandler(this.fld_ceHREmployeeHaveOutOfWorkIns_EditValueChanged);
            // 
            // fld_txtTimeFromDate
            // 
            this.fld_txtTimeFromDate.BOSComment = null;
            this.fld_txtTimeFromDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtTimeFromDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtTimeFromDate.BOSDescription = null;
            this.fld_txtTimeFromDate.BOSError = null;
            this.fld_txtTimeFromDate.BOSFieldGroup = null;
            this.fld_txtTimeFromDate.BOSFieldRelation = null;
            this.fld_txtTimeFromDate.BOSPrivilege = null;
            this.fld_txtTimeFromDate.BOSPropertyName = "EditValue";
            this.fld_txtTimeFromDate.EditValue = "00:00:00";
            this.fld_txtTimeFromDate.Location = new System.Drawing.Point(539, 51);
            this.fld_txtTimeFromDate.Name = "fld_txtTimeFromDate";
            this.fld_txtTimeFromDate.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.fld_txtTimeFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtTimeFromDate.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.fld_txtTimeFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtTimeFromDate.Properties.Mask.EditMask = "HH:mm:ss";
            this.fld_txtTimeFromDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtTimeFromDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTimeFromDate.Properties.NullText = "00:00:00";
            this.fld_txtTimeFromDate.Screen = null;
            this.fld_txtTimeFromDate.Size = new System.Drawing.Size(168, 20);
            this.fld_txtTimeFromDate.TabIndex = 6;
            this.fld_txtTimeFromDate.Tag = "DC";
            // 
            // fld_txtTimeToDate
            // 
            this.fld_txtTimeToDate.BOSComment = null;
            this.fld_txtTimeToDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtTimeToDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtTimeToDate.BOSDescription = null;
            this.fld_txtTimeToDate.BOSError = null;
            this.fld_txtTimeToDate.BOSFieldGroup = null;
            this.fld_txtTimeToDate.BOSFieldRelation = null;
            this.fld_txtTimeToDate.BOSPrivilege = null;
            this.fld_txtTimeToDate.BOSPropertyName = "EditValue";
            this.fld_txtTimeToDate.EditValue = "00:00:00";
            this.fld_txtTimeToDate.Location = new System.Drawing.Point(778, 51);
            this.fld_txtTimeToDate.Name = "fld_txtTimeToDate";
            this.fld_txtTimeToDate.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.fld_txtTimeToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtTimeToDate.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.fld_txtTimeToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtTimeToDate.Properties.Mask.EditMask = "HH:mm:ss";
            this.fld_txtTimeToDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtTimeToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTimeToDate.Properties.NullText = "00:00:00";
            this.fld_txtTimeToDate.Screen = null;
            this.fld_txtTimeToDate.Size = new System.Drawing.Size(147, 20);
            this.fld_txtTimeToDate.TabIndex = 8;
            this.fld_txtTimeToDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.Location = new System.Drawing.Point(475, 54);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(36, 13);
            this.bosLabel1.TabIndex = 127;
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.Text = "Giờ vào";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.Location = new System.Drawing.Point(724, 54);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(28, 13);
            this.bosLabel4.TabIndex = 128;
            this.bosLabel4.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.Text = "Giờ ra";
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
            this.fld_lblLabel20.Location = new System.Drawing.Point(475, 28);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 125;
            this.fld_lblLabel20.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(539, 25);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(168, 20);
            this.fld_dteSearchFromDate.TabIndex = 2;
            this.fld_dteSearchFromDate.Tag = "DC";
            this.fld_dteSearchFromDate.EditValueChanged += new System.EventHandler(this.fld_dteSearchToDate_EditValueChanged);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(778, 25);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(147, 20);
            this.fld_dteSearchToDate.TabIndex = 3;
            this.fld_dteSearchToDate.Tag = "DC";
            this.fld_dteSearchToDate.EditValueChanged += new System.EventHandler(this.fld_dteSearchToDate_EditValueChanged);
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
            this.fld_lblLabel22.Location = new System.Drawing.Point(724, 28);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 126;
            this.fld_lblLabel22.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_btnViewQuickImport
            // 
            this.fld_btnViewQuickImport.BOSComment = null;
            this.fld_btnViewQuickImport.BOSDataMember = null;
            this.fld_btnViewQuickImport.BOSDataSource = null;
            this.fld_btnViewQuickImport.BOSDescription = null;
            this.fld_btnViewQuickImport.BOSError = null;
            this.fld_btnViewQuickImport.BOSFieldGroup = null;
            this.fld_btnViewQuickImport.BOSFieldRelation = null;
            this.fld_btnViewQuickImport.BOSPrivilege = null;
            this.fld_btnViewQuickImport.BOSPropertyName = null;
            this.fld_btnViewQuickImport.Location = new System.Drawing.Point(292, 51);
            this.fld_btnViewQuickImport.Name = "fld_btnViewQuickImport";
            this.fld_btnViewQuickImport.Screen = null;
            this.fld_btnViewQuickImport.Size = new System.Drawing.Size(88, 32);
            this.fld_btnViewQuickImport.TabIndex = 5;
            this.fld_btnViewQuickImport.Text = "Xem";
            this.fld_btnViewQuickImport.Click += new System.EventHandler(this.fld_btnViewQuickImport_Click);
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
            this.fld_lkeHREmployeeID2.Location = new System.Drawing.Point(77, 51);
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
            this.fld_lkeHREmployeeID2.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeHREmployeeID2.TabIndex = 4;
            this.fld_lkeHREmployeeID2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHREmployeeID2_QueryPopUp_1);
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 119;
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
            this.bosLabel2.Location = new System.Drawing.Point(13, 28);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 118;
            this.bosLabel2.Text = "Phòng ban";
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
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(292, 25);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 1;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID_QueryPopUp_1);
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
            this.fld_lblLabel11.Location = new System.Drawing.Point(247, 28);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel11.TabIndex = 117;
            this.fld_lblLabel11.Text = "Bộ phận";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 101);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fld_dgcHREmployees);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fld_btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.fld_btnApply);
            this.splitContainer1.Panel2.Controls.Add(this.fld_dgcHRTimeKeepers2);
            this.splitContainer1.Size = new System.Drawing.Size(941, 514);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 0;
            // 
            // fld_dgcHREmployees
            // 
            this.fld_dgcHREmployees.BOSComment = null;
            this.fld_dgcHREmployees.BOSDataMember = null;
            this.fld_dgcHREmployees.BOSDataSource = "HREmployees";
            this.fld_dgcHREmployees.BOSDescription = null;
            this.fld_dgcHREmployees.BOSError = null;
            this.fld_dgcHREmployees.BOSFieldGroup = null;
            this.fld_dgcHREmployees.BOSFieldRelation = null;
            this.fld_dgcHREmployees.BOSGridType = null;
            this.fld_dgcHREmployees.BOSPrivilege = null;
            this.fld_dgcHREmployees.BOSPropertyName = null;
            this.fld_dgcHREmployees.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployees.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHREmployees.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployees.Name = "fld_dgcHREmployees";
            this.fld_dgcHREmployees.PrintReport = false;
            this.fld_dgcHREmployees.Screen = null;
            this.fld_dgcHREmployees.Size = new System.Drawing.Size(457, 514);
            this.fld_dgcHREmployees.TabIndex = 0;
            this.fld_dgcHREmployees.Tag = "DC";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(275, 480);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(117, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Huỷ bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(140, 480);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(121, 27);
            this.fld_btnApply.TabIndex = 1;
            this.fld_btnApply.Text = "Thực hiện";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcHRTimeKeepers2
            // 
            this.fld_dgcHRTimeKeepers2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimeKeepers2.BOSComment = null;
            this.fld_dgcHRTimeKeepers2.BOSDataMember = null;
            this.fld_dgcHRTimeKeepers2.BOSDataSource = "HRTimeKeepers";
            this.fld_dgcHRTimeKeepers2.BOSDescription = null;
            this.fld_dgcHRTimeKeepers2.BOSError = null;
            this.fld_dgcHRTimeKeepers2.BOSFieldGroup = null;
            this.fld_dgcHRTimeKeepers2.BOSFieldRelation = null;
            this.fld_dgcHRTimeKeepers2.BOSGridType = null;
            this.fld_dgcHRTimeKeepers2.BOSPrivilege = null;
            this.fld_dgcHRTimeKeepers2.BOSPropertyName = null;
            this.fld_dgcHRTimeKeepers2.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRTimeKeepers2.Location = new System.Drawing.Point(7, 3);
            this.fld_dgcHRTimeKeepers2.MenuManager = this.screenToolbar;
            this.fld_dgcHRTimeKeepers2.Name = "fld_dgcHRTimeKeepers2";
            this.fld_dgcHRTimeKeepers2.PrintReport = false;
            this.fld_dgcHRTimeKeepers2.Screen = null;
            this.fld_dgcHRTimeKeepers2.Size = new System.Drawing.Size(469, 460);
            this.fld_dgcHRTimeKeepers2.TabIndex = 0;
            this.fld_dgcHRTimeKeepers2.Tag = "DC";
            // 
            // guiQuickImportTimeSheet
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(948, 623);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiQuickImportTimeSheet";
            this.Text = "Nhập công nhanh";
            this.Load += new System.EventHandler(this.guiQuickImportTimeSheet_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveOutOfWorkIns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTimeFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTimeToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeepers2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private IContainer components;
        private SplitContainer splitContainer1;
        private HREmployeesGridControl fld_dgcHREmployees;
        private HRTimeKeeperGridControl2 fld_dgcHRTimeKeepers2;
        private BOSComponent.BOSTextBox fld_txtTimeToDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSButton fld_btnViewQuickImport;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSTextBox fld_txtTimeFromDate;
        private BOSComponent.BOSCheckEdit fld_ceHREmployeeHaveOutOfWorkIns;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;

    }
}
