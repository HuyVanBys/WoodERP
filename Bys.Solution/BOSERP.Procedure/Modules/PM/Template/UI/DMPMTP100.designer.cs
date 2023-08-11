using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Template.UI
{
	/// <summary>
	/// Summary description for DMDE100
	/// </summary>
    partial class DMPMTP100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtPMTemplateNo1;
		private BOSComponent.BOSTextBox fld_txtPMTemplateName1;
        private BOSComponent.BOSMemoEdit fld_medPMTemplate;


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
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMPhaseTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkePMTemplateStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMTemplateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteMMProductionNormProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMTemplateNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMTemplateName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medPMTemplate = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabTemplateItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabWork = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlTemplateItemsTreeListControl = new BOSERP.Modules.Template.TemplateItemsTreeListControl();
            this.fld_btnAddProductSection = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProductWork = new BOSComponent.BOSButton(this.components);
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcTemplateItemTasksGridControl = new BOSERP.Modules.Template.TemplateItemTasksGridControl();
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcTemplateItemComponentMaterialsGridControl = new BOSERP.Modules.Template.TemplateItemComponentsGridControl();
            this.fld_tabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcTemplateItemComponentAssetsGridControl = new BOSERP.Modules.Template.TemplateItemComponentsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMTemplateStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMTemplate.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).BeginInit();
            this.fld_tabTemplateItem.SuspendLayout();
            this.fld_tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItemsTreeListControl)).BeginInit();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemTasksGridControl)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemComponentMaterialsGridControl)).BeginInit();
            this.fld_tabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemComponentAssetsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel58);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_PMPhaseTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkePMTemplateStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMTemplateDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_pteMMProductionNormProductPicture);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMTemplateNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMTemplateName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medPMTemplate);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(960, 184);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.bosLabel2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel2.Location = new System.Drawing.Point(686, 110);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(6, 13);
            this.bosLabel2.TabIndex = 131;
            this.bosLabel2.Text = "*";
            // 
            // bosLabel58
            // 
            this.bosLabel58.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel58.Appearance.Options.UseForeColor = true;
            this.bosLabel58.BOSComment = null;
            this.bosLabel58.BOSDataMember = null;
            this.bosLabel58.BOSDataSource = null;
            this.bosLabel58.BOSDescription = null;
            this.bosLabel58.BOSError = null;
            this.bosLabel58.BOSFieldGroup = null;
            this.bosLabel58.BOSFieldRelation = null;
            this.bosLabel58.BOSPrivilege = null;
            this.bosLabel58.BOSPropertyName = null;
            this.bosLabel58.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.bosLabel58.Location = new System.Drawing.Point(411, 84);
            this.bosLabel58.Name = "bosLabel58";
            this.bosLabel58.Screen = null;
            this.bosLabel58.Size = new System.Drawing.Size(6, 13);
            this.bosLabel58.TabIndex = 130;
            this.bosLabel58.Text = "*";
            // 
            // fld_lkeFK_PMPhaseTypeID
            // 
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMPhaseTypeID.BOSComment = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSDataMember = "FK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.BOSDataSource = "PMTemplates";
            this.fld_lkeFK_PMPhaseTypeID.BOSDescription = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSError = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldParent = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSPrivilege = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectType = "";
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMPhaseTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMPhaseTypeID.Location = new System.Drawing.Point(228, 109);
            this.fld_lkeFK_PMPhaseTypeID.Name = "fld_lkeFK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMPhaseTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMPhaseTypeName", "Tên Loại dự án", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_PMPhaseTypeID.Properties.DisplayMember = "PMPhaseTypeName";
            this.fld_lkeFK_PMPhaseTypeID.Properties.NullText = "";
            this.fld_lkeFK_PMPhaseTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMPhaseTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMPhaseTypeID.Properties.ValueMember = "PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_PMPhaseTypeID, true);
            this.fld_lkeFK_PMPhaseTypeID.Size = new System.Drawing.Size(455, 20);
            this.fld_lkeFK_PMPhaseTypeID.TabIndex = 5;
            this.fld_lkeFK_PMPhaseTypeID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(145, 112);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 129;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Giai đoạn";
            // 
            // fld_lkePMTemplateStatus
            // 
            this.fld_lkePMTemplateStatus.BOSAllowAddNew = false;
            this.fld_lkePMTemplateStatus.BOSAllowDummy = false;
            this.fld_lkePMTemplateStatus.BOSComment = "";
            this.fld_lkePMTemplateStatus.BOSDataMember = "PMTemplateStatus";
            this.fld_lkePMTemplateStatus.BOSDataSource = "PMTemplates";
            this.fld_lkePMTemplateStatus.BOSDescription = null;
            this.fld_lkePMTemplateStatus.BOSError = null;
            this.fld_lkePMTemplateStatus.BOSFieldGroup = "";
            this.fld_lkePMTemplateStatus.BOSFieldParent = "";
            this.fld_lkePMTemplateStatus.BOSFieldRelation = "";
            this.fld_lkePMTemplateStatus.BOSPrivilege = "";
            this.fld_lkePMTemplateStatus.BOSPropertyName = "EditValue";
            this.fld_lkePMTemplateStatus.BOSSelectType = "";
            this.fld_lkePMTemplateStatus.BOSSelectTypeValue = "";
            this.fld_lkePMTemplateStatus.CurrentDisplayText = null;
            this.fld_lkePMTemplateStatus.Location = new System.Drawing.Point(503, 83);
            this.fld_lkePMTemplateStatus.Name = "fld_lkePMTemplateStatus";
            this.fld_lkePMTemplateStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkePMTemplateStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePMTemplateStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePMTemplateStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePMTemplateStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePMTemplateStatus.Properties.ColumnName = null;
            this.fld_lkePMTemplateStatus.Properties.NullText = "";
            this.fld_lkePMTemplateStatus.Properties.ReadOnly = true;
            this.fld_lkePMTemplateStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePMTemplateStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkePMTemplateStatus, true);
            this.fld_lkePMTemplateStatus.Size = new System.Drawing.Size(180, 20);
            this.fld_lkePMTemplateStatus.TabIndex = 4;
            this.fld_lkePMTemplateStatus.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(427, 86);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 127;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = "";
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "PMTemplates";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(228, 83);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", "Tên Loại dự án", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(180, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 3;
            this.fld_lkeFK_PMProjectTypeID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(145, 86);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(50, 13);
            this.bosLabel3.TabIndex = 126;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại dự án";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(427, 34);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(70, 13);
            this.bosLabel5.TabIndex = 124;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngày chứng từ";
            // 
            // fld_dtePMTemplateDate
            // 
            this.fld_dtePMTemplateDate.BOSComment = "";
            this.fld_dtePMTemplateDate.BOSDataMember = "PMTemplateDate";
            this.fld_dtePMTemplateDate.BOSDataSource = "PMTemplates";
            this.fld_dtePMTemplateDate.BOSDescription = null;
            this.fld_dtePMTemplateDate.BOSError = null;
            this.fld_dtePMTemplateDate.BOSFieldGroup = "";
            this.fld_dtePMTemplateDate.BOSFieldRelation = "";
            this.fld_dtePMTemplateDate.BOSPrivilege = "";
            this.fld_dtePMTemplateDate.BOSPropertyName = "EditValue";
            this.fld_dtePMTemplateDate.EditValue = null;
            this.fld_dtePMTemplateDate.Location = new System.Drawing.Point(503, 31);
            this.fld_dtePMTemplateDate.Name = "fld_dtePMTemplateDate";
            this.fld_dtePMTemplateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMTemplateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMTemplateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMTemplateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMTemplateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMTemplateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMTemplateDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMTemplateDate, true);
            this.fld_dtePMTemplateDate.Size = new System.Drawing.Size(180, 20);
            this.fld_dtePMTemplateDate.TabIndex = 1;
            this.fld_dtePMTemplateDate.Tag = "DC";
            // 
            // fld_pteMMProductionNormProductPicture
            // 
            this.fld_pteMMProductionNormProductPicture.BOSComment = "";
            this.fld_pteMMProductionNormProductPicture.BOSDataMember = "MMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormProductPicture.BOSDescription = null;
            this.fld_pteMMProductionNormProductPicture.BOSError = null;
            this.fld_pteMMProductionNormProductPicture.BOSFieldGroup = "";
            this.fld_pteMMProductionNormProductPicture.BOSFieldRelation = "";
            this.fld_pteMMProductionNormProductPicture.BOSPrivilege = "";
            this.fld_pteMMProductionNormProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteMMProductionNormProductPicture.EditValue = "";
            this.fld_pteMMProductionNormProductPicture.FileName = null;
            this.fld_pteMMProductionNormProductPicture.FilePath = null;
            this.fld_pteMMProductionNormProductPicture.Location = new System.Drawing.Point(9, 25);
            this.fld_pteMMProductionNormProductPicture.Name = "fld_pteMMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteMMProductionNormProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteMMProductionNormProductPicture, true);
            this.fld_pteMMProductionNormProductPicture.Size = new System.Drawing.Size(120, 112);
            this.fld_pteMMProductionNormProductPicture.TabIndex = 6;
            this.fld_pteMMProductionNormProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "PMTemplates";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(10, 143);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 7;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(145, 34);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(145, 60);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(145, 138);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtPMTemplateNo1
            // 
            this.fld_txtPMTemplateNo1.BOSComment = "";
            this.fld_txtPMTemplateNo1.BOSDataMember = "PMTemplateNo";
            this.fld_txtPMTemplateNo1.BOSDataSource = "PMTemplates";
            this.fld_txtPMTemplateNo1.BOSDescription = null;
            this.fld_txtPMTemplateNo1.BOSError = "Mã chứng từ không thể rỗng.";
            this.fld_txtPMTemplateNo1.BOSFieldGroup = "";
            this.fld_txtPMTemplateNo1.BOSFieldRelation = "";
            this.fld_txtPMTemplateNo1.BOSPrivilege = "";
            this.fld_txtPMTemplateNo1.BOSPropertyName = "Text";
            this.fld_txtPMTemplateNo1.Location = new System.Drawing.Point(228, 31);
            this.fld_txtPMTemplateNo1.Name = "fld_txtPMTemplateNo1";
            this.fld_txtPMTemplateNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMTemplateNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMTemplateNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMTemplateNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMTemplateNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMTemplateNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMTemplateNo1.Screen = null;
            this.fld_txtPMTemplateNo1.Size = new System.Drawing.Size(180, 20);
            this.fld_txtPMTemplateNo1.TabIndex = 0;
            this.fld_txtPMTemplateNo1.Tag = "DC";
            // 
            // fld_txtPMTemplateName1
            // 
            this.fld_txtPMTemplateName1.BOSComment = "";
            this.fld_txtPMTemplateName1.BOSDataMember = "PMTemplateName";
            this.fld_txtPMTemplateName1.BOSDataSource = "PMTemplates";
            this.fld_txtPMTemplateName1.BOSDescription = null;
            this.fld_txtPMTemplateName1.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtPMTemplateName1.BOSFieldGroup = "";
            this.fld_txtPMTemplateName1.BOSFieldRelation = "";
            this.fld_txtPMTemplateName1.BOSPrivilege = "";
            this.fld_txtPMTemplateName1.BOSPropertyName = "Text";
            this.fld_txtPMTemplateName1.Location = new System.Drawing.Point(228, 57);
            this.fld_txtPMTemplateName1.Name = "fld_txtPMTemplateName1";
            this.fld_txtPMTemplateName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMTemplateName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMTemplateName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMTemplateName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMTemplateName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMTemplateName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMTemplateName1.Screen = null;
            this.fld_txtPMTemplateName1.Size = new System.Drawing.Size(455, 20);
            this.fld_txtPMTemplateName1.TabIndex = 2;
            this.fld_txtPMTemplateName1.Tag = "DC";
            // 
            // fld_medPMTemplate
            // 
            this.fld_medPMTemplate.BOSComment = "";
            this.fld_medPMTemplate.BOSDataMember = "PMTemplateDesc";
            this.fld_medPMTemplate.BOSDataSource = "PMTemplates";
            this.fld_medPMTemplate.BOSDescription = null;
            this.fld_medPMTemplate.BOSError = "";
            this.fld_medPMTemplate.BOSFieldGroup = "";
            this.fld_medPMTemplate.BOSFieldRelation = "";
            this.fld_medPMTemplate.BOSPrivilege = "";
            this.fld_medPMTemplate.BOSPropertyName = "Text";
            this.fld_medPMTemplate.Location = new System.Drawing.Point(228, 135);
            this.fld_medPMTemplate.Name = "fld_medPMTemplate";
            this.fld_medPMTemplate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medPMTemplate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medPMTemplate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medPMTemplate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medPMTemplate.Screen = null;
            this.fld_medPMTemplate.Size = new System.Drawing.Size(455, 40);
            this.fld_medPMTemplate.TabIndex = 6;
            this.fld_medPMTemplate.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_tabTemplateItem);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(975, 655);
            this.bosPanel1.TabIndex = 29;
            // 
            // fld_tabTemplateItem
            // 
            this.fld_tabTemplateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabTemplateItem.BOSComment = null;
            this.fld_tabTemplateItem.BOSDataMember = null;
            this.fld_tabTemplateItem.BOSDataSource = "";
            this.fld_tabTemplateItem.BOSDescription = null;
            this.fld_tabTemplateItem.BOSError = null;
            this.fld_tabTemplateItem.BOSFieldGroup = null;
            this.fld_tabTemplateItem.BOSFieldRelation = null;
            this.fld_tabTemplateItem.BOSPrivilege = null;
            this.fld_tabTemplateItem.BOSPropertyName = null;
            this.fld_tabTemplateItem.Location = new System.Drawing.Point(3, 193);
            this.fld_tabTemplateItem.Name = "fld_tabTemplateItem";
            this.fld_tabTemplateItem.Screen = null;
            this.fld_tabTemplateItem.SelectedTabPage = this.fld_tabWork;
            this.fld_tabTemplateItem.Size = new System.Drawing.Size(960, 459);
            this.fld_tabTemplateItem.TabIndex = 1;
            this.fld_tabTemplateItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabWork,
            this.fld_tabTask,
            this.fld_tabMaterial,
            this.fld_tabAsset});
            this.fld_tabTemplateItem.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabTemplateItem_SelectedPageChanged);
            // 
            // fld_tabWork
            // 
            this.fld_tabWork.Controls.Add(this.fld_trlTemplateItemsTreeListControl);
            this.fld_tabWork.Controls.Add(this.fld_btnAddProductSection);
            this.fld_tabWork.Controls.Add(this.fld_btnAddProductWork);
            this.fld_tabWork.Name = "fld_tabWork";
            this.fld_tabWork.Size = new System.Drawing.Size(954, 431);
            this.fld_tabWork.Text = "Danh sách công việc";
            // 
            // fld_trlTemplateItemsTreeListControl
            // 
            this.fld_trlTemplateItemsTreeListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlTemplateItemsTreeListControl.BOSComment = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDataMember = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDataSource = "PMTemplateItems";
            this.fld_trlTemplateItemsTreeListControl.BOSDescription = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDisplayOption = false;
            this.fld_trlTemplateItemsTreeListControl.BOSDisplayRoot = true;
            this.fld_trlTemplateItemsTreeListControl.BOSError = null;
            this.fld_trlTemplateItemsTreeListControl.BOSFieldGroup = null;
            this.fld_trlTemplateItemsTreeListControl.BOSFieldRelation = null;
            this.fld_trlTemplateItemsTreeListControl.BOSPrivilege = null;
            this.fld_trlTemplateItemsTreeListControl.BOSPropertyName = null;
            this.fld_trlTemplateItemsTreeListControl.Location = new System.Drawing.Point(12, 41);
            this.fld_trlTemplateItemsTreeListControl.Name = "fld_trlTemplateItemsTreeListControl";
            this.fld_trlTemplateItemsTreeListControl.Screen = null;
            this.fld_trlTemplateItemsTreeListControl.Size = new System.Drawing.Size(939, 386);
            this.fld_trlTemplateItemsTreeListControl.TabIndex = 3;
            // 
            // fld_btnAddProductSection
            // 
            this.fld_btnAddProductSection.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductSection.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductSection.BOSComment = "";
            this.fld_btnAddProductSection.BOSDataMember = null;
            this.fld_btnAddProductSection.BOSDataSource = null;
            this.fld_btnAddProductSection.BOSDescription = null;
            this.fld_btnAddProductSection.BOSError = null;
            this.fld_btnAddProductSection.BOSFieldGroup = "";
            this.fld_btnAddProductSection.BOSFieldRelation = "";
            this.fld_btnAddProductSection.BOSPrivilege = "";
            this.fld_btnAddProductSection.BOSPropertyName = null;
            this.fld_btnAddProductSection.Location = new System.Drawing.Point(13, 9);
            this.fld_btnAddProductSection.Name = "fld_btnAddProductSection";
            this.fld_btnAddProductSection.Screen = null;
            this.fld_btnAddProductSection.Size = new System.Drawing.Size(115, 26);
            this.fld_btnAddProductSection.TabIndex = 1;
            this.fld_btnAddProductSection.Tag = "AddProductSectionButtonName";
            this.fld_btnAddProductSection.Text = "Thêm hạng mục";
            this.fld_btnAddProductSection.Click += new System.EventHandler(this.fld_btnAddProductSection_Click);
            // 
            // fld_btnAddProductWork
            // 
            this.fld_btnAddProductWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWork.BOSComment = "";
            this.fld_btnAddProductWork.BOSDataMember = null;
            this.fld_btnAddProductWork.BOSDataSource = null;
            this.fld_btnAddProductWork.BOSDescription = null;
            this.fld_btnAddProductWork.BOSError = null;
            this.fld_btnAddProductWork.BOSFieldGroup = "";
            this.fld_btnAddProductWork.BOSFieldRelation = "";
            this.fld_btnAddProductWork.BOSPrivilege = "";
            this.fld_btnAddProductWork.BOSPropertyName = null;
            this.fld_btnAddProductWork.Location = new System.Drawing.Point(134, 8);
            this.fld_btnAddProductWork.Name = "fld_btnAddProductWork";
            this.fld_btnAddProductWork.Screen = null;
            this.fld_btnAddProductWork.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductWork.TabIndex = 2;
            this.fld_btnAddProductWork.Tag = "AddProductWorkButtonName";
            this.fld_btnAddProductWork.Text = "Thêm công việc";
            this.fld_btnAddProductWork.Click += new System.EventHandler(this.fld_btnProductWork_Click);
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcTemplateItemTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(948, 424);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_dgcTemplateItemTasksGridControl
            // 
            this.fld_dgcTemplateItemTasksGridControl.BOSComment = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSDataMember = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSDataSource = "PMTemplateItemTasks";
            this.fld_dgcTemplateItemTasksGridControl.BOSDescription = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSError = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSGridType = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSPrivilege = null;
            this.fld_dgcTemplateItemTasksGridControl.BOSPropertyName = null;
            this.fld_dgcTemplateItemTasksGridControl.CommodityType = "";
            this.fld_dgcTemplateItemTasksGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcTemplateItemTasksGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcTemplateItemTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcTemplateItemTasksGridControl.Name = "fld_dgcTemplateItemTasksGridControl";
            this.fld_dgcTemplateItemTasksGridControl.PrintReport = false;
            this.fld_dgcTemplateItemTasksGridControl.Screen = null;
            this.fld_dgcTemplateItemTasksGridControl.Size = new System.Drawing.Size(948, 424);
            this.fld_dgcTemplateItemTasksGridControl.TabIndex = 1;
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_dgcTemplateItemComponentMaterialsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(948, 424);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_dgcTemplateItemComponentMaterialsGridControl
            // 
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSComment = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSDataSource = "PMTemplateItemComponents";
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSDescription = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSError = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSGridType = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.CommodityType = "";
            this.fld_dgcTemplateItemComponentMaterialsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcTemplateItemComponentMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.Name = "fld_dgcTemplateItemComponentMaterialsGridControl";
            this.fld_dgcTemplateItemComponentMaterialsGridControl.PrintReport = false;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.Screen = null;
            this.fld_dgcTemplateItemComponentMaterialsGridControl.Size = new System.Drawing.Size(948, 424);
            this.fld_dgcTemplateItemComponentMaterialsGridControl.TabIndex = 0;
            // 
            // fld_tabAsset
            // 
            this.fld_tabAsset.Controls.Add(this.fld_dgcTemplateItemComponentAssetsGridControl);
            this.fld_tabAsset.Name = "fld_tabAsset";
            this.fld_tabAsset.Size = new System.Drawing.Size(948, 424);
            this.fld_tabAsset.Text = "Danh sách MM, CCDC";
            // 
            // fld_dgcTemplateItemComponentAssetsGridControl
            // 
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSComment = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSDataMember = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSDataSource = "PMTemplateItemComponents";
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSDescription = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSError = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSGridType = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.CommodityType = "";
            this.fld_dgcTemplateItemComponentAssetsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcTemplateItemComponentAssetsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcTemplateItemComponentAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcTemplateItemComponentAssetsGridControl.Name = "fld_dgcTemplateItemComponentAssetsGridControl";
            this.fld_dgcTemplateItemComponentAssetsGridControl.PrintReport = false;
            this.fld_dgcTemplateItemComponentAssetsGridControl.Screen = null;
            this.fld_dgcTemplateItemComponentAssetsGridControl.Size = new System.Drawing.Size(948, 424);
            this.fld_dgcTemplateItemComponentAssetsGridControl.TabIndex = 1;
            // 
            // DMPMTP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(975, 655);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPMTP100";
            this.ShowIcon = false;
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMTemplateStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMTemplate.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).EndInit();
            this.fld_tabTemplateItem.ResumeLayout(false);
            this.fld_tabWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItemsTreeListControl)).EndInit();
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemTasksGridControl)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemComponentMaterialsGridControl)).EndInit();
            this.fld_tabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateItemComponentAssetsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dtePMTemplateDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkePMTemplateStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTabControl fld_tabTemplateItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabWork;
        private BOSComponent.BOSButton fld_btnAddProductSection;
        private BOSComponent.BOSButton fld_btnAddProductWork;
        private TemplateItemsTreeListControl fld_trlTemplateItemsTreeListControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabAsset;
        private TemplateItemComponentsGridControl fld_dgcTemplateItemComponentMaterialsGridControl;
        private TemplateItemComponentsGridControl fld_dgcTemplateItemComponentAssetsGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private TemplateItemTasksGridControl fld_dgcTemplateItemTasksGridControl;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMPhaseTypeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel58;
    }
}
