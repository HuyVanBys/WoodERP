using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.UI
{
	/// <summary>
	/// Summary description for SMII100
	/// </summary>
	partial class SMAIODA100
	{
		private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInNo;
		private BOSComponent.BOSDateEdit fld_dteSearchFromAPInvoiceInDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPInvoiceInDate;


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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPInvoiceIn = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAdjustIncreaseOrDecreaseAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceIn)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.Location = new System.Drawing.Point(20, 48);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel11.TabIndex = 5;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã hóa đơn";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel12.Location = new System.Drawing.Point(19, 74);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel12.TabIndex = 6;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Đối tượng";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.Location = new System.Drawing.Point(20, 126);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 8;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chừng từ từ";
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(308, 126);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 11;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_txtAPInvoiceInNo
            // 
            this.fld_txtAPInvoiceInNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtAPInvoiceInNo.BOSDataMember = "ACAdjustIncreaseOrDecreaseAssetNo";
            this.fld_txtAPInvoiceInNo.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_txtAPInvoiceInNo.BOSDescription = null;
            this.fld_txtAPInvoiceInNo.BOSError = null;
            this.fld_txtAPInvoiceInNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtAPInvoiceInNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtAPInvoiceInNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtAPInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtAPInvoiceInNo.Location = new System.Drawing.Point(135, 45);
            this.fld_txtAPInvoiceInNo.Name = "fld_txtAPInvoiceInNo";
            this.fld_txtAPInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInNo.Screen = null;
            this.fld_txtAPInvoiceInNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPInvoiceInNo.TabIndex = 0;
            this.fld_txtAPInvoiceInNo.Tag = "SC";
            // 
            // fld_dteSearchFromAPInvoiceInDate
            // 
            this.fld_dteSearchFromAPInvoiceInDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataMember = "ACAdjustIODAssetDateFrom";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchFromAPInvoiceInDate.Location = new System.Drawing.Point(135, 123);
            this.fld_dteSearchFromAPInvoiceInDate.Name = "fld_dteSearchFromAPInvoiceInDate";
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPInvoiceInDate.Screen = null;
            this.fld_dteSearchFromAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPInvoiceInDate.TabIndex = 5;
            this.fld_dteSearchFromAPInvoiceInDate.Tag = "SC";
            // 
            // fld_dteSearchToAPInvoiceInDate
            // 
            this.fld_dteSearchToAPInvoiceInDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToAPInvoiceInDate.BOSDataMember = "ACAdjustIODAssetDateTo";
            this.fld_dteSearchToAPInvoiceInDate.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_dteSearchToAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToAPInvoiceInDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToAPInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchToAPInvoiceInDate.Location = new System.Drawing.Point(342, 123);
            this.fld_dteSearchToAPInvoiceInDate.Name = "fld_dteSearchToAPInvoiceInDate";
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToAPInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPInvoiceInDate.Screen = null;
            this.fld_dteSearchToAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPInvoiceInDate.TabIndex = 6;
            this.fld_dteSearchToAPInvoiceInDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.Location = new System.Drawing.Point(20, 100);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 18;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(135, 97);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 4;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(135, 71);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 589;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_dgcACAdjustIncreaseOrDecreaseAsset
            // 
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.AllowDrop = true;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSDescription = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSError = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Location = new System.Drawing.Point(19, 267);
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.MainView = this.fld_dgvAPInvoiceIn;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Name = "fld_dgcACAdjustIncreaseOrDecreaseAsset";
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Screen = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.TabIndex = 590;
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.Tag = "SR";
            this.fld_dgcACAdjustIncreaseOrDecreaseAsset.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPInvoiceIn});
            // 
            // fld_dgvAPInvoiceIn
            // 
            this.fld_dgvAPInvoiceIn.GridControl = this.fld_dgcACAdjustIncreaseOrDecreaseAsset;
            this.fld_dgvAPInvoiceIn.Name = "fld_dgvAPInvoiceIn";
            this.fld_dgvAPInvoiceIn.PaintStyleName = "Office2003";
            // 
            // SMAIODA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcACAdjustIncreaseOrDecreaseAsset);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_txtAPInvoiceInNo);
            this.Controls.Add(this.fld_dteSearchFromAPInvoiceInDate);
            this.Controls.Add(this.fld_dteSearchToAPInvoiceInDate);
            this.Name = "SMAIODA100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToAPInvoiceInDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPInvoiceInDate, 0);
            this.Controls.SetChildIndex(this.fld_txtAPInvoiceInNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_dgcACAdjustIncreaseOrDecreaseAsset, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAdjustIncreaseOrDecreaseAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSSearchResultsGridControl fld_dgcACAdjustIncreaseOrDecreaseAsset;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPInvoiceIn;
	}
}
