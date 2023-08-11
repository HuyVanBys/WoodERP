using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmloyeePayRollFormula.UI
{
	/// <summary>
	/// Summary description for DMEPRF100
	/// </summary>
	partial class DMEPRF100
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
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHREmployeePayrollFormulaItems = new BOSERP.Modules.EmloyeePayRollFormula.HREmployeePayrollFormulaItemsGridControl();
            this.fld_dgvHREmployeePayrollFormulaItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRWorkingShifts = new BOSERP.Modules.EmloyeePayRollFormula.WorkingShiftGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHROTFactors = new BOSERP.Modules.EmloyeePayRollFormula.HROTFactorsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRTimesheetEmployeeLates = new BOSERP.Modules.EmloyeePayRollFormula.HRTimesheetEmployeeLatesGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeePayrollFormulaCalculation = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcHRTimesheetConfigs = new BOSERP.Modules.EmloyeePayRollFormula.HRTimesheetConfigsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox11 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox10 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHREmployeeCommissionBranchs = new BOSERP.Modules.EmloyeePayRollFormula.HREmployeeCommissionBranchsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox12 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox13 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox15 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox14 = new BOSComponent.BOSTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRAllowanceConfigs = new BOSERP.Modules.EmloyeePayRollFormula.AllowanceConfigGridControl();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.btnCalculatorBreakTime = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRBreakTimes = new BOSERP.Modules.EmloyeePayRollFormula.HRBreakTimesGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblWorkingDiff = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeePayrollFormulaWorkingDiff = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePayrollFormulaName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePayrollFormulaNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHREmployeePayrollFormulaFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHREmployeePayrollFormulaDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHREmployeePayrollFormulaToDate = new BOSComponent.BOSDateEdit(this.components);
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayrollFormulaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayrollFormulaItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRWorkingShifts)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROTFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimesheetEmployeeLates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormulaCalculation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimesheetConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeCommissionBranchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox14.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceConfigs)).BeginInit();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBreakTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePayrollFormulaDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaToDate.Properties)).BeginInit();
            this.xtraTabPage9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblWorkingDiff);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePayrollFormulaWorkingDiff);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePayrollFormulaName);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePayrollFormulaNo);
            this.bosPanel1.Controls.Add(this.fld_dteHREmployeePayrollFormulaFromDate);
            this.bosPanel1.Controls.Add(this.fld_medHREmployeePayrollFormulaDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHREmployeePayrollFormulaToDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(933, 609);
            this.bosPanel1.TabIndex = 7;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(4, 158);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(926, 448);
            this.bosTabControl1.TabIndex = 66;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6,
            this.xtraTabPage7,
            this.xtraTabPage8,
            this.xtraTabPage9});
            this.bosTabControl1.Tag = "";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHREmployeePayrollFormulaItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(920, 420);
            this.xtraTabPage1.Text = "Danh sách bảng lương";
            // 
            // fld_dgcHREmployeePayrollFormulaItems
            // 
            this.fld_dgcHREmployeePayrollFormulaItems.AllowDrop = true;
            this.fld_dgcHREmployeePayrollFormulaItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePayrollFormulaItems.BOSComment = "";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSDataMember = "";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSDataSource = "HREmployeePayrollFormulaItems";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSDescription = null;
            this.fld_dgcHREmployeePayrollFormulaItems.BOSError = null;
            this.fld_dgcHREmployeePayrollFormulaItems.BOSFieldGroup = "";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSFieldRelation = "";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSGridType = null;
            this.fld_dgcHREmployeePayrollFormulaItems.BOSPrivilege = "";
            this.fld_dgcHREmployeePayrollFormulaItems.BOSPropertyName = "";
            this.fld_dgcHREmployeePayrollFormulaItems.CommodityType = "";
            this.fld_dgcHREmployeePayrollFormulaItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePayrollFormulaItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHREmployeePayrollFormulaItems.MainView = this.fld_dgvHREmployeePayrollFormulaItems;
            this.fld_dgcHREmployeePayrollFormulaItems.Name = "fld_dgcHREmployeePayrollFormulaItems";
            this.fld_dgcHREmployeePayrollFormulaItems.PrintReport = false;
            this.fld_dgcHREmployeePayrollFormulaItems.Screen = null;
            this.fld_dgcHREmployeePayrollFormulaItems.Size = new System.Drawing.Size(914, 417);
            this.fld_dgcHREmployeePayrollFormulaItems.TabIndex = 13;
            this.fld_dgcHREmployeePayrollFormulaItems.Tag = "DC";
            this.fld_dgcHREmployeePayrollFormulaItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeePayrollFormulaItems});
            // 
            // fld_dgvHREmployeePayrollFormulaItems
            // 
            this.fld_dgvHREmployeePayrollFormulaItems.GridControl = this.fld_dgcHREmployeePayrollFormulaItems;
            this.fld_dgvHREmployeePayrollFormulaItems.Name = "fld_dgvHREmployeePayrollFormulaItems";
            this.fld_dgvHREmployeePayrollFormulaItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcHRWorkingShifts);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage2.Text = "Cấu hình ca làm việc";
            // 
            // fld_dgcHRWorkingShifts
            // 
            this.fld_dgcHRWorkingShifts.BOSComment = null;
            this.fld_dgcHRWorkingShifts.BOSDataMember = null;
            this.fld_dgcHRWorkingShifts.BOSDataSource = "HRWorkingShifts";
            this.fld_dgcHRWorkingShifts.BOSDescription = null;
            this.fld_dgcHRWorkingShifts.BOSError = null;
            this.fld_dgcHRWorkingShifts.BOSFieldGroup = null;
            this.fld_dgcHRWorkingShifts.BOSFieldRelation = null;
            this.fld_dgcHRWorkingShifts.BOSGridType = null;
            this.fld_dgcHRWorkingShifts.BOSPrivilege = null;
            this.fld_dgcHRWorkingShifts.BOSPropertyName = null;
            this.fld_dgcHRWorkingShifts.CommodityType = "";
            this.fld_dgcHRWorkingShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRWorkingShifts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRWorkingShifts.MenuManager = this.screenToolbar;
            this.fld_dgcHRWorkingShifts.Name = "fld_dgcHRWorkingShifts";
            this.fld_dgcHRWorkingShifts.PrintReport = false;
            this.fld_dgcHRWorkingShifts.Screen = null;
            this.fld_dgcHRWorkingShifts.Size = new System.Drawing.Size(914, 413);
            this.fld_dgcHRWorkingShifts.TabIndex = 1;
            this.fld_dgcHRWorkingShifts.Tag = "DC";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcHROTFactors);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage3.Text = "Cấu hình hệ số tăng ca";
            // 
            // fld_dgcHROTFactors
            // 
            this.fld_dgcHROTFactors.AllowDrop = true;
            this.fld_dgcHROTFactors.BOSComment = "";
            this.fld_dgcHROTFactors.BOSDataMember = null;
            this.fld_dgcHROTFactors.BOSDataSource = "HROTFactors";
            this.fld_dgcHROTFactors.BOSDescription = null;
            this.fld_dgcHROTFactors.BOSError = "";
            this.fld_dgcHROTFactors.BOSFieldGroup = "";
            this.fld_dgcHROTFactors.BOSFieldRelation = null;
            this.fld_dgcHROTFactors.BOSGridType = null;
            this.fld_dgcHROTFactors.BOSPrivilege = "";
            this.fld_dgcHROTFactors.BOSPropertyName = null;
            this.fld_dgcHROTFactors.CommodityType = "";
            this.fld_dgcHROTFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHROTFactors.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHROTFactors.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHROTFactors.MainView = this.gridView2;
            this.fld_dgcHROTFactors.Name = "fld_dgcHROTFactors";
            this.fld_dgcHROTFactors.PrintReport = false;
            this.fld_dgcHROTFactors.Screen = null;
            this.fld_dgcHROTFactors.Size = new System.Drawing.Size(914, 413);
            this.fld_dgcHROTFactors.TabIndex = 6;
            this.fld_dgcHROTFactors.Tag = "DC";
            this.fld_dgcHROTFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHROTFactors;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcHRTimesheetEmployeeLates);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage4.Text = "Cấu hình đi trễ/ tăng ca mặc định";
            // 
            // fld_dgcHRTimesheetEmployeeLates
            // 
            this.fld_dgcHRTimesheetEmployeeLates.AllowDrop = true;
            this.fld_dgcHRTimesheetEmployeeLates.BOSComment = "";
            this.fld_dgcHRTimesheetEmployeeLates.BOSDataMember = null;
            this.fld_dgcHRTimesheetEmployeeLates.BOSDataSource = "HRTimesheetEmployeeLates";
            this.fld_dgcHRTimesheetEmployeeLates.BOSDescription = null;
            this.fld_dgcHRTimesheetEmployeeLates.BOSError = "";
            this.fld_dgcHRTimesheetEmployeeLates.BOSFieldGroup = "";
            this.fld_dgcHRTimesheetEmployeeLates.BOSFieldRelation = null;
            this.fld_dgcHRTimesheetEmployeeLates.BOSGridType = null;
            this.fld_dgcHRTimesheetEmployeeLates.BOSPrivilege = "";
            this.fld_dgcHRTimesheetEmployeeLates.BOSPropertyName = null;
            this.fld_dgcHRTimesheetEmployeeLates.CommodityType = "";
            this.fld_dgcHRTimesheetEmployeeLates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTimesheetEmployeeLates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTimesheetEmployeeLates.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRTimesheetEmployeeLates.MainView = this.gridView5;
            this.fld_dgcHRTimesheetEmployeeLates.Name = "fld_dgcHRTimesheetEmployeeLates";
            this.fld_dgcHRTimesheetEmployeeLates.PrintReport = false;
            this.fld_dgcHRTimesheetEmployeeLates.Screen = null;
            this.fld_dgcHRTimesheetEmployeeLates.Size = new System.Drawing.Size(914, 413);
            this.fld_dgcHRTimesheetEmployeeLates.TabIndex = 6;
            this.fld_dgcHRTimesheetEmployeeLates.Tag = "DC";
            this.fld_dgcHRTimesheetEmployeeLates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcHRTimesheetEmployeeLates;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.bosLabel19);
            this.xtraTabPage5.Controls.Add(this.fld_lkeHREmployeePayrollFormulaCalculation);
            this.xtraTabPage5.Controls.Add(this.fld_dgcHRTimesheetConfigs);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage5.Text = "Cấu hình công tháng";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(7, 6);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(71, 13);
            this.bosLabel19.TabIndex = 58;
            this.bosLabel19.Text = "Cách tính công";
            // 
            // fld_lkeHREmployeePayrollFormulaCalculation
            // 
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSAllowAddNew = false;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSAllowDummy = false;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSComment = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSDataMember = "HREmployeePayrollFormulaCalculation";
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSDescription = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSError = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSFieldGroup = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSFieldParent = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSFieldRelation = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSPrivilege = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSSelectType = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.CurrentDisplayText = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Location = new System.Drawing.Point(105, 3);
            this.fld_lkeHREmployeePayrollFormulaCalculation.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Name = "fld_lkeHREmployeePayrollFormulaCalculation";
            this.fld_lkeHREmployeePayrollFormulaCalculation.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeePayrollFormulaCalculation.Properties.ColumnName = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Screen = null;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHREmployeePayrollFormulaCalculation.TabIndex = 57;
            this.fld_lkeHREmployeePayrollFormulaCalculation.Tag = "DC";
            this.fld_lkeHREmployeePayrollFormulaCalculation.Validated += new System.EventHandler(this.fld_lkeHREmployeePayrollFormulaCalculation_Validated);
            // 
            // fld_dgcHRTimesheetConfigs
            // 
            this.fld_dgcHRTimesheetConfigs.AllowDrop = true;
            this.fld_dgcHRTimesheetConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTimesheetConfigs.BOSComment = "";
            this.fld_dgcHRTimesheetConfigs.BOSDataMember = null;
            this.fld_dgcHRTimesheetConfigs.BOSDataSource = "HRTimesheetConfigs";
            this.fld_dgcHRTimesheetConfigs.BOSDescription = null;
            this.fld_dgcHRTimesheetConfigs.BOSError = "";
            this.fld_dgcHRTimesheetConfigs.BOSFieldGroup = "";
            this.fld_dgcHRTimesheetConfigs.BOSFieldRelation = null;
            this.fld_dgcHRTimesheetConfigs.BOSGridType = null;
            this.fld_dgcHRTimesheetConfigs.BOSPrivilege = "";
            this.fld_dgcHRTimesheetConfigs.BOSPropertyName = null;
            this.fld_dgcHRTimesheetConfigs.CommodityType = "";
            this.fld_dgcHRTimesheetConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTimesheetConfigs.Location = new System.Drawing.Point(3, 29);
            this.fld_dgcHRTimesheetConfigs.MainView = this.gridView4;
            this.fld_dgcHRTimesheetConfigs.Name = "fld_dgcHRTimesheetConfigs";
            this.fld_dgcHRTimesheetConfigs.PrintReport = false;
            this.fld_dgcHRTimesheetConfigs.Screen = null;
            this.fld_dgcHRTimesheetConfigs.Size = new System.Drawing.Size(908, 381);
            this.fld_dgcHRTimesheetConfigs.TabIndex = 7;
            this.fld_dgcHRTimesheetConfigs.Tag = "DC";
            this.fld_dgcHRTimesheetConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcHRTimesheetConfigs;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.groupBox3);
            this.xtraTabPage6.Controls.Add(this.groupBox2);
            this.xtraTabPage6.Controls.Add(this.groupBox5);
            this.xtraTabPage6.Controls.Add(this.groupBox4);
            this.xtraTabPage6.Controls.Add(this.groupBox1);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage6.Text = "Hoa hồng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bosLabel12);
            this.groupBox3.Controls.Add(this.bosLabel11);
            this.groupBox3.Controls.Add(this.bosLabel10);
            this.groupBox3.Controls.Add(this.bosTextBox11);
            this.groupBox3.Controls.Add(this.bosTextBox10);
            this.groupBox3.Controls.Add(this.bosTextBox9);
            this.groupBox3.Location = new System.Drawing.Point(7, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 153);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh số";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(18, 75);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(123, 13);
            this.bosLabel12.TabIndex = 1;
            this.bosLabel12.Text = "% tổng số tiền thu về cty";
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
            this.bosLabel11.Location = new System.Drawing.Point(18, 49);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(120, 13);
            this.bosLabel11.TabIndex = 1;
            this.bosLabel11.Text = "% tổng doanh số của CH";
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
            this.bosLabel10.Location = new System.Drawing.Point(18, 23);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(132, 13);
            this.bosLabel10.TabIndex = 1;
            this.bosLabel10.Text = "% tổng doanh số của NVBH";
            // 
            // bosTextBox11
            // 
            this.bosTextBox11.BOSComment = "";
            this.bosTextBox11.BOSDataMember = "HREmployeePayrollFormulaTotalAmountCompanyPercentValue";
            this.bosTextBox11.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox11.BOSDescription = null;
            this.bosTextBox11.BOSError = null;
            this.bosTextBox11.BOSFieldGroup = "";
            this.bosTextBox11.BOSFieldRelation = "";
            this.bosTextBox11.BOSPrivilege = "";
            this.bosTextBox11.BOSPropertyName = "Text";
            this.bosTextBox11.EditValue = "0.00";
            this.bosTextBox11.Location = new System.Drawing.Point(166, 72);
            this.bosTextBox11.Name = "bosTextBox11";
            this.bosTextBox11.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox11.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox11.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox11.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox11.Screen = null;
            this.bosTextBox11.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox11.TabIndex = 61;
            this.bosTextBox11.Tag = "DC";
            // 
            // bosTextBox10
            // 
            this.bosTextBox10.BOSComment = "";
            this.bosTextBox10.BOSDataMember = "HREmployeePayrollFormulaTotalAmountBranchPercentValue";
            this.bosTextBox10.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox10.BOSDescription = null;
            this.bosTextBox10.BOSError = null;
            this.bosTextBox10.BOSFieldGroup = "";
            this.bosTextBox10.BOSFieldRelation = "";
            this.bosTextBox10.BOSPrivilege = "";
            this.bosTextBox10.BOSPropertyName = "Text";
            this.bosTextBox10.EditValue = "0.00";
            this.bosTextBox10.Location = new System.Drawing.Point(166, 46);
            this.bosTextBox10.Name = "bosTextBox10";
            this.bosTextBox10.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox10.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox10.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox10.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox10.Screen = null;
            this.bosTextBox10.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox10.TabIndex = 61;
            this.bosTextBox10.Tag = "DC";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = "";
            this.bosTextBox9.BOSDataMember = "HREmployeePayrollFormulaTotalAmountEmployeePercentValue";
            this.bosTextBox9.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = "";
            this.bosTextBox9.BOSFieldRelation = "";
            this.bosTextBox9.BOSPrivilege = "";
            this.bosTextBox9.BOSPropertyName = "Text";
            this.bosTextBox9.EditValue = "0.00";
            this.bosTextBox9.Location = new System.Drawing.Point(166, 20);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox9.TabIndex = 61;
            this.bosTextBox9.Tag = "DC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bosLabel9);
            this.groupBox2.Controls.Add(this.bosLabel7);
            this.groupBox2.Controls.Add(this.bosLabel8);
            this.groupBox2.Controls.Add(this.bosTextBox8);
            this.groupBox2.Controls.Add(this.bosTextBox7);
            this.groupBox2.Controls.Add(this.bosTextBox6);
            this.groupBox2.Controls.Add(this.bosTextBox5);
            this.groupBox2.Controls.Add(this.bosTextBox4);
            this.groupBox2.Controls.Add(this.bosLabel5);
            this.groupBox2.Controls.Add(this.bosLabel6);
            this.groupBox2.Location = new System.Drawing.Point(7, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thu tiền còn";
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
            this.bosLabel9.Location = new System.Drawing.Point(255, 49);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(29, 13);
            this.bosLabel9.TabIndex = 1;
            this.bosLabel9.Text = "% trừ";
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
            this.bosLabel7.Location = new System.Drawing.Point(18, 101);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(59, 13);
            this.bosLabel7.TabIndex = 1;
            this.bosLabel7.Text = "% hoa hồng";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(18, 49);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(57, 13);
            this.bosLabel8.TabIndex = 1;
            this.bosLabel8.Text = "Số ngày trừ";
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = "";
            this.bosTextBox8.BOSDataMember = "HREmployeePayrollFormulaBalancePercentValueLevel2";
            this.bosTextBox8.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = "";
            this.bosTextBox8.BOSFieldRelation = "";
            this.bosTextBox8.BOSPrivilege = "";
            this.bosTextBox8.BOSPropertyName = "Text";
            this.bosTextBox8.EditValue = "0.00";
            this.bosTextBox8.Location = new System.Drawing.Point(290, 46);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox8.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox8.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox8.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(98, 20);
            this.bosTextBox8.TabIndex = 61;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = "";
            this.bosTextBox7.BOSDataMember = "HREmployeePayrollFormulaBalancePercentValue";
            this.bosTextBox7.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = "";
            this.bosTextBox7.BOSFieldRelation = "";
            this.bosTextBox7.BOSPrivilege = "";
            this.bosTextBox7.BOSPropertyName = "Text";
            this.bosTextBox7.EditValue = "0.00";
            this.bosTextBox7.Location = new System.Drawing.Point(121, 98);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox7.TabIndex = 61;
            this.bosTextBox7.Tag = "DC";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = "";
            this.bosTextBox6.BOSDataMember = "HREmployeePayrollFormulaBalanceFactor";
            this.bosTextBox6.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = "";
            this.bosTextBox6.BOSFieldRelation = "";
            this.bosTextBox6.BOSPrivilege = "";
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.EditValue = "0.00";
            this.bosTextBox6.Location = new System.Drawing.Point(121, 72);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox6.TabIndex = 61;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = "";
            this.bosTextBox5.BOSDataMember = "HREmployeePayrollFormulaBalanceDayNumberLevel2";
            this.bosTextBox5.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = "";
            this.bosTextBox5.BOSFieldRelation = "";
            this.bosTextBox5.BOSPrivilege = "";
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.EditValue = "0";
            this.bosTextBox5.Location = new System.Drawing.Point(121, 46);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox5.TabIndex = 61;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "HREmployeePayrollFormulaBalanceDayNumber";
            this.bosTextBox4.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.EditValue = "0";
            this.bosTextBox4.Location = new System.Drawing.Point(121, 20);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox4.TabIndex = 61;
            this.bosTextBox4.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(18, 23);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(77, 13);
            this.bosLabel5.TabIndex = 1;
            this.bosLabel5.Text = "Số ngày tính HH";
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
            this.bosLabel6.Location = new System.Drawing.Point(18, 75);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(27, 13);
            this.bosLabel6.TabIndex = 1;
            this.bosLabel6.Text = "Hệ số";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.fld_dgcHREmployeeCommissionBranchs);
            this.groupBox5.Location = new System.Drawing.Point(423, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 264);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách chi nhánh tính doanh số";
            // 
            // fld_dgcHREmployeeCommissionBranchs
            // 
            this.fld_dgcHREmployeeCommissionBranchs.AllowDrop = true;
            this.fld_dgcHREmployeeCommissionBranchs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeCommissionBranchs.BOSComment = "";
            this.fld_dgcHREmployeeCommissionBranchs.BOSDataMember = "";
            this.fld_dgcHREmployeeCommissionBranchs.BOSDataSource = "HREmployeeCommissionBranchs";
            this.fld_dgcHREmployeeCommissionBranchs.BOSDescription = null;
            this.fld_dgcHREmployeeCommissionBranchs.BOSError = null;
            this.fld_dgcHREmployeeCommissionBranchs.BOSFieldGroup = "";
            this.fld_dgcHREmployeeCommissionBranchs.BOSFieldRelation = "";
            this.fld_dgcHREmployeeCommissionBranchs.BOSGridType = null;
            this.fld_dgcHREmployeeCommissionBranchs.BOSPrivilege = "";
            this.fld_dgcHREmployeeCommissionBranchs.BOSPropertyName = "";
            this.fld_dgcHREmployeeCommissionBranchs.CommodityType = "";
            this.fld_dgcHREmployeeCommissionBranchs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeCommissionBranchs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcHREmployeeCommissionBranchs.MainView = this.gridView1;
            this.fld_dgcHREmployeeCommissionBranchs.Name = "fld_dgcHREmployeeCommissionBranchs";
            this.fld_dgcHREmployeeCommissionBranchs.PrintReport = false;
            this.fld_dgcHREmployeeCommissionBranchs.Screen = null;
            this.fld_dgcHREmployeeCommissionBranchs.Size = new System.Drawing.Size(472, 239);
            this.fld_dgcHREmployeeCommissionBranchs.TabIndex = 14;
            this.fld_dgcHREmployeeCommissionBranchs.Tag = "DC";
            this.fld_dgcHREmployeeCommissionBranchs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHREmployeeCommissionBranchs;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bosLabel17);
            this.groupBox4.Controls.Add(this.bosLabel16);
            this.groupBox4.Controls.Add(this.bosLabel13);
            this.groupBox4.Controls.Add(this.bosLabel14);
            this.groupBox4.Controls.Add(this.bosLabel18);
            this.groupBox4.Controls.Add(this.bosLabel15);
            this.groupBox4.Controls.Add(this.bosTextBox12);
            this.groupBox4.Controls.Add(this.bosTextBox13);
            this.groupBox4.Controls.Add(this.bosTextBox15);
            this.groupBox4.Controls.Add(this.bosTextBox14);
            this.groupBox4.Location = new System.Drawing.Point(423, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 136);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khác";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(262, 23);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(29, 13);
            this.bosLabel17.TabIndex = 1;
            this.bosLabel17.Text = "/m vải";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(262, 101);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(32, 13);
            this.bosLabel16.TabIndex = 1;
            this.bosLabel16.Text = "/CONT";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(17, 101);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(77, 13);
            this.bosLabel13.TabIndex = 1;
            this.bosLabel13.Text = "Hoa hồng CONT";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(17, 75);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(100, 13);
            this.bosLabel14.TabIndex = 1;
            this.bosLabel14.Text = "% hoa hồng cắt màn";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(17, 49);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(103, 13);
            this.bosLabel18.TabIndex = 1;
            this.bosLabel18.Text = "% hoa hồng bán màn";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(17, 23);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(84, 13);
            this.bosLabel15.TabIndex = 1;
            this.bosLabel15.Text = "Hoa hồng bán vải";
            // 
            // bosTextBox12
            // 
            this.bosTextBox12.BOSComment = "";
            this.bosTextBox12.BOSDataMember = "HREmployeePayrollFormulaXNK";
            this.bosTextBox12.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox12.BOSDescription = null;
            this.bosTextBox12.BOSError = null;
            this.bosTextBox12.BOSFieldGroup = "";
            this.bosTextBox12.BOSFieldRelation = "";
            this.bosTextBox12.BOSPrivilege = "";
            this.bosTextBox12.BOSPropertyName = "Text";
            this.bosTextBox12.EditValue = "0.00";
            this.bosTextBox12.Location = new System.Drawing.Point(138, 98);
            this.bosTextBox12.Name = "bosTextBox12";
            this.bosTextBox12.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox12.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox12.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox12.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox12.Screen = null;
            this.bosTextBox12.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox12.TabIndex = 61;
            this.bosTextBox12.Tag = "DC";
            // 
            // bosTextBox13
            // 
            this.bosTextBox13.BOSComment = "";
            this.bosTextBox13.BOSDataMember = "HREmployeePayrollFormulaCatMan";
            this.bosTextBox13.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox13.BOSDescription = null;
            this.bosTextBox13.BOSError = null;
            this.bosTextBox13.BOSFieldGroup = "";
            this.bosTextBox13.BOSFieldRelation = "";
            this.bosTextBox13.BOSPrivilege = "";
            this.bosTextBox13.BOSPropertyName = "Text";
            this.bosTextBox13.EditValue = "0";
            this.bosTextBox13.Location = new System.Drawing.Point(138, 72);
            this.bosTextBox13.Name = "bosTextBox13";
            this.bosTextBox13.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox13.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox13.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox13.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox13.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox13.Screen = null;
            this.bosTextBox13.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox13.TabIndex = 61;
            this.bosTextBox13.Tag = "DC";
            // 
            // bosTextBox15
            // 
            this.bosTextBox15.BOSComment = "";
            this.bosTextBox15.BOSDataMember = "HREmployeePayrollFormulaBanMan";
            this.bosTextBox15.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox15.BOSDescription = null;
            this.bosTextBox15.BOSError = null;
            this.bosTextBox15.BOSFieldGroup = "";
            this.bosTextBox15.BOSFieldRelation = "";
            this.bosTextBox15.BOSPrivilege = "";
            this.bosTextBox15.BOSPropertyName = "Text";
            this.bosTextBox15.EditValue = "0";
            this.bosTextBox15.Location = new System.Drawing.Point(138, 46);
            this.bosTextBox15.Name = "bosTextBox15";
            this.bosTextBox15.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox15.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox15.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox15.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox15.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox15.Screen = null;
            this.bosTextBox15.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox15.TabIndex = 61;
            this.bosTextBox15.Tag = "DC";
            // 
            // bosTextBox14
            // 
            this.bosTextBox14.BOSComment = "";
            this.bosTextBox14.BOSDataMember = "HREmployeePayrollFormulaBanVai";
            this.bosTextBox14.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox14.BOSDescription = null;
            this.bosTextBox14.BOSError = null;
            this.bosTextBox14.BOSFieldGroup = "";
            this.bosTextBox14.BOSFieldRelation = "";
            this.bosTextBox14.BOSPrivilege = "";
            this.bosTextBox14.BOSPropertyName = "Text";
            this.bosTextBox14.EditValue = "0";
            this.bosTextBox14.Location = new System.Drawing.Point(138, 20);
            this.bosTextBox14.Name = "bosTextBox14";
            this.bosTextBox14.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox14.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox14.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox14.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox14.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox14.Screen = null;
            this.bosTextBox14.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox14.TabIndex = 61;
            this.bosTextBox14.Tag = "DC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bosLabel4);
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.bosTextBox3);
            this.groupBox1.Controls.Add(this.bosTextBox2);
            this.groupBox1.Controls.Add(this.bosTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thu tiền cọc";
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
            this.bosLabel4.Location = new System.Drawing.Point(17, 75);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 1;
            this.bosLabel4.Text = "% hoa hồng";
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
            this.bosLabel3.Location = new System.Drawing.Point(17, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 1;
            this.bosLabel3.Text = "Hệ số";
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
            this.bosLabel1.Location = new System.Drawing.Point(17, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(81, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "% tối đa tiền cọc";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "HREmployeePayrollFormulaDepositPercentValue";
            this.bosTextBox3.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.EditValue = "0.00";
            this.bosTextBox3.Location = new System.Drawing.Point(121, 72);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox3.TabIndex = 61;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "HREmployeePayrollFormulaDepositFactor";
            this.bosTextBox2.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "0.00";
            this.bosTextBox2.Location = new System.Drawing.Point(121, 46);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox2.TabIndex = 61;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "HREmployeePayrollFormulaMaxPercentDeposit";
            this.bosTextBox1.BOSDataSource = "HREmployeePayrollFormulas";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "0.00";
            this.bosTextBox1.Location = new System.Drawing.Point(121, 20);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox1.TabIndex = 61;
            this.bosTextBox1.Tag = "DC";
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.fld_dgcHRAllowanceConfigs);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage7.Text = "Phụ cấp";
            // 
            // fld_dgcHRAllowanceConfigs
            // 
            this.fld_dgcHRAllowanceConfigs.BOSComment = null;
            this.fld_dgcHRAllowanceConfigs.BOSDataMember = null;
            this.fld_dgcHRAllowanceConfigs.BOSDataSource = "HRAllowanceConfigs";
            this.fld_dgcHRAllowanceConfigs.BOSDescription = null;
            this.fld_dgcHRAllowanceConfigs.BOSError = null;
            this.fld_dgcHRAllowanceConfigs.BOSFieldGroup = null;
            this.fld_dgcHRAllowanceConfigs.BOSFieldRelation = null;
            this.fld_dgcHRAllowanceConfigs.BOSGridType = null;
            this.fld_dgcHRAllowanceConfigs.BOSPrivilege = null;
            this.fld_dgcHRAllowanceConfigs.BOSPropertyName = null;
            this.fld_dgcHRAllowanceConfigs.CommodityType = "";
            this.fld_dgcHRAllowanceConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRAllowanceConfigs.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRAllowanceConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcHRAllowanceConfigs.Name = "fld_dgcHRAllowanceConfigs";
            this.fld_dgcHRAllowanceConfigs.PrintReport = false;
            this.fld_dgcHRAllowanceConfigs.Screen = null;
            this.fld_dgcHRAllowanceConfigs.Size = new System.Drawing.Size(914, 413);
            this.fld_dgcHRAllowanceConfigs.TabIndex = 2;
            this.fld_dgcHRAllowanceConfigs.Tag = "DC";
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.btnCalculatorBreakTime);
            this.xtraTabPage8.Controls.Add(this.fld_dgcHRBreakTimes);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(914, 413);
            this.xtraTabPage8.Text = "Cấu hình nghĩ giữa giờ";
            // 
            // btnCalculatorBreakTime
            // 
            this.btnCalculatorBreakTime.BOSComment = null;
            this.btnCalculatorBreakTime.BOSDataMember = null;
            this.btnCalculatorBreakTime.BOSDataSource = null;
            this.btnCalculatorBreakTime.BOSDescription = null;
            this.btnCalculatorBreakTime.BOSError = null;
            this.btnCalculatorBreakTime.BOSFieldGroup = null;
            this.btnCalculatorBreakTime.BOSFieldRelation = null;
            this.btnCalculatorBreakTime.BOSPrivilege = null;
            this.btnCalculatorBreakTime.BOSPropertyName = null;
            this.btnCalculatorBreakTime.Location = new System.Drawing.Point(7, 3);
            this.btnCalculatorBreakTime.Name = "btnCalculatorBreakTime";
            this.btnCalculatorBreakTime.Screen = null;
            this.btnCalculatorBreakTime.Size = new System.Drawing.Size(154, 27);
            this.btnCalculatorBreakTime.TabIndex = 67;
            this.btnCalculatorBreakTime.Text = "Tính lại thời gian nghĩ giữa giờ";
            this.btnCalculatorBreakTime.Click += new System.EventHandler(this.btnCalculatorBreakTime_Click);
            // 
            // fld_dgcHRBreakTimes
            // 
            this.fld_dgcHRBreakTimes.AllowDrop = true;
            this.fld_dgcHRBreakTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRBreakTimes.BOSComment = "";
            this.fld_dgcHRBreakTimes.BOSDataMember = null;
            this.fld_dgcHRBreakTimes.BOSDataSource = "HRBreakTimes";
            this.fld_dgcHRBreakTimes.BOSDescription = null;
            this.fld_dgcHRBreakTimes.BOSError = "";
            this.fld_dgcHRBreakTimes.BOSFieldGroup = "";
            this.fld_dgcHRBreakTimes.BOSFieldRelation = null;
            this.fld_dgcHRBreakTimes.BOSGridType = null;
            this.fld_dgcHRBreakTimes.BOSPrivilege = "";
            this.fld_dgcHRBreakTimes.BOSPropertyName = null;
            this.fld_dgcHRBreakTimes.CommodityType = "";
            this.fld_dgcHRBreakTimes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRBreakTimes.Location = new System.Drawing.Point(-2, 36);
            this.fld_dgcHRBreakTimes.MainView = this.gridView3;
            this.fld_dgcHRBreakTimes.Name = "fld_dgcHRBreakTimes";
            this.fld_dgcHRBreakTimes.PrintReport = false;
            this.fld_dgcHRBreakTimes.Screen = null;
            this.fld_dgcHRBreakTimes.Size = new System.Drawing.Size(916, 377);
            this.fld_dgcHRBreakTimes.TabIndex = 7;
            this.fld_dgcHRBreakTimes.Tag = "DC";
            this.fld_dgcHRBreakTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcHRBreakTimes;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(337, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(81, 13);
            this.bosLabel2.TabIndex = 52;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Nhóm chấm công";
            // 
            // fld_lblWorkingDiff
            // 
            this.fld_lblWorkingDiff.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblWorkingDiff.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblWorkingDiff.Appearance.Options.UseBackColor = true;
            this.fld_lblWorkingDiff.Appearance.Options.UseForeColor = true;
            this.fld_lblWorkingDiff.BOSComment = "";
            this.fld_lblWorkingDiff.BOSDataMember = "";
            this.fld_lblWorkingDiff.BOSDataSource = "";
            this.fld_lblWorkingDiff.BOSDescription = null;
            this.fld_lblWorkingDiff.BOSError = null;
            this.fld_lblWorkingDiff.BOSFieldGroup = "";
            this.fld_lblWorkingDiff.BOSFieldRelation = "";
            this.fld_lblWorkingDiff.BOSPrivilege = "";
            this.fld_lblWorkingDiff.BOSPropertyName = "";
            this.fld_lblWorkingDiff.Location = new System.Drawing.Point(13, 126);
            this.fld_lblWorkingDiff.Name = "fld_lblWorkingDiff";
            this.fld_lblWorkingDiff.Screen = null;
            this.fld_lblWorkingDiff.Size = new System.Drawing.Size(92, 13);
            this.fld_lblWorkingDiff.TabIndex = 52;
            this.fld_lblWorkingDiff.Tag = "";
            this.fld_lblWorkingDiff.Text = "Số công chênh lệch";
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
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(13, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel2.TabIndex = 52;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã công thức";
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
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(13, 64);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 55;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 38);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 56;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Từ ngày";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(337, 38);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel6.TabIndex = 57;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Đến ngày";
            // 
            // fld_txtHREmployeePayrollFormulaWorkingDiff
            // 
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSComment = "";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSDataMember = "HREmployeePayrollFormulaWorkingDiff";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSDescription = null;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSError = null;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSFieldGroup = "";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSFieldRelation = "";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSPrivilege = "";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.BOSPropertyName = "Text";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.EditValue = "";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Location = new System.Drawing.Point(111, 123);
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Name = "fld_txtHREmployeePayrollFormulaWorkingDiff";
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Screen = null;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.TabIndex = 6;
            this.fld_txtHREmployeePayrollFormulaWorkingDiff.Tag = "DC";
            // 
            // fld_txtHREmployeePayrollFormulaName
            // 
            this.fld_txtHREmployeePayrollFormulaName.BOSComment = "";
            this.fld_txtHREmployeePayrollFormulaName.BOSDataMember = "HREmployeePayrollFormulaName";
            this.fld_txtHREmployeePayrollFormulaName.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_txtHREmployeePayrollFormulaName.BOSDescription = null;
            this.fld_txtHREmployeePayrollFormulaName.BOSError = null;
            this.fld_txtHREmployeePayrollFormulaName.BOSFieldGroup = "";
            this.fld_txtHREmployeePayrollFormulaName.BOSFieldRelation = "";
            this.fld_txtHREmployeePayrollFormulaName.BOSPrivilege = "";
            this.fld_txtHREmployeePayrollFormulaName.BOSPropertyName = "Text";
            this.fld_txtHREmployeePayrollFormulaName.EditValue = "";
            this.fld_txtHREmployeePayrollFormulaName.Location = new System.Drawing.Point(429, 9);
            this.fld_txtHREmployeePayrollFormulaName.Name = "fld_txtHREmployeePayrollFormulaName";
            this.fld_txtHREmployeePayrollFormulaName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePayrollFormulaName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePayrollFormulaName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePayrollFormulaName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePayrollFormulaName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePayrollFormulaName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePayrollFormulaName.Screen = null;
            this.fld_txtHREmployeePayrollFormulaName.Size = new System.Drawing.Size(216, 20);
            this.fld_txtHREmployeePayrollFormulaName.TabIndex = 2;
            this.fld_txtHREmployeePayrollFormulaName.Tag = "DC";
            // 
            // fld_txtHREmployeePayrollFormulaNo
            // 
            this.fld_txtHREmployeePayrollFormulaNo.BOSComment = "";
            this.fld_txtHREmployeePayrollFormulaNo.BOSDataMember = "HREmployeePayrollFormulaNo";
            this.fld_txtHREmployeePayrollFormulaNo.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_txtHREmployeePayrollFormulaNo.BOSDescription = null;
            this.fld_txtHREmployeePayrollFormulaNo.BOSError = null;
            this.fld_txtHREmployeePayrollFormulaNo.BOSFieldGroup = "";
            this.fld_txtHREmployeePayrollFormulaNo.BOSFieldRelation = "";
            this.fld_txtHREmployeePayrollFormulaNo.BOSPrivilege = "";
            this.fld_txtHREmployeePayrollFormulaNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeePayrollFormulaNo.EditValue = "";
            this.fld_txtHREmployeePayrollFormulaNo.Location = new System.Drawing.Point(111, 9);
            this.fld_txtHREmployeePayrollFormulaNo.Name = "fld_txtHREmployeePayrollFormulaNo";
            this.fld_txtHREmployeePayrollFormulaNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePayrollFormulaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePayrollFormulaNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePayrollFormulaNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePayrollFormulaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePayrollFormulaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePayrollFormulaNo.Screen = null;
            this.fld_txtHREmployeePayrollFormulaNo.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHREmployeePayrollFormulaNo.TabIndex = 1;
            this.fld_txtHREmployeePayrollFormulaNo.Tag = "DC";
            // 
            // fld_dteHREmployeePayrollFormulaFromDate
            // 
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSComment = "";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSDataMember = "HREmployeePayrollFormulaFromDate";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSDescription = null;
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSError = null;
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSFieldGroup = "";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSFieldRelation = "";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSPrivilege = "";
            this.fld_dteHREmployeePayrollFormulaFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePayrollFormulaFromDate.EditValue = null;
            this.fld_dteHREmployeePayrollFormulaFromDate.Location = new System.Drawing.Point(111, 35);
            this.fld_dteHREmployeePayrollFormulaFromDate.Name = "fld_dteHREmployeePayrollFormulaFromDate";
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePayrollFormulaFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePayrollFormulaFromDate.Screen = null;
            this.fld_dteHREmployeePayrollFormulaFromDate.Size = new System.Drawing.Size(195, 20);
            this.fld_dteHREmployeePayrollFormulaFromDate.TabIndex = 3;
            this.fld_dteHREmployeePayrollFormulaFromDate.Tag = "DC";
            // 
            // fld_medHREmployeePayrollFormulaDesc
            // 
            this.fld_medHREmployeePayrollFormulaDesc.BOSComment = "";
            this.fld_medHREmployeePayrollFormulaDesc.BOSDataMember = "HREmployeePayrollFormulaDesc";
            this.fld_medHREmployeePayrollFormulaDesc.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_medHREmployeePayrollFormulaDesc.BOSDescription = null;
            this.fld_medHREmployeePayrollFormulaDesc.BOSError = null;
            this.fld_medHREmployeePayrollFormulaDesc.BOSFieldGroup = "";
            this.fld_medHREmployeePayrollFormulaDesc.BOSFieldRelation = "";
            this.fld_medHREmployeePayrollFormulaDesc.BOSPrivilege = "";
            this.fld_medHREmployeePayrollFormulaDesc.BOSPropertyName = "Text";
            this.fld_medHREmployeePayrollFormulaDesc.EditValue = "";
            this.fld_medHREmployeePayrollFormulaDesc.Location = new System.Drawing.Point(111, 61);
            this.fld_medHREmployeePayrollFormulaDesc.Name = "fld_medHREmployeePayrollFormulaDesc";
            this.fld_medHREmployeePayrollFormulaDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREmployeePayrollFormulaDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREmployeePayrollFormulaDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREmployeePayrollFormulaDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREmployeePayrollFormulaDesc.Screen = null;
            this.fld_medHREmployeePayrollFormulaDesc.Size = new System.Drawing.Size(534, 57);
            this.fld_medHREmployeePayrollFormulaDesc.TabIndex = 5;
            this.fld_medHREmployeePayrollFormulaDesc.Tag = "DC";
            // 
            // fld_dteHREmployeePayrollFormulaToDate
            // 
            this.fld_dteHREmployeePayrollFormulaToDate.BOSComment = "";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSDataMember = "HREmployeePayrollFormulaToDate";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSDescription = null;
            this.fld_dteHREmployeePayrollFormulaToDate.BOSError = null;
            this.fld_dteHREmployeePayrollFormulaToDate.BOSFieldGroup = "";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSFieldRelation = "";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSPrivilege = "";
            this.fld_dteHREmployeePayrollFormulaToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePayrollFormulaToDate.EditValue = null;
            this.fld_dteHREmployeePayrollFormulaToDate.Location = new System.Drawing.Point(429, 35);
            this.fld_dteHREmployeePayrollFormulaToDate.Name = "fld_dteHREmployeePayrollFormulaToDate";
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePayrollFormulaToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePayrollFormulaToDate.Screen = null;
            this.fld_dteHREmployeePayrollFormulaToDate.Size = new System.Drawing.Size(216, 20);
            this.fld_dteHREmployeePayrollFormulaToDate.TabIndex = 4;
            this.fld_dteHREmployeePayrollFormulaToDate.Tag = "DC";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.groupBox8);
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.xtraTabPage9.Size = new System.Drawing.Size(920, 420);
            this.xtraTabPage9.Text = "Cấu hình xét thưởng";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bosLabel27);
            this.groupBox8.Controls.Add(this.fld_txtHREmployeePayrollFormulaWorkingBHXH);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(290, 48);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cấu hình tính BHXH";
            // 
            // bosLabel27
            // 
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(6, 20);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(92, 13);
            this.bosLabel27.TabIndex = 69;
            this.bosLabel27.Text = "Xét công tính BHXH";
            // 
            // fld_txtHREmployeePayrollFormulaWorkingBHXH
            // 
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSComment = "";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSDataMember = "HREmployeePayrollFormulaWorkingBHXH";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSDescription = null;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSError = null;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSFieldGroup = "";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSFieldRelation = "";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSPrivilege = "";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.BOSPropertyName = "Text";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.EditValue = "0.00";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Location = new System.Drawing.Point(131, 17);
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Name = "fld_txtHREmployeePayrollFormulaWorkingBHXH";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Mask.EditMask = "n0";
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Screen = null;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Size = new System.Drawing.Size(139, 20);
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.TabIndex = 0;
            this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Tag = "DC";
            // 
            // DMEPRF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(933, 609);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEPRF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayrollFormulaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayrollFormulaItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRWorkingShifts)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROTFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimesheetEmployeeLates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormulaCalculation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimesheetConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeCommissionBranchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox14.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceConfigs)).EndInit();
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBreakTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaWorkingDiff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePayrollFormulaDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePayrollFormulaToDate.Properties)).EndInit();
            this.xtraTabPage9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePayrollFormulaWorkingBHXH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtHREmployeePayrollFormulaNo;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePayrollFormulaFromDate;
        private BOSComponent.BOSMemoEdit fld_medHREmployeePayrollFormulaDesc;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePayrollFormulaToDate;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHREmployeePayrollFormulaName;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private HREmployeePayrollFormulaItemsGridControl fld_dgcHREmployeePayrollFormulaItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePayrollFormulaItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private WorkingShiftGridControl fld_dgcHRWorkingShifts;
        private HROTFactorsGridControl fld_dgcHROTFactors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private HRTimesheetEmployeeLatesGridControl fld_dgcHRTimesheetEmployeeLates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private HRTimesheetConfigsGridControl fld_dgcHRTimesheetConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox bosTextBox11;
        private BOSComponent.BOSTextBox bosTextBox10;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private GroupBox groupBox4;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox bosTextBox12;
        private BOSComponent.BOSTextBox bosTextBox13;
        private BOSComponent.BOSTextBox bosTextBox14;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox bosTextBox15;
        private GroupBox groupBox5;
        private HREmployeeCommissionBranchsGridControl fld_dgcHREmployeeCommissionBranchs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel fld_lblWorkingDiff;
        private BOSComponent.BOSTextBox fld_txtHREmployeePayrollFormulaWorkingDiff;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private AllowanceConfigGridControl fld_dgcHRAllowanceConfigs;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private BOSERP.Modules.EmloyeePayRollFormula.HRBreakTimesGridControl fld_dgcHRBreakTimes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeePayrollFormulaCalculation;
        private BOSComponent.BOSButton btnCalculatorBreakTime;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private GroupBox groupBox8;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSTextBox fld_txtHREmployeePayrollFormulaWorkingBHXH;
    }
}
