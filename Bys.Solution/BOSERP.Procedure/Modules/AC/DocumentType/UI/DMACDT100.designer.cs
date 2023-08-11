using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ACDocumentType.UI
{
	/// <summary>
	/// Summary description for DMACDT100
	/// </summary>
	partial class DMACDT100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private ACDocumentTypesGridControl fld_dgcACDocumentTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentTypes;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACDocumentTypes = new BOSERP.Modules.ACDocumentType.ACDocumentTypesGridControl();
            this.fld_ctmDocumentTypeAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fld_tmiEditDocumentType = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_tmiConfigEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_dgvACDocumentTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSaveACDocTypeEntryFunctionMappings = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACDocTypeEntryFunctionMappings = new BOSERP.Modules.ACDocumentType.ACDocTypeEntryFunctionMappingsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSaveSTModulePostings = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSTModulePostings = new BOSERP.Modules.ACDocumentType.STModulePostingsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_TabTranferCost = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSaveAccountCostTranfer = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACAccountTranferCosts = new BOSERP.Modules.ACDocumentType.ACAccountTranferCostsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentTypes)).BeginInit();
            this.fld_ctmDocumentTypeAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentTypes)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntryFunctionMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTModulePostings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fld_TabTranferCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountTranferCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcACDocumentTypes);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(855, 538);
            this.fld_grcGroupControl.TabIndex = 5;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.String2;
            this.fld_grcGroupControl.Text = "Danh sách loại chứng từ";
            // 
            // fld_dgcACDocumentTypes
            // 
            this.fld_dgcACDocumentTypes.AllowDrop = true;
            this.fld_dgcACDocumentTypes.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.BOSDataSource = "ACDocumentTypes";
            this.fld_dgcACDocumentTypes.BOSDescription = null;
            this.fld_dgcACDocumentTypes.BOSError = null;
            this.fld_dgcACDocumentTypes.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.BOSGridType = null;
            this.fld_dgcACDocumentTypes.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocumentTypes.ContextMenuStrip = this.fld_ctmDocumentTypeAction;
            this.fld_dgcACDocumentTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentTypes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentTypes.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACDocumentTypes.MainView = this.fld_dgvACDocumentTypes;
            this.fld_dgcACDocumentTypes.Name = "fld_dgcACDocumentTypes";
            this.fld_dgcACDocumentTypes.PrintReport = false;
            this.fld_dgcACDocumentTypes.Screen = null;
            this.fld_dgcACDocumentTypes.Size = new System.Drawing.Size(851, 514);
            this.fld_dgcACDocumentTypes.TabIndex = 4;
            this.fld_dgcACDocumentTypes.Tag = "DC";
            this.fld_dgcACDocumentTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentTypes});
            // 
            // fld_ctmDocumentTypeAction
            // 
            this.fld_ctmDocumentTypeAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fld_tmiEditDocumentType,
            this.fld_tmiConfigEntry});
            this.fld_ctmDocumentTypeAction.Name = "fld_ctmDocumentTypeAction";
            this.fld_ctmDocumentTypeAction.Size = new System.Drawing.Size(171, 48);
            // 
            // fld_tmiEditDocumentType
            // 
            this.fld_tmiEditDocumentType.Name = "fld_tmiEditDocumentType";
            this.fld_tmiEditDocumentType.Size = new System.Drawing.Size(170, 22);
            this.fld_tmiEditDocumentType.Text = "Sửa loại chứng từ";
            this.fld_tmiEditDocumentType.Click += new System.EventHandler(this.fld_tmiEditDocumentType_Click);
            // 
            // fld_tmiConfigEntry
            // 
            this.fld_tmiConfigEntry.Name = "fld_tmiConfigEntry";
            this.fld_tmiConfigEntry.Size = new System.Drawing.Size(170, 22);
            this.fld_tmiConfigEntry.Text = "Cấu hình bút toán";
            this.fld_tmiConfigEntry.Click += new System.EventHandler(this.fld_tmiConfigEntry_Click);
            // 
            // fld_dgvACDocumentTypes
            // 
            this.fld_dgvACDocumentTypes.GridControl = this.fld_dgcACDocumentTypes;
            this.fld_dgvACDocumentTypes.Name = "fld_dgvACDocumentTypes";
            this.fld_dgvACDocumentTypes.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(862, 567);
            this.bosTabControl1.TabIndex = 8;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.fld_TabTranferCost});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_grcGroupControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(855, 538);
            this.xtraTabPage1.Text = "Cấu hình loại chứng từ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosGroupControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(855, 538);
            this.xtraTabPage2.Text = "Cấu hình bút toán theo loại chứng từ";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.Controls.Add(this.fld_btnSaveACDocTypeEntryFunctionMappings);
            this.bosGroupControl1.Controls.Add(this.fld_dgcACDocTypeEntryFunctionMappings);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(855, 538);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl1.Text = "Danh sách chứng từ";
            // 
            // fld_btnSaveACDocTypeEntryFunctionMappings
            // 
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSComment = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSDataMember = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSDataSource = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSDescription = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSError = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSFieldGroup = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSFieldRelation = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSPrivilege = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.BOSPropertyName = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Location = new System.Drawing.Point(817, 25);
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Name = "fld_btnSaveACDocTypeEntryFunctionMappings";
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Screen = null;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveACDocTypeEntryFunctionMappings.TabIndex = 8;
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Text = "bosButton1";
            this.fld_btnSaveACDocTypeEntryFunctionMappings.Click += new System.EventHandler(this.fld_btnSaveACDocTypeEntryFunctionMappings_Click);
            // 
            // fld_dgcACDocTypeEntryFunctionMappings
            // 
            this.fld_dgcACDocTypeEntryFunctionMappings.AllowDrop = true;
            this.fld_dgcACDocTypeEntryFunctionMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSDataSource = "ACDocTypeEntryFunctionMappings";
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSDescription = null;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSError = null;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSGridType = null;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACDocTypeEntryFunctionMappings.ContextMenuStrip = this.fld_ctmDocumentTypeAction;
            this.fld_dgcACDocTypeEntryFunctionMappings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocTypeEntryFunctionMappings.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACDocTypeEntryFunctionMappings.MainView = this.gridView1;
            this.fld_dgcACDocTypeEntryFunctionMappings.Name = "fld_dgcACDocTypeEntryFunctionMappings";
            this.fld_dgcACDocTypeEntryFunctionMappings.PrintReport = false;
            this.fld_dgcACDocTypeEntryFunctionMappings.Screen = null;
            this.fld_dgcACDocTypeEntryFunctionMappings.Size = new System.Drawing.Size(809, 513);
            this.fld_dgcACDocTypeEntryFunctionMappings.TabIndex = 4;
            this.fld_dgcACDocTypeEntryFunctionMappings.Tag = "DC";
            this.fld_dgcACDocTypeEntryFunctionMappings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACDocTypeEntryFunctionMappings;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosGroupControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(855, 538);
            this.xtraTabPage3.Text = "Cấu hình post sổ theo store";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl2.Appearance.Options.UseBackColor = true;
            this.bosGroupControl2.Appearance.Options.UseForeColor = true;
            this.bosGroupControl2.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.Controls.Add(this.fld_btnSaveSTModulePostings);
            this.bosGroupControl2.Controls.Add(this.fld_dgcSTModulePostings);
            this.bosGroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl2.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(855, 538);
            this.bosGroupControl2.TabIndex = 7;
            this.bosGroupControl2.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl2.Text = "Danh sách cấu hình";
            // 
            // fld_btnSaveSTModulePostings
            // 
            this.fld_btnSaveSTModulePostings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveSTModulePostings.BOSComment = null;
            this.fld_btnSaveSTModulePostings.BOSDataMember = null;
            this.fld_btnSaveSTModulePostings.BOSDataSource = null;
            this.fld_btnSaveSTModulePostings.BOSDescription = null;
            this.fld_btnSaveSTModulePostings.BOSError = null;
            this.fld_btnSaveSTModulePostings.BOSFieldGroup = null;
            this.fld_btnSaveSTModulePostings.BOSFieldRelation = null;
            this.fld_btnSaveSTModulePostings.BOSPrivilege = null;
            this.fld_btnSaveSTModulePostings.BOSPropertyName = null;
            this.fld_btnSaveSTModulePostings.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveSTModulePostings.Location = new System.Drawing.Point(817, 25);
            this.fld_btnSaveSTModulePostings.Name = "fld_btnSaveSTModulePostings";
            this.fld_btnSaveSTModulePostings.Screen = null;
            this.fld_btnSaveSTModulePostings.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveSTModulePostings.TabIndex = 8;
            this.fld_btnSaveSTModulePostings.Text = "bosButton1";
            this.fld_btnSaveSTModulePostings.Click += new System.EventHandler(this.fld_btnSaveSTModulePostings_Click);
            // 
            // fld_dgcSTModulePostings
            // 
            this.fld_dgcSTModulePostings.AllowDrop = true;
            this.fld_dgcSTModulePostings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSTModulePostings.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.BOSDataSource = "STModulePostings";
            this.fld_dgcSTModulePostings.BOSDescription = null;
            this.fld_dgcSTModulePostings.BOSError = null;
            this.fld_dgcSTModulePostings.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.BOSGridType = null;
            this.fld_dgcSTModulePostings.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcSTModulePostings.ContextMenuStrip = this.fld_ctmDocumentTypeAction;
            this.fld_dgcSTModulePostings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSTModulePostings.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcSTModulePostings.MainView = this.gridView2;
            this.fld_dgcSTModulePostings.Name = "fld_dgcSTModulePostings";
            this.fld_dgcSTModulePostings.PrintReport = false;
            this.fld_dgcSTModulePostings.Screen = null;
            this.fld_dgcSTModulePostings.Size = new System.Drawing.Size(809, 513);
            this.fld_dgcSTModulePostings.TabIndex = 4;
            this.fld_dgcSTModulePostings.Tag = "DC";
            this.fld_dgcSTModulePostings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcSTModulePostings;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_TabTranferCost
            // 
            this.fld_TabTranferCost.Controls.Add(this.bosGroupControl3);
            this.fld_TabTranferCost.Name = "fld_TabTranferCost";
            this.fld_TabTranferCost.Size = new System.Drawing.Size(855, 538);
            this.fld_TabTranferCost.Text = "Cấu hình kết chuyển";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl3.Appearance.Options.UseBackColor = true;
            this.bosGroupControl3.Appearance.Options.UseForeColor = true;
            this.bosGroupControl3.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.Controls.Add(this.fld_btnSaveAccountCostTranfer);
            this.bosGroupControl3.Controls.Add(this.fld_dgcACAccountTranferCosts);
            this.bosGroupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl3.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(855, 538);
            this.bosGroupControl3.TabIndex = 8;
            this.bosGroupControl3.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosGroupControl3.Text = "Danh sách bút toán";
            // 
            // fld_btnSaveAccountCostTranfer
            // 
            this.fld_btnSaveAccountCostTranfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveAccountCostTranfer.BOSComment = null;
            this.fld_btnSaveAccountCostTranfer.BOSDataMember = null;
            this.fld_btnSaveAccountCostTranfer.BOSDataSource = null;
            this.fld_btnSaveAccountCostTranfer.BOSDescription = null;
            this.fld_btnSaveAccountCostTranfer.BOSError = null;
            this.fld_btnSaveAccountCostTranfer.BOSFieldGroup = null;
            this.fld_btnSaveAccountCostTranfer.BOSFieldRelation = null;
            this.fld_btnSaveAccountCostTranfer.BOSPrivilege = null;
            this.fld_btnSaveAccountCostTranfer.BOSPropertyName = null;
            this.fld_btnSaveAccountCostTranfer.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveAccountCostTranfer.Location = new System.Drawing.Point(817, 25);
            this.fld_btnSaveAccountCostTranfer.Name = "fld_btnSaveAccountCostTranfer";
            this.fld_btnSaveAccountCostTranfer.Screen = null;
            this.fld_btnSaveAccountCostTranfer.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveAccountCostTranfer.TabIndex = 8;
            this.fld_btnSaveAccountCostTranfer.Text = "bosButton1";
            this.fld_btnSaveAccountCostTranfer.Click += new System.EventHandler(this.fld_btnSaveAccountCostTranfer_Click);
            // 
            // fld_dgcACAccountTranferCosts
            // 
            this.fld_dgcACAccountTranferCosts.AllowDrop = true;
            this.fld_dgcACAccountTranferCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACAccountTranferCosts.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.BOSDataSource = "ACAccountTranferCosts";
            this.fld_dgcACAccountTranferCosts.BOSDescription = null;
            this.fld_dgcACAccountTranferCosts.BOSError = null;
            this.fld_dgcACAccountTranferCosts.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.BOSGridType = null;
            this.fld_dgcACAccountTranferCosts.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcACAccountTranferCosts.ContextMenuStrip = this.fld_ctmDocumentTypeAction;
            this.fld_dgcACAccountTranferCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACAccountTranferCosts.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACAccountTranferCosts.MainView = this.gridView3;
            this.fld_dgcACAccountTranferCosts.Name = "fld_dgcACAccountTranferCosts";
            this.fld_dgcACAccountTranferCosts.PrintReport = false;
            this.fld_dgcACAccountTranferCosts.Screen = null;
            this.fld_dgcACAccountTranferCosts.Size = new System.Drawing.Size(809, 513);
            this.fld_dgcACAccountTranferCosts.TabIndex = 4;
            this.fld_dgcACAccountTranferCosts.Tag = "DC";
            this.fld_dgcACAccountTranferCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcACAccountTranferCosts;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // DMACDT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACDT100";
            this.ScreenNumber = "DMACDT100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentTypes)).EndInit();
            this.fld_ctmDocumentTypeAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentTypes)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntryFunctionMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTModulePostings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fld_TabTranferCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountTranferCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private ContextMenuStrip fld_ctmDocumentTypeAction;
        private ToolStripMenuItem fld_tmiEditDocumentType;
        private ToolStripMenuItem fld_tmiConfigEntry;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSERP.Modules.ACDocumentType.ACDocTypeEntryFunctionMappingsGridControl fld_dgcACDocTypeEntryFunctionMappings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnSaveACDocTypeEntryFunctionMappings;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton fld_btnSaveSTModulePostings;
        private STModulePostingsGridControl fld_dgcSTModulePostings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage fld_TabTranferCost;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private BOSComponent.BOSButton fld_btnSaveAccountCostTranfer;
        private ACAccountTranferCostsGridControl fld_dgcACAccountTranferCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}
