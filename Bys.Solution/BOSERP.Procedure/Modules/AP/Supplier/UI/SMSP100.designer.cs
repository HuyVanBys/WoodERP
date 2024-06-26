using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Supplier.UI
{
	/// <summary>
	/// Summary description for SMSP100
	/// </summary>
	partial class SMSP100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
		private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtAPSupplierName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcAPSupplier;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPSupplier;
		private BOSComponent.BOSLookupEdit fld_lkeAPSupplierTypeCombo1;
		private BOSComponent.BOSLabel fld_lblLabel31;
        private BOSComponent.BOSTextBox fld_txtAPSupplierNo;


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
            this.fld_lblLabel53 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel57 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPSupplier = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeAPSupplierTypeCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressLine3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel53
            // 
            this.fld_lblLabel53.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel53.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel53.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel53.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel53.Appearance.Options.UseFont = true;
            this.fld_lblLabel53.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel53.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.Location = new System.Drawing.Point(38, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã nhà cung cấp";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.Location = new System.Drawing.Point(38, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(88, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên nhà cung cấp";
            // 
            // fld_txtAPSupplierName
            // 
            this.fld_txtAPSupplierName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierName.BOSDataMember = "APSupplierName";
            this.fld_txtAPSupplierName.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierName.BOSDescription = null;
            this.fld_txtAPSupplierName.BOSError = null;
            this.fld_txtAPSupplierName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierName.BOSPropertyName = "Text";
            this.fld_txtAPSupplierName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierName.Location = new System.Drawing.Point(156, 35);
            this.fld_txtAPSupplierName.Name = "fld_txtAPSupplierName";
            this.fld_txtAPSupplierName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierName.Screen = null;
            this.fld_txtAPSupplierName.Size = new System.Drawing.Size(316, 20);
            this.fld_txtAPSupplierName.TabIndex = 2;
            this.fld_txtAPSupplierName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 85);
            this.fld_lblLabel51.Name = "fld_lblLabel51";
            this.fld_lblLabel51.Screen = null;
            this.fld_lblLabel51.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel51.TabIndex = 65;
            this.fld_lblLabel51.Tag = "SI";
            // 
            // fld_lblLabel58
            // 
            this.fld_lblLabel58.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel58.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel58.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel58.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel58.Appearance.Options.UseFont = true;
            this.fld_lblLabel58.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel58.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcAPSupplier
            // 
            this.fld_dgcAPSupplier.AllowDrop = true;
            this.fld_dgcAPSupplier.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.BOSDataSource = "APSuppliers";
            this.fld_dgcAPSupplier.BOSDescription = null;
            this.fld_dgcAPSupplier.BOSError = null;
            this.fld_dgcAPSupplier.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcAPSupplier.Location = new System.Drawing.Point(28, 185);
            this.fld_dgcAPSupplier.MainView = this.fld_dgvAPSupplier;
            this.fld_dgcAPSupplier.Name = "fld_dgcAPSupplier";
            this.fld_dgcAPSupplier.Screen = null;
            this.fld_dgcAPSupplier.Size = new System.Drawing.Size(494, 320);
            this.fld_dgcAPSupplier.TabIndex = 67;
            this.fld_dgcAPSupplier.Tag = "SR";
            this.fld_dgcAPSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPSupplier});
            // 
            // fld_dgvAPSupplier
            // 
            this.fld_dgvAPSupplier.GridControl = this.fld_dgcAPSupplier;
            this.fld_dgvAPSupplier.Name = "fld_dgvAPSupplier";
            this.fld_dgvAPSupplier.PaintStyleName = "Office2003";
            // 
            // fld_lkeAPSupplierTypeCombo1
            // 
            this.fld_lkeAPSupplierTypeCombo1.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierTypeCombo1.BOSAllowDummy = true;
            this.fld_lkeAPSupplierTypeCombo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSDataMember = "APSupplierTypeCombo";
            this.fld_lkeAPSupplierTypeCombo1.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierTypeCombo1.BOSDescription = null;
            this.fld_lkeAPSupplierTypeCombo1.BOSError = null;
            this.fld_lkeAPSupplierTypeCombo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierTypeCombo1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.CurrentDisplayText = null;
            this.fld_lkeAPSupplierTypeCombo1.Location = new System.Drawing.Point(156, 61);
            this.fld_lkeAPSupplierTypeCombo1.Name = "fld_lkeAPSupplierTypeCombo1";
            this.fld_lkeAPSupplierTypeCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierTypeCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierTypeCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierTypeCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierTypeCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierTypeCombo1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierTypeCombo1.Screen = null;
            this.fld_lkeAPSupplierTypeCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPSupplierTypeCombo1.TabIndex = 3;
            this.fld_lkeAPSupplierTypeCombo1.Tag = "SC";
            // 
            // fld_lblLabel31
            // 
            this.fld_lblLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel31.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel31.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel31.Appearance.Options.UseFont = true;
            this.fld_lblLabel31.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel31.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDescription = null;
            this.fld_lblLabel31.BOSError = null;
            this.fld_lblLabel31.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.Location = new System.Drawing.Point(38, 64);
            this.fld_lblLabel31.Name = "fld_lblLabel31";
            this.fld_lblLabel31.Screen = null;
            this.fld_lblLabel31.Size = new System.Drawing.Size(89, 13);
            this.fld_lblLabel31.TabIndex = 78;
            this.fld_lblLabel31.Tag = "SI";
            this.fld_lblLabel31.Text = "Loại nhà cung cấp";
            // 
            // fld_txtAPSupplierNo
            // 
            this.fld_txtAPSupplierNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierNo.BOSDataMember = "APSupplierNo";
            this.fld_txtAPSupplierNo.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierNo.BOSDescription = null;
            this.fld_txtAPSupplierNo.BOSError = null;
            this.fld_txtAPSupplierNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierNo.BOSPropertyName = "Text";
            this.fld_txtAPSupplierNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierNo.Location = new System.Drawing.Point(156, 9);
            this.fld_txtAPSupplierNo.Name = "fld_txtAPSupplierNo";
            this.fld_txtAPSupplierNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierNo.Screen = null;
            this.fld_txtAPSupplierNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierNo.TabIndex = 1;
            this.fld_txtAPSupplierNo.Tag = "SC";
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
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(38, 90);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 78;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Điện thoại";
            // 
            // fld_txtAPSupplierContactPhone
            // 
            this.fld_txtAPSupplierContactPhone.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactPhone.BOSDataMember = "APSupplierContactPhone";
            this.fld_txtAPSupplierContactPhone.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactPhone.BOSDescription = null;
            this.fld_txtAPSupplierContactPhone.BOSError = null;
            this.fld_txtAPSupplierContactPhone.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactPhone.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactPhone.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactPhone.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactPhone.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactPhone.Location = new System.Drawing.Point(156, 87);
            this.fld_txtAPSupplierContactPhone.Name = "fld_txtAPSupplierContactPhone";
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactPhone.Screen = null;
            this.fld_txtAPSupplierContactPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierContactPhone.TabIndex = 4;
            this.fld_txtAPSupplierContactPhone.Tag = "SC";
            // 
            // fld_txtAPSupplierContactAddressLine3
            // 
            this.fld_txtAPSupplierContactAddressLine3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactAddressLine3.BOSDataMember = "APSupplierContactAddressLine3";
            this.fld_txtAPSupplierContactAddressLine3.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactAddressLine3.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressLine3.BOSError = null;
            this.fld_txtAPSupplierContactAddressLine3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactAddressLine3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactAddressLine3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactAddressLine3.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressLine3.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPSupplierContactAddressLine3.Location = new System.Drawing.Point(156, 113);
            this.fld_txtAPSupplierContactAddressLine3.Name = "fld_txtAPSupplierContactAddressLine3";
            this.fld_txtAPSupplierContactAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressLine3.Screen = null;
            this.fld_txtAPSupplierContactAddressLine3.Size = new System.Drawing.Size(316, 20);
            this.fld_txtAPSupplierContactAddressLine3.TabIndex = 5;
            this.fld_txtAPSupplierContactAddressLine3.Tag = "SC";
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
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(38, 116);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 78;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Địa chỉ";
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
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(38, 142);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(156, 139);
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
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 79;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // SMSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_dgcAPSupplier);
            this.Controls.Add(this.fld_txtAPSupplierName);
            this.Controls.Add(this.fld_txtAPSupplierNo);
            this.Controls.Add(this.fld_txtAPSupplierContactAddressLine3);
            this.Controls.Add(this.fld_lblLabel31);
            this.Controls.Add(this.fld_txtAPSupplierContactPhone);
            this.Controls.Add(this.fld_lkeAPSupplierTypeCombo1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Name = "SMSP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPSupplierTypeCombo1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPSupplierContactPhone, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel31, 0);
            this.Controls.SetChildIndex(this.fld_txtAPSupplierContactAddressLine3, 0);
            this.Controls.SetChildIndex(this.fld_txtAPSupplierNo, 0);
            this.Controls.SetChildIndex(this.fld_txtAPSupplierName, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPSupplier, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressLine3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactPhone;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressLine3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
	}
}
