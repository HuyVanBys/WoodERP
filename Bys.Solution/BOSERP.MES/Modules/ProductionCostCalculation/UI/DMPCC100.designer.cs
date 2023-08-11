using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCostCalculation.UI
{
    /// <summary>
    /// Summary description for DMPCC100
    /// </summary>
    partial class DMPCC100
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
            this.fld_lkeMMProductionCostCalculationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnLoadFeeByFactor = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostCalculationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_MMProductionCostFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostCalculationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.Cost = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostCalculationDetailCosts = new BOSERP.Modules.ProductionCostCalculation.MMProductionCostCalculationDetailCostsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ReceiptItem = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostCalculationItems = new BOSERP.Modules.ProductionCostCalculation.MMProductionCostCalculationItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Allocation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostCalculationAllocations = new BOSERP.Modules.ProductionCostCalculation.MMProductionCostCalculationAllocationsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OtherAllocation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostCalculationAllocationOthers = new BOSERP.Modules.ProductionCostCalculation.MMProductionCostCalculationAllocationOthersGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Price = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostCalculationPrices = new BOSERP.Modules.ProductionCostCalculation.MMProductionCostCalculationPricesGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Statictis = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostCalculationTotalBlock = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostCalculationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionCostCalculationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostCalculationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostCalculationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.Cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationDetailCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.ReceiptItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Allocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.OtherAllocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationAllocationOthers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.Price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.Statictis.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationTotalBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostCalculationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeMMProductionCostCalculationStatus);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.fld_btnLoadFeeByFactor);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostCalculationToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionCostFormulaID);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostCalculationFromDate);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostCalculationDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medMMProductionCostCalculationDesc);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtMMProductionCostCalculationNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(904, 616);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeMMProductionCostCalculationStatus
            // 
            this.fld_lkeMMProductionCostCalculationStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionCostCalculationStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionCostCalculationStatus.BOSComment = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSDataMember = "MMProductionCostCalculationStatus";
            this.fld_lkeMMProductionCostCalculationStatus.BOSDataSource = "MMProductionCostCalculations";
            this.fld_lkeMMProductionCostCalculationStatus.BOSDescription = null;
            this.fld_lkeMMProductionCostCalculationStatus.BOSError = null;
            this.fld_lkeMMProductionCostCalculationStatus.BOSFieldGroup = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSFieldParent = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSFieldRelation = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSPrivilege = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionCostCalculationStatus.BOSSelectType = "";
            this.fld_lkeMMProductionCostCalculationStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionCostCalculationStatus.CurrentDisplayText = "";
            this.fld_lkeMMProductionCostCalculationStatus.Location = new System.Drawing.Point(370, 64);
            this.fld_lkeMMProductionCostCalculationStatus.Name = "fld_lkeMMProductionCostCalculationStatus";
            this.fld_lkeMMProductionCostCalculationStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionCostCalculationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionCostCalculationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionCostCalculationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionCostCalculationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionCostCalculationStatus.Properties.ColumnName = null;
            this.fld_lkeMMProductionCostCalculationStatus.Properties.NullText = "";
            this.fld_lkeMMProductionCostCalculationStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionCostCalculationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionCostCalculationStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionCostCalculationStatus, true);
            this.fld_lkeMMProductionCostCalculationStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMProductionCostCalculationStatus.TabIndex = 4;
            this.fld_lkeMMProductionCostCalculationStatus.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(281, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(49, 13);
            this.bosLabel7.TabIndex = 584;
            this.bosLabel7.Text = "Tình trạng";
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
            this.bosLabel4.Location = new System.Drawing.Point(17, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 582;
            this.bosLabel4.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = "";
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMProductionCostCalculations";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = "";
            this.fld_lkeFK_MMOperationID.BOSFieldParent = "";
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = "";
            this.fld_lkeFK_MMOperationID.BOSPrivilege = "";
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = "";
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(101, 64);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 3;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // fld_btnLoadFeeByFactor
            // 
            this.fld_btnLoadFeeByFactor.BOSComment = null;
            this.fld_btnLoadFeeByFactor.BOSDataMember = null;
            this.fld_btnLoadFeeByFactor.BOSDataSource = null;
            this.fld_btnLoadFeeByFactor.BOSDescription = null;
            this.fld_btnLoadFeeByFactor.BOSError = null;
            this.fld_btnLoadFeeByFactor.BOSFieldGroup = null;
            this.fld_btnLoadFeeByFactor.BOSFieldRelation = null;
            this.fld_btnLoadFeeByFactor.BOSPrivilege = null;
            this.fld_btnLoadFeeByFactor.BOSPropertyName = null;
            this.fld_btnLoadFeeByFactor.Location = new System.Drawing.Point(526, 122);
            this.fld_btnLoadFeeByFactor.Name = "fld_btnLoadFeeByFactor";
            this.fld_btnLoadFeeByFactor.Screen = null;
            this.fld_btnLoadFeeByFactor.Size = new System.Drawing.Size(103, 36);
            this.fld_btnLoadFeeByFactor.TabIndex = 8;
            this.fld_btnLoadFeeByFactor.Text = "Tính giá thành";
            this.fld_btnLoadFeeByFactor.Click += new System.EventHandler(this.fld_btnLoadFeeByFactor_Click);
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
            this.bosLabel6.Location = new System.Drawing.Point(281, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 86;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_dteMMProductionCostCalculationToDate
            // 
            this.fld_dteMMProductionCostCalculationToDate.BOSComment = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSDataMember = "MMProductionCostCalculationToDate";
            this.fld_dteMMProductionCostCalculationToDate.BOSDataSource = "MMProductionCostCalculations";
            this.fld_dteMMProductionCostCalculationToDate.BOSDescription = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSError = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostCalculationToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostCalculationToDate.EditValue = null;
            this.fld_dteMMProductionCostCalculationToDate.Location = new System.Drawing.Point(370, 90);
            this.fld_dteMMProductionCostCalculationToDate.Name = "fld_dteMMProductionCostCalculationToDate";
            this.fld_dteMMProductionCostCalculationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostCalculationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostCalculationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostCalculationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostCalculationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostCalculationToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostCalculationToDate.Screen = null;
            this.fld_dteMMProductionCostCalculationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostCalculationToDate.TabIndex = 6;
            this.fld_dteMMProductionCostCalculationToDate.Tag = "DC";
            // 
            // fld_lkeFK_MMProductionCostFormulaID
            // 
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSComment = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataMember = "FK_MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataSource = "MMProductionCostCalculations";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDescription = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSError = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionCostFormulaID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Location = new System.Drawing.Point(101, 38);
            this.fld_lkeFK_MMProductionCostFormulaID.Name = "fld_lkeFK_MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFormulaNo", "Mã công thức"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFormulaName", "Tên công thức")});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.DisplayMember = "MMProductionCostFormulaName";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.ValueMember = "MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.Screen = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Size = new System.Drawing.Size(419, 20);
            this.fld_lkeFK_MMProductionCostFormulaID.TabIndex = 2;
            this.fld_lkeFK_MMProductionCostFormulaID.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(17, 41);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(72, 13);
            this.bosLabel15.TabIndex = 579;
            this.bosLabel15.Text = "Công thức TGT";
            // 
            // fld_dteMMProductionCostCalculationFromDate
            // 
            this.fld_dteMMProductionCostCalculationFromDate.BOSComment = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSDataMember = "MMProductionCostCalculationFromDate";
            this.fld_dteMMProductionCostCalculationFromDate.BOSDataSource = "MMProductionCostCalculations";
            this.fld_dteMMProductionCostCalculationFromDate.BOSDescription = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSError = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostCalculationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostCalculationFromDate.EditValue = null;
            this.fld_dteMMProductionCostCalculationFromDate.Location = new System.Drawing.Point(101, 90);
            this.fld_dteMMProductionCostCalculationFromDate.Name = "fld_dteMMProductionCostCalculationFromDate";
            this.fld_dteMMProductionCostCalculationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostCalculationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostCalculationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostCalculationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostCalculationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostCalculationFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostCalculationFromDate.Screen = null;
            this.fld_dteMMProductionCostCalculationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostCalculationFromDate.TabIndex = 5;
            this.fld_dteMMProductionCostCalculationFromDate.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 164);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.Cost;
            this.bosTabControl1.Size = new System.Drawing.Size(898, 449);
            this.bosTabControl1.TabIndex = 8;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Cost,
            this.ReceiptItem,
            this.Allocation,
            this.OtherAllocation,
            this.Price,
            this.Statictis});
            this.bosTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.bosTabControl1_SelectedPageChanged);
            // 
            // Cost
            // 
            this.Cost.Controls.Add(this.fld_dgcMMProductionCostCalculationDetailCosts);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(892, 421);
            this.Cost.Text = "Yếu tố chi phí";
            // 
            // fld_dgcMMProductionCostCalculationDetailCosts
            // 
            this.fld_dgcMMProductionCostCalculationDetailCosts.AllowDrop = true;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSComment = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSDataSource = "MMProductionCostCalculationDetailCosts";
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSError = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.CommodityType = "";
            this.fld_dgcMMProductionCostCalculationDetailCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionCostCalculationDetailCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostCalculationDetailCosts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionCostCalculationDetailCosts.MainView = this.gridView2;
            this.fld_dgcMMProductionCostCalculationDetailCosts.Name = "fld_dgcMMProductionCostCalculationDetailCosts";
            this.fld_dgcMMProductionCostCalculationDetailCosts.PrintReport = false;
            this.fld_dgcMMProductionCostCalculationDetailCosts.Screen = null;
            this.fld_dgcMMProductionCostCalculationDetailCosts.Size = new System.Drawing.Size(892, 421);
            this.fld_dgcMMProductionCostCalculationDetailCosts.TabIndex = 0;
            this.fld_dgcMMProductionCostCalculationDetailCosts.Tag = "DC";
            this.fld_dgcMMProductionCostCalculationDetailCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostCalculationDetailCosts;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // ReceiptItem
            // 
            this.ReceiptItem.Controls.Add(this.fld_dgcMMProductionCostCalculationItems);
            this.ReceiptItem.Name = "ReceiptItem";
            this.ReceiptItem.Size = new System.Drawing.Size(892, 421);
            this.ReceiptItem.Text = "Số lượng sản xuất";
            // 
            // fld_dgcMMProductionCostCalculationItems
            // 
            this.fld_dgcMMProductionCostCalculationItems.AllowDrop = true;
            this.fld_dgcMMProductionCostCalculationItems.BOSComment = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSDataSource = "MMProductionCostCalculationItems";
            this.fld_dgcMMProductionCostCalculationItems.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSError = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculationItems.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculationItems.CommodityType = "";
            this.fld_dgcMMProductionCostCalculationItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionCostCalculationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostCalculationItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionCostCalculationItems.MainView = this.gridView1;
            this.fld_dgcMMProductionCostCalculationItems.Name = "fld_dgcMMProductionCostCalculationItems";
            this.fld_dgcMMProductionCostCalculationItems.PrintReport = false;
            this.fld_dgcMMProductionCostCalculationItems.Screen = null;
            this.fld_dgcMMProductionCostCalculationItems.Size = new System.Drawing.Size(892, 421);
            this.fld_dgcMMProductionCostCalculationItems.TabIndex = 1;
            this.fld_dgcMMProductionCostCalculationItems.Tag = "DC";
            this.fld_dgcMMProductionCostCalculationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostCalculationItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // Allocation
            // 
            this.Allocation.Controls.Add(this.fld_dgcMMProductionCostCalculationAllocations);
            this.Allocation.Name = "Allocation";
            this.Allocation.Size = new System.Drawing.Size(886, 414);
            this.Allocation.Text = "Phân bổ theo YTCP";
            // 
            // fld_dgcMMProductionCostCalculationAllocations
            // 
            this.fld_dgcMMProductionCostCalculationAllocations.AllowDrop = true;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSComment = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSDataSource = "MMProductionCostCalculationAllocations";
            this.fld_dgcMMProductionCostCalculationAllocations.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSError = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculationAllocations.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculationAllocations.CommodityType = "";
            this.fld_dgcMMProductionCostCalculationAllocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionCostCalculationAllocations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostCalculationAllocations.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionCostCalculationAllocations.MainView = this.gridView3;
            this.fld_dgcMMProductionCostCalculationAllocations.Name = "fld_dgcMMProductionCostCalculationAllocations";
            this.fld_dgcMMProductionCostCalculationAllocations.PrintReport = false;
            this.fld_dgcMMProductionCostCalculationAllocations.Screen = null;
            this.fld_dgcMMProductionCostCalculationAllocations.Size = new System.Drawing.Size(886, 414);
            this.fld_dgcMMProductionCostCalculationAllocations.TabIndex = 1;
            this.fld_dgcMMProductionCostCalculationAllocations.Tag = "DC";
            this.fld_dgcMMProductionCostCalculationAllocations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMProductionCostCalculationAllocations;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // OtherAllocation
            // 
            this.OtherAllocation.Controls.Add(this.fld_dgcMMProductionCostCalculationAllocationOthers);
            this.OtherAllocation.Name = "OtherAllocation";
            this.OtherAllocation.Size = new System.Drawing.Size(886, 414);
            this.OtherAllocation.Text = "Phân bổ theo YTCP khác";
            // 
            // fld_dgcMMProductionCostCalculationAllocationOthers
            // 
            this.fld_dgcMMProductionCostCalculationAllocationOthers.AllowDrop = true;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSComment = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSDataSource = "MMProductionCostCalculationAllocations";
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSError = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.CommodityType = "";
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionCostCalculationAllocationOthers.MainView = this.gridView4;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Name = "fld_dgcMMProductionCostCalculationAllocationOthers";
            this.fld_dgcMMProductionCostCalculationAllocationOthers.PrintReport = false;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Screen = null;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Size = new System.Drawing.Size(886, 414);
            this.fld_dgcMMProductionCostCalculationAllocationOthers.TabIndex = 2;
            this.fld_dgcMMProductionCostCalculationAllocationOthers.Tag = "DC";
            this.fld_dgcMMProductionCostCalculationAllocationOthers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProductionCostCalculationAllocationOthers;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // Price
            // 
            this.Price.Controls.Add(this.fld_dgcMMProductionCostCalculationPrices);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(886, 414);
            this.Price.Text = "Giá thành sản xuất";
            // 
            // fld_dgcMMProductionCostCalculationPrices
            // 
            this.fld_dgcMMProductionCostCalculationPrices.AllowDrop = true;
            this.fld_dgcMMProductionCostCalculationPrices.BOSComment = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSDataSource = "MMProductionCostCalculationPrices";
            this.fld_dgcMMProductionCostCalculationPrices.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSError = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculationPrices.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculationPrices.CommodityType = "";
            this.fld_dgcMMProductionCostCalculationPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionCostCalculationPrices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostCalculationPrices.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionCostCalculationPrices.MainView = this.gridView5;
            this.fld_dgcMMProductionCostCalculationPrices.Name = "fld_dgcMMProductionCostCalculationPrices";
            this.fld_dgcMMProductionCostCalculationPrices.PrintReport = false;
            this.fld_dgcMMProductionCostCalculationPrices.Screen = null;
            this.fld_dgcMMProductionCostCalculationPrices.Size = new System.Drawing.Size(886, 414);
            this.fld_dgcMMProductionCostCalculationPrices.TabIndex = 2;
            this.fld_dgcMMProductionCostCalculationPrices.Tag = "DC";
            this.fld_dgcMMProductionCostCalculationPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcMMProductionCostCalculationPrices;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // Statictis
            // 
            this.Statictis.Controls.Add(this.panel1);
            this.Statictis.Name = "Statictis";
            this.Statictis.Size = new System.Drawing.Size(886, 414);
            this.Statictis.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bosLabel12);
            this.panel1.Controls.Add(this.bosLabel13);
            this.panel1.Controls.Add(this.bosLabel14);
            this.panel1.Controls.Add(this.bosLabel16);
            this.panel1.Controls.Add(this.bosTextBox4);
            this.panel1.Controls.Add(this.bosTextBox5);
            this.panel1.Controls.Add(this.bosTextBox6);
            this.panel1.Controls.Add(this.bosTextBox7);
            this.panel1.Controls.Add(this.bosLabel11);
            this.panel1.Controls.Add(this.bosTextBox3);
            this.panel1.Controls.Add(this.bosLabel10);
            this.panel1.Controls.Add(this.bosTextBox2);
            this.panel1.Controls.Add(this.bosLabel9);
            this.panel1.Controls.Add(this.bosTextBox1);
            this.panel1.Controls.Add(this.bosLabel8);
            this.panel1.Controls.Add(this.fld_txtMMProductionCostCalculationTotalBlock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 414);
            this.panel1.TabIndex = 0;
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
            this.bosLabel12.Location = new System.Drawing.Point(398, 100);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(122, 13);
            this.bosLabel12.TabIndex = 30;
            this.bosLabel12.Text = "Tổng SL CD (theo Y/T PB)";
            this.bosLabel12.Visible = false;
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
            this.bosLabel13.Location = new System.Drawing.Point(398, 74);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(70, 13);
            this.bosLabel13.TabIndex = 29;
            this.bosLabel13.Text = "Tổng SL SX CD";
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
            this.bosLabel14.Location = new System.Drawing.Point(398, 48);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(58, 13);
            this.bosLabel14.TabIndex = 28;
            this.bosLabel14.Text = "Tổng m2 CD";
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
            this.bosLabel16.Location = new System.Drawing.Point(398, 22);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(79, 13);
            this.bosLabel16.TabIndex = 27;
            this.bosLabel16.Text = "Tổng m3 tinh CD";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "MMProductionCostCalculationOperationQtyByFactor";
            this.bosTextBox4.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.EditValue = "";
            this.bosTextBox4.Location = new System.Drawing.Point(550, 97);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 26;
            this.bosTextBox4.Tag = "DC";
            this.bosTextBox4.Visible = false;
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = "";
            this.bosTextBox5.BOSDataMember = "MMProductionCostCalculationOperationQty";
            this.bosTextBox5.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = "";
            this.bosTextBox5.BOSFieldRelation = "";
            this.bosTextBox5.BOSPrivilege = "";
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.EditValue = "";
            this.bosTextBox5.Location = new System.Drawing.Point(550, 71);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 24;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = "";
            this.bosTextBox6.BOSDataMember = "MMProductionCostCalculationOperationAcreage";
            this.bosTextBox6.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = "";
            this.bosTextBox6.BOSFieldRelation = "";
            this.bosTextBox6.BOSPrivilege = "";
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.EditValue = "";
            this.bosTextBox6.Location = new System.Drawing.Point(550, 45);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox6.TabIndex = 22;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = "";
            this.bosTextBox7.BOSDataMember = "MMProductionCostCalculationOperationBlock";
            this.bosTextBox7.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = "";
            this.bosTextBox7.BOSFieldRelation = "";
            this.bosTextBox7.BOSPrivilege = "";
            this.bosTextBox7.BOSPropertyName = "Text";
            this.bosTextBox7.EditValue = "";
            this.bosTextBox7.Location = new System.Drawing.Point(550, 19);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox7.TabIndex = 20;
            this.bosTextBox7.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(12, 100);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(149, 13);
            this.bosLabel11.TabIndex = 19;
            this.bosLabel11.Text = "Tổng SL nhà máy (theo Y/T PB)";
            this.bosLabel11.Visible = false;
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "MMProductionCostCalculationTotalQtyByFactor";
            this.bosTextBox3.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.EditValue = "";
            this.bosTextBox3.Location = new System.Drawing.Point(174, 97);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 18;
            this.bosTextBox3.Tag = "DC";
            this.bosTextBox3.Visible = false;
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 74);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(97, 13);
            this.bosLabel10.TabIndex = 17;
            this.bosLabel10.Text = "Tổng SL SX nhà máy";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMProductionCostCalculationTotalQty";
            this.bosTextBox2.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(174, 71);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 16;
            this.bosTextBox2.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(12, 48);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 15;
            this.bosLabel9.Text = "Tổng m2 nhà máy";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMProductionCostCalculationTotalAcreage";
            this.bosTextBox1.BOSDataSource = "MMProductionCostCalculations";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(174, 45);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 14;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 22);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(106, 13);
            this.bosLabel8.TabIndex = 13;
            this.bosLabel8.Text = "Tổng m3 tinh nhà máy";
            // 
            // fld_txtMMProductionCostCalculationTotalBlock
            // 
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSComment = "";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSDataMember = "MMProductionCostCalculationTotalBlock";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSDataSource = "MMProductionCostCalculations";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSDescription = null;
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSError = null;
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSFieldGroup = "";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSFieldRelation = "";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSPrivilege = "";
            this.fld_txtMMProductionCostCalculationTotalBlock.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostCalculationTotalBlock.EditValue = "";
            this.fld_txtMMProductionCostCalculationTotalBlock.Location = new System.Drawing.Point(174, 19);
            this.fld_txtMMProductionCostCalculationTotalBlock.Name = "fld_txtMMProductionCostCalculationTotalBlock";
            this.fld_txtMMProductionCostCalculationTotalBlock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostCalculationTotalBlock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostCalculationTotalBlock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostCalculationTotalBlock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostCalculationTotalBlock.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostCalculationTotalBlock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostCalculationTotalBlock.Screen = null;
            this.fld_txtMMProductionCostCalculationTotalBlock.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostCalculationTotalBlock.TabIndex = 12;
            this.fld_txtMMProductionCostCalculationTotalBlock.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(17, 93);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 84;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_dteMMProductionCostCalculationDate
            // 
            this.fld_dteMMProductionCostCalculationDate.BOSComment = null;
            this.fld_dteMMProductionCostCalculationDate.BOSDataMember = "MMProductionCostCalculationDate";
            this.fld_dteMMProductionCostCalculationDate.BOSDataSource = "MMProductionCostCalculations";
            this.fld_dteMMProductionCostCalculationDate.BOSDescription = null;
            this.fld_dteMMProductionCostCalculationDate.BOSError = null;
            this.fld_dteMMProductionCostCalculationDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostCalculationDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostCalculationDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostCalculationDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostCalculationDate.EditValue = null;
            this.fld_dteMMProductionCostCalculationDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteMMProductionCostCalculationDate.Name = "fld_dteMMProductionCostCalculationDate";
            this.fld_dteMMProductionCostCalculationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostCalculationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostCalculationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostCalculationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostCalculationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostCalculationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostCalculationDate.Screen = null;
            this.fld_dteMMProductionCostCalculationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostCalculationDate.TabIndex = 1;
            this.fld_dteMMProductionCostCalculationDate.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(17, 118);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_medMMProductionCostCalculationDesc
            // 
            this.fld_medMMProductionCostCalculationDesc.BOSComment = "";
            this.fld_medMMProductionCostCalculationDesc.BOSDataMember = "MMProductionCostCalculationDesc";
            this.fld_medMMProductionCostCalculationDesc.BOSDataSource = "MMProductionCostCalculations";
            this.fld_medMMProductionCostCalculationDesc.BOSDescription = null;
            this.fld_medMMProductionCostCalculationDesc.BOSError = null;
            this.fld_medMMProductionCostCalculationDesc.BOSFieldGroup = "";
            this.fld_medMMProductionCostCalculationDesc.BOSFieldRelation = "";
            this.fld_medMMProductionCostCalculationDesc.BOSPrivilege = "";
            this.fld_medMMProductionCostCalculationDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionCostCalculationDesc.EditValue = "";
            this.fld_medMMProductionCostCalculationDesc.Location = new System.Drawing.Point(101, 116);
            this.fld_medMMProductionCostCalculationDesc.Name = "fld_medMMProductionCostCalculationDesc";
            this.fld_medMMProductionCostCalculationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionCostCalculationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionCostCalculationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionCostCalculationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionCostCalculationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionCostCalculationDesc, true);
            this.fld_medMMProductionCostCalculationDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medMMProductionCostCalculationDesc.TabIndex = 7;
            this.fld_medMMProductionCostCalculationDesc.Tag = "DC";
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
            // fld_txtMMProductionCostCalculationNo
            // 
            this.fld_txtMMProductionCostCalculationNo.BOSComment = "";
            this.fld_txtMMProductionCostCalculationNo.BOSDataMember = "MMProductionCostCalculationNo";
            this.fld_txtMMProductionCostCalculationNo.BOSDataSource = "MMProductionCostCalculations";
            this.fld_txtMMProductionCostCalculationNo.BOSDescription = null;
            this.fld_txtMMProductionCostCalculationNo.BOSError = null;
            this.fld_txtMMProductionCostCalculationNo.BOSFieldGroup = "";
            this.fld_txtMMProductionCostCalculationNo.BOSFieldRelation = "";
            this.fld_txtMMProductionCostCalculationNo.BOSPrivilege = "";
            this.fld_txtMMProductionCostCalculationNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostCalculationNo.EditValue = "";
            this.fld_txtMMProductionCostCalculationNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtMMProductionCostCalculationNo.Name = "fld_txtMMProductionCostCalculationNo";
            this.fld_txtMMProductionCostCalculationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostCalculationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostCalculationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostCalculationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostCalculationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostCalculationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostCalculationNo.Screen = null;
            this.fld_txtMMProductionCostCalculationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostCalculationNo.TabIndex = 0;
            this.fld_txtMMProductionCostCalculationNo.Tag = "DC";
            // 
            // DMPCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(904, 616);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPCC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostCalculationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.Cost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationDetailCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ReceiptItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Allocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.OtherAllocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationAllocationOthers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.Price.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculationPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.Statictis.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationTotalBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostCalculationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostCalculationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostCalculationNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMProductionCostCalculationDesc;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostCalculationDate;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostCalculationFromDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostCalculationToDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage Cost;
        private MMProductionCostCalculationDetailCostsGridControl fld_dgcMMProductionCostCalculationDetailCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;

        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionCostFormulaID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSButton fld_btnLoadFeeByFactor;
        private DevExpress.XtraTab.XtraTabPage ReceiptItem;
        private DevExpress.XtraTab.XtraTabPage Allocation;
        private DevExpress.XtraTab.XtraTabPage OtherAllocation;
        private MMProductionCostCalculationItemsGridControl fld_dgcMMProductionCostCalculationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MMProductionCostCalculationAllocationsGridControl fld_dgcMMProductionCostCalculationAllocations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private MMProductionCostCalculationAllocationOthersGridControl fld_dgcMMProductionCostCalculationAllocationOthers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage Price;
        private MMProductionCostCalculationPricesGridControl fld_dgcMMProductionCostCalculationPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionCostCalculationStatus;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraTab.XtraTabPage Statictis;
        private Panel panel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostCalculationTotalBlock;
		private BOSComponent.BOSTextBox bosTextBox4;
		private BOSComponent.BOSTextBox bosTextBox5;
		private BOSComponent.BOSTextBox bosTextBox6;
		private BOSComponent.BOSTextBox bosTextBox7;
		private BOSComponent.BOSLabel bosLabel11;
		private BOSComponent.BOSTextBox bosTextBox3;
		private BOSComponent.BOSLabel bosLabel10;
		private BOSComponent.BOSTextBox bosTextBox2;
		private BOSComponent.BOSLabel bosLabel9;
		private BOSComponent.BOSTextBox bosTextBox1;
		private BOSComponent.BOSLabel bosLabel12;
		private BOSComponent.BOSLabel bosLabel13;
		private BOSComponent.BOSLabel bosLabel14;
		private BOSComponent.BOSLabel bosLabel16;
	}
}
