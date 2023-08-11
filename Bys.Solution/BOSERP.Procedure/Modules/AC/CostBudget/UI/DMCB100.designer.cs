using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostBudget.UI
{
	/// <summary>
	/// Summary description for DMCB100
	/// </summary>
	partial class DMCB100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCB100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACCostBudgetType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACCostBudgetDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeACCostBudgetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACCostBudgetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACCostBudgetDetails = new BOSERP.Modules.CostBudget.ACCostBudgetDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACCostBudgetExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostBudgetNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostBudgetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACCostBudgetDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACCostBudgetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostBudgetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACCostBudgetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostBudgetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosDateEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeACCostBudgetType);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteACCostBudgetDate);
            this.bosPanel1.Controls.Add(this.fld_lkeACCostBudgetStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medACCostBudgetDesc);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtACCostBudgetExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtACCostBudgetNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1100, 595);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "ACCostBudgetToDate";
            this.bosDateEdit2.BOSDataSource = "ACCostBudgets";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(370, 38);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 88;
            this.bosDateEdit2.Tag = "DC";
            this.bosDateEdit2.Validated += new System.EventHandler(this.bosDateEdit2_Validated);
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
            this.bosLabel6.Location = new System.Drawing.Point(288, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 87;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ACCostBudgetFromDate";
            this.bosDateEdit1.BOSDataSource = "ACCostBudgets";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(370, 12);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 86;
            this.bosDateEdit1.Tag = "DC";
            this.bosDateEdit1.Validated += new System.EventHandler(this.bosDateEdit1_Validated);
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
            this.bosLabel5.Location = new System.Drawing.Point(288, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 85;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_lkeACCostBudgetType
            // 
            this.fld_lkeACCostBudgetType.BOSAllowAddNew = false;
            this.fld_lkeACCostBudgetType.BOSAllowDummy = false;
            this.fld_lkeACCostBudgetType.BOSComment = null;
            this.fld_lkeACCostBudgetType.BOSDataMember = "ACCostBudgetType";
            this.fld_lkeACCostBudgetType.BOSDataSource = "ACCostBudgets";
            this.fld_lkeACCostBudgetType.BOSDescription = null;
            this.fld_lkeACCostBudgetType.BOSError = null;
            this.fld_lkeACCostBudgetType.BOSFieldGroup = null;
            this.fld_lkeACCostBudgetType.BOSFieldParent = null;
            this.fld_lkeACCostBudgetType.BOSFieldRelation = null;
            this.fld_lkeACCostBudgetType.BOSPrivilege = null;
            this.fld_lkeACCostBudgetType.BOSPropertyName = "EditValue";
            this.fld_lkeACCostBudgetType.BOSSelectType = null;
            this.fld_lkeACCostBudgetType.BOSSelectTypeValue = null;
            this.fld_lkeACCostBudgetType.CurrentDisplayText = null;
            this.fld_lkeACCostBudgetType.Location = new System.Drawing.Point(101, 38);
            this.fld_lkeACCostBudgetType.Name = "fld_lkeACCostBudgetType";
            this.fld_lkeACCostBudgetType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACCostBudgetType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACCostBudgetType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACCostBudgetType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACCostBudgetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCostBudgetType.Properties.ColumnName = null;
            this.fld_lkeACCostBudgetType.Properties.NullText = "";
            this.fld_lkeACCostBudgetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACCostBudgetType.Screen = null;
            this.fld_lkeACCostBudgetType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACCostBudgetType.TabIndex = 84;
            this.fld_lkeACCostBudgetType.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(17, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(71, 13);
            this.bosLabel4.TabIndex = 83;
            this.bosLabel4.Text = "Loại ngân sách";
            // 
            // fld_dteACCostBudgetDate
            // 
            this.fld_dteACCostBudgetDate.BOSComment = null;
            this.fld_dteACCostBudgetDate.BOSDataMember = "ACCostBudgetDate";
            this.fld_dteACCostBudgetDate.BOSDataSource = "ACCostBudgets";
            this.fld_dteACCostBudgetDate.BOSDescription = null;
            this.fld_dteACCostBudgetDate.BOSError = null;
            this.fld_dteACCostBudgetDate.BOSFieldGroup = null;
            this.fld_dteACCostBudgetDate.BOSFieldRelation = null;
            this.fld_dteACCostBudgetDate.BOSPrivilege = null;
            this.fld_dteACCostBudgetDate.BOSPropertyName = "EditValue";
            this.fld_dteACCostBudgetDate.EditValue = null;
            this.fld_dteACCostBudgetDate.Location = new System.Drawing.Point(636, 38);
            this.fld_dteACCostBudgetDate.Name = "fld_dteACCostBudgetDate";
            this.fld_dteACCostBudgetDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACCostBudgetDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACCostBudgetDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACCostBudgetDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACCostBudgetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACCostBudgetDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACCostBudgetDate.Screen = null;
            this.fld_dteACCostBudgetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACCostBudgetDate.TabIndex = 81;
            this.fld_dteACCostBudgetDate.Tag = "DC";
            this.fld_dteACCostBudgetDate.Visible = false;
            // 
            // fld_lkeACCostBudgetStatus
            // 
            this.fld_lkeACCostBudgetStatus.BOSAllowAddNew = false;
            this.fld_lkeACCostBudgetStatus.BOSAllowDummy = false;
            this.fld_lkeACCostBudgetStatus.BOSComment = null;
            this.fld_lkeACCostBudgetStatus.BOSDataMember = "ACCostBudgetStatus";
            this.fld_lkeACCostBudgetStatus.BOSDataSource = "ACCostBudgets";
            this.fld_lkeACCostBudgetStatus.BOSDescription = null;
            this.fld_lkeACCostBudgetStatus.BOSError = null;
            this.fld_lkeACCostBudgetStatus.BOSFieldGroup = null;
            this.fld_lkeACCostBudgetStatus.BOSFieldParent = null;
            this.fld_lkeACCostBudgetStatus.BOSFieldRelation = null;
            this.fld_lkeACCostBudgetStatus.BOSPrivilege = null;
            this.fld_lkeACCostBudgetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACCostBudgetStatus.BOSSelectType = null;
            this.fld_lkeACCostBudgetStatus.BOSSelectTypeValue = null;
            this.fld_lkeACCostBudgetStatus.CurrentDisplayText = null;
            this.fld_lkeACCostBudgetStatus.Location = new System.Drawing.Point(639, 12);
            this.fld_lkeACCostBudgetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACCostBudgetStatus.Name = "fld_lkeACCostBudgetStatus";
            this.fld_lkeACCostBudgetStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeACCostBudgetStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACCostBudgetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCostBudgetStatus.Properties.ColumnName = null;
            this.fld_lkeACCostBudgetStatus.Properties.NullText = "";
            this.fld_lkeACCostBudgetStatus.Properties.ReadOnly = true;
            this.fld_lkeACCostBudgetStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACCostBudgetStatus.Screen = null;
            this.fld_lkeACCostBudgetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACCostBudgetStatus.TabIndex = 2;
            this.fld_lkeACCostBudgetStatus.Tag = "DC";
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
            // fld_medACCostBudgetDesc
            // 
            this.fld_medACCostBudgetDesc.BOSComment = "";
            this.fld_medACCostBudgetDesc.BOSDataMember = "ACCostBudgetDesc";
            this.fld_medACCostBudgetDesc.BOSDataSource = "ACCostBudgets";
            this.fld_medACCostBudgetDesc.BOSDescription = null;
            this.fld_medACCostBudgetDesc.BOSError = null;
            this.fld_medACCostBudgetDesc.BOSFieldGroup = "";
            this.fld_medACCostBudgetDesc.BOSFieldRelation = "";
            this.fld_medACCostBudgetDesc.BOSPrivilege = "";
            this.fld_medACCostBudgetDesc.BOSPropertyName = "EditValue";
            this.fld_medACCostBudgetDesc.EditValue = "";
            this.fld_medACCostBudgetDesc.Location = new System.Drawing.Point(101, 64);
            this.fld_medACCostBudgetDesc.Name = "fld_medACCostBudgetDesc";
            this.fld_medACCostBudgetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACCostBudgetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACCostBudgetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACCostBudgetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACCostBudgetDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medACCostBudgetDesc, true);
            this.fld_medACCostBudgetDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medACCostBudgetDesc.TabIndex = 5;
            this.fld_medACCostBudgetDesc.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcACCostBudgetDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 115);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1094, 477);
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
            this.bosButton2.Visible = false;
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
            this.bosButton1.Visible = false;
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dgcACCostBudgetDetails
            // 
            this.fld_dgcACCostBudgetDetails.AllowDrop = true;
            this.fld_dgcACCostBudgetDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACCostBudgetDetails.BOSComment = null;
            this.fld_dgcACCostBudgetDetails.BOSDataMember = null;
            this.fld_dgcACCostBudgetDetails.BOSDataSource = "ACCostBudgetDetails";
            this.fld_dgcACCostBudgetDetails.BOSDescription = null;
            this.fld_dgcACCostBudgetDetails.BOSError = null;
            this.fld_dgcACCostBudgetDetails.BOSFieldGroup = null;
            this.fld_dgcACCostBudgetDetails.BOSFieldRelation = null;
            this.fld_dgcACCostBudgetDetails.BOSGridType = null;
            this.fld_dgcACCostBudgetDetails.BOSPrivilege = null;
            this.fld_dgcACCostBudgetDetails.BOSPropertyName = null;
            this.fld_dgcACCostBudgetDetails.CommodityType = "";
            this.fld_dgcACCostBudgetDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACCostBudgetDetails.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcACCostBudgetDetails.MainView = this.gridView1;
            this.fld_dgcACCostBudgetDetails.Name = "fld_dgcACCostBudgetDetails";
            this.fld_dgcACCostBudgetDetails.PrintReport = false;
            this.fld_dgcACCostBudgetDetails.Screen = null;
            this.fld_dgcACCostBudgetDetails.Size = new System.Drawing.Size(1089, 414);
            this.fld_dgcACCostBudgetDetails.TabIndex = 2;
            this.fld_dgcACCostBudgetDetails.Tag = "DC";
            this.fld_dgcACCostBudgetDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACCostBudgetDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_txtACCostBudgetExchangeRate
            // 
            this.fld_txtACCostBudgetExchangeRate.BOSComment = null;
            this.fld_txtACCostBudgetExchangeRate.BOSDataMember = "ACCostBudgetExchangeRate";
            this.fld_txtACCostBudgetExchangeRate.BOSDataSource = "ACCostBudgets";
            this.fld_txtACCostBudgetExchangeRate.BOSDescription = null;
            this.fld_txtACCostBudgetExchangeRate.BOSError = null;
            this.fld_txtACCostBudgetExchangeRate.BOSFieldGroup = null;
            this.fld_txtACCostBudgetExchangeRate.BOSFieldRelation = null;
            this.fld_txtACCostBudgetExchangeRate.BOSPrivilege = null;
            this.fld_txtACCostBudgetExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACCostBudgetExchangeRate.Location = new System.Drawing.Point(636, 64);
            this.fld_txtACCostBudgetExchangeRate.Name = "fld_txtACCostBudgetExchangeRate";
            this.fld_txtACCostBudgetExchangeRate.Screen = null;
            this.fld_txtACCostBudgetExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostBudgetExchangeRate.TabIndex = 4;
            this.fld_txtACCostBudgetExchangeRate.Tag = "DC";
            this.fld_txtACCostBudgetExchangeRate.Visible = false;
            this.fld_txtACCostBudgetExchangeRate.Validated += new System.EventHandler(this.fld_txtACCostBudgetExchangeRate_Validated);
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
            this.bosLabel12.Location = new System.Drawing.Point(558, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 75;
            this.bosLabel12.Text = "Tỷ giá";
            this.bosLabel12.Visible = false;
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
            this.bosLabel11.Location = new System.Drawing.Point(558, 93);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 76;
            this.bosLabel11.Text = "Loại tiền tệ";
            this.bosLabel11.Visible = false;
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACCostBudgets";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(636, 89);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.Visible = false;
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
            this.bosLabel2.Location = new System.Drawing.Point(558, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Ngày chứng từ";
            this.bosLabel2.Visible = false;
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
            // fld_txtACCostBudgetNo
            // 
            this.fld_txtACCostBudgetNo.BOSComment = "";
            this.fld_txtACCostBudgetNo.BOSDataMember = "ACCostBudgetNo";
            this.fld_txtACCostBudgetNo.BOSDataSource = "ACCostBudgets";
            this.fld_txtACCostBudgetNo.BOSDescription = null;
            this.fld_txtACCostBudgetNo.BOSError = null;
            this.fld_txtACCostBudgetNo.BOSFieldGroup = "";
            this.fld_txtACCostBudgetNo.BOSFieldRelation = "";
            this.fld_txtACCostBudgetNo.BOSPrivilege = "";
            this.fld_txtACCostBudgetNo.BOSPropertyName = "Text";
            this.fld_txtACCostBudgetNo.EditValue = "";
            this.fld_txtACCostBudgetNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtACCostBudgetNo.Name = "fld_txtACCostBudgetNo";
            this.fld_txtACCostBudgetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostBudgetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostBudgetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostBudgetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostBudgetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostBudgetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostBudgetNo.Screen = null;
            this.fld_txtACCostBudgetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostBudgetNo.TabIndex = 0;
            this.fld_txtACCostBudgetNo.Tag = "DC";
            // 
            // DMCB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1100, 595);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCB100.IconOptions.Icon")));
            this.Name = "DMCB100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostBudgetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACCostBudgetDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACCostBudgetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostBudgetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACCostBudgetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostBudgetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACCostBudgetNo;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtACCostBudgetExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medACCostBudgetDesc;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private ACCostBudgetDetailsGridControl fld_dgcACCostBudgetDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeACCostBudgetStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSDateEdit fld_dteACCostBudgetDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeACCostBudgetType;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel5;
    }
}
