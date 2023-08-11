using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ActualCostBudget.UI
{
	/// <summary>
	/// Summary description for DMACB100
	/// </summary>
	partial class DMACB100
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
            this.fld_dteACActualCostBudgetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeACActualCostBudgetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACActualCostBudgetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACActualCostBudgetDetails = new BOSERP.Modules.ActualCostBudget.ACActualCostBudgetDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACActualCostBudgetExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACActualCostBudgetNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACActualCostBudgetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACActualCostBudgetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACActualCostBudgetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACActualCostBudgetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACActualCostBudgetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_dteACActualCostBudgetDate);
            this.bosPanel1.Controls.Add(this.fld_lkeACActualCostBudgetStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medACActualCostBudgetDesc);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtACActualCostBudgetExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtACActualCostBudgetNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_dteACActualCostBudgetDate
            // 
            this.fld_dteACActualCostBudgetDate.BOSComment = null;
            this.fld_dteACActualCostBudgetDate.BOSDataMember = "ACActualCostBudgetDate";
            this.fld_dteACActualCostBudgetDate.BOSDataSource = "ACActualCostBudgets";
            this.fld_dteACActualCostBudgetDate.BOSDescription = null;
            this.fld_dteACActualCostBudgetDate.BOSError = null;
            this.fld_dteACActualCostBudgetDate.BOSFieldGroup = null;
            this.fld_dteACActualCostBudgetDate.BOSFieldRelation = null;
            this.fld_dteACActualCostBudgetDate.BOSPrivilege = null;
            this.fld_dteACActualCostBudgetDate.BOSPropertyName = "EditValue";
            this.fld_dteACActualCostBudgetDate.EditValue = null;
            this.fld_dteACActualCostBudgetDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteACActualCostBudgetDate.Name = "fld_dteACActualCostBudgetDate";
            this.fld_dteACActualCostBudgetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACActualCostBudgetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACActualCostBudgetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACActualCostBudgetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACActualCostBudgetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACActualCostBudgetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACActualCostBudgetDate.Screen = null;
            this.fld_dteACActualCostBudgetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACActualCostBudgetDate.TabIndex = 81;
            this.fld_dteACActualCostBudgetDate.Tag = "DC";
            // 
            // fld_lkeACActualCostBudgetStatus
            // 
            this.fld_lkeACActualCostBudgetStatus.BOSAllowAddNew = false;
            this.fld_lkeACActualCostBudgetStatus.BOSAllowDummy = false;
            this.fld_lkeACActualCostBudgetStatus.BOSComment = null;
            this.fld_lkeACActualCostBudgetStatus.BOSDataMember = "ACActualCostBudgetStatus";
            this.fld_lkeACActualCostBudgetStatus.BOSDataSource = "ACActualCostBudgets";
            this.fld_lkeACActualCostBudgetStatus.BOSDescription = null;
            this.fld_lkeACActualCostBudgetStatus.BOSError = null;
            this.fld_lkeACActualCostBudgetStatus.BOSFieldGroup = null;
            this.fld_lkeACActualCostBudgetStatus.BOSFieldParent = null;
            this.fld_lkeACActualCostBudgetStatus.BOSFieldRelation = null;
            this.fld_lkeACActualCostBudgetStatus.BOSPrivilege = null;
            this.fld_lkeACActualCostBudgetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACActualCostBudgetStatus.BOSSelectType = null;
            this.fld_lkeACActualCostBudgetStatus.BOSSelectTypeValue = null;
            this.fld_lkeACActualCostBudgetStatus.CurrentDisplayText = null;
            this.fld_lkeACActualCostBudgetStatus.Location = new System.Drawing.Point(639, 12);
            this.fld_lkeACActualCostBudgetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACActualCostBudgetStatus.Name = "fld_lkeACActualCostBudgetStatus";
            this.fld_lkeACActualCostBudgetStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeACActualCostBudgetStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACActualCostBudgetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACActualCostBudgetStatus.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACActualCostBudgetStatus.Properties.ReadOnly = true;
            this.fld_lkeACActualCostBudgetStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACActualCostBudgetStatus.Screen = null;
            this.fld_lkeACActualCostBudgetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACActualCostBudgetStatus.TabIndex = 2;
            this.fld_lkeACActualCostBudgetStatus.Tag = "DC";
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
            // fld_medACActualCostBudgetDesc
            // 
            this.fld_medACActualCostBudgetDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACActualCostBudgetDesc.BOSDataMember = "ACActualCostBudgetDesc";
            this.fld_medACActualCostBudgetDesc.BOSDataSource = "ACActualCostBudgets";
            this.fld_medACActualCostBudgetDesc.BOSDescription = null;
            this.fld_medACActualCostBudgetDesc.BOSError = null;
            this.fld_medACActualCostBudgetDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACActualCostBudgetDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACActualCostBudgetDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACActualCostBudgetDesc.BOSPropertyName = "EditValue";
            this.fld_medACActualCostBudgetDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACActualCostBudgetDesc.Location = new System.Drawing.Point(101, 64);
            this.fld_medACActualCostBudgetDesc.Name = "fld_medACActualCostBudgetDesc";
            this.fld_medACActualCostBudgetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACActualCostBudgetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACActualCostBudgetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACActualCostBudgetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACActualCostBudgetDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medACActualCostBudgetDesc, true);
            this.fld_medACActualCostBudgetDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medACActualCostBudgetDesc.TabIndex = 5;
            this.fld_medACActualCostBudgetDesc.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcACActualCostBudgetDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 112);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 452);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Text = "Chi tiết ngân sách chi phí";
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
            // fld_dgcACActualCostBudgetDetails
            // 
            this.fld_dgcACActualCostBudgetDetails.AllowDrop = true;
            this.fld_dgcACActualCostBudgetDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACActualCostBudgetDetails.BOSComment = null;
            this.fld_dgcACActualCostBudgetDetails.BOSDataMember = null;
            this.fld_dgcACActualCostBudgetDetails.BOSDataSource = "ACActualCostBudgetDetails";
            this.fld_dgcACActualCostBudgetDetails.BOSDescription = null;
            this.fld_dgcACActualCostBudgetDetails.BOSError = null;
            this.fld_dgcACActualCostBudgetDetails.BOSFieldGroup = null;
            this.fld_dgcACActualCostBudgetDetails.BOSFieldRelation = null;
            this.fld_dgcACActualCostBudgetDetails.BOSGridType = null;
            this.fld_dgcACActualCostBudgetDetails.BOSPrivilege = null;
            this.fld_dgcACActualCostBudgetDetails.BOSPropertyName = null;
            this.fld_dgcACActualCostBudgetDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACActualCostBudgetDetails.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcACActualCostBudgetDetails.MainView = this.gridView1;
            this.fld_dgcACActualCostBudgetDetails.Name = "fld_dgcACActualCostBudgetDetails";
            this.fld_dgcACActualCostBudgetDetails.PrintReport = false;
            this.fld_dgcACActualCostBudgetDetails.Screen = null;
            this.fld_dgcACActualCostBudgetDetails.Size = new System.Drawing.Size(851, 389);
            this.fld_dgcACActualCostBudgetDetails.TabIndex = 2;
            this.fld_dgcACActualCostBudgetDetails.Tag = "DC";
            this.fld_dgcACActualCostBudgetDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACActualCostBudgetDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_txtACActualCostBudgetExchangeRate
            // 
            this.fld_txtACActualCostBudgetExchangeRate.BOSComment = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSDataMember = "ACActualCostBudgetExchangeRate";
            this.fld_txtACActualCostBudgetExchangeRate.BOSDataSource = "ACActualCostBudgets";
            this.fld_txtACActualCostBudgetExchangeRate.BOSDescription = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSError = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSFieldGroup = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSFieldRelation = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSPrivilege = null;
            this.fld_txtACActualCostBudgetExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACActualCostBudgetExchangeRate.Location = new System.Drawing.Point(370, 38);
            this.fld_txtACActualCostBudgetExchangeRate.Name = "fld_txtACActualCostBudgetExchangeRate";
            this.fld_txtACActualCostBudgetExchangeRate.Screen = null;
            this.fld_txtACActualCostBudgetExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACActualCostBudgetExchangeRate.TabIndex = 4;
            this.fld_txtACActualCostBudgetExchangeRate.Tag = "DC";
            this.fld_txtACActualCostBudgetExchangeRate.Validated += new System.EventHandler(this.fld_txtACActualCostBudgetExchangeRate_Validated);
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
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACActualCostBudgets";
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
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
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
            // fld_txtACActualCostBudgetNo
            // 
            this.fld_txtACActualCostBudgetNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo.BOSDataMember = "ACActualCostBudgetNo";
            this.fld_txtACActualCostBudgetNo.BOSDataSource = "ACActualCostBudgets";
            this.fld_txtACActualCostBudgetNo.BOSDescription = null;
            this.fld_txtACActualCostBudgetNo.BOSError = null;
            this.fld_txtACActualCostBudgetNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo.BOSPropertyName = "Text";
            this.fld_txtACActualCostBudgetNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtACActualCostBudgetNo.Name = "fld_txtACActualCostBudgetNo";
            this.fld_txtACActualCostBudgetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACActualCostBudgetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACActualCostBudgetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACActualCostBudgetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACActualCostBudgetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACActualCostBudgetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACActualCostBudgetNo.Screen = null;
            this.fld_txtACActualCostBudgetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACActualCostBudgetNo.TabIndex = 0;
            this.fld_txtACActualCostBudgetNo.Tag = "DC";
            // 
            // DMACB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACB100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACActualCostBudgetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACActualCostBudgetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACActualCostBudgetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACActualCostBudgetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACActualCostBudgetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACActualCostBudgetNo;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtACActualCostBudgetExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medACActualCostBudgetDesc;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private ACActualCostBudgetDetailsGridControl fld_dgcACActualCostBudgetDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeACActualCostBudgetStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSDateEdit fld_dteACActualCostBudgetDate;
	}
}
