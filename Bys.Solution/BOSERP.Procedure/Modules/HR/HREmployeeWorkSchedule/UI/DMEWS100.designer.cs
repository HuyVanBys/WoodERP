using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSERP.Modules.HREmployeeWorkSchedule;

namespace BOSERP.Modules.HREmployeeWorkSchedule.UI
{
	/// <summary>
	/// Summary description for DMEWS100
	/// </summary>
	partial class DMEWS100
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
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeWorkScheduleStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeWorkScheduleName = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosDateEdit3 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit4 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeWorkScheduleItems = new BOSERP.Modules.HREmployeeWorkSchedule.HREmployeeWorkScheduleItemsGridControl();
            this.fld_dgvHREmployeeOTs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeWorkScheduleStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeWorkScheduleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeWorkScheduleStatus);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeWorkScheduleName);
            this.bosGroupControl1.Controls.Add(this.bosMemoEdit1);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit3);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit4);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 138);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
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
            this.bosLabel6.Location = new System.Drawing.Point(628, 37);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 12;
            this.bosLabel6.Text = "Trạng thái";
            // 
            // fld_lkeHREmployeeWorkScheduleStatus
            // 
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSAllowDummy = true;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSComment = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSDataMember = "HREmployeeWorkScheduleStatus";
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSDescription = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSError = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSFieldGroup = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSFieldParent = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSFieldRelation = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSPrivilege = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSSelectType = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.CurrentDisplayText = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.Location = new System.Drawing.Point(683, 34);
            this.fld_lkeHREmployeeWorkScheduleStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeWorkScheduleStatus.Name = "fld_lkeHREmployeeWorkScheduleStatus";
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.ColumnName = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.ReadOnly = true;
            this.fld_lkeHREmployeeWorkScheduleStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeWorkScheduleStatus.Screen = null;
            this.fld_lkeHREmployeeWorkScheduleStatus.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeHREmployeeWorkScheduleStatus.TabIndex = 2;
            this.fld_lkeHREmployeeWorkScheduleStatus.Tag = "DC";
            // 
            // fld_txtHREmployeeWorkScheduleName
            // 
            this.fld_txtHREmployeeWorkScheduleName.BOSComment = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSDataMember = "HREmployeeWorkScheduleName";
            this.fld_txtHREmployeeWorkScheduleName.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_txtHREmployeeWorkScheduleName.BOSDescription = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSError = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSFieldGroup = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSFieldRelation = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSPrivilege = null;
            this.fld_txtHREmployeeWorkScheduleName.BOSPropertyName = "Text";
            this.fld_txtHREmployeeWorkScheduleName.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHREmployeeWorkScheduleName.Location = new System.Drawing.Point(401, 34);
            this.fld_txtHREmployeeWorkScheduleName.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeeWorkScheduleName.Name = "fld_txtHREmployeeWorkScheduleName";
            this.fld_txtHREmployeeWorkScheduleName.Screen = null;
            this.fld_txtHREmployeeWorkScheduleName.Size = new System.Drawing.Size(178, 20);
            this.fld_txtHREmployeeWorkScheduleName.TabIndex = 1;
            this.fld_txtHREmployeeWorkScheduleName.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = null;
            this.bosMemoEdit1.BOSDataMember = "HREmployeeWorkScheduleDesc";
            this.bosMemoEdit1.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = null;
            this.bosMemoEdit1.BOSFieldRelation = null;
            this.bosMemoEdit1.BOSPrivilege = null;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.Location = new System.Drawing.Point(104, 86);
            this.bosMemoEdit1.MenuManager = this.screenToolbar;
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(475, 42);
            this.bosMemoEdit1.TabIndex = 7;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosDateEdit3
            // 
            this.bosDateEdit3.BOSComment = null;
            this.bosDateEdit3.BOSDataMember = "HREmployeeWorkScheduleDateTo";
            this.bosDateEdit3.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosDateEdit3.BOSDescription = null;
            this.bosDateEdit3.BOSError = null;
            this.bosDateEdit3.BOSFieldGroup = null;
            this.bosDateEdit3.BOSFieldRelation = null;
            this.bosDateEdit3.BOSPrivilege = null;
            this.bosDateEdit3.BOSPropertyName = "EditValue";
            this.bosDateEdit3.EditValue = null;
            this.bosDateEdit3.Location = new System.Drawing.Point(507, 60);
            this.bosDateEdit3.Name = "bosDateEdit3";
            this.bosDateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit3.Properties.DisplayFormat.FormatString = "HH:mm";
            this.bosDateEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit3.Properties.EditFormat.FormatString = "HH:mm";
            this.bosDateEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit3.Properties.Mask.EditMask = "HH:mm";
            this.bosDateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit3.Screen = null;
            this.bosDateEdit3.Size = new System.Drawing.Size(72, 20);
            this.bosDateEdit3.TabIndex = 6;
            this.bosDateEdit3.Tag = "DC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "HREmployeeWorkScheduleDateFrom";
            this.bosDateEdit2.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(206, 60);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.DisplayFormat.FormatString = "HH:mm";
            this.bosDateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit2.Properties.EditFormat.FormatString = "HH:mm";
            this.bosDateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit2.Properties.Mask.EditMask = "HH:mm";
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(69, 20);
            this.bosDateEdit2.TabIndex = 4;
            this.bosDateEdit2.Tag = "DC";
            // 
            // bosDateEdit4
            // 
            this.bosDateEdit4.BOSComment = null;
            this.bosDateEdit4.BOSDataMember = "HREmployeeWorkScheduleToDate";
            this.bosDateEdit4.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosDateEdit4.BOSDescription = null;
            this.bosDateEdit4.BOSError = null;
            this.bosDateEdit4.BOSFieldGroup = null;
            this.bosDateEdit4.BOSFieldRelation = null;
            this.bosDateEdit4.BOSPrivilege = null;
            this.bosDateEdit4.BOSPropertyName = "EditValue";
            this.bosDateEdit4.EditValue = null;
            this.bosDateEdit4.Location = new System.Drawing.Point(401, 60);
            this.bosDateEdit4.Name = "bosDateEdit4";
            this.bosDateEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit4.Screen = null;
            this.bosDateEdit4.Size = new System.Drawing.Size(100, 20);
            this.bosDateEdit4.TabIndex = 5;
            this.bosDateEdit4.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "HREmployeeWorkScheduleFromDate";
            this.bosDateEdit1.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(104, 60);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(96, 20);
            this.bosDateEdit1.TabIndex = 3;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(315, 37);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(80, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Tên lịch công tác";
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
            this.bosLabel5.Location = new System.Drawing.Point(375, 63);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(20, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Đến";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "HREmployeeWorkScheduleNo";
            this.bosTextBox1.BOSDataSource = "HREmployeeWorkSchedules";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(105, 34);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(170, 20);
            this.bosTextBox1.TabIndex = 0;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 89);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Mô tả";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(13, 63);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(85, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Ngày công tác Từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(13, 37);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeWorkScheduleItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 137);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 385);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Danh sách nhân viên";
            // 
            // fld_dgcHREmployeeWorkScheduleItems
            // 
            this.fld_dgcHREmployeeWorkScheduleItems.AllowDrop = true;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSDataSource = "HREmployeeWorkScheduleItems";
            this.fld_dgcHREmployeeWorkScheduleItems.BOSDescription = null;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSError = null;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSGridType = null;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeWorkScheduleItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeWorkScheduleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeWorkScheduleItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeWorkScheduleItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREmployeeWorkScheduleItems.MainView = this.fld_dgvHREmployeeOTs;
            this.fld_dgcHREmployeeWorkScheduleItems.Name = "fld_dgcHREmployeeWorkScheduleItems";
            this.fld_dgcHREmployeeWorkScheduleItems.PrintReport = false;
            this.fld_dgcHREmployeeWorkScheduleItems.Screen = null;
            this.fld_dgcHREmployeeWorkScheduleItems.Size = new System.Drawing.Size(852, 361);
            this.fld_dgcHREmployeeWorkScheduleItems.TabIndex = 7;
            this.fld_dgcHREmployeeWorkScheduleItems.Tag = "DC";
            this.fld_dgcHREmployeeWorkScheduleItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeOTs});
            // 
            // fld_dgvHREmployeeOTs
            // 
            this.fld_dgvHREmployeeOTs.GridControl = this.fld_dgcHREmployeeWorkScheduleItems;
            this.fld_dgvHREmployeeOTs.Name = "fld_dgvHREmployeeOTs";
            this.fld_dgvHREmployeeOTs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(12, 530);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(97, 27);
            this.fld_btnAddEmployee.TabIndex = 11;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // DMEWS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEWS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeWorkScheduleStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeWorkScheduleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl bosGroupControl1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSDateEdit bosDateEdit3;
        private BOSComponent.BOSLabel bosLabel5;
        private HREmployeeWorkScheduleItemsGridControl fld_dgcHREmployeeWorkScheduleItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeOTs;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSDateEdit bosDateEdit4;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHREmployeeWorkScheduleName;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeWorkScheduleStatus;
	}
}
