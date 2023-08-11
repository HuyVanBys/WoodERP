using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
	/// <summary>
	/// Summary description for DMHRM100
	/// </summary>
	partial class DMHRM100
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
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_btnViewData = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRMachineTimeKeepers = new BOSERP.Modules.ManagerTimeKeeper.HRMachineTimeKeepersGridControl();
            this.radioGroup = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_btnReadDat = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRTimeKeepers = new BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperGridControl();
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnLoadData = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnQuickImport = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMachineTimeKeepers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeepers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
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
            this.bosPanel1.Size = new System.Drawing.Size(1025, 567);
            this.bosPanel1.TabIndex = 34;
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnQuickImport);
            this.fld_grcGroupControl1.Controls.Add(this.bosButton2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnViewData);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRMachineTimeKeepers);
            this.fld_grcGroupControl1.Controls.Add(this.radioGroup);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnReadDat);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel20);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRTimeKeepers);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnLoadData);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteSearchToDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel22);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 3);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(1022, 561);
            this.fld_grcGroupControl1.TabIndex = 36;
            this.fld_grcGroupControl1.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.Text = "Kết nối máy chấm công";
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(678, 31);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(94, 27);
            this.bosButton2.TabIndex = 43;
            this.bosButton2.Text = "Tải từ Excel thô";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // fld_btnViewData
            // 
            this.fld_btnViewData.BOSComment = null;
            this.fld_btnViewData.BOSDataMember = null;
            this.fld_btnViewData.BOSDataSource = null;
            this.fld_btnViewData.BOSDescription = null;
            this.fld_btnViewData.BOSError = null;
            this.fld_btnViewData.BOSFieldGroup = null;
            this.fld_btnViewData.BOSFieldRelation = null;
            this.fld_btnViewData.BOSPrivilege = null;
            this.fld_btnViewData.BOSPropertyName = null;
            this.fld_btnViewData.Location = new System.Drawing.Point(679, 64);
            this.fld_btnViewData.Name = "fld_btnViewData";
            this.fld_btnViewData.Screen = null;
            this.fld_btnViewData.Size = new System.Drawing.Size(93, 27);
            this.fld_btnViewData.TabIndex = 4;
            this.fld_btnViewData.Text = "Xem lịch sử tải về";
            this.fld_btnViewData.Click += new System.EventHandler(this.fld_btnViewData_Click);
            // 
            // fld_dgcHRMachineTimeKeepers
            // 
            this.fld_dgcHRMachineTimeKeepers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_dgcHRMachineTimeKeepers.BOSComment = null;
            this.fld_dgcHRMachineTimeKeepers.BOSDataMember = null;
            this.fld_dgcHRMachineTimeKeepers.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_dgcHRMachineTimeKeepers.BOSDescription = null;
            this.fld_dgcHRMachineTimeKeepers.BOSError = null;
            this.fld_dgcHRMachineTimeKeepers.BOSFieldGroup = null;
            this.fld_dgcHRMachineTimeKeepers.BOSFieldRelation = null;
            this.fld_dgcHRMachineTimeKeepers.BOSGridType = null;
            this.fld_dgcHRMachineTimeKeepers.BOSPrivilege = null;
            this.fld_dgcHRMachineTimeKeepers.BOSPropertyName = null;
            this.fld_dgcHRMachineTimeKeepers.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRMachineTimeKeepers.Location = new System.Drawing.Point(0, 25);
            this.fld_dgcHRMachineTimeKeepers.MenuManager = this.screenToolbar;
            this.fld_dgcHRMachineTimeKeepers.Name = "fld_dgcHRMachineTimeKeepers";
            this.fld_dgcHRMachineTimeKeepers.PrintReport = false;
            this.fld_dgcHRMachineTimeKeepers.Screen = null;
            this.fld_dgcHRMachineTimeKeepers.Size = new System.Drawing.Size(295, 539);
            this.fld_dgcHRMachineTimeKeepers.TabIndex = 0;
            this.fld_dgcHRMachineTimeKeepers.Tag = "DC";
            // 
            // radioGroup
            // 
            this.radioGroup.BOSComment = null;
            this.radioGroup.BOSDataMember = null;
            this.radioGroup.BOSDataSource = null;
            this.radioGroup.BOSDescription = null;
            this.radioGroup.BOSError = null;
            this.radioGroup.BOSFieldGroup = null;
            this.radioGroup.BOSFieldRelation = null;
            this.radioGroup.BOSPrivilege = null;
            this.radioGroup.BOSPropertyName = null;
            this.radioGroup.EditValue = 0;
            this.radioGroup.Location = new System.Drawing.Point(347, 55);
            this.radioGroup.MenuManager = this.screenToolbar;
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Theo máy được chọn"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tất cả máy")});
            this.radioGroup.Screen = null;
            this.radioGroup.Size = new System.Drawing.Size(283, 26);
            this.radioGroup.TabIndex = 3;
            // 
            // fld_btnReadDat
            // 
            this.fld_btnReadDat.BOSComment = null;
            this.fld_btnReadDat.BOSDataMember = null;
            this.fld_btnReadDat.BOSDataSource = null;
            this.fld_btnReadDat.BOSDescription = null;
            this.fld_btnReadDat.BOSError = null;
            this.fld_btnReadDat.BOSFieldGroup = null;
            this.fld_btnReadDat.BOSFieldRelation = null;
            this.fld_btnReadDat.BOSPrivilege = null;
            this.fld_btnReadDat.BOSPropertyName = null;
            this.fld_btnReadDat.Location = new System.Drawing.Point(778, 64);
            this.fld_btnReadDat.Name = "fld_btnReadDat";
            this.fld_btnReadDat.Screen = null;
            this.fld_btnReadDat.Size = new System.Drawing.Size(72, 27);
            this.fld_btnReadDat.TabIndex = 6;
            this.fld_btnReadDat.Text = "Tải từ file Dat";
            this.fld_btnReadDat.Click += new System.EventHandler(this.fld_btnReadDat_Click);
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.Location = new System.Drawing.Point(301, 32);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 39;
            this.fld_lblLabel20.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // fld_dgcHRTimeKeepers
            // 
            this.fld_dgcHRTimeKeepers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimeKeepers.BOSComment = null;
            this.fld_dgcHRTimeKeepers.BOSDataMember = null;
            this.fld_dgcHRTimeKeepers.BOSDataSource = "HRTimeKeepers";
            this.fld_dgcHRTimeKeepers.BOSDescription = null;
            this.fld_dgcHRTimeKeepers.BOSError = null;
            this.fld_dgcHRTimeKeepers.BOSFieldGroup = null;
            this.fld_dgcHRTimeKeepers.BOSFieldRelation = null;
            this.fld_dgcHRTimeKeepers.BOSGridType = null;
            this.fld_dgcHRTimeKeepers.BOSPrivilege = null;
            this.fld_dgcHRTimeKeepers.BOSPropertyName = null;
            this.fld_dgcHRTimeKeepers.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRTimeKeepers.Location = new System.Drawing.Point(296, 97);
            this.fld_dgcHRTimeKeepers.MenuManager = this.screenToolbar;
            this.fld_dgcHRTimeKeepers.Name = "fld_dgcHRTimeKeepers";
            this.fld_dgcHRTimeKeepers.PrintReport = false;
            this.fld_dgcHRTimeKeepers.Screen = null;
            this.fld_dgcHRTimeKeepers.Size = new System.Drawing.Size(721, 467);
            this.fld_dgcHRTimeKeepers.TabIndex = 7;
            this.fld_dgcHRTimeKeepers.Tag = "DC";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(347, 29);
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
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_btnLoadData
            // 
            this.fld_btnLoadData.BOSComment = null;
            this.fld_btnLoadData.BOSDataMember = null;
            this.fld_btnLoadData.BOSDataSource = null;
            this.fld_btnLoadData.BOSDescription = null;
            this.fld_btnLoadData.BOSError = null;
            this.fld_btnLoadData.BOSFieldGroup = null;
            this.fld_btnLoadData.BOSFieldRelation = null;
            this.fld_btnLoadData.BOSPrivilege = null;
            this.fld_btnLoadData.BOSPropertyName = null;
            this.fld_btnLoadData.Location = new System.Drawing.Point(778, 31);
            this.fld_btnLoadData.Name = "fld_btnLoadData";
            this.fld_btnLoadData.Screen = null;
            this.fld_btnLoadData.Size = new System.Drawing.Size(72, 27);
            this.fld_btnLoadData.TabIndex = 5;
            this.fld_btnLoadData.Text = "Tải dữ liệu";
            this.fld_btnLoadData.Click += new System.EventHandler(this.fld_btnLoadData_Click);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteSearchToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(509, 29);
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
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(121, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.Location = new System.Drawing.Point(483, 32);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 40;
            this.fld_lblLabel22.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_btnQuickImport
            // 
            this.fld_btnQuickImport.BOSComment = null;
            this.fld_btnQuickImport.BOSDataMember = null;
            this.fld_btnQuickImport.BOSDataSource = null;
            this.fld_btnQuickImport.BOSDescription = null;
            this.fld_btnQuickImport.BOSError = null;
            this.fld_btnQuickImport.BOSFieldGroup = null;
            this.fld_btnQuickImport.BOSFieldRelation = null;
            this.fld_btnQuickImport.BOSPrivilege = null;
            this.fld_btnQuickImport.BOSPropertyName = null;
            this.fld_btnQuickImport.Location = new System.Drawing.Point(856, 31);
            this.fld_btnQuickImport.Name = "fld_btnQuickImport";
            this.fld_btnQuickImport.Screen = null;
            this.fld_btnQuickImport.Size = new System.Drawing.Size(98, 27);
            this.fld_btnQuickImport.TabIndex = 44;
            this.fld_btnQuickImport.Text = "Nhập công nhanh";
            this.fld_btnQuickImport.Click += new System.EventHandler(this.fld_btnQuickImport_Click);
            // 
            // DMHRM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1025, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRM100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMHRM100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMachineTimeKeepers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeKeepers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSRadioGroup radioGroup;
        private BOSComponent.BOSButton fld_btnReadDat;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSERP.Modules.ManagerTimeKeeper.HRTimeKeeperGridControl fld_dgcHRTimeKeepers;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSButton fld_btnLoadData;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private IContainer components;
        private HRMachineTimeKeepersGridControl fld_dgcHRMachineTimeKeepers;
        private BOSComponent.BOSButton fld_btnViewData;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton fld_btnQuickImport;

    }
}
