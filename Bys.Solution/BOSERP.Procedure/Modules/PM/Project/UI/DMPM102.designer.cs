using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
    /// Summary description for DMPM102
	/// </summary>
    partial class DMPM102
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
            this.fld_tabProjectTemplate = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcProjectTemplateRelationshipsGridControl = new BOSERP.Modules.Project.ProjectTemplateRelationshipsGridControl();
            this.fld_btnShowProject = new BOSComponent.BOSButton(this.components);
            this.fld_btnShowTemplateList = new BOSComponent.BOSButton(this.components);
            this.fld_tabProjectNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabWork = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlProjectNormsTreeListControl = new BOSERP.Modules.Project.ProjectNormsTreeListControl();
            this.fld_btnAddProductSection = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProductWork = new BOSComponent.BOSButton(this.components);
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnShowAllTasks = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPMTasksGridControl = new BOSERP.Modules.Project.PMTasksGridControl();
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcProjectNormItemMaterialsGridControl = new BOSERP.Modules.Project.ProjectNormItemsGridControl();
            this.fld_tabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcProjectNormItemAssetsGridControl = new BOSERP.Modules.Project.ProjectNormItemsGridControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectTemplate)).BeginInit();
            this.fld_tabProjectTemplate.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectTemplateRelationshipsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectNorm)).BeginInit();
            this.fld_tabProjectNorm.SuspendLayout();
            this.fld_tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProjectNormsTreeListControl)).BeginInit();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemMaterialsGridControl)).BeginInit();
            this.fld_tabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemAssetsGridControl)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_tabProjectTemplate);
            this.bosPanel1.Controls.Add(this.fld_btnShowProject);
            this.bosPanel1.Controls.Add(this.fld_btnShowTemplateList);
            this.bosPanel1.Controls.Add(this.fld_tabProjectNorm);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1001, 644);
            this.bosPanel1.TabIndex = 29;
            // 
            // fld_tabProjectTemplate
            // 
            this.fld_tabProjectTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_tabProjectTemplate.BOSComment = null;
            this.fld_tabProjectTemplate.BOSDataMember = null;
            this.fld_tabProjectTemplate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_tabProjectTemplate.BOSDescription = null;
            this.fld_tabProjectTemplate.BOSError = null;
            this.fld_tabProjectTemplate.BOSFieldGroup = null;
            this.fld_tabProjectTemplate.BOSFieldRelation = null;
            this.fld_tabProjectTemplate.BOSPrivilege = null;
            this.fld_tabProjectTemplate.BOSPropertyName = null;
            this.fld_tabProjectTemplate.Location = new System.Drawing.Point(3, 45);
            this.fld_tabProjectTemplate.Name = "fld_tabProjectTemplate";
            this.fld_tabProjectTemplate.Screen = null;
            this.fld_tabProjectTemplate.SelectedTabPage = this.xtraTabPage3;
            this.fld_tabProjectTemplate.Size = new System.Drawing.Size(302, 599);
            this.fld_tabProjectTemplate.TabIndex = 31;
            this.fld_tabProjectTemplate.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcProjectTemplateRelationshipsGridControl);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(295, 570);
            this.xtraTabPage3.Text = "Danh sách giai đoạn";
            // 
            // fld_dgcProjectTemplateRelationshipsGridControl
            // 
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSComment = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSDataMember = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSDataSource = "PMProjectTemplateRelationships";
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSDescription = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSError = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSGridType = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProjectTemplateRelationshipsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProjectTemplateRelationshipsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectTemplateRelationshipsGridControl.Name = "fld_dgcProjectTemplateRelationshipsGridControl";
            this.fld_dgcProjectTemplateRelationshipsGridControl.PrintReport = false;
            this.fld_dgcProjectTemplateRelationshipsGridControl.Screen = null;
            this.fld_dgcProjectTemplateRelationshipsGridControl.Size = new System.Drawing.Size(295, 570);
            this.fld_dgcProjectTemplateRelationshipsGridControl.TabIndex = 0;
            // 
            // fld_btnShowProject
            // 
            this.fld_btnShowProject.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowProject.Appearance.Options.UseForeColor = true;
            this.fld_btnShowProject.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowProject.BOSDataMember = null;
            this.fld_btnShowProject.BOSDataSource = null;
            this.fld_btnShowProject.BOSDescription = null;
            this.fld_btnShowProject.BOSError = null;
            this.fld_btnShowProject.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowProject.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowProject.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowProject.BOSPropertyName = null;
            this.fld_btnShowProject.Location = new System.Drawing.Point(175, 13);
            this.fld_btnShowProject.Name = "fld_btnShowProject";
            this.fld_btnShowProject.Screen = null;
            this.fld_btnShowProject.Size = new System.Drawing.Size(192, 26);
            this.fld_btnShowProject.TabIndex = 30;
            this.fld_btnShowProject.Tag = "AddProductWorkGroupButtonName";
            this.fld_btnShowProject.Text = "Thêm bảng định mức từ dự án cũ";
            this.fld_btnShowProject.Click += new System.EventHandler(this.fld_btnShowProject_Click);
            // 
            // fld_btnShowTemplateList
            // 
            this.fld_btnShowTemplateList.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowTemplateList.Appearance.Options.UseForeColor = true;
            this.fld_btnShowTemplateList.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowTemplateList.BOSDataMember = null;
            this.fld_btnShowTemplateList.BOSDataSource = null;
            this.fld_btnShowTemplateList.BOSDescription = null;
            this.fld_btnShowTemplateList.BOSError = null;
            this.fld_btnShowTemplateList.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowTemplateList.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowTemplateList.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowTemplateList.BOSPropertyName = null;
            this.fld_btnShowTemplateList.Location = new System.Drawing.Point(14, 12);
            this.fld_btnShowTemplateList.Name = "fld_btnShowTemplateList";
            this.fld_btnShowTemplateList.Screen = null;
            this.fld_btnShowTemplateList.Size = new System.Drawing.Size(155, 27);
            this.fld_btnShowTemplateList.TabIndex = 29;
            this.fld_btnShowTemplateList.Tag = "AddPhaseTypeButtonName";
            this.fld_btnShowTemplateList.Text = "Thêm bảng định mức từ mẫu";
            this.fld_btnShowTemplateList.Click += new System.EventHandler(this.fld_btnShowTemplateList_Click);
            // 
            // fld_tabProjectNorm
            // 
            this.fld_tabProjectNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProjectNorm.BOSComment = null;
            this.fld_tabProjectNorm.BOSDataMember = null;
            this.fld_tabProjectNorm.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_tabProjectNorm.BOSDescription = null;
            this.fld_tabProjectNorm.BOSError = null;
            this.fld_tabProjectNorm.BOSFieldGroup = null;
            this.fld_tabProjectNorm.BOSFieldRelation = null;
            this.fld_tabProjectNorm.BOSPrivilege = null;
            this.fld_tabProjectNorm.BOSPropertyName = null;
            this.fld_tabProjectNorm.Location = new System.Drawing.Point(306, 45);
            this.fld_tabProjectNorm.Name = "fld_tabProjectNorm";
            this.fld_tabProjectNorm.Screen = null;
            this.fld_tabProjectNorm.SelectedTabPage = this.fld_tabWork;
            this.fld_tabProjectNorm.Size = new System.Drawing.Size(695, 599);
            this.fld_tabProjectNorm.TabIndex = 28;
            this.fld_tabProjectNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabWork,
            this.fld_tabTask,
            this.fld_tabMaterial,
            this.fld_tabAsset});
            this.fld_tabProjectNorm.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabProjectNorm_SelectedPageChanged);
            // 
            // fld_tabWork
            // 
            this.fld_tabWork.Controls.Add(this.fld_trlProjectNormsTreeListControl);
            this.fld_tabWork.Controls.Add(this.fld_btnAddProductSection);
            this.fld_tabWork.Controls.Add(this.fld_btnAddProductWork);
            this.fld_tabWork.Name = "fld_tabWork";
            this.fld_tabWork.Size = new System.Drawing.Size(688, 570);
            this.fld_tabWork.Text = "Danh sách công việc";
            // 
            // fld_trlProjectNormsTreeListControl
            // 
            this.fld_trlProjectNormsTreeListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlProjectNormsTreeListControl.BOSComment = null;
            this.fld_trlProjectNormsTreeListControl.BOSDataMember = null;
            this.fld_trlProjectNormsTreeListControl.BOSDataSource = "PMProjectNorms";
            this.fld_trlProjectNormsTreeListControl.BOSDescription = null;
            this.fld_trlProjectNormsTreeListControl.BOSDisplayOption = false;
            this.fld_trlProjectNormsTreeListControl.BOSDisplayRoot = true;
            this.fld_trlProjectNormsTreeListControl.BOSError = null;
            this.fld_trlProjectNormsTreeListControl.BOSFieldGroup = null;
            this.fld_trlProjectNormsTreeListControl.BOSFieldRelation = null;
            this.fld_trlProjectNormsTreeListControl.BOSPrivilege = null;
            this.fld_trlProjectNormsTreeListControl.BOSPropertyName = null;
            this.fld_trlProjectNormsTreeListControl.Location = new System.Drawing.Point(12, 41);
            this.fld_trlProjectNormsTreeListControl.Name = "fld_trlProjectNormsTreeListControl";
            this.fld_trlProjectNormsTreeListControl.Screen = null;
            this.fld_trlProjectNormsTreeListControl.Size = new System.Drawing.Size(669, 522);
            this.fld_trlProjectNormsTreeListControl.TabIndex = 9;
            // 
            // fld_btnAddProductSection
            // 
            this.fld_btnAddProductSection.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductSection.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductSection.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductSection.BOSDataMember = null;
            this.fld_btnAddProductSection.BOSDataSource = null;
            this.fld_btnAddProductSection.BOSDescription = null;
            this.fld_btnAddProductSection.BOSError = null;
            this.fld_btnAddProductSection.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductSection.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductSection.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductSection.BOSPropertyName = null;
            this.fld_btnAddProductSection.Location = new System.Drawing.Point(12, 9);
            this.fld_btnAddProductSection.Name = "fld_btnAddProductSection";
            this.fld_btnAddProductSection.Screen = null;
            this.fld_btnAddProductSection.Size = new System.Drawing.Size(121, 26);
            this.fld_btnAddProductSection.TabIndex = 7;
            this.fld_btnAddProductSection.Tag = "AddProductSectionButtonName";
            this.fld_btnAddProductSection.Text = "Thêm hạng mục";
            this.fld_btnAddProductSection.Click += new System.EventHandler(this.fld_btnAddProductSection_Click);
            // 
            // fld_btnAddProductWork
            // 
            this.fld_btnAddProductWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWork.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductWork.BOSDataMember = null;
            this.fld_btnAddProductWork.BOSDataSource = null;
            this.fld_btnAddProductWork.BOSDescription = null;
            this.fld_btnAddProductWork.BOSError = null;
            this.fld_btnAddProductWork.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductWork.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductWork.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProductWork.BOSPropertyName = null;
            this.fld_btnAddProductWork.Location = new System.Drawing.Point(139, 9);
            this.fld_btnAddProductWork.Name = "fld_btnAddProductWork";
            this.fld_btnAddProductWork.Screen = null;
            this.fld_btnAddProductWork.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductWork.TabIndex = 8;
            this.fld_btnAddProductWork.Tag = "AddProductWorkButtonName";
            this.fld_btnAddProductWork.Text = "Thêm công việc";
            this.fld_btnAddProductWork.Click += new System.EventHandler(this.fld_btnAddProductWork_Click);
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_btnShowAllTasks);
            this.fld_tabTask.Controls.Add(this.fld_dgcPMTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(688, 570);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_btnShowAllTasks
            // 
            this.fld_btnShowAllTasks.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowAllTasks.Appearance.Options.UseForeColor = true;
            this.fld_btnShowAllTasks.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowAllTasks.BOSDataMember = null;
            this.fld_btnShowAllTasks.BOSDataSource = null;
            this.fld_btnShowAllTasks.BOSDescription = null;
            this.fld_btnShowAllTasks.BOSError = null;
            this.fld_btnShowAllTasks.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowAllTasks.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowAllTasks.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnShowAllTasks.BOSPropertyName = null;
            this.fld_btnShowAllTasks.Location = new System.Drawing.Point(3, 3);
            this.fld_btnShowAllTasks.Name = "fld_btnShowAllTasks";
            this.fld_btnShowAllTasks.Screen = null;
            this.fld_btnShowAllTasks.Size = new System.Drawing.Size(121, 26);
            this.fld_btnShowAllTasks.TabIndex = 8;
            this.fld_btnShowAllTasks.Tag = "AddProductSectionButtonName";
            this.fld_btnShowAllTasks.Text = "Xem tất cả";
            this.fld_btnShowAllTasks.Click += new System.EventHandler(this.fld_btnShowAllTasks_Click);
            // 
            // fld_dgcPMTasksGridControl
            // 
            this.fld_dgcPMTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMTasksGridControl.BOSComment = null;
            this.fld_dgcPMTasksGridControl.BOSDataMember = null;
            this.fld_dgcPMTasksGridControl.BOSDataSource = "PMTasks";
            this.fld_dgcPMTasksGridControl.BOSDescription = null;
            this.fld_dgcPMTasksGridControl.BOSError = null;
            this.fld_dgcPMTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcPMTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcPMTasksGridControl.BOSGridType = null;
            this.fld_dgcPMTasksGridControl.BOSPrivilege = null;
            this.fld_dgcPMTasksGridControl.BOSPropertyName = null;
            this.fld_dgcPMTasksGridControl.Location = new System.Drawing.Point(0, 35);
            this.fld_dgcPMTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMTasksGridControl.Name = "fld_dgcPMTasksGridControl";
            this.fld_dgcPMTasksGridControl.PrintReport = false;
            this.fld_dgcPMTasksGridControl.Screen = null;
            this.fld_dgcPMTasksGridControl.Size = new System.Drawing.Size(688, 535);
            this.fld_dgcPMTasksGridControl.TabIndex = 1;
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_dgcProjectNormItemMaterialsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(688, 570);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_dgcProjectNormItemMaterialsGridControl
            // 
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSComment = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDataSource = "PMProjectNormItems";
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDescription = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSError = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSGridType = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProjectNormItemMaterialsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProjectNormItemMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectNormItemMaterialsGridControl.Name = "fld_dgcProjectNormItemMaterialsGridControl";
            this.fld_dgcProjectNormItemMaterialsGridControl.PrintReport = false;
            this.fld_dgcProjectNormItemMaterialsGridControl.Screen = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.Size = new System.Drawing.Size(688, 570);
            this.fld_dgcProjectNormItemMaterialsGridControl.TabIndex = 0;
            // 
            // fld_tabAsset
            // 
            this.fld_tabAsset.Controls.Add(this.fld_dgcProjectNormItemAssetsGridControl);
            this.fld_tabAsset.Name = "fld_tabAsset";
            this.fld_tabAsset.Size = new System.Drawing.Size(688, 570);
            this.fld_tabAsset.Text = "Danh sách MM, CCDC";
            // 
            // fld_dgcProjectNormItemAssetsGridControl
            // 
            this.fld_dgcProjectNormItemAssetsGridControl.BOSComment = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDataMember = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDataSource = "PMProjectNormItems";
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDescription = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSError = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSGridType = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectNormItemAssetsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProjectNormItemAssetsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProjectNormItemAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectNormItemAssetsGridControl.Name = "fld_dgcProjectNormItemAssetsGridControl";
            this.fld_dgcProjectNormItemAssetsGridControl.PrintReport = false;
            this.fld_dgcProjectNormItemAssetsGridControl.Screen = null;
            this.fld_dgcProjectNormItemAssetsGridControl.Size = new System.Drawing.Size(688, 570);
            this.fld_dgcProjectNormItemAssetsGridControl.TabIndex = 1;
            // 
            // DMPM102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1001, 644);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPM102";
            this.ShowIcon = false;
            this.Text = "Bảng định mức";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectTemplate)).EndInit();
            this.fld_tabProjectTemplate.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectTemplateRelationshipsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectNorm)).EndInit();
            this.fld_tabProjectNorm.ResumeLayout(false);
            this.fld_tabWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProjectNormsTreeListControl)).EndInit();
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemMaterialsGridControl)).EndInit();
            this.fld_tabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemAssetsGridControl)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabProjectNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabWork;
        private BOSERP.Modules.Project.ProjectNormsTreeListControl fld_trlProjectNormsTreeListControl;
        private BOSComponent.BOSButton fld_btnAddProductSection;
        private BOSComponent.BOSButton fld_btnAddProductWork;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private BOSERP.Modules.Project.ProjectNormItemsGridControl fld_dgcProjectNormItemMaterialsGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabAsset;
        private BOSERP.Modules.Project.ProjectNormItemsGridControl fld_dgcProjectNormItemAssetsGridControl;
        private BOSComponent.BOSButton fld_btnShowProject;
        private BOSComponent.BOSButton fld_btnShowTemplateList;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private PMTasksGridControl fld_dgcPMTasksGridControl;
        private BOSComponent.BOSTabControl fld_tabProjectTemplate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ProjectTemplateRelationshipsGridControl fld_dgcProjectTemplateRelationshipsGridControl;
        private BOSComponent.BOSButton fld_btnShowAllTasks;
	}
}
