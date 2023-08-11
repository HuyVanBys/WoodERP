using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseContract.UI
{
	/// <summary>
	/// Summary description for SMPCT100
	/// </summary>
	partial class SMPCT100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
		private BOSSearchResultsGridControl fld_dgcAPPurchaseContracts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseContracts;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseContractNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAPPurchaseContracts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseContracts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromAPPurchaseContractDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToAPPurchaseContractDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseContractDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseContractDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseContractDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.Location = new System.Drawing.Point(35, 35);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.Location = new System.Drawing.Point(35, 61);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.Location = new System.Drawing.Point(35, 85);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Chi nhánh";
            // 
            // fld_txtAPPurchaseContractNo
            // 
            this.fld_txtAPPurchaseContractNo.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractNo.BOSDataMember = "APPurchaseContractNo";
            this.fld_txtAPPurchaseContractNo.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractNo.BOSDescription = null;
            this.fld_txtAPPurchaseContractNo.BOSError = null;
            this.fld_txtAPPurchaseContractNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractNo.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractNo.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractNo.Location = new System.Drawing.Point(148, 32);
            this.fld_txtAPPurchaseContractNo.Name = "fld_txtAPPurchaseContractNo";
            this.fld_txtAPPurchaseContractNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseContractNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractNo.Screen = null;
            this.fld_txtAPPurchaseContractNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseContractNo.TabIndex = 0;
            this.fld_txtAPPurchaseContractNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(148, 58);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(148, 82);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Name")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 2;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_dgcAPPurchaseContracts
            // 
            this.fld_dgcAPPurchaseContracts.AllowDrop = true;
            this.fld_dgcAPPurchaseContracts.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.BOSDataSource = "APPurchaseContracts";
            this.fld_dgcAPPurchaseContracts.BOSDescription = null;
            this.fld_dgcAPPurchaseContracts.BOSError = null;
            this.fld_dgcAPPurchaseContracts.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.BOSGridType = null;
            this.fld_dgcAPPurchaseContracts.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcAPPurchaseContracts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseContracts.Location = new System.Drawing.Point(35, 161);
            this.fld_dgcAPPurchaseContracts.MainView = this.fld_dgvAPPurchaseContracts;
            this.fld_dgcAPPurchaseContracts.Name = "fld_dgcAPPurchaseContracts";
            this.fld_dgcAPPurchaseContracts.PrintReport = false;
            this.fld_dgcAPPurchaseContracts.Screen = null;
            this.fld_dgcAPPurchaseContracts.Size = new System.Drawing.Size(702, 380);
            this.fld_dgcAPPurchaseContracts.TabIndex = 8;
            this.fld_dgcAPPurchaseContracts.Tag = "SR";
            this.fld_dgcAPPurchaseContracts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseContracts});
            // 
            // fld_dgvAPPurchaseContracts
            // 
            this.fld_dgvAPPurchaseContracts.GridControl = this.fld_dgcAPPurchaseContracts;
            this.fld_dgvAPPurchaseContracts.Name = "fld_dgvAPPurchaseContracts";
            this.fld_dgvAPPurchaseContracts.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.Location = new System.Drawing.Point(35, 111);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(86, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Ngày chứng từ từ";
            // 
            // fld_dteSearchFromAPPurchaseContractDate
            // 
            this.fld_dteSearchFromAPPurchaseContractDate.BOSComment = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSDataMember = "PurchaseContractDateFrom";
            this.fld_dteSearchFromAPPurchaseContractDate.BOSDataSource = "APPurchaseContracts";
            this.fld_dteSearchFromAPPurchaseContractDate.BOSDescription = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSError = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPPurchaseContractDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPPurchaseContractDate.EditValue = null;
            this.fld_dteSearchFromAPPurchaseContractDate.Location = new System.Drawing.Point(148, 108);
            this.fld_dteSearchFromAPPurchaseContractDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPPurchaseContractDate.Name = "fld_dteSearchFromAPPurchaseContractDate";
            this.fld_dteSearchFromAPPurchaseContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPPurchaseContractDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPPurchaseContractDate.Screen = null;
            this.fld_dteSearchFromAPPurchaseContractDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPPurchaseContractDate.TabIndex = 3;
            this.fld_dteSearchFromAPPurchaseContractDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.Location = new System.Drawing.Point(320, 111);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // fld_dteSearchToAPPurchaseContractDate
            // 
            this.fld_dteSearchToAPPurchaseContractDate.BOSComment = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSDataMember = "PurchaseContractDateTo";
            this.fld_dteSearchToAPPurchaseContractDate.BOSDataSource = "APPurchaseContracts";
            this.fld_dteSearchToAPPurchaseContractDate.BOSDescription = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSError = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSPrivilege = null;
            this.fld_dteSearchToAPPurchaseContractDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPPurchaseContractDate.EditValue = null;
            this.fld_dteSearchToAPPurchaseContractDate.Location = new System.Drawing.Point(363, 108);
            this.fld_dteSearchToAPPurchaseContractDate.Name = "fld_dteSearchToAPPurchaseContractDate";
            this.fld_dteSearchToAPPurchaseContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPPurchaseContractDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPPurchaseContractDate.Screen = null;
            this.fld_dteSearchToAPPurchaseContractDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPPurchaseContractDate.TabIndex = 4;
            this.fld_dteSearchToAPPurchaseContractDate.Tag = "SC";
            // 
            // SMPCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dteSearchToAPPurchaseContractDate);
            this.Controls.Add(this.fld_dteSearchFromAPPurchaseContractDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtAPPurchaseContractNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_dgcAPPurchaseContracts);
            this.Name = "SMPCT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPPurchaseContracts, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtAPPurchaseContractNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPPurchaseContractDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPPurchaseContractDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseContractDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseContractDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseContractDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPPurchaseContractDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPPurchaseContractDate;
	}
}
