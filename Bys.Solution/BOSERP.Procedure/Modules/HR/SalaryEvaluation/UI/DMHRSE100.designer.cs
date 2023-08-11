using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SalaryEvaluation.UI
{
    /// <summary>
    /// Summary description for DMHRSE100
    /// </summary>
    partial class DMHRSE100
    {
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private HREmployeeSalaryEvaluationsGridControl fld_dgcHREmployeeSalaryEvaluations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMHRSE100));
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHREmployeeSalaryEvaluations = new BOSERP.Modules.SalaryEvaluation.HREmployeeSalaryEvaluationsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeHRSalaryEvaluationPeriodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteHRKPIRegistrationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRSalaryEvaluationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRSalaryEvaluationSlrAmt = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRSalaryEvaluationName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRSalaryEvaluationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRSalaryEvaluationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSalaryEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSalaryEvaluationPeriodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSalaryEvaluationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationSlrAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRSalaryEvaluationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = null;
            this.fld_lblLabel2.BOSDataMember = null;
            this.fld_lblLabel2.BOSDataSource = null;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = null;
            this.fld_lblLabel2.BOSFieldRelation = null;
            this.fld_lblLabel2.BOSPrivilege = null;
            this.fld_lblLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel2, "fld_lblLabel2");
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel2, ((bool)(resources.GetObject("fld_lblLabel2.ShowHelp"))));
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = null;
            this.fld_lblLabel3.BOSDataMember = null;
            this.fld_lblLabel3.BOSDataSource = null;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = null;
            this.fld_lblLabel3.BOSFieldRelation = null;
            this.fld_lblLabel3.BOSPrivilege = null;
            this.fld_lblLabel3.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel3, "fld_lblLabel3");
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel3, ((bool)(resources.GetObject("fld_lblLabel3.ShowHelp"))));
            // 
            // fld_dgcHREmployeeSalaryEvaluations
            // 
            this.fld_dgcHREmployeeSalaryEvaluations.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHREmployeeSalaryEvaluations, "fld_dgcHREmployeeSalaryEvaluations");
            this.fld_dgcHREmployeeSalaryEvaluations.BOSComment = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSDataMember = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSDataSource = "HREmployeeSalaryEvaluations";
            this.fld_dgcHREmployeeSalaryEvaluations.BOSDescription = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSError = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSFieldGroup = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSFieldRelation = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSGridType = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSPrivilege = null;
            this.fld_dgcHREmployeeSalaryEvaluations.BOSPropertyName = null;
            this.fld_dgcHREmployeeSalaryEvaluations.CommodityType = "";
            this.fld_dgcHREmployeeSalaryEvaluations.GridViewMain = null;
            this.fld_dgcHREmployeeSalaryEvaluations.MainView = this.gridView1;
            this.fld_dgcHREmployeeSalaryEvaluations.Name = "fld_dgcHREmployeeSalaryEvaluations";
            this.fld_dgcHREmployeeSalaryEvaluations.PrintReport = false;
            this.fld_dgcHREmployeeSalaryEvaluations.RowHandle = 0;
            this.fld_dgcHREmployeeSalaryEvaluations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeSalaryEvaluations, ((bool)(resources.GetObject("fld_dgcHREmployeeSalaryEvaluations.ShowHelp"))));
            this.fld_dgcHREmployeeSalaryEvaluations.Tag = "DC";
            this.fld_dgcHREmployeeSalaryEvaluations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHREmployeeSalaryEvaluations;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            resources.ApplyResources(this.bosGroupControl1, "bosGroupControl1");
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRSalaryEvaluationPeriodType);
            this.bosGroupControl1.Controls.Add(this.fld_dteHRKPIRegistrationDate);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRSalaryEvaluationStatus);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRSalaryEvaluationSlrAmt);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRSalaryEvaluationName);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_medHRSalaryEvaluationDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRSalaryEvaluationWorkingSlrAmt);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRSalaryEvaluationNo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, ((bool)(resources.GetObject("bosGroupControl1.ShowHelp"))));
            // 
            // fld_lkeHRSalaryEvaluationPeriodType
            // 
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSAllowAddNew = false;
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSAllowDummy = false;
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSComment = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSDataMember = "HRSalaryEvaluationPeriodType";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSDataSource = "HRSalaryEvaluations";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSDescription = null;
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSError = null;
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSFieldGroup = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSFieldParent = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSFieldRelation = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSPrivilege = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSPropertyName = "EditValue";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSSelectType = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.BOSSelectTypeValue = "";
            this.fld_lkeHRSalaryEvaluationPeriodType.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHRSalaryEvaluationPeriodType, "fld_lkeHRSalaryEvaluationPeriodType");
            this.fld_lkeHRSalaryEvaluationPeriodType.Name = "fld_lkeHRSalaryEvaluationPeriodType";
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHRSalaryEvaluationPeriodType.Properties.Buttons"))))});
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.ColumnName = null;
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.NullText = resources.GetString("fld_lkeHRSalaryEvaluationPeriodType.Properties.NullText");
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.PopupWidth = 40;
            this.fld_lkeHRSalaryEvaluationPeriodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRSalaryEvaluationPeriodType.Screen = null;
            this.fld_lkeHRSalaryEvaluationPeriodType.Tag = "DC";
            // 
            // fld_dteHRKPIRegistrationDate
            // 
            this.fld_dteHRKPIRegistrationDate.BOSComment = null;
            this.fld_dteHRKPIRegistrationDate.BOSDataMember = "HRSalaryEvaluationDate";
            this.fld_dteHRKPIRegistrationDate.BOSDataSource = "HRSalaryEvaluations";
            this.fld_dteHRKPIRegistrationDate.BOSDescription = null;
            this.fld_dteHRKPIRegistrationDate.BOSError = null;
            this.fld_dteHRKPIRegistrationDate.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationDate.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationDate.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHRKPIRegistrationDate, "fld_dteHRKPIRegistrationDate");
            this.fld_dteHRKPIRegistrationDate.Name = "fld_dteHRKPIRegistrationDate";
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRKPIRegistrationDate.Properties.Buttons"))))});
            this.fld_dteHRKPIRegistrationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationDate.Screen = null;
            this.fld_dteHRKPIRegistrationDate.Tag = "DC";
            // 
            // fld_lkeHRSalaryEvaluationStatus
            // 
            this.fld_lkeHRSalaryEvaluationStatus.BOSAllowAddNew = false;
            this.fld_lkeHRSalaryEvaluationStatus.BOSAllowDummy = true;
            this.fld_lkeHRSalaryEvaluationStatus.BOSComment = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSDataMember = "HRSalaryEvaluationStatus";
            this.fld_lkeHRSalaryEvaluationStatus.BOSDataSource = "HRSalaryEvaluations";
            this.fld_lkeHRSalaryEvaluationStatus.BOSDescription = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSError = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSFieldGroup = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSFieldParent = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSFieldRelation = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSPrivilege = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRSalaryEvaluationStatus.BOSSelectType = null;
            this.fld_lkeHRSalaryEvaluationStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRSalaryEvaluationStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHRSalaryEvaluationStatus, "fld_lkeHRSalaryEvaluationStatus");
            this.fld_lkeHRSalaryEvaluationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRSalaryEvaluationStatus.Name = "fld_lkeHRSalaryEvaluationStatus";
            this.fld_lkeHRSalaryEvaluationStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeHRSalaryEvaluationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRSalaryEvaluationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHRSalaryEvaluationStatus.Properties.Buttons"))))});
            this.fld_lkeHRSalaryEvaluationStatus.Properties.ColumnName = null;
            this.fld_lkeHRSalaryEvaluationStatus.Properties.NullText = resources.GetString("fld_lkeHRSalaryEvaluationStatus.Properties.NullText");
            this.fld_lkeHRSalaryEvaluationStatus.Properties.ReadOnly = true;
            this.fld_lkeHRSalaryEvaluationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRSalaryEvaluationStatus.Screen = null;
            this.fld_lkeHRSalaryEvaluationStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            // 
            // fld_txtHRSalaryEvaluationSlrAmt
            // 
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSComment = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSDataMember = "HRSalaryEvaluationSlrAmt";
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSDescription = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSError = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationSlrAmt.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationSlrAmt, "fld_txtHRSalaryEvaluationSlrAmt");
            this.fld_txtHRSalaryEvaluationSlrAmt.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationSlrAmt.Name = "fld_txtHRSalaryEvaluationSlrAmt";
            this.fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.EditMask = resources.GetString("fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.EditMask");
            this.fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.MaskType")));
            this.fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationSlrAmt.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRSalaryEvaluationSlrAmt.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRSalaryEvaluationSlrAmt, ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationSlrAmt.ShowHelp"))));
            this.fld_txtHRSalaryEvaluationSlrAmt.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            // 
            // fld_txtHRSalaryEvaluationName
            // 
            this.fld_txtHRSalaryEvaluationName.BOSComment = null;
            this.fld_txtHRSalaryEvaluationName.BOSDataMember = "HRSalaryEvaluationName";
            this.fld_txtHRSalaryEvaluationName.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationName.BOSDescription = null;
            this.fld_txtHRSalaryEvaluationName.BOSError = null;
            this.fld_txtHRSalaryEvaluationName.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationName.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationName.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationName.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationName, "fld_txtHRSalaryEvaluationName");
            this.fld_txtHRSalaryEvaluationName.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationName.Name = "fld_txtHRSalaryEvaluationName";
            this.fld_txtHRSalaryEvaluationName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRSalaryEvaluationName, ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationName.ShowHelp"))));
            this.fld_txtHRSalaryEvaluationName.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            // 
            // fld_medHRSalaryEvaluationDesc
            // 
            this.fld_medHRSalaryEvaluationDesc.BOSComment = null;
            this.fld_medHRSalaryEvaluationDesc.BOSDataMember = "HRSalaryEvaluationDesc";
            this.fld_medHRSalaryEvaluationDesc.BOSDataSource = "HRSalaryEvaluations";
            this.fld_medHRSalaryEvaluationDesc.BOSDescription = null;
            this.fld_medHRSalaryEvaluationDesc.BOSError = null;
            this.fld_medHRSalaryEvaluationDesc.BOSFieldGroup = null;
            this.fld_medHRSalaryEvaluationDesc.BOSFieldRelation = null;
            this.fld_medHRSalaryEvaluationDesc.BOSPrivilege = null;
            this.fld_medHRSalaryEvaluationDesc.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_medHRSalaryEvaluationDesc, "fld_medHRSalaryEvaluationDesc");
            this.fld_medHRSalaryEvaluationDesc.Name = "fld_medHRSalaryEvaluationDesc";
            this.fld_medHRSalaryEvaluationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRSalaryEvaluationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRSalaryEvaluationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRSalaryEvaluationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRSalaryEvaluationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRSalaryEvaluationDesc, ((bool)(resources.GetObject("fld_medHRSalaryEvaluationDesc.ShowHelp"))));
            this.fld_medHRSalaryEvaluationDesc.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // fld_txtHRSalaryEvaluationWorkingSlrAmt
            // 
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSComment = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSDataMember = "HRSalaryEvaluationWorkingSlrAmt";
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSDescription = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSError = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationWorkingSlrAmt, "fld_txtHRSalaryEvaluationWorkingSlrAmt");
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Name = "fld_txtHRSalaryEvaluationWorkingSlrAmt";
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.EditMask = resources.GetString("fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.EditMask");
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.MaskType")));
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRSalaryEvaluationWorkingSlrAmt, ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationWorkingSlrAmt.ShowHelp"))));
            this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Tag = "DC";
            // 
            // fld_txtHRSalaryEvaluationNo
            // 
            this.fld_txtHRSalaryEvaluationNo.BOSComment = null;
            this.fld_txtHRSalaryEvaluationNo.BOSDataMember = "HRSalaryEvaluationNo";
            this.fld_txtHRSalaryEvaluationNo.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationNo.BOSDescription = null;
            this.fld_txtHRSalaryEvaluationNo.BOSError = null;
            this.fld_txtHRSalaryEvaluationNo.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationNo.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationNo.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationNo.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationNo, "fld_txtHRSalaryEvaluationNo");
            this.fld_txtHRSalaryEvaluationNo.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationNo.Name = "fld_txtHRSalaryEvaluationNo";
            this.fld_txtHRSalaryEvaluationNo.Screen = null;
            this.fld_txtHRSalaryEvaluationNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // bosTabControl1
            // 
            resources.ApplyResources(this.bosTabControl1, "bosTabControl1");
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.bosTabControl1, ((bool)(resources.GetObject("bosTabControl1.ShowHelp"))));
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnAddEmployee);
            this.xtraTabPage1.Controls.Add(this.fld_dgcHREmployeeSalaryEvaluations);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, ((bool)(resources.GetObject("xtraTabPage1.ShowHelp"))));
            resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.BOSComment = null;
            this.fld_btnAddEmployee.BOSDataMember = null;
            this.fld_btnAddEmployee.BOSDataSource = null;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = null;
            this.fld_btnAddEmployee.BOSFieldRelation = null;
            this.fld_btnAddEmployee.BOSPrivilege = null;
            this.fld_btnAddEmployee.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnAddEmployee, "fld_btnAddEmployee");
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddEmployee, ((bool)(resources.GetObject("fld_btnAddEmployee.ShowHelp"))));
            this.fld_btnAddEmployee.Tag = "ShowKPI";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // DMHRSE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRSE100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSalaryEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSalaryEvaluationPeriodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSalaryEvaluationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationSlrAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRSalaryEvaluationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationWorkingSlrAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationWorkingSlrAmt;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medHRSalaryEvaluationDesc;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationSlrAmt;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeHRSalaryEvaluationStatus;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRSalaryEvaluationPeriodType;
    }
}
