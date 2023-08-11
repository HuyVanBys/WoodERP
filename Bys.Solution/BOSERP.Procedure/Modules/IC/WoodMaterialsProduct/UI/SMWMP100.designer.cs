using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WoodMaterialsProduct.UI
{
	/// <summary>
	/// Summary description for SMWMP100
	/// </summary>
	partial class SMWMP100
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
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bteICProductGroupName1 = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICProduct = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductDesc = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteICProductGroupName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = true;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "ICProductType";
            this.fld_lkeICProductType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductType.BOSDescription = null;
            this.fld_lkeICProductType.BOSError = null;
            this.fld_lkeICProductType.BOSFieldGroup = null;
            this.fld_lkeICProductType.BOSFieldParent = null;
            this.fld_lkeICProductType.BOSFieldRelation = null;
            this.fld_lkeICProductType.BOSPrivilege = null;
            this.fld_lkeICProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductType.BOSSelectType = null;
            this.fld_lkeICProductType.BOSSelectTypeValue = null;
            this.fld_lkeICProductType.CurrentDisplayText = null;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(117, 54);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductType, true);
            this.fld_lkeICProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductType.TabIndex = 46;
            this.fld_lkeICProductType.Tag = "SC";
            // 
            // fld_bteICProductGroupName1
            // 
            this.fld_bteICProductGroupName1.BOSComment = null;
            this.fld_bteICProductGroupName1.BOSDataMember = "ICProductGroupName";
            this.fld_bteICProductGroupName1.BOSDataSource = "ICProducts";
            this.fld_bteICProductGroupName1.BOSDescription = null;
            this.fld_bteICProductGroupName1.BOSError = null;
            this.fld_bteICProductGroupName1.BOSFieldGroup = null;
            this.fld_bteICProductGroupName1.BOSFieldRelation = null;
            this.fld_bteICProductGroupName1.BOSPrivilege = null;
            this.fld_bteICProductGroupName1.BOSPropertyName = "Text";
            this.fld_bteICProductGroupName1.Location = new System.Drawing.Point(117, 132);
            this.fld_bteICProductGroupName1.MenuManager = this.screenToolbar;
            this.fld_bteICProductGroupName1.Name = "fld_bteICProductGroupName1";
            this.fld_bteICProductGroupName1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteICProductGroupName1.Properties.ReadOnly = true;
            this.fld_bteICProductGroupName1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bteICProductGroupName1, true);
            this.fld_bteICProductGroupName1.Size = new System.Drawing.Size(150, 20);
            this.fld_bteICProductGroupName1.TabIndex = 53;
            this.fld_bteICProductGroupName1.Tag = "SC";
            this.fld_bteICProductGroupName1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bteICProductGroupName1_ButtonClick);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(12, 83);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 49;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Mô tả";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 31);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(89, 13);
            this.bosLabel1.TabIndex = 48;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã sản phẩm NCC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 5);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel4.TabIndex = 51;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã sản phẩm";
            // 
            // fld_dgcICProduct
            // 
            this.fld_dgcICProduct.AllowDrop = true;
            this.fld_dgcICProduct.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProduct.BOSDataMember = null;
            this.fld_dgcICProduct.BOSDataSource = "ICProducts";
            this.fld_dgcICProduct.BOSDescription = null;
            this.fld_dgcICProduct.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProduct.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProduct.BOSFieldRelation = null;
            this.fld_dgcICProduct.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProduct.BOSPropertyName = null;
            this.fld_dgcICProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICProduct.Location = new System.Drawing.Point(12, 184);
            this.fld_dgcICProduct.MainView = this.fld_dgvICProduct;
            this.fld_dgcICProduct.Name = "fld_dgcICProduct";
            this.fld_dgcICProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProduct, true);
            this.fld_dgcICProduct.Size = new System.Drawing.Size(495, 265);
            this.fld_dgcICProduct.TabIndex = 52;
            this.fld_dgcICProduct.Tag = "SR";
            this.fld_dgcICProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcICProduct;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseFont = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(12, 135);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel5, true);
            this.fld_lblLabel5.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel5.TabIndex = 55;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Nhóm hàng";
            // 
            // fld_txtICProductDesc
            // 
            this.fld_txtICProductDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductDesc.BOSDataMember = "ICProductDesc";
            this.fld_txtICProductDesc.BOSDataSource = "ICProducts";
            this.fld_txtICProductDesc.BOSDescription = null;
            this.fld_txtICProductDesc.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductDesc.BOSPropertyName = "Text";
            this.fld_txtICProductDesc.Location = new System.Drawing.Point(117, 80);
            this.fld_txtICProductDesc.Name = "fld_txtICProductDesc";
            this.fld_txtICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDesc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductDesc, true);
            this.fld_txtICProductDesc.Size = new System.Drawing.Size(351, 20);
            this.fld_txtICProductDesc.TabIndex = 47;
            this.fld_txtICProductDesc.Tag = "SC";
            // 
            // fld_txtICProductSupplierNumber
            // 
            this.fld_txtICProductSupplierNumber.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierNumber.BOSDataMember = "ICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.BOSDataSource = "ICProducts";
            this.fld_txtICProductSupplierNumber.BOSDescription = null;
            this.fld_txtICProductSupplierNumber.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierNumber.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierNumber.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierNumber.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierNumber.BOSPropertyName = "Text";
            this.fld_txtICProductSupplierNumber.Location = new System.Drawing.Point(117, 28);
            this.fld_txtICProductSupplierNumber.Name = "fld_txtICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductSupplierNumber, true);
            this.fld_txtICProductSupplierNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductSupplierNumber.TabIndex = 45;
            this.fld_txtICProductSupplierNumber.Tag = "SC";
            // 
            // fld_txtICProductNo1
            // 
            this.fld_txtICProductNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo1.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo1.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo1.BOSDescription = null;
            this.fld_txtICProductNo1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo1.BOSPropertyName = "Text";
            this.fld_txtICProductNo1.Location = new System.Drawing.Point(117, 2);
            this.fld_txtICProductNo1.Name = "fld_txtICProductNo1";
            this.fld_txtICProductNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNo1, true);
            this.fld_txtICProductNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo1.TabIndex = 44;
            this.fld_txtICProductNo1.Tag = "SC";
            // 
            // fld_lkeFK_APSupplierID1
            // 
            this.fld_lkeFK_APSupplierID1.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID1.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID1.BOSDataSource = "ICProducts";
            this.fld_lkeFK_APSupplierID1.BOSDescription = null;
            this.fld_lkeFK_APSupplierID1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.Location = new System.Drawing.Point(117, 158);
            this.fld_lkeFK_APSupplierID1.Name = "fld_lkeFK_APSupplierID1";
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID1.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID1.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_APSupplierID1, true);
            this.fld_lkeFK_APSupplierID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID1.TabIndex = 54;
            this.fld_lkeFK_APSupplierID1.Tag = "SC";
            // 
            // fld_lkeFK_ICDepartmentID
            // 
            this.fld_lkeFK_ICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ICDepartmentID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSDataMember = "FK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICDepartmentID.BOSDescription = null;
            this.fld_lkeFK_ICDepartmentID.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICDepartmentID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.Location = new System.Drawing.Point(117, 106);
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Name")});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICDepartmentID, true);
            this.fld_lkeFK_ICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICDepartmentID.TabIndex = 50;
            this.fld_lkeFK_ICDepartmentID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 57);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(69, 13);
            this.bosLabel3.TabIndex = 57;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Loại sản phẩm";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseFont = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 161);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel6, true);
            this.fld_lblLabel6.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel6.TabIndex = 56;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Nhà cung cấp";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseFont = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(12, 109);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel7, true);
            this.fld_lblLabel7.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel7.TabIndex = 58;
            this.fld_lblLabel7.Tag = "SI";
            this.fld_lblLabel7.Text = "Ngành hàng";
            // 
            // SMWMP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(518, 479);
            this.Controls.Add(this.fld_lkeICProductType);
            this.Controls.Add(this.fld_bteICProductGroupName1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dgcICProduct);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtICProductDesc);
            this.Controls.Add(this.fld_txtICProductSupplierNumber);
            this.Controls.Add(this.fld_txtICProductNo1);
            this.Controls.Add(this.fld_lkeFK_APSupplierID1);
            this.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_lblLabel7);
            this.Name = "SMWMP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID1, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductNo1, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductSupplierNumber, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductDesc, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProduct, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_bteICProductGroupName1, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteICProductGroupName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSButtonEdit fld_bteICProductGroupName1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSSearchResultsGridControl fld_dgcICProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtICProductDesc;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierNumber;
        private BOSComponent.BOSTextBox fld_txtICProductNo1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
	}
}
