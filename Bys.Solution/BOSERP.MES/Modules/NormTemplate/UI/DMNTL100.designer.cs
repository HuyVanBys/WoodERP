using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.NormTemplate.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMNTL100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_medMMNormTemplateDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMNormTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_btnGetTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnImportTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMNormTemplateItems = new BOSERP.Modules.NormTemplate.NormTemplateItemsGridControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMNormTemplateDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMNormTemplateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplateItems)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(843, 562);
            this.xtraScrollableControl1.TabIndex = 0;
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(843, 562);
            this.bosPanel1.TabIndex = 0;
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
            this.bosGroupControl1.Controls.Add(this.fld_medMMNormTemplateDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMNormTemplateNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(837, 104);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Tag = "DC";
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_medMMNormTemplateDesc
            // 
            this.fld_medMMNormTemplateDesc.BOSComment = null;
            this.fld_medMMNormTemplateDesc.BOSDataMember = "MMNormTemplateDesc";
            this.fld_medMMNormTemplateDesc.BOSDataSource = "MMNormTemplates";
            this.fld_medMMNormTemplateDesc.BOSDescription = null;
            this.fld_medMMNormTemplateDesc.BOSError = null;
            this.fld_medMMNormTemplateDesc.BOSFieldGroup = null;
            this.fld_medMMNormTemplateDesc.BOSFieldRelation = null;
            this.fld_medMMNormTemplateDesc.BOSPrivilege = null;
            this.fld_medMMNormTemplateDesc.BOSPropertyName = "EditValue";
            this.fld_medMMNormTemplateDesc.Location = new System.Drawing.Point(99, 59);
            this.fld_medMMNormTemplateDesc.MenuManager = this.screenToolbar;
            this.fld_medMMNormTemplateDesc.Name = "fld_medMMNormTemplateDesc";
            this.fld_medMMNormTemplateDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMNormTemplateDesc, true);
            this.fld_medMMNormTemplateDesc.Size = new System.Drawing.Size(422, 37);
            this.fld_medMMNormTemplateDesc.TabIndex = 7;
            this.fld_medMMNormTemplateDesc.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(21, 62);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel3.Location = new System.Drawing.Point(551, 36);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMNormTemplates";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(638, 33);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(551, 62);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 8;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMNormTemplateStatus";
            this.bosLookupEdit3.BOSDataSource = "MMNormTemplates";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(638, 59);
            this.bosLookupEdit3.MenuManager = this.screenToolbar;
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 9;
            this.bosLookupEdit3.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(284, 36);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Text = "Ngày chứng từ";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "MMNormTemplateDate";
            this.bosDateEdit1.BOSDataSource = "MMNormTemplates";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(371, 33);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 3;
            this.bosDateEdit1.Tag = "DC";
            // 
            // fld_txtMMNormTemplateNo
            // 
            this.fld_txtMMNormTemplateNo.BOSComment = null;
            this.fld_txtMMNormTemplateNo.BOSDataMember = "MMNormTemplateNo";
            this.fld_txtMMNormTemplateNo.BOSDataSource = "MMNormTemplates";
            this.fld_txtMMNormTemplateNo.BOSDescription = null;
            this.fld_txtMMNormTemplateNo.BOSError = null;
            this.fld_txtMMNormTemplateNo.BOSFieldGroup = null;
            this.fld_txtMMNormTemplateNo.BOSFieldRelation = null;
            this.fld_txtMMNormTemplateNo.BOSPrivilege = null;
            this.fld_txtMMNormTemplateNo.BOSPropertyName = "Text";
            this.fld_txtMMNormTemplateNo.Location = new System.Drawing.Point(99, 33);
            this.fld_txtMMNormTemplateNo.MenuManager = this.screenToolbar;
            this.fld_txtMMNormTemplateNo.Name = "fld_txtMMNormTemplateNo";
            this.fld_txtMMNormTemplateNo.Properties.ReadOnly = true;
            this.fld_txtMMNormTemplateNo.Screen = null;
            this.fld_txtMMNormTemplateNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMNormTemplateNo.TabIndex = 1;
            this.fld_txtMMNormTemplateNo.Tag = "DC";
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
            this.bosGroupControl2.Controls.Add(this.xtraScrollableControl2);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 113);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(837, 446);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin chi tiết";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.fld_btnGetTemplate);
            this.xtraScrollableControl2.Controls.Add(this.fld_btnImportTemplate);
            this.xtraScrollableControl2.Controls.Add(this.fld_dgcMMNormTemplateItems);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(2, 22);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(833, 422);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // fld_btnGetTemplate
            // 
            this.fld_btnGetTemplate.BOSComment = null;
            this.fld_btnGetTemplate.BOSDataMember = null;
            this.fld_btnGetTemplate.BOSDataSource = null;
            this.fld_btnGetTemplate.BOSDescription = null;
            this.fld_btnGetTemplate.BOSError = null;
            this.fld_btnGetTemplate.BOSFieldGroup = null;
            this.fld_btnGetTemplate.BOSFieldRelation = null;
            this.fld_btnGetTemplate.BOSPrivilege = null;
            this.fld_btnGetTemplate.BOSPropertyName = null;
            this.fld_btnGetTemplate.Location = new System.Drawing.Point(7, 5);
            this.fld_btnGetTemplate.Name = "fld_btnGetTemplate";
            this.fld_btnGetTemplate.Screen = null;
            this.fld_btnGetTemplate.Size = new System.Drawing.Size(124, 25);
            this.fld_btnGetTemplate.TabIndex = 0;
            this.fld_btnGetTemplate.Tag = "DC";
            this.fld_btnGetTemplate.Text = "Mẫu import";
            this.fld_btnGetTemplate.Click += new System.EventHandler(this.fld_btnGetTemplate_Click);
            // 
            // fld_btnImportTemplate
            // 
            this.fld_btnImportTemplate.BOSComment = null;
            this.fld_btnImportTemplate.BOSDataMember = null;
            this.fld_btnImportTemplate.BOSDataSource = null;
            this.fld_btnImportTemplate.BOSDescription = null;
            this.fld_btnImportTemplate.BOSError = null;
            this.fld_btnImportTemplate.BOSFieldGroup = null;
            this.fld_btnImportTemplate.BOSFieldRelation = null;
            this.fld_btnImportTemplate.BOSPrivilege = null;
            this.fld_btnImportTemplate.BOSPropertyName = null;
            this.fld_btnImportTemplate.Location = new System.Drawing.Point(146, 5);
            this.fld_btnImportTemplate.Name = "fld_btnImportTemplate";
            this.fld_btnImportTemplate.Screen = null;
            this.fld_btnImportTemplate.Size = new System.Drawing.Size(124, 25);
            this.fld_btnImportTemplate.TabIndex = 0;
            this.fld_btnImportTemplate.Tag = "DC";
            this.fld_btnImportTemplate.Text = "Import từ excel";
            this.fld_btnImportTemplate.Click += new System.EventHandler(this.fld_btnImportTemplate_Click);
            // 
            // fld_dgcMMNormTemplateItems
            // 
            this.fld_dgcMMNormTemplateItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMNormTemplateItems.BOSComment = null;
            this.fld_dgcMMNormTemplateItems.BOSDataMember = null;
            this.fld_dgcMMNormTemplateItems.BOSDataSource = "MMNormTemplateItems";
            this.fld_dgcMMNormTemplateItems.BOSDescription = null;
            this.fld_dgcMMNormTemplateItems.BOSError = null;
            this.fld_dgcMMNormTemplateItems.BOSFieldGroup = null;
            this.fld_dgcMMNormTemplateItems.BOSFieldRelation = null;
            this.fld_dgcMMNormTemplateItems.BOSGridType = null;
            this.fld_dgcMMNormTemplateItems.BOSPrivilege = null;
            this.fld_dgcMMNormTemplateItems.BOSPropertyName = null;
            this.fld_dgcMMNormTemplateItems.Location = new System.Drawing.Point(0, 36);
            this.fld_dgcMMNormTemplateItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMNormTemplateItems.Name = "fld_dgcMMNormTemplateItems";
            this.fld_dgcMMNormTemplateItems.PrintReport = false;
            this.fld_dgcMMNormTemplateItems.Screen = null;
            this.fld_dgcMMNormTemplateItems.Size = new System.Drawing.Size(833, 386);
            this.fld_dgcMMNormTemplateItems.TabIndex = 1;
            this.fld_dgcMMNormTemplateItems.Tag = "DC";
            // 
            // DMNTL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(843, 562);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMNTL100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMNormTemplateDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMNormTemplateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplateItems)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSTextBox fld_txtMMNormTemplateNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private NormTemplateItemsGridControl fld_dgcMMNormTemplateItems;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSMemoEdit fld_medMMNormTemplateDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnImportTemplate;
        private BOSComponent.BOSButton fld_btnGetTemplate;
	}
}
