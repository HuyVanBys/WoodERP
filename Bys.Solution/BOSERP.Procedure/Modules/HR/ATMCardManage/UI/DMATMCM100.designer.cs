using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ATMCardManage.UI
{
    /// <summary>
    /// Summary description for DMATMCM100
    /// </summary>
    partial class DMATMCM100
    {
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSTextBox fld_txtHRATMCardManageName;
        private BOSComponent.BOSMemoEdit fld_medHRATMCardManageDesc;
        private HREmployeeATMCardManagesGridControl fld_dgcHREmployeeATMCardManages;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeATMCardManages;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMATMCM100));
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRATMCardManageName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRATMCardManageDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgcHREmployeeATMCardManages = new BOSERP.Modules.ATMCardManage.HREmployeeATMCardManagesGridControl();
            this.fld_dgvHREmployeeATMCardManages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRATMCardManageDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRATMCardManageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRATMCardManageStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeATMCardManageStatus = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRATMCardManageDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeATMCardManages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeATMCardManages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardManageDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardManageDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRATMCardManageStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeATMCardManageStatus.Properties)).BeginInit();
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
            // fld_txtHRATMCardManageName
            // 
            this.fld_txtHRATMCardManageName.BOSComment = null;
            this.fld_txtHRATMCardManageName.BOSDataMember = "HRATMCardManageName";
            this.fld_txtHRATMCardManageName.BOSDataSource = "HRATMCardManages";
            this.fld_txtHRATMCardManageName.BOSDescription = null;
            this.fld_txtHRATMCardManageName.BOSError = null;
            this.fld_txtHRATMCardManageName.BOSFieldGroup = null;
            this.fld_txtHRATMCardManageName.BOSFieldRelation = null;
            this.fld_txtHRATMCardManageName.BOSPrivilege = null;
            this.fld_txtHRATMCardManageName.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRATMCardManageName, "fld_txtHRATMCardManageName");
            this.fld_txtHRATMCardManageName.Name = "fld_txtHRATMCardManageName";
            this.fld_txtHRATMCardManageName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRATMCardManageName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRATMCardManageName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRATMCardManageName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRATMCardManageName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRATMCardManageName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRATMCardManageName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardManageName, ((bool)(resources.GetObject("fld_txtHRATMCardManageName.ShowHelp"))));
            this.fld_txtHRATMCardManageName.Tag = "DC";
            // 
            // fld_medHRATMCardManageDesc
            // 
            this.fld_medHRATMCardManageDesc.BOSComment = null;
            this.fld_medHRATMCardManageDesc.BOSDataMember = "HRATMCardManageDesc";
            this.fld_medHRATMCardManageDesc.BOSDataSource = "HRATMCardManages";
            this.fld_medHRATMCardManageDesc.BOSDescription = null;
            this.fld_medHRATMCardManageDesc.BOSError = null;
            this.fld_medHRATMCardManageDesc.BOSFieldGroup = null;
            this.fld_medHRATMCardManageDesc.BOSFieldRelation = null;
            this.fld_medHRATMCardManageDesc.BOSPrivilege = null;
            this.fld_medHRATMCardManageDesc.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_medHRATMCardManageDesc, "fld_medHRATMCardManageDesc");
            this.fld_medHRATMCardManageDesc.Name = "fld_medHRATMCardManageDesc";
            this.fld_medHRATMCardManageDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRATMCardManageDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRATMCardManageDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRATMCardManageDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRATMCardManageDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRATMCardManageDesc, ((bool)(resources.GetObject("fld_medHRATMCardManageDesc.ShowHelp"))));
            this.fld_medHRATMCardManageDesc.Tag = "DC";
            // 
            // fld_dgcHREmployeeATMCardManages
            // 
            this.fld_dgcHREmployeeATMCardManages.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHREmployeeATMCardManages, "fld_dgcHREmployeeATMCardManages");
            this.fld_dgcHREmployeeATMCardManages.BOSComment = null;
            this.fld_dgcHREmployeeATMCardManages.BOSDataMember = null;
            this.fld_dgcHREmployeeATMCardManages.BOSDataSource = "HREmployeeATMCardManages";
            this.fld_dgcHREmployeeATMCardManages.BOSDescription = null;
            this.fld_dgcHREmployeeATMCardManages.BOSError = null;
            this.fld_dgcHREmployeeATMCardManages.BOSFieldGroup = null;
            this.fld_dgcHREmployeeATMCardManages.BOSFieldRelation = null;
            this.fld_dgcHREmployeeATMCardManages.BOSGridType = null;
            this.fld_dgcHREmployeeATMCardManages.BOSPrivilege = null;
            this.fld_dgcHREmployeeATMCardManages.BOSPropertyName = null;
            this.fld_dgcHREmployeeATMCardManages.CommodityType = "";
            this.fld_dgcHREmployeeATMCardManages.MainView = this.fld_dgvHREmployeeATMCardManages;
            this.fld_dgcHREmployeeATMCardManages.Name = "fld_dgcHREmployeeATMCardManages";
            this.fld_dgcHREmployeeATMCardManages.PrintReport = false;
            this.fld_dgcHREmployeeATMCardManages.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeATMCardManages, ((bool)(resources.GetObject("fld_dgcHREmployeeATMCardManages.ShowHelp"))));
            this.fld_dgcHREmployeeATMCardManages.Tag = "DC";
            this.fld_dgcHREmployeeATMCardManages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeATMCardManages});
            // 
            // fld_dgvHREmployeeATMCardManages
            // 
            this.fld_dgvHREmployeeATMCardManages.GridControl = this.fld_dgcHREmployeeATMCardManages;
            this.fld_dgvHREmployeeATMCardManages.Name = "fld_dgvHREmployeeATMCardManages";
            this.fld_dgvHREmployeeATMCardManages.PaintStyleName = "Office2003";
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
            // fld_dteHRATMCardManageDate
            // 
            this.fld_dteHRATMCardManageDate.BOSComment = null;
            this.fld_dteHRATMCardManageDate.BOSDataMember = "HRATMCardManageDate";
            this.fld_dteHRATMCardManageDate.BOSDataSource = "HRATMCardManages";
            this.fld_dteHRATMCardManageDate.BOSDescription = null;
            this.fld_dteHRATMCardManageDate.BOSError = null;
            this.fld_dteHRATMCardManageDate.BOSFieldGroup = null;
            this.fld_dteHRATMCardManageDate.BOSFieldRelation = null;
            this.fld_dteHRATMCardManageDate.BOSPrivilege = null;
            this.fld_dteHRATMCardManageDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHRATMCardManageDate, "fld_dteHRATMCardManageDate");
            this.fld_dteHRATMCardManageDate.Name = "fld_dteHRATMCardManageDate";
            this.fld_dteHRATMCardManageDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRATMCardManageDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRATMCardManageDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRATMCardManageDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRATMCardManageDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRATMCardManageDate.Properties.Buttons"))))});
            this.fld_dteHRATMCardManageDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRATMCardManageDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHRATMCardManageDate, ((bool)(resources.GetObject("fld_dteHRATMCardManageDate.ShowHelp"))));
            this.fld_dteHRATMCardManageDate.Tag = "DC";
            // 
            // fld_txtHRATMCardManageNo
            // 
            this.fld_txtHRATMCardManageNo.BOSComment = null;
            this.fld_txtHRATMCardManageNo.BOSDataMember = "HRATMCardManageNo";
            this.fld_txtHRATMCardManageNo.BOSDataSource = "HRATMCardManages";
            this.fld_txtHRATMCardManageNo.BOSDescription = null;
            this.fld_txtHRATMCardManageNo.BOSError = null;
            this.fld_txtHRATMCardManageNo.BOSFieldGroup = null;
            this.fld_txtHRATMCardManageNo.BOSFieldRelation = null;
            this.fld_txtHRATMCardManageNo.BOSPrivilege = null;
            this.fld_txtHRATMCardManageNo.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRATMCardManageNo, "fld_txtHRATMCardManageNo");
            this.fld_txtHRATMCardManageNo.Name = "fld_txtHRATMCardManageNo";
            this.fld_txtHRATMCardManageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRATMCardManageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRATMCardManageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRATMCardManageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRATMCardManageNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRATMCardManageNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRATMCardManageNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardManageNo, ((bool)(resources.GetObject("fld_txtHRATMCardManageNo.ShowHelp"))));
            this.fld_txtHRATMCardManageNo.Tag = "DC";
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
            // fld_lkeHRATMCardManageStatus
            // 
            this.fld_lkeHRATMCardManageStatus.BOSAllowAddNew = false;
            this.fld_lkeHRATMCardManageStatus.BOSAllowDummy = false;
            this.fld_lkeHRATMCardManageStatus.BOSComment = null;
            this.fld_lkeHRATMCardManageStatus.BOSDataMember = "HRATMCardManageStatus";
            this.fld_lkeHRATMCardManageStatus.BOSDataSource = "HRATMCardManages";
            this.fld_lkeHRATMCardManageStatus.BOSDescription = null;
            this.fld_lkeHRATMCardManageStatus.BOSError = null;
            this.fld_lkeHRATMCardManageStatus.BOSFieldGroup = null;
            this.fld_lkeHRATMCardManageStatus.BOSFieldParent = null;
            this.fld_lkeHRATMCardManageStatus.BOSFieldRelation = null;
            this.fld_lkeHRATMCardManageStatus.BOSPrivilege = null;
            this.fld_lkeHRATMCardManageStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRATMCardManageStatus.BOSSelectType = null;
            this.fld_lkeHRATMCardManageStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRATMCardManageStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHRATMCardManageStatus, "fld_lkeHRATMCardManageStatus");
            this.fld_lkeHRATMCardManageStatus.Name = "fld_lkeHRATMCardManageStatus";
            this.fld_lkeHRATMCardManageStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRATMCardManageStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRATMCardManageStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRATMCardManageStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRATMCardManageStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHRATMCardManageStatus.Properties.Buttons"))))});
            this.fld_lkeHRATMCardManageStatus.Properties.ColumnName = null;
            this.fld_lkeHRATMCardManageStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeHRATMCardManageStatus.Properties.Columns"), resources.GetString("fld_lkeHRATMCardManageStatus.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeHRATMCardManageStatus.Properties.Columns2"), resources.GetString("fld_lkeHRATMCardManageStatus.Properties.Columns3"))});
            this.fld_lkeHRATMCardManageStatus.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeHRATMCardManageStatus.Properties.NullText = resources.GetString("fld_lkeHRATMCardManageStatus.Properties.NullText");
            this.fld_lkeHRATMCardManageStatus.Properties.ReadOnly = true;
            this.fld_lkeHRATMCardManageStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRATMCardManageStatus.Properties.ValueMember = "BRBranchID";
            this.fld_lkeHRATMCardManageStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRATMCardManageStatus, ((bool)(resources.GetObject("fld_lkeHRATMCardManageStatus.ShowHelp"))));
            this.fld_lkeHRATMCardManageStatus.Tag = "DC";
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeATMCardManages);
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
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeATMCardManageStatus);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteHRATMCardManageDate);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_txtHRATMCardManageNo);
            this.bosPanel1.Controls.Add(this.fld_medHRATMCardManageDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeHRATMCardManageStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRATMCardManageName);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // fld_lkeHREmployeeATMCardManageStatus
            // 
            this.fld_lkeHREmployeeATMCardManageStatus.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSAllowDummy = false;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSComment = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSDataMember = "HREmployeeATMCardManageStatus";
            this.fld_lkeHREmployeeATMCardManageStatus.BOSDataSource = "HREmployeeATMCardManages";
            this.fld_lkeHREmployeeATMCardManageStatus.BOSDescription = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSError = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSFieldGroup = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSFieldParent = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSFieldRelation = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSPrivilege = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeATMCardManageStatus.BOSSelectType = null;
            this.fld_lkeHREmployeeATMCardManageStatus.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeATMCardManageStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeATMCardManageStatus, "fld_lkeHREmployeeATMCardManageStatus");
            this.fld_lkeHREmployeeATMCardManageStatus.Name = "fld_lkeHREmployeeATMCardManageStatus";
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeATMCardManageStatus.Properties.Buttons"))))});
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.ColumnName = null;
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeATMCardManageStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeATMCardManageStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeATMCardManageStatus, ((bool)(resources.GetObject("fld_lkeHREmployeeATMCardManageStatus.ShowHelp"))));
            this.fld_lkeHREmployeeATMCardManageStatus.Tag = "DC";
            this.fld_lkeHREmployeeATMCardManageStatus.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeHREmployeeATMCardManageStatus_CloseUp);
            // 
            // DMATMCM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMATMCM100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRATMCardManageDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeATMCardManages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeATMCardManages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardManageDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRATMCardManageDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRATMCardManageStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeATMCardManageStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeHRATMCardManageStatus;
        private BOSComponent.BOSTextBox fld_txtHRATMCardManageNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteHRATMCardManageDate;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeATMCardManageStatus;
        private BOSComponent.BOSLabel bosLabel2;
    }
}
