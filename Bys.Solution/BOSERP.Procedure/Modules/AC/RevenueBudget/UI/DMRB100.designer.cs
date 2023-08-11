using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RevenueBudget.UI
{
	/// <summary>
	/// Summary description for DMRB100
	/// </summary>
	partial class DMRB100
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
            this.fld_dteACRevenueBudgetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeACRevenueBudgetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACRevenueBudgetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACRevenueBudgetDetails = new BOSERP.Modules.RevenueBudget.ACRevenueBudgetDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACRevenueBudgetExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRevenueBudgetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACRevenueBudgetType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRevenueBudgetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRevenueBudgetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRevenueBudgetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRevenueBudgetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRevenueBudgetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRevenueBudgetType.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeACRevenueBudgetType);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteACRevenueBudgetDate);
            this.bosPanel1.Controls.Add(this.fld_lkeACRevenueBudgetStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medACRevenueBudgetDesc);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtACRevenueBudgetExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtACRevenueBudgetNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_dteACRevenueBudgetDate
            // 
            this.fld_dteACRevenueBudgetDate.BOSComment = null;
            this.fld_dteACRevenueBudgetDate.BOSDataMember = "ACRevenueBudgetDate";
            this.fld_dteACRevenueBudgetDate.BOSDataSource = "ACRevenueBudgets";
            this.fld_dteACRevenueBudgetDate.BOSDescription = null;
            this.fld_dteACRevenueBudgetDate.BOSError = null;
            this.fld_dteACRevenueBudgetDate.BOSFieldGroup = null;
            this.fld_dteACRevenueBudgetDate.BOSFieldRelation = null;
            this.fld_dteACRevenueBudgetDate.BOSPrivilege = null;
            this.fld_dteACRevenueBudgetDate.BOSPropertyName = "EditValue";
            this.fld_dteACRevenueBudgetDate.EditValue = null;
            this.fld_dteACRevenueBudgetDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteACRevenueBudgetDate.Name = "fld_dteACRevenueBudgetDate";
            this.fld_dteACRevenueBudgetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACRevenueBudgetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACRevenueBudgetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACRevenueBudgetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACRevenueBudgetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACRevenueBudgetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACRevenueBudgetDate.Screen = null;
            this.fld_dteACRevenueBudgetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACRevenueBudgetDate.TabIndex = 81;
            this.fld_dteACRevenueBudgetDate.Tag = "DC";
            // 
            // fld_lkeACRevenueBudgetStatus
            // 
            this.fld_lkeACRevenueBudgetStatus.BOSAllowAddNew = false;
            this.fld_lkeACRevenueBudgetStatus.BOSAllowDummy = false;
            this.fld_lkeACRevenueBudgetStatus.BOSComment = null;
            this.fld_lkeACRevenueBudgetStatus.BOSDataMember = "ACRevenueBudgetStatus";
            this.fld_lkeACRevenueBudgetStatus.BOSDataSource = "ACRevenueBudgets";
            this.fld_lkeACRevenueBudgetStatus.BOSDescription = null;
            this.fld_lkeACRevenueBudgetStatus.BOSError = null;
            this.fld_lkeACRevenueBudgetStatus.BOSFieldGroup = null;
            this.fld_lkeACRevenueBudgetStatus.BOSFieldParent = null;
            this.fld_lkeACRevenueBudgetStatus.BOSFieldRelation = null;
            this.fld_lkeACRevenueBudgetStatus.BOSPrivilege = null;
            this.fld_lkeACRevenueBudgetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACRevenueBudgetStatus.BOSSelectType = null;
            this.fld_lkeACRevenueBudgetStatus.BOSSelectTypeValue = null;
            this.fld_lkeACRevenueBudgetStatus.CurrentDisplayText = null;
            this.fld_lkeACRevenueBudgetStatus.Location = new System.Drawing.Point(639, 12);
            this.fld_lkeACRevenueBudgetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACRevenueBudgetStatus.Name = "fld_lkeACRevenueBudgetStatus";
            this.fld_lkeACRevenueBudgetStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeACRevenueBudgetStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACRevenueBudgetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACRevenueBudgetStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACRevenueBudgetStatus.Properties.ReadOnly = true;
            this.fld_lkeACRevenueBudgetStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACRevenueBudgetStatus.Screen = null;
            this.fld_lkeACRevenueBudgetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACRevenueBudgetStatus.TabIndex = 2;
            this.fld_lkeACRevenueBudgetStatus.Tag = "DC";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(558, 15);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 80;
            this.fld_lblLabel25.Text = "Tình trạng";
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
            this.bosLabel3.Location = new System.Drawing.Point(17, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_medACRevenueBudgetDesc
            // 
            this.fld_medACRevenueBudgetDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACRevenueBudgetDesc.BOSDataMember = "ACRevenueBudgetDesc";
            this.fld_medACRevenueBudgetDesc.BOSDataSource = "ACRevenueBudgets";
            this.fld_medACRevenueBudgetDesc.BOSDescription = null;
            this.fld_medACRevenueBudgetDesc.BOSError = null;
            this.fld_medACRevenueBudgetDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACRevenueBudgetDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACRevenueBudgetDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACRevenueBudgetDesc.BOSPropertyName = "EditValue";
            this.fld_medACRevenueBudgetDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACRevenueBudgetDesc.Location = new System.Drawing.Point(101, 64);
            this.fld_medACRevenueBudgetDesc.Name = "fld_medACRevenueBudgetDesc";
            this.fld_medACRevenueBudgetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACRevenueBudgetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACRevenueBudgetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACRevenueBudgetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACRevenueBudgetDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medACRevenueBudgetDesc, true);
            this.fld_medACRevenueBudgetDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medACRevenueBudgetDesc.TabIndex = 5;
            this.fld_medACRevenueBudgetDesc.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl1.Controls.Add(this.bosButton2);
            this.bosGroupControl1.Controls.Add(this.bosButton1);
            this.bosGroupControl1.Controls.Add(this.fld_dgcACRevenueBudgetDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 112);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 452);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Text = "Chi tiết ngân sách doanh thu";
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
            this.bosButton2.Location = new System.Drawing.Point(104, 25);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(93, 27);
            this.bosButton2.TabIndex = 1;
            this.bosButton2.Text = "Import từ excel";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(5, 25);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(93, 27);
            this.bosButton1.TabIndex = 0;
            this.bosButton1.Text = "Lấy mẫu excel";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dgcACRevenueBudgetDetails
            // 
            this.fld_dgcACRevenueBudgetDetails.AllowDrop = true;
            this.fld_dgcACRevenueBudgetDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACRevenueBudgetDetails.BOSComment = null;
            this.fld_dgcACRevenueBudgetDetails.BOSDataMember = null;
            this.fld_dgcACRevenueBudgetDetails.BOSDataSource = "ACRevenueBudgetDetails";
            this.fld_dgcACRevenueBudgetDetails.BOSDescription = null;
            this.fld_dgcACRevenueBudgetDetails.BOSError = null;
            this.fld_dgcACRevenueBudgetDetails.BOSFieldGroup = null;
            this.fld_dgcACRevenueBudgetDetails.BOSFieldRelation = null;
            this.fld_dgcACRevenueBudgetDetails.BOSGridType = null;
            this.fld_dgcACRevenueBudgetDetails.BOSPrivilege = null;
            this.fld_dgcACRevenueBudgetDetails.BOSPropertyName = null;
            this.fld_dgcACRevenueBudgetDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACRevenueBudgetDetails.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcACRevenueBudgetDetails.MainView = this.gridView1;
            this.fld_dgcACRevenueBudgetDetails.Name = "fld_dgcACRevenueBudgetDetails";
            this.fld_dgcACRevenueBudgetDetails.PrintReport = false;
            this.fld_dgcACRevenueBudgetDetails.Screen = null;
            this.fld_dgcACRevenueBudgetDetails.Size = new System.Drawing.Size(851, 389);
            this.fld_dgcACRevenueBudgetDetails.TabIndex = 2;
            this.fld_dgcACRevenueBudgetDetails.Tag = "DC";
            this.fld_dgcACRevenueBudgetDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACRevenueBudgetDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_txtACRevenueBudgetExchangeRate
            // 
            this.fld_txtACRevenueBudgetExchangeRate.BOSComment = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSDataMember = "ACRevenueBudgetExchangeRate";
            this.fld_txtACRevenueBudgetExchangeRate.BOSDataSource = "ACRevenueBudgets";
            this.fld_txtACRevenueBudgetExchangeRate.BOSDescription = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSError = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSFieldGroup = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSFieldRelation = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSPrivilege = null;
            this.fld_txtACRevenueBudgetExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACRevenueBudgetExchangeRate.Location = new System.Drawing.Point(370, 38);
            this.fld_txtACRevenueBudgetExchangeRate.Name = "fld_txtACRevenueBudgetExchangeRate";
            this.fld_txtACRevenueBudgetExchangeRate.Screen = null;
            this.fld_txtACRevenueBudgetExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACRevenueBudgetExchangeRate.TabIndex = 4;
            this.fld_txtACRevenueBudgetExchangeRate.Tag = "DC";
            this.fld_txtACRevenueBudgetExchangeRate.Validated += new System.EventHandler(this.fld_txtACRevenueBudgetExchangeRate_Validated);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(281, 41);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 75;
            this.bosLabel12.Text = "Tỷ giá";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(17, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 76;
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACRevenueBudgets";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(101, 38);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.bosLabel2.Location = new System.Drawing.Point(281, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Ngày chứng từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(17, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtACRevenueBudgetNo
            // 
            this.fld_txtACRevenueBudgetNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACRevenueBudgetNo.BOSDataMember = "ACRevenueBudgetNo";
            this.fld_txtACRevenueBudgetNo.BOSDataSource = "ACRevenueBudgets";
            this.fld_txtACRevenueBudgetNo.BOSDescription = null;
            this.fld_txtACRevenueBudgetNo.BOSError = null;
            this.fld_txtACRevenueBudgetNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACRevenueBudgetNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACRevenueBudgetNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACRevenueBudgetNo.BOSPropertyName = "Text";
            this.fld_txtACRevenueBudgetNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACRevenueBudgetNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtACRevenueBudgetNo.Name = "fld_txtACRevenueBudgetNo";
            this.fld_txtACRevenueBudgetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRevenueBudgetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRevenueBudgetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRevenueBudgetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRevenueBudgetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRevenueBudgetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRevenueBudgetNo.Screen = null;
            this.fld_txtACRevenueBudgetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACRevenueBudgetNo.TabIndex = 0;
            this.fld_txtACRevenueBudgetNo.Tag = "DC";
            // 
            // fld_lkeACRevenueBudgetType
            // 
            this.fld_lkeACRevenueBudgetType.BOSAllowAddNew = false;
            this.fld_lkeACRevenueBudgetType.BOSAllowDummy = false;
            this.fld_lkeACRevenueBudgetType.BOSComment = null;
            this.fld_lkeACRevenueBudgetType.BOSDataMember = "ACRevenueBudgetType";
            this.fld_lkeACRevenueBudgetType.BOSDataSource = "ACRevenueBudgets";
            this.fld_lkeACRevenueBudgetType.BOSDescription = null;
            this.fld_lkeACRevenueBudgetType.BOSError = null;
            this.fld_lkeACRevenueBudgetType.BOSFieldGroup = null;
            this.fld_lkeACRevenueBudgetType.BOSFieldParent = null;
            this.fld_lkeACRevenueBudgetType.BOSFieldRelation = null;
            this.fld_lkeACRevenueBudgetType.BOSPrivilege = null;
            this.fld_lkeACRevenueBudgetType.BOSPropertyName = "EditValue";
            this.fld_lkeACRevenueBudgetType.BOSSelectType = null;
            this.fld_lkeACRevenueBudgetType.BOSSelectTypeValue = null;
            this.fld_lkeACRevenueBudgetType.CurrentDisplayText = null;
            this.fld_lkeACRevenueBudgetType.Location = new System.Drawing.Point(639, 38);
            this.fld_lkeACRevenueBudgetType.Name = "fld_lkeACRevenueBudgetType";
            this.fld_lkeACRevenueBudgetType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACRevenueBudgetType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACRevenueBudgetType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACRevenueBudgetType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACRevenueBudgetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACRevenueBudgetType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACRevenueBudgetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACRevenueBudgetType.Screen = null;
            this.fld_lkeACRevenueBudgetType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACRevenueBudgetType.TabIndex = 86;
            this.fld_lkeACRevenueBudgetType.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(558, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(71, 13);
            this.bosLabel4.TabIndex = 85;
            this.bosLabel4.Text = "Loại ngân sách";
            // 
            // DMRB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRB100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRevenueBudgetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACRevenueBudgetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRevenueBudgetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACRevenueBudgetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRevenueBudgetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACRevenueBudgetType.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACRevenueBudgetNo;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtACRevenueBudgetExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medACRevenueBudgetDesc;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private ACRevenueBudgetDetailsGridControl fld_dgcACRevenueBudgetDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeACRevenueBudgetStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSDateEdit fld_dteACRevenueBudgetDate;
        private BOSComponent.BOSLookupEdit fld_lkeACRevenueBudgetType;
        private BOSComponent.BOSLabel bosLabel4;
	}
}
