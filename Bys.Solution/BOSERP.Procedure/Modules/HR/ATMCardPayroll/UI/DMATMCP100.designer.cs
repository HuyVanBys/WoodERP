using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ATMCardPayroll.UI
{
    /// <summary>
    /// Summary description for DMATMCM100
    /// </summary>
    partial class DMATMCP100
    {
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSTextBox fld_txtHRATMCardPayrollName;
        private BOSComponent.BOSMemoEdit fld_medHRATMCardPayrollDesc;
        private HREmployeeATMCardPayrollsGridControl fld_dgcHREmployeeATMCardPayrolls;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeATMCardPayrolls;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMATMCP100));
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRATMCardPayrollName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRATMCardPayrollDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgcHREmployeeATMCardPayrolls = new BOSERP.Modules.ATMCardPayroll.HREmployeeATMCardPayrollsGridControl();
            this.fld_dgvHREmployeeATMCardPayrolls = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRATMCardPayrollDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRATMCardPayrollNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRATMCardPayrollStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRPayrollID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRATMCardPayrollMonthDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRATMCardPayrollBankCN = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRATMCardPayrollDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeATMCardPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeATMCardPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRATMCardPayrollStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRPayrollID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollMonthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollMonthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollBankCN.Properties)).BeginInit();
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
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = null;
            this.fld_lblLabel5.BOSDataMember = null;
            this.fld_lblLabel5.BOSDataSource = null;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = null;
            this.fld_lblLabel5.BOSFieldRelation = null;
            this.fld_lblLabel5.BOSPrivilege = null;
            this.fld_lblLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel5, "fld_lblLabel5");
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel5, ((bool)(resources.GetObject("fld_lblLabel5.ShowHelp"))));
            // 
            // fld_txtHRATMCardPayrollName
            // 
            this.fld_txtHRATMCardPayrollName.BOSComment = null;
            this.fld_txtHRATMCardPayrollName.BOSDataMember = "HRATMCardPayrollName";
            this.fld_txtHRATMCardPayrollName.BOSDataSource = "HRATMCardPayrolls";
            this.fld_txtHRATMCardPayrollName.BOSDescription = null;
            this.fld_txtHRATMCardPayrollName.BOSError = null;
            this.fld_txtHRATMCardPayrollName.BOSFieldGroup = null;
            this.fld_txtHRATMCardPayrollName.BOSFieldRelation = null;
            this.fld_txtHRATMCardPayrollName.BOSPrivilege = null;
            this.fld_txtHRATMCardPayrollName.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRATMCardPayrollName, "fld_txtHRATMCardPayrollName");
            this.fld_txtHRATMCardPayrollName.Name = "fld_txtHRATMCardPayrollName";
            this.fld_txtHRATMCardPayrollName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRATMCardPayrollName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRATMCardPayrollName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRATMCardPayrollName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRATMCardPayrollName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRATMCardPayrollName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRATMCardPayrollName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardPayrollName, ((bool)(resources.GetObject("fld_txtHRATMCardPayrollName.ShowHelp"))));
            this.fld_txtHRATMCardPayrollName.Tag = "DC";
            // 
            // fld_medHRATMCardPayrollDesc
            // 
            this.fld_medHRATMCardPayrollDesc.BOSComment = null;
            this.fld_medHRATMCardPayrollDesc.BOSDataMember = "HRATMCardPayrollDesc";
            this.fld_medHRATMCardPayrollDesc.BOSDataSource = "HRATMCardPayrolls";
            this.fld_medHRATMCardPayrollDesc.BOSDescription = null;
            this.fld_medHRATMCardPayrollDesc.BOSError = null;
            this.fld_medHRATMCardPayrollDesc.BOSFieldGroup = null;
            this.fld_medHRATMCardPayrollDesc.BOSFieldRelation = null;
            this.fld_medHRATMCardPayrollDesc.BOSPrivilege = null;
            this.fld_medHRATMCardPayrollDesc.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_medHRATMCardPayrollDesc, "fld_medHRATMCardPayrollDesc");
            this.fld_medHRATMCardPayrollDesc.Name = "fld_medHRATMCardPayrollDesc";
            this.fld_medHRATMCardPayrollDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRATMCardPayrollDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRATMCardPayrollDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRATMCardPayrollDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRATMCardPayrollDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRATMCardPayrollDesc, ((bool)(resources.GetObject("fld_medHRATMCardPayrollDesc.ShowHelp"))));
            this.fld_medHRATMCardPayrollDesc.Tag = "DC";
            this.fld_medHRATMCardPayrollDesc.Validated += new System.EventHandler(this.Fld_medHRATMCardPayrollDesc_Validated);
            // 
            // fld_dgcHREmployeeATMCardPayrolls
            // 
            this.fld_dgcHREmployeeATMCardPayrolls.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHREmployeeATMCardPayrolls, "fld_dgcHREmployeeATMCardPayrolls");
            this.fld_dgcHREmployeeATMCardPayrolls.BOSComment = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSDataMember = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSDataSource = "HREmployeeATMCardPayrolls";
            this.fld_dgcHREmployeeATMCardPayrolls.BOSDescription = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSError = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSFieldGroup = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSFieldRelation = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSGridType = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSPrivilege = null;
            this.fld_dgcHREmployeeATMCardPayrolls.BOSPropertyName = null;
            this.fld_dgcHREmployeeATMCardPayrolls.CommodityType = "";
            this.fld_dgcHREmployeeATMCardPayrolls.MainView = this.fld_dgvHREmployeeATMCardPayrolls;
            this.fld_dgcHREmployeeATMCardPayrolls.Name = "fld_dgcHREmployeeATMCardPayrolls";
            this.fld_dgcHREmployeeATMCardPayrolls.PrintReport = false;
            this.fld_dgcHREmployeeATMCardPayrolls.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeATMCardPayrolls, ((bool)(resources.GetObject("fld_dgcHREmployeeATMCardPayrolls.ShowHelp"))));
            this.fld_dgcHREmployeeATMCardPayrolls.Tag = "DC";
            this.fld_dgcHREmployeeATMCardPayrolls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeATMCardPayrolls});
            // 
            // fld_dgvHREmployeeATMCardPayrolls
            // 
            this.fld_dgvHREmployeeATMCardPayrolls.GridControl = this.fld_dgcHREmployeeATMCardPayrolls;
            this.fld_dgvHREmployeeATMCardPayrolls.Name = "fld_dgvHREmployeeATMCardPayrolls";
            this.fld_dgvHREmployeeATMCardPayrolls.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // fld_dteHRATMCardPayrollDate
            // 
            this.fld_dteHRATMCardPayrollDate.BOSComment = null;
            this.fld_dteHRATMCardPayrollDate.BOSDataMember = "HRATMCardPayrollDate";
            this.fld_dteHRATMCardPayrollDate.BOSDataSource = "HRATMCardPayrolls";
            this.fld_dteHRATMCardPayrollDate.BOSDescription = null;
            this.fld_dteHRATMCardPayrollDate.BOSError = null;
            this.fld_dteHRATMCardPayrollDate.BOSFieldGroup = null;
            this.fld_dteHRATMCardPayrollDate.BOSFieldRelation = null;
            this.fld_dteHRATMCardPayrollDate.BOSPrivilege = null;
            this.fld_dteHRATMCardPayrollDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHRATMCardPayrollDate, "fld_dteHRATMCardPayrollDate");
            this.fld_dteHRATMCardPayrollDate.Name = "fld_dteHRATMCardPayrollDate";
            this.fld_dteHRATMCardPayrollDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRATMCardPayrollDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRATMCardPayrollDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRATMCardPayrollDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRATMCardPayrollDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRATMCardPayrollDate.Properties.Buttons"))))});
            this.fld_dteHRATMCardPayrollDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRATMCardPayrollDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHRATMCardPayrollDate, ((bool)(resources.GetObject("fld_dteHRATMCardPayrollDate.ShowHelp"))));
            this.fld_dteHRATMCardPayrollDate.Tag = "DC";
            // 
            // fld_txtHRATMCardPayrollNo
            // 
            this.fld_txtHRATMCardPayrollNo.BOSComment = null;
            this.fld_txtHRATMCardPayrollNo.BOSDataMember = "HRATMCardPayrollNo";
            this.fld_txtHRATMCardPayrollNo.BOSDataSource = "HRATMCardPayrolls";
            this.fld_txtHRATMCardPayrollNo.BOSDescription = null;
            this.fld_txtHRATMCardPayrollNo.BOSError = null;
            this.fld_txtHRATMCardPayrollNo.BOSFieldGroup = null;
            this.fld_txtHRATMCardPayrollNo.BOSFieldRelation = null;
            this.fld_txtHRATMCardPayrollNo.BOSPrivilege = null;
            this.fld_txtHRATMCardPayrollNo.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRATMCardPayrollNo, "fld_txtHRATMCardPayrollNo");
            this.fld_txtHRATMCardPayrollNo.Name = "fld_txtHRATMCardPayrollNo";
            this.fld_txtHRATMCardPayrollNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRATMCardPayrollNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRATMCardPayrollNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRATMCardPayrollNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRATMCardPayrollNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRATMCardPayrollNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRATMCardPayrollNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardPayrollNo, ((bool)(resources.GetObject("fld_txtHRATMCardPayrollNo.ShowHelp"))));
            this.fld_txtHRATMCardPayrollNo.Tag = "DC";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel10, "fld_lblLabel10");
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, ((bool)(resources.GetObject("fld_lblLabel10.ShowHelp"))));
            // 
            // fld_lkeHRATMCardPayrollStatus
            // 
            this.fld_lkeHRATMCardPayrollStatus.BOSAllowAddNew = false;
            this.fld_lkeHRATMCardPayrollStatus.BOSAllowDummy = false;
            this.fld_lkeHRATMCardPayrollStatus.BOSComment = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSDataMember = "HRATMCardPayrollStatus";
            this.fld_lkeHRATMCardPayrollStatus.BOSDataSource = "HRATMCardPayrolls";
            this.fld_lkeHRATMCardPayrollStatus.BOSDescription = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSError = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSFieldGroup = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSFieldParent = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSFieldRelation = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSPrivilege = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRATMCardPayrollStatus.BOSSelectType = null;
            this.fld_lkeHRATMCardPayrollStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRATMCardPayrollStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHRATMCardPayrollStatus, "fld_lkeHRATMCardPayrollStatus");
            this.fld_lkeHRATMCardPayrollStatus.Name = "fld_lkeHRATMCardPayrollStatus";
            this.fld_lkeHRATMCardPayrollStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRATMCardPayrollStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRATMCardPayrollStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRATMCardPayrollStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRATMCardPayrollStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHRATMCardPayrollStatus.Properties.Buttons"))))});
            this.fld_lkeHRATMCardPayrollStatus.Properties.ColumnName = null;
            this.fld_lkeHRATMCardPayrollStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeHRATMCardPayrollStatus.Properties.Columns"), resources.GetString("fld_lkeHRATMCardPayrollStatus.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeHRATMCardPayrollStatus.Properties.Columns2"), resources.GetString("fld_lkeHRATMCardPayrollStatus.Properties.Columns3"))});
            this.fld_lkeHRATMCardPayrollStatus.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeHRATMCardPayrollStatus.Properties.NullText = resources.GetString("fld_lkeHRATMCardPayrollStatus.Properties.NullText");
            this.fld_lkeHRATMCardPayrollStatus.Properties.ReadOnly = true;
            this.fld_lkeHRATMCardPayrollStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRATMCardPayrollStatus.Properties.ValueMember = "BRBranchID";
            this.fld_lkeHRATMCardPayrollStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRATMCardPayrollStatus, ((bool)(resources.GetObject("fld_lkeHRATMCardPayrollStatus.ShowHelp"))));
            this.fld_lkeHRATMCardPayrollStatus.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            resources.ApplyResources(this.bosGroupControl2, "bosGroupControl2");
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_btnAddEmployee);
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeATMCardPayrolls);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, ((bool)(resources.GetObject("bosGroupControl2.ShowHelp"))));
            // 
            // fld_btnAddEmployee
            // 
            resources.ApplyResources(this.fld_btnAddEmployee, "fld_btnAddEmployee");
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.Fld_btnAddEmployee_Click);
            // 
            // bosPanel1
            // 
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_txtHRATMCardPayrollBankCN);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRPayrollID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Controls.Add(this.fld_dteHRATMCardPayrollMonthDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteHRATMCardPayrollDate);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_txtHRATMCardPayrollNo);
            this.bosPanel1.Controls.Add(this.fld_medHRATMCardPayrollDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeHRATMCardPayrollStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRATMCardPayrollName);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            this.bosLabel4.Tag = "";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            this.bosLabel3.Tag = "";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "HRATMCardPayrolls";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = "";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_CSCompanyBankID, "fld_lkeFK_CSCompanyBankID");
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_CSCompanyBankID.Properties.Buttons"))))});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns"), resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns2"), resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns3"))});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.NullText");
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCompanyBankID, ((bool)(resources.GetObject("fld_lkeFK_CSCompanyBankID.ShowHelp"))));
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Tag = "";
            // 
            // fld_lkeFK_HRPayrollID
            // 
            this.fld_lkeFK_HRPayrollID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRPayrollID.BOSAllowDummy = false;
            this.fld_lkeFK_HRPayrollID.BOSComment = "";
            this.fld_lkeFK_HRPayrollID.BOSDataMember = "FK_HRPayrollID";
            this.fld_lkeFK_HRPayrollID.BOSDataSource = "HRATMCardPayrolls";
            this.fld_lkeFK_HRPayrollID.BOSDescription = null;
            this.fld_lkeFK_HRPayrollID.BOSError = null;
            this.fld_lkeFK_HRPayrollID.BOSFieldGroup = "";
            this.fld_lkeFK_HRPayrollID.BOSFieldParent = "";
            this.fld_lkeFK_HRPayrollID.BOSFieldRelation = "";
            this.fld_lkeFK_HRPayrollID.BOSPrivilege = "";
            this.fld_lkeFK_HRPayrollID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRPayrollID.BOSSelectType = "";
            this.fld_lkeFK_HRPayrollID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRPayrollID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRPayrollID, "fld_lkeFK_HRPayrollID");
            this.fld_lkeFK_HRPayrollID.Name = "fld_lkeFK_HRPayrollID";
            this.fld_lkeFK_HRPayrollID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRPayrollID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRPayrollID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRPayrollID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRPayrollID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRPayrollID.Properties.Buttons"))))});
            this.fld_lkeFK_HRPayrollID.Properties.ColumnName = null;
            this.fld_lkeFK_HRPayrollID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRPayrollID.Properties.Columns"), resources.GetString("fld_lkeFK_HRPayrollID.Properties.Columns1"))});
            this.fld_lkeFK_HRPayrollID.Properties.DisplayMember = "HRPayRollNo";
            this.fld_lkeFK_HRPayrollID.Properties.NullText = resources.GetString("fld_lkeFK_HRPayrollID.Properties.NullText");
            this.fld_lkeFK_HRPayrollID.Properties.ReadOnly = true;
            this.fld_lkeFK_HRPayrollID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRPayrollID.Properties.ValueMember = "HRPayRollID";
            this.fld_lkeFK_HRPayrollID.Screen = null;
            this.fld_lkeFK_HRPayrollID.Tag = "DC";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            resources.ApplyResources(this.fld_lblLabel9, "fld_lblLabel9");
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Tag = "";
            // 
            // fld_dteHRATMCardPayrollMonthDate
            // 
            this.fld_dteHRATMCardPayrollMonthDate.BOSComment = "";
            this.fld_dteHRATMCardPayrollMonthDate.BOSDataMember = "HRATMCardPayrollMonthDate";
            this.fld_dteHRATMCardPayrollMonthDate.BOSDataSource = "HRATMCardPayrolls";
            this.fld_dteHRATMCardPayrollMonthDate.BOSDescription = null;
            this.fld_dteHRATMCardPayrollMonthDate.BOSError = null;
            this.fld_dteHRATMCardPayrollMonthDate.BOSFieldGroup = "";
            this.fld_dteHRATMCardPayrollMonthDate.BOSFieldRelation = "";
            this.fld_dteHRATMCardPayrollMonthDate.BOSPrivilege = "";
            this.fld_dteHRATMCardPayrollMonthDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHRATMCardPayrollMonthDate, "fld_dteHRATMCardPayrollMonthDate");
            this.fld_dteHRATMCardPayrollMonthDate.Name = "fld_dteHRATMCardPayrollMonthDate";
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRATMCardPayrollMonthDate.Properties.Buttons"))))});
            this.fld_dteHRATMCardPayrollMonthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRATMCardPayrollMonthDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRATMCardPayrollMonthDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRATMCardPayrollMonthDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRATMCardPayrollMonthDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRATMCardPayrollMonthDate.Properties.Mask.EditMask = resources.GetString("fld_dteHRATMCardPayrollMonthDate.Properties.Mask.EditMask");
            this.fld_dteHRATMCardPayrollMonthDate.Properties.ReadOnly = true;
            this.fld_dteHRATMCardPayrollMonthDate.Screen = null;
            this.fld_dteHRATMCardPayrollMonthDate.Tag = "DC";
            // 
            // fld_txtHRATMCardPayrollBankCN
            // 
            this.fld_txtHRATMCardPayrollBankCN.BOSComment = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSDataMember = "HRATMCardPayrollBankCN";
            this.fld_txtHRATMCardPayrollBankCN.BOSDataSource = "HRATMCardPayrolls";
            this.fld_txtHRATMCardPayrollBankCN.BOSDescription = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSError = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSFieldGroup = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSFieldRelation = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSPrivilege = null;
            this.fld_txtHRATMCardPayrollBankCN.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRATMCardPayrollBankCN, "fld_txtHRATMCardPayrollBankCN");
            this.fld_txtHRATMCardPayrollBankCN.Name = "fld_txtHRATMCardPayrollBankCN";
            this.fld_txtHRATMCardPayrollBankCN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRATMCardPayrollBankCN.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRATMCardPayrollBankCN.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRATMCardPayrollBankCN.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRATMCardPayrollBankCN.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRATMCardPayrollBankCN.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardPayrollBankCN, ((bool)(resources.GetObject("fld_txtHRATMCardPayrollBankCN.ShowHelp"))));
            this.fld_txtHRATMCardPayrollBankCN.Tag = "DC";
            this.fld_txtHRATMCardPayrollBankCN.Validated += new System.EventHandler(this.fld_txtHRATMCardPayrollBankCN_Validated);
            // 
            // DMATMCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMATMCP100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRATMCardPayrollDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeATMCardPayrolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeATMCardPayrolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRATMCardPayrollStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRPayrollID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollMonthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardPayrollMonthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollBankCN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeHRATMCardPayrollStatus;
        private BOSComponent.BOSTextBox fld_txtHRATMCardPayrollNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteHRATMCardPayrollDate;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSDateEdit fld_dteHRATMCardPayrollMonthDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRPayrollID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHRATMCardPayrollBankCN;
    }
}
