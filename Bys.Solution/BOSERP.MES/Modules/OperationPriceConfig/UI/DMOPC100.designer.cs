using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OperationPriceConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMOPC100
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
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMOperationPriceConfigExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMOperationPriceConfigDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMOperationPriceConfigToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMOperationPriceConfigNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICMeasureUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMOperationPriceConfigItems = new BOSERP.Modules.OperationPriceConfig.OperationPriceConfigItemsGridControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationPriceConfigDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationPriceConfigToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationPriceConfigToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICMeasureUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationPriceConfigItems)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(926, 562);
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
            this.bosPanel1.Size = new System.Drawing.Size(926, 562);
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMOperationPriceConfigExchangeRate);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.fld_medMMOperationPriceConfigDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.fld_dteMMOperationPriceConfigToDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMOperationPriceConfigNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(920, 114);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Tag = "DC";
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(771, 33);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 7;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(705, 36);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "MMOperationPriceConfigs";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(545, 59);
            this.fld_lkeFK_GECurrencyID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 11;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // fld_txtMMOperationPriceConfigExchangeRate
            // 
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSComment = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSDataMember = "MMOperationPriceConfigExchangeRate";
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSDescription = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSError = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSFieldGroup = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSFieldRelation = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSPrivilege = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.BOSPropertyName = "Text";
            this.fld_txtMMOperationPriceConfigExchangeRate.Location = new System.Drawing.Point(545, 85);
            this.fld_txtMMOperationPriceConfigExchangeRate.MenuManager = this.screenToolbar;
            this.fld_txtMMOperationPriceConfigExchangeRate.Name = "fld_txtMMOperationPriceConfigExchangeRate";
            this.fld_txtMMOperationPriceConfigExchangeRate.Screen = null;
            this.fld_txtMMOperationPriceConfigExchangeRate.Size = new System.Drawing.Size(132, 20);
            this.fld_txtMMOperationPriceConfigExchangeRate.TabIndex = 15;
            this.fld_txtMMOperationPriceConfigExchangeRate.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(483, 88);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(29, 13);
            this.bosLabel10.TabIndex = 14;
            this.bosLabel10.Text = "Tỷ giá";
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
            this.bosLabel3.Location = new System.Drawing.Point(483, 62);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Text = "Loại tiền tệ";
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
            this.bosLabel11.Location = new System.Drawing.Point(255, 36);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(52, 13);
            this.bosLabel11.TabIndex = 2;
            this.bosLabel11.Text = "Hiệu lực từ";
            // 
            // fld_medMMOperationPriceConfigDesc
            // 
            this.fld_medMMOperationPriceConfigDesc.BOSComment = null;
            this.fld_medMMOperationPriceConfigDesc.BOSDataMember = "MMOperationPriceConfigDesc";
            this.fld_medMMOperationPriceConfigDesc.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_medMMOperationPriceConfigDesc.BOSDescription = null;
            this.fld_medMMOperationPriceConfigDesc.BOSError = null;
            this.fld_medMMOperationPriceConfigDesc.BOSFieldGroup = null;
            this.fld_medMMOperationPriceConfigDesc.BOSFieldRelation = null;
            this.fld_medMMOperationPriceConfigDesc.BOSPrivilege = null;
            this.fld_medMMOperationPriceConfigDesc.BOSPropertyName = "EditValue";
            this.fld_medMMOperationPriceConfigDesc.Location = new System.Drawing.Point(99, 59);
            this.fld_medMMOperationPriceConfigDesc.MenuManager = this.screenToolbar;
            this.fld_medMMOperationPriceConfigDesc.Name = "fld_medMMOperationPriceConfigDesc";
            this.fld_medMMOperationPriceConfigDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMOperationPriceConfigDesc, true);
            this.fld_medMMOperationPriceConfigDesc.Size = new System.Drawing.Size(358, 46);
            this.fld_medMMOperationPriceConfigDesc.TabIndex = 9;
            this.fld_medMMOperationPriceConfigDesc.Tag = "DC";
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
            this.bosLabel5.TabIndex = 8;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel9.Location = new System.Drawing.Point(705, 62);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMOperationPriceConfigStatus";
            this.bosLookupEdit3.BOSDataSource = "MMOperationPriceConfigs";
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
            this.bosLookupEdit3.Location = new System.Drawing.Point(771, 59);
            this.bosLookupEdit3.MenuManager = this.screenToolbar;
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(132, 20);
            this.bosLookupEdit3.TabIndex = 13;
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
            this.bosLabel2.Location = new System.Drawing.Point(483, 36);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 4;
            this.bosLabel2.Text = "Đến";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "MMOperationPriceConfigFromDate";
            this.bosDateEdit2.BOSDataSource = "MMOperationPriceConfigs";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(325, 33);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(132, 20);
            this.bosDateEdit2.TabIndex = 3;
            this.bosDateEdit2.Tag = "DC";
            // 
            // fld_dteMMOperationPriceConfigToDate
            // 
            this.fld_dteMMOperationPriceConfigToDate.BOSComment = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSDataMember = "MMOperationPriceConfigToDate";
            this.fld_dteMMOperationPriceConfigToDate.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_dteMMOperationPriceConfigToDate.BOSDescription = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSError = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSFieldGroup = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSFieldRelation = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSPrivilege = null;
            this.fld_dteMMOperationPriceConfigToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMOperationPriceConfigToDate.EditValue = null;
            this.fld_dteMMOperationPriceConfigToDate.Location = new System.Drawing.Point(545, 33);
            this.fld_dteMMOperationPriceConfigToDate.MenuManager = this.screenToolbar;
            this.fld_dteMMOperationPriceConfigToDate.Name = "fld_dteMMOperationPriceConfigToDate";
            this.fld_dteMMOperationPriceConfigToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMOperationPriceConfigToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMOperationPriceConfigToDate.Screen = null;
            this.fld_dteMMOperationPriceConfigToDate.Size = new System.Drawing.Size(132, 20);
            this.fld_dteMMOperationPriceConfigToDate.TabIndex = 5;
            this.fld_dteMMOperationPriceConfigToDate.Tag = "DC";
            // 
            // fld_txtMMOperationPriceConfigNo
            // 
            this.fld_txtMMOperationPriceConfigNo.BOSComment = null;
            this.fld_txtMMOperationPriceConfigNo.BOSDataMember = "MMOperationPriceConfigNo";
            this.fld_txtMMOperationPriceConfigNo.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_txtMMOperationPriceConfigNo.BOSDescription = null;
            this.fld_txtMMOperationPriceConfigNo.BOSError = null;
            this.fld_txtMMOperationPriceConfigNo.BOSFieldGroup = null;
            this.fld_txtMMOperationPriceConfigNo.BOSFieldRelation = null;
            this.fld_txtMMOperationPriceConfigNo.BOSPrivilege = null;
            this.fld_txtMMOperationPriceConfigNo.BOSPropertyName = "Text";
            this.fld_txtMMOperationPriceConfigNo.Location = new System.Drawing.Point(99, 33);
            this.fld_txtMMOperationPriceConfigNo.MenuManager = this.screenToolbar;
            this.fld_txtMMOperationPriceConfigNo.Name = "fld_txtMMOperationPriceConfigNo";
            this.fld_txtMMOperationPriceConfigNo.Properties.ReadOnly = true;
            this.fld_txtMMOperationPriceConfigNo.Screen = null;
            this.fld_txtMMOperationPriceConfigNo.Size = new System.Drawing.Size(132, 20);
            this.fld_txtMMOperationPriceConfigNo.TabIndex = 1;
            this.fld_txtMMOperationPriceConfigNo.Tag = "DC";
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
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 123);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(920, 436);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin chi tiết";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.bosLabel7);
            this.xtraScrollableControl2.Controls.Add(this.bosLabel6);
            this.xtraScrollableControl2.Controls.Add(this.fld_lkeICMeasureUnitID);
            this.xtraScrollableControl2.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.xtraScrollableControl2.Controls.Add(this.fld_btnAdd);
            this.xtraScrollableControl2.Controls.Add(this.fld_dgcMMOperationPriceConfigItems);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(2, 22);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(916, 412);
            this.xtraScrollableControl2.TabIndex = 0;
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
            this.bosLabel7.Location = new System.Drawing.Point(396, 11);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(20, 13);
            this.bosLabel7.TabIndex = 3;
            this.bosLabel7.Text = "ĐVT";
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
            this.bosLabel6.Location = new System.Drawing.Point(159, 11);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(52, 13);
            this.bosLabel6.TabIndex = 1;
            this.bosLabel6.Text = "Công đoạn";
            // 
            // fld_lkeICMeasureUnitID
            // 
            this.fld_lkeICMeasureUnitID.BOSAllowAddNew = false;
            this.fld_lkeICMeasureUnitID.BOSAllowDummy = true;
            this.fld_lkeICMeasureUnitID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSDataMember = "ICMeasureUnitID";
            this.fld_lkeICMeasureUnitID.BOSDataSource = "ICMeasureUnits";
            this.fld_lkeICMeasureUnitID.BOSDescription = null;
            this.fld_lkeICMeasureUnitID.BOSError = null;
            this.fld_lkeICMeasureUnitID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.CurrentDisplayText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.Location = new System.Drawing.Point(434, 8);
            this.fld_lkeICMeasureUnitID.Name = "fld_lkeICMeasureUnitID";
            this.fld_lkeICMeasureUnitID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICMeasureUnitID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICMeasureUnitID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICMeasureUnitID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICMeasureUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICMeasureUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "ĐVT")});
            this.fld_lkeICMeasureUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeICMeasureUnitID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICMeasureUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICMeasureUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeICMeasureUnitID.Screen = null;
            this.fld_lkeICMeasureUnitID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeICMeasureUnitID.TabIndex = 4;
            this.fld_lkeICMeasureUnitID.Tag = "DC";
            this.fld_lkeICMeasureUnitID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICMeasureUnitID_CloseUp);
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(227, 8);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 2;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMOperationID_CloseUp);
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.BOSComment = null;
            this.fld_btnAdd.BOSDataMember = null;
            this.fld_btnAdd.BOSDataSource = null;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = null;
            this.fld_btnAdd.BOSFieldRelation = null;
            this.fld_btnAdd.BOSPrivilege = null;
            this.fld_btnAdd.BOSPropertyName = null;
            this.fld_btnAdd.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(124, 25);
            this.fld_btnAdd.TabIndex = 0;
            this.fld_btnAdd.Tag = "DC";
            this.fld_btnAdd.Text = "Thêm chi tiết";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_dgcMMOperationPriceConfigItems
            // 
            this.fld_dgcMMOperationPriceConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMOperationPriceConfigItems.BOSComment = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSDataMember = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSDataSource = "MMOperationPriceConfigItems";
            this.fld_dgcMMOperationPriceConfigItems.BOSDescription = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSError = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSFieldGroup = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSFieldRelation = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSGridType = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSPrivilege = null;
            this.fld_dgcMMOperationPriceConfigItems.BOSPropertyName = null;
            this.fld_dgcMMOperationPriceConfigItems.Location = new System.Drawing.Point(0, 43);
            this.fld_dgcMMOperationPriceConfigItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMOperationPriceConfigItems.Name = "fld_dgcMMOperationPriceConfigItems";
            this.fld_dgcMMOperationPriceConfigItems.PrintReport = false;
            this.fld_dgcMMOperationPriceConfigItems.Screen = null;
            this.fld_dgcMMOperationPriceConfigItems.Size = new System.Drawing.Size(916, 369);
            this.fld_dgcMMOperationPriceConfigItems.TabIndex = 1;
            this.fld_dgcMMOperationPriceConfigItems.Tag = "DC";
            // 
            // DMOPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(926, 562);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMOPC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationPriceConfigDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationPriceConfigToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationPriceConfigToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICMeasureUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationPriceConfigItems)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteMMOperationPriceConfigToDate;
        private BOSComponent.BOSTextBox fld_txtMMOperationPriceConfigNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private OperationPriceConfigItemsGridControl fld_dgcMMOperationPriceConfigItems;
        private BOSComponent.BOSMemoEdit fld_medMMOperationPriceConfigDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtMMOperationPriceConfigExchangeRate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeICMeasureUnitID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
	}
}
