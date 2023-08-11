using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DeviceConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMDEC100
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDeviceItems = new BOSERP.Modules.DeviceConfig.ACDeviceItemsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMaterialPlan = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcACDeviceItemPlans = new BOSERP.Modules.DeviceConfig.ACDeviceItemPlansGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACDeviceIdentifierNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACDeviceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDeviceItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDeviceItemPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACDeviceIdentifierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDeviceNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosTabControl1);
            this.xtraScrollableControl1.Controls.Add(this.bosGroupControl1);
            this.xtraScrollableControl1.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1080, 567);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 136);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1074, 428);
            this.bosTabControl1.TabIndex = 0;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.bosTabControl1.Tag = "DC";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcACDeviceItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1067, 399);
            this.xtraTabPage1.Text = "Chi tiết MMTB";
            // 
            // fld_dgcACDeviceItems
            // 
            this.fld_dgcACDeviceItems.BOSComment = null;
            this.fld_dgcACDeviceItems.BOSDataMember = null;
            this.fld_dgcACDeviceItems.BOSDataSource = "ACDeviceItems";
            this.fld_dgcACDeviceItems.BOSDescription = null;
            this.fld_dgcACDeviceItems.BOSError = null;
            this.fld_dgcACDeviceItems.BOSFieldGroup = null;
            this.fld_dgcACDeviceItems.BOSFieldRelation = null;
            this.fld_dgcACDeviceItems.BOSGridType = null;
            this.fld_dgcACDeviceItems.BOSPrivilege = null;
            this.fld_dgcACDeviceItems.BOSPropertyName = null;
            this.fld_dgcACDeviceItems.CommodityType = "DeviceItem";
            this.fld_dgcACDeviceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDeviceItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDeviceItems.MenuManager = this.screenToolbar;
            this.fld_dgcACDeviceItems.Name = "fld_dgcACDeviceItems";
            this.fld_dgcACDeviceItems.PrintReport = false;
            this.fld_dgcACDeviceItems.Screen = this;
            this.fld_dgcACDeviceItems.Size = new System.Drawing.Size(1067, 399);
            this.fld_dgcACDeviceItems.TabIndex = 0;
            this.fld_dgcACDeviceItems.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosLabel8);
            this.xtraTabPage2.Controls.Add(this.fld_lkeMaterialPlan);
            this.xtraTabPage2.Controls.Add(this.fld_dgcACDeviceItemPlans);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1067, 399);
            this.xtraTabPage2.Text = "Kế hoạch vật tư";
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
            this.bosLabel8.Location = new System.Drawing.Point(7, 17);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(58, 13);
            this.bosLabel8.TabIndex = 14;
            this.bosLabel8.Text = "Chọn vật tư";
            // 
            // fld_lkeMaterialPlan
            // 
            this.fld_lkeMaterialPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeMaterialPlan.BOSAllowAddNew = false;
            this.fld_lkeMaterialPlan.BOSAllowDummy = false;
            this.fld_lkeMaterialPlan.BOSComment = null;
            this.fld_lkeMaterialPlan.BOSDataMember = "FK_ICProductID";
            this.fld_lkeMaterialPlan.BOSDataSource = "ACDeviceItemPlans";
            this.fld_lkeMaterialPlan.BOSDescription = null;
            this.fld_lkeMaterialPlan.BOSError = null;
            this.fld_lkeMaterialPlan.BOSFieldGroup = null;
            this.fld_lkeMaterialPlan.BOSFieldParent = null;
            this.fld_lkeMaterialPlan.BOSFieldRelation = null;
            this.fld_lkeMaterialPlan.BOSPrivilege = null;
            this.fld_lkeMaterialPlan.BOSPropertyName = "EditValue";
            this.fld_lkeMaterialPlan.BOSSelectType = null;
            this.fld_lkeMaterialPlan.BOSSelectTypeValue = null;
            this.fld_lkeMaterialPlan.CurrentDisplayText = null;
            this.fld_lkeMaterialPlan.Location = new System.Drawing.Point(71, 14);
            this.fld_lkeMaterialPlan.MenuManager = this.screenToolbar;
            this.fld_lkeMaterialPlan.Name = "fld_lkeMaterialPlan";
            this.fld_lkeMaterialPlan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMaterialPlan.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeMaterialPlan.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMaterialPlan.Properties.ValueMember = "ICProductID";
            this.fld_lkeMaterialPlan.Screen = null;
            this.fld_lkeMaterialPlan.Size = new System.Drawing.Size(992, 20);
            this.fld_lkeMaterialPlan.TabIndex = 14;
            this.fld_lkeMaterialPlan.Tag = "DC";
            this.fld_lkeMaterialPlan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bosLookupEdit3_KeyUp);
            // 
            // fld_dgcACDeviceItemPlans
            // 
            this.fld_dgcACDeviceItemPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDeviceItemPlans.BOSComment = null;
            this.fld_dgcACDeviceItemPlans.BOSDataMember = null;
            this.fld_dgcACDeviceItemPlans.BOSDataSource = "ACDeviceItemPlans";
            this.fld_dgcACDeviceItemPlans.BOSDescription = null;
            this.fld_dgcACDeviceItemPlans.BOSError = null;
            this.fld_dgcACDeviceItemPlans.BOSFieldGroup = null;
            this.fld_dgcACDeviceItemPlans.BOSFieldRelation = null;
            this.fld_dgcACDeviceItemPlans.BOSGridType = null;
            this.fld_dgcACDeviceItemPlans.BOSPrivilege = null;
            this.fld_dgcACDeviceItemPlans.BOSPropertyName = null;
            this.fld_dgcACDeviceItemPlans.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDeviceItemPlans.Location = new System.Drawing.Point(7, 40);
            this.fld_dgcACDeviceItemPlans.MenuManager = this.screenToolbar;
            this.fld_dgcACDeviceItemPlans.Name = "fld_dgcACDeviceItemPlans";
            this.fld_dgcACDeviceItemPlans.PrintReport = false;
            this.fld_dgcACDeviceItemPlans.Screen = this;
            this.fld_dgcACDeviceItemPlans.Size = new System.Drawing.Size(1056, 355);
            this.fld_dgcACDeviceItemPlans.TabIndex = 1;
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeICProductID);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACDeviceIdentifierNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.fld_txtACDeviceNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(1, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1079, 127);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Tag = "DC";
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = false;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ACDevices";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(365, 33);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductID.TabIndex = 19;
            this.fld_lkeICProductID.Tag = "DC";
            this.fld_lkeICProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductID_CloseUp);
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(276, 36);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(59, 13);
            this.bosLabel9.TabIndex = 18;
            this.bosLabel9.Text = "Thành phẩm";
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
            this.bosLabel7.Location = new System.Drawing.Point(21, 88);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(49, 13);
            this.bosLabel7.TabIndex = 9;
            this.bosLabel7.Text = "Tên MMTB";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ACDeviceName";
            this.bosTextBox1.BOSDataSource = "ACDevices";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(99, 85);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(416, 20);
            this.bosTextBox1.TabIndex = 2;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeACDeviceIdentifierNo
            // 
            this.fld_lkeACDeviceIdentifierNo.BOSAllowAddNew = false;
            this.fld_lkeACDeviceIdentifierNo.BOSAllowDummy = false;
            this.fld_lkeACDeviceIdentifierNo.BOSComment = null;
            this.fld_lkeACDeviceIdentifierNo.BOSDataMember = "ACDeviceIdentifierID";
            this.fld_lkeACDeviceIdentifierNo.BOSDataSource = "ACDevices";
            this.fld_lkeACDeviceIdentifierNo.BOSDescription = null;
            this.fld_lkeACDeviceIdentifierNo.BOSError = null;
            this.fld_lkeACDeviceIdentifierNo.BOSFieldGroup = null;
            this.fld_lkeACDeviceIdentifierNo.BOSFieldParent = null;
            this.fld_lkeACDeviceIdentifierNo.BOSFieldRelation = null;
            this.fld_lkeACDeviceIdentifierNo.BOSPrivilege = null;
            this.fld_lkeACDeviceIdentifierNo.BOSPropertyName = "EditValue";
            this.fld_lkeACDeviceIdentifierNo.BOSSelectType = null;
            this.fld_lkeACDeviceIdentifierNo.BOSSelectTypeValue = null;
            this.fld_lkeACDeviceIdentifierNo.CurrentDisplayText = null;
            this.fld_lkeACDeviceIdentifierNo.Location = new System.Drawing.Point(365, 59);
            this.fld_lkeACDeviceIdentifierNo.MenuManager = this.screenToolbar;
            this.fld_lkeACDeviceIdentifierNo.Name = "fld_lkeACDeviceIdentifierNo";
            this.fld_lkeACDeviceIdentifierNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACDeviceIdentifierNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACDeviceIdentifierNo", "Mã "),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACDeviceIdentifierName", "Tên")});
            this.fld_lkeACDeviceIdentifierNo.Properties.DisplayMember = "ACDeviceIdentifierNo";
            this.fld_lkeACDeviceIdentifierNo.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACDeviceIdentifierNo.Properties.ValueMember = "ACDeviceIdentifierID";
            this.fld_lkeACDeviceIdentifierNo.Screen = null;
            this.fld_lkeACDeviceIdentifierNo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACDeviceIdentifierNo.TabIndex = 4;
            this.fld_lkeACDeviceIdentifierNo.Tag = "DC";
            this.fld_lkeACDeviceIdentifierNo.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeACDeviceIdentifierNo_Closed);
            this.fld_lkeACDeviceIdentifierNo.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit3_QueryPopUp);
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
            this.bosLabel6.Location = new System.Drawing.Point(276, 62);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(64, 13);
            this.bosLabel6.TabIndex = 11;
            this.bosLabel6.Text = "Mã định danh";
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
            this.bosLabel4.Location = new System.Drawing.Point(543, 36);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Text = "Người lập";
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
            this.bosLabel3.Location = new System.Drawing.Point(542, 62);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 13;
            this.bosLabel3.Text = "Ngày hiệu lực";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "ACDeviceEffectDate";
            this.bosDateEdit2.BOSDataSource = "ACDevices";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(620, 59);
            this.bosDateEdit2.MenuManager = this.screenToolbar;
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 6;
            this.bosDateEdit2.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(21, 62);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Text = "Ngày chứng từ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit1.BOSDataSource = "ACDevices";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(620, 33);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên")});
            this.bosLookupEdit1.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 5;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ACDeviceDate";
            this.bosDateEdit1.BOSDataSource = "ACDevices";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(99, 59);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 1;
            this.bosDateEdit1.Tag = "DC";
            // 
            // fld_txtACDeviceNo
            // 
            this.fld_txtACDeviceNo.BOSComment = null;
            this.fld_txtACDeviceNo.BOSDataMember = "ACDeviceNo";
            this.fld_txtACDeviceNo.BOSDataSource = "ACDevices";
            this.fld_txtACDeviceNo.BOSDescription = null;
            this.fld_txtACDeviceNo.BOSError = null;
            this.fld_txtACDeviceNo.BOSFieldGroup = null;
            this.fld_txtACDeviceNo.BOSFieldRelation = null;
            this.fld_txtACDeviceNo.BOSPrivilege = null;
            this.fld_txtACDeviceNo.BOSPropertyName = "Text";
            this.fld_txtACDeviceNo.Location = new System.Drawing.Point(99, 33);
            this.fld_txtACDeviceNo.MenuManager = this.screenToolbar;
            this.fld_txtACDeviceNo.Name = "fld_txtACDeviceNo";
            this.fld_txtACDeviceNo.Properties.ReadOnly = true;
            this.fld_txtACDeviceNo.Screen = null;
            this.fld_txtACDeviceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDeviceNo.TabIndex = 0;
            this.fld_txtACDeviceNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(21, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Location = new System.Drawing.Point(277, 306);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl2.TabIndex = 9;
            // 
            // DMDEC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1080, 567);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMDEC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDeviceItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDeviceItemPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACDeviceIdentifierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDeviceNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeACDeviceIdentifierNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSTextBox fld_txtACDeviceNo;
        private BOSComponent.BOSLabel bosLabel1;
        private ACDeviceItemsGridControl fld_dgcACDeviceItems;
        private ACDeviceItemPlansGridControl fld_dgcACDeviceItemPlans;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox bosTextBox1;
        private ItemLookupEdit fld_lkeMaterialPlan;
        private BOSComponent.BOSLabel bosLabel8;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel9;
	}
}
