using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.StopDepreciationAsset.UI
{
	/// <summary>
	/// Summary description for SMNKH100
	/// </summary>
	partial class SMNKH100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtACStopDepreciationAssetNo;


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
            this.fld_txtACStopDepreciationAssetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACStopDepreciationAssetStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACStopDepreciationAssetFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACStopDepreciationAssets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAssetID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACStopDepreciationAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtACStopDepreciationAssetNo
            // 
            this.fld_txtACStopDepreciationAssetNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopDepreciationAssetNo.BOSDataMember = "ACStopDepreciationAssetNo";
            this.fld_txtACStopDepreciationAssetNo.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_txtACStopDepreciationAssetNo.BOSDescription = null;
            this.fld_txtACStopDepreciationAssetNo.BOSError = null;
            this.fld_txtACStopDepreciationAssetNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopDepreciationAssetNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopDepreciationAssetNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopDepreciationAssetNo.BOSPropertyName = "Text";
            this.fld_txtACStopDepreciationAssetNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopDepreciationAssetNo.Location = new System.Drawing.Point(166, 27);
            this.fld_txtACStopDepreciationAssetNo.Name = "fld_txtACStopDepreciationAssetNo";
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopDepreciationAssetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopDepreciationAssetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopDepreciationAssetNo.Screen = null;
            this.fld_txtACStopDepreciationAssetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACStopDepreciationAssetNo.TabIndex = 0;
            this.fld_txtACStopDepreciationAssetNo.Tag = "SC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.Location = new System.Drawing.Point(34, 82);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Từ ngày";
            // 
            // fld_dteACStopDepreciationAssetStartDate
            // 
            this.fld_dteACStopDepreciationAssetStartDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetStartDate.BOSDataMember = "ACStopDepreciationAssetStartDate";
            this.fld_dteACStopDepreciationAssetStartDate.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_dteACStopDepreciationAssetStartDate.BOSDescription = null;
            this.fld_dteACStopDepreciationAssetStartDate.BOSError = null;
            this.fld_dteACStopDepreciationAssetStartDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetStartDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetStartDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetStartDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopDepreciationAssetStartDate.EditValue = null;
            this.fld_dteACStopDepreciationAssetStartDate.Location = new System.Drawing.Point(166, 79);
            this.fld_dteACStopDepreciationAssetStartDate.Name = "fld_dteACStopDepreciationAssetStartDate";
            this.fld_dteACStopDepreciationAssetStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopDepreciationAssetStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopDepreciationAssetStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopDepreciationAssetStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopDepreciationAssetStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopDepreciationAssetStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopDepreciationAssetStartDate.Screen = null;
            this.fld_dteACStopDepreciationAssetStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACStopDepreciationAssetStartDate.TabIndex = 2;
            this.fld_dteACStopDepreciationAssetStartDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Location = new System.Drawing.Point(34, 108);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteACStopDepreciationAssetFinishedDate
            // 
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSDataMember = "ACStopDepreciationAssetFinishedDate";
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSDescription = null;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSError = null;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopDepreciationAssetFinishedDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopDepreciationAssetFinishedDate.EditValue = null;
            this.fld_dteACStopDepreciationAssetFinishedDate.Location = new System.Drawing.Point(166, 105);
            this.fld_dteACStopDepreciationAssetFinishedDate.Name = "fld_dteACStopDepreciationAssetFinishedDate";
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopDepreciationAssetFinishedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopDepreciationAssetFinishedDate.Screen = null;
            this.fld_dteACStopDepreciationAssetFinishedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACStopDepreciationAssetFinishedDate.TabIndex = 3;
            this.fld_dteACStopDepreciationAssetFinishedDate.Tag = "SC";
            // 
            // fld_dgcACStopDepreciationAssets
            // 
            this.fld_dgcACStopDepreciationAssets.BOSComment = null;
            this.fld_dgcACStopDepreciationAssets.BOSDataMember = null;
            this.fld_dgcACStopDepreciationAssets.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_dgcACStopDepreciationAssets.BOSDescription = null;
            this.fld_dgcACStopDepreciationAssets.BOSError = null;
            this.fld_dgcACStopDepreciationAssets.BOSFieldGroup = null;
            this.fld_dgcACStopDepreciationAssets.BOSFieldRelation = null;
            this.fld_dgcACStopDepreciationAssets.BOSPrivilege = null;
            this.fld_dgcACStopDepreciationAssets.BOSPropertyName = null;
            this.fld_dgcACStopDepreciationAssets.Location = new System.Drawing.Point(34, 178);
            this.fld_dgcACStopDepreciationAssets.MenuManager = this.screenToolbar;
            this.fld_dgcACStopDepreciationAssets.Name = "fld_dgcACStopDepreciationAssets";
            this.fld_dgcACStopDepreciationAssets.Screen = null;
            this.fld_dgcACStopDepreciationAssets.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACStopDepreciationAssets.TabIndex = 11;
            this.fld_dgcACStopDepreciationAssets.Tag = "SR";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.Location = new System.Drawing.Point(34, 56);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 23;
            this.bosLabel12.Tag = "SI";
            this.bosLabel12.Text = "Số thẻ TSCĐ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Location = new System.Drawing.Point(34, 134);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 28;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACStopDepreciationAssets";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(166, 131);
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
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lkeFK_ACAssetID
            // 
            this.fld_lkeFK_ACAssetID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssetID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAssetID.BOSComment = null;
            this.fld_lkeFK_ACAssetID.BOSDataMember = "FK_ACAssetID";
            this.fld_lkeFK_ACAssetID.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_lkeFK_ACAssetID.BOSDescription = null;
            this.fld_lkeFK_ACAssetID.BOSError = null;
            this.fld_lkeFK_ACAssetID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssetID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssetID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssetID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssetID.BOSSelectType = null;
            this.fld_lkeFK_ACAssetID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAssetID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssetID.Location = new System.Drawing.Point(166, 53);
            this.fld_lkeFK_ACAssetID.Name = "fld_lkeFK_ACAssetID";
            this.fld_lkeFK_ACAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã TSCĐ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên TSCĐ")});
            this.fld_lkeFK_ACAssetID.Properties.DisplayMember = "ACAssetNo";
            this.fld_lkeFK_ACAssetID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACAssetID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeFK_ACAssetID.Screen = null;
            this.fld_lkeFK_ACAssetID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAssetID.TabIndex = 1;
            this.fld_lkeFK_ACAssetID.Tag = "SC";
            // 
            // SMNKH100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(599, 567);
            this.Controls.Add(this.fld_lkeFK_ACAssetID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel12);
            this.Controls.Add(this.fld_dgcACStopDepreciationAssets);
            this.Controls.Add(this.fld_dteACStopDepreciationAssetFinishedDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteACStopDepreciationAssetStartDate);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtACStopDepreciationAssetNo);
            this.Name = "SMNKH100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACStopDepreciationAssetNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteACStopDepreciationAssetStartDate, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteACStopDepreciationAssetFinishedDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcACStopDepreciationAssets, 0);
            this.Controls.SetChildIndex(this.bosLabel12, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACAssetID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopDepreciationAssetFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACStopDepreciationAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACStopDepreciationAssetStartDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACStopDepreciationAssetFinishedDate;
        private BOSSearchResultsGridControl fld_dgcACStopDepreciationAssets;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAssetID;
	}
}
