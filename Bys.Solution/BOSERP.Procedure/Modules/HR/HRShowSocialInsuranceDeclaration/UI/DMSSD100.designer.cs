using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRShowSocialInsuranceDeclaration.UI
{
	/// <summary>
	/// Summary description for DMSSD100
	/// </summary>
	partial class DMSSD100
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcHRSocialInsuranceDeclarations = new BOSERP.Modules.HRShowSocialInsuranceDeclaration.HRSocialInsuranceDeclarationsGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeHRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnViewInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnNewDocument = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMonthBHXH = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRSocialInsuranceDeclarationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHREmployees = new BOSERP.Modules.HRShowSocialInsuranceDeclaration.HREmployeesGridControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMonthBHXH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMonthBHXH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 686);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.bosPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin";
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.fld_dgcHRSocialInsuranceDeclarations);
            this.bosPanel3.Controls.Add(this.panelControl1);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(3, 3);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(990, 654);
            this.bosPanel3.TabIndex = 8;
            // 
            // fld_dgcHRSocialInsuranceDeclarations
            // 
            this.fld_dgcHRSocialInsuranceDeclarations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRSocialInsuranceDeclarations.BOSComment = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDataMember = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDescription = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSError = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSFieldGroup = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSFieldRelation = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSGridType = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSPrivilege = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSPropertyName = null;
            this.fld_dgcHRSocialInsuranceDeclarations.CommodityType = "";
            this.fld_dgcHRSocialInsuranceDeclarations.Location = new System.Drawing.Point(3, 82);
            this.fld_dgcHRSocialInsuranceDeclarations.MenuManager = this.screenToolbar;
            this.fld_dgcHRSocialInsuranceDeclarations.Name = "fld_dgcHRSocialInsuranceDeclarations";
            this.fld_dgcHRSocialInsuranceDeclarations.PrintReport = false;
            this.fld_dgcHRSocialInsuranceDeclarations.Screen = null;
            this.fld_dgcHRSocialInsuranceDeclarations.Size = new System.Drawing.Size(984, 567);
            this.fld_dgcHRSocialInsuranceDeclarations.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemID);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeHRSocialInsuranceDeclarationStatusMain);
            this.panelControl1.Controls.Add(this.fld_btnViewInfo);
            this.panelControl1.Controls.Add(this.fld_lkeHRDepartmentRoomID);
            this.panelControl1.Controls.Add(this.fld_lkeHRDepartmentID);
            this.panelControl1.Controls.Add(this.fld_lkeHREmployeeID);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 76);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_lkeHRDepartmentRoomGroupItemID
            // 
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataSource = "HRDepartmentRoomGroupItems";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(86, 44);
            this.fld_lkeHRDepartmentRoomGroupItemID.Name = "fld_lkeHRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomGroupItemID.TabIndex = 10;
            this.fld_lkeHRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp);
            this.fld_lkeHRDepartmentRoomGroupItemID.EditValueChanged += new System.EventHandler(this.Fld_lkeHRDepartmentRoomGroupItemID_EnabledChanged);
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
            this.bosLabel8.Location = new System.Drawing.Point(18, 47);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(12, 13);
            this.bosLabel8.TabIndex = 11;
            this.bosLabel8.Text = "Tổ";
            // 
            // fld_lkeHRSocialInsuranceDeclarationStatusMain
            // 
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSAllowAddNew = false;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSAllowDummy = true;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSComment = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSDataMember = "HRSocialInsuranceDeclarationStatus";
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSDataSource = "HRShowSocialInsuranceDeclarations";
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSDescription = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSError = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSFieldGroup = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSFieldParent = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSFieldRelation = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSPrivilege = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSPropertyName = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSSelectType = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.BOSSelectTypeValue = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.CurrentDisplayText = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Location = new System.Drawing.Point(615, 44);
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.MenuManager = this.screenToolbar;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Name = "fld_lkeHRSocialInsuranceDeclarationStatusMain";
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Properties.ColumnName = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Screen = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRSocialInsuranceDeclarationStatusMain.TabIndex = 4;
            // 
            // fld_btnViewInfo
            // 
            this.fld_btnViewInfo.BOSComment = null;
            this.fld_btnViewInfo.BOSDataMember = null;
            this.fld_btnViewInfo.BOSDataSource = null;
            this.fld_btnViewInfo.BOSDescription = null;
            this.fld_btnViewInfo.BOSError = null;
            this.fld_btnViewInfo.BOSFieldGroup = null;
            this.fld_btnViewInfo.BOSFieldRelation = null;
            this.fld_btnViewInfo.BOSPrivilege = null;
            this.fld_btnViewInfo.BOSPropertyName = null;
            this.fld_btnViewInfo.Location = new System.Drawing.Point(806, 19);
            this.fld_btnViewInfo.Name = "fld_btnViewInfo";
            this.fld_btnViewInfo.Screen = null;
            this.fld_btnViewInfo.Size = new System.Drawing.Size(75, 29);
            this.fld_btnViewInfo.TabIndex = 7;
            this.fld_btnViewInfo.Text = "Xem";
            this.fld_btnViewInfo.Click += new System.EventHandler(this.fld_btnViewInfo_Click);
            // 
            // fld_lkeHRDepartmentRoomID
            // 
            this.fld_lkeHRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID.BOSError = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID.Location = new System.Drawing.Point(615, 18);
            this.fld_lkeHRDepartmentRoomID.Name = "fld_lkeHRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeHRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Screen = null;
            this.fld_lkeHRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomID.TabIndex = 6;
            this.fld_lkeHRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHRDepartmentRoomID_QueryPopUp);
            this.fld_lkeHRDepartmentRoomID.EditValueChanged += new System.EventHandler(this.Fld_lkeHRDepartmentRoomID_EditValueChanged);
            // 
            // fld_lkeHRDepartmentID
            // 
            this.fld_lkeHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentID.BOSComment = null;
            this.fld_lkeHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartmentID.BOSDescription = null;
            this.fld_lkeHRDepartmentID.BOSError = null;
            this.fld_lkeHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentID.BOSSelectType = null;
            this.fld_lkeHRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentID.Location = new System.Drawing.Point(349, 18);
            this.fld_lkeHRDepartmentID.Name = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.Screen = null;
            this.fld_lkeHRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentID.TabIndex = 3;
            this.fld_lkeHRDepartmentID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHRDepartmentID_QueryPopUp);
            this.fld_lkeHRDepartmentID.EditValueChanged += new System.EventHandler(this.Fld_lkeHRDepartmentID_EditValueChanged);
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
            this.fld_lkeHREmployeeID.BOSFieldParent = null;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = null;
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(349, 44);
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeID.TabIndex = 1;
            this.fld_lkeHREmployeeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeHREmployeeID_QueryPopUp);
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(86, 18);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 0;
            this.fld_lkeBRBranchID.EditValueChanged += new System.EventHandler(this.Fld_lkeBRBranchID_EditValueChanged);
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
            this.bosLabel1.Location = new System.Drawing.Point(547, 47);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Tình trạng";
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
            this.bosLabel5.Location = new System.Drawing.Point(281, 47);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Text = "Nhân viên";
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
            this.bosLabel2.Location = new System.Drawing.Point(18, 21);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Chi nhánh";
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
            this.bosLabel3.Location = new System.Drawing.Point(547, 21);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Bộ phận";
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
            this.bosLabel4.Location = new System.Drawing.Point(281, 21);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(51, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Text = "Phòng ban";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.bosPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách nhân viên";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_chkSellectAll);
            this.bosPanel2.Controls.Add(this.fld_btnNewDocument);
            this.bosPanel2.Controls.Add(this.bosPanel1);
            this.bosPanel2.Controls.Add(this.fld_dgcHREmployees);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(3, 3);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(984, 647);
            this.bosPanel2.TabIndex = 8;
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(3, 614);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkSellectAll, true);
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 9;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
            // 
            // fld_btnNewDocument
            // 
            this.fld_btnNewDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnNewDocument.BOSComment = null;
            this.fld_btnNewDocument.BOSDataMember = null;
            this.fld_btnNewDocument.BOSDataSource = null;
            this.fld_btnNewDocument.BOSDescription = null;
            this.fld_btnNewDocument.BOSError = null;
            this.fld_btnNewDocument.BOSFieldGroup = null;
            this.fld_btnNewDocument.BOSFieldRelation = null;
            this.fld_btnNewDocument.BOSPrivilege = null;
            this.fld_btnNewDocument.BOSPropertyName = null;
            this.fld_btnNewDocument.Location = new System.Drawing.Point(832, 609);
            this.fld_btnNewDocument.Name = "fld_btnNewDocument";
            this.fld_btnNewDocument.Screen = null;
            this.fld_btnNewDocument.Size = new System.Drawing.Size(143, 29);
            this.fld_btnNewDocument.TabIndex = 8;
            this.fld_btnNewDocument.Text = "Tạo chứng từ";
            this.fld_btnNewDocument.Click += new System.EventHandler(this.fld_btnNewDocument_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteMonthBHXH);
            this.bosPanel1.Controls.Add(this.fld_lkeHRSocialInsuranceDeclarationStatus);
            this.bosPanel1.Controls.Add(this.fld_btnView);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(984, 43);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel7.Location = new System.Drawing.Point(411, 13);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(30, 13);
            this.bosLabel7.TabIndex = 9;
            this.bosLabel7.Text = "Tháng";
            // 
            // fld_dteMonthBHXH
            // 
            this.fld_dteMonthBHXH.BOSComment = "";
            this.fld_dteMonthBHXH.BOSDataMember = "";
            this.fld_dteMonthBHXH.BOSDataSource = "";
            this.fld_dteMonthBHXH.BOSDescription = null;
            this.fld_dteMonthBHXH.BOSError = null;
            this.fld_dteMonthBHXH.BOSFieldGroup = "";
            this.fld_dteMonthBHXH.BOSFieldRelation = "";
            this.fld_dteMonthBHXH.BOSPrivilege = "";
            this.fld_dteMonthBHXH.BOSPropertyName = "EditValue";
            this.fld_dteMonthBHXH.EditValue = null;
            this.fld_dteMonthBHXH.Location = new System.Drawing.Point(467, 9);
            this.fld_dteMonthBHXH.Name = "fld_dteMonthBHXH";
            this.fld_dteMonthBHXH.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMonthBHXH.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMonthBHXH.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMonthBHXH.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMonthBHXH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMonthBHXH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMonthBHXH.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteMonthBHXH.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_dteMonthBHXH.Screen = null;
            this.fld_dteMonthBHXH.Size = new System.Drawing.Size(149, 20);
            this.fld_dteMonthBHXH.TabIndex = 8;
            this.fld_dteMonthBHXH.Tag = "DC";
            // 
            // fld_lkeHRSocialInsuranceDeclarationStatus
            // 
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSAllowAddNew = false;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSAllowDummy = true;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSComment = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDataMember = "ADConfigKeyValue";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDataSource = "ADConfigValues";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDescription = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSError = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldGroup = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldParent = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldRelation = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSPrivilege = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSPropertyName = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSSelectType = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.CurrentDisplayText = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Location = new System.Drawing.Point(108, 9);
            this.fld_lkeHRSocialInsuranceDeclarationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Name = "fld_lkeHRSocialInsuranceDeclarationStatus";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.ColumnName = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Tình trạng")});
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Screen = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Size = new System.Drawing.Size(233, 20);
            this.fld_lkeHRSocialInsuranceDeclarationStatus.TabIndex = 4;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRSocialInsuranceDeclarationStatus_QueryPopUp);
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(640, 5);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(75, 29);
            this.fld_btnView.TabIndex = 7;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 13);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(78, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Text = "Tình trạng BHXH";
            // 
            // fld_dgcHREmployees
            // 
            this.fld_dgcHREmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_dgcHREmployees.CommodityType = "";
            this.fld_dgcHREmployees.Location = new System.Drawing.Point(3, 49);
            this.fld_dgcHREmployees.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployees.Name = "fld_dgcHREmployees";
            this.fld_dgcHREmployees.PrintReport = false;
            this.fld_dgcHREmployees.Screen = null;
            this.fld_dgcHREmployees.Size = new System.Drawing.Size(978, 554);
            this.fld_dgcHREmployees.TabIndex = 0;
            // 
            // DMSSD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1004, 686);
            this.Controls.Add(this.tabControl1);
            this.Name = "DMSSD100";
            this.Text = "Quản lý bảo hiểm xã hội";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatusMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMonthBHXH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMonthBHXH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSComponent.BOSButton fld_btnNewDocument;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRSocialInsuranceDeclarationStatus;
        private BOSComponent.BOSButton fld_btnView;
        private BOSComponent.BOSLabel bosLabel6;
        private HREmployeesGridControl fld_dgcHREmployees;
        private BOSComponent.BOSPanel bosPanel3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeHRSocialInsuranceDeclarationStatusMain;
        private BOSComponent.BOSButton fld_btnViewInfo;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private HRSocialInsuranceDeclarationsGridControl fld_dgcHRSocialInsuranceDeclarations;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteMonthBHXH;
    }
}
