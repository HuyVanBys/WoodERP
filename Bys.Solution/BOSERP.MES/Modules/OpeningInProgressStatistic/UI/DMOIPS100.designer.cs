using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OpeningInProgressStatistic.UI
{
	/// <summary>
	/// Summary description for DMOIPS100
	/// </summary>
	partial class DMOIPS100
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
            this.fld_lkeFK_MMProductionCostFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMInProgressStatisticToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMInProgressStatisticFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMInProgressStatisticDetails = new BOSERP.Modules.OpeningInProgressStatistic.MMInProgressStatisticDetailsGridControl();
            this.fld_dteMMInProgressStatisticDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMInProgressStatisticDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMInProgressStatisticNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMInProgressStatisticDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMInProgressStatisticDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMInProgressStatisticNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionCostFormulaID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_dteMMInProgressStatisticToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteMMInProgressStatisticFromDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_dteMMInProgressStatisticDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medMMInProgressStatisticDesc);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtMMInProgressStatisticNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_MMProductionCostFormulaID
            // 
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSComment = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataMember = "FK_MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDescription = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSError = string.Empty;
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
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFormulaNo", "Mã chứng từ")});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.DisplayMember = "MMProductionCostFormulaNo";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.NullText = string.Empty;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.ValueMember = "MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.Screen = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMProductionCostFormulaID.TabIndex = 2;
            this.fld_lkeFK_MMProductionCostFormulaID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = string.Empty;
            this.bosLabel9.BOSDataSource = string.Empty;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = string.Empty;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(17, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(26, 13);
            this.bosLabel9.TabIndex = 599;
            this.bosLabel9.Text = "CTTG";
            // 
            // fld_dteMMInProgressStatisticToDate
            // 
            this.fld_dteMMInProgressStatisticToDate.BOSComment = null;
            this.fld_dteMMInProgressStatisticToDate.BOSDataMember = "MMInProgressStatisticToDate";
            this.fld_dteMMInProgressStatisticToDate.BOSDataSource = "MMInProgressStatistics";
            this.fld_dteMMInProgressStatisticToDate.BOSDescription = null;
            this.fld_dteMMInProgressStatisticToDate.BOSError = null;
            this.fld_dteMMInProgressStatisticToDate.BOSFieldGroup = null;
            this.fld_dteMMInProgressStatisticToDate.BOSFieldRelation = null;
            this.fld_dteMMInProgressStatisticToDate.BOSPrivilege = null;
            this.fld_dteMMInProgressStatisticToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMInProgressStatisticToDate.EditValue = null;
            this.fld_dteMMInProgressStatisticToDate.Location = new System.Drawing.Point(370, 116);
            this.fld_dteMMInProgressStatisticToDate.Name = "fld_dteMMInProgressStatisticToDate";
            this.fld_dteMMInProgressStatisticToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMInProgressStatisticToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMInProgressStatisticToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMInProgressStatisticToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMInProgressStatisticToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMInProgressStatisticToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMInProgressStatisticToDate.Screen = null;
            this.fld_dteMMInProgressStatisticToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMInProgressStatisticToDate.TabIndex = 8;
            this.fld_dteMMInProgressStatisticToDate.Tag = "DC";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = string.Empty;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = string.Empty;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(370, 90);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Phân xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = string.Empty;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMWorkShopID, true);
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 6;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(281, 119);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 86;
            this.bosLabel6.Text = "Đến ngày";
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
            this.bosLabel7.Location = new System.Drawing.Point(281, 93);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(58, 13);
            this.bosLabel7.TabIndex = 597;
            this.bosLabel7.Text = "Phân xưởng";
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
            this.bosLabel5.Location = new System.Drawing.Point(17, 119);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 84;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_dteMMInProgressStatisticFromDate
            // 
            this.fld_dteMMInProgressStatisticFromDate.BOSComment = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSDataMember = "MMInProgressStatisticFromDate";
            this.fld_dteMMInProgressStatisticFromDate.BOSDataSource = "MMInProgressStatistics";
            this.fld_dteMMInProgressStatisticFromDate.BOSDescription = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSError = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSFieldGroup = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSFieldRelation = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSPrivilege = null;
            this.fld_dteMMInProgressStatisticFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMInProgressStatisticFromDate.EditValue = null;
            this.fld_dteMMInProgressStatisticFromDate.Location = new System.Drawing.Point(101, 116);
            this.fld_dteMMInProgressStatisticFromDate.Name = "fld_dteMMInProgressStatisticFromDate";
            this.fld_dteMMInProgressStatisticFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMInProgressStatisticFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMInProgressStatisticFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMInProgressStatisticFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMInProgressStatisticFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMInProgressStatisticFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMInProgressStatisticFromDate.Screen = null;
            this.fld_dteMMInProgressStatisticFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMInProgressStatisticFromDate.TabIndex = 7;
            this.fld_dteMMInProgressStatisticFromDate.Tag = "DC";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = null;
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(370, 64);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã Sale order"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderPONo", "Số PO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderPODate", "Ngày PO")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 4;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(281, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(68, 13);
            this.bosLabel4.TabIndex = 595;
            this.bosLabel4.Text = "Đơn bán hàng";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = string.Empty;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(101, 90);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = string.Empty;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 5;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(17, 93);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(43, 13);
            this.bosLabel21.TabIndex = 593;
            this.bosLabel21.Text = "Xí nghiệp";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMInProgressStatistics";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = string.Empty;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(101, 64);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = string.Empty;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 3;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = string.Empty;
            this.bosLabel8.BOSDataSource = string.Empty;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = string.Empty;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(17, 67);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(68, 13);
            this.bosLabel8.TabIndex = 554;
            this.bosLabel8.Text = "Lệnh sản xuất";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 191);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(856, 373);
            this.bosTabControl1.TabIndex = 5;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMInProgressStatisticDetails);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 344);
            this.xtraTabPage1.Text = "Chi tiết";
            // 
            // fld_dgcMMInProgressStatisticDetails
            // 
            this.fld_dgcMMInProgressStatisticDetails.BOSComment = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSDataMember = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSDataSource = "MMInProgressStatisticDetails";
            this.fld_dgcMMInProgressStatisticDetails.BOSDescription = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSError = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSFieldGroup = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSFieldRelation = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSGridType = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSPrivilege = null;
            this.fld_dgcMMInProgressStatisticDetails.BOSPropertyName = null;
            this.fld_dgcMMInProgressStatisticDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMInProgressStatisticDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMInProgressStatisticDetails.MenuManager = this.screenToolbar;
            this.fld_dgcMMInProgressStatisticDetails.Name = "fld_dgcMMInProgressStatisticDetails";
            this.fld_dgcMMInProgressStatisticDetails.PrintReport = false;
            this.fld_dgcMMInProgressStatisticDetails.Screen = null;
            this.fld_dgcMMInProgressStatisticDetails.Size = new System.Drawing.Size(849, 344);
            this.fld_dgcMMInProgressStatisticDetails.TabIndex = 95;
            // 
            // fld_dteMMInProgressStatisticDate
            // 
            this.fld_dteMMInProgressStatisticDate.BOSComment = null;
            this.fld_dteMMInProgressStatisticDate.BOSDataMember = "MMInProgressStatisticDate";
            this.fld_dteMMInProgressStatisticDate.BOSDataSource = "MMInProgressStatistics";
            this.fld_dteMMInProgressStatisticDate.BOSDescription = null;
            this.fld_dteMMInProgressStatisticDate.BOSError = null;
            this.fld_dteMMInProgressStatisticDate.BOSFieldGroup = null;
            this.fld_dteMMInProgressStatisticDate.BOSFieldRelation = null;
            this.fld_dteMMInProgressStatisticDate.BOSPrivilege = null;
            this.fld_dteMMInProgressStatisticDate.BOSPropertyName = "EditValue";
            this.fld_dteMMInProgressStatisticDate.EditValue = null;
            this.fld_dteMMInProgressStatisticDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteMMInProgressStatisticDate.Name = "fld_dteMMInProgressStatisticDate";
            this.fld_dteMMInProgressStatisticDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMInProgressStatisticDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMInProgressStatisticDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMInProgressStatisticDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMInProgressStatisticDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMInProgressStatisticDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMInProgressStatisticDate.Screen = null;
            this.fld_dteMMInProgressStatisticDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMInProgressStatisticDate.TabIndex = 1;
            this.fld_dteMMInProgressStatisticDate.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(17, 145);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_medMMInProgressStatisticDesc
            // 
            this.fld_medMMInProgressStatisticDesc.BOSComment = string.Empty;
            this.fld_medMMInProgressStatisticDesc.BOSDataMember = "MMInProgressStatisticDesc";
            this.fld_medMMInProgressStatisticDesc.BOSDataSource = "MMInProgressStatistics";
            this.fld_medMMInProgressStatisticDesc.BOSDescription = null;
            this.fld_medMMInProgressStatisticDesc.BOSError = null;
            this.fld_medMMInProgressStatisticDesc.BOSFieldGroup = string.Empty;
            this.fld_medMMInProgressStatisticDesc.BOSFieldRelation = string.Empty;
            this.fld_medMMInProgressStatisticDesc.BOSPrivilege = string.Empty;
            this.fld_medMMInProgressStatisticDesc.BOSPropertyName = "EditValue";
            this.fld_medMMInProgressStatisticDesc.EditValue = string.Empty;
            this.fld_medMMInProgressStatisticDesc.Location = new System.Drawing.Point(101, 142);
            this.fld_medMMInProgressStatisticDesc.Name = "fld_medMMInProgressStatisticDesc";
            this.fld_medMMInProgressStatisticDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMInProgressStatisticDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMInProgressStatisticDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMInProgressStatisticDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMInProgressStatisticDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMInProgressStatisticDesc, true);
            this.fld_medMMInProgressStatisticDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medMMInProgressStatisticDesc.TabIndex = 9;
            this.fld_medMMInProgressStatisticDesc.Tag = "DC";
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
            // fld_txtMMInProgressStatisticNo
            // 
            this.fld_txtMMInProgressStatisticNo.BOSComment = string.Empty;
            this.fld_txtMMInProgressStatisticNo.BOSDataMember = "MMInProgressStatisticNo";
            this.fld_txtMMInProgressStatisticNo.BOSDataSource = "MMInProgressStatistics";
            this.fld_txtMMInProgressStatisticNo.BOSDescription = null;
            this.fld_txtMMInProgressStatisticNo.BOSError = null;
            this.fld_txtMMInProgressStatisticNo.BOSFieldGroup = string.Empty;
            this.fld_txtMMInProgressStatisticNo.BOSFieldRelation = string.Empty;
            this.fld_txtMMInProgressStatisticNo.BOSPrivilege = string.Empty;
            this.fld_txtMMInProgressStatisticNo.BOSPropertyName = "Text";
            this.fld_txtMMInProgressStatisticNo.EditValue = string.Empty;
            this.fld_txtMMInProgressStatisticNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtMMInProgressStatisticNo.Name = "fld_txtMMInProgressStatisticNo";
            this.fld_txtMMInProgressStatisticNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMInProgressStatisticNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMInProgressStatisticNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMInProgressStatisticNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMInProgressStatisticNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMInProgressStatisticNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMInProgressStatisticNo.Screen = null;
            this.fld_txtMMInProgressStatisticNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMInProgressStatisticNo.TabIndex = 0;
            this.fld_txtMMInProgressStatisticNo.Tag = "DC";
            // 
            // DMOIPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMOIPS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMInProgressStatisticDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMInProgressStatisticDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMInProgressStatisticDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMInProgressStatisticNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMInProgressStatisticNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMInProgressStatisticDesc;
        private BOSComponent.BOSDateEdit fld_dteMMInProgressStatisticDate;
        private BOSComponent.BOSDateEdit fld_dteMMInProgressStatisticFromDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMInProgressStatisticToDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel7;
        private MMInProgressStatisticDetailsGridControl fld_dgcMMInProgressStatisticDetails;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionCostFormulaID;
        private BOSComponent.BOSLabel bosLabel9;
	}
}
