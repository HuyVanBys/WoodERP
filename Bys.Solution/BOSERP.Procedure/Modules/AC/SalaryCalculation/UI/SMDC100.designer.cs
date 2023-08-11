using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SalaryCalculation.UI
{
	/// <summary>
	/// Summary description for SMDC100
	/// </summary>
	partial class SMDC100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSSearchResultsGridControl fld_dgcACSalaryCalculation;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocument;
        private BOSComponent.BOSTextBox fld_txtACSalaryCalculationNo;


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
            this.fld_dgcACSalaryCalculation = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvACDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACSalaryCalculationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_Lablel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromACSalaryCalculationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToACSalaryCalculationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSalaryCalculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACSalaryCalculationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACSalaryCalculationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACSalaryCalculationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACSalaryCalculationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.Location = new System.Drawing.Point(14, 28);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 0;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_dgcACSalaryCalculation
            // 
            this.fld_dgcACSalaryCalculation.AllowDrop = true;
            this.fld_dgcACSalaryCalculation.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.BOSDataSource = "ACSalaryCalculations";
            this.fld_dgcACSalaryCalculation.BOSDescription = null;
            this.fld_dgcACSalaryCalculation.BOSError = null;
            this.fld_dgcACSalaryCalculation.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACSalaryCalculation.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACSalaryCalculation.Location = new System.Drawing.Point(12, 164);
            this.fld_dgcACSalaryCalculation.MainView = this.fld_dgvACDocument;
            this.fld_dgcACSalaryCalculation.Name = "fld_dgcACSalaryCalculation";
            this.fld_dgcACSalaryCalculation.Screen = null;
            this.fld_dgcACSalaryCalculation.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACSalaryCalculation.TabIndex = 6;
            this.fld_dgcACSalaryCalculation.Tag = "SR";
            this.fld_dgcACSalaryCalculation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocument});
            // 
            // fld_dgvACDocument
            // 
            this.fld_dgvACDocument.GridControl = this.fld_dgcACSalaryCalculation;
            this.fld_dgvACDocument.Name = "fld_dgvACDocument";
            this.fld_dgvACDocument.PaintStyleName = "Office2003";
            // 
            // fld_txtACSalaryCalculationNo
            // 
            this.fld_txtACSalaryCalculationNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACSalaryCalculationNo.BOSDataMember = "ACSalaryCalculationNo";
            this.fld_txtACSalaryCalculationNo.BOSDataSource = "ACSalaryCalculations";
            this.fld_txtACSalaryCalculationNo.BOSDescription = null;
            this.fld_txtACSalaryCalculationNo.BOSError = null;
            this.fld_txtACSalaryCalculationNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACSalaryCalculationNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACSalaryCalculationNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACSalaryCalculationNo.BOSPropertyName = "Text";
            this.fld_txtACSalaryCalculationNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACSalaryCalculationNo.Location = new System.Drawing.Point(136, 25);
            this.fld_txtACSalaryCalculationNo.Name = "fld_txtACSalaryCalculationNo";
            this.fld_txtACSalaryCalculationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSalaryCalculationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSalaryCalculationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSalaryCalculationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSalaryCalculationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSalaryCalculationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSalaryCalculationNo.Screen = null;
            this.fld_txtACSalaryCalculationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSalaryCalculationNo.TabIndex = 0;
            this.fld_txtACSalaryCalculationNo.Tag = "SC";
            // 
            // fld_Lablel4
            // 
            this.fld_Lablel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.Options.UseBackColor = true;
            this.fld_Lablel4.Appearance.Options.UseForeColor = true;
            this.fld_Lablel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSDescription = null;
            this.fld_Lablel4.BOSError = null;
            this.fld_Lablel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_Lablel4.Location = new System.Drawing.Point(14, 80);
            this.fld_Lablel4.Name = "fld_Lablel4";
            this.fld_Lablel4.Screen = null;
            this.fld_Lablel4.Size = new System.Drawing.Size(86, 13);
            this.fld_Lablel4.TabIndex = 2;
            this.fld_Lablel4.Tag = "SI";
            this.fld_Lablel4.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.Location = new System.Drawing.Point(313, 80);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(23, 13);
            this.fld_lblLabel17.TabIndex = 4;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ";
            // 
            // fld_dteSearchFromACSalaryCalculationDate
            // 
            this.fld_dteSearchFromACSalaryCalculationDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSDataMember = "SalaryCalculationDateFrom";
            this.fld_dteSearchFromACSalaryCalculationDate.BOSDataSource = "ACSalaryCalculations";
            this.fld_dteSearchFromACSalaryCalculationDate.BOSDescription = null;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSError = null;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromACSalaryCalculationDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromACSalaryCalculationDate.EditValue = null;
            this.fld_dteSearchFromACSalaryCalculationDate.Location = new System.Drawing.Point(136, 77);
            this.fld_dteSearchFromACSalaryCalculationDate.Name = "fld_dteSearchFromACSalaryCalculationDate";
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromACSalaryCalculationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromACSalaryCalculationDate.Screen = null;
            this.fld_dteSearchFromACSalaryCalculationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromACSalaryCalculationDate.TabIndex = 2;
            this.fld_dteSearchFromACSalaryCalculationDate.Tag = "SC";
            // 
            // fld_dteSearchToACSalaryCalculationDate
            // 
            this.fld_dteSearchToACSalaryCalculationDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToACSalaryCalculationDate.BOSDataMember = "SalaryCalculationDateTo";
            this.fld_dteSearchToACSalaryCalculationDate.BOSDataSource = "SalaryCalculations";
            this.fld_dteSearchToACSalaryCalculationDate.BOSDescription = null;
            this.fld_dteSearchToACSalaryCalculationDate.BOSError = null;
            this.fld_dteSearchToACSalaryCalculationDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToACSalaryCalculationDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToACSalaryCalculationDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToACSalaryCalculationDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToACSalaryCalculationDate.EditValue = null;
            this.fld_dteSearchToACSalaryCalculationDate.Location = new System.Drawing.Point(352, 77);
            this.fld_dteSearchToACSalaryCalculationDate.Name = "fld_dteSearchToACSalaryCalculationDate";
            this.fld_dteSearchToACSalaryCalculationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToACSalaryCalculationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToACSalaryCalculationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToACSalaryCalculationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToACSalaryCalculationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToACSalaryCalculationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToACSalaryCalculationDate.Screen = null;
            this.fld_dteSearchToACSalaryCalculationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToACSalaryCalculationDate.TabIndex = 3;
            this.fld_dteSearchToACSalaryCalculationDate.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Location = new System.Drawing.Point(14, 54);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "SalaryCalculations";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(136, 51);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 1;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_Lablel4);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchFromACSalaryCalculationDate);
            this.Controls.Add(this.fld_dteSearchToACSalaryCalculationDate);
            this.Controls.Add(this.fld_dgcACSalaryCalculation);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtACSalaryCalculationNo);
            this.Name = "SMDC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACSalaryCalculationNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcACSalaryCalculation, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToACSalaryCalculationDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromACSalaryCalculationDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_Lablel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSalaryCalculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACSalaryCalculationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACSalaryCalculationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACSalaryCalculationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACSalaryCalculationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_Lablel4;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchFromACSalaryCalculationDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToACSalaryCalculationDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
