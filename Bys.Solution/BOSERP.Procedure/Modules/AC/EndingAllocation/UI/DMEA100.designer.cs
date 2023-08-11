using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EndingAllocation.UI
{
	/// <summary>
	/// Summary description for DMEA100
	/// </summary>
	partial class DMEA100
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
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAllocation = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACEndingAllocationItems = new BOSERP.Modules.EndingAllocation.ACEndingAllocationItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ACEndingAllocationDeclarationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACEndingAllocationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACEndingAllocationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACEndingAllocationExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACEndingAllocationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACEndingAllocationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACEndingAllocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACEndingAllocationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 673);
            this.bosPanel1.TabIndex = 0;
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
            this.bosGroupControl2.Controls.Add(this.fld_btnAllocation);
            this.bosGroupControl2.Controls.Add(this.fld_dgcACEndingAllocationItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 205);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 465);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin chi tiết";
            // 
            // fld_btnAllocation
            // 
            this.fld_btnAllocation.BOSComment = null;
            this.fld_btnAllocation.BOSDataMember = null;
            this.fld_btnAllocation.BOSDataSource = null;
            this.fld_btnAllocation.BOSDescription = null;
            this.fld_btnAllocation.BOSError = null;
            this.fld_btnAllocation.BOSFieldGroup = null;
            this.fld_btnAllocation.BOSFieldRelation = null;
            this.fld_btnAllocation.BOSPrivilege = null;
            this.fld_btnAllocation.BOSPropertyName = null;
            this.fld_btnAllocation.Location = new System.Drawing.Point(5, 25);
            this.fld_btnAllocation.Name = "fld_btnAllocation";
            this.fld_btnAllocation.Screen = null;
            this.fld_btnAllocation.Size = new System.Drawing.Size(137, 27);
            this.fld_btnAllocation.TabIndex = 0;
            this.fld_btnAllocation.Text = "Phân bổ";
            this.fld_btnAllocation.Click += new System.EventHandler(this.fld_btnAllocation_Click);
            // 
            // fld_dgcACEndingAllocationItems
            // 
            this.fld_dgcACEndingAllocationItems.AllowDrop = true;
            this.fld_dgcACEndingAllocationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACEndingAllocationItems.BOSComment = null;
            this.fld_dgcACEndingAllocationItems.BOSDataMember = null;
            this.fld_dgcACEndingAllocationItems.BOSDataSource = "ACEndingAllocationItems";
            this.fld_dgcACEndingAllocationItems.BOSDescription = null;
            this.fld_dgcACEndingAllocationItems.BOSError = null;
            this.fld_dgcACEndingAllocationItems.BOSFieldGroup = null;
            this.fld_dgcACEndingAllocationItems.BOSFieldRelation = null;
            this.fld_dgcACEndingAllocationItems.BOSGridType = null;
            this.fld_dgcACEndingAllocationItems.BOSPrivilege = null;
            this.fld_dgcACEndingAllocationItems.BOSPropertyName = null;
            this.fld_dgcACEndingAllocationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEndingAllocationItems.Location = new System.Drawing.Point(2, 58);
            this.fld_dgcACEndingAllocationItems.MainView = this.gridView2;
            this.fld_dgcACEndingAllocationItems.Name = "fld_dgcACEndingAllocationItems";
            this.fld_dgcACEndingAllocationItems.PrintReport = false;
            this.fld_dgcACEndingAllocationItems.Screen = null;
            this.fld_dgcACEndingAllocationItems.Size = new System.Drawing.Size(852, 402);
            this.fld_dgcACEndingAllocationItems.TabIndex = 1;
            this.fld_dgcACEndingAllocationItems.Tag = "DC";
            this.fld_dgcACEndingAllocationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACEndingAllocationItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACEndingAllocationDeclarationID);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_dteACEndingAllocationToDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_dteACEndingAllocationFromDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtACEndingAllocationExchangeRate);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.bosLabel27);
            this.bosGroupControl1.Controls.Add(this.fld_dteACEndingAllocationDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtACEndingAllocationNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_medACEndingAllocationDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 201);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeFK_ACEndingAllocationDeclarationID
            // 
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSComment = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDataMember = "FK_ACEndingAllocationDeclarationID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDataSource = "ACEndingAllocations";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDescription = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSError = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldGroup = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldParent = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldRelation = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSPrivilege = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSSelectType = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.CurrentDisplayText = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Location = new System.Drawing.Point(106, 113);
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Name = "fld_lkeFK_ACEndingAllocationDeclarationID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEndingAllocationDeclarationNo", "Mã phân bổ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEndingAllocationDeclarationName", "Tên phân bổ")});
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.DisplayMember = "ACEndingAllocationDeclarationNo";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.ValueMember = "ACEndingAllocationDeclarationID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Screen = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACEndingAllocationDeclarationID.TabIndex = 6;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Tag = "DC";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEndingAllocationDeclarationID_CloseUp);
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
            this.bosLabel5.Location = new System.Drawing.Point(22, 116);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 598;
            this.bosLabel5.Text = "Mã phân bổ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(288, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 596;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteACEndingAllocationToDate
            // 
            this.fld_dteACEndingAllocationToDate.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationToDate.BOSDataMember = "ACEndingAllocationToDate";
            this.fld_dteACEndingAllocationToDate.BOSDataSource = "ACEndingAllocations";
            this.fld_dteACEndingAllocationToDate.BOSDescription = null;
            this.fld_dteACEndingAllocationToDate.BOSError = null;
            this.fld_dteACEndingAllocationToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationToDate.BOSPropertyName = "EditValue";
            this.fld_dteACEndingAllocationToDate.EditValue = null;
            this.fld_dteACEndingAllocationToDate.Location = new System.Drawing.Point(375, 87);
            this.fld_dteACEndingAllocationToDate.Name = "fld_dteACEndingAllocationToDate";
            this.fld_dteACEndingAllocationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACEndingAllocationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACEndingAllocationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACEndingAllocationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACEndingAllocationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACEndingAllocationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACEndingAllocationToDate.Screen = null;
            this.fld_dteACEndingAllocationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACEndingAllocationToDate.TabIndex = 5;
            this.fld_dteACEndingAllocationToDate.Tag = "DC";
            this.fld_dteACEndingAllocationToDate.TextChanged += new System.EventHandler(this.fld_dteACEndingAllocationToDate_TextChanged);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(22, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 594;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.Text = "Từ ngày";
            // 
            // fld_dteACEndingAllocationFromDate
            // 
            this.fld_dteACEndingAllocationFromDate.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationFromDate.BOSDataMember = "ACEndingAllocationFromDate";
            this.fld_dteACEndingAllocationFromDate.BOSDataSource = "ACEndingAllocations";
            this.fld_dteACEndingAllocationFromDate.BOSDescription = null;
            this.fld_dteACEndingAllocationFromDate.BOSError = null;
            this.fld_dteACEndingAllocationFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACEndingAllocationFromDate.EditValue = null;
            this.fld_dteACEndingAllocationFromDate.Location = new System.Drawing.Point(106, 87);
            this.fld_dteACEndingAllocationFromDate.Name = "fld_dteACEndingAllocationFromDate";
            this.fld_dteACEndingAllocationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACEndingAllocationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACEndingAllocationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACEndingAllocationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACEndingAllocationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACEndingAllocationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACEndingAllocationFromDate.Screen = null;
            this.fld_dteACEndingAllocationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACEndingAllocationFromDate.TabIndex = 4;
            this.fld_dteACEndingAllocationFromDate.Tag = "DC";
            this.fld_dteACEndingAllocationFromDate.TextChanged += new System.EventHandler(this.fld_dteACEndingAllocationFromDate_TextChanged);
            // 
            // fld_txtACEndingAllocationExchangeRate
            // 
            this.fld_txtACEndingAllocationExchangeRate.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationExchangeRate.BOSDataMember = "ACEndingAllocationExchangeRate";
            this.fld_txtACEndingAllocationExchangeRate.BOSDataSource = "ACEndingAllocations";
            this.fld_txtACEndingAllocationExchangeRate.BOSDescription = null;
            this.fld_txtACEndingAllocationExchangeRate.BOSError = null;
            this.fld_txtACEndingAllocationExchangeRate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationExchangeRate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationExchangeRate.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACEndingAllocationExchangeRate.EditValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationExchangeRate.Location = new System.Drawing.Point(375, 61);
            this.fld_txtACEndingAllocationExchangeRate.Name = "fld_txtACEndingAllocationExchangeRate";
            this.fld_txtACEndingAllocationExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationExchangeRate.Properties.ReadOnly = true;
            this.fld_txtACEndingAllocationExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationExchangeRate.Screen = null;
            this.fld_txtACEndingAllocationExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationExchangeRate.TabIndex = 3;
            this.fld_txtACEndingAllocationExchangeRate.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACEndingAllocations";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(106, 61);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_GECurrencyID.Properties.ReadOnly = true;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 2;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(22, 64);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(53, 13);
            this.bosLabel10.TabIndex = 591;
            this.bosLabel10.Text = "Loại tiền tệ";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(288, 64);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(29, 13);
            this.bosLabel11.TabIndex = 592;
            this.bosLabel11.Text = "Tỷ giá";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(288, 38);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(72, 13);
            this.bosLabel27.TabIndex = 588;
            this.bosLabel27.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel27.Text = "Ngày chứng từ";
            // 
            // fld_dteACEndingAllocationDate
            // 
            this.fld_dteACEndingAllocationDate.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationDate.BOSDataMember = "ACEndingAllocationDate";
            this.fld_dteACEndingAllocationDate.BOSDataSource = "ACEndingAllocations";
            this.fld_dteACEndingAllocationDate.BOSDescription = null;
            this.fld_dteACEndingAllocationDate.BOSError = null;
            this.fld_dteACEndingAllocationDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteACEndingAllocationDate.BOSPropertyName = "EditValue";
            this.fld_dteACEndingAllocationDate.EditValue = null;
            this.fld_dteACEndingAllocationDate.Location = new System.Drawing.Point(375, 35);
            this.fld_dteACEndingAllocationDate.Name = "fld_dteACEndingAllocationDate";
            this.fld_dteACEndingAllocationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACEndingAllocationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACEndingAllocationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACEndingAllocationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACEndingAllocationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACEndingAllocationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACEndingAllocationDate.Screen = null;
            this.fld_dteACEndingAllocationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACEndingAllocationDate.TabIndex = 1;
            this.fld_dteACEndingAllocationDate.Tag = "DC";
            // 
            // fld_txtACEndingAllocationNo
            // 
            this.fld_txtACEndingAllocationNo.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationNo.BOSDataMember = "ACEndingAllocationNo";
            this.fld_txtACEndingAllocationNo.BOSDataSource = "ACEndingAllocations";
            this.fld_txtACEndingAllocationNo.BOSDescription = null;
            this.fld_txtACEndingAllocationNo.BOSError = null;
            this.fld_txtACEndingAllocationNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationNo.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationNo.EditValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtACEndingAllocationNo.Location = new System.Drawing.Point(106, 35);
            this.fld_txtACEndingAllocationNo.Name = "fld_txtACEndingAllocationNo";
            this.fld_txtACEndingAllocationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationNo.Screen = null;
            this.fld_txtACEndingAllocationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationNo.TabIndex = 0;
            this.fld_txtACEndingAllocationNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(22, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_medACEndingAllocationDesc
            // 
            this.fld_medACEndingAllocationDesc.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_medACEndingAllocationDesc.BOSDataMember = "ACEndingAllocationDesc";
            this.fld_medACEndingAllocationDesc.BOSDataSource = "ACEndingAllocations";
            this.fld_medACEndingAllocationDesc.BOSDescription = null;
            this.fld_medACEndingAllocationDesc.BOSError = null;
            this.fld_medACEndingAllocationDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_medACEndingAllocationDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_medACEndingAllocationDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_medACEndingAllocationDesc.BOSPropertyName = "EditValue";
            this.fld_medACEndingAllocationDesc.EditValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_medACEndingAllocationDesc.Location = new System.Drawing.Point(106, 139);
            this.fld_medACEndingAllocationDesc.Name = "fld_medACEndingAllocationDesc";
            this.fld_medACEndingAllocationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACEndingAllocationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACEndingAllocationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACEndingAllocationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACEndingAllocationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medACEndingAllocationDesc, true);
            this.fld_medACEndingAllocationDesc.Size = new System.Drawing.Size(419, 52);
            this.fld_medACEndingAllocationDesc.TabIndex = 8;
            this.fld_medACEndingAllocationDesc.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(22, 142);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.Location = new System.Drawing.Point(288, 116);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 600;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACEndingAllocations";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(375, 113);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 7;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // DMEA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 673);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEA100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACEndingAllocationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACEndingAllocationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medACEndingAllocationDesc;
        private ACEndingAllocationItemsGridControl fld_dgcACEndingAllocationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;

        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSDateEdit fld_dteACEndingAllocationDate;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEndingAllocationDeclarationID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteACEndingAllocationToDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACEndingAllocationFromDate;
        private BOSComponent.BOSButton fld_btnAllocation;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
