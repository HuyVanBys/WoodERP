using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for SMPN100
	/// </summary>
	partial class SMPN100
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
            this.fld_dgcMMProductionNorms = new BOSERP.Modules.ProductionNorm.ProductionNormsSearchResultGridControl();
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionNormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormVersion = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionNormPromulgateDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionNormPromulgateDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMProductionNormOldProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNorms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOldProductNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMProductionNorms
            // 
            this.fld_dgcMMProductionNorms.AllowDrop = true;
            this.fld_dgcMMProductionNorms.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionNorms.BOSDataMember = null;
            this.fld_dgcMMProductionNorms.BOSDataSource = "MMProductionNorms";
            this.fld_dgcMMProductionNorms.BOSDescription = null;
            this.fld_dgcMMProductionNorms.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionNorms.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionNorms.BOSFieldRelation = null;
            this.fld_dgcMMProductionNorms.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionNorms.BOSPropertyName = null;
            this.fld_dgcMMProductionNorms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMProductionNorms.Location = new System.Drawing.Point(39, 207);
            this.fld_dgcMMProductionNorms.Name = "fld_dgcMMProductionNorms";
            this.fld_dgcMMProductionNorms.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProductionNorms, true);
            this.fld_dgcMMProductionNorms.Size = new System.Drawing.Size(543, 279);
            this.fld_dgcMMProductionNorms.TabIndex = 6;
            this.fld_dgcMMProductionNorms.Tag = "SR";
            this.fld_dgcMMProductionNorms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMProductionNorms;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(39, 54);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 46;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(39, 28);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 47;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_txtMMProductionNormName
            // 
            this.fld_txtMMProductionNormName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormName.BOSDataMember = "MMProductionNormName";
            this.fld_txtMMProductionNormName.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormName.BOSDescription = null;
            this.fld_txtMMProductionNormName.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormName.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormName.Location = new System.Drawing.Point(140, 51);
            this.fld_txtMMProductionNormName.Name = "fld_txtMMProductionNormName";
            this.fld_txtMMProductionNormName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionNormName, true);
            this.fld_txtMMProductionNormName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionNormName.TabIndex = 1;
            this.fld_txtMMProductionNormName.Tag = "SC";
            // 
            // fld_txtMMProductionNormNo
            // 
            this.fld_txtMMProductionNormNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormNo.BOSDataMember = "MMProductionNormNo";
            this.fld_txtMMProductionNormNo.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormNo.BOSDescription = null;
            this.fld_txtMMProductionNormNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormNo.Location = new System.Drawing.Point(140, 25);
            this.fld_txtMMProductionNormNo.Name = "fld_txtMMProductionNormNo";
            this.fld_txtMMProductionNormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionNormNo, true);
            this.fld_txtMMProductionNormNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionNormNo.TabIndex = 0;
            this.fld_txtMMProductionNormNo.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(39, 80);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 48;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(39, 158);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(88, 13);
            this.bosLabel5.TabIndex = 46;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Ngày phát hành từ";
            // 
            // fld_txtMMProductionNormVersion
            // 
            this.fld_txtMMProductionNormVersion.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormVersion.BOSDataMember = "MMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormVersion.BOSDescription = null;
            this.fld_txtMMProductionNormVersion.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormVersion.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormVersion.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormVersion.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormVersion.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormVersion.Location = new System.Drawing.Point(140, 129);
            this.fld_txtMMProductionNormVersion.Name = "fld_txtMMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormVersion.Screen = null;
            this.fld_txtMMProductionNormVersion.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionNormVersion.TabIndex = 6;
            this.fld_txtMMProductionNormVersion.Tag = "SC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(39, 132);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(69, 13);
            this.bosLabel7.TabIndex = 46;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Lần phát hành";
            // 
            // fld_dteMMProductionNormPromulgateDateFrom
            // 
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSDataMember = "MMProductionNormPromulgateDateFrom";
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSDataSource = "MMProductionNorms";
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSDescription = null;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSError = null;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionNormPromulgateDateFrom.EditValue = null;
            this.fld_dteMMProductionNormPromulgateDateFrom.Location = new System.Drawing.Point(140, 155);
            this.fld_dteMMProductionNormPromulgateDateFrom.Name = "fld_dteMMProductionNormPromulgateDateFrom";
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionNormPromulgateDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionNormPromulgateDateFrom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionNormPromulgateDateFrom, true);
            this.fld_dteMMProductionNormPromulgateDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionNormPromulgateDateFrom.TabIndex = 5;
            this.fld_dteMMProductionNormPromulgateDateFrom.Tag = "SC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(140, 77);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 2;
            this.fld_lkeFK_ICProductID.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(309, 158);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(19, 13);
            this.bosLabel6.TabIndex = 46;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "đến";
            // 
            // fld_dteMMProductionNormPromulgateDateTo
            // 
            this.fld_dteMMProductionNormPromulgateDateTo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSDataMember = "MMProductionNormPromulgateDateTo";
            this.fld_dteMMProductionNormPromulgateDateTo.BOSDataSource = "MMProductionNorms";
            this.fld_dteMMProductionNormPromulgateDateTo.BOSDescription = null;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSError = null;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionNormPromulgateDateTo.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionNormPromulgateDateTo.EditValue = null;
            this.fld_dteMMProductionNormPromulgateDateTo.Location = new System.Drawing.Point(334, 155);
            this.fld_dteMMProductionNormPromulgateDateTo.Name = "fld_dteMMProductionNormPromulgateDateTo";
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionNormPromulgateDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionNormPromulgateDateTo.Screen = null;
            this.fld_dteMMProductionNormPromulgateDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionNormPromulgateDateTo.TabIndex = 5;
            this.fld_dteMMProductionNormPromulgateDateTo.Tag = "SC";
            // 
            // fld_txtMMProductionNormOldProductNo
            // 
            this.fld_txtMMProductionNormOldProductNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormOldProductNo.BOSDataMember = "MMProductionNormOldProductNo";
            this.fld_txtMMProductionNormOldProductNo.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormOldProductNo.BOSDescription = null;
            this.fld_txtMMProductionNormOldProductNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormOldProductNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormOldProductNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormOldProductNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionNormOldProductNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormOldProductNo.Location = new System.Drawing.Point(140, 103);
            this.fld_txtMMProductionNormOldProductNo.Name = "fld_txtMMProductionNormOldProductNo";
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormOldProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormOldProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormOldProductNo.Screen = null;
            this.fld_txtMMProductionNormOldProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionNormOldProductNo.TabIndex = 1;
            this.fld_txtMMProductionNormOldProductNo.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(39, 106);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(62, 13);
            this.bosLabel2.TabIndex = 46;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Mã SPHT cũ";
            // 
            // SMPN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(634, 522);
            this.Controls.Add(this.fld_lkeFK_ICProductID);
            this.Controls.Add(this.fld_dteMMProductionNormPromulgateDateTo);
            this.Controls.Add(this.fld_dteMMProductionNormPromulgateDateFrom);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_txtMMProductionNormVersion);
            this.Controls.Add(this.fld_txtMMProductionNormOldProductNo);
            this.Controls.Add(this.fld_txtMMProductionNormName);
            this.Controls.Add(this.fld_txtMMProductionNormNo);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dgcMMProductionNorms);
            this.Name = "SMPN100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMProductionNorms, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionNormNo, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionNormName, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionNormOldProductNo, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionNormVersion, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionNormPromulgateDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionNormPromulgateDateTo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNorms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOldProductNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private ProductionNormsSearchResultGridControl fld_dgcMMProductionNorms;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormName;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormVersion;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteMMProductionNormPromulgateDateFrom;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteMMProductionNormPromulgateDateTo;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormOldProductNo;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
